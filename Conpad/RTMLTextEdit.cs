using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conpad
{
    public class RTMLTextEdit : RichTextBox
    {
        public RTMLTextEdit() : base()
        {
            RTML = "";
        }

        private string _rtml;

        [ToolboxItem(typeof(string))]
        public string RTML
        {
            get { return _rtml; }
            set
            {
                _rtml = value;

                string state = "chars";
                string commandName = "";

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(@"{\rtf1\ansi\ansicpg1252\deff0\deflang3081{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}}"); // Preamble
                sb.AppendLine(@"\viewkind4\uc1\pard\f0\fs17");

                foreach (char c in value.Replace(Environment.NewLine, ""))
                {
                    switch (state)
                    {
                        case "chars":
                            if (c == '<')
                            {
                                state = "command";
                            }
                            else
                            {
                                sb.Append(c);
                            }
                            break;
                        case "command":
                            if (c == '>')
                            {
                                if (commandName == "/")
                                {
                                    sb.Append("}");
                                }
                                else
                                {
                                    sb.Append(@"{\" + commandName + " ");
                                }
                                state = "chars";
                                commandName = "";
                            }
                            else
                            {
                                commandName += c;
                            }
                            break;
                    }
                }

                sb.AppendLine("}"); // End

                this.Rtf = sb.ToString();
            }
        }
    }
}
