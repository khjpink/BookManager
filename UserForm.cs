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
        }

        public void RefreshScreen()
        {
            throw new NotImplementedException();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }
    }
}