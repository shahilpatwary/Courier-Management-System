namespace Courier_Management_System.Presentation_Layer
{
    partial class EmpShowForm
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
            this.panelEmployeeShow = new System.Windows.Forms.Panel();
            this.txtSearchBy = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.DataGridViewShow = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblEditProfile = new System.Windows.Forms.Label();
            this.lblServiceHistory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelEmployeeShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmployeeShow
            // 
            this.panelEmployeeShow.BackColor = System.Drawing.SystemColors.Menu;
            this.panelEmployeeShow.Controls.Add(this.txtSearchBy);
            this.panelEmployeeShow.Controls.Add(this.cmbPosition);
            this.panelEmployeeShow.Controls.Add(this.lblSearch);
            this.panelEmployeeShow.Controls.Add(this.DataGridViewShow);
            this.panelEmployeeShow.Controls.Add(this.label12);
            this.panelEmployeeShow.Location = new System.Drawing.Point(176, 22);
            this.panelEmployeeShow.Name = "panelEmployeeShow";
            this.panelEmployeeShow.Size = new System.Drawing.Size(469, 393);
            this.panelEmployeeShow.TabIndex = 51;
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBy.Location = new System.Drawing.Point(244, 32);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(193, 26);
            this.txtSearchBy.TabIndex = 13;
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(107, 32);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(121, 28);
            this.cmbPosition.TabIndex = 12;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(28, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(73, 17);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search By";
            // 
            // DataGridViewShow
            // 
            this.DataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewShow.Location = new System.Drawing.Point(3, 75);
            this.DataGridViewShow.Name = "DataGridViewShow";
            this.DataGridViewShow.Size = new System.Drawing.Size(463, 315);
            this.DataGridViewShow.TabIndex = 6;
            this.DataGridViewShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewShow_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(199, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Show From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(284, -6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "Employee Form";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.LightCyan;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Black;
            this.lblLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogout.Location = new System.Drawing.Point(4, 380);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(165, 29);
            this.lblLogout.TabIndex = 88;
            this.lblLogout.Text = "         Logout    ";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.AutoSize = true;
            this.lblEditProfile.BackColor = System.Drawing.Color.LightCyan;
            this.lblEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProfile.ForeColor = System.Drawing.Color.Black;
            this.lblEditProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEditProfile.Location = new System.Drawing.Point(2, 211);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(167, 29);
            this.lblEditProfile.TabIndex = 87;
            this.lblEditProfile.Text = "     Edit Profile ";
            this.lblEditProfile.Click += new System.EventHandler(this.lblEditProfile_Click);
            // 
            // lblServiceHistory
            // 
            this.lblServiceHistory.AutoSize = true;
            this.lblServiceHistory.BackColor = System.Drawing.Color.LightCyan;
            this.lblServiceHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblServiceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceHistory.ForeColor = System.Drawing.Color.Black;
            this.lblServiceHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblServiceHistory.Location = new System.Drawing.Point(2, 167);
            this.lblServiceHistory.Name = "lblServiceHistory";
            this.lblServiceHistory.Size = new System.Drawing.Size(167, 29);
            this.lblServiceHistory.TabIndex = 86;
            this.lblServiceHistory.Text = "     Ser. History";
            this.lblServiceHistory.Click += new System.EventHandler(this.lblServiceHistory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(2, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 85;
            this.label3.Text = "         Profile     ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.LightCyan;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Black;
            this.lblHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Location = new System.Drawing.Point(2, 85);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(168, 29);
            this.lblHome.TabIndex = 84;
            this.lblHome.Text = "         Home      ";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(11, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 20);
            this.label14.TabIndex = 83;
            this.label14.Text = "Courier Service";
            // 
            // EmpShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 414);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblEditProfile);
            this.Controls.Add(this.lblServiceHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelEmployeeShow);
            this.Name = "EmpShowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpShowForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmpShowForm_FormClosed);
            this.panelEmployeeShow.ResumeLayout(false);
            this.panelEmployeeShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployeeShow;
        private System.Windows.Forms.TextBox txtSearchBy;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView DataGridViewShow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblEditProfile;
        private System.Windows.Forms.Label lblServiceHistory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label label14;
    }
}