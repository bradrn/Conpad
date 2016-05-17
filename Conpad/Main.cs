using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using RTF;

namespace Conpad
{
    public partial class Main : Form
    {
        Timer t = new Timer();
        public BindingList<WordInfo> Words = new BindingList<WordInfo>();
        List<WordRange> WordRanges = new List<WordRange>();
        string defaultFont = "";
        string BeforeText = "";
        #region string ipaKeyboard = @"...
        string ipaKeyboard = @"<_\\G>ʛ
<_\\J>ʄ
\\\>>ʡ
`\\r>ɻ
\\!>ǃ
\\&>ɶ
\\?>ʕ
\\@>ɘ
\\|>ǀ
\\<>ʢ
\\=>ǂ
\\3>ɞ
\\B>ʙ
\\G>ɢ
\\H>ʜ
\\h>ɦ
\\J>ɟ
\\j>ʝ
\\K>ɮ
\\L>ʟ
\\l>ɺ
\\N>ɴ
\\O>ʘ
\\p>ɸ
\\R>ʀ
\\r>ɹ
\\s>ɕ
\\u>ʉ
\\X>ħ
\\z>ʑ
<_b>ɓ
<_d>ɗ
<_g>ɠ
`d>ɖ
`l>ɭ
`n>ɳ
`r>ɽ
`s>ʂ
`t>ʈ
`z>ʐ
&>æ
?>ʔ
@>ə
1>ɨ
2>ø
3>ɜ
4>ɾ
6>ɐ
7>ɤ
8>ɵ
9>œ
A>ɑ
B>β
C>ç
D>ð
E>ɛ
F>ɱ
G>ɣ
H>ɥ
I>ɪ
J>ɲ
K>ɬ
L>ʎ
M>ɯ
\\M>ɰ
N>ŋ
O>ɔ
P>ʋ
Q>ɒ
R>ʁ
S>ʃ
T>θ
U>ʊ
V>ʌ
W>ʍ
X>χ
Y>ʏ
Z>ʒ
w_>ʷ
j_>ʲ
ʕ_>ˤ
_>͡
=>̩
:>ː";
        #endregion
        string curOpenFile = "";
        bool changesSaved = true;

        DictionaryForm dictionaryForm;
        AddModifyKeyboardForm addModifyKeyboardForm;
        InsertTableForm insertTableForm;

        public Main()
        {
            InitializeComponent();

            dictionaryForm = new DictionaryForm(this);
            addModifyKeyboardForm = new AddModifyKeyboardForm();
            insertTableForm = new InsertTableForm();

            foreach (FontFamily font in FontFamily.Families)
            {
                Fonts.Items.Add(font.Name);
            }

            conTextEdit1.Font = new Font(Fonts.Text, 12, FontStyle.Regular);
            
            if (FontFamily.Families.Any(f => f.Name == "Segoe MDL2 Assets"))
            {
                Font assetsFont = new Font("Segoe MLD2 Assets", 9);
                Action<ToolStripButton, string> setAssetsFont =
                    (c, text) =>
                    {
                        c.Font = assetsFont;
                        c.Text = text;
                    };
                setAssetsFont(BoldButton, "\ue19b");
                setAssetsFont(ItalicButton, "\ue199");
                setAssetsFont(UnderlineButton, "\ue19a");
                setAssetsFont(ColourButton, "\ue186");
                setAssetsFont(LeftAlignmentButton, "\ue1a2");
                setAssetsFont(CentreAlignmentButton, "\ue1a1");
                setAssetsFont(RightAlignmentButton, "\ue1a0");
            }
            
            if (FontFamily.Families.Any(f => f.Name == "Calibri"))
            {
                defaultFont = "Calibri";
            }
            else if (FontFamily.Families.Any(f => f.Name == "Arial"))
            {
                defaultFont = "Arial";
            }
            else if (FontFamily.Families.Any(f => f.Name == "Segoe UI"))
            {
                defaultFont = "Segoe UI";
            }

            Fonts.Text = defaultFont;

            conTextEdit1.AddKeyboard(ConTextEdit.Parse(ipaKeyboard), "IPA Keyboard");

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                openFile(args[1]);
            }

            t.Interval = 10;
            t.Tick += (object sender, EventArgs e) =>
            {
                KeyboardStatus.Text = conTextEdit1.KeyboardInUseIdentifier;
            };
            t.Start();
        }

        public void WordChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < WordRanges.Count; i++)
            {
                WordRange wr = WordRanges[i];
                if (wr.Word == sender || (wr is DiscontinuousAffixWordRange
                                         ? (wr as DiscontinuousAffixWordRange).DiscontinuousAffix == sender
                                         : false))
                {
                    conTextEdit1.Select(wr.Start, wr.Length);
                    conTextEdit1.SelectedText = wr.ToString();
                    wr.Length = wr.ToString().Length;
                    for (int j = 0; j < WordRanges.Count; j++)
                    {
                        WordRange wr2 = WordRanges[j];
                        if (wr2.Start > wr.Start)
                        {
                            WordRanges[j].Start += (wr.Word.Word.Length - wr.Word.BeforeWord.Length);
                        }
                    }
                }
            }
        }

        private void conTextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            BeforeText = conTextEdit1.Text;
        }

        private void conTextEdit1_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (WordRange wr in WordRanges)
            {
                if (wr.Start + wr.Length > conTextEdit1.Text.Length ||
                    conTextEdit1.Text.Substring(wr.Start, wr.Length) != wr.ToString())
                {
                    wr.Start += conTextEdit1.Text.Length - BeforeText.Length;
                }
            }
        }

        private void conTextEdit1_TextChanged(object sender, EventArgs e)
        {
            if (changesSaved == true) changesSaved = false;
        }

        private void switchKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conTextEdit1.KeyboardInUse < conTextEdit1.Keyboards.Count - 1)
            {
                conTextEdit1.KeyboardInUse++;
            }
            else
            {
                conTextEdit1.KeyboardInUse = 0;
            }
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            if (conTextEdit1.SelectionFont != null)
            {
                conTextEdit1.SelectionFont = new Font(conTextEdit1.SelectionFont.Name, conTextEdit1.SelectionFont.Size,
                    conTextEdit1.SelectionFont.Style ^ FontStyle.Bold);
            }
            conTextEdit1_ManageStyles(BoldButton, EventArgs.Empty);
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            if (conTextEdit1.SelectionFont != null)
            {
                conTextEdit1.SelectionFont = new Font(conTextEdit1.SelectionFont.Name, conTextEdit1.SelectionFont.Size,
                    conTextEdit1.SelectionFont.Style ^ FontStyle.Italic);
            }
            conTextEdit1_ManageStyles(ItalicButton, EventArgs.Empty);
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            if (conTextEdit1.SelectionFont != null)
            {
                conTextEdit1.SelectionFont = new Font(conTextEdit1.SelectionFont.Name, conTextEdit1.SelectionFont.Size,
                    conTextEdit1.SelectionFont.Style ^ FontStyle.Underline);
            }
            conTextEdit1_ManageStyles(UnderlineButton, EventArgs.Empty);
        }

        private void SuperscriptButton_Click(object sender, EventArgs e)
        {
            if (conTextEdit1.SelectionFont != null)
            {
                if (conTextEdit1.SelectionCharOffset > 0) conTextEdit1.SelectionCharOffset = 0;
                else conTextEdit1.SelectionCharOffset = (int)conTextEdit1.SelectionFont.Size;
            }
            conTextEdit1_ManageStyles(SuperscriptButton, EventArgs.Empty);
        }

        private void SubscriptButton_Click(object sender, EventArgs e)
        {
            if (conTextEdit1.SelectionFont != null)
            {
                if (conTextEdit1.SelectionCharOffset < 0) conTextEdit1.SelectionCharOffset = 0;
                else conTextEdit1.SelectionCharOffset = -(int)conTextEdit1.SelectionFont.Size;
            }
            conTextEdit1_ManageStyles(SubscriptButton, EventArgs.Empty);
        }

        private void ColourButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                conTextEdit1.SelectionColor = colorDialog1.Color;
            }
            conTextEdit1_ManageStyles(ColourButton, EventArgs.Empty);
        }

        private void AlignmentButton_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton)
            {
                switch ((sender as ToolStripButton).Name)
                {
                    case "LeftAlignmentButton":
                        conTextEdit1.SelectionAlignment = HorizontalAlignment.Left;
                        break;
                    case "CentreAlignmentButton":
                        conTextEdit1.SelectionAlignment = HorizontalAlignment.Center;
                        break;
                    case "RightAlignmentButton":
                        conTextEdit1.SelectionAlignment = HorizontalAlignment.Right;
                        break;
                }
            }
            conTextEdit1_ManageStyles(null, EventArgs.Empty);
        }

        private void conTextEdit1_ManageStyles(object sender, EventArgs e)
        {
            if (conTextEdit1.SelectionFont != null)
            {
                BoldButton.Checked = conTextEdit1.SelectionFont.Bold;
                ItalicButton.Checked = conTextEdit1.SelectionFont.Italic;
                UnderlineButton.Checked = conTextEdit1.SelectionFont.Underline;
                FontSize.Text = conTextEdit1.SelectionFont.Size.ToString();
                Fonts.Text = conTextEdit1.SelectionFont.Name;
            }
            else
            {
                BoldButton.Checked = false;
                ItalicButton.Checked = false;
                UnderlineButton.Checked = false;
                Fonts.Text = "";
            }
            SuperscriptButton.Checked = conTextEdit1.SelectionCharOffset > 0;
            SubscriptButton.Checked = conTextEdit1.SelectionCharOffset < 0;
            
            switch (conTextEdit1.SelectionAlignment)
            {
                case HorizontalAlignment.Left:
                    LeftAlignmentButton.Checked = true;
                    CentreAlignmentButton.Checked = false;
                    RightAlignmentButton.Checked = false;
                    break;
                case HorizontalAlignment.Center:
                    LeftAlignmentButton.Checked = false;
                    CentreAlignmentButton.Checked = true;
                    RightAlignmentButton.Checked = false;
                    break;
                case HorizontalAlignment.Right:
                    LeftAlignmentButton.Checked = false;
                    CentreAlignmentButton.Checked = false;
                    RightAlignmentButton.Checked = true;
                    break;
            }

            ColourButton.ForeColor = conTextEdit1.SelectionColor;
            ColourButton.BackColor = Color.FromArgb(255 - ColourButton.ForeColor.R, 255 - ColourButton.ForeColor.G,
                                                    255 - ColourButton.ForeColor.B);
            if (ColourButton.BackColor.R < 128 && ColourButton.BackColor.G < 128 && ColourButton.BackColor.B < 128)
            {
                ColourButton.BackColor = Color.Black;
            }
            else
            {
                ColourButton.BackColor = SystemColors.Control;
            }
        }

        private void Fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            conTextEdit1.SelectionFont = new Font(Fonts.Text, conTextEdit1.SelectionFont.Size, conTextEdit1.SelectionFont.Style);
        }

        private void FontSize_Validating(object sender, CancelEventArgs e)
        {
            float result = 0;
            if (!float.TryParse(FontSize.Text, out result))
            {
                e.Cancel = true;
            }
            else
            {
                if (conTextEdit1.SelectionFont != null)
                {
                    conTextEdit1.SelectionFont = new Font(conTextEdit1.SelectionFont.Name, result, conTextEdit1.SelectionFont.Style);
                }
            }
        }

        private void addKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addModifyKeyboardForm.Show(this);
        }

        private void modifyExistingKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChooseKeyboard chooseKeyboardForm = new ChooseKeyboard(this))
            {
                if (chooseKeyboardForm.ShowDialog() == DialogResult.OK)
                {
                    addModifyKeyboardForm.Show(this, conTextEdit1.Keyboards[chooseKeyboardForm.KeyboardIndex],
                                               conTextEdit1.KeyboardIdentifiers[chooseKeyboardForm.KeyboardIndex]);
                }
            }
        }

        private void AddWords_Click(object sender, EventArgs e)
        {
            using (AddWordsForm addWordsForm = new AddWordsForm(this))
            {
                if (addWordsForm.ShowDialog(this) == DialogResult.OK)
                {
                    foreach (WordRange wr in addWordsForm.Result.Item1)
                    {
                        WordRange wr2 = wr;
                        wr2.Start += conTextEdit1.SelectionStart;
                        WordRanges.Add(wr2);
                    }
                    conTextEdit1.Text += addWordsForm.Result.Item2;
                }
            }
        }

        private void showDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!dictionaryForm.Visible)
            {
                dictionaryForm.Show(Words);
            }
        }

        private void AddRow(RTFBuilderbase rb, string[] cellContents, int width = 88)
        {
            Padding p = new Padding { All = 50 };
            RTFRowDefinition rd = new RTFRowDefinition(88, RTFAlignment.TopLeft, RTFBorderSide.Default, 15, SystemColors.WindowText, p);
            RTFCellDefinition[] cds = new RTFCellDefinition[cellContents.Length];
            for (int i = 0; i < cellContents.Length; i++)
            {
                cds[i] = new RTFCellDefinition(width / cellContents.Length, RTFAlignment.TopLeft, RTFBorderSide.Default, 5, Color.Black, Padding.Empty);
            }
            int pos = 0;
            foreach (RTFBuilderbase item in rb.EnumerateCells(rd, cds))
            {
                item.Append(cellContents[pos++]);
            }
        }

        private void insertTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (insertTableForm.ShowDialog() == DialogResult.OK)
            {
                RTFBuilderbase rb = new RTFBuilder();
                rb.AppendRTFDocument(conTextEdit1.Rtf);
                if (conTextEdit1.Text != "") rb.AppendPara();
                for (int i = 0; i < insertTableForm.NumRows; i++)
                {
                    AddRow(rb, Enumerable.Repeat("", insertTableForm.NumCols).ToArray());
                }
                conTextEdit1.Rtf = rb.ToString();
            }
        }

        private void AddImage(Image image)
        {
            RTFBuilderbase rb = new RTFBuilder();
            rb.AppendRTFDocument(conTextEdit1.Rtf);
            rb.InsertImage(image);
            conTextEdit1.Rtf = rb.ToString();
        }

        private void insertImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                AddImage(Image.FromFile(openImageDialog.FileName));
            }
        }

        private void bulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conTextEdit1.SelectionBullet = !conTextEdit1.SelectionBullet;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (curOpenFile == "") saveAsToolStripMenuItem_Click(this, EventArgs.Empty);
            else
            {
                SaveFile(curOpenFile);
            }
        }

        public void SaveFile(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(":WORDS:");
                foreach (WordInfo wi in Words)
                {
                    sw.WriteLine("W:" + wi.ID + "," + wi.Word + "," + wi.Gloss + "," + (int)wi.Type);
                    if (wi is DiscontinuousAffixWordInfo)
                    {
                        DiscontinuousAffixWordInfo dawi = wi as DiscontinuousAffixWordInfo;
                        sw.WriteLine("d:" + (int)dawi.Position);
                        foreach (KeyValuePair<char, string> cat in dawi.Categories)
                        {
                            sw.WriteLine("c:" + cat.Key + "=" + cat.Value);
                        }
                    }

                    foreach (string definition in wi.Definitions)
                    {
                        sw.WriteLine(definition);
                    }
                }
                sw.WriteLine(":WORDRANGES:");
                foreach (WordRange wr in WordRanges)
                {
                    sw.WriteLine(wr.Start + "," + wr.Length + "," + (int)wr.Case + "," + wr.Word.ID);
                    if (wr is DiscontinuousAffixWordRange)
                    {
                        DiscontinuousAffixWordRange dawr = wr as DiscontinuousAffixWordRange;
                        sw.WriteLine("d:" + dawr.DiscontinuousAffix.ID);
                    }
                }
                sw.WriteLine(":RTF:");
                sw.Write(conTextEdit1.Rtf);
                curOpenFile = fileName;
                this.Text = "Conpad - " + curOpenFile;
                changesSaved = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFile(openFileDialog1.FileName);
            }
        }

        private void openFile(string fileName)
        {
            List<WordInfo> words = new List<WordInfo>();
            List<WordRange> wordRanges = new List<WordRange>();
            string rtf = "";
            using (StreamReader sr = new StreamReader(fileName))
            {
                string state = "";
                WordInfo curWord = new WordInfo("", -1, new BindingList<string>(), "", WordClass.Noun, WordChanged);
                WordRange curWordRange =
                    new WordRange(-1, -1, new WordInfo("", -1, new BindingList<string>(), "", WordClass.Noun, WordChanged));
                List<string> curDefs = new List<string>();
                bool addNewWord = false;
                bool addNewRange = false;
                bool isWordDisc = false;
                string discWordCats = "";
                while (sr.Peek() > -1)
                {
                    string line = "";
                    if (state != ":RTF:") line = sr.ReadLine();
                    if (line.Length > 1 && line[0] == ':' && line[line.Length - 1] == ':')
                    {
                        state = line;
                        continue;
                    }
                    if (state == ":RTF:")
                    {
                        if (addNewRange)
                        {
                            wordRanges.Add(curWordRange);
                        }
                        rtf = sr.ReadToEnd();
                        continue;
                    }
                    else
                    {
                        using (StringReader str = new StringReader(line))
                        {
                            switch (state)
                            {
                                case ":WORDS:":
                                    char[] buffer = new char[2];
                                    str.ReadBlock(buffer, 0, 2);
                                    switch (new string(buffer))
                                    {
                                        case "W:":
                                            if (addNewWord)
                                            {
                                                curWord.Definitions = new BindingList<string>(curDefs);
                                                if (isWordDisc)
                                                {
                                                    (curWord as DiscontinuousAffixWordInfo).Categories =
                                                        DiscontinuousAffixWordInfo.ParseCategories(discWordCats);
                                                }
                                                discWordCats = ""; isWordDisc = false;
                                                words.Add(curWord);
                                            }
                                            addNewWord = true;
                                            string[] data = str.ReadToEnd().Split(',');
                                            if (data.Length != 4)
                                            {
                                                if (FileNotEncodedCorrectlyShow() == DialogResult.Yes)
                                                {
                                                    openToolStripMenuItem_Click(this, EventArgs.Empty);
                                                }
                                                return;
                                            }
                                            int id = -1;
                                            if (!openToolStripMenuItem_ParseInt(data[0], out id))
                                            {
                                                if (FileNotEncodedCorrectlyShow() == DialogResult.Yes)
                                                {
                                                    openToolStripMenuItem_Click(this, EventArgs.Empty);
                                                }
                                                return;
                                            }
                                            string word = data[1];
                                            string gloss = data[2];
                                            int _type = -1;
                                            if (!openToolStripMenuItem_ParseInt(data[3], out _type))
                                            {
                                                if (FileNotEncodedCorrectlyShow() == DialogResult.Yes)
                                                {
                                                    openToolStripMenuItem_Click(this, EventArgs.Empty);
                                                }
                                                return;
                                            }
                                            WordClass type = (WordClass)_type;
                                            curWord = new WordInfo(word, id, new BindingList<string>(), gloss, type, WordChanged);
                                            curDefs = new List<string>();
                                            break;
                                        case "d:":
                                            isWordDisc = true;
                                            curWord = new DiscontinuousAffixWordInfo(curWord.Word, curWord.ID, curWord.Definitions,
                                                curWord.Gloss, curWord.Type, WordChanged, new Dictionary<char, string>(),
                                                DiscontinuousAffixPosition.First);
                                            int _position = -1;
                                            if (!openToolStripMenuItem_ParseInt(str.ReadToEnd(), out _position))
                                            {
                                                if (FileNotEncodedCorrectlyShow() == DialogResult.Yes)
                                                {
                                                    openToolStripMenuItem_Click(this, EventArgs.Empty);
                                                }
                                                return;
                                            }
                                            DiscontinuousAffixPosition position = (DiscontinuousAffixPosition)_position;
                                            (curWord as DiscontinuousAffixWordInfo).Position = position;
                                            break;
                                        case "c:":
                                            discWordCats += str.ReadToEnd() + Environment.NewLine;
                                            break;
                                        default:
                                            curDefs.Add(line);
                                            break;
                                    }
                                    break;
                                case ":WORDRANGES:":
                                    if (addNewWord)
                                    {
                                        addNewWord = false;
                                        curWord.Definitions = new BindingList<string>(curDefs);
                                        if (isWordDisc)
                                        {
                                            (curWord as DiscontinuousAffixWordInfo).Categories =
                                                DiscontinuousAffixWordInfo.ParseCategories(discWordCats);
                                        }
                                        discWordCats = ""; isWordDisc = false;
                                        words.Add(curWord);
                                    }

                                    if (addNewRange)
                                    {
                                        wordRanges.Add(curWordRange);
                                    }
                                    addNewRange = true;
                                    char[] buffer2 = new char[2];
                                    str.ReadBlock(buffer2, 0, 2);
                                    if (new string(buffer2) == "d:")
                                    {
                                        int daid = -1;
                                        if (!openToolStripMenuItem_ParseInt(str.ReadToEnd(), out daid)) return;
                                        curWordRange = new DiscontinuousAffixWordRange(curWordRange.Start, curWordRange.Length,
                                            curWordRange.Word, words.Where(wi => wi is DiscontinuousAffixWordInfo)
                                                                    .Select(wi => wi as DiscontinuousAffixWordInfo)
                                                                    .Where(wi => wi.ID == daid).First(), curWordRange.Case);
                                    }
                                    else
                                    {
                                        string[] data2 = line.Split(',');
                                        if (data2.Length != 4)
                                        {
                                            if (FileNotEncodedCorrectlyShow() == DialogResult.Yes)
                                            {
                                                openToolStripMenuItem_Click(this, EventArgs.Empty);
                                            }
                                            return;
                                        }
                                        int start = -1;
                                        if (!openToolStripMenuItem_ParseInt(data2[0], out start))
                                        {
                                            if (FileNotEncodedCorrectlyShow() == DialogResult.Yes)
                                            {
                                                openToolStripMenuItem_Click(this, EventArgs.Empty);
                                            }
                                            return;
                                        }
                                        int length = -1;
                                        if (!openToolStripMenuItem_ParseInt(data2[1], out length))
                                        {
                                            if (FileNotEncodedCorrectlyShow() == DialogResult.Yes)
                                            {
                                                openToolStripMenuItem_Click(this, EventArgs.Empty);
                                            }
                                            return;
                                        }
                                        int _case = -1;
                                        if (!openToolStripMenuItem_ParseInt(data2[2], out _case))
                                        {
                                            if (FileNotEncodedCorrectlyShow() == DialogResult.Yes)
                                            {
                                                openToolStripMenuItem_Click(this, EventArgs.Empty);
                                            }
                                            return;
                                        }
                                        WordCase @case = (WordCase)_case;
                                        int id2 = -1;
                                        if (!openToolStripMenuItem_ParseInt(data2[3], out id2))
                                        {
                                            if (FileNotEncodedCorrectlyShow() == DialogResult.Yes)
                                            {
                                                openToolStripMenuItem_Click(this, EventArgs.Empty);
                                            }
                                            return;
                                        }
                                        curWordRange = new WordRange(start, length, words.Where(wi => wi.ID == id2).First(), @case);
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            Words = new BindingList<WordInfo>(words);
            WordRanges = wordRanges;
            conTextEdit1.Rtf = rtf;
            curOpenFile = fileName;
            this.Text = "Conpad - " + curOpenFile;
            changesSaved = true;
        }

        private DialogResult FileNotEncodedCorrectlyShow()
        {
            return MessageBox.Show("This file is not encoded correctly. Do you want to select another file?", "", MessageBoxButtons.YesNo);
        }

        private bool openToolStripMenuItem_ParseInt(string input, out int result)
        {
            if (int.TryParse(input, out result))
            {
                return true;
            }
            else
            {
                if (FileNotEncodedCorrectlyShow() == DialogResult.Yes)
                {
                    openToolStripMenuItem_Click(this, EventArgs.Empty);
                }
                return false;
            }
        }

        private void removeWordRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WordRanges.Any(wr => (wr.Start <= conTextEdit1.SelectionStart) && (conTextEdit1.SelectionStart <= wr.Start + wr.Length)))
            {
                for (int i = 0; i < WordRanges.Count; i++)
                {
                    if ((WordRanges[i].Start <= conTextEdit1.SelectionStart)
                     && (conTextEdit1.SelectionStart <= WordRanges[i].Start + WordRanges[i].Length))
                    {
                        WordRanges.RemoveAt(i);
                    }
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!changesSaved)
            {
                DialogResult result =
                    MessageBox.Show("Do you want to save changes to " + (curOpenFile == "" ? "Untitled" : curOpenFile) + "?", "Conpad",
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, EventArgs.Empty);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            curOpenFile = "";
            conTextEdit1.Text = "";
            Fonts.Text = defaultFont;
            changesSaved = true;
        }

        private void saveKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChooseKeyboard chooseKeyboardForm = new ChooseKeyboard(this))
            {
                if (chooseKeyboardForm.ShowDialog() == DialogResult.OK)
                {
                    if (saveKeyboardFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(saveKeyboardFileDialog.FileName))
                        {
                            sw.WriteLine(conTextEdit1.KeyboardIdentifiers[chooseKeyboardForm.KeyboardIndex]);
                            sw.Write(ConTextEdit.Deparse(conTextEdit1.Keyboards[chooseKeyboardForm.KeyboardIndex]));
                        }
                    }
                }
            }
        }

        private void loadKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openKeyboardFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openKeyboardFileDialog.FileName))
                {
                    string name = sr.ReadLine();
                    string keyboard = sr.ReadToEnd();
                    conTextEdit1.AddKeyboard(ConTextEdit.Parse(keyboard), name);
                }
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (importDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(importDialog.FileName))
                {
                    switch (Path.GetExtension(importDialog.FileName))
                    {
                        case ".rtf":
                            conTextEdit1.Rtf = sr.ReadToEnd();
                            break;
                        case ".txt":
                            conTextEdit1.Text = sr.ReadToEnd();
                            break;
                    }
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(exportDialog.FileName))
                {
                    switch (Path.GetExtension(exportDialog.FileName))
                    {
                        case ".rtf":
                            sw.Write(conTextEdit1.Rtf);
                            break;
                        case ".txt":
                            sw.Write(conTextEdit1.Text);
                            break;
                        case ".html":
                            sw.Write(ConvertRtfToHtml(conTextEdit1.Rtf));
                            break;
                    }
                }
            }
        }

        private string ConvertRtfToHtml(string rtfText)
        {
            System.Windows.Controls.RichTextBox richTextBox = new System.Windows.Controls.RichTextBox();
            if (string.IsNullOrEmpty(rtfText)) return "";
            System.Windows.Documents.TextRange textRange =
                new System.Windows.Documents.TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            using (MemoryStream rtfMemoryStream = new MemoryStream())
            {
                using (StreamWriter rtfStreamWriter = new StreamWriter(rtfMemoryStream))
                {
                    rtfStreamWriter.Write(rtfText);
                    rtfStreamWriter.Flush();
                    rtfMemoryStream.Seek(0, SeekOrigin.Begin);
                    textRange.Load(rtfMemoryStream, DataFormats.Rtf);
                }
            }
            string HTML;
            using (MemoryStream rtfMemoryStream = new MemoryStream())
            {
                textRange = new System.Windows.Documents.TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                textRange.Save(rtfMemoryStream, System.Windows.DataFormats.Xaml);
                rtfMemoryStream.Seek(0, SeekOrigin.Begin);
                using (StreamReader rtfStreamReader = new StreamReader(rtfMemoryStream))
                {
                    System.Xml.XmlDocument xaml = new System.Xml.XmlDocument();
                    xaml.LoadXml(rtfStreamReader.ReadToEnd());
                    string innerxaml = xaml.DocumentElement.InnerXml;
                    HTML = HTMLConverter.HtmlFromXamlConverter.ConvertXamlToHtml("<FlowDocument>" + innerxaml + "</FlowDocument>");
                }
            }

            XElement xHTML = XElement.Parse(HTML);
            xHTML.Add(new XElement("HEAD", new XElement("TITLE", curOpenFile)));

            return xHTML.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!changesSaved)
            {
                DialogResult result =
                    MessageBox.Show("Do you want to save changes to " + (curOpenFile == "" ? "Untitled" : curOpenFile) + "?", "Conpad",
                    MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, EventArgs.Empty);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

            dictionaryForm.Dispose();
            addModifyKeyboardForm.Dispose();
        }

        private void exportDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(exportDialog.FileName) == ".txt")
                {
                    int maxWordLength = Words.Select(wi => wi.Word.Length).Max();
                    int maxTypeLength = Words.Select(wi => wi.Type.ToString().Length).Max();
                    int maxDefinitionLength = Words.Select(wi => string.Join(",", wi.Definitions).Length).Max();
                    string formatString = "{0,-" + maxWordLength + "}   {1,-" + maxTypeLength + "}   {2,-" + maxDefinitionLength + "}";
                    using (StreamWriter sw = new StreamWriter(exportDialog.FileName))
                    {
                        foreach (WordInfo wi in Words)
                        {
                            sw.WriteLine(formatString, wi.Word, wi.Type.ToString(), string.Join(",", wi.Definitions));
                        }
                    }
                }
                else
                {
                    RTFBuilderbase rb = new RTFBuilder();
                    foreach (WordInfo wi in Words)
                    {
                        AddRow(rb, new string[] { wi.Word, wi.Type.ToString(), string.Join(",", wi.Definitions) });
                    }
                    string rtf = rb.ToString();
                    switch (Path.GetExtension(exportDialog.FileName))
                    {
                        case ".rtf":
                            using (StreamWriter sw = new StreamWriter(exportDialog.FileName))
                            {
                                sw.Write(rtf);
                            }
                            break;
                        case ".html":
                            using (StreamWriter sw = new StreamWriter(exportDialog.FileName))
                            {
                                sw.Write(ConvertRtfToHtml(rtf));
                            }
                            break;
                    }
                }
            }
        }
    }
}