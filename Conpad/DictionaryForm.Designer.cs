using System;

namespace Conpad
{
    partial class DictionaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictionaryForm));
            this.AddWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Definitions = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentDefinition = new System.Windows.Forms.TextBox();
            this.Gloss = new System.Windows.Forms.TextBox();
            this.AddDefinition = new System.Windows.Forms.Button();
            this.RemoveDefinition = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Word = new Conpad.ConTextEdit();
            this.RemoveWord = new System.Windows.Forms.Button();
            this.Words = new System.Windows.Forms.ListBox();
            this.AddDiscontinuousAffix = new System.Windows.Forms.Button();
            this.CategoriesLabel = new System.Windows.Forms.Label();
            this.Categories = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddWord
            // 
            this.AddWord.Location = new System.Drawing.Point(200, 804);
            this.AddWord.Name = "AddWord";
            this.AddWord.Size = new System.Drawing.Size(209, 66);
            this.AddWord.TabIndex = 26;
            this.AddWord.Text = "Add Word";
            this.AddWord.UseVisualStyleBackColor = true;
            this.AddWord.Click += new System.EventHandler(this.AddWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Word:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Gloss:";
            // 
            // Definitions
            // 
            this.Definitions.FormattingEnabled = true;
            this.Definitions.ItemHeight = 31;
            this.Definitions.Location = new System.Drawing.Point(364, 175);
            this.Definitions.Name = "Definitions";
            this.Definitions.Size = new System.Drawing.Size(360, 252);
            this.Definitions.TabIndex = 18;
            this.Definitions.SelectedIndexChanged += new System.EventHandler(this.Definitions_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Definitions:";
            // 
            // CurrentDefinition
            // 
            this.CurrentDefinition.Enabled = false;
            this.CurrentDefinition.Location = new System.Drawing.Point(730, 175);
            this.CurrentDefinition.Name = "CurrentDefinition";
            this.CurrentDefinition.Size = new System.Drawing.Size(426, 38);
            this.CurrentDefinition.TabIndex = 19;
            this.CurrentDefinition.TextChanged += new System.EventHandler(this.CurrentDefinition_TextChanged);
            // 
            // Gloss
            // 
            this.Gloss.Location = new System.Drawing.Point(302, 88);
            this.Gloss.Name = "Gloss";
            this.Gloss.Size = new System.Drawing.Size(252, 38);
            this.Gloss.TabIndex = 17;
            this.Gloss.TextChanged += new System.EventHandler(this.Gloss_TextChanged);
            // 
            // AddDefinition
            // 
            this.AddDefinition.Location = new System.Drawing.Point(730, 220);
            this.AddDefinition.Name = "AddDefinition";
            this.AddDefinition.Size = new System.Drawing.Size(426, 41);
            this.AddDefinition.TabIndex = 20;
            this.AddDefinition.Text = "Add Definition";
            this.AddDefinition.UseVisualStyleBackColor = true;
            this.AddDefinition.Click += new System.EventHandler(this.AddDefinition_Click);
            // 
            // RemoveDefinition
            // 
            this.RemoveDefinition.Location = new System.Drawing.Point(730, 267);
            this.RemoveDefinition.Name = "RemoveDefinition";
            this.RemoveDefinition.Size = new System.Drawing.Size(426, 41);
            this.RemoveDefinition.TabIndex = 21;
            this.RemoveDefinition.Text = "Remove Definition";
            this.RemoveDefinition.UseVisualStyleBackColor = true;
            this.RemoveDefinition.Click += new System.EventHandler(this.RemoveDefinition_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "Word Class:";
            // 
            // Type
            // 
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Noun",
            "Pronoun",
            "Verb",
            "Adjective",
            "Adverb",
            "Particle",
            "Preposition",
            "Postposition",
            "Conjunction",
            "Determiner",
            "Numeral",
            "Affix"});
            this.Type.Location = new System.Drawing.Point(374, 460);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(292, 39);
            this.Type.TabIndex = 23;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Word);
            this.panel1.Location = new System.Drawing.Point(296, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 38);
            this.panel1.TabIndex = 15;
            // 
            // Word
            // 
            this.Word.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Word.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Word.KeyboardIdentifiers = ((System.Collections.Generic.List<string>)(resources.GetObject("Word.KeyboardIdentifiers")));
            this.Word.KeyboardInUse = 0;
            this.Word.Keyboards = ((System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>)(resources.GetObject("Word.Keyboards")));
            this.Word.Location = new System.Drawing.Point(0, 0);
            this.Word.Multiline = false;
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(250, 36);
            this.Word.TabIndex = 0;
            this.Word.Text = "";
            this.Word.TextChanged += new System.EventHandler(this.Word_TextChanged);
            // 
            // RemoveWord
            // 
            this.RemoveWord.Location = new System.Drawing.Point(756, 804);
            this.RemoveWord.Name = "RemoveWord";
            this.RemoveWord.Size = new System.Drawing.Size(209, 66);
            this.RemoveWord.TabIndex = 28;
            this.RemoveWord.Text = "Remove Word";
            this.RemoveWord.UseVisualStyleBackColor = true;
            this.RemoveWord.Click += new System.EventHandler(this.RemoveWord_Click);
            // 
            // Words
            // 
            this.Words.Dock = System.Windows.Forms.DockStyle.Left;
            this.Words.FormattingEnabled = true;
            this.Words.ItemHeight = 31;
            this.Words.Location = new System.Drawing.Point(0, 0);
            this.Words.Name = "Words";
            this.Words.Size = new System.Drawing.Size(194, 882);
            this.Words.TabIndex = 13;
            this.Words.SelectedIndexChanged += new System.EventHandler(this.Words_SelectedIndexChanged);
            // 
            // AddDiscontinuousAffix
            // 
            this.AddDiscontinuousAffix.Location = new System.Drawing.Point(415, 804);
            this.AddDiscontinuousAffix.Name = "AddDiscontinuousAffix";
            this.AddDiscontinuousAffix.Size = new System.Drawing.Size(335, 66);
            this.AddDiscontinuousAffix.TabIndex = 27;
            this.AddDiscontinuousAffix.Text = "Add Discontinuous Affix";
            this.AddDiscontinuousAffix.UseVisualStyleBackColor = true;
            this.AddDiscontinuousAffix.Click += new System.EventHandler(this.AddDiscontinuousAffix_Click);
            // 
            // CategoriesLabel
            // 
            this.CategoriesLabel.AutoSize = true;
            this.CategoriesLabel.Enabled = false;
            this.CategoriesLabel.Location = new System.Drawing.Point(200, 525);
            this.CategoriesLabel.Name = "CategoriesLabel";
            this.CategoriesLabel.Size = new System.Drawing.Size(161, 32);
            this.CategoriesLabel.TabIndex = 24;
            this.CategoriesLabel.Text = "Categories:";
            // 
            // Categories
            // 
            this.Categories.Enabled = false;
            this.Categories.Location = new System.Drawing.Point(201, 560);
            this.Categories.Multiline = true;
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(955, 238);
            this.Categories.TabIndex = 25;
            this.Categories.TextChanged += new System.EventHandler(this.Categories_TextChanged);
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 882);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.CategoriesLabel);
            this.Controls.Add(this.AddDiscontinuousAffix);
            this.Controls.Add(this.Words);
            this.Controls.Add(this.RemoveWord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveDefinition);
            this.Controls.Add(this.AddDefinition);
            this.Controls.Add(this.Gloss);
            this.Controls.Add(this.CurrentDefinition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Definitions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DictionaryForm";
            this.Text = "Dictionary";
            this.Deactivate += new System.EventHandler(this.DictionaryForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DictionaryForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Definitions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CurrentDefinition;
        private System.Windows.Forms.TextBox Gloss;
        private System.Windows.Forms.Button AddDefinition;
        private System.Windows.Forms.Button RemoveDefinition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Type;
        private ConTextEdit Word;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveWord;
        private System.Windows.Forms.ListBox Words;
        private System.Windows.Forms.Button AddDiscontinuousAffix;
        private System.Windows.Forms.Label CategoriesLabel;
        private System.Windows.Forms.TextBox Categories;
    }
}