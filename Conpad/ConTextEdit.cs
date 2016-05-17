using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Conpad
{
    public delegate void TextStyleChangedEventHandler(object sender, EventArgs e);

    public class ConTextEdit : RichTextBox
    {
        public List<Dictionary<string, string>> Keyboards { get; set; } = new List<Dictionary<string, string>>();
        public List<string> KeyboardIdentifiers { get; set; } = new List<string>();
        [ToolboxItem(typeof(int))]
        public int KeyboardInUse { get; set; } = 0;

        public string KeyboardInUseIdentifier
        {
            get
            {
                if (KeyboardIdentifiers.Count >= Keyboards.Count)
                {
                    return KeyboardIdentifiers[KeyboardInUse];
                }
                else
                {
                    return "";
                }
            }
        }

        private bool doneConstructing = false;

        public ConTextEdit() : base()
        {
            Keyboards.Add(new Dictionary<string, string>());
            KeyboardIdentifiers.Add("Base Keyboard");
            doneConstructing = true;
        }

        public void AddKeyboard(Dictionary<string, string> mappings, string name)
        {
            Keyboards.Add(mappings);
            KeyboardIdentifiers.Add(name);
        }

        public void ModifyKeyboard(Dictionary<string, string> mappings, string name)
        {
            if (KeyboardIdentifiers.IndexOf(name) == -1)
            {
                throw new ArgumentException($"{name} does not already exist in the list of keyboards!");
            }
            Keyboards[KeyboardIdentifiers.IndexOf(name)] = mappings;
        }

        public event TextStyleChangedEventHandler TextStyleChanged;

        protected virtual void OnTextStyleChanged(EventArgs e)
        {
            TextStyleChanged?.Invoke(this, e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Control && this.SelectionFont != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.B:
                        e.SuppressKeyPress = true;
                        this.SelectionFont = new Font(this.SelectionFont, this.SelectionFont.Style ^ FontStyle.Bold);
                        OnTextStyleChanged(EventArgs.Empty);
                        break;
                    case Keys.I:
                        e.SuppressKeyPress = true;
                        this.SelectionFont = new Font(this.SelectionFont, this.SelectionFont.Style ^ FontStyle.Italic);
                        OnTextStyleChanged(EventArgs.Empty);
                        break;
                    case Keys.U:
                        e.SuppressKeyPress = true;
                        this.SelectionFont = new Font(this.SelectionFont, this.SelectionFont.Style ^ FontStyle.Underline);
                        OnTextStyleChanged(EventArgs.Empty);
                        break;
                }
            }
            base.OnKeyDown(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (doneConstructing)
            {
                Dictionary<string, string> Keyboard = Keyboards[KeyboardInUse];
                //System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
                //s.Start();
                if (Keyboard.Any(m => (this.SelectionStart - m.Key.Length >= 0)
                    && this.Text.Substring(this.SelectionStart - m.Key.Length, m.Key.Length) == m.Key))
                {
                    foreach (KeyValuePair<string, string> KeyMapping in Keyboard)
                    {
                        if (Text.Length > 0)
                        {
                            int earliarCaretPosition = this.SelectionStart;
                            string earlierText = this.Text;
                            if (this.SelectionStart - KeyMapping.Key.Length >= 0
                                && this.Text.Substring(this.SelectionStart - KeyMapping.Key.Length, KeyMapping.Key.Length) == KeyMapping.Key)
                            {
                                this.Select(this.SelectionStart - KeyMapping.Key.Length, KeyMapping.Key.Length);
                                this.SelectedText = KeyMapping.Value;
                                this.SelectionStart = earliarCaretPosition;
                                this.SelectionLength = 0;
                            }
                            if (this.Text != earlierText)
                            {
                                this.SelectionStart = earliarCaretPosition - (KeyMapping.Key.Length - KeyMapping.Value.Length);
                            }
                            else
                            {
                                this.SelectionStart = earliarCaretPosition;
                            }
                            this.SelectionLength = 0;
                        }
                    }
                }
                //System.Diagnostics.Debug.WriteLine(s.ElapsedMilliseconds + Text);
            }
        }

        public static Dictionary<string, string> Parse(string text)
        {
            string state = "find";
            string[] lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> result = new Dictionary<string, string>();
            string curFindResult = "";
            string curReplaceResult = "";
            bool escaped = false;
            int diag = 0;
            foreach (string line in lines)
            {
                foreach (char c in line)
                {
                    if (state == "find" || escaped)
                    {
                        switch (c)
                        {
                            case '>':
                                if (!escaped) state = "replace";
                                else
                                {
                                    escaped = false;
                                    curFindResult += '>';
                                }
                                break;
                            case '\\':
                                if (!escaped) escaped = true;
                                else
                                {
                                    escaped = false;
                                    curFindResult += '\\';
                                }
                                break;
                            default:
                                curFindResult += c;
                                break;
                        }
                    }
                    else if (state == "replace")
                    {
                        curReplaceResult += c;
                    }
                }
                result.Add(curFindResult, curReplaceResult);
                curFindResult = "";
                curReplaceResult = "";
                state = "find";
                diag++;
            }
            return result;
        }

        public static string Deparse(Dictionary<string, string> keyboard)
        {
            string result = "";
            foreach (KeyValuePair<string, string> mapping in keyboard)
            {
                result += Escape(mapping.Key) + ">" + mapping.Value + Environment.NewLine;
            }
            return result;
        }

        private static string Escape(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                if (c == '\\' || c == '>') result += "\\";
                result += c;
            }
            return result;
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeLibrary(IntPtr hModule);

        private IntPtr msfteditHandle;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams prams = base.CreateParams;
                msfteditHandle = LoadLibrary("msftedit.dll");
                if (msfteditHandle != IntPtr.Zero)
                {
                    prams.ClassName = "RICHEDIT50W";
                }
                return prams;
            }
        }

        ~ConTextEdit()
        {
            if (msfteditHandle != IntPtr.Zero)
            {
                FreeLibrary(msfteditHandle);
            }
        }
    }
}