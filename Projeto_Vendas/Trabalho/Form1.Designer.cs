namespace Trabalho
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
            this.CBprodutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtq = new System.Windows.Forms.TextBox();
            this.txtv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbf = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtt1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtt2 = new System.Windows.Forms.TextBox();
            this.btnc = new System.Windows.Forms.Button();
            this.txtf = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // CBprodutos
            // 
            this.CBprodutos.FormattingEnabled = true;
            this.CBprodutos.Items.AddRange(new object[] {
            "CD",
            "DVD ",
            "Memória ",
            "HD "});
            this.CBprodutos.Location = new System.Drawing.Point(12, 25);
            this.CBprodutos.Name = "CBprodutos";
            this.CBprodutos.Size = new System.Drawing.Size(99, 21);
            this.CBprodutos.TabIndex = 0;
            this.CBprodutos.SelectedIndexChanged += new System.EventHandler(this.CBprodutos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUANTIDADE";
            // 
            // txtq
            // 
            this.txtq.Location = new System.Drawing.Point(157, 25);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(84, 20);
            this.txtq.TabIndex = 3;
            // 
            // txtv
            // 
            this.txtv.Location = new System.Drawing.Point(288, 26);
            this.txtv.Name = "txtv";
            this.txtv.Size = new System.Drawing.Size(79, 20);
            this.txtv.TabIndex = 4;
            this.txtv.TextChanged += new System.EventHandler(this.txtv_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "VALOR";
            // 
            // cbf
            // 
            this.cbf.FormattingEnabled = true;
            this.cbf.Items.AddRange(new object[] {
            "Capital",
            "Grande São Paulo",
            "Interior"});
            this.cbf.Location = new System.Drawing.Point(23, 436);
            this.cbf.Name = "cbf";
            this.cbf.Size = new System.Drawing.Size(99, 21);
            this.cbf.TabIndex = 6;
            this.cbf.SelectedIndexChanged += new System.EventHandler(this.cbf_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FRETE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB2);
            this.groupBox1.Controls.Add(this.RB1);
            this.groupBox1.Location = new System.Drawing.Point(407, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pagamento";
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(49, 42);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(56, 17);
            this.RB2.TabIndex = 1;
            this.RB2.TabStop = true;
            this.RB2.Text = "Cartão";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Location = new System.Drawing.Point(49, 19);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(64, 17);
            this.RB1.TabIndex = 0;
            this.RB1.TabStop = true;
            this.RB1.Text = "Dinheiro";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor total a ser pago :";
            // 
            // txtt1
            // 
            this.txtt1.Location = new System.Drawing.Point(426, 420);
            this.txtt1.Name = "txtt1";
            this.txtt1.Size = new System.Drawing.Size(100, 20);
            this.txtt1.TabIndex = 12;
            this.txtt1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor com Acréscimo ou Desconto :";
            // 
            // txtt2
            // 
            this.txtt2.Location = new System.Drawing.Point(420, 460);
            this.txtt2.Name = "txtt2";
            this.txtt2.Size = new System.Drawing.Size(100, 20);
            this.txtt2.TabIndex = 14;
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(532, 417);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(75, 23);
            this.btnc.TabIndex = 16;
            this.btnc.Text = "calcular";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(22, 463);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(100, 20);
            this.txtf.TabIndex = 17;
            // 
            // pb
            // 
           
            this.pb.Location = new System.Drawing.Point(3, 88);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(604, 282);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 18;
            this.pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 486);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.txtt2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtt1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtv);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBprodutos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBprodutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.TextBox txtv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtt1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtt2;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.PictureBox pb;
    }
}

