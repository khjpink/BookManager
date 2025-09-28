namespace BookManager
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuBookManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDelayedBooks = new System.Windows.Forms.Label();
            this.lblLentBooks = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvUsers = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.dgvBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dgvUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBookManagement,
            this.menuUserManagement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuBookManagement
            // 
            this.menuBookManagement.Name = "menuBookManagement";
            this.menuBookManagement.Size = new System.Drawing.Size(67, 20);
            this.menuBookManagement.Text = "도서관리";
            this.menuBookManagement.Click += new System.EventHandler(this.ToolStripMenuItem_BookManagement_Click);
            // 
            // menuUserManagement
            // 
            this.menuUserManagement.Name = "menuUserManagement";
            this.menuUserManagement.Size = new System.Drawing.Size(79, 20);
            this.menuUserManagement.Text = "사용자관리";
            this.menuUserManagement.Click += new System.EventHandler(this.ToolStripMenuItem_UserManagement_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.lblDelayedBooks);
            this.groupBox1.Controls.Add(this.lblLentBooks);
            this.groupBox1.Controls.Add(this.lblTotalUsers);
            this.groupBox1.Controls.Add(this.lblTotalBooks);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서 및 회원 현황";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDelayedBooks
            // 
            this.lblDelayedBooks.AutoSize = true;
            this.lblDelayedBooks.Location = new System.Drawing.Point(10, 129);
            this.lblDelayedBooks.Name = "lblDelayedBooks";
            this.lblDelayedBooks.Size = new System.Drawing.Size(121, 12);
            this.lblDelayedBooks.TabIndex = 7;
            this.lblDelayedBooks.Text = "연체 중인 도서의 수 :";
            this.lblDelayedBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLentBooks
            // 
            this.lblLentBooks.AutoSize = true;
            this.lblLentBooks.Location = new System.Drawing.Point(10, 96);
            this.lblLentBooks.Name = "lblLentBooks";
            this.lblLentBooks.Size = new System.Drawing.Size(121, 12);
            this.lblLentBooks.TabIndex = 6;
            this.lblLentBooks.Text = "대출 중인 도서의 수 :";
            this.lblLentBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Location = new System.Drawing.Point(10, 63);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(81, 12);
            this.lblTotalUsers.TabIndex = 5;
            this.lblTotalUsers.Text = "전체 회원 수 :";
            this.lblTotalUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalUsers.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Location = new System.Drawing.Point(10, 30);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(81, 12);
            this.lblTotalBooks.TabIndex = 4;
            this.lblTotalBooks.Text = "전체 도서 수 :";
            this.lblTotalBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalBooks.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Controls.Add(this.btnReturn);
            this.groupBox2.Controls.Add(this.btnBorrow);
            this.groupBox2.Controls.Add(this.txtUserId);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.txtIsbn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(408, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "도서 및 회원 선택";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Silver;
            this.btnReturn.Location = new System.Drawing.Point(297, 57);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "반납";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.Button_Return_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Silver;
            this.btnBorrow.Location = new System.Drawing.Point(297, 22);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "대출";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.Button_Borrow_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(72, 92);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(219, 21);
            this.txtUserId.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(72, 58);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(219, 21);
            this.txtTitle.TabIndex = 12;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(72, 24);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(219, 21);
            this.txtIsbn.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "회원 ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "책 제목";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "책 ISBN";
            // 
            // dgvBooks
            // 
            this.dgvBooks.BackColor = System.Drawing.SystemColors.Menu;
            this.dgvBooks.Controls.Add(this.dataGridView1);
            this.dgvBooks.Location = new System.Drawing.Point(12, 211);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(786, 220);
            this.dgvBooks.TabIndex = 2;
            this.dgvBooks.TabStop = false;
            this.dgvBooks.Text = "도서 목록";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(762, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackColor = System.Drawing.SystemColors.Menu;
            this.dgvUsers.Controls.Add(this.dataGridView2);
            this.dgvUsers.Location = new System.Drawing.Point(12, 437);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(786, 199);
            this.dgvUsers.TabIndex = 3;
            this.dgvUsers.TabStop = false;
            this.dgvUsers.Text = "회원 목록";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(423, 176);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 690);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도서 관리 프로그램";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dgvBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dgvUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuBookManagement;
        private System.Windows.Forms.ToolStripMenuItem menuUserManagement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox dgvBooks;
        private System.Windows.Forms.GroupBox dgvUsers;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblDelayedBooks;
        private System.Windows.Forms.Label lblLentBooks;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

