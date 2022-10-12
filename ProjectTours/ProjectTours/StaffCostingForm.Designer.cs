namespace ProjectTours
{
    partial class StaffCostingForm
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
            this.dateStartedLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.phNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phNumber = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.role = new System.Windows.Forms.ComboBox();
            this.dateStarted = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.hourlyWageLabel = new System.Windows.Forms.Label();
            this.hourlyWage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateStartedLabel
            // 
            this.dateStartedLabel.AutoSize = true;
            this.dateStartedLabel.Location = new System.Drawing.Point(10, 85);
            this.dateStartedLabel.Name = "dateStartedLabel";
            this.dateStartedLabel.Size = new System.Drawing.Size(74, 15);
            this.dateStartedLabel.TabIndex = 0;
            this.dateStartedLabel.Text = "Date Started:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(10, 124);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(76, 15);
            this.dateOfBirthLabel.TabIndex = 3;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(10, 163);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(33, 15);
            this.roleLabel.TabIndex = 4;
            this.roleLabel.Text = "Role:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(10, 203);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(48, 15);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender:";
            // 
            // phNumberLabel
            // 
            this.phNumberLabel.AutoSize = true;
            this.phNumberLabel.Location = new System.Drawing.Point(15, 248);
            this.phNumberLabel.Name = "phNumberLabel";
            this.phNumberLabel.Size = new System.Drawing.Size(71, 15);
            this.phNumberLabel.TabIndex = 6;
            this.phNumberLabel.Text = "Ph. Number";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(15, 283);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 15);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email:";
            // 
            // phNumber
            // 
            this.phNumber.Location = new System.Drawing.Point(110, 240);
            this.phNumber.MaxLength = 9;
            this.phNumber.Name = "phNumber";
            this.phNumber.Size = new System.Drawing.Size(100, 23);
            this.phNumber.TabIndex = 10;
            this.phNumber.Text = "0200000000";
            this.phNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phNumber_KeyPress);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(110, 280);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 23);
            this.email.TabIndex = 11;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Location = new System.Drawing.Point(110, 200);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 23);
            this.gender.TabIndex = 13;
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Location = new System.Drawing.Point(110, 160);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(121, 23);
            this.role.TabIndex = 14;
            // 
            // dateStarted
            // 
            this.dateStarted.Location = new System.Drawing.Point(110, 80);
            this.dateStarted.Name = "dateStarted";
            this.dateStarted.Size = new System.Drawing.Size(200, 23);
            this.dateStarted.TabIndex = 15;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(110, 120);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dateOfBirth.TabIndex = 16;
            // 
            // hourlyWageLabel
            // 
            this.hourlyWageLabel.AutoSize = true;
            this.hourlyWageLabel.Location = new System.Drawing.Point(318, 200);
            this.hourlyWageLabel.Name = "hourlyWageLabel";
            this.hourlyWageLabel.Size = new System.Drawing.Size(79, 15);
            this.hourlyWageLabel.TabIndex = 19;
            this.hourlyWageLabel.Text = "Hourly Wage:";
            // 
            // hourlyWage
            // 
            this.hourlyWage.Location = new System.Drawing.Point(419, 194);
            this.hourlyWage.MaxLength = 5;
            this.hourlyWage.Name = "hourlyWage";
            this.hourlyWage.Size = new System.Drawing.Size(100, 23);
            this.hourlyWage.TabIndex = 20;
            this.hourlyWage.Text = "0";
            this.hourlyWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hourlyWage_KeyPress);
            // 
            // StaffCostingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 504);
            this.Controls.Add(this.hourlyWage);
            this.Controls.Add(this.hourlyWageLabel);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.dateStarted);
            this.Controls.Add(this.role);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phNumber);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phNumberLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.dateStartedLabel);
            this.Name = "StaffCostingForm";
            this.Text = "NewStaffForm";
            this.Controls.SetChildIndex(this.dateStartedLabel, 0);
            this.Controls.SetChildIndex(this.dateOfBirthLabel, 0);
            this.Controls.SetChildIndex(this.roleLabel, 0);
            this.Controls.SetChildIndex(this.genderLabel, 0);
            this.Controls.SetChildIndex(this.phNumberLabel, 0);
            this.Controls.SetChildIndex(this.emailLabel, 0);
            this.Controls.SetChildIndex(this.phNumber, 0);
            this.Controls.SetChildIndex(this.email, 0);
            this.Controls.SetChildIndex(this.gender, 0);
            this.Controls.SetChildIndex(this.role, 0);
            this.Controls.SetChildIndex(this.dateStarted, 0);
            this.Controls.SetChildIndex(this.dateOfBirth, 0);
            this.Controls.SetChildIndex(this.hourlyWageLabel, 0);
            this.Controls.SetChildIndex(this.hourlyWage, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dateStartedLabel;
        private Label dateOfBirthLabel;
        private Label roleLabel;
        private Label genderLabel;
        private Label phNumberLabel;
        private Label emailLabel;
        private TextBox phNumber;
        private TextBox email;
        private ComboBox gender;
        private ComboBox role;
        private DateTimePicker dateStarted;
        private DateTimePicker dateOfBirth;
        private Label hourlyWageLabel;
        private TextBox hourlyWage;
    }
}