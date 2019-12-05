using System.Windows.Forms;
using Would.Classes;

namespace Would
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Hook.Start(test);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hook.Stop();
        }

        public static void test(int key)
        {
            MessageBox.Show("Key pressed: " + key);
        }
    }
}
