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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageBookListTitle
            // 
            this.lblManageBookListTitle.AutoSize = true;
            this.lblManageBookListTitle.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageBookListTitle.Location = new System.Drawing.Point(40, 52);
            this.lblManageBookListTitle.Name = "lblManageBookListTitle";
            this.lblManageBookListTitle.Size = new System.Drawing.Size(308, 40);
            this.lblManageBookListTitle.TabIndex = 1;
            this.lblManageBookListTitle.Text = "Manage Book List";
            // 
            // dgvManageBookList
            // 
            this.dgvManageBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageBookList.Location = new System.Drawing.Point(40, 95);
            this.dgvManageBookList.Name = "dgvManageBookList";
            this.dgvManageBookList.RowHeadersWidth = 51;
            this.dgvManageBookList.RowTemplate.Height = 24;
            this.dgvManageBookList.Size = new System.Drawing.Size(655, 380);
            this.dgvManageBookList.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-19, -19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UC_ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvManageBookList);
            this.Controls.Add(this.lblManageBookListTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_ManageBooks";
            this.Size = new System.Drawing.Size(735, 564);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageBookListTitle;
        private System.Windows.Forms.DataGridView dgvManageBookList;
        private System.Windows.Forms.Button button1;
    }
}
