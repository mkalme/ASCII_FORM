using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ASCII_FORM
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();

            setForm();
        }

        private void setForm() {
            Label.CheckForIllegalCrossThreadCalls = false;

            for (int i = 0; i < Convert.encoderList.Length; i++) {
                encoderComboBox.Items.Add(Convert.encoderList[i]);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pathTextBox.Text = openFileDialog1.FileName;
        }

        private void contrastCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            contrastTextBox.Enabled = contrastCheckBox.Checked;
            automaticCheckBox.Enabled = contrastCheckBox.Checked;
            if (automaticCheckBox.Checked) {
                contrastTextBox.Enabled = false;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                convertingLabel.Text = "Loading";
                timer1.Interval = 500;
                timer1.Start();

                Thread t1 = new Thread(delegate ()
                {
                    convertButton.Enabled = false;
                    Convert.baseForm = this;
                    Convert.convert();

                    convertButton.Enabled = true;
                });
                t1.Start();
            }
            catch {
                timer1.Stop();
                convertingLabel.Text = "";

                convertButton.Enabled = true;
            }
        }

        private void clipboardLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(string.IsNullOrEmpty(Convert.text) ? " " : Convert.text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int labelLength = convertingLabel.Text.Length - 6;

            labelLength = labelLength == 4 ? 0 : labelLength;

            string labelName = "Loading";

            for (int i = 0; i < labelLength; i++)
            {
                labelName += ".";
            }

            convertingLabel.Text = labelName;

            double percentage = 0.0;

            try
            {
                percentage = ((double)Convert.linesNow / (double)Convert.pixels.GetLength(1)) * 100;
            }
            catch {
            }

            percentageLabel.Text = String.Format("{0:0.00}", (Math.Floor(percentage * 100) / 100)) + "%";
        }

        private void Base_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Environment.Exit(1);
            }
            catch {
            }
        }

        private void urlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            browseButton.Enabled = !urlCheckBox.Checked;
        }

        private void experimentalLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            encodingTextBox.Text = "@NQ0#8BgD%KbHRU4$&AP6GMhpVWOwyXqZdue]9oma|n[TIJ2Yv5731ktECSj+LzFls\\)x/i>({}*cf!?_<=;r^\"-:,~.'` ";
        }

        private void automaticCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            contrastTextBox.Enabled = !automaticCheckBox.Checked;
        }

        private void encoderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            encodingTextBox.Text = encoderComboBox.Text;
        }
    }
}
