namespace BookRentalSystem.UserControls
{
    partial class UC_BookRental
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
            this.lblBookListTitle = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.btnBookRentalClose = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookListTitle
            // 
            this.lblBookListTitle.AutoSize = true;
            this.lblBookListTitle.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookListTitle.Location = new System.Drawing.Point(40, 30);
            this.lblBookListTitle.Name = "lblBookListTitle";
            this.lblBookListTitle.Size = new System.Drawing.Size(335, 39);
            this.lblBookListTitle.TabIndex = 0;
            this.lblBookListTitle.Text = "Sky Library Book List";
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(40, 80);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowHeadersWidth = 51;
            this.dgvBookList.RowTemplate.Height = 24;
            this.dgvBookList.Size = new System.Drawing.Size(655, 380);
            this.dgvBookList.TabIndex = 1;
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
            this.btnBookRentalClose.TabIndex = 4;
            this.btnBookRentalClose.Text = "X";
            this.btnBookRentalClose.UseVisualStyleBackColor = false;
            this.btnBookRentalClose.Click += new System.EventHandler(this.btnBookRentalClose_Click);
            // 
            // btnRent
            // 
            this.btnRent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(569, 480);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(86, 38);
            this.btnRent.TabIndex = 5;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // UC_BookRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnBookRentalClose);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.lblBookListTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_BookRental";
            this.Size = new System.Drawing.Size(735, 564);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookListTitle;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Button btnBookRentalClose;
        private System.Windows.Forms.Button btnRent;
    }
}
