namespace ProjectTours
{
    partial class CostingForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(446, 455);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(365, 455);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Menu;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Location = new System.Drawing.Point(464, 26);
            this.id.Name = "id";
            this.id.PlaceholderText = "xxxxxxx";
            this.id.Size = new System.Drawing.Size(59, 16);
            this.id.TabIndex = 25;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(438, 27);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 24;
            this.idLabel.Text = "ID:";
            // 
            // dividerLabel
            // 
            this.dividerLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dividerLabel.Location = new System.Drawing.Point(14, 45);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(500, 2);
            this.dividerLabel.TabIndex = 23;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.Menu;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Heavitas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(14, 12);
            this.name.Name = "name";
            this.name.PlaceholderText = "Name";
            this.name.Size = new System.Drawing.Size(425, 28);
            this.name.TabIndex = 28;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(14, 327);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(500, 122);
            this.notes.TabIndex = 29;
            this.notes.Text = "";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(14, 309);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(41, 15);
            this.notesLabel.TabIndex = 30;
            this.notesLabel.Text = "Notes:";
            // 
            // CostingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 504);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.id);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.dividerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CostingForm";
            this.Text = "CostingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelButton;
        private Button saveButton;
        private TextBox id;
        private Label idLabel;
        private Label dividerLabel;
        private TextBox name;
        private RichTextBox notes;
        private Label notesLabel;
    }
}