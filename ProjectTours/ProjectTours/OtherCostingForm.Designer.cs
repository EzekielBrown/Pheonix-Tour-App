namespace ProjectTours
{
    partial class OtherCostingForm
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
            this.cost = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(77, 71);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(170, 23);
            this.cost.TabIndex = 30;
            this.cost.Text = "0";
            this.cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cost_KeyPress);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(9, 74);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(34, 15);
            this.costLabel.TabIndex = 23;
            this.costLabel.Text = "Cost:";
            // 
            // OtherCostingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 504);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.costLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OtherCostingForm";
            this.Text = "OtherCostingForm";
            this.Controls.SetChildIndex(this.costLabel, 0);
            this.Controls.SetChildIndex(this.cost, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox cost;
        private Label costLabel;
        private Label label1;
        private TextBox id;
        private TextBox otherCostingName;
    }
}