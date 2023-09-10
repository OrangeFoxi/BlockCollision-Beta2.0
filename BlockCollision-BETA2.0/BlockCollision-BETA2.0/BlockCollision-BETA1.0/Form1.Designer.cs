namespace BlockCollision_BETA1._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.labelCollisionStatus = new System.Windows.Forms.Label();
            this.textBoxRedWeight = new System.Windows.Forms.TextBox();
            this.textBoxRedSpeed = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBlueWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBlueSpeed = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.autoPlayer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(13, 232);
            this.panelRed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(139, 139);
            this.panelRed.TabIndex = 0;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(991, 232);
            this.panelBlue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(139, 139);
            this.panelBlue.TabIndex = 1;
            // 
            // labelCollisionStatus
            // 
            this.labelCollisionStatus.AutoSize = true;
            this.labelCollisionStatus.Location = new System.Drawing.Point(503, 710);
            this.labelCollisionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCollisionStatus.Name = "labelCollisionStatus";
            this.labelCollisionStatus.Size = new System.Drawing.Size(118, 25);
            this.labelCollisionStatus.TabIndex = 2;
            this.labelCollisionStatus.Text = "collision-data";
            // 
            // textBoxRedWeight
            // 
            this.textBoxRedWeight.Location = new System.Drawing.Point(376, 25);
            this.textBoxRedWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRedWeight.Name = "textBoxRedWeight";
            this.textBoxRedWeight.Size = new System.Drawing.Size(141, 31);
            this.textBoxRedWeight.TabIndex = 3;
            // 
            // textBoxRedSpeed
            // 
            this.textBoxRedSpeed.Location = new System.Drawing.Point(629, 25);
            this.textBoxRedSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRedSpeed.Name = "textBoxRedSpeed";
            this.textBoxRedSpeed.Size = new System.Drawing.Size(141, 31);
            this.textBoxRedSpeed.TabIndex = 4;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(266, 30);
            this.labelWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(107, 25);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Red Weight:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(527, 30);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(101, 25);
            this.labelSpeed.TabIndex = 6;
            this.labelSpeed.Text = "Red Speed:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1006, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Blue Weight:";
            // 
            // textBoxBlueWeight
            // 
            this.textBoxBlueWeight.Location = new System.Drawing.Point(376, 95);
            this.textBoxBlueWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBlueWeight.Name = "textBoxBlueWeight";
            this.textBoxBlueWeight.Size = new System.Drawing.Size(141, 31);
            this.textBoxBlueWeight.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Blue Speed:";
            // 
            // textBoxBlueSpeed
            // 
            this.textBoxBlueSpeed.Location = new System.Drawing.Point(629, 100);
            this.textBoxBlueSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxBlueSpeed.Name = "textBoxBlueSpeed";
            this.textBoxBlueSpeed.Size = new System.Drawing.Size(141, 31);
            this.textBoxBlueSpeed.TabIndex = 11;
            this.textBoxBlueSpeed.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1006, 78);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(794, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 13;
            // 
            // autoPlayer
            // 
            this.autoPlayer.AutoSize = true;
            this.autoPlayer.Location = new System.Drawing.Point(3, 5);
            this.autoPlayer.Name = "autoPlayer";
            this.autoPlayer.Size = new System.Drawing.Size(121, 29);
            this.autoPlayer.TabIndex = 14;
            this.autoPlayer.Text = "autoPlayer";
            this.autoPlayer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.autoPlayer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxBlueSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBlueWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.textBoxRedSpeed);
            this.Controls.Add(this.textBoxRedWeight);
            this.Controls.Add(this.labelCollisionStatus);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelRed);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelRed;
        private Panel panelBlue;
        private Label labelCollisionStatus;
        private TextBox textBoxRedWeight;
        private TextBox textBoxRedSpeed;
        private Label labelWeight;
        private Label labelSpeed;
        private Button button1;
        private Label label1;
        private TextBox textBoxBlueWeight;
        private Label label2;
        private TextBox textBoxBlueSpeed;
        private Button button2;
        private TextBox textBox1;
        private CheckBox autoPlayer;
    }
}