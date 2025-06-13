namespace Tethering_Reverse_Easy_Start_Progam
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.labelDispositivo = new System.Windows.Forms.Label();
            this.labelGnirehtet = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.Color.DarkGreen;
            this.btnInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnInstall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInstall.Location = new System.Drawing.Point(126, 128);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(163, 46);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = "Instalar / Install";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAtualizar.Location = new System.Drawing.Point(214, 31);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(150, 46);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar / Refresh";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // labelDispositivo
            // 
            this.labelDispositivo.AutoSize = true;
            this.labelDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelDispositivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDispositivo.Location = new System.Drawing.Point(24, 31);
            this.labelDispositivo.Name = "labelDispositivo";
            this.labelDispositivo.Size = new System.Drawing.Size(175, 17);
            this.labelDispositivo.TabIndex = 2;
            this.labelDispositivo.Text = "Dispositivo: Desconectado";
            this.labelDispositivo.Click += new System.EventHandler(this.labelDispositivo_Click);
            // 
            // labelGnirehtet
            // 
            this.labelGnirehtet.AutoSize = true;
            this.labelGnirehtet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelGnirehtet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGnirehtet.Location = new System.Drawing.Point(24, 60);
            this.labelGnirehtet.Name = "labelGnirehtet";
            this.labelGnirehtet.Size = new System.Drawing.Size(162, 17);
            this.labelGnirehtet.TabIndex = 3;
            this.labelGnirehtet.Text = "Gnirehtet: Não instalado";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(116, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Desinstalar / Uninstall";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnRun.Location = new System.Drawing.Point(51, 198);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(135, 46);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Iniciar / Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnStop.Location = new System.Drawing.Point(214, 198);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(135, 46);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Parar / Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(9, 5);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(374, 20);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(389, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 355);
            this.panel1.TabIndex = 8;
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.progressBarStatus.Location = new System.Drawing.Point(9, 344);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(374, 23);
            this.progressBarStatus.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(597, 375);
            this.Controls.Add(this.progressBarStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelGnirehtet);
            this.Controls.Add(this.labelDispositivo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInstall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label labelDispositivo;
        private System.Windows.Forms.Label labelGnirehtet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBarStatus;
    }
}

