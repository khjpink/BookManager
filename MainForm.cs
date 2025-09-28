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

        delegate void BtnEvent(object s, EventArgs e);

        public MainForm()
        {
            InitializeComponent();
            RefreshScreen();
<<<<<<< HEAD
            dgvBooks.CellClick += delegate (object o, DataGridViewCellEventArgs e) // 무명 델리게이트
            {
                DataGridView thisView = o as DataGridView; // o 이벤트 발생시키는 주체
=======
            dgvBooks.CellClick += delegate (object o, DataGridViewCellEventArgs e)
            {
                DataGridView thisView = o as DataGridView;
>>>>>>> 230cdc7ff1d89e11b09b45d44f5d9a71ddbf14a1
                Book selectBook = thisView.CurrentRow.DataBoundItem as Book;
                txtIsbn.Text = selectBook.Isbn;
                txtName.Text = selectBook.Name;
            };
<<<<<<< HEAD
            dgvUsers.CellClick += (o, e) => // 람다 
=======
            dgvUsers.CellClick += (o, e) =>
>>>>>>> 230cdc7ff1d89e11b09b45d44f5d9a71ddbf14a1
            {
                User selectUsere = (o as DataGridView).CurrentRow.DataBoundItem as User;
                txtUserId.Text = selectUsere.Id;
            };

<<<<<<< HEAD
            BtnEvent borrowEvent = delegate(object s, EventArgs e) // 대여
            {
                if (txtIsbn.Text.Trim().Equals(""))
                    MessageBox.Show("ISBN을 입력하셔야 도서 대출이 가능합니다.");
                else if (txtUserId.Text.Trim().Equals(""))
                    MessageBox.Show("회원 ID를 알아야 도서 대출이 가능합니다.");
                else
                {
                    try
                    {
                        //Single : ()안에 반환하는 조건을 하나 얕은 복사로 가져옴
                        //얕은 복사 : book값이 바뀌면 books에도 영향을 준다는 뜻
                        //()값이 trur가 아니면 Exception으로 이동함
                        Book book = DataManager.books.Single(item => item.Isbn.Equals(txtIsbn.Text));
                        if (book.IsBorrowed)
                            MessageBox.Show("대여중인 책입니다.");
                        else
                        {
                            try
                            {
                                User u = DataManager.users.Single(item => item.Id.Equals(txtUserId.Text));
                                book.UserId = u.Id;
                                book.UserName = u.Name;
                                book.IsBorrowed = true;
                                book.BorrowedAt = DateTime.Now;
                                RefreshScreen();
                                DataManager.Save();
                                MessageBox.Show($"{book.Isbn}책을 {u.Id}님이 대출합니다");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("해당 ID를 가진 회원은 없으므로 도서 대출이 불가능합니다.");
                                System.Diagnostics.Debug.WriteLine($"실패 :{ ex.Message}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("해당 ISBN은 존재하지 않으므로 도서 대출이 불가능합니다.");
                        System.Diagnostics.Debug.WriteLine($"실패 :{ex.Message}");
                    }
                };                ;


            };

            BtnEvent returnEvent = (s, e) => // 반납 
            {
                if (txtIsbn.Text.Trim().Equals(""))
                    MessageBox.Show("ISBN이 없어서 반납이 불가능합니다.");
                else 
                {
                    try
                    {
                        Book book = DataManager.books.Single(delegate (Book item) { return item.Isbn.Equals(txtIsbn.Text); });
                        if (book.IsBorrowed == false)
                            MessageBox.Show("아직 안 빌렸으므로 반납 불가능합니다.");
                        else
                        {
                            book.UserId = ""; // single은 얕은 복사이기 때문에 book를 수정하면 books에 영향을 준다 
                            book.UserName = "";
                            book.IsBorrowed = false;

                            //연체 여부 체크
                            DateTime oldDay = book.BorrowedAt;
                            book.BorrowedAt = new DateTime(); // 반납 했음으로 날짜 초기화

                            TimeSpan timeDiff = DateTime.Now - oldDay;
                            if(timeDiff.Days > 7)
                                MessageBox.Show("연체 반납입니다.");
                            else
                                MessageBox.Show("기간내 반납입니다.");
                            RefreshScreen();
                            DataManager.Save();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("해당 ISBN은 존재하지 않으므로 반납 불가능합니다.");
                        System.Diagnostics.Debug.WriteLine($"실패 :{ex.Message}");
                    }
                }
            };
            btnBorrow.Click += new EventHandler(borrowEvent);
            btnReturn.Click += new EventHandler(returnEvent);
        }

        private bool CheckBorrowed(Book item)
        {
            return item.IsBorrowed;
=======
>>>>>>> 230cdc7ff1d89e11b09b45d44f5d9a71ddbf14a1
        }
        public void RefreshScreen()
        {
            lblTotalBooks.Text = "전체 도서 수 : " + DataManager.books.Count;
            lblTotalUsers.Text = "전체 회원 수 : " + DataManager.users.Count;
            lblLentBooks.Text = "대출 중인 도서의 수 : ";
            lblLentBooks.Text += DataManager.books.Where(CheckBorrowed).Count();
            lblDelayedBooks.Text = "연체 중인 도서의 수 : ";
            lblDelayedBooks.Text += DataManager.books.Where(delegate (Book item)
            {
                return item.IsBorrowed && item.BorrowedAt.AddDays(7) < DateTime.Now; // 7일이 지나면 연체됨
            }).Count();

            dgvBooks.DataSource = null;
            if (DataManager.books.Count > 0)
                dgvBooks.DataSource = DataManager.books;

            dgvUsers.DataSource = null;
            if (DataManager.users.Count > 0)
                dgvUsers.DataSource = DataManager.users;
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
            RefreshScreen();
            Show();
        }



<<<<<<< HEAD
        private void MainForm_Load(object sender, EventArgs e)
=======
        private void Button_Return_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
>>>>>>> 230cdc7ff1d89e11b09b45d44f5d9a71ddbf14a1
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
