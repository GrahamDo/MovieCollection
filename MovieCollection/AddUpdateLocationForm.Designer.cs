namespace MovieCollection
{
    partial class AddUpdateLocationForm
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
            this.components = new System.ComponentModel.Container();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isUrlRequiredCheckbox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 14);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionText
            // 
            this.descriptionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationBindingSource, "Description", true));
            this.descriptionText.Location = new System.Drawing.Point(81, 7);
            this.descriptionText.MaxLength = 50;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(191, 20);
            this.descriptionText.TabIndex = 0;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(MovieCollection.Models.Location);
            // 
            // isUrlRequiredCheckbox
            // 
            this.isUrlRequiredCheckbox.AutoSize = true;
            this.isUrlRequiredCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.locationBindingSource, "IsUrlRequired", true));
            this.isUrlRequiredCheckbox.Location = new System.Drawing.Point(26, 33);
            this.isUrlRequiredCheckbox.Name = "isUrlRequiredCheckbox";
            this.isUrlRequiredCheckbox.Size = new System.Drawing.Size(99, 17);
            this.isUrlRequiredCheckbox.TabIndex = 1;
            this.isUrlRequiredCheckbox.Text = "Requires URL?";
            this.isUrlRequiredCheckbox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(116, 56);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 57);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddUpdateLocationForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.isUrlRequiredCheckbox);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.descriptionLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUpdateLocationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUpdateLocationForm";
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.CheckBox isUrlRequiredCheckbox;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}