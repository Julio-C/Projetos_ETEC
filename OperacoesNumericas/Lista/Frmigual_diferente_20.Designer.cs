namespace Lista
{
    partial class Frmigual_diferente_20
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
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.btnr4 = new System.Windows.Forms.Button();
            this.btnv4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtn4
            // 
            this.txtn4.Location = new System.Drawing.Point(113, 22);
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(100, 20);
            this.txtn4.TabIndex = 0;
            // 
            // btnr4
            // 
            this.btnr4.Location = new System.Drawing.Point(12, 69);
            this.btnr4.Name = "btnr4";
            this.btnr4.Size = new System.Drawing.Size(75, 23);
            this.btnr4.TabIndex = 1;
            this.btnr4.Text = "Resposta";
            this.btnr4.UseVisualStyleBackColor = true;
            this.btnr4.Click += new System.EventHandler(this.btnr4_Click);
            // 
            // btnv4
            // 
            this.btnv4.Location = new System.Drawing.Point(138, 69);
            this.btnv4.Name = "btnv4";
            this.btnv4.Size = new System.Drawing.Size(75, 23);
            this.btnv4.TabIndex = 2;
            this.btnv4.Text = "Voltar";
            this.btnv4.UseVisualStyleBackColor = true;
            this.btnv4.Click += new System.EventHandler(this.btnv4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero :";
            // 
            // igual_diferente_20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 101);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnv4);
            this.Controls.Add(this.btnr4);
            this.Controls.Add(this.txtn4);
            this.Name = "igual_diferente_20";
            this.Text = "igual_diferente_20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn4;
        private System.Windows.Forms.Button btnr4;
        private System.Windows.Forms.Button btnv4;
        private System.Windows.Forms.Label label1;
    }
}