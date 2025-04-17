using System.Runtime.Intrinsics.Arm;
using System.Media;
using System.Security.Cryptography.X509Certificates; // Ses çalma için gerekli kütüphane

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
                "2 tutan ve üstü için ödüller ekranda gözükmektedir.Minimum iddia tutarý : 30 TL Maksimum iddia tutarý :" +
                 "100 bin TL. Bet numaralarýný 1 ile 6 arasý rakamlarla doldur zarlar atýlsýn ödüller kapýlsýn.", "Nasýl Oyanýr ? "
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

            sesAc();

        }



        public void sesAc()
        {
            string filePath = @"C:\Users\Berkant\Desktop\Sesler\hopeful.wav";
            SoundPlayer arkaSes = new SoundPlayer(filePath);
            arkaSes.Play();
        }

        public void sesKapat()
        {
            string filePath = @"C:\Users\Berkant\Desktop\Sesler\hopeful.wav";
            SoundPlayer arkaSes = new SoundPlayer(filePath);
            arkaSes.Stop();
        }

        public void zarSesi ()
        {
            String filePath2 = @"C:\Users\Berkant\Desktop\Sesler\zarSesi.wav";
            SoundPlayer zarSesi = new SoundPlayer(filePath2);
            zarSesi.PlaySync();
        }
        public void buttonClickSound ()
        {
            String filepath3 = @"C:\Users\Berkant\Desktop\Sesler\selectButton.wav";
            SoundPlayer buttonSelectSound = new SoundPlayer(filepath3);
            buttonSelectSound.Play();
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



            dice2.Text = "Ýki zara : " + (value * 1.3).ToString("F2");
            dice3.Text = "Üç zara : " + (value * 1.6).ToString("F2");
            dice4.Text = "Dört zara : " + (value * 2).ToString("F2");
            dice5.Text = "Beþ zara : " + (value * 7).ToString("F2");
            dice6.Text = "Altý zara : " + (value * 25).ToString("F2");
        }


        private void buttonbahis_Click(object sender, EventArgs e)
        {
            int[] betPlay = new int[6];

            // 6 farklý TextBox'ý bir dizi içine aldým
            TextBox[] betBoxes = { betBox1, betBox2, betBox3, betBox4, betBox5, betBox6 };
            TextBox[] resultBoxes = { resultBox1, resultBox2, resultBox3, resultBox4, resultBox5, resultBox6 };
            //bunu textbox dizisiine atýyorum çünkü 176-232 satýrlarý arasýnda yeþil kutularý sayarken kullanacaðým
            int greenBoxCount = 0; // yeþil kutu sayýsýný buna atacaðým
            int value2;

            buttonClickSound();
            if (!int.TryParse(valueBox.Text, out value2) || value2 < 30 || value2 > 100000)
            {
                MessageBox.Show("Lütfen 30 TL ile 100 bin TL arasý deðerde bir iddia oluþturun.", "Miktar Hatasý"
                    , MessageBoxButtons.OK);
                return;
            }

            for (int k = 0; k < 6; k++)
            {
                if (!int.TryParse(betBoxes[k].Text, out betPlay[k]) || betPlay[k] < 1 || betPlay[k] > 6)
                {
                    MessageBox.Show($"Lütfen {k + 1}. kutu için 1 ile 6 arasýnda bir sayý girin!",
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Eðer hata olursa iþlemi durdur
                }
            }

            

            // Geçerli sayýlar yazdýrýlýyor
            string oynananSayilar = string.Join(", ", betPlay); //String join dizideki elemanlarý birleþtirir.
            MessageBox.Show($"Oynanan Sayýlar: {oynananSayilar}", "Ýddia baþarýyla oluþturuldu",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            Random rndm = new Random();
            int[] betNumbers = new int[6]; // tek tek deðiþken oluþturmak yerine


            for (int i = 0; i < betNumbers.Length; i++)
            {
                betNumbers[i] = rndm.Next(1, 7);
            }

            zarSesi();
            resultBox1.Text = betNumbers[0].ToString();
            resultBox2.Text = betNumbers[1].ToString();
            resultBox3.Text = betNumbers[2].ToString();
            resultBox4.Text = betNumbers[3].ToString();
            resultBox5.Text = betNumbers[4].ToString();
            resultBox6.Text = betNumbers[5].ToString();

            if (resultBox1.Text == betBox1.Text)
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

            for (int k = 0; k < 6; k++)
            {
                if (resultBoxes[k].BackColor == Color.Green)
                {
                    greenBoxCount++;
                }
            }

            switch (greenBoxCount)
            {
                case 1:
                    MessageBox.Show("Bir sayý tutturdunuz ve paranýz iade oldu.");
                    break;
                case 2:
                    MessageBox.Show($"Ýki sayý tutturdunuz {dice2.Text}  ");
                    break;
                case 3:
                    MessageBox.Show($"Üç sayý tutturdunuz :{dice3.Text}  ");
                    break;
                case 4:
                    MessageBox.Show($"Dört sayý tutturdunuz {dice4.Text}  ");
                    break;
                case 5:
                    MessageBox.Show($"Beþ sayý tutturdunuz {dice5.Text}  ");
                    break;
                case 6:
                    MessageBox.Show($"Altý sayý tutturdunuz {dice6.Text}  ");
                    break;
                default:
                    MessageBox.Show("Malesef hiçbir sayý tutmadý -_-");
                    break;
            }

            sesAc();


        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sesKapat();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sesAc();
        }
        private void sesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
