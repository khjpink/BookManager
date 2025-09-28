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
        }

        public void RefreshScreen()
        {
            throw new NotImplementedException();
        }
    }
}
