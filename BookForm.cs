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
            Book book = null;
            for(int i=0; i<DataManager.books.Count; i++)
            {
                if (DataManager.books[i].Isbn.Equals(txtIsbn.Text))
                {
                    book = DataManager.books[i];
                    book.Name = txtName.Text;
                    RefreshScreen();
                    DataManager.Save();
                    MessageBox.Show("수정되었습니다.");
                    break;
                }
            }
            if (book == null)
                MessageBox.Show("해당 책이 없어서 수정 불가능합니다.");
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            bool existBook = false;

            for(int i=0; i<DataManager.books.Count; i++)
            {
                if (DataManager.books[i].Isbn.Equals(txtIsbn.Text))
                {
                    DataManager.books.RemoveAt(i);
                    existBook = true;
                    MessageBox.Show("삭제 되었습니다.");
                    break;
                }
            }
            if(existBook)
            {
                RefreshScreen();
                DataManager.Save();
            }
            else
            {
                MessageBox.Show("해당 책이 없으므로 삭제 불가능합니다.");
            }
        }

        private void DgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = dgvBooks.CurrentRow.DataBoundItem as Book;
            txtIsbn.Text = book.Isbn;
            txtName.Text = book.Name;
        }

    }
}
