namespace ForumlarArasıGeçiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {

                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!!!");
            }
        }

    }
}