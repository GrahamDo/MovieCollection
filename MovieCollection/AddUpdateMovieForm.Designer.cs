namespace MovieCollection
{
    partial class AddUpdateMovieForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.actorLabel = new System.Windows.Forms.Label();
            this.actorSelect = new System.Windows.Forms.ComboBox();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorLabel = new System.Windows.Forms.Label();
            this.directorSelect = new System.Windows.Forms.ComboBox();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationSelect = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationUrlLabel = new System.Windows.Forms.Label();
            this.locationUrlText = new System.Windows.Forms.TextBox();
            this.locationUrlBrowseButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.locationUrlBrowseDialog = new System.Windows.Forms.OpenFileDialog();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(24, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // titleText
            // 
            this.titleText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Title", true));
            this.titleText.Location = new System.Drawing.Point(61, 7);
            this.titleText.MaxLength = 50;
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(304, 20);
            this.titleText.TabIndex = 1;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(MovieCollection.Models.Movie);
            // 
            // yearText
            // 
            this.yearText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Year", true));
            this.yearText.Location = new System.Drawing.Point(61, 33);
            this.yearText.MaxLength = 10;
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(54, 20);
            this.yearText.TabIndex = 2;
            this.yearText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearText_KeyPress);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(24, 40);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year:";
            // 
            // actorLabel
            // 
            this.actorLabel.AutoSize = true;
            this.actorLabel.Location = new System.Drawing.Point(19, 67);
            this.actorLabel.Name = "actorLabel";
            this.actorLabel.Size = new System.Drawing.Size(35, 13);
            this.actorLabel.TabIndex = 7;
            this.actorLabel.Text = "Actor:";
            // 
            // actorSelect
            // 
            this.actorSelect.DataSource = this.actorBindingSource;
            this.actorSelect.FormattingEnabled = true;
            this.actorSelect.Location = new System.Drawing.Point(61, 59);
            this.actorSelect.Name = "actorSelect";
            this.actorSelect.Size = new System.Drawing.Size(121, 21);
            this.actorSelect.TabIndex = 6;
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataSource = typeof(MovieCollection.Models.ActorDirector);
            this.actorBindingSource.CurrentChanged += new System.EventHandler(this.actorBindingSource_CurrentChanged);
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(7, 94);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(47, 13);
            this.directorLabel.TabIndex = 11;
            this.directorLabel.Text = "Director:";
            // 
            // directorSelect
            // 
            this.directorSelect.DataSource = this.directorBindingSource;
            this.directorSelect.FormattingEnabled = true;
            this.directorSelect.Location = new System.Drawing.Point(61, 86);
            this.directorSelect.Name = "directorSelect";
            this.directorSelect.Size = new System.Drawing.Size(121, 21);
            this.directorSelect.TabIndex = 10;
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataSource = typeof(MovieCollection.Models.ActorDirector);
            this.directorBindingSource.CurrentChanged += new System.EventHandler(this.directorBindingSource_CurrentChanged);
            // 
            // locationSelect
            // 
            this.locationSelect.DataSource = this.locationBindingSource;
            this.locationSelect.FormattingEnabled = true;
            this.locationSelect.Location = new System.Drawing.Point(61, 113);
            this.locationSelect.Name = "locationSelect";
            this.locationSelect.Size = new System.Drawing.Size(117, 21);
            this.locationSelect.TabIndex = 13;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(MovieCollection.Models.Location);
            this.locationBindingSource.CurrentChanged += new System.EventHandler(this.locationBindingSource_CurrentChanged);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(4, 121);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 12;
            this.locationLabel.Text = "Location:";
            // 
            // locationUrlLabel
            // 
            this.locationUrlLabel.AutoSize = true;
            this.locationUrlLabel.Location = new System.Drawing.Point(58, 147);
            this.locationUrlLabel.Name = "locationUrlLabel";
            this.locationUrlLabel.Size = new System.Drawing.Size(32, 13);
            this.locationUrlLabel.TabIndex = 14;
            this.locationUrlLabel.Text = "URL:";
            // 
            // locationUrlText
            // 
            this.locationUrlText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "LocationUrl", true));
            this.locationUrlText.Location = new System.Drawing.Point(96, 140);
            this.locationUrlText.MaxLength = 2083;
            this.locationUrlText.Name = "locationUrlText";
            this.locationUrlText.Size = new System.Drawing.Size(235, 20);
            this.locationUrlText.TabIndex = 15;
            // 
            // locationUrlBrowseButton
            // 
            this.locationUrlBrowseButton.Location = new System.Drawing.Point(337, 137);
            this.locationUrlBrowseButton.Name = "locationUrlBrowseButton";
            this.locationUrlBrowseButton.Size = new System.Drawing.Size(28, 23);
            this.locationUrlBrowseButton.TabIndex = 16;
            this.locationUrlBrowseButton.Text = "...";
            this.locationUrlBrowseButton.UseVisualStyleBackColor = true;
            this.locationUrlBrowseButton.Click += new System.EventHandler(this.locationUrlBrowseButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(209, 179);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "Add";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(290, 179);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(7, 207);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(35, 13);
            this.resultLabel.TabIndex = 19;
            this.resultLabel.Text = "label1";
            this.resultLabel.Visible = false;
            // 
            // AddUpdateMovieForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(377, 229);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.locationUrlBrowseButton);
            this.Controls.Add(this.locationUrlText);
            this.Controls.Add(this.locationUrlLabel);
            this.Controls.Add(this.locationSelect);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.directorSelect);
            this.Controls.Add(this.actorLabel);
            this.Controls.Add(this.actorSelect);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUpdateMovieForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUpdateMovieForm";
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label actorLabel;
        private System.Windows.Forms.ComboBox actorSelect;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.ComboBox directorSelect;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private System.Windows.Forms.ComboBox locationSelect;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.Label locationUrlLabel;
        private System.Windows.Forms.TextBox locationUrlText;
        private System.Windows.Forms.Button locationUrlBrowseButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog locationUrlBrowseDialog;
        private System.Windows.Forms.Label resultLabel;
    }
}