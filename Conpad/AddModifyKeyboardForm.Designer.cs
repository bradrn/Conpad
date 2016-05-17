namespace Conpad
{
    partial class AddModifyKeyboardForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Keyboard = new FastColoredTextBoxNS.FastColoredTextBox();
            this.KeyboardName = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Keyboard, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.KeyboardName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.OKButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CancelButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1049, 738);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Keyboard
            // 
            this.Keyboard.AutoScrollMinSize = new System.Drawing.Size(2, 38);
            this.Keyboard.BackBrush = null;
            this.tableLayoutPanel1.SetColumnSpan(this.Keyboard, 2);
            this.Keyboard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Keyboard.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Keyboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Keyboard.Location = new System.Drawing.Point(3, 47);
            this.Keyboard.Name = "Keyboard";
            this.Keyboard.Paddings = new System.Windows.Forms.Padding(0);
            this.Keyboard.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Keyboard.ShowLineNumbers = false;
            this.Keyboard.Size = new System.Drawing.Size(1043, 610);
            this.Keyboard.TabIndex = 1;
            // 
            // KeyboardName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.KeyboardName, 2);
            this.KeyboardName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyboardName.Location = new System.Drawing.Point(3, 3);
            this.KeyboardName.Name = "KeyboardName";
            this.KeyboardName.Size = new System.Drawing.Size(1043, 38);
            this.KeyboardName.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKButton.Location = new System.Drawing.Point(3, 663);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(518, 72);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelButton.Location = new System.Drawing.Point(527, 663);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(519, 72);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 738);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddKeyboard";
            this.Text = "Add/Modify Keyboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddKeyboard_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FastColoredTextBoxNS.FastColoredTextBox Keyboard;
        private System.Windows.Forms.TextBox KeyboardName;
        private System.Windows.Forms.Button OKButton;
        private new System.Windows.Forms.Button CancelButton;
    }
}