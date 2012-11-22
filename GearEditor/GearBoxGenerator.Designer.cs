namespace GearEditor
{
    partial class GearBoxGenerator
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
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtOutputMaterial = new System.Windows.Forms.TextBox();
            this.btnOutputMaterial = new System.Windows.Forms.Button();
            this.txtInputMaterial = new System.Windows.Forms.TextBox();
            this.btnInputMaterial = new System.Windows.Forms.Button();
            this.numTorqueRatio = new System.Windows.Forms.NumericUpDown();
            this.numGearModule = new System.Windows.Forms.NumericUpDown();
            this.numInputTorque = new System.Windows.Forms.NumericUpDown();
            this.numOutputTorque = new System.Windows.Forms.NumericUpDown();
            this.numAxesDistance = new System.Windows.Forms.NumericUpDown();
            this.numAlpha = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTorqueRatio = new System.Windows.Forms.Label();
            this.lblOutputGearMaterial = new System.Windows.Forms.Label();
            this.lblInputGearMaterial = new System.Windows.Forms.Label();
            this.lblOutputTorque = new System.Windows.Forms.Label();
            this.lblInputTorque = new System.Windows.Forms.Label();
            this.lblGearModule = new System.Windows.Forms.Label();
            this.lblAxesDistance = new System.Windows.Forms.Label();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTorqueRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGearModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputTorque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutputTorque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAxesDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnValidate);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerate);
            this.splitContainer1.Panel1.Controls.Add(this.txtOutputMaterial);
            this.splitContainer1.Panel1.Controls.Add(this.btnOutputMaterial);
            this.splitContainer1.Panel1.Controls.Add(this.txtInputMaterial);
            this.splitContainer1.Panel1.Controls.Add(this.btnInputMaterial);
            this.splitContainer1.Panel1.Controls.Add(this.numTorqueRatio);
            this.splitContainer1.Panel1.Controls.Add(this.numGearModule);
            this.splitContainer1.Panel1.Controls.Add(this.numInputTorque);
            this.splitContainer1.Panel1.Controls.Add(this.numOutputTorque);
            this.splitContainer1.Panel1.Controls.Add(this.numAxesDistance);
            this.splitContainer1.Panel1.Controls.Add(this.numAlpha);
            this.splitContainer1.Panel1.Controls.Add(this.txtName);
            this.splitContainer1.Panel1.Controls.Add(this.lblTorqueRatio);
            this.splitContainer1.Panel1.Controls.Add(this.lblOutputGearMaterial);
            this.splitContainer1.Panel1.Controls.Add(this.lblInputGearMaterial);
            this.splitContainer1.Panel1.Controls.Add(this.lblOutputTorque);
            this.splitContainer1.Panel1.Controls.Add(this.lblInputTorque);
            this.splitContainer1.Panel1.Controls.Add(this.lblGearModule);
            this.splitContainer1.Panel1.Controls.Add(this.lblAxesDistance);
            this.splitContainer1.Panel1.Controls.Add(this.lblAlpha);
            this.splitContainer1.Panel1.Controls.Add(this.lblName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(584, 598);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(37, 407);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(174, 34);
            this.btnValidate.TabIndex = 35;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Visible = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(37, 367);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(174, 34);
            this.btnGenerate.TabIndex = 34;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtOutputMaterial
            // 
            this.txtOutputMaterial.Location = new System.Drawing.Point(119, 198);
            this.txtOutputMaterial.Name = "txtOutputMaterial";
            this.txtOutputMaterial.ReadOnly = true;
            this.txtOutputMaterial.Size = new System.Drawing.Size(92, 20);
            this.txtOutputMaterial.TabIndex = 33;
            this.txtOutputMaterial.Visible = false;
            // 
            // btnOutputMaterial
            // 
            this.btnOutputMaterial.Location = new System.Drawing.Point(119, 196);
            this.btnOutputMaterial.Name = "btnOutputMaterial";
            this.btnOutputMaterial.Size = new System.Drawing.Size(120, 23);
            this.btnOutputMaterial.TabIndex = 32;
            this.btnOutputMaterial.Text = "Choose...";
            this.btnOutputMaterial.UseVisualStyleBackColor = true;
            this.btnOutputMaterial.Click += new System.EventHandler(this.btnOutputMaterial_Click);
            // 
            // txtInputMaterial
            // 
            this.txtInputMaterial.Location = new System.Drawing.Point(119, 145);
            this.txtInputMaterial.Name = "txtInputMaterial";
            this.txtInputMaterial.ReadOnly = true;
            this.txtInputMaterial.Size = new System.Drawing.Size(92, 20);
            this.txtInputMaterial.TabIndex = 31;
            this.txtInputMaterial.Visible = false;
            // 
            // btnInputMaterial
            // 
            this.btnInputMaterial.Location = new System.Drawing.Point(119, 143);
            this.btnInputMaterial.Name = "btnInputMaterial";
            this.btnInputMaterial.Size = new System.Drawing.Size(120, 23);
            this.btnInputMaterial.TabIndex = 30;
            this.btnInputMaterial.Text = "Choose...";
            this.btnInputMaterial.UseVisualStyleBackColor = true;
            this.btnInputMaterial.Click += new System.EventHandler(this.btnInputMaterial_Click);
            // 
            // numTorqueRatio
            // 
            this.numTorqueRatio.DecimalPlaces = 2;
            this.numTorqueRatio.Location = new System.Drawing.Point(119, 225);
            this.numTorqueRatio.Name = "numTorqueRatio";
            this.numTorqueRatio.Size = new System.Drawing.Size(119, 20);
            this.numTorqueRatio.TabIndex = 15;
            this.numTorqueRatio.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numGearModule
            // 
            this.numGearModule.DecimalPlaces = 2;
            this.numGearModule.Location = new System.Drawing.Point(119, 93);
            this.numGearModule.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numGearModule.Name = "numGearModule";
            this.numGearModule.Size = new System.Drawing.Size(119, 20);
            this.numGearModule.TabIndex = 12;
            this.numGearModule.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numInputTorque
            // 
            this.numInputTorque.DecimalPlaces = 2;
            this.numInputTorque.Location = new System.Drawing.Point(119, 119);
            this.numInputTorque.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numInputTorque.Name = "numInputTorque";
            this.numInputTorque.Size = new System.Drawing.Size(119, 20);
            this.numInputTorque.TabIndex = 13;
            this.numInputTorque.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numOutputTorque
            // 
            this.numOutputTorque.DecimalPlaces = 2;
            this.numOutputTorque.Location = new System.Drawing.Point(119, 172);
            this.numOutputTorque.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOutputTorque.Name = "numOutputTorque";
            this.numOutputTorque.Size = new System.Drawing.Size(120, 20);
            this.numOutputTorque.TabIndex = 14;
            this.numOutputTorque.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numAxesDistance
            // 
            this.numAxesDistance.DecimalPlaces = 2;
            this.numAxesDistance.Location = new System.Drawing.Point(119, 67);
            this.numAxesDistance.Name = "numAxesDistance";
            this.numAxesDistance.Size = new System.Drawing.Size(119, 20);
            this.numAxesDistance.TabIndex = 11;
            this.numAxesDistance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numAlpha
            // 
            this.numAlpha.DecimalPlaces = 2;
            this.numAlpha.Location = new System.Drawing.Point(119, 41);
            this.numAlpha.Name = "numAlpha";
            this.numAlpha.Size = new System.Drawing.Size(119, 20);
            this.numAlpha.TabIndex = 10;
            this.numAlpha.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 20);
            this.txtName.TabIndex = 9;
            // 
            // lblTorqueRatio
            // 
            this.lblTorqueRatio.AutoSize = true;
            this.lblTorqueRatio.Location = new System.Drawing.Point(43, 227);
            this.lblTorqueRatio.Name = "lblTorqueRatio";
            this.lblTorqueRatio.Size = new System.Drawing.Size(69, 13);
            this.lblTorqueRatio.TabIndex = 8;
            this.lblTorqueRatio.Text = "Torque Ratio";
            // 
            // lblOutputGearMaterial
            // 
            this.lblOutputGearMaterial.AutoSize = true;
            this.lblOutputGearMaterial.Location = new System.Drawing.Point(8, 201);
            this.lblOutputGearMaterial.Name = "lblOutputGearMaterial";
            this.lblOutputGearMaterial.Size = new System.Drawing.Size(105, 13);
            this.lblOutputGearMaterial.TabIndex = 7;
            this.lblOutputGearMaterial.Text = "Output Gear Material";
            // 
            // lblInputGearMaterial
            // 
            this.lblInputGearMaterial.AutoSize = true;
            this.lblInputGearMaterial.Location = new System.Drawing.Point(16, 148);
            this.lblInputGearMaterial.Name = "lblInputGearMaterial";
            this.lblInputGearMaterial.Size = new System.Drawing.Size(97, 13);
            this.lblInputGearMaterial.TabIndex = 6;
            this.lblInputGearMaterial.Text = "Input Gear Material";
            // 
            // lblOutputTorque
            // 
            this.lblOutputTorque.AutoSize = true;
            this.lblOutputTorque.Location = new System.Drawing.Point(11, 174);
            this.lblOutputTorque.Name = "lblOutputTorque";
            this.lblOutputTorque.Size = new System.Drawing.Size(101, 13);
            this.lblOutputTorque.TabIndex = 5;
            this.lblOutputTorque.Text = "Output Torque (mm)";
            // 
            // lblInputTorque
            // 
            this.lblInputTorque.AutoSize = true;
            this.lblInputTorque.Location = new System.Drawing.Point(20, 121);
            this.lblInputTorque.Name = "lblInputTorque";
            this.lblInputTorque.Size = new System.Drawing.Size(93, 13);
            this.lblInputTorque.TabIndex = 4;
            this.lblInputTorque.Text = "Input Torque (mm)";
            // 
            // lblGearModule
            // 
            this.lblGearModule.AutoSize = true;
            this.lblGearModule.Location = new System.Drawing.Point(20, 95);
            this.lblGearModule.Name = "lblGearModule";
            this.lblGearModule.Size = new System.Drawing.Size(93, 13);
            this.lblGearModule.TabIndex = 3;
            this.lblGearModule.Text = "Gear Module (mm)";
            this.lblGearModule.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAxesDistance
            // 
            this.lblAxesDistance.AutoSize = true;
            this.lblAxesDistance.Location = new System.Drawing.Point(13, 69);
            this.lblAxesDistance.Name = "lblAxesDistance";
            this.lblAxesDistance.Size = new System.Drawing.Size(100, 13);
            this.lblAxesDistance.TabIndex = 2;
            this.lblAxesDistance.Text = "Axes Distance (mm)";
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(52, 43);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(61, 13);
            this.lblAlpha.TabIndex = 1;
            this.lblAlpha.Text = "Alpha (deg)";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(78, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer2.Size = new System.Drawing.Size(336, 598);
            this.splitContainer2.SplitterDistance = 288;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(330, 282);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(330, 300);
            this.propertyGrid1.TabIndex = 0;
            // 
            // GearBoxGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 598);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GearBoxGenerator";
            this.Text = "GearBoxGenerator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTorqueRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGearModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInputTorque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutputTorque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAxesDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlpha)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.NumericUpDown numTorqueRatio;
        private System.Windows.Forms.NumericUpDown numGearModule;
        private System.Windows.Forms.NumericUpDown numInputTorque;
        private System.Windows.Forms.NumericUpDown numOutputTorque;
        private System.Windows.Forms.NumericUpDown numAxesDistance;
        private System.Windows.Forms.NumericUpDown numAlpha;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTorqueRatio;
        private System.Windows.Forms.Label lblOutputGearMaterial;
        private System.Windows.Forms.Label lblInputGearMaterial;
        private System.Windows.Forms.Label lblOutputTorque;
        private System.Windows.Forms.Label lblInputTorque;
        private System.Windows.Forms.Label lblGearModule;
        private System.Windows.Forms.Label lblAxesDistance;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TextBox txtOutputMaterial;
        private System.Windows.Forms.Button btnOutputMaterial;
        private System.Windows.Forms.TextBox txtInputMaterial;
        private System.Windows.Forms.Button btnInputMaterial;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnGenerate;
    }
}