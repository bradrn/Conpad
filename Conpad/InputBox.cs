using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conpad
{
    public partial class InputBox : Form
    {
        Timer t = new Timer();

        public String Input
        {
            get { return textInput.Text; }
        }

        public InputBox()
        {
            InitializeComponent();

            t.Interval = 10;
            t.Tick += (object sender, EventArgs e) =>
            {
                KeyboardStatus.Text = textInput.KeyboardInUseIdentifier;
            };
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textInput;
        }

        public static DialogResult Show(String title, String message, String inputTitle,
            ConTextEdit keyboardsTextEdit, out String inputValue)
        {
            InputBox inputBox = null;
            DialogResult results = DialogResult.None;

            using (inputBox = new InputBox() { Text = title })
            {
                inputBox.textInput.Keyboards = keyboardsTextEdit.Keyboards;
                inputBox.textInput.KeyboardIdentifiers = keyboardsTextEdit.KeyboardIdentifiers;
                inputBox.textInput.KeyboardInUse = keyboardsTextEdit.KeyboardInUse;
                inputBox.labelMessage.Text = message;
                //inputBox.splitContainer2.SplitterDistance = inputBox.labelMessage.Width;
                inputBox.labelInput.Text = inputTitle;
                //inputBox.splitContainer1.SplitterDistance = inputBox.labelInput.Width;
                /*inputBox.Size = new Size(
                    inputBox.Width,
                    8 + inputBox.labelMessage.Height + inputBox.splitContainer2.SplitterWidth + inputBox.splitContainer1.Height + 8 + inputBox.button2.Height + 12 + (50));*/
                results = inputBox.ShowDialog();
                inputValue = inputBox.Input;
            }

            return results;
        }


        private void TextInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.K)
            {
                if (textInput.KeyboardInUse < textInput.Keyboards.Count - 1)
                {
                    textInput.KeyboardInUse++;
                }
                else
                {
                    textInput.KeyboardInUse = 0;
                }
            }
        }

    }
}
