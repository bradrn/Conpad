using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Conpad
{
    public delegate void WordChangedEventHandler(object sender, EventArgs e);
    public delegate void GlossChangedEventHandler(object sender, EventArgs e);

    public class WordInfo
    {
        public WordInfo(string word, int ID, BindingList<string> definitions, string gloss, WordClass type)
        {
            Word = word;
            Definitions = definitions;
            Gloss = gloss;
            Type = type;
            this.ID = ID;
        }

        public WordInfo(string word, int ID, BindingList<string> definitions, string gloss, WordClass type, WordChangedEventHandler wh)
            : this(word, ID, definitions, gloss, type)
        {
            WordChanged += wh;
        }

        public event WordChangedEventHandler WordChanged;
        protected virtual void OnWordChanged(EventArgs e)
        {
            WordChanged?.Invoke(this, e);
        }

        public event GlossChangedEventHandler GlossChanged;
        protected virtual void OnGlossChanged(EventArgs e)
        {
            GlossChanged?.Invoke(this, e);
        }

        public int ID { get; private set; }
        public string BeforeWord { get; private set; }

        private string _Word;
        public string Word
        {
            get
            {
                return _Word;
            }
            set
            {
                BeforeWord = _Word;
                _Word = value;
                OnWordChanged(EventArgs.Empty);
            }
        }

        public BindingList<string> Definitions { get; set; }
        private string _Gloss;
        public string Gloss
        {
            get
            {
                return _Gloss;
            }
            set
            {
                _Gloss = value;
                OnGlossChanged(EventArgs.Empty);
            }
        }

        public WordClass Type { get; set; }

        public override string ToString()
        {
            if (Type == WordClass.Affix) return $"({Word})";
            else return Word;
        }
    }

    public class DiscontinuousAffixWordInfo : WordInfo
    {
        public DiscontinuousAffixWordInfo(string word, int ID, BindingList<string> definitions, string gloss, WordClass type,
                                          Dictionary<char, string> categories, DiscontinuousAffixPosition position)
            : base(word, ID, definitions, gloss, type)
        {
            Categories = categories;
            Position = position;
        }

        public DiscontinuousAffixWordInfo(string word, int ID, BindingList<string> definitions, string gloss, WordClass type,
                                          WordChangedEventHandler wh, Dictionary<char, string> categories,
                                          DiscontinuousAffixPosition position)
            : base(word, ID, definitions, gloss, type, wh)
        {
            Categories = categories;
            Position = position;
        }

        public Dictionary<char, string> Categories { get; set; }
        public DiscontinuousAffixPosition Position { get; set; }

        public override string ToString()
        {
            string result = "";
            foreach (char c in Word)
            {
                if (Categories.ContainsKey(c))
                {
                    result += '-';
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        public static Dictionary<char, string> ParseCategories(string categories)
        {
            Dictionary<char, string> cats = new Dictionary<char, string>();
            MatchCollection mc = Regex.Matches(categories, "^(.)=(.+)$", RegexOptions.Multiline);
            foreach (Match m in mc)
            {
                cats[m.Groups[1].Value[0]] = "";
                foreach (char c in m.Groups[2].Value)
                {
                    if (cats.ContainsKey(c)) cats[m.Groups[1].Value[0]] += cats[c];
                    else cats[m.Groups[1].Value[0]] += c;
                }
            }
            return cats;
        }

        public static string DeparseCategories(Dictionary<char, string> categories)
        {
            if (categories == null) return "";

            string cats = "";

            foreach (KeyValuePair<char, string> cat in categories)
            {
                cats += Environment.NewLine + cat.Key + "=" + cat.Value;
            }
            cats = cats.Remove(0, Environment.NewLine.Length);

            return cats;
        }
    }

    public enum DiscontinuousAffixPosition
    {
        First,
        Last,
    }

    public class WordRange
    {
        public WordRange(int start, int length, WordInfo word, WordCase @case = WordCase.lowercase)
        {
            Start = start;
            Length = length;
            Word = word;
            Case = @case;
        }
        public int Start { get; set; }
        public int Length { get; set; }
        public WordInfo Word { get; set; }
        public WordCase Case { get; set; }

        public override string ToString()
        {
            switch (Case)
            {
                case WordCase.Sentencecase:
                    string result = Word.Word;
                    if (result.Length == 0) return "";
                    else if (result.Length == 1) return char.ToUpper(result[0]).ToString();
                    else return char.ToUpper(result[0]) + result.Substring(1);
                case WordCase.UPPERCASE:
                    return Word.Word.ToUpper();
                default:
                    return Word.Word;
            }
        }
    }

    public class DiscontinuousAffixWordRange : WordRange
    {
        public DiscontinuousAffixWordInfo DiscontinuousAffix { get; set; }

        public DiscontinuousAffixWordRange(int start, int length, WordInfo word, DiscontinuousAffixWordInfo discontinuousAffix,
                                               WordCase @case = WordCase.lowercase)
            : base(start, length, word, @case)
        {
            DiscontinuousAffix = discontinuousAffix;
        }

        public override string ToString()
        {
            string result = "";
            string regex = string.Concat(DiscontinuousAffix.Word.Select(c => (DiscontinuousAffix.Categories.ContainsKey(c)
                                                                              ? "[" + DiscontinuousAffix.Categories[c] + "]"
                                                                              : "")));
            regex = Regex.Replace(regex, @"\s+", "");
            MatchCollection mc = Regex.Matches(Word.Word, regex);
            if (mc.Count == 0) return Word.Word;

            Match m = null;
            switch (DiscontinuousAffix.Position)
            {
                case DiscontinuousAffixPosition.First:
                    m = mc[0];
                    break;
                case DiscontinuousAffixPosition.Last:
                    m = mc[mc.Count - 1];
                    break;
            }
            if (m == null) return Word.Word;

            result += string.Concat(Word.Word.Take(m.Index));
            int wi = m.Index; // word index

            for (int dai = 0; dai < DiscontinuousAffix.Word.Length; dai++)
            {
                if (DiscontinuousAffix.Categories.ContainsKey(DiscontinuousAffix.Word[dai])) { result += Word.Word[wi]; wi++; }
                else result += DiscontinuousAffix.Word[dai];
            }
            result += string.Concat(Word.Word.Skip(wi));

            switch (Case)
            {
                case WordCase.Sentencecase:
                    if (result.Length == 0) return "";
                    else if (result.Length == 1) return char.ToUpper(result[0]).ToString();
                    else return char.ToUpper(result[0]) + result.Substring(1);
                case WordCase.UPPERCASE:
                    return result.ToUpper();
                default:
                    return result;
            }

            // Infixes are placed either ADJACENT TO A PROSODIC CONSTITUENT (primary-stressed syllable or prosodic root) <- TODO
            // or ADJACENT TO THE LEFTMOST OF RIGHTMOST PHONOLOGICAL ELEMENT OF A GIVEN TYPE
        }
    }

    public enum WordClass
    {
        Noun,
        Pronoun,
        Verb,
        Adjective,
        Adverb,
        Particle,
        Preposition,
        Postposition,
        Conjunction,
        Determiner,
        Numeral,
        Affix
    }

    public enum WordCase
    {
        UPPERCASE,
        lowercase,
        Sentencecase
    }
}
