﻿namespace GearEditor
{
    partial class GearEditorForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblYourGears = new System.Windows.Forms.Label();
            this.listGear = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeViewGear = new System.Windows.Forms.TreeView();
            this.propertyGridGear = new System.Windows.Forms.PropertyGrid();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gearBoxEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shaftEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemove);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.lblYourGears);
            this.splitContainer1.Panel1.Controls.Add(this.listGear);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btnSelect);
            this.splitContainer1.Size = new System.Drawing.Size(423, 521);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DimGray;
            this.btnEdit.Location = new System.Drawing.Point(135, 480);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(29, 29);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "✎";
            this.btnEdit.UseCompatibleTextRendering = true;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemove.Location = new System.Drawing.Point(100, 480);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnRemove.Size = new System.Drawing.Size(29, 29);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "-";
            this.btnRemove.UseCompatibleTextRendering = true;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdd.Location = new System.Drawing.Point(65, 480);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(29, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseCompatibleTextRendering = true;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblYourGears
            // 
            this.lblYourGears.AutoSize = true;
            this.lblYourGears.Location = new System.Drawing.Point(5, 9);
            this.lblYourGears.Name = "lblYourGears";
            this.lblYourGears.Size = new System.Drawing.Size(63, 13);
            this.lblYourGears.TabIndex = 1;
            this.lblYourGears.Text = "Your Gears:";
            // 
            // listGear
            // 
            this.listGear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listGear.DisplayMember = "Name";
            this.listGear.FormattingEnabled = true;
            this.listGear.Location = new System.Drawing.Point(8, 24);
            this.listGear.Name = "listGear";
            this.listGear.Size = new System.Drawing.Size(156, 446);
            this.listGear.TabIndex = 0;
            this.listGear.ValueMember = "Gear";
            this.listGear.SelectedIndexChanged += new System.EventHandler(this.listGear_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(-1, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeViewGear);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGridGear);
            this.splitContainer2.Size = new System.Drawing.Size(253, 480);
            this.splitContainer2.SplitterDistance = 133;
            this.splitContainer2.TabIndex = 5;
            // 
            // treeViewGear
            // 
            this.treeViewGear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewGear.Location = new System.Drawing.Point(3, 3);
            this.treeViewGear.Name = "treeViewGear";
            this.treeViewGear.Size = new System.Drawing.Size(247, 127);
            this.treeViewGear.TabIndex = 0;
            this.treeViewGear.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewGear_AfterSelect);
            // 
            // propertyGridGear
            // 
            this.propertyGridGear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridGear.Enabled = false;
            this.propertyGridGear.Location = new System.Drawing.Point(4, 3);
            this.propertyGridGear.Name = "propertyGridGear";
            this.propertyGridGear.Size = new System.Drawing.Size(246, 337);
            this.propertyGridGear.TabIndex = 0;
            this.propertyGridGear.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridGear_PropertyValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(165, 485);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(78, 485);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.goToToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gearBoxEditorToolStripMenuItem,
            this.shaftEditorToolStripMenuItem,
            this.materialEditorToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.goToToolStripMenuItem.Text = "Go To...";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.goToToolStripMenuItem_Click);
            // 
            // gearBoxEditorToolStripMenuItem
            // 
            this.gearBoxEditorToolStripMenuItem.Name = "gearBoxEditorToolStripMenuItem";
            this.gearBoxEditorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.gearBoxEditorToolStripMenuItem.Text = "Gear Box Editor";
            this.gearBoxEditorToolStripMenuItem.Click += new System.EventHandler(this.gearBoxEditorToolStripMenuItem_Click);
            // 
            // shaftEditorToolStripMenuItem
            // 
            this.shaftEditorToolStripMenuItem.Name = "shaftEditorToolStripMenuItem";
            this.shaftEditorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.shaftEditorToolStripMenuItem.Text = "Shaft Editor ";
            this.shaftEditorToolStripMenuItem.Click += new System.EventHandler(this.shaftEditorToolStripMenuItem_Click);
            // 
            // materialEditorToolStripMenuItem
            // 
            this.materialEditorToolStripMenuItem.Name = "materialEditorToolStripMenuItem";
            this.materialEditorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.materialEditorToolStripMenuItem.Text = "Material Editor";
            this.materialEditorToolStripMenuItem.Click += new System.EventHandler(this.materialEditorToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveXMLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveXMLToolStripMenuItem
            // 
            this.saveXMLToolStripMenuItem.Name = "saveXMLToolStripMenuItem";
            this.saveXMLToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveXMLToolStripMenuItem.Text = "Save XML...";
            this.saveXMLToolStripMenuItem.Click += new System.EventHandler(this.saveXMLToolStripMenuItem_Click);
            // 
            // GearEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 545);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(439, 349);
            this.Name = "GearEditorForm";
            this.Text = "Gear Editor Form";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblYourGears;
        private System.Windows.Forms.ListBox listGear;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeViewGear;
        private System.Windows.Forms.PropertyGrid propertyGridGear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gearBoxEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shaftEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialEditorToolStripMenuItem;

        public void menuStripVisible(bool b)
        {
            this.menuStrip1.Visible = b;
        }
        public void hideSelect()
        {
            this.btnSelect.Hide();
        }

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveXMLToolStripMenuItem;
    }
}