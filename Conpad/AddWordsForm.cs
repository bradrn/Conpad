using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conpad
{
    public partial class AddWordsForm : Form
    {
        FastColoredTextBoxNS.AutocompleteMenu menu;
        public new Main Owner { get; set; }
        public Tuple<BindingList<WordRange>, string> Result { get; set; }

        public AddWordsForm(Main owner)
        {
            InitializeComponent();
            Owner = owner;
            menu = new FastColoredTextBoxNS.AutocompleteMenu(Morphemes);
            menu.MinFragmentLength = 1;
            menu.Items.MaximumSize = new System.Drawing.Size(200, 300);
            menu.Items.Width = 200;
        }

        public new DialogResult ShowDialog()
        {
            menu.Items.SetAutocompleteItems(Owner.Words.Select(w => w.Gloss).ToList());
            return base.ShowDialog();
        }

        private void Morphemes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyData == Keys.Space)
            {
                menu.Show();
                e.Handled = true;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string[][] morphemes = Morphemes.Text.Split(' ').Select(word => word.Split('-')).ToArray();

            string result = "";
            BindingList<WordRange> wordRanges = new BindingList<WordRange>();
            int i = 0;
            int wordCounter = 0;
            bool first = true;

            WordCase @case;
            if (UPPERCASEOption.Checked) @case = WordCase.UPPERCASE;
            else if (SentencecaseOption.Checked) @case = WordCase.Sentencecase;
            else @case = WordCase.lowercase;

            foreach (string[] word in morphemes)
            {
                foreach (string morpheme in word)
                {
                    Match m = Regex.Match(morpheme, "(.*)<(.+)>(.*)");
                    if (m.Success)
                    {
                        string stem = m.Groups[1].Value + m.Groups[3].Value;
                        string da = m.Groups[2].Value;
                        WordInfo wordWordInfo;
                        if (Owner.Words.Any(w => w.Gloss == stem))
                        {
                            wordWordInfo = Owner.Words.Where(w => w.Gloss == stem).First();
                        }
                        else
                        {
                            MessageBox.Show($"{stem} is not a word", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        DiscontinuousAffixWordInfo daWordInfo;
                        if (Owner.Words.Any(w => w.Gloss == da))
                        {
                            daWordInfo = Owner.Words.Where(w => w.Gloss == da).First() as DiscontinuousAffixWordInfo;
                            if (daWordInfo == null)
                            {
                                MessageBox.Show($"{da} is not a discontinuous affix", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"{da} is not a discontinuous affix", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        DiscontinuousAffixWordRange dawr = new DiscontinuousAffixWordRange(i, -1, wordWordInfo, daWordInfo, @case);
                        dawr.Length = dawr.ToString().Length;

                        if (first && @case == WordCase.Sentencecase)
                        {
                            @case = WordCase.lowercase;
                        }

                        result += dawr.ToString();
                        wordRanges.Add(dawr);
                        i += dawr.ToString().Length;
                    }
                    else if (Owner.Words.Any(w => w.Gloss == morpheme))
                    {
                        WordInfo foundWord = Owner.Words.Where(w => w.Gloss == morpheme).First();
                        WordRange wr = new WordRange(i, foundWord.Word.Length, foundWord, @case);

                        if (first && @case == WordCase.Sentencecase)
                        {
                            @case = WordCase.lowercase;
                        }

                        result += wr.ToString();
                        wordRanges.Add(wr);
                        i += wr.ToString().Length;
                    }
                    else
                    {
                        MessageBox.Show($"{morpheme} is not a morpheme", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (wordCounter < morphemes.Count() - 1) result += " ";
                i++;
                wordCounter++;
            }

            Result = Tuple.Create(wordRanges, result);
            DialogResult = DialogResult.OK;
        }
    }
}
