namespace GearEditor
{
    partial class GearBoxCreationForm
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
            this.btnInputGear = new System.Windows.Forms.Button();
            this.btnOutputGear = new System.Windows.Forms.Button();
            this.numTorqueRatio = new System.Windows.Forms.NumericUpDown();
            this.numInputTorque = new System.Windows.Forms.NumericUpDown();
            this.numAxisDistance = new System.Windows.Forms.NumericUpDown();
            this.numAlpha = new System.Windows.Forms.NumericUpDown();
            this.lblTorqueRatio = new System.Windows.Forms.Label();
            this.lblInputGear = new System.Windows.Forms.Label();
            this.lblInputTorque = new System.Windows.Forms.Label();
            this.lblOutputGear = new System.Windows.Forms.Label();
            this.lblAxesDistance = new System.Windows.Forms.Label();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.numGearModule = new System.Windows.Forms.NumericUpDown();
            this.lblGearModule = new System.Windows.Forms.Label();
            this.numOutputTorque = new System.Windows.Forms.NumericUpDown();
            this.lblOutputTorque = new System.Windows.Forms.Label();
            this.txtInputGear = new System.Windows.Forms.TextBox();
            this.txtOutputGear = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTorqueRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputTorque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAxisDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGearModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutputTorque)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(129, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInputGear
            // 
            this.btnInputGear.Location = new System.Drawing.Point(121, 190);
            this.btnInputGear.Name = "btnInputGear";
            this.btnInputGear.Size = new System.Drawing.Size(83, 23);
            this.btnInputGear.TabIndex = 26;
            this.btnInputGear.Text = "Choose...";
            this.btnInputGear.UseVisualStyleBackColor = true;
            this.btnInputGear.Click += new System.EventHandler(this.btnInputGear_Click);
            // 
            // btnOutputGear
            // 
            this.btnOutputGear.Location = new System.Drawing.Point(121, 219);
            this.btnOutputGear.Name = "btnOutputGear";
            this.btnOutputGear.Size = new System.Drawing.Size(83, 23);
            this.btnOutputGear.TabIndex = 25;
            this.btnOutputGear.Text = "Choose...";
            this.btnOutputGear.UseVisualStyleBackColor = true;
            this.btnOutputGear.Click += new System.EventHandler(this.btnOutputGear_Click);
            // 
            // numTorqueRatio
            // 
            this.numTorqueRatio.Location = new System.Drawing.Point(121, 162);
            this.numTorqueRatio.Name = "numTorqueRatio";
            this.numTorqueRatio.Size = new System.Drawing.Size(83, 20);
            this.numTorqueRatio.TabIndex = 24;
            // 
            // numInputTorque
            // 
            this.numInputTorque.Location = new System.Drawing.Point(121, 107);
            this.numInputTorque.Name = "numInputTorque";
            this.numInputTorque.Size = new System.Drawing.Size(83, 20);
            this.numInputTorque.TabIndex = 23;
            // 
            // numAxisDistance
            // 
            this.numAxisDistance.Location = new System.Drawing.Point(121, 56);
            this.numAxisDistance.Name = "numAxisDistance";
            this.numAxisDistance.Size = new System.Drawing.Size(83, 20);
            this.numAxisDistance.TabIndex = 22;
            // 
            // numAlpha
            // 
            this.numAlpha.Location = new System.Drawing.Point(121, 30);
            this.numAlpha.Name = "numAlpha";
            this.numAlpha.Size = new System.Drawing.Size(83, 20);
            this.numAlpha.TabIndex = 21;
            // 
            // lblTorqueRatio
            // 
            this.lblTorqueRatio.AutoSize = true;
            this.lblTorqueRatio.Location = new System.Drawing.Point(9, 164);
            this.lblTorqueRatio.Name = "lblTorqueRatio";
            this.lblTorqueRatio.Size = new System.Drawing.Size(69, 13);
            this.lblTorqueRatio.TabIndex = 20;
            this.lblTorqueRatio.Text = "Torque Ratio";
            // 
            // lblInputGear
            // 
            this.lblInputGear.AutoSize = true;
            this.lblInputGear.Location = new System.Drawing.Point(9, 195);
            this.lblInputGear.Name = "lblInputGear";
            this.lblInputGear.Size = new System.Drawing.Size(57, 13);
            this.lblInputGear.TabIndex = 19;
            this.lblInputGear.Text = "Input Gear";
            // 
            // lblInputTorque
            // 
            this.lblInputTorque.AutoSize = true;
            this.lblInputTorque.Location = new System.Drawing.Point(9, 109);
            this.lblInputTorque.Name = "lblInputTorque";
            this.lblInputTorque.Size = new System.Drawing.Size(68, 13);
            this.lblInputTorque.TabIndex = 18;
            this.lblInputTorque.Text = "Input Torque";
            // 
            // lblOutputGear
            // 
            this.lblOutputGear.AutoSize = true;
            this.lblOutputGear.Location = new System.Drawing.Point(9, 224);
            this.lblOutputGear.Name = "lblOutputGear";
            this.lblOutputGear.Size = new System.Drawing.Size(62, 13);
            this.lblOutputGear.TabIndex = 17;
            this.lblOutputGear.Text = "OutputGear";
            // 
            // lblAxesDistance
            // 
            this.lblAxesDistance.AutoSize = true;
            this.lblAxesDistance.Location = new System.Drawing.Point(9, 58);
            this.lblAxesDistance.Name = "lblAxesDistance";
            this.lblAxesDistance.Size = new System.Drawing.Size(75, 13);
            this.lblAxesDistance.TabIndex = 16;
            this.lblAxesDistance.Text = "Axes Distance";
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(9, 32);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(34, 13);
            this.lblAlpha.TabIndex = 15;
            this.lblAlpha.Text = "Alpha";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(83, 20);
            this.txtName.TabIndex = 28;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Name";
            // 
            // numGearModule
            // 
            this.numGearModule.Location = new System.Drawing.Point(121, 81);
            this.numGearModule.Name = "numGearModule";
            this.numGearModule.Size = new System.Drawing.Size(83, 20);
            this.numGearModule.TabIndex = 30;
            // 
            // lblGearModule
            // 
            this.lblGearModule.AutoSize = true;
            this.lblGearModule.Location = new System.Drawing.Point(9, 83);
            this.lblGearModule.Name = "lblGearModule";
            this.lblGearModule.Size = new System.Drawing.Size(68, 13);
            this.lblGearModule.TabIndex = 29;
            this.lblGearModule.Text = "Gear Module";
            // 
            // numOutputTorque
            // 
            this.numOutputTorque.Location = new System.Drawing.Point(121, 135);
            this.numOutputTorque.Name = "numOutputTorque";
            this.numOutputTorque.Size = new System.Drawing.Size(83, 20);
            this.numOutputTorque.TabIndex = 32;
            // 
            // lblOutputTorque
            // 
            this.lblOutputTorque.AutoSize = true;
            this.lblOutputTorque.Location = new System.Drawing.Point(9, 137);
            this.lblOutputTorque.Name = "lblOutputTorque";
            this.lblOutputTorque.Size = new System.Drawing.Size(76, 13);
            this.lblOutputTorque.TabIndex = 31;
            this.lblOutputTorque.Text = "Output Torque";
            // 
            // txtInputGear
            // 
            this.txtInputGear.Location = new System.Drawing.Point(121, 192);
            this.txtInputGear.Name = "txtInputGear";
            this.txtInputGear.ReadOnly = true;
            this.txtInputGear.Size = new System.Drawing.Size(67, 20);
            this.txtInputGear.TabIndex = 33;
            this.txtInputGear.Visible = false;
            // 
            // txtOutputGear
            // 
            this.txtOutputGear.Location = new System.Drawing.Point(121, 221);
            this.txtOutputGear.Name = "txtOutputGear";
            this.txtOutputGear.ReadOnly = true;
            this.txtOutputGear.Size = new System.Drawing.Size(67, 20);
            this.txtOutputGear.TabIndex = 34;
            this.txtOutputGear.Visible = false;
            // 
            // GearBoxCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 311);
            this.Controls.Add(this.txtOutputGear);
            this.Controls.Add(this.txtInputGear);
            this.Controls.Add(this.numOutputTorque);
            this.Controls.Add(this.lblOutputTorque);
            this.Controls.Add(this.numGearModule);
            this.Controls.Add(this.lblGearModule);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnInputGear);
            this.Controls.Add(this.btnOutputGear);
            this.Controls.Add(this.numTorqueRatio);
            this.Controls.Add(this.numInputTorque);
            this.Controls.Add(this.numAxisDistance);
            this.Controls.Add(this.numAlpha);
            this.Controls.Add(this.lblTorqueRatio);
            this.Controls.Add(this.lblInputGear);
            this.Controls.Add(this.lblInputTorque);
            this.Controls.Add(this.lblOutputGear);
            this.Controls.Add(this.lblAxesDistance);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GearBoxCreationForm";
            this.Text = "Gear Box Creation";
            ((System.ComponentModel.ISupportInitialize)(this.numTorqueRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputTorque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAxisDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGearModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutputTorque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInputGear;
        private System.Windows.Forms.Button btnOutputGear;
        private System.Windows.Forms.NumericUpDown numTorqueRatio;
        private System.Windows.Forms.NumericUpDown numInputTorque;
        private System.Windows.Forms.NumericUpDown numAxisDistance;
        private System.Windows.Forms.NumericUpDown numAlpha;
        private System.Windows.Forms.Label lblTorqueRatio;
        private System.Windows.Forms.Label lblInputGear;
        private System.Windows.Forms.Label lblInputTorque;
        private System.Windows.Forms.Label lblOutputGear;
        private System.Windows.Forms.Label lblAxesDistance;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numGearModule;
        private System.Windows.Forms.Label lblGearModule;
        private System.Windows.Forms.NumericUpDown numOutputTorque;
        private System.Windows.Forms.Label lblOutputTorque;
        private System.Windows.Forms.TextBox txtInputGear;
        private System.Windows.Forms.TextBox txtOutputGear;
    }
}