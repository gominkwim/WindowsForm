namespace BookRentalSystem.UserControls
{
    partial class UC_ManageBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblManageBookListTitle = new System.Windows.Forms.Label();
            this.dgvManageBookList = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnBookRentalClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageBookListTitle
            // 
            this.lblManageBookListTitle.AutoSize = true;
            this.lblManageBookListTitle.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageBookListTitle.Location = new System.Drawing.Point(40, 30);
            this.lblManageBookListTitle.Name = "lblManageBookListTitle";
            this.lblManageBookListTitle.Size = new System.Drawing.Size(333, 39);
            this.lblManageBookListTitle.TabIndex = 1;
            this.lblManageBookListTitle.Text = "Manage A Book List";
            // 
            // dgvManageBookList
            // 
            this.dgvManageBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageBookList.Location = new System.Drawing.Point(40, 80);
            this.dgvManageBookList.Name = "dgvManageBookList";
            this.dgvManageBookList.RowHeadersWidth = 51;
            this.dgvManageBookList.RowTemplate.Height = 24;
            this.dgvManageBookList.Size = new System.Drawing.Size(655, 380);
            this.dgvManageBookList.TabIndex = 2;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(400, 480);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(90, 35);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBook.Location = new System.Drawing.Point(500, 480);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(90, 35);
            this.btnEditBook.TabIndex = 4;
            this.btnEditBook.Text = "Edit";
            this.btnEditBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Location = new System.Drawing.Point(600, 480);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(90, 35);
            this.btnDeleteBook.TabIndex = 5;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // btnBookRentalClose
            // 
            this.btnBookRentalClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnBookRentalClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBookRentalClose.FlatAppearance.BorderSize = 0;
            this.btnBookRentalClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookRentalClose.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRentalClose.Location = new System.Drawing.Point(692, 3);
            this.btnBookRentalClose.Name = "btnBookRentalClose";
            this.btnBookRentalClose.Size = new System.Drawing.Size(40, 40);
            this.btnBookRentalClose.TabIndex = 6;
            this.btnBookRentalClose.Text = "X";
            this.btnBookRentalClose.UseVisualStyleBackColor = false;
            this.btnBookRentalClose.Click += new System.EventHandler(this.btnBookRentalClose_Click);
            // 
            // UC_ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBookRentalClose);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dgvManageBookList);
            this.Controls.Add(this.lblManageBookListTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_ManageBooks";
            this.Size = new System.Drawing.Size(735, 564);
            this.Load += new System.EventHandler(this.UC_ManageBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageBookListTitle;
        private System.Windows.Forms.DataGridView dgvManageBookList;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnBookRentalClose;
    }
}
