namespace MovieCollection
{
    partial class MainForm
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
            this.filterPanel = new System.Windows.Forms.Panel();
            this.yearFilterText = new System.Windows.Forms.TextBox();
            this.yearFilterLabel = new System.Windows.Forms.Label();
            this.filterTitleText = new System.Windows.Forms.TextBox();
            this.titleFilterLabel = new System.Windows.Forms.Label();
            this.actorFilterSelect = new System.Windows.Forms.ComboBox();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorFilterLabel = new System.Windows.Forms.Label();
            this.locationFilterLabel = new System.Windows.Forms.Label();
            this.LocationFilterSelect = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.LocationFilterSelect);
            this.filterPanel.Controls.Add(this.locationFilterLabel);
            this.filterPanel.Controls.Add(this.actorFilterLabel);
            this.filterPanel.Controls.Add(this.actorFilterSelect);
            this.filterPanel.Controls.Add(this.yearFilterText);
            this.filterPanel.Controls.Add(this.yearFilterLabel);
            this.filterPanel.Controls.Add(this.filterTitleText);
            this.filterPanel.Controls.Add(this.titleFilterLabel);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(454, 100);
            this.filterPanel.TabIndex = 0;
            // 
            // yearFilterText
            // 
            this.yearFilterText.Location = new System.Drawing.Point(334, 5);
            this.yearFilterText.Name = "yearFilterText";
            this.yearFilterText.Size = new System.Drawing.Size(54, 20);
            this.yearFilterText.TabIndex = 3;
            this.yearFilterText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearFilterText_KeyPress);
            // 
            // yearFilterLabel
            // 
            this.yearFilterLabel.AutoSize = true;
            this.yearFilterLabel.Location = new System.Drawing.Point(296, 12);
            this.yearFilterLabel.Name = "yearFilterLabel";
            this.yearFilterLabel.Size = new System.Drawing.Size(32, 13);
            this.yearFilterLabel.TabIndex = 2;
            this.yearFilterLabel.Text = "Year:";
            // 
            // filterTitleText
            // 
            this.filterTitleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTitleText.Location = new System.Drawing.Point(40, 5);
            this.filterTitleText.Name = "filterTitleText";
            this.filterTitleText.Size = new System.Drawing.Size(247, 20);
            this.filterTitleText.TabIndex = 1;
            // 
            // titleFilterLabel
            // 
            this.titleFilterLabel.AutoSize = true;
            this.titleFilterLabel.Location = new System.Drawing.Point(3, 9);
            this.titleFilterLabel.Name = "titleFilterLabel";
            this.titleFilterLabel.Size = new System.Drawing.Size(30, 13);
            this.titleFilterLabel.TabIndex = 0;
            this.titleFilterLabel.Text = "Title:";
            // 
            // actorFilterSelect
            // 
            this.actorFilterSelect.DataSource = this.actorBindingSource;
            this.actorFilterSelect.FormattingEnabled = true;
            this.actorFilterSelect.Location = new System.Drawing.Point(47, 30);
            this.actorFilterSelect.Name = "actorFilterSelect";
            this.actorFilterSelect.Size = new System.Drawing.Size(121, 21);
            this.actorFilterSelect.TabIndex = 4;
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataSource = typeof(MovieCollection.Models.Actor);
            // 
            // actorFilterLabel
            // 
            this.actorFilterLabel.AutoSize = true;
            this.actorFilterLabel.Location = new System.Drawing.Point(6, 38);
            this.actorFilterLabel.Name = "actorFilterLabel";
            this.actorFilterLabel.Size = new System.Drawing.Size(35, 13);
            this.actorFilterLabel.TabIndex = 5;
            this.actorFilterLabel.Text = "Actor:";
            // 
            // locationFilterLabel
            // 
            this.locationFilterLabel.AutoSize = true;
            this.locationFilterLabel.Location = new System.Drawing.Point(174, 38);
            this.locationFilterLabel.Name = "locationFilterLabel";
            this.locationFilterLabel.Size = new System.Drawing.Size(51, 13);
            this.locationFilterLabel.TabIndex = 6;
            this.locationFilterLabel.Text = "Location:";
            // 
            // LocationFilterSelect
            // 
            this.LocationFilterSelect.DataSource = this.locationBindingSource;
            this.LocationFilterSelect.FormattingEnabled = true;
            this.LocationFilterSelect.Location = new System.Drawing.Point(231, 30);
            this.LocationFilterSelect.Name = "LocationFilterSelect";
            this.LocationFilterSelect.Size = new System.Drawing.Size(117, 21);
            this.LocationFilterSelect.TabIndex = 7;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(MovieCollection.Models.Location);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.filterPanel);
            this.Name = "MainForm";
            this.Text = "Movie Collection";
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.TextBox yearFilterText;
        private System.Windows.Forms.Label yearFilterLabel;
        private System.Windows.Forms.TextBox filterTitleText;
        private System.Windows.Forms.Label titleFilterLabel;
        private System.Windows.Forms.ComboBox actorFilterSelect;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private System.Windows.Forms.ComboBox LocationFilterSelect;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.Label locationFilterLabel;
        private System.Windows.Forms.Label actorFilterLabel;
    }
}

