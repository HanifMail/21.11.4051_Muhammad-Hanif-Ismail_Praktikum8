using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void tampilan(int nilaiA, int nilaiB, int hasil, string simbol, string operasihitung)
		{
			listBox1.Items.Add(string.Format("Hasil {0} {1} {2} {3} = {4}", operasihitung, nilaiA, simbol, nilaiB, hasil));
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void button1_Click_1(object sender, EventArgs e)
		{
			Calculator calculator = new Calculator();
			calculator.handler += tampilan;
			calculator.ShowDialog();
		}
	}
}
