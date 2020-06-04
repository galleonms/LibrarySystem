namespace LibrarySistem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.overviewButton = new System.Windows.Forms.Button();
            this.loanManagementButton = new System.Windows.Forms.Button();
            this.createUserButton = new System.Windows.Forms.Button();
            this.createBookButton = new System.Windows.Forms.Button();
            this.createBookPanel = new System.Windows.Forms.Panel();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.bookAuthorBox = new System.Windows.Forms.TextBox();
            this.bookTitleBox = new System.Windows.Forms.TextBox();
            this.bookAuthor = new System.Windows.Forms.Label();
            this.bookIsbn = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.Label();
            this.saveBookButton = new System.Windows.Forms.Button();
            this.loanManagementPanel = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.loanButton = new System.Windows.Forms.Button();
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.overviewPanel = new System.Windows.Forms.Panel();
            this.showUsersButton = new System.Windows.Forms.Button();
            this.showBooksButton = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.createBookPanel.SuspendLayout();
            this.loanManagementPanel.SuspendLayout();
            this.overviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // overviewButton
            // 
            this.overviewButton.Location = new System.Drawing.Point(52, 365);
            this.overviewButton.Name = "overviewButton";
            this.overviewButton.Size = new System.Drawing.Size(151, 76);
            this.overviewButton.TabIndex = 0;
            this.overviewButton.Text = "Overview";
            this.overviewButton.UseVisualStyleBackColor = true;
            this.overviewButton.Click += new System.EventHandler(this.overviewButton_Click);
            // 
            // loanManagementButton
            // 
            this.loanManagementButton.Location = new System.Drawing.Point(52, 257);
            this.loanManagementButton.Name = "loanManagementButton";
            this.loanManagementButton.Size = new System.Drawing.Size(151, 76);
            this.loanManagementButton.TabIndex = 1;
            this.loanManagementButton.Text = "Loan Management";
            this.loanManagementButton.UseVisualStyleBackColor = true;
            this.loanManagementButton.Click += new System.EventHandler(this.loanManagementButton_Click);
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(52, 155);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(151, 76);
            this.createUserButton.TabIndex = 2;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // createBookButton
            // 
            this.createBookButton.Location = new System.Drawing.Point(52, 52);
            this.createBookButton.Name = "createBookButton";
            this.createBookButton.Size = new System.Drawing.Size(151, 76);
            this.createBookButton.TabIndex = 3;
            this.createBookButton.Text = "Create Book";
            this.createBookButton.UseVisualStyleBackColor = true;
            this.createBookButton.Click += new System.EventHandler(this.createBookButton_Click);
            // 
            // createBookPanel
            // 
            this.createBookPanel.Controls.Add(this.isbnBox);
            this.createBookPanel.Controls.Add(this.bookAuthorBox);
            this.createBookPanel.Controls.Add(this.bookTitleBox);
            this.createBookPanel.Controls.Add(this.bookAuthor);
            this.createBookPanel.Controls.Add(this.bookIsbn);
            this.createBookPanel.Controls.Add(this.bookTitle);
            this.createBookPanel.Controls.Add(this.saveBookButton);
            this.createBookPanel.Location = new System.Drawing.Point(220, 54);
            this.createBookPanel.Name = "createBookPanel";
            this.createBookPanel.Size = new System.Drawing.Size(670, 380);
            this.createBookPanel.TabIndex = 4;
            // 
            // isbnBox
            // 
            this.isbnBox.Location = new System.Drawing.Point(228, 179);
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(205, 22);
            this.isbnBox.TabIndex = 5;
            // 
            // bookAuthorBox
            // 
            this.bookAuthorBox.Location = new System.Drawing.Point(228, 129);
            this.bookAuthorBox.Name = "bookAuthorBox";
            this.bookAuthorBox.Size = new System.Drawing.Size(205, 22);
            this.bookAuthorBox.TabIndex = 4;
            // 
            // bookTitleBox
            // 
            this.bookTitleBox.Location = new System.Drawing.Point(228, 78);
            this.bookTitleBox.Name = "bookTitleBox";
            this.bookTitleBox.Size = new System.Drawing.Size(205, 22);
            this.bookTitleBox.TabIndex = 3;
            // 
            // bookAuthor
            // 
            this.bookAuthor.AutoSize = true;
            this.bookAuthor.Location = new System.Drawing.Point(114, 132);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(86, 17);
            this.bookAuthor.TabIndex = 2;
            this.bookAuthor.Text = "Book Author";
            // 
            // bookIsbn
            // 
            this.bookIsbn.AutoSize = true;
            this.bookIsbn.Location = new System.Drawing.Point(161, 182);
            this.bookIsbn.Name = "bookIsbn";
            this.bookIsbn.Size = new System.Drawing.Size(39, 17);
            this.bookIsbn.TabIndex = 1;
            this.bookIsbn.Text = "ISBN";
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Location = new System.Drawing.Point(129, 81);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(71, 17);
            this.bookTitle.TabIndex = 0;
            this.bookTitle.Text = "Book Title";
            // 
            // saveBookButton
            // 
            this.saveBookButton.Location = new System.Drawing.Point(297, 235);
            this.saveBookButton.Name = "saveBookButton";
            this.saveBookButton.Size = new System.Drawing.Size(136, 34);
            this.saveBookButton.TabIndex = 6;
            this.saveBookButton.Text = "Save Book";
            this.saveBookButton.UseVisualStyleBackColor = true;
            this.saveBookButton.Click += new System.EventHandler(this.saveBookButton_Click);
            // 
            // loanManagementPanel
            // 
            this.loanManagementPanel.Controls.Add(this.returnButton);
            this.loanManagementPanel.Controls.Add(this.loanButton);
            this.loanManagementPanel.Controls.Add(this.bookComboBox);
            this.loanManagementPanel.Controls.Add(this.userComboBox);
            this.loanManagementPanel.Controls.Add(this.label2);
            this.loanManagementPanel.Controls.Add(this.label1);
            this.loanManagementPanel.Location = new System.Drawing.Point(222, 56);
            this.loanManagementPanel.Name = "loanManagementPanel";
            this.loanManagementPanel.Size = new System.Drawing.Size(670, 380);
            this.loanManagementPanel.TabIndex = 7;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(328, 198);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(123, 51);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // loanButton
            // 
            this.loanButton.Location = new System.Drawing.Point(164, 198);
            this.loanButton.Name = "loanButton";
            this.loanButton.Size = new System.Drawing.Size(123, 51);
            this.loanButton.TabIndex = 4;
            this.loanButton.Text = "Loan";
            this.loanButton.UseVisualStyleBackColor = true;
            this.loanButton.Click += new System.EventHandler(this.loanButton_Click);
            // 
            // bookComboBox
            // 
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(227, 148);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(224, 24);
            this.bookComboBox.TabIndex = 3;
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(227, 92);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(224, 24);
            this.userComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // overviewPanel
            // 
            this.overviewPanel.Controls.Add(this.showUsersButton);
            this.overviewPanel.Controls.Add(this.showBooksButton);
            this.overviewPanel.Controls.Add(this.dataGrid);
            this.overviewPanel.Location = new System.Drawing.Point(219, 53);
            this.overviewPanel.Name = "overviewPanel";
            this.overviewPanel.Size = new System.Drawing.Size(670, 388);
            this.overviewPanel.TabIndex = 8;
            // 
            // showUsersButton
            // 
            this.showUsersButton.Location = new System.Drawing.Point(414, 266);
            this.showUsersButton.Name = "showUsersButton";
            this.showUsersButton.Size = new System.Drawing.Size(144, 60);
            this.showUsersButton.TabIndex = 2;
            this.showUsersButton.Text = "Show Users";
            this.showUsersButton.UseVisualStyleBackColor = true;
            this.showUsersButton.Click += new System.EventHandler(this.showUsersButton_Click);
            // 
            // showBooksButton
            // 
            this.showBooksButton.Location = new System.Drawing.Point(115, 266);
            this.showBooksButton.Name = "showBooksButton";
            this.showBooksButton.Size = new System.Drawing.Size(143, 60);
            this.showBooksButton.TabIndex = 1;
            this.showBooksButton.Text = "Show Books";
            this.showBooksButton.UseVisualStyleBackColor = true;
            this.showBooksButton.Click += new System.EventHandler(this.showBooksButton_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(73, 21);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(531, 227);
            this.dataGrid.TabIndex = 0;
            // 
            // saveUserButton
            // 
            this.saveUserButton.Location = new System.Drawing.Point(296, 234);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(136, 34);
            this.saveUserButton.TabIndex = 6;
            this.saveUserButton.Text = "Save User";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // userIdBox
            // 
            this.userIdBox.Location = new System.Drawing.Point(227, 178);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(205, 22);
            this.userIdBox.TabIndex = 5;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(227, 128);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(205, 22);
            this.lastNameBox.TabIndex = 4;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(227, 77);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(205, 22);
            this.firstNameBox.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(123, 131);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(76, 17);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Last Name";
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Location = new System.Drawing.Point(144, 181);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(55, 17);
            this.userId.TabIndex = 1;
            this.userId.Text = "User ID";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(128, 80);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(76, 17);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name";
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.userIdBox);
            this.userPanel.Controls.Add(this.lastNameBox);
            this.userPanel.Controls.Add(this.firstNameBox);
            this.userPanel.Controls.Add(this.lastName);
            this.userPanel.Controls.Add(this.firstName);
            this.userPanel.Controls.Add(this.saveUserButton);
            this.userPanel.Controls.Add(this.userId);
            this.userPanel.Location = new System.Drawing.Point(221, 55);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(670, 380);
            this.userPanel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 504);
            this.Controls.Add(this.createBookButton);
            this.Controls.Add(this.loanManagementButton);
            this.Controls.Add(this.overviewButton);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.loanManagementPanel);
            this.Controls.Add(this.overviewPanel);
            this.Controls.Add(this.createBookPanel);
            this.Controls.Add(this.userPanel);
            this.Name = "Form1";
            this.Text = "Library System";
            this.createBookPanel.ResumeLayout(false);
            this.createBookPanel.PerformLayout();
            this.loanManagementPanel.ResumeLayout(false);
            this.loanManagementPanel.PerformLayout();
            this.overviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button overviewButton;
        private System.Windows.Forms.Button loanManagementButton;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button createBookButton;
        private System.Windows.Forms.Panel createBookPanel;
        private System.Windows.Forms.Button saveBookButton;
        private System.Windows.Forms.TextBox isbnBox;
        private System.Windows.Forms.TextBox bookAuthorBox;
        private System.Windows.Forms.TextBox bookTitleBox;
        private System.Windows.Forms.Label bookAuthor;
        private System.Windows.Forms.Label bookIsbn;
        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.Panel loanManagementPanel;
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label userId;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button loanButton;
        private System.Windows.Forms.Panel overviewPanel;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button showUsersButton;
        private System.Windows.Forms.Button showBooksButton;
    }
}

