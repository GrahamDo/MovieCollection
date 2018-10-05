namespace MovieCollection
{
    partial class ActorsDirectorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorsDirectorsForm));
            this.actorDirectorsGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isDirectorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.actorDirectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.actorDirectorsGrid)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorDirectorBindingSource)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // actorDirectorsGrid
            // 
            this.actorDirectorsGrid.AllowUserToAddRows = false;
            this.actorDirectorsGrid.AllowUserToDeleteRows = false;
            this.actorDirectorsGrid.AllowUserToResizeRows = false;
            this.actorDirectorsGrid.AutoGenerateColumns = false;
            this.actorDirectorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorDirectorsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.isActorDataGridViewCheckBoxColumn,
            this.isDirectorDataGridViewCheckBoxColumn});
            this.actorDirectorsGrid.ContextMenuStrip = this.contextMenuStrip;
            this.actorDirectorsGrid.DataSource = this.actorDirectorBindingSource;
            this.actorDirectorsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actorDirectorsGrid.Location = new System.Drawing.Point(0, 25);
            this.actorDirectorsGrid.Name = "actorDirectorsGrid";
            this.actorDirectorsGrid.ReadOnly = true;
            this.actorDirectorsGrid.RowHeadersVisible = false;
            this.actorDirectorsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.actorDirectorsGrid.Size = new System.Drawing.Size(309, 236);
            this.actorDirectorsGrid.TabIndex = 1;
            this.actorDirectorsGrid.DoubleClick += new System.EventHandler(this.actorDirectorsGrid_DoubleClick);
            this.actorDirectorsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.actorDirectorsGrid_KeyDown);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActorDataGridViewCheckBoxColumn
            // 
            this.isActorDataGridViewCheckBoxColumn.DataPropertyName = "IsActor";
            this.isActorDataGridViewCheckBoxColumn.HeaderText = "Actor?";
            this.isActorDataGridViewCheckBoxColumn.Name = "isActorDataGridViewCheckBoxColumn";
            this.isActorDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isDirectorDataGridViewCheckBoxColumn
            // 
            this.isDirectorDataGridViewCheckBoxColumn.DataPropertyName = "IsDirector";
            this.isDirectorDataGridViewCheckBoxColumn.HeaderText = "Director?";
            this.isDirectorDataGridViewCheckBoxColumn.Name = "isDirectorDataGridViewCheckBoxColumn";
            this.isDirectorDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenu,
            this.editMenu,
            this.deleteMenu});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 70);
            // 
            // addMenu
            // 
            this.addMenu.Name = "addMenu";
            this.addMenu.Size = new System.Drawing.Size(107, 22);
            this.addMenu.Text = "Add";
            this.addMenu.Click += new System.EventHandler(this.addMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(107, 22);
            this.editMenu.Text = "Edit";
            this.editMenu.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // deleteMenu
            // 
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(107, 22);
            this.deleteMenu.Text = "Delete";
            this.deleteMenu.Click += new System.EventHandler(this.deleteMenu_Click);
            // 
            // actorDirectorBindingSource
            // 
            this.actorDirectorBindingSource.DataSource = typeof(MovieCollection.Models.ActorDirector);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.editButton,
            this.deleteButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(309, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(33, 22);
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(31, 22);
            this.editButton.Text = "Edit";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(44, 22);
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ActorsDirectorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 261);
            this.Controls.Add(this.actorDirectorsGrid);
            this.Controls.Add(this.toolStrip);
            this.Name = "ActorsDirectorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actors / Directors";
            ((System.ComponentModel.ISupportInitialize)(this.actorDirectorsGrid)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actorDirectorBindingSource)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView actorDirectorsGrid;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addMenu;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton editButton;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenu;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDirectorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource actorDirectorBindingSource;
    }
}