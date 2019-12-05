using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
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
            MessageBox.Show("Нажата клавиша: " + key);
        }
    }
}
