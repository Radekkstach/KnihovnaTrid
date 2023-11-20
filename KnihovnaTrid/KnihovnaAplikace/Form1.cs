using KnihovnaTrid;
namespace KnihovnaAplikace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] pole = Pole.Nacti(5);
            for (int i = 0; i < pole.Length; i++)
            {
                listBox1.Items.Add(pole[i]);
            }
            //listBox1.Items.Add(Pole.Nacti(5)); // natocit cyklem
        }
    }
}