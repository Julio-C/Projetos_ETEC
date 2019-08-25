namespace Trabalho
{
    partial class vendas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.rbc = new System.Windows.Forms.RadioButton();
            this.rbd = new System.Windows.Forms.RadioButton();
            this.btncalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.cbprod = new System.Windows.Forms.ComboBox();
            this.cbfrete = new System.Windows.Forms.ComboBox();
            this.txttotal1 = new System.Windows.Forms.TextBox();
            this.txttotal2 = new System.Windows.Forms.TextBox();
            this.txtfrete = new System.Windows.Forms.TextBox();
            this.btncalc2 = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendas de Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor total ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor Com Acréscimo ou Desconto";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.rbc);
            this.gb.Controls.Add(this.rbd);
            this.gb.Location = new System.Drawing.Point(12, 164);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(116, 62);
            this.gb.TabIndex = 7;
            this.gb.TabStop = false;
            this.gb.Text = "Tipo de pagamento";
            // 
            // rbc
            // 
            this.rbc.AutoSize = true;
            this.rbc.Location = new System.Drawing.Point(20, 42);
            this.rbc.Name = "rbc";
            this.rbc.Size = new System.Drawing.Size(56, 17);
            this.rbc.TabIndex = 1;
            this.rbc.TabStop = true;
            this.rbc.Text = "Cartão";
            this.rbc.UseVisualStyleBackColor = true;
            // 
            // rbd
            // 
            this.rbd.AutoSize = true;
            this.rbd.Location = new System.Drawing.Point(20, 19);
            this.rbd.Name = "rbd";
            this.rbd.Size = new System.Drawing.Size(64, 17);
            this.rbd.TabIndex = 0;
            this.rbd.TabStop = true;
            this.rbd.Text = "Dinheiro";
            this.rbd.UseVisualStyleBackColor = true;
            this.rbd.CheckedChanged += new System.EventHandler(this.rbdin_CheckedChanged);
            // 
            // btncalc
            // 
            this.btncalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalc.Location = new System.Drawing.Point(326, 85);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 8;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Frete";
            // 
            // txtqtd
            // 
            this.txtqtd.Location = new System.Drawing.Point(129, 54);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(71, 20);
            this.txtqtd.TabIndex = 9;
            this.txtqtd.TextChanged += new System.EventHandler(this.txtqtd_TextChanged);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(209, 54);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(71, 20);
            this.txtvalor.TabIndex = 10;
            this.txtvalor.TextChanged += new System.EventHandler(this.txtvalor_TextChanged);
            // 
            // cbprod
            // 
            this.cbprod.FormattingEnabled = true;
            this.cbprod.Items.AddRange(new object[] {
            "CD",
            "DVD",
            "Memoria",
            "HD"});
            this.cbprod.Location = new System.Drawing.Point(15, 54);
            this.cbprod.Name = "cbprod";
            this.cbprod.Size = new System.Drawing.Size(97, 21);
            this.cbprod.TabIndex = 11;
            this.cbprod.SelectedIndexChanged += new System.EventHandler(this.cbprod_SelectedIndexChanged);
            // 
            // cbfrete
            // 
            this.cbfrete.FormattingEnabled = true;
            this.cbfrete.Items.AddRange(new object[] {
            "Capital",
            "Grande São Paulo",
            "Interior"});
            this.cbfrete.Location = new System.Drawing.Point(15, 106);
            this.cbfrete.Name = "cbfrete";
            this.cbfrete.Size = new System.Drawing.Size(100, 21);
            this.cbfrete.TabIndex = 12;
            this.cbfrete.SelectedIndexChanged += new System.EventHandler(this.cbfrete_SelectedIndexChanged);
            // 
            // txttotal1
            // 
            this.txttotal1.Location = new System.Drawing.Point(326, 55);
            this.txttotal1.Name = "txttotal1";
            this.txttotal1.Size = new System.Drawing.Size(100, 20);
            this.txttotal1.TabIndex = 13;
            this.txttotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttotal2
            // 
            this.txttotal2.Location = new System.Drawing.Point(233, 208);
            this.txttotal2.Name = "txttotal2";
            this.txttotal2.Size = new System.Drawing.Size(100, 20);
            this.txttotal2.TabIndex = 14;
            // 
            // txtfrete
            // 
            this.txtfrete.Location = new System.Drawing.Point(15, 133);
            this.txtfrete.Name = "txtfrete";
            this.txtfrete.Size = new System.Drawing.Size(100, 20);
            this.txtfrete.TabIndex = 15;
            // 
            // btncalc2
            // 
            this.btncalc2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalc2.Location = new System.Drawing.Point(339, 208);
            this.btncalc2.Name = "btncalc2";
            this.btncalc2.Size = new System.Drawing.Size(75, 23);
            this.btncalc2.TabIndex = 16;
            this.btncalc2.Text = "Calcular";
            this.btncalc2.UseVisualStyleBackColor = true;
            this.btncalc2.Click += new System.EventHandler(this.btncalc2_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(129, 103);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 50);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 17;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(512, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel1.Text = "Welcome";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(198, 256);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 121);
            this.listBox1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(102, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "ADD >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(383, 357);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 21;
            this.total.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Total da compra :";
            // 
            // vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(512, 402);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.total);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btncalc2);
            this.Controls.Add(this.txtfrete);
            this.Controls.Add(this.txttotal2);
            this.Controls.Add(this.txttotal1);
            this.Controls.Add(this.cbfrete);
            this.Controls.Add(this.cbprod);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtqtd);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vendas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rbc;
        private System.Windows.Forms.RadioButton rbd;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ComboBox cbprod;
        private System.Windows.Forms.ComboBox cbfrete;
        private System.Windows.Forms.TextBox txttotal1;
        private System.Windows.Forms.TextBox txttotal2;
        private System.Windows.Forms.TextBox txtfrete;
        private System.Windows.Forms.Button btncalc2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label8;
    }
}

