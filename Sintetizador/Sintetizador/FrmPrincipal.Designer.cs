namespace Sintetizador
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExecutar = new System.Windows.Forms.Button();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.tkbVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblVelocidade = new System.Windows.Forms.Label();
            this.tkbVelocidade = new System.Windows.Forms.TrackBar();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVelocidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(319, 352);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(147, 50);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Falar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(14, 8);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(452, 203);
            this.rtbTexto.TabIndex = 1;
            this.rtbTexto.Text = "";
            // 
            // tkbVolume
            // 
            this.tkbVolume.Location = new System.Drawing.Point(11, 233);
            this.tkbVolume.Maximum = 100;
            this.tkbVolume.Name = "tkbVolume";
            this.tkbVolume.Size = new System.Drawing.Size(455, 45);
            this.tkbVolume.TabIndex = 2;
            this.tkbVolume.TickFrequency = 10;
            this.tkbVolume.Value = 100;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(11, 217);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 3;
            this.lblVolume.Text = "Volume";
            // 
            // lblVelocidade
            // 
            this.lblVelocidade.AutoSize = true;
            this.lblVelocidade.Location = new System.Drawing.Point(11, 281);
            this.lblVelocidade.Name = "lblVelocidade";
            this.lblVelocidade.Size = new System.Drawing.Size(60, 13);
            this.lblVelocidade.TabIndex = 4;
            this.lblVelocidade.Text = "Velocidade";
            // 
            // tkbVelocidade
            // 
            this.tkbVelocidade.Location = new System.Drawing.Point(14, 297);
            this.tkbVelocidade.Minimum = -10;
            this.tkbVelocidade.Name = "tkbVelocidade";
            this.tkbVelocidade.Size = new System.Drawing.Size(452, 45);
            this.tkbVelocidade.TabIndex = 5;
            this.tkbVelocidade.TickFrequency = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(166, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(147, 50);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 410);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.tkbVelocidade);
            this.Controls.Add(this.lblVelocidade);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.tkbVolume);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.btnExecutar);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Síntetizador de Voz - Desenvol. por Vinicius Manca";
            ((System.ComponentModel.ISupportInitialize)(this.tkbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbVelocidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.TrackBar tkbVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblVelocidade;
        private System.Windows.Forms.TrackBar tkbVelocidade;
        private System.Windows.Forms.Button btnLimpar;
    }
}

