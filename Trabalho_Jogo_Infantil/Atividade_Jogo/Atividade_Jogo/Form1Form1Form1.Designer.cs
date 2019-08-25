namespace Atividade_Jogo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TXTO = new System.Windows.Forms.TextBox();
            this.TXTU = new System.Windows.Forms.TextBox();
            this.TXTI = new System.Windows.Forms.TextBox();
            this.TXTE = new System.Windows.Forms.TextBox();
            this.TXTA = new System.Windows.Forms.TextBox();
            this.LBL1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTO
            // 
            this.TXTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTO.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTO.Location = new System.Drawing.Point(162, 281);
            this.TXTO.MaxLength = 1;
            this.TXTO.Name = "TXTO";
            this.TXTO.Size = new System.Drawing.Size(33, 29);
            this.TXTO.TabIndex = 4;
            this.TXTO.Visible = false;
            this.TXTO.TextChanged += new System.EventHandler(this.TXTO_TextChanged);
            // 
            // TXTU
            // 
            this.TXTU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTU.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTU.Location = new System.Drawing.Point(213, 281);
            this.TXTU.MaxLength = 1;
            this.TXTU.Name = "TXTU";
            this.TXTU.Size = new System.Drawing.Size(33, 29);
            this.TXTU.TabIndex = 6;
            this.TXTU.Visible = false;
            this.TXTU.TextChanged += new System.EventHandler(this.TXTU_TextChanged);
            // 
            // TXTI
            // 
            this.TXTI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTI.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTI.Location = new System.Drawing.Point(114, 281);
            this.TXTI.MaxLength = 1;
            this.TXTI.Name = "TXTI";
            this.TXTI.Size = new System.Drawing.Size(33, 29);
            this.TXTI.TabIndex = 9;
            this.TXTI.Visible = false;
            this.TXTI.TextChanged += new System.EventHandler(this.TXTI_TextChanged);
            // 
            // TXTE
            // 
            this.TXTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTE.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTE.Location = new System.Drawing.Point(64, 281);
            this.TXTE.MaxLength = 1;
            this.TXTE.Name = "TXTE";
            this.TXTE.Size = new System.Drawing.Size(33, 29);
            this.TXTE.TabIndex = 10;
            this.TXTE.Visible = false;
            this.TXTE.TextChanged += new System.EventHandler(this.TXTE_TextChanged);
            // 
            // TXTA
            // 
            this.TXTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTA.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTA.Location = new System.Drawing.Point(16, 281);
            this.TXTA.MaxLength = 1;
            this.TXTA.Name = "TXTA";
            this.TXTA.Size = new System.Drawing.Size(33, 29);
            this.TXTA.TabIndex = 11;
            this.TXTA.TextChanged += new System.EventHandler(this.TXTA_TextChanged);
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1.Location = new System.Drawing.Point(12, 9);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(249, 24);
            this.LBL1.TabIndex = 12;
            this.LBL1.Text = "ORGANIZE AS VOGAIS :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.TXTA);
            this.Controls.Add(this.TXTE);
            this.Controls.Add(this.TXTI);
            this.Controls.Add(this.TXTU);
            this.Controls.Add(this.TXTO);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTO;
        private System.Windows.Forms.TextBox TXTU;
        private System.Windows.Forms.TextBox TXTI;
        private System.Windows.Forms.TextBox TXTE;
        private System.Windows.Forms.TextBox TXTA;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

