namespace Lista
{
    partial class FrmDivisivel_10_5_2
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
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnresp = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(119, 35);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(100, 20);
            this.txtn3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o numero :";
            // 
            // btnresp
            // 
            this.btnresp.Location = new System.Drawing.Point(15, 75);
            this.btnresp.Name = "btnresp";
            this.btnresp.Size = new System.Drawing.Size(75, 23);
            this.btnresp.TabIndex = 2;
            this.btnresp.Text = "Resposta";
            this.btnresp.UseVisualStyleBackColor = true;
            this.btnresp.Click += new System.EventHandler(this.btnresp_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.Location = new System.Drawing.Point(144, 75);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(75, 23);
            this.btnvolt.TabIndex = 3;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = true;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // FrmDivisivel_10_5_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 108);
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btnresp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn3);
            this.Name = "FrmDivisivel_10_5_2";
            this.Text = "Divisivel_10_5_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnresp;
        private System.Windows.Forms.Button btnvolt;
    }
}