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
    public partial class AddDiscontinuousAffixForm : Form
    {
        public Tuple<string, string, DiscontinuousAffixPosition> Result { get; set; }

        public AddDiscontinuousAffixForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DiscontinuousAffixPosition position = DiscontinuousAffixPosition.First;
            if (Enum.TryParse(Position.Text, out position))
            {
                Result = Tuple.Create(Affix.Text, Categories.Text, position);
            }
            DialogResult = DialogResult.OK;
        }
    }
}
