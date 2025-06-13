using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tethering_Reverse_Easy_Start_Progam.Helpers;
using Tethering_Reverse_Easy_Start_Progam.Services;



namespace Tethering_Reverse_Easy_Start_Progam
{
    
    public partial class Form1 : Form
    {
        private readonly AdbService adbService;
    private readonly GnirehtetService gnirehtetService;
    private const string CaminhoGnirehtet = @"gnirehtet";
        private Process _gnirehtetProcess;
        public Form1()
        {
            InitializeComponent();
            adbService = new AdbService(CaminhoGnirehtet);
            gnirehtetService = new GnirehtetService(CaminhoGnirehtet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBarStatus.Value = 10;

            if (!adbService.DispositivoConectado())
            {
                MessageBox.Show("Nenhum dispositivo conectado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                progressBarStatus.Value = 0;
                return;
            }

            progressBarStatus.Value = 30;
            string resultado = gnirehtetService.Instalar();
            progressBarStatus.Value = 70;

            if (resultado.ToLower().Contains("success"))
            {
                MessageBox.Show("Gnirehtet instalado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBarStatus.Value = 100;
            }
            else
            {
                MessageBox.Show("Falha ao instalar gnirehtet.\nDetalhes:\n" + resultado, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBarStatus.Value = 0;
            }

            AtualizarStatus();
        }

        private void AtualizarStatus()
        {
            bool temDispositivo = adbService.DispositivoConectado();
            bool gnirehtetInstalado = temDispositivo && adbService.GnirehtetInstalado();

            labelDispositivo.Text = "Dispositivo: " + (temDispositivo ? "Conectado" : "Desconectado");
            labelGnirehtet.Text = "Gnirehtet: " + (gnirehtetInstalado ? "Instalado" : "Não instalado");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarStatus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBarStatus.Value = 10;

            if (adbService.DispositivoConectado())
            {
                progressBarStatus.Value = 30;
                adbService.DesinstalarGnirehtet();
                progressBarStatus.Value = 70;
                AtualizarStatus();
                progressBarStatus.Value = 100;
            }
            else
            {
                MessageBox.Show("Nenhum dispositivo conectado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                progressBarStatus.Value = 0;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            progressBarStatus.Value = 10;

            if (!adbService.DispositivoConectado())
            {
                MessageBox.Show("Nenhum dispositivo conectado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                progressBarStatus.Value = 0;
                return;
            }

            btnRun.Enabled = false;
            progressBarStatus.Value = 30;

            var psi = new ProcessStartInfo("cmd.exe", "/c gnirehtet run")
            {
                WorkingDirectory = CaminhoGnirehtet,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            _gnirehtetProcess = new Process();
            _gnirehtetProcess.StartInfo = psi;

            // Eventos para capturar saída em tempo real
            _gnirehtetProcess.OutputDataReceived += (s, ea) =>
            {
                if (!string.IsNullOrEmpty(ea.Data))
                    this.BeginInvoke(new Action(() => {
                        txtOutput.AppendText(ea.Data + Environment.NewLine);
                    }));
            };

            _gnirehtetProcess.ErrorDataReceived += (s, ea) =>
            {
                if (!string.IsNullOrEmpty(ea.Data))
                    this.BeginInvoke(new Action(() => {
                        txtOutput.AppendText("[ERRO] " + ea.Data + Environment.NewLine);
                    }));
            };

            _gnirehtetProcess.Start();
            _gnirehtetProcess.BeginOutputReadLine();
            _gnirehtetProcess.BeginErrorReadLine();

            progressBarStatus.Value = 100;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            progressBarStatus.Value = 10;

            try
            {
                // Mata o processo cmd.exe usado (se existir)
                if (_gnirehtetProcess != null && !_gnirehtetProcess.HasExited)
                {
                    _gnirehtetProcess.Kill();
                    _gnirehtetProcess.Dispose();
                    _gnirehtetProcess = null;
                }

                progressBarStatus.Value = 50;

                // Mata qualquer processo gnirehtet ativo (processo filho)
                foreach (var proc in Process.GetProcessesByName("gnirehtet"))
                {
                    proc.Kill();
                    proc.WaitForExit();
                    proc.Dispose();
                }

                progressBarStatus.Value = 100;
                btnRun.Enabled = true;
                MessageBox.Show("Gnirehtet parado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar parar o Gnirehtet: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBarStatus.Value = 0;
            }
        }

        private void labelDispositivo_Click(object sender, EventArgs e)
        {

        }
    }
}
