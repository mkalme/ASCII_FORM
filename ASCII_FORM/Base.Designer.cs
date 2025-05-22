namespace ASCII_FORM
{
    partial class Base
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
            this.browseButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contrastCheckBox = new System.Windows.Forms.CheckBox();
            this.contrastTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clipboardLink = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convertingLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.encodingTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.urlCheckBox = new System.Windows.Forms.CheckBox();
            this.automaticCheckBox = new System.Windows.Forms.CheckBox();
            this.encoderComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(12, 22);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 25);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(93, 25);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(430, 20);
            this.pathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the image you want to convert";
            // 
            // contrastCheckBox
            // 
            this.contrastCheckBox.AutoSize = true;
            this.contrastCheckBox.Location = new System.Drawing.Point(13, 117);
            this.contrastCheckBox.Name = "contrastCheckBox";
            this.contrastCheckBox.Size = new System.Drawing.Size(104, 17);
            this.contrastCheckBox.TabIndex = 3;
            this.contrastCheckBox.Text = "Change contrast";
            this.contrastCheckBox.UseVisualStyleBackColor = true;
            this.contrastCheckBox.CheckedChanged += new System.EventHandler(this.contrastCheckBox_CheckedChanged);
            // 
            // contrastTextBox
            // 
            this.contrastTextBox.Enabled = false;
            this.contrastTextBox.Location = new System.Drawing.Point(119, 115);
            this.contrastTextBox.Name = "contrastTextBox";
            this.contrastTextBox.Size = new System.Drawing.Size(100, 20);
            this.contrastTextBox.TabIndex = 4;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(12, 174);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 25);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clipboardLink
            // 
            this.clipboardLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.clipboardLink.AutoSize = true;
            this.clipboardLink.LinkColor = System.Drawing.Color.Black;
            this.clipboardLink.Location = new System.Drawing.Point(93, 184);
            this.clipboardLink.Name = "clipboardLink";
            this.clipboardLink.Size = new System.Drawing.Size(89, 13);
            this.clipboardLink.TabIndex = 6;
            this.clipboardLink.TabStop = true;
            this.clipboardLink.Text = "Copy to clipboard";
            this.clipboardLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.clipboardLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clipboardLink_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(12, 82);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Width (in pixels)";
            // 
            // convertingLabel
            // 
            this.convertingLabel.AutoSize = true;
            this.convertingLabel.Location = new System.Drawing.Point(11, 145);
            this.convertingLabel.Name = "convertingLabel";
            this.convertingLabel.Size = new System.Drawing.Size(0, 13);
            this.convertingLabel.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // encodingTextBox
            // 
            this.encodingTextBox.Location = new System.Drawing.Point(118, 82);
            this.encodingTextBox.Name = "encodingTextBox";
            this.encodingTextBox.Size = new System.Drawing.Size(192, 20);
            this.encodingTextBox.TabIndex = 10;
            this.encodingTextBox.Text = "@@8%MW52tvvf(!,.``` ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Encoder";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new System.Drawing.Point(72, 145);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(0, 13);
            this.percentageLabel.TabIndex = 12;
            // 
            // urlCheckBox
            // 
            this.urlCheckBox.AutoSize = true;
            this.urlCheckBox.Location = new System.Drawing.Point(455, 51);
            this.urlCheckBox.Name = "urlCheckBox";
            this.urlCheckBox.Size = new System.Drawing.Size(74, 17);
            this.urlCheckBox.TabIndex = 13;
            this.urlCheckBox.Text = "From URL";
            this.urlCheckBox.UseVisualStyleBackColor = true;
            this.urlCheckBox.CheckedChanged += new System.EventHandler(this.urlCheckBox_CheckedChanged);
            // 
            // automaticCheckBox
            // 
            this.automaticCheckBox.AutoSize = true;
            this.automaticCheckBox.Enabled = false;
            this.automaticCheckBox.Location = new System.Drawing.Point(226, 118);
            this.automaticCheckBox.Name = "automaticCheckBox";
            this.automaticCheckBox.Size = new System.Drawing.Size(73, 17);
            this.automaticCheckBox.TabIndex = 15;
            this.automaticCheckBox.Text = "Automatic";
            this.automaticCheckBox.UseVisualStyleBackColor = true;
            this.automaticCheckBox.CheckedChanged += new System.EventHandler(this.automaticCheckBox_CheckedChanged);
            // 
            // encoderComboBox
            // 
            this.encoderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encoderComboBox.FormattingEnabled = true;
            this.encoderComboBox.Location = new System.Drawing.Point(316, 82);
            this.encoderComboBox.Name = "encoderComboBox";
            this.encoderComboBox.Size = new System.Drawing.Size(207, 21);
            this.encoderComboBox.TabIndex = 16;
            this.encoderComboBox.SelectedIndexChanged += new System.EventHandler(this.encoderComboBox_SelectedIndexChanged);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 211);
            this.Controls.Add(this.encoderComboBox);
            this.Controls.Add(this.automaticCheckBox);
            this.Controls.Add(this.urlCheckBox);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encodingTextBox);
            this.Controls.Add(this.convertingLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.clipboardLink);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.contrastTextBox);
            this.Controls.Add(this.contrastCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.browseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image to ASCII";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Base_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.LinkLabel clipboardLink;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox pathTextBox;
        public System.Windows.Forms.CheckBox contrastCheckBox;
        public System.Windows.Forms.TextBox contrastTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox widthTextBox;
        public System.Windows.Forms.Label convertingLabel;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox encodingTextBox;
        public System.Windows.Forms.Label percentageLabel;
        public System.Windows.Forms.CheckBox urlCheckBox;
        public System.Windows.Forms.CheckBox automaticCheckBox;
        private System.Windows.Forms.ComboBox encoderComboBox;
    }
}

