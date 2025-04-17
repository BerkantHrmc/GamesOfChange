namespace GameOfChange
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            karanlıkModToolStripMenuItem = new ToolStripMenuItem();
            karanlıkToolStripMenuItem = new ToolStripMenuItem();
            aydınlıkToolStripMenuItem = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            nasılOynanırToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Baslik = new Label();
            panel2 = new Panel();
            informationText6 = new Label();
            informationText3 = new Label();
            informationText5 = new Label();
            informationText2 = new Label();
            informationText4 = new Label();
            informationTextHeader = new Label();
            informationText1 = new Label();
            pictureBox2 = new PictureBox();
            resultBox1 = new TextBox();
            resultBox2 = new TextBox();
            resultBox3 = new TextBox();
            resultBox4 = new TextBox();
            resultBox5 = new TextBox();
            resultBox6 = new TextBox();
            panel3 = new Panel();
            dice6 = new TextBox();
            dice5 = new TextBox();
            dice3 = new TextBox();
            dice4 = new TextBox();
            valueBox = new TextBox();
            dice2 = new TextBox();
            numbersText = new Label();
            betBox6 = new TextBox();
            buttonbahis = new Button();
            betBox5 = new TextBox();
            label2 = new Label();
            betBox4 = new TextBox();
            betBox3 = new TextBox();
            betBox2 = new TextBox();
            betBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sesToolStripMenuItem = new ToolStripMenuItem();
            açToolStripMenuItem = new ToolStripMenuItem();
            kapatToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { karanlıkModToolStripMenuItem, hakkımızdaToolStripMenuItem, nasılOynanırToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(747, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // karanlıkModToolStripMenuItem
            // 
            karanlıkModToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { karanlıkToolStripMenuItem, aydınlıkToolStripMenuItem });
            karanlıkModToolStripMenuItem.Name = "karanlıkModToolStripMenuItem";
            karanlıkModToolStripMenuItem.Size = new Size(48, 21);
            karanlıkModToolStripMenuItem.Text = "Mod";
            karanlıkModToolStripMenuItem.Click += karanlıkModToolStripMenuItem_Click;
            // 
            // karanlıkToolStripMenuItem
            // 
            karanlıkToolStripMenuItem.Name = "karanlıkToolStripMenuItem";
            karanlıkToolStripMenuItem.Size = new Size(128, 24);
            karanlıkToolStripMenuItem.Text = "Karanlık";
            karanlıkToolStripMenuItem.Click += karanlıkToolStripMenuItem_Click;
            // 
            // aydınlıkToolStripMenuItem
            // 
            aydınlıkToolStripMenuItem.Name = "aydınlıkToolStripMenuItem";
            aydınlıkToolStripMenuItem.Size = new Size(128, 24);
            aydınlıkToolStripMenuItem.Text = "Aydınlık";
            aydınlıkToolStripMenuItem.Click += aydınlıkToolStripMenuItem_Click;
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(86, 21);
            hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            hakkımızdaToolStripMenuItem.Click += hakkımızdaToolStripMenuItem_Click;
            // 
            // nasılOynanırToolStripMenuItem
            // 
            nasılOynanırToolStripMenuItem.Name = "nasılOynanırToolStripMenuItem";
            nasılOynanırToolStripMenuItem.Size = new Size(112, 21);
            nasılOynanırToolStripMenuItem.Text = "Nasıl Oynanır ? ";
            nasılOynanırToolStripMenuItem.Click += nasılOynanırToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.BackgroundImage = Properties.Resources.zar;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Baslik);
            panel1.Location = new Point(3, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 51);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.zar;
            pictureBox1.Location = new Point(9, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Baslik
            // 
            Baslik.AutoSize = true;
            Baslik.Font = new Font("Verdana", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Baslik.ForeColor = Color.Orange;
            Baslik.Location = new Point(130, 11);
            Baslik.Name = "Baslik";
            Baslik.Size = new Size(201, 31);
            Baslik.TabIndex = 2;
            Baslik.Text = "Chuck a Luck";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkViolet;
            panel2.Controls.Add(informationText6);
            panel2.Controls.Add(informationText3);
            panel2.Controls.Add(informationText5);
            panel2.Controls.Add(informationText2);
            panel2.Controls.Add(informationText4);
            panel2.Controls.Add(informationTextHeader);
            panel2.Controls.Add(informationText1);
            panel2.Location = new Point(520, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 146);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // informationText6
            // 
            informationText6.AutoSize = true;
            informationText6.Font = new Font("Arial", 10.18868F, FontStyle.Bold);
            informationText6.ForeColor = SystemColors.ButtonHighlight;
            informationText6.Location = new Point(67, 118);
            informationText6.Name = "informationText6";
            informationText6.Size = new Size(102, 18);
            informationText6.TabIndex = 5;
            informationText6.Text = "6 Zara 25 Katı";
            // 
            // informationText3
            // 
            informationText3.AutoSize = true;
            informationText3.Font = new Font("Arial", 10.18868F, FontStyle.Bold);
            informationText3.ForeColor = SystemColors.ButtonHighlight;
            informationText3.Location = new Point(67, 67);
            informationText3.Name = "informationText3";
            informationText3.Size = new Size(106, 18);
            informationText3.TabIndex = 3;
            informationText3.Text = "3 Zara 1.6 Katı";
            // 
            // informationText5
            // 
            informationText5.AutoSize = true;
            informationText5.Font = new Font("Arial", 10.18868F, FontStyle.Bold);
            informationText5.ForeColor = SystemColors.ButtonHighlight;
            informationText5.Location = new Point(67, 101);
            informationText5.Name = "informationText5";
            informationText5.Size = new Size(94, 18);
            informationText5.TabIndex = 4;
            informationText5.Text = "5 Zara 7 Katı";
            // 
            // informationText2
            // 
            informationText2.AutoSize = true;
            informationText2.Font = new Font("Arial", 10.18868F, FontStyle.Bold);
            informationText2.ForeColor = SystemColors.ButtonHighlight;
            informationText2.Location = new Point(67, 50);
            informationText2.Name = "informationText2";
            informationText2.Size = new Size(106, 18);
            informationText2.TabIndex = 4;
            informationText2.Text = "2 Zara 1.3 Katı";
            // 
            // informationText4
            // 
            informationText4.AutoSize = true;
            informationText4.Font = new Font("Arial", 10.18868F, FontStyle.Bold);
            informationText4.ForeColor = SystemColors.ButtonHighlight;
            informationText4.Location = new Point(67, 84);
            informationText4.Name = "informationText4";
            informationText4.Size = new Size(94, 18);
            informationText4.TabIndex = 3;
            informationText4.Text = "4 Zara 3 Katı";
            // 
            // informationTextHeader
            // 
            informationTextHeader.AutoSize = true;
            informationTextHeader.Font = new Font("Arial", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 162);
            informationTextHeader.ForeColor = SystemColors.ButtonHighlight;
            informationTextHeader.Location = new Point(49, 5);
            informationTextHeader.Name = "informationTextHeader";
            informationTextHeader.Size = new Size(95, 21);
            informationTextHeader.TabIndex = 0;
            informationTextHeader.Text = "Kazançlar";
            informationTextHeader.Click += informationtext_Click;
            // 
            // informationText1
            // 
            informationText1.AutoSize = true;
            informationText1.Font = new Font("Arial", 10.18868F, FontStyle.Bold);
            informationText1.ForeColor = SystemColors.ButtonHighlight;
            informationText1.Location = new Point(67, 33);
            informationText1.Name = "informationText1";
            informationText1.Size = new Size(84, 18);
            informationText1.TabIndex = 3;
            informationText1.Text = "1 Zara İade";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Enabled = false;
            pictureBox2.Location = new Point(12, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(494, 146);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // resultBox1
            // 
            resultBox1.Enabled = false;
            resultBox1.Font = new Font("Segoe UI", 21.73585F, FontStyle.Regular, GraphicsUnit.Point, 162);
            resultBox1.Location = new Point(133, 109);
            resultBox1.Name = "resultBox1";
            resultBox1.Size = new Size(51, 50);
            resultBox1.TabIndex = 4;
            // 
            // resultBox2
            // 
            resultBox2.Enabled = false;
            resultBox2.Font = new Font("Segoe UI", 21.73585F, FontStyle.Regular, GraphicsUnit.Point, 162);
            resultBox2.Location = new Point(236, 109);
            resultBox2.Name = "resultBox2";
            resultBox2.Size = new Size(51, 50);
            resultBox2.TabIndex = 5;
            // 
            // resultBox3
            // 
            resultBox3.Enabled = false;
            resultBox3.Font = new Font("Segoe UI", 21.73585F, FontStyle.Regular, GraphicsUnit.Point, 162);
            resultBox3.Location = new Point(332, 109);
            resultBox3.Name = "resultBox3";
            resultBox3.Size = new Size(51, 50);
            resultBox3.TabIndex = 6;
            // 
            // resultBox4
            // 
            resultBox4.Enabled = false;
            resultBox4.Font = new Font("Segoe UI", 21.73585F, FontStyle.Regular, GraphicsUnit.Point, 162);
            resultBox4.Location = new Point(133, 168);
            resultBox4.Name = "resultBox4";
            resultBox4.Size = new Size(51, 50);
            resultBox4.TabIndex = 7;
            // 
            // resultBox5
            // 
            resultBox5.Enabled = false;
            resultBox5.Font = new Font("Segoe UI", 21.73585F, FontStyle.Regular, GraphicsUnit.Point, 162);
            resultBox5.Location = new Point(236, 168);
            resultBox5.Name = "resultBox5";
            resultBox5.Size = new Size(51, 50);
            resultBox5.TabIndex = 8;
            // 
            // resultBox6
            // 
            resultBox6.Enabled = false;
            resultBox6.Font = new Font("Segoe UI", 21.73585F, FontStyle.Regular, GraphicsUnit.Point, 162);
            resultBox6.Location = new Point(332, 168);
            resultBox6.Name = "resultBox6";
            resultBox6.Size = new Size(51, 50);
            resultBox6.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 64, 0);
            panel3.Controls.Add(dice6);
            panel3.Controls.Add(dice5);
            panel3.Controls.Add(dice3);
            panel3.Controls.Add(dice4);
            panel3.Controls.Add(valueBox);
            panel3.Controls.Add(dice2);
            panel3.Controls.Add(numbersText);
            panel3.Controls.Add(betBox6);
            panel3.Controls.Add(buttonbahis);
            panel3.Controls.Add(betBox5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(betBox4);
            panel3.Controls.Add(betBox3);
            panel3.Controls.Add(betBox2);
            panel3.Controls.Add(betBox1);
            panel3.Location = new Point(15, 248);
            panel3.Name = "panel3";
            panel3.Size = new Size(731, 147);
            panel3.TabIndex = 10;
            // 
            // dice6
            // 
            dice6.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dice6.Location = new Point(508, 121);
            dice6.Name = "dice6";
            dice6.Size = new Size(212, 22);
            dice6.TabIndex = 20;
            // 
            // dice5
            // 
            dice5.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dice5.Location = new Point(508, 92);
            dice5.Name = "dice5";
            dice5.Size = new Size(212, 22);
            dice5.TabIndex = 19;
            // 
            // dice3
            // 
            dice3.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dice3.Location = new Point(508, 35);
            dice3.Name = "dice3";
            dice3.Size = new Size(212, 22);
            dice3.TabIndex = 18;
            // 
            // dice4
            // 
            dice4.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dice4.Location = new Point(508, 64);
            dice4.Name = "dice4";
            dice4.Size = new Size(212, 22);
            dice4.TabIndex = 17;
            // 
            // valueBox
            // 
            valueBox.Font = new Font("Segoe UI", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            valueBox.Location = new Point(189, 35);
            valueBox.Name = "valueBox";
            valueBox.Size = new Size(302, 39);
            valueBox.TabIndex = 15;
            valueBox.TextChanged += textBox1_TextChanged;
            // 
            // dice2
            // 
            dice2.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dice2.Location = new Point(508, 6);
            dice2.Name = "dice2";
            dice2.Size = new Size(212, 22);
            dice2.TabIndex = 16;
            // 
            // numbersText
            // 
            numbersText.AutoSize = true;
            numbersText.BackColor = Color.Transparent;
            numbersText.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numbersText.ForeColor = SystemColors.ButtonHighlight;
            numbersText.Location = new Point(0, 0);
            numbersText.Name = "numbersText";
            numbersText.Size = new Size(85, 25);
            numbersText.TabIndex = 11;
            numbersText.Text = "Rakamlar";
            // 
            // betBox6
            // 
            betBox6.Font = new Font("Segoe UI", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            betBox6.Location = new Point(129, 89);
            betBox6.Name = "betBox6";
            betBox6.Size = new Size(40, 39);
            betBox6.TabIndex = 12;
            // 
            // buttonbahis
            // 
            buttonbahis.BackColor = Color.DarkGreen;
            buttonbahis.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonbahis.ForeColor = Color.White;
            buttonbahis.Location = new Point(347, 89);
            buttonbahis.Name = "buttonbahis";
            buttonbahis.Size = new Size(144, 40);
            buttonbahis.TabIndex = 14;
            buttonbahis.Text = "BAHİS";
            buttonbahis.UseVisualStyleBackColor = false;
            buttonbahis.Click += buttonbahis_Click;
            // 
            // betBox5
            // 
            betBox5.Font = new Font("Segoe UI", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            betBox5.Location = new Point(72, 89);
            betBox5.Name = "betBox5";
            betBox5.Size = new Size(40, 39);
            betBox5.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(183, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 12;
            label2.Text = "Bahis Girin:";
            label2.Click += label2_Click;
            // 
            // betBox4
            // 
            betBox4.Font = new Font("Segoe UI", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            betBox4.Location = new Point(12, 89);
            betBox4.Name = "betBox4";
            betBox4.Size = new Size(40, 39);
            betBox4.TabIndex = 12;
            // 
            // betBox3
            // 
            betBox3.Font = new Font("Segoe UI", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            betBox3.Location = new Point(129, 35);
            betBox3.Name = "betBox3";
            betBox3.Size = new Size(40, 39);
            betBox3.TabIndex = 12;
            // 
            // betBox2
            // 
            betBox2.Font = new Font("Segoe UI", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            betBox2.Location = new Point(72, 35);
            betBox2.Name = "betBox2";
            betBox2.Size = new Size(40, 39);
            betBox2.TabIndex = 12;
            // 
            // betBox1
            // 
            betBox1.Font = new Font("Segoe UI", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            betBox1.Location = new Point(12, 35);
            betBox1.Name = "betBox1";
            betBox1.Size = new Size(40, 39);
            betBox1.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(18, 18);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { sesToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 26);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // sesToolStripMenuItem
            // 
            sesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { açToolStripMenuItem, kapatToolStripMenuItem });
            sesToolStripMenuItem.Name = "sesToolStripMenuItem";
            sesToolStripMenuItem.Size = new Size(100, 22);
            sesToolStripMenuItem.Text = "Ses ";
            sesToolStripMenuItem.Click += sesToolStripMenuItem_Click;
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.Size = new Size(116, 24);
            açToolStripMenuItem.Text = "Aç";
            açToolStripMenuItem.Click += açToolStripMenuItem_Click;
            // 
            // kapatToolStripMenuItem
            // 
            kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            kapatToolStripMenuItem.Size = new Size(116, 24);
            kapatToolStripMenuItem.Text = "Kapat";
            kapatToolStripMenuItem.Click += kapatToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 406);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(panel3);
            Controls.Add(resultBox6);
            Controls.Add(resultBox5);
            Controls.Add(resultBox4);
            Controls.Add(resultBox3);
            Controls.Add(resultBox2);
            Controls.Add(resultBox1);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem karanlıkModToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem karanlıkToolStripMenuItem;
        private ToolStripMenuItem aydınlıkToolStripMenuItem;
        private Panel panel1;
        private Label Baslik;
        private PictureBox pictureBox1;
        private ToolStripMenuItem nasılOynanırToolStripMenuItem;
        private Panel panel2;
        private Label informationTextHeader;
        private Label informationText1;
        private Label informationText2;
        private Label informationText6;
        private Label informationText3;
        private Label informationText5;
        private Label informationText4;
        private PictureBox pictureBox2;
        private TextBox resultBox1;
        private TextBox resultBox2;
        private TextBox resultBox3;
        private TextBox resultBox4;
        private TextBox resultBox5;
        private TextBox resultBox6;
        private Panel panel3;
        private TextBox betBox1;
        private TextBox betBox6;
        private TextBox betBox5;
        private TextBox betBox4;
        private TextBox betBox3;
        private TextBox betBox2;
        private Label numbersText;
        private Label label2;
        private Button buttonbahis;
        private TextBox valueBox;
        private TextBox dice2;
        private TextBox dice4;
        private TextBox dice5;
        private TextBox dice3;
        private TextBox dice6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sesToolStripMenuItem;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem kapatToolStripMenuItem;
    }
}
