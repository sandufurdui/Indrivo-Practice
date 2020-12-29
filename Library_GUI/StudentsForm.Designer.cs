
namespace Library_GUI
{
    partial class StudentsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtStudyYear = new System.Windows.Forms.TextBox();
            this.txtInsert = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.dataGridView_Students = new System.Windows.Forms.DataGridView();
            this.search_input = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.txtReset = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.Button();
            this.txtStudentBorrows = new System.Windows.Forms.Button();
            this.txtStudentBooks = new System.Windows.Forms.Button();
            this.txtStudentAuthors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(225, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(49, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(49, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(49, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birth Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(49, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Study Year";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(213, 109);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(194, 22);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(213, 139);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(194, 22);
            this.txtSecondName.TabIndex = 8;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(213, 170);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(194, 22);
            this.txtBirthDate.TabIndex = 9;
            // 
            // txtStudyYear
            // 
            this.txtStudyYear.Location = new System.Drawing.Point(213, 205);
            this.txtStudyYear.Name = "txtStudyYear";
            this.txtStudyYear.Size = new System.Drawing.Size(194, 22);
            this.txtStudyYear.TabIndex = 10;
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(53, 261);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(75, 23);
            this.txtInsert.TabIndex = 11;
            this.txtInsert.Text = "Insert";
            this.txtInsert.UseVisualStyleBackColor = true;
            this.txtInsert.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(332, 261);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(75, 23);
            this.txtDelete.TabIndex = 15;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // dataGridView_Students
            // 
            this.dataGridView_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Students.Location = new System.Drawing.Point(442, 139);
            this.dataGridView_Students.Name = "dataGridView_Students";
            this.dataGridView_Students.ReadOnly = true;
            this.dataGridView_Students.RowHeadersWidth = 51;
            this.dataGridView_Students.RowTemplate.Height = 24;
            this.dataGridView_Students.Size = new System.Drawing.Size(937, 326);
            this.dataGridView_Students.TabIndex = 17;
            this.dataGridView_Students.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Students_CellContentClick);
            this.dataGridView_Students.DoubleClick += new System.EventHandler(this.dataGridView_Students_DoubleClick);
            // 
            // search_input
            // 
            this.search_input.Location = new System.Drawing.Point(442, 106);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(730, 22);
            this.search_input.TabIndex = 18;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(1178, 105);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(201, 23);
            this.search_button.TabIndex = 19;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(242, 261);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(75, 23);
            this.txtReset.TabIndex = 20;
            this.txtReset.Text = "Reset";
            this.txtReset.UseVisualStyleBackColor = true;
            this.txtReset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(145, 261);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(75, 23);
            this.txtEdit.TabIndex = 21;
            this.txtEdit.Text = "Edit";
            this.txtEdit.UseVisualStyleBackColor = true;
            this.txtEdit.Click += new System.EventHandler(this.txtEdit_Click);
            // 
            // txtStudentBorrows
            // 
            this.txtStudentBorrows.Location = new System.Drawing.Point(274, 334);
            this.txtStudentBorrows.Name = "txtStudentBorrows";
            this.txtStudentBorrows.Size = new System.Drawing.Size(133, 23);
            this.txtStudentBorrows.TabIndex = 22;
            this.txtStudentBorrows.Text = "Add Borrows";
            this.txtStudentBorrows.UseVisualStyleBackColor = true;
            this.txtStudentBorrows.Click += new System.EventHandler(this.txtStudentBorrows_Click);
            // 
            // txtStudentBooks
            // 
            this.txtStudentBooks.Location = new System.Drawing.Point(274, 392);
            this.txtStudentBooks.Name = "txtStudentBooks";
            this.txtStudentBooks.Size = new System.Drawing.Size(133, 23);
            this.txtStudentBooks.TabIndex = 23;
            this.txtStudentBooks.Text = "Add Books";
            this.txtStudentBooks.UseVisualStyleBackColor = true;
            this.txtStudentBooks.Click += new System.EventHandler(this.txtBooks_Click);
            // 
            // txtStudentAuthors
            // 
            this.txtStudentAuthors.Location = new System.Drawing.Point(274, 363);
            this.txtStudentAuthors.Name = "txtStudentAuthors";
            this.txtStudentAuthors.Size = new System.Drawing.Size(133, 23);
            this.txtStudentAuthors.TabIndex = 24;
            this.txtStudentAuthors.Text = "Add Authors";
            this.txtStudentAuthors.UseVisualStyleBackColor = true;
            this.txtStudentAuthors.Click += new System.EventHandler(this.txtAuthors_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 499);
            this.Controls.Add(this.txtStudentAuthors);
            this.Controls.Add(this.txtStudentBooks);
            this.Controls.Add(this.txtStudentBorrows);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_input);
            this.Controls.Add(this.dataGridView_Students);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.txtStudyYear);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "StudentsForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtStudyYear;
        private System.Windows.Forms.Button txtInsert;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.DataGridView dataGridView_Students;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button txtReset;
        private System.Windows.Forms.Button txtEdit;
        private System.Windows.Forms.Button txtStudentBorrows;
        private System.Windows.Forms.Button txtStudentBooks;
        private System.Windows.Forms.Button txtStudentAuthors;
    }
}

