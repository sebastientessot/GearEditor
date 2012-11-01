namespace Gear_Editor
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblAxesDistance = new System.Windows.Forms.Label();
            this.lblGearModule = new System.Windows.Forms.Label();
            this.lblInputTorque = new System.Windows.Forms.Label();
            this.lblOutputTorque = new System.Windows.Forms.Label();
            this.lblTorqueRatio = new System.Windows.Forms.Label();
            this.lblInputGear = new System.Windows.Forms.Label();
            this.lblOutputGear = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nbAlpha = new System.Windows.Forms.NumericUpDown();
            this.nbAxesDistance = new System.Windows.Forms.NumericUpDown();
            this.nbGearModule = new System.Windows.Forms.NumericUpDown();
            this.nbInputTorque = new System.Windows.Forms.NumericUpDown();
            this.nbOutputTorque = new System.Windows.Forms.NumericUpDown();
            this.nbTorqueRatio = new System.Windows.Forms.NumericUpDown();
            this.btnInputGear = new System.Windows.Forms.Button();
            this.btnOutputGear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbAxesDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGearModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbInputTorque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbOutputTorque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTorqueRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(28, 42);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(34, 13);
            this.lblAlpha.TabIndex = 2;
            this.lblAlpha.Text = "Alpha";
            this.lblAlpha.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAxesDistance
            // 
            this.lblAxesDistance.AutoSize = true;
            this.lblAxesDistance.Location = new System.Drawing.Point(27, 68);
            this.lblAxesDistance.Name = "lblAxesDistance";
            this.lblAxesDistance.Size = new System.Drawing.Size(75, 13);
            this.lblAxesDistance.TabIndex = 3;
            this.lblAxesDistance.Text = "Axes Distance";
            this.lblAxesDistance.Click += new System.EventHandler(this.lblGearBoxCreationAxesDistance_Click);
            // 
            // lblGearModule
            // 
            this.lblGearModule.AutoSize = true;
            this.lblGearModule.Location = new System.Drawing.Point(27, 94);
            this.lblGearModule.Name = "lblGearModule";
            this.lblGearModule.Size = new System.Drawing.Size(68, 13);
            this.lblGearModule.TabIndex = 4;
            this.lblGearModule.Text = "Gear Module";
            // 
            // lblInputTorque
            // 
            this.lblInputTorque.AutoSize = true;
            this.lblInputTorque.Location = new System.Drawing.Point(28, 120);
            this.lblInputTorque.Name = "lblInputTorque";
            this.lblInputTorque.Size = new System.Drawing.Size(68, 13);
            this.lblInputTorque.TabIndex = 5;
            this.lblInputTorque.Text = "Input Torque";
            // 
            // lblOutputTorque
            // 
            this.lblOutputTorque.AutoSize = true;
            this.lblOutputTorque.Location = new System.Drawing.Point(28, 146);
            this.lblOutputTorque.Name = "lblOutputTorque";
            this.lblOutputTorque.Size = new System.Drawing.Size(76, 13);
            this.lblOutputTorque.TabIndex = 6;
            this.lblOutputTorque.Text = "Output Torque";
            // 
            // lblTorqueRatio
            // 
            this.lblTorqueRatio.AutoSize = true;
            this.lblTorqueRatio.Location = new System.Drawing.Point(27, 173);
            this.lblTorqueRatio.Name = "lblTorqueRatio";
            this.lblTorqueRatio.Size = new System.Drawing.Size(69, 13);
            this.lblTorqueRatio.TabIndex = 7;
            this.lblTorqueRatio.Text = "Torque Ratio";
            // 
            // lblInputGear
            // 
            this.lblInputGear.AutoSize = true;
            this.lblInputGear.Location = new System.Drawing.Point(27, 202);
            this.lblInputGear.Name = "lblInputGear";
            this.lblInputGear.Size = new System.Drawing.Size(57, 13);
            this.lblInputGear.TabIndex = 8;
            this.lblInputGear.Text = "Input Gear";
            // 
            // lblOutputGear
            // 
            this.lblOutputGear.AutoSize = true;
            this.lblOutputGear.Location = new System.Drawing.Point(27, 231);
            this.lblOutputGear.Name = "lblOutputGear";
            this.lblOutputGear.Size = new System.Drawing.Size(65, 13);
            this.lblOutputGear.TabIndex = 9;
            this.lblOutputGear.Text = "Output Gear";
            this.lblOutputGear.Click += new System.EventHandler(this.lblGearBoxCreationOutputGear_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(90, 20);
            this.txtName.TabIndex = 10;
            // 
            // nbAlpha
            // 
            this.nbAlpha.Location = new System.Drawing.Point(148, 40);
            this.nbAlpha.Name = "nbAlpha";
            this.nbAlpha.Size = new System.Drawing.Size(90, 20);
            this.nbAlpha.TabIndex = 11;
            this.nbAlpha.ValueChanged += new System.EventHandler(this.nbGearBoxCreationAlpha_ValueChanged);
            // 
            // nbAxesDistance
            // 
            this.nbAxesDistance.Location = new System.Drawing.Point(148, 66);
            this.nbAxesDistance.Name = "nbAxesDistance";
            this.nbAxesDistance.Size = new System.Drawing.Size(90, 20);
            this.nbAxesDistance.TabIndex = 12;
            // 
            // nbGearModule
            // 
            this.nbGearModule.Location = new System.Drawing.Point(148, 92);
            this.nbGearModule.Name = "nbGearModule";
            this.nbGearModule.Size = new System.Drawing.Size(90, 20);
            this.nbGearModule.TabIndex = 13;
            this.nbGearModule.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // nbInputTorque
            // 
            this.nbInputTorque.Location = new System.Drawing.Point(148, 118);
            this.nbInputTorque.Name = "nbInputTorque";
            this.nbInputTorque.Size = new System.Drawing.Size(90, 20);
            this.nbInputTorque.TabIndex = 14;
            // 
            // nbOutputTorque
            // 
            this.nbOutputTorque.Location = new System.Drawing.Point(148, 144);
            this.nbOutputTorque.Name = "nbOutputTorque";
            this.nbOutputTorque.Size = new System.Drawing.Size(90, 20);
            this.nbOutputTorque.TabIndex = 15;
            // 
            // nbTorqueRatio
            // 
            this.nbTorqueRatio.Location = new System.Drawing.Point(148, 171);
            this.nbTorqueRatio.Name = "nbTorqueRatio";
            this.nbTorqueRatio.Size = new System.Drawing.Size(90, 20);
            this.nbTorqueRatio.TabIndex = 16;
            // 
            // btnInputGear
            // 
            this.btnInputGear.Location = new System.Drawing.Point(148, 197);
            this.btnInputGear.Name = "btnInputGear";
            this.btnInputGear.Size = new System.Drawing.Size(90, 23);
            this.btnInputGear.TabIndex = 17;
            this.btnInputGear.Text = "Choose...";
            this.btnInputGear.UseVisualStyleBackColor = true;
            this.btnInputGear.Click += new System.EventHandler(this.btnInputGear_Click);
            // 
            // btnOutputGear
            // 
            this.btnOutputGear.Location = new System.Drawing.Point(148, 226);
            this.btnOutputGear.Name = "btnOutputGear";
            this.btnOutputGear.Size = new System.Drawing.Size(90, 23);
            this.btnOutputGear.TabIndex = 18;
            this.btnOutputGear.Text = "Choose...";
            this.btnOutputGear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(31, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(163, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GearBoxCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 326);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOutputGear);
            this.Controls.Add(this.btnInputGear);
            this.Controls.Add(this.nbTorqueRatio);
            this.Controls.Add(this.nbOutputTorque);
            this.Controls.Add(this.nbInputTorque);
            this.Controls.Add(this.nbGearModule);
            this.Controls.Add(this.nbAxesDistance);
            this.Controls.Add(this.nbAlpha);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblOutputGear);
            this.Controls.Add(this.lblInputGear);
            this.Controls.Add(this.lblTorqueRatio);
            this.Controls.Add(this.lblOutputTorque);
            this.Controls.Add(this.lblInputTorque);
            this.Controls.Add(this.lblGearModule);
            this.Controls.Add(this.lblAxesDistance);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.lblName);
            this.Name = "GearBoxCreationForm";
            this.ShowInTaskbar = false;
            this.Text = "Create a Gear Box";
            ((System.ComponentModel.ISupportInitialize)(this.nbAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbAxesDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGearModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbInputTorque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbOutputTorque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbTorqueRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.Label lblAxesDistance;
        private System.Windows.Forms.Label lblGearModule;
        private System.Windows.Forms.Label lblInputTorque;
        private System.Windows.Forms.Label lblOutputTorque;
        private System.Windows.Forms.Label lblTorqueRatio;
        private System.Windows.Forms.Label lblInputGear;
        private System.Windows.Forms.Label lblOutputGear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nbAlpha;
        private System.Windows.Forms.NumericUpDown nbAxesDistance;
        private System.Windows.Forms.NumericUpDown nbGearModule;
        private System.Windows.Forms.NumericUpDown nbInputTorque;
        private System.Windows.Forms.NumericUpDown nbOutputTorque;
        private System.Windows.Forms.NumericUpDown nbTorqueRatio;
        private System.Windows.Forms.Button btnInputGear;
        private System.Windows.Forms.Button btnOutputGear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}