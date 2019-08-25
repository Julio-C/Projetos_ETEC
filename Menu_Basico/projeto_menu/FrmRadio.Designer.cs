namespace projeto_menu
{
    partial class FrmRadio
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.btnver1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.btnver2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado";
            // 
            // cbuf
            // 
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Items.AddRange(new object[] {
            "SP",
            "RS",
            "MG"});
            this.cbuf.Location = new System.Drawing.Point(73, 26);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(121, 21);
            this.cbuf.TabIndex = 1;
            // 
            // btnver1
            // 
            this.btnver1.Location = new System.Drawing.Point(209, 24);
            this.btnver1.Name = "btnver1";
            this.btnver1.Size = new System.Drawing.Size(75, 23);
            this.btnver1.TabIndex = 2;
            this.btnver1.Text = "Verificar";
            this.btnver1.UseVisualStyleBackColor = true;
            this.btnver1.Click += new System.EventHandler(this.btnver1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbf);
            this.groupBox1.Controls.Add(this.rbm);
            this.groupBox1.Location = new System.Drawing.Point(64, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(32, 19);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(67, 17);
            this.rbm.TabIndex = 0;
            this.rbm.TabStop = true;
            this.rbm.Text = "Masculio";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(32, 53);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(67, 17);
            this.rbf.TabIndex = 1;
            this.rbf.TabStop = true;
            this.rbf.Text = "Feminino";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // btnver2
            // 
            this.btnver2.Location = new System.Drawing.Point(108, 206);
            this.btnver2.Name = "btnver2";
            this.btnver2.Size = new System.Drawing.Size(75, 23);
            this.btnver2.TabIndex = 4;
            this.btnver2.Text = "Verificar";
            this.btnver2.UseVisualStyleBackColor = true;
            this.btnver2.Click += new System.EventHandler(this.btnver2_Click);
            // 
            // FrmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 262);
            this.Controls.Add(this.btnver2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnver1);
            this.Controls.Add(this.cbuf);
            this.Controls.Add(this.label1);
            this.Name = "FrmRadio";
            this.Text = "FrmRadio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.Button btnver1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.Button btnver2;
    }
}