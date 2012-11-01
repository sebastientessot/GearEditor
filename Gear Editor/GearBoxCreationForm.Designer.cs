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
            this.lblGearBoxCreationName = new System.Windows.Forms.Label();
            this.lblGearBoxCreationAlpha = new System.Windows.Forms.Label();
            this.lblGearBoxCreationAxesDistance = new System.Windows.Forms.Label();
            this.lblGearBoxCreationGearModule = new System.Windows.Forms.Label();
            this.lblGearBoxCreationInputTorque = new System.Windows.Forms.Label();
            this.lblGearBoxCreationOutputTorque = new System.Windows.Forms.Label();
            this.lblGearBoxCreationTorqueRatio = new System.Windows.Forms.Label();
            this.lblGearBoxCreationInputGear = new System.Windows.Forms.Label();
            this.lblGearBoxCreationOutputGear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGearBoxCreationName
            // 
            this.lblGearBoxCreationName.AutoSize = true;
            this.lblGearBoxCreationName.Location = new System.Drawing.Point(27, 14);
            this.lblGearBoxCreationName.Name = "lblGearBoxCreationName";
            this.lblGearBoxCreationName.Size = new System.Drawing.Size(35, 13);
            this.lblGearBoxCreationName.TabIndex = 1;
            this.lblGearBoxCreationName.Text = "Name";
            // 
            // lblGearBoxCreationAlpha
            // 
            this.lblGearBoxCreationAlpha.AutoSize = true;
            this.lblGearBoxCreationAlpha.Location = new System.Drawing.Point(27, 27);
            this.lblGearBoxCreationAlpha.Name = "lblGearBoxCreationAlpha";
            this.lblGearBoxCreationAlpha.Size = new System.Drawing.Size(34, 13);
            this.lblGearBoxCreationAlpha.TabIndex = 2;
            this.lblGearBoxCreationAlpha.Text = "Alpha";
            this.lblGearBoxCreationAlpha.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGearBoxCreationAxesDistance
            // 
            this.lblGearBoxCreationAxesDistance.AutoSize = true;
            this.lblGearBoxCreationAxesDistance.Location = new System.Drawing.Point(27, 40);
            this.lblGearBoxCreationAxesDistance.Name = "lblGearBoxCreationAxesDistance";
            this.lblGearBoxCreationAxesDistance.Size = new System.Drawing.Size(75, 13);
            this.lblGearBoxCreationAxesDistance.TabIndex = 3;
            this.lblGearBoxCreationAxesDistance.Text = "Axes Distance";
            this.lblGearBoxCreationAxesDistance.Click += new System.EventHandler(this.lblGearBoxCreationAxesDistance_Click);
            // 
            // lblGearBoxCreationGearModule
            // 
            this.lblGearBoxCreationGearModule.AutoSize = true;
            this.lblGearBoxCreationGearModule.Location = new System.Drawing.Point(27, 53);
            this.lblGearBoxCreationGearModule.Name = "lblGearBoxCreationGearModule";
            this.lblGearBoxCreationGearModule.Size = new System.Drawing.Size(68, 13);
            this.lblGearBoxCreationGearModule.TabIndex = 4;
            this.lblGearBoxCreationGearModule.Text = "Gear Module";
            // 
            // lblGearBoxCreationInputTorque
            // 
            this.lblGearBoxCreationInputTorque.AutoSize = true;
            this.lblGearBoxCreationInputTorque.Location = new System.Drawing.Point(27, 66);
            this.lblGearBoxCreationInputTorque.Name = "lblGearBoxCreationInputTorque";
            this.lblGearBoxCreationInputTorque.Size = new System.Drawing.Size(68, 13);
            this.lblGearBoxCreationInputTorque.TabIndex = 5;
            this.lblGearBoxCreationInputTorque.Text = "Input Torque";
            // 
            // lblGearBoxCreationOutputTorque
            // 
            this.lblGearBoxCreationOutputTorque.AutoSize = true;
            this.lblGearBoxCreationOutputTorque.Location = new System.Drawing.Point(27, 79);
            this.lblGearBoxCreationOutputTorque.Name = "lblGearBoxCreationOutputTorque";
            this.lblGearBoxCreationOutputTorque.Size = new System.Drawing.Size(76, 13);
            this.lblGearBoxCreationOutputTorque.TabIndex = 6;
            this.lblGearBoxCreationOutputTorque.Text = "Output Torque";
            // 
            // lblGearBoxCreationTorqueRatio
            // 
            this.lblGearBoxCreationTorqueRatio.AutoSize = true;
            this.lblGearBoxCreationTorqueRatio.Location = new System.Drawing.Point(26, 92);
            this.lblGearBoxCreationTorqueRatio.Name = "lblGearBoxCreationTorqueRatio";
            this.lblGearBoxCreationTorqueRatio.Size = new System.Drawing.Size(69, 13);
            this.lblGearBoxCreationTorqueRatio.TabIndex = 7;
            this.lblGearBoxCreationTorqueRatio.Text = "Torque Ratio";
            // 
            // lblGearBoxCreationInputGear
            // 
            this.lblGearBoxCreationInputGear.AutoSize = true;
            this.lblGearBoxCreationInputGear.Location = new System.Drawing.Point(26, 105);
            this.lblGearBoxCreationInputGear.Name = "lblGearBoxCreationInputGear";
            this.lblGearBoxCreationInputGear.Size = new System.Drawing.Size(57, 13);
            this.lblGearBoxCreationInputGear.TabIndex = 8;
            this.lblGearBoxCreationInputGear.Text = "Input Gear";
            // 
            // lblGearBoxCreationOutputGear
            // 
            this.lblGearBoxCreationOutputGear.AutoSize = true;
            this.lblGearBoxCreationOutputGear.Location = new System.Drawing.Point(26, 118);
            this.lblGearBoxCreationOutputGear.Name = "lblGearBoxCreationOutputGear";
            this.lblGearBoxCreationOutputGear.Size = new System.Drawing.Size(65, 13);
            this.lblGearBoxCreationOutputGear.TabIndex = 9;
            this.lblGearBoxCreationOutputGear.Text = "Output Gear";
            // 
            // GearBoxCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblGearBoxCreationOutputGear);
            this.Controls.Add(this.lblGearBoxCreationInputGear);
            this.Controls.Add(this.lblGearBoxCreationTorqueRatio);
            this.Controls.Add(this.lblGearBoxCreationOutputTorque);
            this.Controls.Add(this.lblGearBoxCreationInputTorque);
            this.Controls.Add(this.lblGearBoxCreationGearModule);
            this.Controls.Add(this.lblGearBoxCreationAxesDistance);
            this.Controls.Add(this.lblGearBoxCreationAlpha);
            this.Controls.Add(this.lblGearBoxCreationName);
            this.Name = "GearBoxCreationForm";
            this.ShowInTaskbar = false;
            this.Text = "Create a Gear Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGearBoxCreationName;
        private System.Windows.Forms.Label lblGearBoxCreationAlpha;
        private System.Windows.Forms.Label lblGearBoxCreationAxesDistance;
        private System.Windows.Forms.Label lblGearBoxCreationGearModule;
        private System.Windows.Forms.Label lblGearBoxCreationInputTorque;
        private System.Windows.Forms.Label lblGearBoxCreationOutputTorque;
        private System.Windows.Forms.Label lblGearBoxCreationTorqueRatio;
        private System.Windows.Forms.Label lblGearBoxCreationInputGear;
        private System.Windows.Forms.Label lblGearBoxCreationOutputGear;
    }
}