namespace GameOfChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void karanlýkModToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void karanlýkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void aydýnlýkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void hakkýmýzdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://github.com/BerkantHrmc", "Hakkýmýzda",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void nasýlOynanýrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Altý zarýn altýsýný da tuttur büyük ödülü kap! " +
                "2 tutan ve üstü için ödüller ekranda gözükmektedir.", "Nasýl Oyanýr ? "
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void informationtext_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void informationText_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ToUpper();
        }
    }
}
