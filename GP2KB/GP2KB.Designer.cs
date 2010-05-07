/*
 * GamePad to KeyBoard
 * Copyright (c) 2010 Rodrigo 'r2d2rigo' Diaz
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify,
 * merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
 * permit persons to whom the Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies
 * or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
 * CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

namespace GP2KB
{
    partial class GP2KB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GP2KB));
            this.keyA = new System.Windows.Forms.TextBox();
            this.keyX = new System.Windows.Forms.TextBox();
            this.keyB = new System.Windows.Forms.TextBox();
            this.keyY = new System.Windows.Forms.TextBox();
            this.keyDown = new System.Windows.Forms.TextBox();
            this.keyLeft = new System.Windows.Forms.TextBox();
            this.keyRight = new System.Windows.Forms.TextBox();
            this.keyUp = new System.Windows.Forms.TextBox();
            this.keyBack = new System.Windows.Forms.TextBox();
            this.keyStart = new System.Windows.Forms.TextBox();
            this.keyLShoulder = new System.Windows.Forms.TextBox();
            this.keyRShoulder = new System.Windows.Forms.TextBox();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // keyA
            // 
            this.keyA.Location = new System.Drawing.Point(610, 178);
            this.keyA.Name = "keyA";
            this.keyA.Size = new System.Drawing.Size(45, 20);
            this.keyA.TabIndex = 1;
            this.keyA.Tag = "A";
            this.toolTipHelp.SetToolTip(this.keyA, "A Button");
            this.keyA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // keyX
            // 
            this.keyX.Location = new System.Drawing.Point(550, 121);
            this.keyX.Name = "keyX";
            this.keyX.Size = new System.Drawing.Size(41, 20);
            this.keyX.TabIndex = 1;
            this.keyX.Tag = "X";
            this.toolTipHelp.SetToolTip(this.keyX, "X Button");
            this.keyX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // keyB
            // 
            this.keyB.Location = new System.Drawing.Point(668, 121);
            this.keyB.Name = "keyB";
            this.keyB.Size = new System.Drawing.Size(42, 20);
            this.keyB.TabIndex = 1;
            this.keyB.Tag = "B";
            this.toolTipHelp.SetToolTip(this.keyB, "B Button");
            this.keyB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // keyY
            // 
            this.keyY.Location = new System.Drawing.Point(610, 63);
            this.keyY.Name = "keyY";
            this.keyY.Size = new System.Drawing.Size(44, 20);
            this.keyY.TabIndex = 1;
            this.keyY.Tag = "Y";
            this.toolTipHelp.SetToolTip(this.keyY, "Y Button");
            this.keyY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // keyDown
            // 
            this.keyDown.Location = new System.Drawing.Point(261, 292);
            this.keyDown.Name = "keyDown";
            this.keyDown.Size = new System.Drawing.Size(49, 20);
            this.keyDown.TabIndex = 1;
            this.keyDown.Tag = "DPadDown";
            this.toolTipHelp.SetToolTip(this.keyDown, "Directional Pad Down");
            this.keyDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // keyLeft
            // 
            this.keyLeft.Location = new System.Drawing.Point(201, 244);
            this.keyLeft.Name = "keyLeft";
            this.keyLeft.Size = new System.Drawing.Size(47, 20);
            this.keyLeft.TabIndex = 1;
            this.keyLeft.Tag = "DPadLeft";
            this.toolTipHelp.SetToolTip(this.keyLeft, "Directional Pad Left");
            this.keyLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // keyRight
            // 
            this.keyRight.Location = new System.Drawing.Point(326, 244);
            this.keyRight.Name = "keyRight";
            this.keyRight.Size = new System.Drawing.Size(49, 20);
            this.keyRight.TabIndex = 1;
            this.keyRight.Tag = "DPadRight";
            this.toolTipHelp.SetToolTip(this.keyRight, "Directional Pad Right");
            this.keyRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // keyUp
            // 
            this.keyUp.Location = new System.Drawing.Point(261, 193);
            this.keyUp.Name = "keyUp";
            this.keyUp.Size = new System.Drawing.Size(49, 20);
            this.keyUp.TabIndex = 1;
            this.keyUp.Tag = "DPadUp";
            this.toolTipHelp.SetToolTip(this.keyUp, "Directial Pad Up");
            this.keyUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // keyBack
            // 
            this.keyBack.Location = new System.Drawing.Point(297, 121);
            this.keyBack.Name = "keyBack";
            this.keyBack.Size = new System.Drawing.Size(49, 20);
            this.keyBack.TabIndex = 1;
            this.keyBack.Tag = "Back";
            this.toolTipHelp.SetToolTip(this.keyBack, "Back Button");
            this.keyBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // keyStart
            // 
            this.keyStart.Location = new System.Drawing.Point(464, 121);
            this.keyStart.Name = "keyStart";
            this.keyStart.Size = new System.Drawing.Size(49, 20);
            this.keyStart.TabIndex = 1;
            this.keyStart.Tag = "Start";
            this.toolTipHelp.SetToolTip(this.keyStart, "Start Button");
            this.keyStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // keyLShoulder
            // 
            this.keyLShoulder.Location = new System.Drawing.Point(152, 12);
            this.keyLShoulder.Name = "keyLShoulder";
            this.keyLShoulder.Size = new System.Drawing.Size(49, 20);
            this.keyLShoulder.TabIndex = 1;
            this.keyLShoulder.Tag = "LeftShoulder";
            this.toolTipHelp.SetToolTip(this.keyLShoulder, "Left Shoulder Button");
            this.keyLShoulder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // keyRShoulder
            // 
            this.keyRShoulder.Location = new System.Drawing.Point(605, 12);
            this.keyRShoulder.Name = "keyRShoulder";
            this.keyRShoulder.Size = new System.Drawing.Size(49, 20);
            this.keyRShoulder.TabIndex = 1;
            this.keyRShoulder.Tag = "RightShoulder";
            this.toolTipHelp.SetToolTip(this.keyRShoulder, "Right Shoulder Button");
            this.keyRShoulder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyButton_KeyDown);
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.AutomaticDelay = 100;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "GP2KB";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Image = global::GP2KB.Properties.Resources.help;
            this.buttonHelp.Location = new System.Drawing.Point(775, 547);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(24, 24);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GP2KB.Properties.Resources.controller;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 571);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GP2KB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.keyRShoulder);
            this.Controls.Add(this.keyLShoulder);
            this.Controls.Add(this.keyStart);
            this.Controls.Add(this.keyBack);
            this.Controls.Add(this.keyUp);
            this.Controls.Add(this.keyY);
            this.Controls.Add(this.keyRight);
            this.Controls.Add(this.keyB);
            this.Controls.Add(this.keyLeft);
            this.Controls.Add(this.keyDown);
            this.Controls.Add(this.keyX);
            this.Controls.Add(this.keyA);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "GP2KB";
            this.Text = "GamePad to KeyBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GP2KB_FormClosed);
            this.Resize += new System.EventHandler(this.GP2KB_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyA;
        private System.Windows.Forms.TextBox keyX;
        private System.Windows.Forms.TextBox keyB;
        private System.Windows.Forms.TextBox keyY;
        private System.Windows.Forms.TextBox keyDown;
        private System.Windows.Forms.TextBox keyLeft;
        private System.Windows.Forms.TextBox keyRight;
        private System.Windows.Forms.TextBox keyUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox keyBack;
        private System.Windows.Forms.TextBox keyStart;
        private System.Windows.Forms.TextBox keyLShoulder;
        private System.Windows.Forms.TextBox keyRShoulder;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button buttonHelp;
    }
}

