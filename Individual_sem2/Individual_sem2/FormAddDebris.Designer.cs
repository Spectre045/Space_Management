﻿namespace Individual_sem2
{
    partial class FormAddDebris
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
            groupBox2 = new GroupBox();
            cbbOrbitType = new ComboBox();
            label16 = new Label();
            btnAddDebris = new Button();
            btnAbort = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            tbOrientationZ = new TextBox();
            tbOrientationY = new TextBox();
            tbOrientationX = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tbVelocityZ = new TextBox();
            tbVelocityY = new TextBox();
            tbVelocityX = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tbDangerRadius = new TextBox();
            tbPositionZ = new TextBox();
            tbPositionY = new TextBox();
            tbPositionX = new TextBox();
            tbMass = new TextBox();
            tbSize = new TextBox();
            tbName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblObjOrientation = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(170, 0, 0, 0);
            groupBox2.Controls.Add(cbbOrbitType);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(btnAddDebris);
            groupBox2.Controls.Add(btnAbort);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(tbOrientationZ);
            groupBox2.Controls.Add(tbOrientationY);
            groupBox2.Controls.Add(tbOrientationX);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(tbVelocityZ);
            groupBox2.Controls.Add(tbVelocityY);
            groupBox2.Controls.Add(tbVelocityX);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbDangerRadius);
            groupBox2.Controls.Add(tbPositionZ);
            groupBox2.Controls.Add(tbPositionY);
            groupBox2.Controls.Add(tbPositionX);
            groupBox2.Controls.Add(tbMass);
            groupBox2.Controls.Add(tbSize);
            groupBox2.Controls.Add(tbName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lblObjOrientation);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(12, 11);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(500, 476);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add:";
            // 
            // cbbOrbitType
            // 
            cbbOrbitType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbbOrbitType.FormattingEnabled = true;
            cbbOrbitType.Location = new Point(108, 328);
            cbbOrbitType.Name = "cbbOrbitType";
            cbbOrbitType.Size = new Size(160, 25);
            cbbOrbitType.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(6, 331);
            label16.Name = "label16";
            label16.Size = new Size(97, 21);
            label16.TabIndex = 43;
            label16.Text = "Orbit Type: ";
            // 
            // btnAddDebris
            // 
            btnAddDebris.BackColor = SystemColors.ActiveCaptionText;
            btnAddDebris.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddDebris.ForeColor = SystemColors.ButtonFace;
            btnAddDebris.Location = new Point(281, 406);
            btnAddDebris.Margin = new Padding(3, 2, 3, 2);
            btnAddDebris.Name = "btnAddDebris";
            btnAddDebris.Size = new Size(213, 53);
            btnAddDebris.TabIndex = 42;
            btnAddDebris.Text = "Add Debris";
            btnAddDebris.UseVisualStyleBackColor = false;
            btnAddDebris.Click += btnAddDebris_Click;
            // 
            // btnAbort
            // 
            btnAbort.BackColor = SystemColors.ActiveCaptionText;
            btnAbort.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbort.ForeColor = SystemColors.ButtonFace;
            btnAbort.Location = new Point(12, 406);
            btnAbort.Margin = new Padding(3, 2, 3, 2);
            btnAbort.Name = "btnAbort";
            btnAbort.Size = new Size(213, 53);
            btnAbort.TabIndex = 41;
            btnAbort.Text = "Abort";
            btnAbort.UseVisualStyleBackColor = false;
            btnAbort.Click += btnAbort_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(307, 252);
            label13.Name = "label13";
            label13.Size = new Size(28, 21);
            label13.TabIndex = 40;
            label13.Text = "Z: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(197, 252);
            label14.Name = "label14";
            label14.Size = new Size(28, 21);
            label14.TabIndex = 39;
            label14.Text = "Y: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(103, 252);
            label15.Name = "label15";
            label15.Size = new Size(24, 21);
            label15.TabIndex = 38;
            label15.Text = "X:";
            // 
            // tbOrientationZ
            // 
            tbOrientationZ.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbOrientationZ.Location = new Point(341, 248);
            tbOrientationZ.Name = "tbOrientationZ";
            tbOrientationZ.Size = new Size(52, 25);
            tbOrientationZ.TabIndex = 37;
            // 
            // tbOrientationY
            // 
            tbOrientationY.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbOrientationY.Location = new Point(231, 248);
            tbOrientationY.Name = "tbOrientationY";
            tbOrientationY.Size = new Size(62, 25);
            tbOrientationY.TabIndex = 36;
            // 
            // tbOrientationX
            // 
            tbOrientationX.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbOrientationX.Location = new Point(133, 248);
            tbOrientationX.Name = "tbOrientationX";
            tbOrientationX.Size = new Size(56, 25);
            tbOrientationX.TabIndex = 35;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(292, 212);
            label10.Name = "label10";
            label10.Size = new Size(28, 21);
            label10.TabIndex = 33;
            label10.Text = "Z: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(182, 212);
            label11.Name = "label11";
            label11.Size = new Size(28, 21);
            label11.TabIndex = 32;
            label11.Text = "Y: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(88, 212);
            label12.Name = "label12";
            label12.Size = new Size(24, 21);
            label12.TabIndex = 31;
            label12.Text = "X:";
            // 
            // tbVelocityZ
            // 
            tbVelocityZ.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbVelocityZ.Location = new Point(326, 208);
            tbVelocityZ.Name = "tbVelocityZ";
            tbVelocityZ.Size = new Size(52, 25);
            tbVelocityZ.TabIndex = 30;
            // 
            // tbVelocityY
            // 
            tbVelocityY.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbVelocityY.Location = new Point(216, 208);
            tbVelocityY.Name = "tbVelocityY";
            tbVelocityY.Size = new Size(62, 25);
            tbVelocityY.TabIndex = 29;
            // 
            // tbVelocityX
            // 
            tbVelocityX.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbVelocityX.Location = new Point(118, 208);
            tbVelocityX.Name = "tbVelocityX";
            tbVelocityX.Size = new Size(56, 25);
            tbVelocityX.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(282, 177);
            label9.Name = "label9";
            label9.Size = new Size(28, 21);
            label9.TabIndex = 26;
            label9.Text = "Z: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(172, 177);
            label8.Name = "label8";
            label8.Size = new Size(28, 21);
            label8.TabIndex = 25;
            label8.Text = "Y: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(78, 177);
            label7.Name = "label7";
            label7.Size = new Size(24, 21);
            label7.TabIndex = 24;
            label7.Text = "X:";
            // 
            // tbDangerRadius
            // 
            tbDangerRadius.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbDangerRadius.Location = new Point(164, 291);
            tbDangerRadius.Name = "tbDangerRadius";
            tbDangerRadius.Size = new Size(146, 25);
            tbDangerRadius.TabIndex = 23;
            // 
            // tbPositionZ
            // 
            tbPositionZ.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbPositionZ.Location = new Point(316, 173);
            tbPositionZ.Name = "tbPositionZ";
            tbPositionZ.Size = new Size(52, 25);
            tbPositionZ.TabIndex = 20;
            // 
            // tbPositionY
            // 
            tbPositionY.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbPositionY.Location = new Point(206, 173);
            tbPositionY.Name = "tbPositionY";
            tbPositionY.Size = new Size(62, 25);
            tbPositionY.TabIndex = 19;
            // 
            // tbPositionX
            // 
            tbPositionX.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbPositionX.Location = new Point(108, 173);
            tbPositionX.Name = "tbPositionX";
            tbPositionX.Size = new Size(56, 25);
            tbPositionX.TabIndex = 18;
            // 
            // tbMass
            // 
            tbMass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbMass.Location = new Point(108, 123);
            tbMass.Name = "tbMass";
            tbMass.Size = new Size(192, 25);
            tbMass.TabIndex = 17;
            // 
            // tbSize
            // 
            tbSize.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbSize.Location = new Point(108, 80);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(192, 25);
            tbSize.TabIndex = 16;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbName.Location = new Point(76, 39);
            tbName.Name = "tbName";
            tbName.Size = new Size(192, 25);
            tbName.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(6, 291);
            label6.Name = "label6";
            label6.Size = new Size(152, 21);
            label6.TabIndex = 14;
            label6.Text = "Danger Radius(m):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(6, 252);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 13;
            label5.Text = "Orientation: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(6, 212);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 12;
            label4.Text = "Velocity: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(6, 177);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 11;
            label3.Text = "Position: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(6, 127);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 10;
            label2.Text = "Mass(kg): ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(6, 80);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 9;
            label1.Text = "Size(m^2): ";
            // 
            // lblObjOrientation
            // 
            lblObjOrientation.AutoSize = true;
            lblObjOrientation.BackColor = Color.Transparent;
            lblObjOrientation.Location = new Point(6, 39);
            lblObjOrientation.Name = "lblObjOrientation";
            lblObjOrientation.Size = new Size(64, 21);
            lblObjOrientation.TabIndex = 8;
            lblObjOrientation.Text = "Name: ";
            // 
            // FormAddDebris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Earth_Background2;
            ClientSize = new Size(524, 498);
            Controls.Add(groupBox2);
            Name = "FormAddDebris";
            Text = "FormAddDebris";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox tbDangerRadius;
        private TextBox tbPositionZ;
        private TextBox tbPositionY;
        private TextBox tbPositionX;
        private TextBox tbMass;
        private TextBox tbSize;
        private TextBox tbName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblObjOrientation;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox tbOrientationZ;
        private TextBox tbOrientationY;
        private TextBox tbOrientationX;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tbVelocityZ;
        private TextBox tbVelocityY;
        private TextBox tbVelocityX;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnAddDebris;
        private Button btnAbort;
        private Label label16;
        private ComboBox cbbOrbitType;
    }
}