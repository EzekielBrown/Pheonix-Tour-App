namespace ProjectTours
{
    partial class TourForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.costingListBox = new System.Windows.Forms.ListBox();
            this.dateCreatedLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.tourName = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.costNameLabel = new System.Windows.Forms.Label();
            this.costDescriptionLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.kmLabel = new System.Windows.Forms.Label();
            this.costingType = new System.Windows.Forms.ComboBox();
            this.editButon = new System.Windows.Forms.Button();
            this.dateCreated = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 2);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // costingListBox
            // 
            this.costingListBox.FormattingEnabled = true;
            this.costingListBox.ItemHeight = 15;
            this.costingListBox.Location = new System.Drawing.Point(12, 241);
            this.costingListBox.Name = "costingListBox";
            this.costingListBox.Size = new System.Drawing.Size(510, 199);
            this.costingListBox.Sorted = true;
            this.costingListBox.TabIndex = 2;
            // 
            // dateCreatedLabel
            // 
            this.dateCreatedLabel.AutoSize = true;
            this.dateCreatedLabel.Location = new System.Drawing.Point(12, 76);
            this.dateCreatedLabel.Name = "dateCreatedLabel";
            this.dateCreatedLabel.Size = new System.Drawing.Size(78, 15);
            this.dateCreatedLabel.TabIndex = 3;
            this.dateCreatedLabel.Text = "Date Created:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 443);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(174, 442);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(447, 469);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(366, 469);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(446, 41);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID:";
            // 
            // tourName
            // 
            this.tourName.BackColor = System.Drawing.SystemColors.Menu;
            this.tourName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tourName.Font = new System.Drawing.Font("Heavitas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tourName.Location = new System.Drawing.Point(12, 24);
            this.tourName.Name = "tourName";
            this.tourName.PlaceholderText = "Tour Name";
            this.tourName.Size = new System.Drawing.Size(429, 28);
            this.tourName.TabIndex = 10;
            this.tourName.WordWrap = false;
            this.tourName.TextChanged += new System.EventHandler(this.tourName_TextChanged);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Control;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Location = new System.Drawing.Point(473, 40);
            this.id.MaxLength = 7;
            this.id.Name = "id";
            this.id.PlaceholderText = "xxxxxxx";
            this.id.Size = new System.Drawing.Size(49, 16);
            this.id.TabIndex = 11;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(12, 110);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(61, 15);
            this.startDateLabel.TabIndex = 12;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(12, 147);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(57, 15);
            this.endDateLabel.TabIndex = 13;
            this.endDateLabel.Text = "End Date:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(315, 76);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "Description:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(315, 99);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(207, 103);
            this.description.TabIndex = 15;
            this.description.Text = "";
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(108, 107);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 23);
            this.startDate.TabIndex = 19;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(108, 142);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 23);
            this.endDate.TabIndex = 20;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // costNameLabel
            // 
            this.costNameLabel.AutoSize = true;
            this.costNameLabel.Location = new System.Drawing.Point(15, 223);
            this.costNameLabel.Name = "costNameLabel";
            this.costNameLabel.Size = new System.Drawing.Size(66, 15);
            this.costNameLabel.TabIndex = 21;
            this.costNameLabel.Text = "Cost Name";
            // 
            // costDescriptionLabel
            // 
            this.costDescriptionLabel.AutoSize = true;
            this.costDescriptionLabel.Location = new System.Drawing.Point(242, 223);
            this.costDescriptionLabel.Name = "costDescriptionLabel";
            this.costDescriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.costDescriptionLabel.TabIndex = 22;
            this.costDescriptionLabel.Text = "Description";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(446, 223);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 15);
            this.priceLabel.TabIndex = 23;
            this.priceLabel.Text = "Price";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(15, 183);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(55, 15);
            this.distanceLabel.TabIndex = 24;
            this.distanceLabel.Text = "Distance:";
            // 
            // kmLabel
            // 
            this.kmLabel.AutoSize = true;
            this.kmLabel.Location = new System.Drawing.Point(214, 183);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(25, 15);
            this.kmLabel.TabIndex = 26;
            this.kmLabel.Text = "KM";
            // 
            // costingType
            // 
            this.costingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.costingType.FormattingEnabled = true;
            this.costingType.Location = new System.Drawing.Point(255, 443);
            this.costingType.Name = "costingType";
            this.costingType.Size = new System.Drawing.Size(121, 23);
            this.costingType.TabIndex = 27;
            // 
            // editButon
            // 
            this.editButon.Location = new System.Drawing.Point(93, 442);
            this.editButon.Name = "editButon";
            this.editButon.Size = new System.Drawing.Size(75, 23);
            this.editButon.TabIndex = 28;
            this.editButon.Text = "Edit";
            this.editButon.UseVisualStyleBackColor = true;
            this.editButon.Click += new System.EventHandler(this.editButon_Click);
            // 
            // dateCreated
            // 
            this.dateCreated.Location = new System.Drawing.Point(117, 76);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(100, 23);
            this.dateCreated.TabIndex = 29;
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(108, 181);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(100, 23);
            this.distance.TabIndex = 30;
            // 
            // TourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 504);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.dateCreated);
            this.Controls.Add(this.editButon);
            this.Controls.Add(this.costingType);
            this.Controls.Add(this.kmLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.costDescriptionLabel);
            this.Controls.Add(this.costNameLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.description);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.id);
            this.Controls.Add(this.tourName);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dateCreatedLabel);
            this.Controls.Add(this.costingListBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TourForm";
            this.Text = "Tour Form";
            ((System.ComponentModel.ISupportInitialize)(this.distance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private ListBox costingListBox;
        private Label dateCreatedLabel;
        private Button addButton;
        private Button removeButton;
        private Button cancelButton;
        private Button saveButton;
        private Label idLabel;
        private TextBox tourName;
        private TextBox id;
        private Label startDateLabel;
        private Label endDateLabel;
        private Label descriptionLabel;
        private RichTextBox description;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
        private Label costNameLabel;
        private Label costDescriptionLabel;
        private Label priceLabel;
        private Label distanceLabel;
        private Label kmLabel;
        private ComboBox costingType;
        private Button editButon;
        private Label dateCreated;
        private NumericUpDown distance;
    }
}