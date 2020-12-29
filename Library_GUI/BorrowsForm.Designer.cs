
namespace Library_GUI
{
    partial class BorrowsForm
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
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtTakenDate = new System.Windows.Forms.Label();
            this.txtEdit = new System.Windows.Forms.Button();
            this.txtReset = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.search_input = new System.Windows.Forms.TextBox();
            this.dataGridView_Borrows = new System.Windows.Forms.DataGridView();
            this.txtDelete = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.Button();
            this.txtPublicationYear = new System.Windows.Forms.TextBox();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBorrowAuthorId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBroughtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBorrowAuthors = new System.Windows.Forms.Button();
            this.txtBorrowBooks = new System.Windows.Forms.Button();
            this.txtBorrowStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Borrows)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(184, 240);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(194, 22);
            this.txtCategoryId.TabIndex = 85;
            // 
            // txtTakenDate
            // 
            this.txtTakenDate.AutoSize = true;
            this.txtTakenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTakenDate.Location = new System.Drawing.Point(20, 240);
            this.txtTakenDate.Name = "txtTakenDate";
            this.txtTakenDate.Size = new System.Drawing.Size(95, 20);
            this.txtTakenDate.TabIndex = 84;
            this.txtTakenDate.Text = "Taken Date";
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(116, 322);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(75, 23);
            this.txtEdit.TabIndex = 79;
            this.txtEdit.Text = "Edit";
            this.txtEdit.UseVisualStyleBackColor = true;
            this.txtEdit.Click += new System.EventHandler(this.txtEdit_Click);
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(213, 322);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(75, 23);
            this.txtReset.TabIndex = 78;
            this.txtReset.Text = "Reset";
            this.txtReset.UseVisualStyleBackColor = true;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(1053, 140);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(176, 23);
            this.search_button.TabIndex = 77;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_input
            // 
            this.search_input.Location = new System.Drawing.Point(413, 141);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(634, 22);
            this.search_input.TabIndex = 76;
            // 
            // dataGridView_Borrows
            // 
            this.dataGridView_Borrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Borrows.Location = new System.Drawing.Point(413, 174);
            this.dataGridView_Borrows.Name = "dataGridView_Borrows";
            this.dataGridView_Borrows.ReadOnly = true;
            this.dataGridView_Borrows.RowHeadersWidth = 51;
            this.dataGridView_Borrows.RowTemplate.Height = 24;
            this.dataGridView_Borrows.Size = new System.Drawing.Size(816, 326);
            this.dataGridView_Borrows.TabIndex = 75;
            this.dataGridView_Borrows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Borrows_CellContentClick);
            this.dataGridView_Borrows.DoubleClick += new System.EventHandler(this.dataGridView_Borrows_DoubleClick);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(303, 322);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(75, 23);
            this.txtDelete.TabIndex = 74;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(24, 322);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(75, 23);
            this.txtInsert.TabIndex = 73;
            this.txtInsert.Text = "Insert";
            this.txtInsert.UseVisualStyleBackColor = true;
            this.txtInsert.Click += new System.EventHandler(this.txtInsert_Click);
            // 
            // txtPublicationYear
            // 
            this.txtPublicationYear.Location = new System.Drawing.Point(184, 205);
            this.txtPublicationYear.Name = "txtPublicationYear";
            this.txtPublicationYear.Size = new System.Drawing.Size(194, 22);
            this.txtPublicationYear.TabIndex = 72;
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(184, 174);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(194, 22);
            this.txtAuthorId.TabIndex = 71;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(184, 144);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(194, 22);
            this.txtTitle.TabIndex = 70;
            // 
            // txtBorrowAuthorId
            // 
            this.txtBorrowAuthorId.AutoSize = true;
            this.txtBorrowAuthorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBorrowAuthorId.Location = new System.Drawing.Point(20, 207);
            this.txtBorrowAuthorId.Name = "txtBorrowAuthorId";
            this.txtBorrowAuthorId.Size = new System.Drawing.Size(76, 20);
            this.txtBorrowAuthorId.TabIndex = 69;
            this.txtBorrowAuthorId.Text = "Author Id";
            // 
            // txtStudentId
            // 
            this.txtStudentId.AutoSize = true;
            this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStudentId.Location = new System.Drawing.Point(20, 174);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(84, 20);
            this.txtStudentId.TabIndex = 68;
            this.txtStudentId.Text = "Student Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(196, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "Borrows page";
            // 
            // textBroughtDate
            // 
            this.textBroughtDate.Location = new System.Drawing.Point(184, 278);
            this.textBroughtDate.Name = "textBroughtDate";
            this.textBroughtDate.Size = new System.Drawing.Size(194, 22);
            this.textBroughtDate.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Brought Date";
            // 
            // txtBorrowAuthors
            // 
            this.txtBorrowAuthors.Location = new System.Drawing.Point(245, 430);
            this.txtBorrowAuthors.Name = "txtBorrowAuthors";
            this.txtBorrowAuthors.Size = new System.Drawing.Size(133, 23);
            this.txtBorrowAuthors.TabIndex = 90;
            this.txtBorrowAuthors.Text = "Add Authors";
            this.txtBorrowAuthors.UseVisualStyleBackColor = true;
            this.txtBorrowAuthors.Click += new System.EventHandler(this.txtBorrowAuthors_Click);
            // 
            // txtBorrowBooks
            // 
            this.txtBorrowBooks.Location = new System.Drawing.Point(245, 459);
            this.txtBorrowBooks.Name = "txtBorrowBooks";
            this.txtBorrowBooks.Size = new System.Drawing.Size(133, 23);
            this.txtBorrowBooks.TabIndex = 89;
            this.txtBorrowBooks.Text = "Add Books";
            this.txtBorrowBooks.UseVisualStyleBackColor = true;
            this.txtBorrowBooks.Click += new System.EventHandler(this.txtBorrowBooks_Click);
            // 
            // txtBorrowStudents
            // 
            this.txtBorrowStudents.Location = new System.Drawing.Point(245, 401);
            this.txtBorrowStudents.Name = "txtBorrowStudents";
            this.txtBorrowStudents.Size = new System.Drawing.Size(133, 23);
            this.txtBorrowStudents.TabIndex = 88;
            this.txtBorrowStudents.Text = "Add Students";
            this.txtBorrowStudents.UseVisualStyleBackColor = true;
            this.txtBorrowStudents.Click += new System.EventHandler(this.txtBorrowStudents_Click);
            // 
            // BorrowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 556);
            this.Controls.Add(this.txtBorrowAuthors);
            this.Controls.Add(this.txtBorrowBooks);
            this.Controls.Add(this.txtBorrowStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBroughtDate);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.txtTakenDate);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_input);
            this.Controls.Add(this.dataGridView_Borrows);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.txtPublicationYear);
            this.Controls.Add(this.txtAuthorId);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBorrowAuthorId);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "BorrowsForm";
            this.Text = "BorrowsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Borrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label txtTakenDate;
        private System.Windows.Forms.Button txtEdit;
        private System.Windows.Forms.Button txtReset;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.DataGridView dataGridView_Borrows;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button txtInsert;
        private System.Windows.Forms.TextBox txtPublicationYear;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label txtBorrowAuthorId;
        private System.Windows.Forms.Label txtStudentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBroughtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtBorrowAuthors;
        private System.Windows.Forms.Button txtBorrowBooks;
        private System.Windows.Forms.Button txtBorrowStudents;
    }
}