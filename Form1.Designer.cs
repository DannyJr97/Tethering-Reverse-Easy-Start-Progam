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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.Color.DarkGreen;
            this.btnInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnInstall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInstall.Location = new System.Drawing.Point(115, 167);
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
            this.btnAtualizar.Location = new System.Drawing.Point(214, 46);
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
            this.labelDispositivo.Size = new System.Drawing.Size(167, 17);
            this.labelDispositivo.TabIndex = 2;
            this.labelDispositivo.Text = "Conectividade dispositivo";
            this.labelDispositivo.Click += new System.EventHandler(this.labelDispositivo_Click);
            // 
            // labelGnirehtet
            // 
            this.labelGnirehtet.AutoSize = true;
            this.labelGnirehtet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelGnirehtet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGnirehtet.Location = new System.Drawing.Point(24, 60);
            this.labelGnirehtet.Name = "labelGnirehtet";
            this.labelGnirehtet.Size = new System.Drawing.Size(67, 17);
            this.labelGnirehtet.TabIndex = 3;
            this.labelGnirehtet.Text = "Gnirehtet";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(115, 290);
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
            this.btnRun.Location = new System.Drawing.Point(51, 223);
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
            this.btnStop.Location = new System.Drawing.Point(214, 223);
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
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(389, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 362);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label10.Location = new System.Drawing.Point(35, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "após clicar em iniciar";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(29, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "3 Aceite a conexão no cell";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(35, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "definições (Debugging USB)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(29, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "2 Active a depuração USB nas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(35, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "o seu celular antes de iniciar";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(29, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "1 Não esqueça de conectar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(65, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Github: DANNYJR97";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apenas Android e Windows por enquanto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(53, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tethering Reverso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(91, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gnirehtet ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.progressBarStatus.Location = new System.Drawing.Point(9, 344);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(374, 23);
            this.progressBarStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.Location = new System.Drawing.Point(24, 89);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Estado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(673, 375);
            this.Controls.Add(this.lblStatus);
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
            this.Text = "Gnireht DANNYJR97";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStatus;
    }
}

