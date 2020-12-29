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

namespace Library_GUI
{
    public partial class BooksForm : Form
    {
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandu\OneDrive\Desktop\Indrivo_Practice\Library_GUI\Library_GUI_DB.mdf;Integrated Security=True;Connect Timeout=30");
        int Book_Id = 0;
        public BooksForm()
        {
            InitializeComponent();
        }
        /*links to other pages*/
        private void txtStudentBorrows_Click(object sender, EventArgs e)
        {
            new BorrowsForm().Show();
            this.Hide();
        }

        private void txtStudentBooks_Click(object sender, EventArgs e)
        {
            new StudentsForm().Show();
            this.Hide();
        }

        private void txtStudentAuthors_Click(object sender, EventArgs e)
        {
            new AuthorsForm().Show();
            this.Hide();
        }



        /*insert button*/
        private void txtInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("BooksInsert", Sqlcon);
                if (txtInsert.Text == "Insert")
                {
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@mode", "Add");
                    sqlcmd.Parameters.AddWithValue("@Id", 0);
                    sqlcmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    sqlcmd.Parameters.AddWithValue("@Author_Id", txtAuthorId.Text);
                    sqlcmd.Parameters.AddWithValue("@Publication_Year", txtPublicationYear.Text);
                    sqlcmd.Parameters.AddWithValue("@Category_Id", txtCategoryId.Text);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Succesfully Added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                Sqlcon.Close();
            }
        }
        /*edit button*/
        private void txtEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("BooksInsert", Sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                sqlcmd.Parameters.AddWithValue("@Id", Book_Id);
                sqlcmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                sqlcmd.Parameters.AddWithValue("@Author_Id", txtAuthorId.Text);
                sqlcmd.Parameters.AddWithValue("@Publication_Year", txtPublicationYear.Text);
                sqlcmd.Parameters.AddWithValue("@Category_Id", txtCategoryId.Text);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Edited");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                Sqlcon.Close();
            }
        }
        /*search button*/
        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        /*reset function*/
        void Reset()
        {
            txtTitle.Text = txtPublicationYear.Text = txtAuthorId.Text = txtCategoryId.Text = "";
            txtEdit.Text = "Save";
            Book_Id = 0;
            txtDelete.Enabled = true;
        }
        /*Reset button*/
        private void txtReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        /*delete button*/
        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("BooksDelete", Sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@Id", Book_Id);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Deleted");
                Reset();
                FillDataGridView();
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView_Books_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Books.CurrentRow.Index != -1)
            {
                Book_Id = Convert.ToInt32(dataGridView_Books.CurrentRow.Cells[0].Value.ToString());
                txtTitle.Text = dataGridView_Books.CurrentRow.Cells[1].Value.ToString();
                txtAuthorId.Text = dataGridView_Books.CurrentRow.Cells[2].Value.ToString();
                txtPublicationYear.Text = dataGridView_Books.CurrentRow.Cells[3].Value.ToString();
                txtCategoryId.Text = dataGridView_Books.CurrentRow.Cells[4].Value.ToString();
                txtDelete.Enabled = true;

            }
        }

        private void dataGridView_Books_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_Books.CurrentRow.Index != -1)
            {
                Book_Id = Convert.ToInt32(dataGridView_Books.CurrentRow.Cells[0].Value.ToString());
                txtTitle.Text = dataGridView_Books.CurrentRow.Cells[1].Value.ToString();
                txtAuthorId.Text = dataGridView_Books.CurrentRow.Cells[2].Value.ToString();
                txtPublicationYear.Text = dataGridView_Books.CurrentRow.Cells[3].Value.ToString();
                txtCategoryId.Text = dataGridView_Books.CurrentRow.Cells[4].Value.ToString();
                txtDelete.Enabled = true;
            }
        }
        /*displayed data function*/
        void FillDataGridView()
        {
            if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("BooksViewandSearch", Sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Book_title", search_input.Text.Trim());
            DataTable data = new DataTable();
            sqlDa.Fill(data);
            dataGridView_Books.DataSource = data;
            Sqlcon.Close();
        }
    }
}
