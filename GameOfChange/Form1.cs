namespace GameOfChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void karanl�kModToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void karanl�kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void ayd�nl�kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void hakk�m�zdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://github.com/BerkantHrmc", "Hakk�m�zda",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void nas�lOynan�rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alt� zar�n alt�s�n� da tuttur b�y�k �d�l� kap! " +
                "2 tutan ve �st� i�in �d�ller ekranda g�z�kmektedir.", "Nas�l Oyan�r ? "
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
