using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tethering_Reverse_Easy_Start_Progam.Helpers;

namespace Tethering_Reverse_Easy_Start_Progam.Services
{
    internal class GnirehtetService
    {
        private readonly string _gnirehtetPath;
        private Process _process;

        public GnirehtetService(string gnirehtetPath)
        {
            _gnirehtetPath = gnirehtetPath;
        }

        public string Instalar()
        {
            // executa "gnirehtet install" dentro da pasta de trabalho
            string resultado = CmdHelper.Run("gnirehtet install", _gnirehtetPath);
            return resultado;
        }
        public string RodarComTratamento()
        {
            string output = RunGnirehtetRun();

            if (output.Contains("os error 10048") || output.Contains("address already in use"))
            {
                // Porta está ocupada, mata processo antigo e tenta novamente
                KillGnirehtetProcess();
                output = RunGnirehtetRun();
            }

            return output;
        }

        private string RunGnirehtetRun()
        {
            var psi = new ProcessStartInfo("cmd.exe", "/c gnirehtet run")
            {
                WorkingDirectory = _gnirehtetPath,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process proc = null;
            try
            {
                proc = Process.Start(psi);
                if (proc == null)
                    throw new InvalidOperationException("Falha ao iniciar processo.");

                // Leia as saídas antes de esperar o processo sair para evitar deadlock
                string output = proc.StandardOutput.ReadToEnd();
                string error = proc.StandardError.ReadToEnd();

                proc.WaitForExit();

                return output + error;
            }
            finally
            {
                if (proc != null)
                    proc.Dispose();
            }
        }


        public void KillGnirehtetProcess()
        {
            try
            {
                foreach (var proc in Process.GetProcessesByName("gnirehtet"))
                {
                    proc.Kill();
                    proc.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao matar processo gnirehtet:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Parar()
        {
            try
            {
                if (_process != null && !_process.HasExited)
                {
                    _process.Kill();
                    _process.Dispose();
                    _process = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao parar processo gnirehtet:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
