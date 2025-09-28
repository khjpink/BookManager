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
    public partial class MainForm : Form, IRefresh
    {
        public MainForm()
        {
            InitializeComponent();
            RefreshScreen();
        }
        public void RefreshScreen()
        {
            lblTotalBooks.Text = "전체 도서 수 : " + DataManager.books.Count;
            lblTotalUsers.Text = "전체 회원 수 : " + DataManager.users.Count;

            dgvBooks.DataSource = null;
            if (DataManager.books.Count > 0)
                dgvBooks.DataSource = DataManager.books;
        }

        private void ToolStripMenuItem_BookManagement_Click(object sender, EventArgs e)
        {
            Hide(); // 현재 창 숨김
            BookForm f = new BookForm();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog(); // 뒤에 창 선택 못함 
            RefreshScreen();
            Show(); // 현재 창 보이게
        }

        private void ToolStripMenuItem_UserManagement_Click(object sender, EventArgs e)
        {
            Hide();
            UserForm f = new UserForm();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            Show();
        }

        private void Button_Borrow_Click(object sender, EventArgs e)
        {

        }

        private void Button_Return_Click(object sender, EventArgs e)
        {

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
