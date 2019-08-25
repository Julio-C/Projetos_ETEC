namespace Atividade_Jogo
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.LBLCONTA = new System.Windows.Forms.Label();
            this.txtv = new System.Windows.Forms.TextBox();
            this.LBLP = new System.Windows.Forms.Label();
            this.pontos = new System.Windows.Forms.Label();
            this.BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "VAMOS APREDER A SOMA E SUBTRAIR AGORA :";
            // 
            // LBLCONTA
            // 
            this.LBLCONTA.AutoSize = true;
            this.LBLCONTA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCONTA.Location = new System.Drawing.Point(118, 135);
            this.LBLCONTA.Name = "LBLCONTA";
            this.LBLCONTA.Size = new System.Drawing.Size(69, 24);
            this.LBLCONTA.TabIndex = 1;
            this.LBLCONTA.Text = "label2";
            // 
            // txtv
            // 
            this.txtv.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtv.Location = new System.Drawing.Point(290, 134);
            this.txtv.Name = "txtv";
            this.txtv.Size = new System.Drawing.Size(84, 32);
            this.txtv.TabIndex = 2;
            // 
            // LBLP
            // 
            this.LBLP.AutoSize = true;
            this.LBLP.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLP.Location = new System.Drawing.Point(75, 296);
            this.LBLP.Name = "LBLP";
            this.LBLP.Size = new System.Drawing.Size(161, 24);
            this.LBLP.TabIndex = 3;
            this.LBLP.Text = "PONTUAÇÃO  :";
            // 
            // pontos
            // 
            this.pontos.AutoSize = true;
            this.pontos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontos.Location = new System.Drawing.Point(322, 298);
            this.pontos.Name = "pontos";
            this.pontos.Size = new System.Drawing.Size(21, 22);
            this.pontos.TabIndex = 4;
            this.pontos.Text = "0";
            // 
            // BTN
            // 
            this.BTN.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN.Location = new System.Drawing.Point(136, 190);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(192, 35);
            this.BTN.TabIndex = 5;
            this.BTN.Text = "VERIFICAR";
            this.BTN.UseVisualStyleBackColor = true;
            this.BTN.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 387);
            this.Controls.Add(this.BTN);
            this.Controls.Add(this.pontos);
            this.Controls.Add(this.LBLP);
            this.Controls.Add(this.txtv);
            this.Controls.Add(this.LBLCONTA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLCONTA;
        private System.Windows.Forms.TextBox txtv;
        private System.Windows.Forms.Label LBLP;
        private System.Windows.Forms.Label pontos;
        private System.Windows.Forms.Button BTN;
    }
}