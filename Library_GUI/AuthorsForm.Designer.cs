
namespace Library_GUI
{
    partial class AuthorsForm
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
            this.txtEdit = new System.Windows.Forms.Button();
            this.txtReset = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.search_input = new System.Windows.Forms.TextBox();
            this.dataGridView_Authors = new System.Windows.Forms.DataGridView();
            this.txtDelete = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.Button();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthorStudents = new System.Windows.Forms.Button();
            this.txtAuthorsBooks = new System.Windows.Forms.Button();
            this.txtAuthorBorrows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Authors)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(133, 304);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(75, 23);
            this.txtEdit.TabIndex = 41;
            this.txtEdit.Text = "Edit";
            this.txtEdit.UseVisualStyleBackColor = true;
            this.txtEdit.Click += new System.EventHandler(this.txtEdit_Click_1);
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(230, 304);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(75, 23);
            this.txtReset.TabIndex = 40;
            this.txtReset.Text = "Reset";
            this.txtReset.UseVisualStyleBackColor = true;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(1070, 148);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(176, 23);
            this.search_button.TabIndex = 39;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click_1);
            // 
            // search_input
            // 
            this.search_input.Location = new System.Drawing.Point(430, 149);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(634, 22);
            this.search_input.TabIndex = 38;
            // 
            // dataGridView_Authors
            // 
            this.dataGridView_Authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Authors.Location = new System.Drawing.Point(430, 182);
            this.dataGridView_Authors.Name = "dataGridView_Authors";
            this.dataGridView_Authors.ReadOnly = true;
            this.dataGridView_Authors.RowHeadersWidth = 51;
            this.dataGridView_Authors.RowTemplate.Height = 24;
            this.dataGridView_Authors.Size = new System.Drawing.Size(816, 326);
            this.dataGridView_Authors.TabIndex = 37;
            this.dataGridView_Authors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Authors_CellContentClick);
            this.dataGridView_Authors.DoubleClick += new System.EventHandler(this.dataGridView_Authors_DoubleClick);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(320, 304);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(75, 23);
            this.txtDelete.TabIndex = 36;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(41, 304);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(75, 23);
            this.txtInsert.TabIndex = 35;
            this.txtInsert.Text = "Insert";
            this.txtInsert.UseVisualStyleBackColor = true;
            this.txtInsert.Click += new System.EventHandler(this.txtInsert_Click);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(201, 213);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(194, 22);
            this.txtBirthDate.TabIndex = 33;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(201, 182);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(194, 22);
            this.txtSecondName.TabIndex = 32;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(201, 152);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(194, 22);
            this.txtFirstName.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(37, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Birth Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(37, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(37, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(213, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Authors page";
            // 
            // txtAuthorStudents
            // 
            this.txtAuthorStudents.Location = new System.Drawing.Point(262, 417);
            this.txtAuthorStudents.Name = "txtAuthorStudents";
            this.txtAuthorStudents.Size = new System.Drawing.Size(133, 23);
            this.txtAuthorStudents.TabIndex = 48;
            this.txtAuthorStudents.Text = "Add Students";
            this.txtAuthorStudents.UseVisualStyleBackColor = true;
            this.txtAuthorStudents.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtAuthorsBooks
            // 
            this.txtAuthorsBooks.Location = new System.Drawing.Point(262, 446);
            this.txtAuthorsBooks.Name = "txtAuthorsBooks";
            this.txtAuthorsBooks.Size = new System.Drawing.Size(133, 23);
            this.txtAuthorsBooks.TabIndex = 47;
            this.txtAuthorsBooks.Text = "Add Books";
            this.txtAuthorsBooks.UseVisualStyleBackColor = true;
            this.txtAuthorsBooks.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtAuthorBorrows
            // 
            this.txtAuthorBorrows.Location = new System.Drawing.Point(262, 388);
            this.txtAuthorBorrows.Name = "txtAuthorBorrows";
            this.txtAuthorBorrows.Size = new System.Drawing.Size(133, 23);
            this.txtAuthorBorrows.TabIndex = 46;
            this.txtAuthorBorrows.Text = "Add Borrows";
            this.txtAuthorBorrows.UseVisualStyleBackColor = true;
            this.txtAuthorBorrows.Click += new System.EventHandler(this.txtBorrows_Click);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 567);
            this.Controls.Add(this.txtAuthorStudents);
            this.Controls.Add(this.txtAuthorsBooks);
            this.Controls.Add(this.txtAuthorBorrows);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_input);
            this.Controls.Add(this.dataGridView_Authors);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AuthorsForm";
            this.Text = "AuthorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Authors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button txtEdit;
        private System.Windows.Forms.Button txtReset;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.DataGridView dataGridView_Authors;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button txtInsert;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtAuthorStudents;
        private System.Windows.Forms.Button txtAuthorsBooks;
        private System.Windows.Forms.Button txtAuthorBorrows;
    }
}