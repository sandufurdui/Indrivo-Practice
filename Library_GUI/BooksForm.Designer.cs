
namespace Library_GUI
{
    partial class BooksForm
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
            this.dataGridView_Books = new System.Windows.Forms.DataGridView();
            this.txtDelete = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.Button();
            this.txtPublicationYear = new System.Windows.Forms.TextBox();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtStudentAuthors = new System.Windows.Forms.Button();
            this.txtBookStudents = new System.Windows.Forms.Button();
            this.txtStudentBorrows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(117, 287);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(75, 23);
            this.txtEdit.TabIndex = 59;
            this.txtEdit.Text = "Edit";
            this.txtEdit.UseVisualStyleBackColor = true;
            this.txtEdit.Click += new System.EventHandler(this.txtEdit_Click);
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(214, 287);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(75, 23);
            this.txtReset.TabIndex = 58;
            this.txtReset.Text = "Reset";
            this.txtReset.UseVisualStyleBackColor = true;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(1054, 131);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(176, 23);
            this.search_button.TabIndex = 57;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_input
            // 
            this.search_input.Location = new System.Drawing.Point(414, 132);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(634, 22);
            this.search_input.TabIndex = 56;
            // 
            // dataGridView_Books
            // 
            this.dataGridView_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Books.Location = new System.Drawing.Point(414, 165);
            this.dataGridView_Books.Name = "dataGridView_Books";
            this.dataGridView_Books.ReadOnly = true;
            this.dataGridView_Books.RowHeadersWidth = 51;
            this.dataGridView_Books.RowTemplate.Height = 24;
            this.dataGridView_Books.Size = new System.Drawing.Size(816, 326);
            this.dataGridView_Books.TabIndex = 55;
            this.dataGridView_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Books_CellContentClick);
            this.dataGridView_Books.DoubleClick += new System.EventHandler(this.dataGridView_Books_DoubleClick);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(304, 287);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(75, 23);
            this.txtDelete.TabIndex = 54;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(25, 287);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(75, 23);
            this.txtInsert.TabIndex = 53;
            this.txtInsert.Text = "Insert";
            this.txtInsert.UseVisualStyleBackColor = true;
            this.txtInsert.Click += new System.EventHandler(this.txtInsert_Click);
            // 
            // txtPublicationYear
            // 
            this.txtPublicationYear.Location = new System.Drawing.Point(185, 196);
            this.txtPublicationYear.Name = "txtPublicationYear";
            this.txtPublicationYear.Size = new System.Drawing.Size(194, 22);
            this.txtPublicationYear.TabIndex = 52;
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Location = new System.Drawing.Point(185, 165);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(194, 22);
            this.txtAuthorId.TabIndex = 51;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(185, 135);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(194, 22);
            this.txtTitle.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(21, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Publication Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Author Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(197, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Books page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Category Id";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(185, 231);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(194, 22);
            this.txtCategoryId.TabIndex = 65;
            // 
            // txtStudentAuthors
            // 
            this.txtStudentAuthors.Location = new System.Drawing.Point(246, 412);
            this.txtStudentAuthors.Name = "txtStudentAuthors";
            this.txtStudentAuthors.Size = new System.Drawing.Size(133, 23);
            this.txtStudentAuthors.TabIndex = 68;
            this.txtStudentAuthors.Text = "Add Authors";
            this.txtStudentAuthors.UseVisualStyleBackColor = true;
            this.txtStudentAuthors.Click += new System.EventHandler(this.txtStudentAuthors_Click);
            // 
            // txtBookStudents
            // 
            this.txtBookStudents.Location = new System.Drawing.Point(246, 441);
            this.txtBookStudents.Name = "txtBookStudents";
            this.txtBookStudents.Size = new System.Drawing.Size(133, 23);
            this.txtBookStudents.TabIndex = 67;
            this.txtBookStudents.Text = "Add Students";
            this.txtBookStudents.UseVisualStyleBackColor = true;
            this.txtBookStudents.Click += new System.EventHandler(this.txtStudentBooks_Click);
            // 
            // txtStudentBorrows
            // 
            this.txtStudentBorrows.Location = new System.Drawing.Point(246, 383);
            this.txtStudentBorrows.Name = "txtStudentBorrows";
            this.txtStudentBorrows.Size = new System.Drawing.Size(133, 23);
            this.txtStudentBorrows.TabIndex = 66;
            this.txtStudentBorrows.Text = "Add Borrows";
            this.txtStudentBorrows.UseVisualStyleBackColor = true;
            this.txtStudentBorrows.Click += new System.EventHandler(this.txtStudentBorrows_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 540);
            this.Controls.Add(this.txtStudentAuthors);
            this.Controls.Add(this.txtBookStudents);
            this.Controls.Add(this.txtStudentBorrows);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_input);
            this.Controls.Add(this.dataGridView_Books);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.txtPublicationYear);
            this.Controls.Add(this.txtAuthorId);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "BooksForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button txtEdit;
        private System.Windows.Forms.Button txtReset;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.DataGridView dataGridView_Books;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button txtInsert;
        private System.Windows.Forms.TextBox txtPublicationYear;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Button txtStudentAuthors;
        private System.Windows.Forms.Button txtBookStudents;
        private System.Windows.Forms.Button txtStudentBorrows;
    }
}