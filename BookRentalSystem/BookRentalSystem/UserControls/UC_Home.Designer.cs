namespace BookRentalSystem.UserControls
{
    partial class UC_Home
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
            this.panel_Top = new System.Windows.Forms.Panel();
            this.btnHomeClose = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblHi = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel_BottomHistory = new System.Windows.Forms.Panel();
            this.dataGridView_History = new System.Windows.Forms.DataGridView();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            this.panel_BottomHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Top.Controls.Add(this.btnHomeClose);
            this.panel_Top.Controls.Add(this.lblMemberName);
            this.panel_Top.Controls.Add(this.lblHi);
            this.panel_Top.Controls.Add(this.lblRole);
            this.panel_Top.Controls.Add(this.lblWelcome);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(735, 160);
            this.panel_Top.TabIndex = 0;
            // 
            // btnHomeClose
            // 
            this.btnHomeClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnHomeClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHomeClose.FlatAppearance.BorderSize = 0;
            this.btnHomeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeClose.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeClose.Location = new System.Drawing.Point(692, 3);
            this.btnHomeClose.Name = "btnHomeClose";
            this.btnHomeClose.Size = new System.Drawing.Size(40, 40);
            this.btnHomeClose.TabIndex = 3;
            this.btnHomeClose.Text = "X";
            this.btnHomeClose.UseVisualStyleBackColor = false;
            this.btnHomeClose.Click += new System.EventHandler(this.btnHomeClose_Click);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(120, 110);
            this.lblMemberName.Margin = new System.Windows.Forms.Padding(0);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(143, 34);
            this.lblMemberName.TabIndex = 2;
            this.lblMemberName.Text = "Rainbow,";
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.Location = new System.Drawing.Point(85, 110);
            this.lblHi.Margin = new System.Windows.Forms.Padding(0);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(41, 34);
            this.lblHi.TabIndex = 1;
            this.lblHi.Text = "Hi";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(500, 110);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(218, 23);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role: Member/Admin";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(170, 32);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(475, 47);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Sky Library";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_BottomHistory
            // 
            this.panel_BottomHistory.BackColor = System.Drawing.SystemColors.Control;
            this.panel_BottomHistory.Controls.Add(this.dataGridView_History);
            this.panel_BottomHistory.Controls.Add(this.lblHistoryTitle);
            this.panel_BottomHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_BottomHistory.Location = new System.Drawing.Point(0, 162);
            this.panel_BottomHistory.Name = "panel_BottomHistory";
            this.panel_BottomHistory.Size = new System.Drawing.Size(735, 375);
            this.panel_BottomHistory.TabIndex = 1;
            // 
            // dataGridView_History
            // 
            this.dataGridView_History.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_History.Location = new System.Drawing.Point(28, 36);
            this.dataGridView_History.Name = "dataGridView_History";
            this.dataGridView_History.RowHeadersWidth = 51;
            this.dataGridView_History.RowTemplate.Height = 24;
            this.dataGridView_History.Size = new System.Drawing.Size(675, 299);
            this.dataGridView_History.TabIndex = 1;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryTitle.Location = new System.Drawing.Point(40, 0);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(171, 34);
            this.lblHistoryTitle.TabIndex = 0;
            this.lblHistoryTitle.Text = "Rent History";
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel_BottomHistory);
            this.Controls.Add(this.panel_Top);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(735, 537);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.panel_BottomHistory.ResumeLayout(false);
            this.panel_BottomHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_History)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel_BottomHistory;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.DataGridView dataGridView_History;
        private System.Windows.Forms.Button btnHomeClose;
    }
}
