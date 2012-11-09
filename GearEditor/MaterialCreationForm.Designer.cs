namespace GearEditor
{
    partial class MaterialCreationForm
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
            this.lblDensity = new System.Windows.Forms.Label();
            this.lblYieldStress = new System.Windows.Forms.Label();
            this.lblYoungsModulus = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numDensity = new System.Windows.Forms.NumericUpDown();
            this.numYieldStress = new System.Windows.Forms.NumericUpDown();
            this.numYoungModulus = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYieldStress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYoungModulus)).BeginInit();
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
            this.btnCancel.Location = new System.Drawing.Point(97, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblDensity
            // 
            this.lblDensity.AutoSize = true;
            this.lblDensity.Location = new System.Drawing.Point(9, 48);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(42, 13);
            this.lblDensity.TabIndex = 4;
            this.lblDensity.Text = "Density";
            // 
            // lblYieldStress
            // 
            this.lblYieldStress.AutoSize = true;
            this.lblYieldStress.Location = new System.Drawing.Point(9, 77);
            this.lblYieldStress.Name = "lblYieldStress";
            this.lblYieldStress.Size = new System.Drawing.Size(62, 13);
            this.lblYieldStress.TabIndex = 5;
            this.lblYieldStress.Text = "Yield Stress";
            // 
            // lblYoungsModulus
            // 
            this.lblYoungsModulus.AutoSize = true;
            this.lblYoungsModulus.Location = new System.Drawing.Point(9, 107);
            this.lblYoungsModulus.Name = "lblYoungsModulus";
            this.lblYoungsModulus.Size = new System.Drawing.Size(86, 13);
            this.lblYoungsModulus.TabIndex = 6;
            this.lblYoungsModulus.Text = "Youngs Modulus";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(71, 20);
            this.txtName.TabIndex = 7;
            // 
            // numDensity
            // 
            this.numDensity.Location = new System.Drawing.Point(101, 46);
            this.numDensity.Name = "numDensity";
            this.numDensity.Size = new System.Drawing.Size(71, 20);
            this.numDensity.TabIndex = 8;
            // 
            // numYieldStress
            // 
            this.numYieldStress.Location = new System.Drawing.Point(101, 75);
            this.numYieldStress.Name = "numYieldStress";
            this.numYieldStress.Size = new System.Drawing.Size(71, 20);
            this.numYieldStress.TabIndex = 9;
            // 
            // numYoungModulus
            // 
            this.numYoungModulus.Location = new System.Drawing.Point(101, 105);
            this.numYoungModulus.Name = "numYoungModulus";
            this.numYoungModulus.Size = new System.Drawing.Size(71, 20);
            this.numYoungModulus.TabIndex = 10;
            // 
            // MaterialCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 311);
            this.Controls.Add(this.numYoungModulus);
            this.Controls.Add(this.numYieldStress);
            this.Controls.Add(this.numDensity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblYoungsModulus);
            this.Controls.Add(this.lblYieldStress);
            this.Controls.Add(this.lblDensity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MaterialCreationForm";
            this.Text = "Material Creation";
            ((System.ComponentModel.ISupportInitialize)(this.numDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYieldStress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYoungModulus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.Label lblYieldStress;
        private System.Windows.Forms.Label lblYoungsModulus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numDensity;
        private System.Windows.Forms.NumericUpDown numYieldStress;
        private System.Windows.Forms.NumericUpDown numYoungModulus;
    }
}