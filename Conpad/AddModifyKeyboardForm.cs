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
    public partial class AddModifyKeyboardForm : Form
    {
        public new Main Owner { get; private set; }

        public AddModifyKeyboardForm()
        {
            InitializeComponent();
        }

        public void Show(Main owner)
        {
            Owner = owner;
            this.Show();
        }

        public void Show(Main owner, Dictionary<string, string> keyboard, string keyboardName)
        {
            Keyboard.Text = ConTextEdit.Deparse(keyboard);
            KeyboardName.Text = keyboardName;
            this.Show(owner);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!Owner.conTextEdit1.KeyboardIdentifiers.Contains(KeyboardName.Text))
            {
                Owner.conTextEdit1.AddKeyboard(ConTextEdit.Parse(Keyboard.Text), KeyboardName.Text);
            }
            else
            {
                Owner.conTextEdit1.ModifyKeyboard(ConTextEdit.Parse(Keyboard.Text), KeyboardName.Text);
            }
            this.DialogResult = DialogResult.OK;
            Keyboard.Text = "";
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Keyboard.Text = "";
            this.Close();
        }

        private void AddKeyboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
