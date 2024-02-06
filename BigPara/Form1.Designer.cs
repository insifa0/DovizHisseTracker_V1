namespace BigPara
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGetir = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            btnHisseGetir = new Button();
            lblHisseFiyati = new Label();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            dovizSeçenekleriToolStripMenuItem = new ToolStripMenuItem();
            dolarToolStripMenuItem = new ToolStripMenuItem();
            euroToolStripMenuItem = new ToolStripMenuItem();
            özelliklerToolStripMenuItem = new ToolStripMenuItem();
            arkaPlanRengiToolStripMenuItem = new ToolStripMenuItem();
            pinkToolStripMenuItem = new ToolStripMenuItem();
            orangeToolStripMenuItem = new ToolStripMenuItem();
            blackToolStripMenuItem = new ToolStripMenuItem();
            aboutMeToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(276, 67);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(129, 29);
            btnGetir.TabIndex = 0;
            btnGetir.Text = "Veri getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 46);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Dolar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 46);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 46);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 27);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 119);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 7;
            label4.Text = "Hisse Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 150);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 8;
            label5.Text = "Hisse Adeti";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(177, 27);
            textBox3.TabIndex = 9;
            // 
            // btnHisseGetir
            // 
            btnHisseGetir.Location = new Point(276, 150);
            btnHisseGetir.Name = "btnHisseGetir";
            btnHisseGetir.Size = new Size(129, 29);
            btnHisseGetir.TabIndex = 10;
            btnHisseGetir.Text = "Hisse Getir";
            btnHisseGetir.UseVisualStyleBackColor = true;
            btnHisseGetir.Click += btnHisseGetir_Click;
            // 
            // lblHisseFiyati
            // 
            lblHisseFiyati.AutoSize = true;
            lblHisseFiyati.Location = new Point(144, 191);
            lblHisseFiyati.Name = "lblHisseFiyati";
            lblHisseFiyati.Size = new Size(83, 20);
            lblHisseFiyati.TabIndex = 11;
            lblHisseFiyati.Text = "Hisse Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 223);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 12;
            label6.Text = "Hisse Adeti";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dovizSeçenekleriToolStripMenuItem, özelliklerToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(465, 28);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // dovizSeçenekleriToolStripMenuItem
            // 
            dovizSeçenekleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dolarToolStripMenuItem, euroToolStripMenuItem });
            dovizSeçenekleriToolStripMenuItem.Name = "dovizSeçenekleriToolStripMenuItem";
            dovizSeçenekleriToolStripMenuItem.Size = new Size(140, 24);
            dovizSeçenekleriToolStripMenuItem.Text = "Doviz Seçenekleri";
            // 
            // dolarToolStripMenuItem
            // 
            dolarToolStripMenuItem.Name = "dolarToolStripMenuItem";
            dolarToolStripMenuItem.Size = new Size(224, 26);
            dolarToolStripMenuItem.Text = "Dolar";
            // 
            // euroToolStripMenuItem
            // 
            euroToolStripMenuItem.Name = "euroToolStripMenuItem";
            euroToolStripMenuItem.Size = new Size(224, 26);
            euroToolStripMenuItem.Text = "Euro";
            euroToolStripMenuItem.Click += euroToolStripMenuItem_Click;
            // 
            // özelliklerToolStripMenuItem
            // 
            özelliklerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arkaPlanRengiToolStripMenuItem, aboutMeToolStripMenuItem });
            özelliklerToolStripMenuItem.Name = "özelliklerToolStripMenuItem";
            özelliklerToolStripMenuItem.Size = new Size(85, 24);
            özelliklerToolStripMenuItem.Text = "Özellikler";
            // 
            // arkaPlanRengiToolStripMenuItem
            // 
            arkaPlanRengiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pinkToolStripMenuItem, orangeToolStripMenuItem, blackToolStripMenuItem });
            arkaPlanRengiToolStripMenuItem.Name = "arkaPlanRengiToolStripMenuItem";
            arkaPlanRengiToolStripMenuItem.Size = new Size(224, 26);
            arkaPlanRengiToolStripMenuItem.Text = "Arka Plan Rengi";
            // 
            // pinkToolStripMenuItem
            // 
            pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            pinkToolStripMenuItem.Size = new Size(224, 26);
            pinkToolStripMenuItem.Text = "Pink";
            pinkToolStripMenuItem.Click += pinkToolStripMenuItem_Click;
            // 
            // orangeToolStripMenuItem
            // 
            orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            orangeToolStripMenuItem.Size = new Size(224, 26);
            orangeToolStripMenuItem.Text = "Orange";
            orangeToolStripMenuItem.Click += orangeToolStripMenuItem_Click;
            // 
            // blackToolStripMenuItem
            // 
            blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            blackToolStripMenuItem.Size = new Size(224, 26);
            blackToolStripMenuItem.Text = "Grey";
            blackToolStripMenuItem.Click += blackToolStripMenuItem_Click;
            // 
            // aboutMeToolStripMenuItem
            // 
            aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            aboutMeToolStripMenuItem.Size = new Size(224, 26);
            aboutMeToolStripMenuItem.Text = "About Me";
            aboutMeToolStripMenuItem.Click += aboutMeToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 257);
            Controls.Add(label6);
            Controls.Add(lblHisseFiyati);
            Controls.Add(btnHisseGetir);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnGetir);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetir;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Button btnHisseGetir;
        private Label lblHisseFiyati;
        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dovizSeçenekleriToolStripMenuItem;
        private ToolStripMenuItem dolarToolStripMenuItem;
        private ToolStripMenuItem euroToolStripMenuItem;
        private ToolStripMenuItem özelliklerToolStripMenuItem;
        private ToolStripMenuItem arkaPlanRengiToolStripMenuItem;
        private ToolStripMenuItem pinkToolStripMenuItem;
        private ToolStripMenuItem orangeToolStripMenuItem;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem aboutMeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
