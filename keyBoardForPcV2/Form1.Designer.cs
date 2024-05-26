namespace keyBoardForPcV2
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
            components = new System.ComponentModel.Container();
            textBoxBluePress = new TextBox();
            textBoxBlueRelease = new TextBox();
            textBoxWhitePress = new TextBox();
            textBoxWhiteRelease = new TextBox();
            textBoxRedPress = new TextBox();
            textBoxRedRelease = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            comboBoxCom = new ComboBox();
            buttonUpdateCom = new Button();
            buttonConnectCom = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panelConnect = new Panel();
            buttonDisconnect = new Button();
            panelHotkeys = new Panel();
            panelConnect.SuspendLayout();
            panelHotkeys.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxBluePress
            // 
            textBoxBluePress.Location = new Point(12, 58);
            textBoxBluePress.Name = "textBoxBluePress";
            textBoxBluePress.Size = new Size(100, 23);
            textBoxBluePress.TabIndex = 0;
            // 
            // textBoxBlueRelease
            // 
            textBoxBlueRelease.Location = new Point(12, 105);
            textBoxBlueRelease.Name = "textBoxBlueRelease";
            textBoxBlueRelease.Size = new Size(100, 23);
            textBoxBlueRelease.TabIndex = 1;
            // 
            // textBoxWhitePress
            // 
            textBoxWhitePress.Location = new Point(157, 58);
            textBoxWhitePress.Name = "textBoxWhitePress";
            textBoxWhitePress.Size = new Size(100, 23);
            textBoxWhitePress.TabIndex = 2;
            // 
            // textBoxWhiteRelease
            // 
            textBoxWhiteRelease.Location = new Point(157, 105);
            textBoxWhiteRelease.Name = "textBoxWhiteRelease";
            textBoxWhiteRelease.Size = new Size(100, 23);
            textBoxWhiteRelease.TabIndex = 3;
            // 
            // textBoxRedPress
            // 
            textBoxRedPress.Location = new Point(302, 58);
            textBoxRedPress.Name = "textBoxRedPress";
            textBoxRedPress.Size = new Size(100, 23);
            textBoxRedPress.TabIndex = 4;
            // 
            // textBoxRedRelease
            // 
            textBoxRedRelease.Location = new Point(302, 105);
            textBoxRedRelease.Name = "textBoxRedRelease";
            textBoxRedRelease.Size = new Size(100, 23);
            textBoxRedRelease.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 13);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 6;
            label1.Text = "Blue button";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 13);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 7;
            label2.Text = "Red button";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 13);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 8;
            label3.Text = "White button";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 40);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 9;
            label4.Text = "Press";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 40);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 10;
            label5.Text = "Press";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 40);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 11;
            label6.Text = "Press";
            // 
            // timer
            // 
            timer.Interval = 300;
            timer.Tick += timer_Tick;
            // 
            // comboBoxCom
            // 
            comboBoxCom.FormattingEnabled = true;
            comboBoxCom.Location = new Point(3, 30);
            comboBoxCom.Name = "comboBoxCom";
            comboBoxCom.Size = new Size(121, 23);
            comboBoxCom.TabIndex = 12;
            // 
            // buttonUpdateCom
            // 
            buttonUpdateCom.Location = new Point(3, 59);
            buttonUpdateCom.Name = "buttonUpdateCom";
            buttonUpdateCom.Size = new Size(53, 23);
            buttonUpdateCom.TabIndex = 13;
            buttonUpdateCom.Text = "Update";
            buttonUpdateCom.UseVisualStyleBackColor = true;
            buttonUpdateCom.Click += buttonUpdateCom_Click;
            // 
            // buttonConnectCom
            // 
            buttonConnectCom.Location = new Point(62, 59);
            buttonConnectCom.Name = "buttonConnectCom";
            buttonConnectCom.Size = new Size(62, 23);
            buttonConnectCom.TabIndex = 14;
            buttonConnectCom.Text = "Connect";
            buttonConnectCom.UseVisualStyleBackColor = true;
            buttonConnectCom.Click += buttonConnectCom_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 12);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 15;
            label7.Text = "Connect to keyboard";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 87);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 16;
            label8.Text = "Release";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(336, 84);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 17;
            label9.Text = "Release";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(190, 84);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 18;
            label10.Text = "Release";
            label10.Click += label10_Click;
            // 
            // panelConnect
            // 
            panelConnect.Controls.Add(comboBoxCom);
            panelConnect.Controls.Add(buttonUpdateCom);
            panelConnect.Controls.Add(buttonConnectCom);
            panelConnect.Controls.Add(label7);
            panelConnect.Location = new Point(426, 9);
            panelConnect.Name = "panelConnect";
            panelConnect.Size = new Size(135, 89);
            panelConnect.TabIndex = 19;
            // 
            // buttonDisconnect
            // 
            buttonDisconnect.Enabled = false;
            buttonDisconnect.Location = new Point(429, 104);
            buttonDisconnect.Name = "buttonDisconnect";
            buttonDisconnect.Size = new Size(75, 23);
            buttonDisconnect.TabIndex = 20;
            buttonDisconnect.Text = "Disconnect";
            buttonDisconnect.UseVisualStyleBackColor = true;
            buttonDisconnect.Click += buttonDisconnect_Click;
            // 
            // panelHotkeys
            // 
            panelHotkeys.Controls.Add(textBoxRedRelease);
            panelHotkeys.Controls.Add(textBoxBluePress);
            panelHotkeys.Controls.Add(label10);
            panelHotkeys.Controls.Add(textBoxBlueRelease);
            panelHotkeys.Controls.Add(label9);
            panelHotkeys.Controls.Add(textBoxWhitePress);
            panelHotkeys.Controls.Add(label8);
            panelHotkeys.Controls.Add(textBoxWhiteRelease);
            panelHotkeys.Controls.Add(label6);
            panelHotkeys.Controls.Add(textBoxRedPress);
            panelHotkeys.Controls.Add(label5);
            panelHotkeys.Controls.Add(label1);
            panelHotkeys.Controls.Add(label4);
            panelHotkeys.Controls.Add(label2);
            panelHotkeys.Controls.Add(label3);
            panelHotkeys.Location = new Point(1, 0);
            panelHotkeys.Name = "panelHotkeys";
            panelHotkeys.Size = new Size(420, 150);
            panelHotkeys.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 162);
            Controls.Add(buttonDisconnect);
            Controls.Add(panelConnect);
            Controls.Add(panelHotkeys);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panelConnect.ResumeLayout(false);
            panelConnect.PerformLayout();
            panelHotkeys.ResumeLayout(false);
            panelHotkeys.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxBluePress;
        private TextBox textBoxBlueRelease;
        private TextBox textBoxWhitePress;
        private TextBox textBoxWhiteRelease;
        private TextBox textBoxRedPress;
        private TextBox textBoxRedRelease;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private System.Windows.Forms.Timer timer;
        private ComboBox comboBoxCom;
        private Button buttonUpdateCom;
        private Button buttonConnectCom;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panelConnect;
        private Button buttonDisconnect;
        private Panel panelHotkeys;
    }
}
