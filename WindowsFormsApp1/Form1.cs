using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySistem
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=LAPTOP-RJMIT47O\SQL2017;Initial Catalog=Test;Integrated Security=True";
        DataTable userdt = new DataTable(), bookdt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter userAdapter = new SqlDataAdapter("SELECT * FROM Username", conn);
                userAdapter.Fill(userdt);
                for (int i = 0; i < userdt.Rows.Count; i++)
                {
                    string name = userdt.Rows[i]["Firstname"].ToString() + " " + userdt.Rows[i]["Lastname"].ToString();
                    userComboBox.Items.Add(name);
                }
                SqlDataAdapter bookAdapter = new SqlDataAdapter("SELECT * FROM Book", conn);
                bookAdapter.Fill(bookdt);
                for (int j = 0; j < bookdt.Rows.Count; j++)
                {
                    string book = bookdt.Rows[j]["BookTitle"].ToString();
                    bookComboBox.Items.Add(book);
                }

            }
            userPanel.Visible = false;
            loanManagementPanel.Visible = false;
            overviewPanel.Visible = false;
            createBookPanel.Visible = true;

        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            userPanel.Visible = true;
            loanManagementPanel.Visible = false;
            overviewPanel.Visible = false;
            createBookPanel.Visible = false;
        }

        private void loanManagementButton_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            loanManagementPanel.Visible = true;
            overviewPanel.Visible = false;
            createBookPanel.Visible = false;
           

        }

        private void createBookButton_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            loanManagementPanel.Visible = false;
            overviewPanel.Visible = false;
            createBookPanel.Visible = true;
        }

        private void overviewButton_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            loanManagementPanel.Visible = false;
            overviewPanel.Visible = true;
            createBookPanel.Visible = false;
        }

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Book(BookTitle, Author, ISBN, Availability)  VALUES ('" + bookTitleBox.Text + "','" + bookAuthorBox.Text + 
                "','" + isbnBox.Text + "', '1')";
            cmd.Connection = conn;
            
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                bookTitleBox.Clear();
                bookAuthorBox.Clear();
                isbnBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Username (FirstName, LastName, UserId)  VALUES ('" + firstNameBox.Text + "','" + lastNameBox.Text +
                "','" + userIdBox.Text + "')";
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                firstNameBox.Clear();
                lastNameBox.Clear();
                userIdBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showBooksButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM LibraryBook", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGrid.DataSource = dt;
                conn.Close();
            }
        }

        private void showUsersButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Username", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGrid.DataSource = dt;
                conn.Close();
            }
        }

        private void loanButton_Click(object sender, EventArgs e)
        {
            LoanBook(bookComboBox.Text);              
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            ReturnBook(bookComboBox.Text);            
        }

        public bool LoanBook(string bookTitle)
        {
            var result = false;
            bookTitle = bookComboBox.Text;
            for (int i = 0; i < bookdt.Rows.Count; i++)
            {
                var available = bookdt.Rows[i]["Availability"].ToString();
                if (available == "False")
                    MessageBox.Show("Book can not be borrowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE BOOK SET Availability = 0 WHERE BookTitle = '" + bookTitle + "'";
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Book loan successfully", "Loan Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                            result = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }

            }
            return result;
        }
        public bool ReturnBook(string bookTitle)
        {
            var result = false;
            bookTitle = bookComboBox.Text;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE BOOK SET Availability = 1 WHERE BookTitle = '" + bookTitle + "'";
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book returned successfully", "Return Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return result;
        }
    }
}
