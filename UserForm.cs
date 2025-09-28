using BookManager;
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
    public partial class UserForm : Form, IRefresh
    {
        public UserForm()
        {
            InitializeComponent();
            RefreshScreen();
        }
        public void RefreshScreen()
        {
            dgvUsers.DataSource = null;
            if (DataManager.users.Count > 0)
            {
                dgvUsers.DataSource = DataManager.users;
                dgvUsers.Columns[0].HeaderText = "ID";
                dgvUsers.Columns[1].HeaderText = "이름";
            }
        }


        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (DataManager.users.Exists(item => item.Id.Equals(txtUserId.Text)))
                MessageBox.Show("ID 중복입니다. 생성 불가!");
            else
            {
                User newUser = new User();
                newUser.Id = txtUserId.Text;
                newUser.Name = txtUserName.Text;
                DataManager.users.Add(newUser);
                RefreshScreen();
                DataManager.Save();
                MessageBox.Show("회원 추가 완료!");
            }
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            User user = null;
            for (int i = 0; i < DataManager.users.Count; i++)
            {
                if (DataManager.users[i].Id.Equals(txtUserId.Text))
                {
                    user = DataManager.users[i];
                    user.Name = txtUserName.Text;
                    RefreshScreen();
                    DataManager.Save();
                    MessageBox.Show("수정되었습니다.");
                    break;
                }
            }
            if (user == null)
                MessageBox.Show("해당 이름이 없어서 수정 불가능합니다.");
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            //bool existUser = false;
            for(int i=0; i<DataManager.users.Count; i++)
            {
                if (DataManager.users[i].Id.Equals(txtUserId.Text))
                {
                    DataManager.users.RemoveAt(i);
                    //existUser = true;
                    MessageBox.Show("삭제 되었습니다.");
                    RefreshScreen();
                    break;
                }
            }
        }

        private void DgvUsers_CellCilck(object sender, DataGridViewCellEventArgs e)
        {
            User user = dgvUsers.CurrentRow.DataBoundItem as User;
            txtUserId.Text = user.Id;
            txtUserName.Text = user.Name;
        }
    }
}