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
    public partial class DictionaryForm : Form
    {
        public BindingList<WordInfo> WordList { get; set; }
        //public string BeforeWord { get; set; }
        public new Main Owner { get; set; }

        private bool fire = true;
        private AddDiscontinuousAffixForm addDiscontinuousAffixForm = new AddDiscontinuousAffixForm();


        public DictionaryForm(Main owner)
        {
            InitializeComponent();
            Owner = owner;
            //BeforeWord = "";
        }

        public void Show(BindingList<WordInfo> words)
        {
            WordList = words;
            Words.DataSource = WordList;
            Show();
        }

        private void AddWord_Click(object sender, EventArgs e)
        {
            string word = "";
            if (InputBox.Show("", "", "", Owner.conTextEdit1, out word) == DialogResult.OK)
            {
                int count = WordList.Count;
                WordList.Add(new WordInfo(word, getID(), new BindingList<string>(), "", WordClass.Noun, Owner.WordChanged));
                Words.SelectedIndex = WordList.Count - 1;
                if (count == 0)
                {
                    Words_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }
        }

        private void AddDiscontinuousAffix_Click(object sender, EventArgs e)
        {
            if (addDiscontinuousAffixForm.ShowDialog() == DialogResult.OK)
            {
                WordList.Add(new DiscontinuousAffixWordInfo(addDiscontinuousAffixForm.Result.Item1, getID(), new BindingList<string>(), "",
                              WordClass.Noun, Owner.WordChanged, DiscontinuousAffixWordInfo.ParseCategories(addDiscontinuousAffixForm.Result.Item2),
                              addDiscontinuousAffixForm.Result.Item3));
            }
        }

        private int getID()
        {
            return WordList.Select(w => w.ID).DefaultIfEmpty(0).Max() + 1;
        }

        private void RemoveWord_Click(object sender, EventArgs e)
        {
            if (WordList.Count > 0 && Words.SelectedIndex != -1)
            {
                WordList.RemoveAt(Words.SelectedIndex);
            }
        }

        private void Words_SelectedIndexChanged(object sender, EventArgs e)
        {
            WordInfo word = WordList[Words.SelectedIndex];

            fire = false;
            Word.Text = word.Word;
            Gloss.Text = word.Gloss;
            Type.SelectedItem = word.Type.ToString();
            Definitions.DataSource = word.Definitions;
            Definitions.SelectedIndex = -1;
            CurrentDefinition.Text = "";

            bool isDAffix = word is DiscontinuousAffixWordInfo;
            CategoriesLabel.Enabled = isDAffix;
            Categories.Enabled = isDAffix;
            if (isDAffix) Categories.Text = DiscontinuousAffixWordInfo.DeparseCategories((word as DiscontinuousAffixWordInfo).Categories);
            else Categories.Text = "";
            fire = true;
        }
        
        private void Definitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentDefinition.Text = (Definitions.SelectedIndex == -1 ? "" :
                                      WordList[Words.SelectedIndex].Definitions[Definitions.SelectedIndex]);
            CurrentDefinition.Enabled = (Definitions.SelectedIndex != -1);
        }

        private void Word_TextChanged(object sender, EventArgs e)
        {
            if (fire && Words.SelectedIndex != -1)
            {
                WordList[Words.SelectedIndex].Word = Word.Text;
                WordList.ResetBindings();
            }
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            WordClass result;
            if (Enum.TryParse<WordClass>(Type.Items[Type.SelectedIndex].ToString(), out result))
            {
                WordList[Words.SelectedIndex].Type = result;
                WordList.ResetBindings();
            }
        }

        /*private void Word_KeyDown(object sender, KeyEventArgs e)
        {
            BeforeWord = Word.Text;
        }*/

        private void Gloss_TextChanged(object sender, EventArgs e)
        {
            if (fire && Words.SelectedIndex != -1)
            {
                WordList[Words.SelectedIndex].Gloss = Gloss.Text;
            }
        }

        private void AddDefinition_Click(object sender, EventArgs e)
        {
            string definition = "";
            if (InputBox.Show("", "", "", Owner.conTextEdit1, out definition) == DialogResult.OK)
            {
                BindingList<string> definitions = WordList[Words.SelectedIndex].Definitions;
                definitions.Add(definition);
                definitions.ResetBindings();
            }
        }

        private void CurrentDefinition_TextChanged(object sender, EventArgs e)
        {
            if (Definitions.SelectedIndex != -1)
            {
                int cursorPosition = CurrentDefinition.SelectionStart;
                BindingList<string> definitions = WordList[Words.SelectedIndex].Definitions;
                definitions[Definitions.SelectedIndex] = CurrentDefinition.Text;
                definitions.ResetBindings();
                CurrentDefinition.SelectionStart = cursorPosition;
                CurrentDefinition.Focus();
            }
        }

        private void RemoveDefinition_Click(object sender, EventArgs e)
        {
            BindingList<string> definitions = WordList[Words.SelectedIndex].Definitions;
            definitions.RemoveAt(Definitions.SelectedIndex);
            definitions.ResetBindings();
        }

        private void DictionaryForm_Deactivate(object sender, EventArgs e)
        {
            Owner.Words = WordList;
        }

        private void DictionaryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


        private void Categories_TextChanged(object sender, EventArgs e)
        {
            if (fire && Words.SelectedIndex != -1)
            {
                (WordList[Words.SelectedIndex] as DiscontinuousAffixWordInfo).Categories =
                    DiscontinuousAffixWordInfo.ParseCategories(Categories.Text);
            }
        }
    }
}
