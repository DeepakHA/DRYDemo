namespace WinFormUICore
{
    partial class formDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnGenerateEmpID = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(160, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(125, 27);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(160, 68);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(125, 27);
            this.txtLastName.TabIndex = 1;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Enabled = false;
            this.txtEmployeeId.Location = new System.Drawing.Point(160, 181);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(125, 27);
            this.txtEmployeeId.TabIndex = 2;
            // 
            // btnGenerateEmpID
            // 
            this.btnGenerateEmpID.Location = new System.Drawing.Point(38, 120);
            this.btnGenerateEmpID.Name = "btnGenerateEmpID";
            this.btnGenerateEmpID.Size = new System.Drawing.Size(247, 29);
            this.btnGenerateEmpID.TabIndex = 3;
            this.btnGenerateEmpID.Text = "Generate Employee ID";
            this.btnGenerateEmpID.UseVisualStyleBackColor = true;
            this.btnGenerateEmpID.Click += new System.EventHandler(this.btnGenerateEmpID_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(37, 26);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 20);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(38, 68);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 20);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(37, 181);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(97, 20);
            this.lblEmployeeId.TabIndex = 6;
            this.lblEmployeeId.Text = "Employee ID:";
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnGenerateEmpID);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "formDashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmployeeId;
        private Button btnGenerateEmpID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmployeeId;
    }
}