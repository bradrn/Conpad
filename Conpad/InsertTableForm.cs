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
    public partial class InsertTableForm : Form
    {
        public int NumRows { get; private set; }
        public int NumCols { get; private set; }

        public InsertTableForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            NumRows = (int)Rows.Value;
            NumCols = (int)Columns.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
