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
    public partial class BorrowsForm : Form
    {
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandu\OneDrive\Desktop\Indrivo_Practice\Library_GUI\Library_GUI_DB.mdf;Integrated Security=True;Connect Timeout=30");
        int Borrow_Id = 0;
        public BorrowsForm()
        {
            InitializeComponent();
        }
        /*links to other pages*/
        private void txtBorrowBooks_Click(object sender, EventArgs e)
        {
            new BooksForm().Show();
            this.Hide();
        }

        private void txtBorrowStudents_Click(object sender, EventArgs e)
        {
            new BorrowsForm().Show();
            this.Hide();
        }

        private void txtBorrowAuthors_Click(object sender, EventArgs e)
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
                SqlCommand sqlcmd = new SqlCommand("BorrowsInsert", Sqlcon);
                if (txtInsert.Text == "Insert")
                {
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@mode", "Add");
                    sqlcmd.Parameters.AddWithValue("@Id", 0);
                    sqlcmd.Parameters.AddWithValue("@Student_Id", txtStudentId.Text);
                    sqlcmd.Parameters.AddWithValue("@Author_Id", txtBorrowAuthorId.Text);
                    sqlcmd.Parameters.AddWithValue("@Taken_Date", txtTakenDate.Text);
                    sqlcmd.Parameters.AddWithValue("@Brought_Date", textBroughtDate.Text);
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

        private void txtEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("BorrowsInsert", Sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                sqlcmd.Parameters.AddWithValue("@Id", Borrow_Id);
                sqlcmd.Parameters.AddWithValue("@Student_Id", txtStudentId.Text);
                sqlcmd.Parameters.AddWithValue("@Author_Id", txtBorrowAuthorId.Text);
                sqlcmd.Parameters.AddWithValue("@Taken_Date", txtTakenDate.Text);
                sqlcmd.Parameters.AddWithValue("@Brought_Date", textBroughtDate.Text);
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

        private void txtReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("BorrowsDelete", Sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@Id", Borrow_Id);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Deleted");
                Reset();
                FillDataGridView();
            }
            catch (Exception ex)
            {

            }
        }
        void Reset()
        {
            txtStudentId.Text = txtBorrowAuthorId.Text = txtTakenDate.Text = textBroughtDate.Text = "";
            txtInsert.Text = "Save";
            Borrow_Id = 0;
            txtDelete.Enabled = true;
        }
        void FillDataGridView()
        {
            if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("BorrowsViewandSearch", Sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Id", search_input.Text.Trim());
            DataTable data = new DataTable();
            sqlDa.Fill(data);
            dataGridView_Borrows.DataSource = data;
            Sqlcon.Close();
        }

        private void dataGridView_Borrows_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_Borrows.CurrentRow.Index != -1)
            {
                Borrow_Id = Convert.ToInt32(dataGridView_Borrows.CurrentRow.Cells[0].Value.ToString());
                txtStudentId.Text = dataGridView_Borrows.CurrentRow.Cells[1].Value.ToString();
                txtBorrowAuthorId.Text = dataGridView_Borrows.CurrentRow.Cells[2].Value.ToString();
                txtTakenDate.Text = dataGridView_Borrows.CurrentRow.Cells[3].Value.ToString();
                textBroughtDate.Text = dataGridView_Borrows.CurrentRow.Cells[4].Value.ToString();
                txtDelete.Enabled = true;
            }
        }

        private void dataGridView_Borrows_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Borrows.CurrentRow.Index != -1)
            {
                Borrow_Id = Convert.ToInt32(dataGridView_Borrows.CurrentRow.Cells[0].Value.ToString());
                txtStudentId.Text = dataGridView_Borrows.CurrentRow.Cells[1].Value.ToString();
                txtBorrowAuthorId.Text = dataGridView_Borrows.CurrentRow.Cells[2].Value.ToString();
                txtTakenDate.Text = dataGridView_Borrows.CurrentRow.Cells[3].Value.ToString();
                textBroughtDate.Text = dataGridView_Borrows.CurrentRow.Cells[4].Value.ToString();
                txtDelete.Enabled = true;

            }
        }
    }
}
