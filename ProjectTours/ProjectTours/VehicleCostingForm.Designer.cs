namespace ProjectTours
{
    partial class VehicleCostingForm
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
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.regoLabel = new System.Windows.Forms.Label();
            this.wofExpiryLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.rego = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.make = new System.Windows.Forms.TextBox();
            this.wofExpiry = new System.Windows.Forms.DateTimePicker();
            this.vehicleType = new System.Windows.Forms.ComboBox();
            this.pricePerKMLabel = new System.Windows.Forms.Label();
            this.pricePerKM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(12, 85);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(39, 15);
            this.makeLabel.TabIndex = 4;
            this.makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(12, 128);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(44, 15);
            this.modelLabel.TabIndex = 5;
            this.modelLabel.Text = "Model:";
            // 
            // regoLabel
            // 
            this.regoLabel.AutoSize = true;
            this.regoLabel.Location = new System.Drawing.Point(12, 163);
            this.regoLabel.Name = "regoLabel";
            this.regoLabel.Size = new System.Drawing.Size(37, 15);
            this.regoLabel.TabIndex = 6;
            this.regoLabel.Text = "Rego:";
            // 
            // wofExpiryLabel
            // 
            this.wofExpiryLabel.Location = new System.Drawing.Point(239, 80);
            this.wofExpiryLabel.Name = "wofExpiryLabel";
            this.wofExpiryLabel.Size = new System.Drawing.Size(77, 30);
            this.wofExpiryLabel.TabIndex = 7;
            this.wofExpiryLabel.Text = "WOF Expiry Date";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(231, 123);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(85, 15);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "Type of Vehicle";
            // 
            // rego
            // 
            this.rego.Location = new System.Drawing.Point(110, 160);
            this.rego.Name = "rego";
            this.rego.Size = new System.Drawing.Size(100, 23);
            this.rego.TabIndex = 9;
            this.rego.Text = "ABC123";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(110, 120);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(100, 23);
            this.model.TabIndex = 10;
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(110, 80);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(100, 23);
            this.make.TabIndex = 11;
            this.make.Text = "Acura";
            // 
            // wofExpiry
            // 
            this.wofExpiry.Location = new System.Drawing.Point(322, 80);
            this.wofExpiry.Name = "wofExpiry";
            this.wofExpiry.Size = new System.Drawing.Size(200, 23);
            this.wofExpiry.TabIndex = 12;
            // 
            // vehicleType
            // 
            this.vehicleType.FormattingEnabled = true;
            this.vehicleType.Location = new System.Drawing.Point(322, 120);
            this.vehicleType.Name = "vehicleType";
            this.vehicleType.Size = new System.Drawing.Size(121, 23);
            this.vehicleType.TabIndex = 13;
            // 
            // pricePerKMLabel
            // 
            this.pricePerKMLabel.AutoSize = true;
            this.pricePerKMLabel.Location = new System.Drawing.Point(12, 203);
            this.pricePerKMLabel.Name = "pricePerKMLabel";
            this.pricePerKMLabel.Size = new System.Drawing.Size(74, 15);
            this.pricePerKMLabel.TabIndex = 16;
            this.pricePerKMLabel.Text = "Price Per KM";
            // 
            // pricePerKM
            // 
            this.pricePerKM.Location = new System.Drawing.Point(112, 200);
            this.pricePerKM.Name = "pricePerKM";
            this.pricePerKM.Size = new System.Drawing.Size(100, 23);
            this.pricePerKM.TabIndex = 17;
            this.pricePerKM.Text = "0";
            this.pricePerKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricePerKM_KeyPress);
            // 
            // VehicleCostingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 504);
            this.Controls.Add(this.pricePerKM);
            this.Controls.Add(this.pricePerKMLabel);
            this.Controls.Add(this.vehicleType);
            this.Controls.Add(this.wofExpiry);
            this.Controls.Add(this.make);
            this.Controls.Add(this.model);
            this.Controls.Add(this.rego);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.wofExpiryLabel);
            this.Controls.Add(this.regoLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VehicleCostingForm";
            this.Text = "NewVehicleForm";
            this.Controls.SetChildIndex(this.makeLabel, 0);
            this.Controls.SetChildIndex(this.modelLabel, 0);
            this.Controls.SetChildIndex(this.regoLabel, 0);
            this.Controls.SetChildIndex(this.wofExpiryLabel, 0);
            this.Controls.SetChildIndex(this.typeLabel, 0);
            this.Controls.SetChildIndex(this.rego, 0);
            this.Controls.SetChildIndex(this.model, 0);
            this.Controls.SetChildIndex(this.make, 0);
            this.Controls.SetChildIndex(this.wofExpiry, 0);
            this.Controls.SetChildIndex(this.vehicleType, 0);
            this.Controls.SetChildIndex(this.pricePerKMLabel, 0);
            this.Controls.SetChildIndex(this.pricePerKM, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label makeLabel;
        private Label modelLabel;
        private Label regoLabel;
        private Label wofExpiryLabel;
        private Label typeLabel;
        private TextBox rego;
        private TextBox model;
        private TextBox make;
        private DateTimePicker wofExpiry;
        private ComboBox vehicleType;
        private Label pricePerKMLabel;
        private TextBox pricePerKM;
    }
}