namespace Gear_Editor
{
    partial class GearForm
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
            this.lblGearCaracteristics = new System.Windows.Forms.Label();
            this.btnEditGear = new System.Windows.Forms.Button();
            this.btnRemoveGear = new System.Windows.Forms.Button();
            this.btnAddGear = new System.Windows.Forms.Button();
            this.lblListGear = new System.Windows.Forms.Label();
            this.listGear = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAGearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAShaftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGearCaracteristics
            // 
            this.lblGearCaracteristics.Location = new System.Drawing.Point(200, 57);
            this.lblGearCaracteristics.Name = "lblGearCaracteristics";
            this.lblGearCaracteristics.Size = new System.Drawing.Size(174, 199);
            this.lblGearCaracteristics.TabIndex = 12;
            this.lblGearCaracteristics.Text = "Once you select a GearBox, the characteristics will appear here...";
            // 
            // btnEditGear
            // 
            this.btnEditGear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGear.Location = new System.Drawing.Point(80, 266);
            this.btnEditGear.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnEditGear.Name = "btnEditGear";
            this.btnEditGear.Size = new System.Drawing.Size(28, 28);
            this.btnEditGear.TabIndex = 11;
            this.btnEditGear.Text = "✎";
            this.btnEditGear.UseVisualStyleBackColor = true;
            // 
            // btnRemoveGear
            // 
            this.btnRemoveGear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGear.Location = new System.Drawing.Point(46, 266);
            this.btnRemoveGear.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnRemoveGear.Name = "btnRemoveGear";
            this.btnRemoveGear.Size = new System.Drawing.Size(28, 28);
            this.btnRemoveGear.TabIndex = 10;
            this.btnRemoveGear.Text = "-";
            this.btnRemoveGear.UseVisualStyleBackColor = true;
            // 
            // btnAddGear
            // 
            this.btnAddGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGear.Location = new System.Drawing.Point(12, 266);
            this.btnAddGear.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnAddGear.Name = "btnAddGear";
            this.btnAddGear.Size = new System.Drawing.Size(28, 28);
            this.btnAddGear.TabIndex = 9;
            this.btnAddGear.Text = "+";
            this.btnAddGear.UseVisualStyleBackColor = true;
            // 
            // lblListGear
            // 
            this.lblListGear.AutoSize = true;
            this.lblListGear.Location = new System.Drawing.Point(9, 41);
            this.lblListGear.Name = "lblListGear";
            this.lblListGear.Size = new System.Drawing.Size(113, 13);
            this.lblListGear.TabIndex = 8;
            this.lblListGear.Text = "Your gears boxes are :";
            // 
            // listGear
            // 
            this.listGear.FormattingEnabled = true;
            this.listGear.Location = new System.Drawing.Point(12, 57);
            this.listGear.Name = "listGear";
            this.listGear.Size = new System.Drawing.Size(150, 199);
            this.listGear.TabIndex = 7;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.createToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(412, 24);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAGearToolStripMenuItem,
            this.createAShaftToolStripMenuItem,
            this.createAMaterialToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.createToolStripMenuItem.Text = "Create...";
            // 
            // createAGearToolStripMenuItem
            // 
            this.createAGearToolStripMenuItem.Name = "createAGearToolStripMenuItem";
            this.createAGearToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createAGearToolStripMenuItem.Text = "Create a Gear";
            // 
            // createAShaftToolStripMenuItem
            // 
            this.createAShaftToolStripMenuItem.Name = "createAShaftToolStripMenuItem";
            this.createAShaftToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createAShaftToolStripMenuItem.Text = "Create a Shaft";
            // 
            // createAMaterialToolStripMenuItem
            // 
            this.createAMaterialToolStripMenuItem.Name = "createAMaterialToolStripMenuItem";
            this.createAMaterialToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createAMaterialToolStripMenuItem.Text = "Create a Material";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(129, 266);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 28);
            this.btnSelect.TabIndex = 14;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // GearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 306);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblGearCaracteristics);
            this.Controls.Add(this.btnEditGear);
            this.Controls.Add(this.btnRemoveGear);
            this.Controls.Add(this.btnAddGear);
            this.Controls.Add(this.lblListGear);
            this.Controls.Add(this.listGear);
            this.Name = "GearForm";
            this.Text = "Gear Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGearCaracteristics;
        private System.Windows.Forms.Button btnEditGear;
        private System.Windows.Forms.Button btnRemoveGear;
        private System.Windows.Forms.Button btnAddGear;
        private System.Windows.Forms.Label lblListGear;
        private System.Windows.Forms.ListBox listGear;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAGearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAShaftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAMaterialToolStripMenuItem;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
    }
}