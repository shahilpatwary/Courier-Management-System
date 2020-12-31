namespace Courier_Management_System.Presentation_Layer
{
    partial class EmpReceive
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
            this.panelEmployeeReceive = new System.Windows.Forms.Panel();
            this.lblReceiveFromCustomer = new System.Windows.Forms.Label();
            this.lblReceiveFromOtherBranch = new System.Windows.Forms.Label();
            this.dgvReceiveFromOtherBranch = new System.Windows.Forms.DataGridView();
            this.dgvReceiveFromCustomer = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblEditProfile = new System.Windows.Forms.Label();
            this.lblServiceHistory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelEmployeeReceive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveFromOtherBranch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveFromCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmployeeReceive
            // 
            this.panelEmployeeReceive.BackColor = System.Drawing.Color.LightCyan;
            this.panelEmployeeReceive.Controls.Add(this.lblReceiveFromCustomer);
            this.panelEmployeeReceive.Controls.Add(this.lblReceiveFromOtherBranch);
            this.panelEmployeeReceive.Controls.Add(this.dgvReceiveFromOtherBranch);
            this.panelEmployeeReceive.Controls.Add(this.dgvReceiveFromCustomer);
            this.panelEmployeeReceive.Controls.Add(this.label12);
            this.panelEmployeeReceive.Location = new System.Drawing.Point(183, 29);
            this.panelEmployeeReceive.Name = "panelEmployeeReceive";
            this.panelEmployeeReceive.Size = new System.Drawing.Size(469, 392);
            this.panelEmployeeReceive.TabIndex = 75;
            // 
            // lblReceiveFromCustomer
            // 
            this.lblReceiveFromCustomer.AutoSize = true;
            this.lblReceiveFromCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiveFromCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveFromCustomer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblReceiveFromCustomer.Location = new System.Drawing.Point(5, 21);
            this.lblReceiveFromCustomer.Name = "lblReceiveFromCustomer";
            this.lblReceiveFromCustomer.Size = new System.Drawing.Size(192, 18);
            this.lblReceiveFromCustomer.TabIndex = 18;
            this.lblReceiveFromCustomer.Text = "Receive From Customer";
            // 
            // lblReceiveFromOtherBranch
            // 
            this.lblReceiveFromOtherBranch.AutoSize = true;
            this.lblReceiveFromOtherBranch.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiveFromOtherBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveFromOtherBranch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblReceiveFromOtherBranch.Location = new System.Drawing.Point(5, 205);
            this.lblReceiveFromOtherBranch.Name = "lblReceiveFromOtherBranch";
            this.lblReceiveFromOtherBranch.Size = new System.Drawing.Size(218, 18);
            this.lblReceiveFromOtherBranch.TabIndex = 17;
            this.lblReceiveFromOtherBranch.Text = "Receive From Other Branch";
            // 
            // dgvReceiveFromOtherBranch
            // 
            this.dgvReceiveFromOtherBranch.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvReceiveFromOtherBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiveFromOtherBranch.Location = new System.Drawing.Point(3, 226);
            this.dgvReceiveFromOtherBranch.Name = "dgvReceiveFromOtherBranch";
            this.dgvReceiveFromOtherBranch.Size = new System.Drawing.Size(463, 164);
            this.dgvReceiveFromOtherBranch.TabIndex = 16;
            this.dgvReceiveFromOtherBranch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiveFromOtherBranch_CellContentClick);
            // 
            // dgvReceiveFromCustomer
            // 
            this.dgvReceiveFromCustomer.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvReceiveFromCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiveFromCustomer.Location = new System.Drawing.Point(3, 42);
            this.dgvReceiveFromCustomer.Name = "dgvReceiveFromCustomer";
            this.dgvReceiveFromCustomer.Size = new System.Drawing.Size(463, 160);
            this.dgvReceiveFromCustomer.TabIndex = 15;
            this.dgvReceiveFromCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiveFromCustomer_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(162, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Receive Product From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(292, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 76;
            this.label6.Text = "Employee Form";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.LightCyan;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Black;
            this.lblLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogout.Location = new System.Drawing.Point(5, 381);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(165, 29);
            this.lblLogout.TabIndex = 82;
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
            this.lblEditProfile.Location = new System.Drawing.Point(3, 212);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(167, 29);
            this.lblEditProfile.TabIndex = 81;
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
            this.lblServiceHistory.Location = new System.Drawing.Point(3, 168);
            this.lblServiceHistory.Name = "lblServiceHistory";
            this.lblServiceHistory.Size = new System.Drawing.Size(167, 29);
            this.lblServiceHistory.TabIndex = 80;
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
            this.label3.Location = new System.Drawing.Point(3, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 79;
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
            this.lblHome.Location = new System.Drawing.Point(3, 86);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(168, 29);
            this.lblHome.TabIndex = 78;
            this.lblHome.Text = "         Home      ";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(12, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 20);
            this.label14.TabIndex = 77;
            this.label14.Text = "Courier Service";
            // 
            // EmpReceive
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
            this.Controls.Add(this.panelEmployeeReceive);
            this.Name = "EmpReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpReceive";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmpReceive_FormClosed);
            this.panelEmployeeReceive.ResumeLayout(false);
            this.panelEmployeeReceive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveFromOtherBranch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveFromCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEmployeeReceive;
        private System.Windows.Forms.Label lblReceiveFromCustomer;
        private System.Windows.Forms.Label lblReceiveFromOtherBranch;
        private System.Windows.Forms.DataGridView dgvReceiveFromOtherBranch;
        private System.Windows.Forms.DataGridView dgvReceiveFromCustomer;
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