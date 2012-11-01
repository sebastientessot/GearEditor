namespace Gear_Editor
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
            this.listGearBox = new System.Windows.Forms.ListBox();
            this.lblListGearBox = new System.Windows.Forms.Label();
            this.btnAddGearBox = new System.Windows.Forms.Button();
            this.btnRemoveGearBox = new System.Windows.Forms.Button();
            this.btnEditGearBox = new System.Windows.Forms.Button();
            this.menuStripForGearBoxCreation = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAGearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAShaftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGearBoxCaracteristics = new System.Windows.Forms.Label();
            this.menuStripForGearBoxCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // listGearBox
            // 
            this.listGearBox.FormattingEnabled = true;
            this.listGearBox.Location = new System.Drawing.Point(29, 58);
            this.listGearBox.Name = "listGearBox";
            this.listGearBox.Size = new System.Drawing.Size(150, 199);
            this.listGearBox.TabIndex = 0;
            // 
            // lblListGearBox
            // 
            this.lblListGearBox.AutoSize = true;
            this.lblListGearBox.Location = new System.Drawing.Point(26, 42);
            this.lblListGearBox.Name = "lblListGearBox";
            this.lblListGearBox.Size = new System.Drawing.Size(82, 13);
            this.lblListGearBox.TabIndex = 1;
            this.lblListGearBox.Text = "Your gears are :";
            // 
            // btnAddGearBox
            // 
            this.btnAddGearBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGearBox.Location = new System.Drawing.Point(29, 264);
            this.btnAddGearBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnAddGearBox.Name = "btnAddGearBox";
            this.btnAddGearBox.Size = new System.Drawing.Size(28, 28);
            this.btnAddGearBox.TabIndex = 2;
            this.btnAddGearBox.Text = "+";
            this.btnAddGearBox.UseVisualStyleBackColor = true;
            this.btnAddGearBox.Click += new System.EventHandler(this.btnAddGearBox_Click);
            // 
            // btnRemoveGearBox
            // 
            this.btnRemoveGearBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGearBox.Location = new System.Drawing.Point(63, 264);
            this.btnRemoveGearBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnRemoveGearBox.Name = "btnRemoveGearBox";
            this.btnRemoveGearBox.Size = new System.Drawing.Size(28, 28);
            this.btnRemoveGearBox.TabIndex = 3;
            this.btnRemoveGearBox.Text = "-";
            this.btnRemoveGearBox.UseVisualStyleBackColor = true;
            // 
            // btnEditGearBox
            // 
            this.btnEditGearBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGearBox.Location = new System.Drawing.Point(97, 264);
            this.btnEditGearBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnEditGearBox.Name = "btnEditGearBox";
            this.btnEditGearBox.Size = new System.Drawing.Size(28, 28);
            this.btnEditGearBox.TabIndex = 4;
            this.btnEditGearBox.Text = "✎";
            this.btnEditGearBox.UseVisualStyleBackColor = true;
            // 
            // menuStripForGearBoxCreation
            // 
            this.menuStripForGearBoxCreation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.createToolStripMenuItem});
            this.menuStripForGearBoxCreation.Location = new System.Drawing.Point(0, 0);
            this.menuStripForGearBoxCreation.Name = "menuStripForGearBoxCreation";
            this.menuStripForGearBoxCreation.Size = new System.Drawing.Size(458, 24);
            this.menuStripForGearBoxCreation.TabIndex = 5;
            this.menuStripForGearBoxCreation.Text = "menuStrip1";
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
            this.createAGearToolStripMenuItem.Click += new System.EventHandler(this.createAGearToolStripMenuItem_Click);
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
            // lblGearBoxCaracteristics
            // 
            this.lblGearBoxCaracteristics.AutoSize = true;
            this.lblGearBoxCaracteristics.Location = new System.Drawing.Point(217, 58);
            this.lblGearBoxCaracteristics.Name = "lblGearBoxCaracteristics";
            this.lblGearBoxCaracteristics.Size = new System.Drawing.Size(174, 13);
            this.lblGearBoxCaracteristics.TabIndex = 6;
            this.lblGearBoxCaracteristics.Text = "Some text giving the characteristics";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 336);
            this.Controls.Add(this.lblGearBoxCaracteristics);
            this.Controls.Add(this.btnEditGearBox);
            this.Controls.Add(this.btnRemoveGearBox);
            this.Controls.Add(this.btnAddGearBox);
            this.Controls.Add(this.lblListGearBox);
            this.Controls.Add(this.listGearBox);
            this.Controls.Add(this.menuStripForGearBoxCreation);
            this.MainMenuStrip = this.menuStripForGearBoxCreation;
            this.Name = "MainForm";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripForGearBoxCreation.ResumeLayout(false);
            this.menuStripForGearBoxCreation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listGearBox;
        private System.Windows.Forms.Label lblListGearBox;
        private System.Windows.Forms.Button btnAddGearBox;
        private System.Windows.Forms.Button btnRemoveGearBox;
        private System.Windows.Forms.Button btnEditGearBox;
        private System.Windows.Forms.MenuStrip menuStripForGearBoxCreation;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAGearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAShaftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAMaterialToolStripMenuItem;
        private System.Windows.Forms.Label lblGearBoxCaracteristics;
    }
}

