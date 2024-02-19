namespace Faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Faktoriyel";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = 1;
            int n = Convert.ToInt32(textBox1.Text);
            for (int s = 1; s <= n; s++)
                f = f * s;
            label2.Text = n + " ! =" + f;
        }

        
    }
}
