namespace Lista
{
    partial class FrmDivisivel_5
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
            this.lbln1 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.btnr = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.Location = new System.Drawing.Point(12, 23);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(87, 13);
            this.lbln1.TabIndex = 0;
            this.lbln1.Text = "Digite o numero :";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(119, 16);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 1;
            // 
            // btnr
            // 
            this.btnr.Location = new System.Drawing.Point(28, 74);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(75, 23);
            this.btnr.TabIndex = 2;
            this.btnr.Text = "Resposta ";
            this.btnr.UseVisualStyleBackColor = true;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(156, 74);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 3;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Divisivel_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.lbln1);
            this.Name = "Divisivel_5";
            this.Text = "Divisivel_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbln1;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.Button btnvoltar;
    }
}