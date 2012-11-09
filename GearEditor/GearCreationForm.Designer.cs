namespace GearEditor
{
    partial class GearCreationForm
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
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblGearModule = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblTorque = new System.Windows.Forms.Label();
            this.lblShaft = new System.Windows.Forms.Label();
            this.lblWantedRadius = new System.Windows.Forms.Label();
            this.numAlpha = new System.Windows.Forms.NumericUpDown();
            this.numGearModule = new System.Windows.Forms.NumericUpDown();
            this.numTorque = new System.Windows.Forms.NumericUpDown();
            this.numWantedRadius = new System.Windows.Forms.NumericUpDown();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnShaft = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGearModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTorque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWantedRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(12, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
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
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(9, 30);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(34, 13);
            this.lblAlpha.TabIndex = 3;
            this.lblAlpha.Text = "Alpha";
            // 
            // lblGearModule
            // 
            this.lblGearModule.AutoSize = true;
            this.lblGearModule.Location = new System.Drawing.Point(9, 54);
            this.lblGearModule.Name = "lblGearModule";
            this.lblGearModule.Size = new System.Drawing.Size(68, 13);
            this.lblGearModule.TabIndex = 4;
            this.lblGearModule.Text = "Gear Module";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(9, 164);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 5;
            this.lblMaterial.Text = "Material";
            // 
            // lblTorque
            // 
            this.lblTorque.AutoSize = true;
            this.lblTorque.Location = new System.Drawing.Point(9, 80);
            this.lblTorque.Name = "lblTorque";
            this.lblTorque.Size = new System.Drawing.Size(41, 13);
            this.lblTorque.TabIndex = 6;
            this.lblTorque.Text = "Torque";
            // 
            // lblShaft
            // 
            this.lblShaft.AutoSize = true;
            this.lblShaft.Location = new System.Drawing.Point(9, 135);
            this.lblShaft.Name = "lblShaft";
            this.lblShaft.Size = new System.Drawing.Size(32, 13);
            this.lblShaft.TabIndex = 7;
            this.lblShaft.Text = "Shaft";
            // 
            // lblWantedRadius
            // 
            this.lblWantedRadius.AutoSize = true;
            this.lblWantedRadius.Location = new System.Drawing.Point(9, 106);
            this.lblWantedRadius.Name = "lblWantedRadius";
            this.lblWantedRadius.Size = new System.Drawing.Size(81, 13);
            this.lblWantedRadius.TabIndex = 8;
            this.lblWantedRadius.Text = "Wanted Radius";
            // 
            // numAlpha
            // 
            this.numAlpha.Location = new System.Drawing.Point(121, 28);
            this.numAlpha.Name = "numAlpha";
            this.numAlpha.Size = new System.Drawing.Size(83, 20);
            this.numAlpha.TabIndex = 9;
            // 
            // numGearModule
            // 
            this.numGearModule.Location = new System.Drawing.Point(121, 52);
            this.numGearModule.Name = "numGearModule";
            this.numGearModule.Size = new System.Drawing.Size(83, 20);
            this.numGearModule.TabIndex = 10;
            // 
            // numTorque
            // 
            this.numTorque.Location = new System.Drawing.Point(121, 78);
            this.numTorque.Name = "numTorque";
            this.numTorque.Size = new System.Drawing.Size(83, 20);
            this.numTorque.TabIndex = 11;
            // 
            // numWantedRadius
            // 
            this.numWantedRadius.Location = new System.Drawing.Point(121, 104);
            this.numWantedRadius.Name = "numWantedRadius";
            this.numWantedRadius.Size = new System.Drawing.Size(83, 20);
            this.numWantedRadius.TabIndex = 12;
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(121, 159);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(83, 23);
            this.btnMaterial.TabIndex = 13;
            this.btnMaterial.Text = "Choose...";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnShaft
            // 
            this.btnShaft.Location = new System.Drawing.Point(121, 130);
            this.btnShaft.Name = "btnShaft";
            this.btnShaft.Size = new System.Drawing.Size(83, 23);
            this.btnShaft.TabIndex = 14;
            this.btnShaft.Text = "Choose...";
            this.btnShaft.UseVisualStyleBackColor = true;
            this.btnShaft.Click += new System.EventHandler(this.btnShaft_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(83, 20);
            this.txtName.TabIndex = 16;
            // 
            // GearCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 311);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnShaft);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.numWantedRadius);
            this.Controls.Add(this.numTorque);
            this.Controls.Add(this.numGearModule);
            this.Controls.Add(this.numAlpha);
            this.Controls.Add(this.lblWantedRadius);
            this.Controls.Add(this.lblShaft);
            this.Controls.Add(this.lblTorque);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblGearModule);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GearCreationForm";
            this.Text = "Gear Creation";
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGearModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTorque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWantedRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.Label lblGearModule;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblTorque;
        private System.Windows.Forms.Label lblShaft;
        private System.Windows.Forms.Label lblWantedRadius;
        private System.Windows.Forms.NumericUpDown numAlpha;
        private System.Windows.Forms.NumericUpDown numGearModule;
        private System.Windows.Forms.NumericUpDown numTorque;
        private System.Windows.Forms.NumericUpDown numWantedRadius;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnShaft;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}