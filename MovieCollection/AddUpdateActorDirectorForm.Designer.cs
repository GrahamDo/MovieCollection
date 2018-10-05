namespace MovieCollection
{
    partial class AddUpdateActorDirectorForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.isActorCheckbox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.isDirectorCheckbox = new System.Windows.Forms.CheckBox();
            this.actorDirectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.actorDirectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // descriptionText
            // 
            this.descriptionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorDirectorBindingSource, "Name", true));
            this.descriptionText.Location = new System.Drawing.Point(56, 7);
            this.descriptionText.MaxLength = 50;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(191, 20);
            this.descriptionText.TabIndex = 1;
            // 
            // isActorCheckbox
            // 
            this.isActorCheckbox.AutoSize = true;
            this.isActorCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.actorDirectorBindingSource, "IsActor", true));
            this.isActorCheckbox.Location = new System.Drawing.Point(26, 33);
            this.isActorCheckbox.Name = "isActorCheckbox";
            this.isActorCheckbox.Size = new System.Drawing.Size(68, 17);
            this.isActorCheckbox.TabIndex = 2;
            this.isActorCheckbox.Text = "Is Actor?";
            this.isActorCheckbox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(116, 56);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
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
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // isDirectorCheckbox
            // 
            this.isDirectorCheckbox.AutoSize = true;
            this.isDirectorCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.actorDirectorBindingSource, "IsDirector", true));
            this.isDirectorCheckbox.Location = new System.Drawing.Point(116, 33);
            this.isDirectorCheckbox.Name = "isDirectorCheckbox";
            this.isDirectorCheckbox.Size = new System.Drawing.Size(74, 17);
            this.isDirectorCheckbox.TabIndex = 5;
            this.isDirectorCheckbox.Text = "Is Director";
            this.isDirectorCheckbox.UseVisualStyleBackColor = true;
            // 
            // actorDirectorBindingSource
            // 
            this.actorDirectorBindingSource.DataSource = typeof(MovieCollection.Models.ActorDirector);
            // 
            // AddUpdateActorDirectorForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.Controls.Add(this.isDirectorCheckbox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.isActorCheckbox);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUpdateActorDirectorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUpdateLocationForm";
            ((System.ComponentModel.ISupportInitialize)(this.actorDirectorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.CheckBox isActorCheckbox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource actorDirectorBindingSource;
        private System.Windows.Forms.CheckBox isDirectorCheckbox;
    }
}