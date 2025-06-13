using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tethering_Reverse_Easy_Start_Progam.Helpers;


namespace Tethering_Reverse_Easy_Start_Progam.Services
{
    internal class AdbService
    {
        private readonly string _gnirehtetPath;

        public AdbService(string gnirehtetPath)
        {
            _gnirehtetPath = gnirehtetPath;
        }

        public bool DispositivoConectado()
        {
            string output = CmdHelper.Run("adb devices", _gnirehtetPath);
            return output.Contains("\tdevice");
        }

        public bool GnirehtetInstalado()
        {
            string output = CmdHelper.Run("adb shell pm list packages", _gnirehtetPath);
            return output.Contains("com.genymobile.gnirehtet");
        }

        public void InstalarGnirehtet()
        {
            if (GnirehtetInstalado())
            {
                MessageBox.Show("Gnirehtet já está instalado — não é necessário reinstalar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string resultado = CmdHelper.Run("adb install gnirehtet.apk", _gnirehtetPath);

            if (resultado.ToLower().Contains("success"))
            {
                MessageBox.Show("Gnirehtet instalado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao instalar o gnirehtet.\n\nDetalhes:\n" + resultado, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DesinstalarGnirehtet()
        {
            string resultado = CmdHelper.Run("adb uninstall com.genymobile.gnirehtet", _gnirehtetPath);

            if (resultado.ToLower().Contains("success"))
            {
                MessageBox.Show("Gnirehtet desinstalado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao desinstalar gnirehtet.\n\nDetalhes:\n" + resultado, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
