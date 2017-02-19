namespace simple_test
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
            this.btnGetWorkspaces = new System.Windows.Forms.Button();
            this.lvWorkspaces = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastAccess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chComputer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteWorkspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetWorkspaces
            // 
            this.btnGetWorkspaces.Location = new System.Drawing.Point(13, 13);
            this.btnGetWorkspaces.Name = "btnGetWorkspaces";
            this.btnGetWorkspaces.Size = new System.Drawing.Size(75, 23);
            this.btnGetWorkspaces.TabIndex = 0;
            this.btnGetWorkspaces.Text = "Get";
            this.btnGetWorkspaces.UseVisualStyleBackColor = true;
            this.btnGetWorkspaces.Click += new System.EventHandler(this.btnGetWorkspaces_Click);
            // 
            // lvWorkspaces
            // 
            this.lvWorkspaces.CheckBoxes = true;
            this.lvWorkspaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chOwner,
            this.chComputer,
            this.chLastAccess,
            this.chComment});
            this.lvWorkspaces.FullRowSelect = true;
            this.lvWorkspaces.Location = new System.Drawing.Point(12, 43);
            this.lvWorkspaces.Name = "lvWorkspaces";
            this.lvWorkspaces.Size = new System.Drawing.Size(850, 348);
            this.lvWorkspaces.TabIndex = 1;
            this.lvWorkspaces.UseCompatibleStateImageBehavior = false;
            this.lvWorkspaces.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 120;
            // 
            // chOwner
            // 
            this.chOwner.Text = "Owner";
            this.chOwner.Width = 120;
            // 
            // chLastAccess
            // 
            this.chLastAccess.DisplayIndex = 2;
            this.chLastAccess.Text = "Last Access";
            this.chLastAccess.Width = 120;
            // 
            // chComputer
            // 
            this.chComputer.DisplayIndex = 3;
            this.chComputer.Text = "Computer";
            this.chComputer.Width = 120;
            // 
            // chComment
            // 
            this.chComment.Text = "Comment";
            this.chComment.Width = 240;
            // 
            // btnDeleteWorkspace
            // 
            this.btnDeleteWorkspace.Location = new System.Drawing.Point(94, 14);
            this.btnDeleteWorkspace.Name = "btnDeleteWorkspace";
            this.btnDeleteWorkspace.Size = new System.Drawing.Size(172, 23);
            this.btnDeleteWorkspace.TabIndex = 0;
            this.btnDeleteWorkspace.Text = "Delete Workspace";
            this.btnDeleteWorkspace.UseVisualStyleBackColor = true;
            this.btnDeleteWorkspace.Click += new System.EventHandler(this.btnDeleteWorkspace_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 403);
            this.Controls.Add(this.lvWorkspaces);
            this.Controls.Add(this.btnDeleteWorkspace);
            this.Controls.Add(this.btnGetWorkspaces);
            this.Name = "MainForm";
            this.Text = "TFS Workspace Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetWorkspaces;
        private System.Windows.Forms.ListView lvWorkspaces;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chOwner;
        private System.Windows.Forms.ColumnHeader chComputer;
        private System.Windows.Forms.ColumnHeader chLastAccess;
        private System.Windows.Forms.ColumnHeader chComment;
        private System.Windows.Forms.Button btnDeleteWorkspace;
    }
}

