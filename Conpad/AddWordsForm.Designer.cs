namespace Conpad
{
    partial class AddWordsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Morphemes = new FastColoredTextBoxNS.FastColoredTextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UPPERCASEOption = new System.Windows.Forms.RadioButton();
            this.SentencecaseOption = new System.Windows.Forms.RadioButton();
            this.lowercaseOption = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Morphemes:";
            // 
            // Morphemes
            // 
            this.Morphemes.BackBrush = null;
            this.tableLayoutPanel1.SetColumnSpan(this.Morphemes, 3);
            this.Morphemes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Morphemes.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Morphemes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Morphemes.Location = new System.Drawing.Point(181, 3);
            this.Morphemes.Multiline = false;
            this.Morphemes.Name = "Morphemes";
            this.Morphemes.Paddings = new System.Windows.Forms.Padding(0);
            this.Morphemes.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Morphemes.ShowLineNumbers = false;
            this.Morphemes.ShowScrollBars = false;
            this.Morphemes.Size = new System.Drawing.Size(749, 47);
            this.Morphemes.TabIndex = 1;
            this.Morphemes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Morphemes_KeyDown);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(799, 234);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(131, 56);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Morphemes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OKButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 293);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(662, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.UPPERCASEOption, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SentencecaseOption, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lowercaseOption, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(927, 172);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // UPPERCASEOption
            // 
            this.UPPERCASEOption.AutoSize = true;
            this.UPPERCASEOption.Location = new System.Drawing.Point(5, 5);
            this.UPPERCASEOption.Margin = new System.Windows.Forms.Padding(5);
            this.UPPERCASEOption.Name = "UPPERCASEOption";
            this.UPPERCASEOption.Size = new System.Drawing.Size(226, 36);
            this.UPPERCASEOption.TabIndex = 0;
            this.UPPERCASEOption.Text = "UPPERCASE";
            this.UPPERCASEOption.UseVisualStyleBackColor = true;
            // 
            // SentencecaseOption
            // 
            this.SentencecaseOption.AutoSize = true;
            this.SentencecaseOption.Checked = true;
            this.SentencecaseOption.Location = new System.Drawing.Point(5, 51);
            this.SentencecaseOption.Margin = new System.Windows.Forms.Padding(5);
            this.SentencecaseOption.Name = "SentencecaseOption";
            this.SentencecaseOption.Size = new System.Drawing.Size(240, 36);
            this.SentencecaseOption.TabIndex = 1;
            this.SentencecaseOption.TabStop = true;
            this.SentencecaseOption.Text = "Sentence case";
            this.SentencecaseOption.UseVisualStyleBackColor = true;
            // 
            // lowercaseOption
            // 
            this.lowercaseOption.AutoSize = true;
            this.lowercaseOption.Location = new System.Drawing.Point(5, 97);
            this.lowercaseOption.Margin = new System.Windows.Forms.Padding(5);
            this.lowercaseOption.Name = "lowercaseOption";
            this.lowercaseOption.Size = new System.Drawing.Size(180, 36);
            this.lowercaseOption.TabIndex = 2;
            this.lowercaseOption.TabStop = true;
            this.lowercaseOption.Text = "lowercase";
            this.lowercaseOption.UseVisualStyleBackColor = true;
            // 
            // AddWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 293);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddWordsForm";
            this.Text = "AddWordsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FastColoredTextBoxNS.FastColoredTextBox Morphemes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton UPPERCASEOption;
        private System.Windows.Forms.RadioButton SentencecaseOption;
        private System.Windows.Forms.RadioButton lowercaseOption;
    }
}