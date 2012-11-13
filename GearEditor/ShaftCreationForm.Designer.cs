namespace GearEditor
{
    partial class ShaftCreationForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblKeyCutWidth = new System.Windows.Forms.Label();
            this.lblKeycutHeight = new System.Windows.Forms.Label();
            this.lblKeyCutLength = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numDiameter = new System.Windows.Forms.NumericUpDown();
            this.numKeyCutWidth = new System.Windows.Forms.NumericUpDown();
            this.numKeyCutHeight = new System.Windows.Forms.NumericUpDown();
            this.numKeyCutLength = new System.Windows.Forms.NumericUpDown();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyCutWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyCutHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyCutLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(129, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(12, 32);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(42, 13);
            this.lblDiameter.TabIndex = 4;
            this.lblDiameter.Text = "Density";
            this.lblDiameter.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKeyCutWidth
            // 
            this.lblKeyCutWidth.AutoSize = true;
            this.lblKeyCutWidth.Location = new System.Drawing.Point(12, 59);
            this.lblKeyCutWidth.Name = "lblKeyCutWidth";
            this.lblKeyCutWidth.Size = new System.Drawing.Size(75, 13);
            this.lblKeyCutWidth.TabIndex = 5;
            this.lblKeyCutWidth.Text = "Key Cut Width";
            // 
            // lblKeycutHeight
            // 
            this.lblKeycutHeight.AutoSize = true;
            this.lblKeycutHeight.Location = new System.Drawing.Point(12, 85);
            this.lblKeycutHeight.Name = "lblKeycutHeight";
            this.lblKeycutHeight.Size = new System.Drawing.Size(78, 13);
            this.lblKeycutHeight.TabIndex = 6;
            this.lblKeycutHeight.Text = "Key Cut Height";
            // 
            // lblKeyCutLength
            // 
            this.lblKeyCutLength.AutoSize = true;
            this.lblKeyCutLength.Location = new System.Drawing.Point(12, 113);
            this.lblKeyCutLength.Name = "lblKeyCutLength";
            this.lblKeyCutLength.Size = new System.Drawing.Size(80, 13);
            this.lblKeyCutLength.TabIndex = 7;
            this.lblKeyCutLength.Text = "Key Cut Length";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(12, 138);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 8;
            this.lblMaterial.Text = "Material";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(83, 20);
            this.txtName.TabIndex = 9;
            // 
            // numDiameter
            // 
            this.numDiameter.Location = new System.Drawing.Point(122, 30);
            this.numDiameter.Name = "numDiameter";
            this.numDiameter.Size = new System.Drawing.Size(82, 20);
            this.numDiameter.TabIndex = 10;
            // 
            // numKeyCutWidth
            // 
            this.numKeyCutWidth.Location = new System.Drawing.Point(122, 57);
            this.numKeyCutWidth.Name = "numKeyCutWidth";
            this.numKeyCutWidth.Size = new System.Drawing.Size(82, 20);
            this.numKeyCutWidth.TabIndex = 11;
            // 
            // numKeyCutHeight
            // 
            this.numKeyCutHeight.Location = new System.Drawing.Point(122, 83);
            this.numKeyCutHeight.Name = "numKeyCutHeight";
            this.numKeyCutHeight.Size = new System.Drawing.Size(82, 20);
            this.numKeyCutHeight.TabIndex = 12;
            // 
            // numKeyCutLength
            // 
            this.numKeyCutLength.Location = new System.Drawing.Point(122, 111);
            this.numKeyCutLength.Name = "numKeyCutLength";
            this.numKeyCutLength.Size = new System.Drawing.Size(82, 20);
            this.numKeyCutLength.TabIndex = 13;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(122, 133);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(82, 23);
            this.btnMaterial.TabIndex = 14;
            this.btnMaterial.Text = "Choose...";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(122, 135);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.ReadOnly = true;
            this.txtMaterial.Size = new System.Drawing.Size(67, 20);
            this.txtMaterial.TabIndex = 29;
            this.txtMaterial.Visible = false;
            // 
            // ShaftCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 311);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.numKeyCutLength);
            this.Controls.Add(this.numKeyCutHeight);
            this.Controls.Add(this.numKeyCutWidth);
            this.Controls.Add(this.numDiameter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblKeyCutLength);
            this.Controls.Add(this.lblKeycutHeight);
            this.Controls.Add(this.lblKeyCutWidth);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShaftCreationForm";
            this.Text = "Shaft Creation";
            this.Load += new System.EventHandler(this.ShaftCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyCutWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyCutHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyCutLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblKeyCutWidth;
        private System.Windows.Forms.Label lblKeycutHeight;
        private System.Windows.Forms.Label lblKeyCutLength;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numDiameter;
        private System.Windows.Forms.NumericUpDown numKeyCutWidth;
        private System.Windows.Forms.NumericUpDown numKeyCutHeight;
        private System.Windows.Forms.NumericUpDown numKeyCutLength;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.TextBox txtMaterial;
    }
}