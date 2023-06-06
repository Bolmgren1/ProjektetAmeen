namespace Projektet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Add(10);
            listBox1.Items.Add(20);

            listBox1.SelectedItem = listBox1.Items[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tal = listBox1.SelectedItem.ToString();

            int största = int.Parse(tal);
            Random random = new Random();

            int Datornstal = random.Next(1, största + 1);

            int dittTal = int.Parse(textBox1.Text);

            if (dittTal == Datornstal)
            {
                label6.Text = "Du svarade rätt";
                label4.Text = "Datorn fick " + Datornstal;
            }
            else if (dittTal < Datornstal)
            {
                label6.Text = "Du svarade för lågt";
                label4.Text = "Datorn fick " + Datornstal;
            }
            else
            {
                label6.Text = "Du svarade för högt";
                label4.Text = "Datorn fick " + Datornstal;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}