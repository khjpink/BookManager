using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide(); // 현재 창 숨김
            Form2 f = new Form2();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog(); // 뒤에 창 선택 못함 
            Show(); // 현재 창 보이게
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 f = new Form3();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
