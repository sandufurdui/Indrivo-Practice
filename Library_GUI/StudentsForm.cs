using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_GUI
{
    public partial class StudentsForm : Form
    {
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandu\OneDrive\Desktop\Indrivo_Practice\Library_GUI\Library_GUI_DB.mdf;Integrated Security=True;Connect Timeout=30");
        int Student_Id = 0;
        /*form initialization*/
        public StudentsForm()
        {
            InitializeComponent();
        }
        /*Links other forms*/
        private void txtAuthors_Click(object sender, EventArgs e)
        {
            new AuthorsForm().Show();
            this.Hide();
        }

        private void txtBooks_Click(object sender, EventArgs e)
        {
            new BooksForm().Show();
            this.Hide();
        }
        private void txtStudentBorrows_Click(object sender, EventArgs e)
        {
            new BorrowsForm().Show();
            this.Hide();
        }

        /*displayed data function*/
        void FillDataGridView()
        {
            if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("StudentsViewandSearch", Sqlcon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Student_Name", search_input.Text.Trim());
            DataTable data = new DataTable();
            sqlDa.Fill(data);
            dataGridView_Students.DataSource = data;
            Sqlcon.Close();
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
        /*displayed data*/
        private void dataGridView_Students_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_Students.CurrentRow.Index != -1)
            {
                Student_Id = Convert.ToInt32(dataGridView_Students.CurrentRow.Cells[0].Value.ToString());
                txtFirstName.Text = dataGridView_Students.CurrentRow.Cells[1].Value.ToString();
                txtSecondName.Text = dataGridView_Students.CurrentRow.Cells[2].Value.ToString();
                txtBirthDate.Text = dataGridView_Students.CurrentRow.Cells[3].Value.ToString();
                txtStudyYear.Text = dataGridView_Students.CurrentRow.Cells[4].Value.ToString();
                txtDelete.Enabled = true;
            }
        }
        /*reset function*/
        void Reset()
        {
            txtFirstName.Text = txtBirthDate.Text = txtSecondName.Text = txtStudyYear.Text = "";
            txtEdit.Text = "Save";
            Student_Id = 0;
            txtDelete.Enabled = true;
        }
        /*delete button*/
        private void txtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("StudentsDelete", Sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@Id", Student_Id);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Deleted");
                Reset();
                FillDataGridView();
            }
            catch (Exception ex)
            {

            }
        }

        /*insert button*/
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("StudentsInsert", Sqlcon);
                if (txtInsert.Text == "Insert")
                {
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@mode", "Add");
                    sqlcmd.Parameters.AddWithValue("@Id", 0);
                    sqlcmd.Parameters.AddWithValue("@First_Name", txtFirstName.Text);
                    sqlcmd.Parameters.AddWithValue("@Last_Name", txtSecondName.Text);
                    sqlcmd.Parameters.AddWithValue("@Birth_Date", txtBirthDate.Text);
                    sqlcmd.Parameters.AddWithValue("@Study_Year", int.Parse(txtStudyYear.Text));
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
        /*Updated view of the grid*/
        private void dataGridView_Students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Students.CurrentRow.Index != -1)
            {
                Student_Id = Convert.ToInt32(dataGridView_Students.CurrentRow.Cells[0].Value.ToString());
                txtFirstName.Text = dataGridView_Students.CurrentRow.Cells[1].Value.ToString();
                txtSecondName.Text = dataGridView_Students.CurrentRow.Cells[2].Value.ToString();
                txtBirthDate.Text = dataGridView_Students.CurrentRow.Cells[3].Value.ToString();
                txtStudyYear.Text = dataGridView_Students.CurrentRow.Cells[4].Value.ToString();
                txtDelete.Enabled = true;
                
            }
        }
        /*Reset Button*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
        /*Edit button*/
        private void txtEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sqlcon.State == ConnectionState.Closed) Sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("StudentsInsert", Sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlcmd.Parameters.AddWithValue("@Id", Student_Id);
                    sqlcmd.Parameters.AddWithValue("@First_Name", txtFirstName.Text);
                    sqlcmd.Parameters.AddWithValue("@Last_Name", txtSecondName.Text);
                    sqlcmd.Parameters.AddWithValue("@Birth_Date", txtBirthDate.Text);
                    sqlcmd.Parameters.AddWithValue("@Study_Year", int.Parse(txtStudyYear.Text));
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
    }
}