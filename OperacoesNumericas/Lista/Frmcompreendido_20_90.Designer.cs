namespace Lista
{
    partial class Frmcompreendido_20_90
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
            this.btnR1 = new System.Windows.Forms.Button();
            this.btnv1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnR1
            // 
            this.btnR1.Location = new System.Drawing.Point(12, 69);
            this.btnR1.Name = "btnR1";
            this.btnR1.Size = new System.Drawing.Size(75, 23);
            this.btnR1.TabIndex = 0;
            this.btnR1.Text = "Resposta";
            this.btnR1.UseVisualStyleBackColor = true;
            this.btnR1.Click += new System.EventHandler(this.btnR1_Click);
            // 
            // btnv1
            // 
            this.btnv1.Location = new System.Drawing.Point(125, 69);
            this.btnv1.Name = "btnv1";
            this.btnv1.Size = new System.Drawing.Size(75, 23);
            this.btnv1.TabIndex = 1;
            this.btnv1.Text = "Voltar";
            this.btnv1.UseVisualStyleBackColor = true;
            this.btnv1.Click += new System.EventHandler(this.btnv1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero :";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(100, 12);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 3;
            // 
            // compreendido_20_90
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 98);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnv1);
            this.Controls.Add(this.btnR1);
            this.Name = "compreendido_20_90";
            this.Text = "compreendido_20_90";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnR1;
        private System.Windows.Forms.Button btnv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
    }
}