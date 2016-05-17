namespace Conpad
{
    partial class AddDiscontinuousAffixForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Affix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(258, 461);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(182, 49);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(446, 461);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(182, 49);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Categories
            // 
            this.Categories.Location = new System.Drawing.Point(12, 124);
            this.Categories.Multiline = true;
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(616, 286);
            this.Categories.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categories:";
            // 
            // Affix
            // 
            this.Affix.Location = new System.Drawing.Point(12, 48);
            this.Affix.Name = "Affix";
            this.Affix.Size = new System.Drawing.Size(616, 38);
            this.Affix.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Affix:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Position:";
            // 
            // Position
            // 
            this.Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            "First",
            "Last"});
            this.Position.Location = new System.Drawing.Point(138, 416);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(203, 39);
            this.Position.TabIndex = 5;
            // 
            // AddDiscontinuousAffixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 522);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Affix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddDiscontinuousAffixForm";
            this.Text = "AddDiscontinuousAffix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox Categories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Affix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Position;
    }
}