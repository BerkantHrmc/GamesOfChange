using System.Runtime.Intrinsics.Arm;

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
            int value;
            int.TryParse(valueBox.Text, out value);
            


            dice2.Text = "�ki zar : " + (value * 1.3).ToString("F2");
            dice3.Text = "�� zar : " + (value * 1.6).ToString("F2");
            dice4.Text = "D�rt zar : " + (value * 2).ToString("F2");
            dice5.Text = "Be� zar : " + (value * 7).ToString("F2");
            dice6.Text = "Alt� zar : " + (value * 25).ToString("F2");
        }


        private void buttonbahis_Click(object sender, EventArgs e)
        {
            int[] betPlay = new int[6];

            // 6 farkl� TextBox'� bir dizi i�ine ald�m
            TextBox[] betBoxes = { betBox1, betBox2, betBox3, betBox4, betBox5, betBox6 };
            int value2;
            if (!int.TryParse(valueBox.Text,out value2) || value2 <30 || value2 > 100000)
            {
                MessageBox.Show("L�tfen 30 TL ile 100 bin TL aras� de�erde bir iddia olu�turun.","Miktar Hatas�"
                    ,MessageBoxButtons.OK);
                    return;
            }

            for (int k = 0; k < 6; k++)
            {
                if (!int.TryParse(betBoxes[k].Text, out betPlay[k]) || betPlay[k] < 1 || betPlay[k] > 6)
                {
                    MessageBox.Show($"L�tfen {k + 1}. kutu i�in 1 ile 6 aras�nda bir say� girin!",
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // E�er hata olursa i�lemi durdur
                }
            }

            // Ge�erli say�lar yazd�r�l�yor
            string oynananSayilar = string.Join(", ", betPlay); //String join dizideki elemanlar� birle�tirir.
            MessageBox.Show($"Oynanan Say�lar: {oynananSayilar}","�ddia ba�ar�yla olu�turuldu");







            Random rndm = new Random();
            int[] betNumbers = new int[6]; // tek tek de�i�ken olu�turmak yerine


            for (int i = 0; i < betNumbers.Length; i++)
            {
                betNumbers[i] = rndm.Next(1, 7);
            }

           
            
            

            resultBox1.Text = betNumbers[0].ToString();
            resultBox2.Text = betNumbers[1].ToString();
            resultBox3.Text = betNumbers[2].ToString();
            resultBox4.Text = betNumbers[3].ToString();
            resultBox5.Text = betNumbers[4].ToString();
            resultBox6.Text = betNumbers[5].ToString();

            if (resultBox1.Text == betBox1.Text )
            {
                resultBox1.BackColor = Color.Green;
            }
            else
            {
                resultBox1.BackColor = Color.Red;
            }
            if (resultBox2.Text == betBox2.Text)
            {
                resultBox2.BackColor = Color.Green;
            }
            else
            {
                resultBox2.BackColor = Color.Red;
            }
            if (resultBox3.Text == betBox3.Text)
            {
                resultBox3.BackColor = Color.Green;
            }
            else
            {
                resultBox3.BackColor = Color.Red;
            }
            if (resultBox4.Text == betBox4.Text)
            {
                resultBox4.BackColor = Color.Green;
            }
            else
            {
                resultBox4.BackColor = Color.Red;
            }
            if (resultBox5.Text == betBox5.Text)
            {
                resultBox5.BackColor = Color.Green;
            }
            else
            {
                resultBox5.BackColor = Color.Red;
            }
            if (resultBox6.Text == betBox6.Text)
            {
                resultBox6.BackColor = Color.Green;
            }
            else
            {
                resultBox6.BackColor = Color.Red;
            }



        }
    }
}
