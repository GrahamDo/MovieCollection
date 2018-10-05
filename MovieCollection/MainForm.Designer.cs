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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.filterPanel = new System.Windows.Forms.Panel();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.directorFilterLabel = new System.Windows.Forms.Label();
            this.directorFilterSelect = new System.Windows.Forms.ComboBox();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LocationFilterSelect = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationFilterLabel = new System.Windows.Forms.Label();
            this.actorFilterLabel = new System.Windows.Forms.Label();
            this.actorFilterSelect = new System.Windows.Forms.ComboBox();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yearFilterText = new System.Windows.Forms.TextBox();
            this.yearFilterLabel = new System.Windows.Forms.Label();
            this.titleFilterText = new System.Windows.Forms.TextBox();
            this.titleFilterLabel = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addMovieButton = new System.Windows.Forms.ToolStripButton();
            this.editMovieButton = new System.Windows.Forms.ToolStripButton();
            this.deleteMovieButton = new System.Windows.Forms.ToolStripButton();
            this.browseToUrlButton = new System.Windows.Forms.ToolStripButton();
            this.seperatorButton = new System.Windows.Forms.ToolStripSeparator();
            this.locationsButton = new System.Windows.Forms.ToolStripButton();
            this.movieResultsGrid = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMovieMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMovieMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMovieMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.browseToUrlMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.movieResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorDirectorsButton = new System.Windows.Forms.ToolStripButton();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieResultsGrid)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.resultsLabel);
            this.filterPanel.Controls.Add(this.directorFilterLabel);
            this.filterPanel.Controls.Add(this.directorFilterSelect);
            this.filterPanel.Controls.Add(this.LocationFilterSelect);
            this.filterPanel.Controls.Add(this.locationFilterLabel);
            this.filterPanel.Controls.Add(this.actorFilterLabel);
            this.filterPanel.Controls.Add(this.actorFilterSelect);
            this.filterPanel.Controls.Add(this.yearFilterText);
            this.filterPanel.Controls.Add(this.yearFilterLabel);
            this.filterPanel.Controls.Add(this.titleFilterText);
            this.filterPanel.Controls.Add(this.titleFilterLabel);
            this.filterPanel.Controls.Add(this.toolStrip);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(512, 148);
            this.filterPanel.TabIndex = 0;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(9, 116);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(42, 13);
            this.resultsLabel.TabIndex = 10;
            this.resultsLabel.Text = "Results";
            // 
            // directorFilterLabel
            // 
            this.directorFilterLabel.AutoSize = true;
            this.directorFilterLabel.Location = new System.Drawing.Point(175, 63);
            this.directorFilterLabel.Name = "directorFilterLabel";
            this.directorFilterLabel.Size = new System.Drawing.Size(47, 13);
            this.directorFilterLabel.TabIndex = 9;
            this.directorFilterLabel.Text = "Director:";
            // 
            // directorFilterSelect
            // 
            this.directorFilterSelect.DataSource = this.directorBindingSource;
            this.directorFilterSelect.FormattingEnabled = true;
            this.directorFilterSelect.Location = new System.Drawing.Point(228, 55);
            this.directorFilterSelect.Name = "directorFilterSelect";
            this.directorFilterSelect.Size = new System.Drawing.Size(121, 21);
            this.directorFilterSelect.TabIndex = 8;
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataSource = typeof(MovieCollection.Models.ActorDirector);
            this.directorBindingSource.CurrentChanged += new System.EventHandler(this.directorBindingSource_CurrentChanged);
            // 
            // LocationFilterSelect
            // 
            this.LocationFilterSelect.DataSource = this.locationBindingSource;
            this.LocationFilterSelect.FormattingEnabled = true;
            this.LocationFilterSelect.Location = new System.Drawing.Point(65, 82);
            this.LocationFilterSelect.Name = "LocationFilterSelect";
            this.LocationFilterSelect.Size = new System.Drawing.Size(117, 21);
            this.LocationFilterSelect.TabIndex = 7;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(MovieCollection.Models.Location);
            this.locationBindingSource.CurrentChanged += new System.EventHandler(this.locationBindingSource_CurrentChanged);
            // 
            // locationFilterLabel
            // 
            this.locationFilterLabel.AutoSize = true;
            this.locationFilterLabel.Location = new System.Drawing.Point(8, 90);
            this.locationFilterLabel.Name = "locationFilterLabel";
            this.locationFilterLabel.Size = new System.Drawing.Size(51, 13);
            this.locationFilterLabel.TabIndex = 6;
            this.locationFilterLabel.Text = "Location:";
            // 
            // actorFilterLabel
            // 
            this.actorFilterLabel.AutoSize = true;
            this.actorFilterLabel.Location = new System.Drawing.Point(6, 63);
            this.actorFilterLabel.Name = "actorFilterLabel";
            this.actorFilterLabel.Size = new System.Drawing.Size(35, 13);
            this.actorFilterLabel.TabIndex = 5;
            this.actorFilterLabel.Text = "Actor:";
            // 
            // actorFilterSelect
            // 
            this.actorFilterSelect.DataSource = this.actorBindingSource;
            this.actorFilterSelect.FormattingEnabled = true;
            this.actorFilterSelect.Location = new System.Drawing.Point(47, 55);
            this.actorFilterSelect.Name = "actorFilterSelect";
            this.actorFilterSelect.Size = new System.Drawing.Size(121, 21);
            this.actorFilterSelect.TabIndex = 4;
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataSource = typeof(MovieCollection.Models.ActorDirector);
            this.actorBindingSource.CurrentChanged += new System.EventHandler(this.actorBindingSource_CurrentChanged);
            // 
            // yearFilterText
            // 
            this.yearFilterText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearFilterText.Location = new System.Drawing.Point(392, 30);
            this.yearFilterText.Name = "yearFilterText";
            this.yearFilterText.Size = new System.Drawing.Size(54, 20);
            this.yearFilterText.TabIndex = 3;
            this.yearFilterText.TextChanged += new System.EventHandler(this.yearFilterText_TextChanged);
            this.yearFilterText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearFilterText_KeyPress);
            // 
            // yearFilterLabel
            // 
            this.yearFilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearFilterLabel.AutoSize = true;
            this.yearFilterLabel.Location = new System.Drawing.Point(354, 34);
            this.yearFilterLabel.Name = "yearFilterLabel";
            this.yearFilterLabel.Size = new System.Drawing.Size(32, 13);
            this.yearFilterLabel.TabIndex = 2;
            this.yearFilterLabel.Text = "Year:";
            // 
            // titleFilterText
            // 
            this.titleFilterText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleFilterText.Location = new System.Drawing.Point(40, 30);
            this.titleFilterText.Name = "titleFilterText";
            this.titleFilterText.Size = new System.Drawing.Size(305, 20);
            this.titleFilterText.TabIndex = 1;
            this.titleFilterText.TextChanged += new System.EventHandler(this.titleFilterText_TextChanged);
            // 
            // titleFilterLabel
            // 
            this.titleFilterLabel.AutoSize = true;
            this.titleFilterLabel.Location = new System.Drawing.Point(3, 34);
            this.titleFilterLabel.Name = "titleFilterLabel";
            this.titleFilterLabel.Size = new System.Drawing.Size(30, 13);
            this.titleFilterLabel.TabIndex = 0;
            this.titleFilterLabel.Text = "Title:";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovieButton,
            this.editMovieButton,
            this.deleteMovieButton,
            this.browseToUrlButton,
            this.seperatorButton,
            this.actorDirectorsButton,
            this.locationsButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(512, 25);
            this.toolStrip.TabIndex = 11;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addMovieButton
            // 
            this.addMovieButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addMovieButton.Image = ((System.Drawing.Image)(resources.GetObject("addMovieButton.Image")));
            this.addMovieButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(69, 22);
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // editMovieButton
            // 
            this.editMovieButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editMovieButton.Image = ((System.Drawing.Image)(resources.GetObject("editMovieButton.Image")));
            this.editMovieButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editMovieButton.Name = "editMovieButton";
            this.editMovieButton.Size = new System.Drawing.Size(67, 22);
            this.editMovieButton.Text = "Edit Movie";
            this.editMovieButton.Click += new System.EventHandler(this.editMovieButton_Click);
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteMovieButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteMovieButton.Image")));
            this.deleteMovieButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(80, 22);
            this.deleteMovieButton.Text = "Delete Movie";
            this.deleteMovieButton.Click += new System.EventHandler(this.deleteMovieButton_Click);
            // 
            // browseToUrlButton
            // 
            this.browseToUrlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.browseToUrlButton.Image = ((System.Drawing.Image)(resources.GetObject("browseToUrlButton.Image")));
            this.browseToUrlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.browseToUrlButton.Name = "browseToUrlButton";
            this.browseToUrlButton.Size = new System.Drawing.Size(87, 22);
            this.browseToUrlButton.Text = "Browse to URL";
            this.browseToUrlButton.Click += new System.EventHandler(this.browseToUrlButton_Click);
            // 
            // seperatorButton
            // 
            this.seperatorButton.Name = "seperatorButton";
            this.seperatorButton.Size = new System.Drawing.Size(6, 25);
            // 
            // locationsButton
            // 
            this.locationsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.locationsButton.Image = ((System.Drawing.Image)(resources.GetObject("locationsButton.Image")));
            this.locationsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.locationsButton.Name = "locationsButton";
            this.locationsButton.Size = new System.Drawing.Size(62, 22);
            this.locationsButton.Text = "Locations";
            this.locationsButton.Click += new System.EventHandler(this.locationsButton_Click);
            // 
            // movieResultsGrid
            // 
            this.movieResultsGrid.AllowUserToAddRows = false;
            this.movieResultsGrid.AllowUserToDeleteRows = false;
            this.movieResultsGrid.AllowUserToResizeRows = false;
            this.movieResultsGrid.AutoGenerateColumns = false;
            this.movieResultsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.movieResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieResultsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.actorNameDataGridViewTextBoxColumn,
            this.directorNameDataGridViewTextBoxColumn,
            this.locationDescriptionDataGridViewTextBoxColumn,
            this.locationUrlDataGridViewTextBoxColumn});
            this.movieResultsGrid.ContextMenuStrip = this.contextMenuStrip;
            this.movieResultsGrid.DataSource = this.movieResultBindingSource;
            this.movieResultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieResultsGrid.Location = new System.Drawing.Point(0, 148);
            this.movieResultsGrid.MultiSelect = false;
            this.movieResultsGrid.Name = "movieResultsGrid";
            this.movieResultsGrid.ReadOnly = true;
            this.movieResultsGrid.RowHeadersVisible = false;
            this.movieResultsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movieResultsGrid.Size = new System.Drawing.Size(512, 237);
            this.movieResultsGrid.TabIndex = 1;
            this.movieResultsGrid.DoubleClick += new System.EventHandler(this.movieResultsGrid_DoubleClick);
            this.movieResultsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.movieResultsGrid_KeyDown);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 52;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 54;
            // 
            // actorNameDataGridViewTextBoxColumn
            // 
            this.actorNameDataGridViewTextBoxColumn.DataPropertyName = "ActorName";
            this.actorNameDataGridViewTextBoxColumn.HeaderText = "Actor";
            this.actorNameDataGridViewTextBoxColumn.Name = "actorNameDataGridViewTextBoxColumn";
            this.actorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.actorNameDataGridViewTextBoxColumn.Width = 57;
            // 
            // directorNameDataGridViewTextBoxColumn
            // 
            this.directorNameDataGridViewTextBoxColumn.DataPropertyName = "DirectorName";
            this.directorNameDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorNameDataGridViewTextBoxColumn.Name = "directorNameDataGridViewTextBoxColumn";
            this.directorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.directorNameDataGridViewTextBoxColumn.Width = 69;
            // 
            // locationDescriptionDataGridViewTextBoxColumn
            // 
            this.locationDescriptionDataGridViewTextBoxColumn.DataPropertyName = "LocationDescription";
            this.locationDescriptionDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDescriptionDataGridViewTextBoxColumn.Name = "locationDescriptionDataGridViewTextBoxColumn";
            this.locationDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDescriptionDataGridViewTextBoxColumn.Width = 73;
            // 
            // locationUrlDataGridViewTextBoxColumn
            // 
            this.locationUrlDataGridViewTextBoxColumn.DataPropertyName = "LocationUrl";
            this.locationUrlDataGridViewTextBoxColumn.HeaderText = "Location URL";
            this.locationUrlDataGridViewTextBoxColumn.Name = "locationUrlDataGridViewTextBoxColumn";
            this.locationUrlDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationUrlDataGridViewTextBoxColumn.Width = 98;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMovieMenu,
            this.editMovieMenu,
            this.deleteMovieMenu,
            this.contextMenuSeperator,
            this.browseToUrlMenu});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(151, 98);
            // 
            // addMovieMenu
            // 
            this.addMovieMenu.Name = "addMovieMenu";
            this.addMovieMenu.Size = new System.Drawing.Size(150, 22);
            this.addMovieMenu.Text = "Add";
            this.addMovieMenu.Click += new System.EventHandler(this.addMovieMenu_Click);
            // 
            // editMovieMenu
            // 
            this.editMovieMenu.Name = "editMovieMenu";
            this.editMovieMenu.Size = new System.Drawing.Size(150, 22);
            this.editMovieMenu.Text = "Edit";
            this.editMovieMenu.Click += new System.EventHandler(this.editMovieMenu_Click);
            // 
            // deleteMovieMenu
            // 
            this.deleteMovieMenu.Name = "deleteMovieMenu";
            this.deleteMovieMenu.Size = new System.Drawing.Size(150, 22);
            this.deleteMovieMenu.Text = "Delete";
            this.deleteMovieMenu.Click += new System.EventHandler(this.deleteMovieMenu_Click);
            // 
            // contextMenuSeperator
            // 
            this.contextMenuSeperator.Name = "contextMenuSeperator";
            this.contextMenuSeperator.Size = new System.Drawing.Size(147, 6);
            // 
            // browseToUrlMenu
            // 
            this.browseToUrlMenu.Name = "browseToUrlMenu";
            this.browseToUrlMenu.Size = new System.Drawing.Size(150, 22);
            this.browseToUrlMenu.Text = "Browse to URL";
            this.browseToUrlMenu.Click += new System.EventHandler(this.browseToUrlMenu_Click);
            // 
            // movieResultBindingSource
            // 
            this.movieResultBindingSource.DataSource = typeof(MovieCollection.Models.MovieResult);
            this.movieResultBindingSource.CurrentChanged += new System.EventHandler(this.movieResultBindingSource_CurrentChanged);
            // 
            // actorDirectorsButton
            // 
            this.actorDirectorsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.actorDirectorsButton.Image = ((System.Drawing.Image)(resources.GetObject("actorDirectorsButton.Image")));
            this.actorDirectorsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actorDirectorsButton.Name = "actorDirectorsButton";
            this.actorDirectorsButton.Size = new System.Drawing.Size(103, 22);
            this.actorDirectorsButton.Text = "Actors / Directors";
            this.actorDirectorsButton.Click += new System.EventHandler(this.actorDirectorsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 385);
            this.Controls.Add(this.movieResultsGrid);
            this.Controls.Add(this.filterPanel);
            this.Name = "MainForm";
            this.Text = "Movie Collection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieResultsGrid)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movieResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.TextBox yearFilterText;
        private System.Windows.Forms.Label yearFilterLabel;
        private System.Windows.Forms.TextBox titleFilterText;
        private System.Windows.Forms.Label titleFilterLabel;
        private System.Windows.Forms.ComboBox actorFilterSelect;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private System.Windows.Forms.ComboBox LocationFilterSelect;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.Label locationFilterLabel;
        private System.Windows.Forms.Label actorFilterLabel;
        private System.Windows.Forms.Label directorFilterLabel;
        private System.Windows.Forms.ComboBox directorFilterSelect;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private System.Windows.Forms.DataGridView movieResultsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource movieResultBindingSource;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addMovieButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addMovieMenu;
        private System.Windows.Forms.ToolStripSeparator contextMenuSeperator;
        private System.Windows.Forms.ToolStripMenuItem browseToUrlMenu;
        private System.Windows.Forms.ToolStripButton browseToUrlButton;
        private System.Windows.Forms.ToolStripButton editMovieButton;
        private System.Windows.Forms.ToolStripMenuItem editMovieMenu;
        private System.Windows.Forms.ToolStripButton deleteMovieButton;
        private System.Windows.Forms.ToolStripMenuItem deleteMovieMenu;
        private System.Windows.Forms.ToolStripSeparator seperatorButton;
        private System.Windows.Forms.ToolStripButton locationsButton;
        private System.Windows.Forms.ToolStripButton actorDirectorsButton;
    }
}

