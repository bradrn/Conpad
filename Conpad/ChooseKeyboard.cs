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
    public partial class ChooseKeyboard : Form
    {
        public int KeyboardIndex { get; set; }
        public ChooseKeyboard(Main owner)
        {
            InitializeComponent();
            KeyboardList.DataSource = owner.conTextEdit1.KeyboardIdentifiers;
        }

        public DialogResult ShowDialog(Main owner)
        {
            return this.ShowDialog();
        }

        private void KeyboardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyboardIndex = KeyboardList.SelectedIndex;
        }
    }
}
