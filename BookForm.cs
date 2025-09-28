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
    public partial class BookForm : Form, IRefresh
    {
        public BookForm()
        {
            InitializeComponent();
            RefreshScreen();
        }

        public void RefreshScreen()
        {
            //dgvBooks.DataSource = null;
            //if (DataManager.books.Count > 0)
            //    dgvBooks.DataSource = DataManager.books;
            bookBindingSource.DataSource = null;
            if (DataManager.books.Count > 0)
                bookBindingSource.DataSource = DataManager.books;
        }

        
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            bool existBook = false;
            foreach (var item in DataManager.books)
            {
                if (item.Isbn.Equals(txtIsbn.Text))
                {
                    existBook = true;
                    break;
                }
            }
            if (existBook)
                MessageBox.Show("ISBN 중복입니다. 해당 책이 이미 있습니다.");
            else
            {
                Book newBook = new Book();
                newBook.Isbn = txtIsbn.Text;
                newBook.Name = txtName.Text;
                DataManager.books.Add(newBook);
                RefreshScreen();
                DataManager.Save();
            }
        }

        private void BtnEditBook_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {

        }

        private void TxtIsbn_Click(object sender, EventArgs e)
        {

        }

        private void TxtTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
