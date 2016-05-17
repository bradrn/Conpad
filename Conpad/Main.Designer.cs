namespace Conpad
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchKeyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addKeyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyExistingKeyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveKeyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKeyboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeWordRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.KeyboardStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Fonts = new System.Windows.Forms.ToolStripComboBox();
            this.FontSize = new System.Windows.Forms.ToolStripTextBox();
            this.ColourButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LeftAlignmentButton = new System.Windows.Forms.ToolStripButton();
            this.CentreAlignmentButton = new System.Windows.Forms.ToolStripButton();
            this.RightAlignmentButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BoldButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicButton = new System.Windows.Forms.ToolStripButton();
            this.UnderlineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SuperscriptButton = new System.Windows.Forms.ToolStripButton();
            this.SubscriptButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveKeyboardFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openKeyboardFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.importDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.conTextEdit1 = new Conpad.ConTextEdit();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exportDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.keyboardToolStripMenuItem,
            this.wordsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1941, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 48);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(415, 46);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(415, 46);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(415, 46);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(415, 46);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(415, 46);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(415, 46);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertTableToolStripMenuItem,
            this.insertImageToolStripMenuItem,
            this.bulletsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(104, 48);
            this.editToolStripMenuItem.Text = "Insert";
            // 
            // insertTableToolStripMenuItem
            // 
            this.insertTableToolStripMenuItem.Name = "insertTableToolStripMenuItem";
            this.insertTableToolStripMenuItem.Size = new System.Drawing.Size(220, 46);
            this.insertTableToolStripMenuItem.Text = "Table";
            this.insertTableToolStripMenuItem.Click += new System.EventHandler(this.insertTableToolStripMenuItem_Click);
            // 
            // insertImageToolStripMenuItem
            // 
            this.insertImageToolStripMenuItem.Name = "insertImageToolStripMenuItem";
            this.insertImageToolStripMenuItem.Size = new System.Drawing.Size(220, 46);
            this.insertImageToolStripMenuItem.Text = "Image";
            this.insertImageToolStripMenuItem.Click += new System.EventHandler(this.insertImageToolStripMenuItem_Click);
            // 
            // bulletsToolStripMenuItem
            // 
            this.bulletsToolStripMenuItem.Name = "bulletsToolStripMenuItem";
            this.bulletsToolStripMenuItem.Size = new System.Drawing.Size(220, 46);
            this.bulletsToolStripMenuItem.Text = "Bullets";
            this.bulletsToolStripMenuItem.Click += new System.EventHandler(this.bulletsToolStripMenuItem_Click);
            // 
            // keyboardToolStripMenuItem
            // 
            this.keyboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchKeyboardToolStripMenuItem,
            this.addKeyboardToolStripMenuItem,
            this.modifyExistingKeyboardToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveKeyboardToolStripMenuItem,
            this.loadKeyboardToolStripMenuItem});
            this.keyboardToolStripMenuItem.Name = "keyboardToolStripMenuItem";
            this.keyboardToolStripMenuItem.Size = new System.Drawing.Size(157, 48);
            this.keyboardToolStripMenuItem.Text = "Keyboard";
            // 
            // switchKeyboardToolStripMenuItem
            // 
            this.switchKeyboardToolStripMenuItem.Name = "switchKeyboardToolStripMenuItem";
            this.switchKeyboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.switchKeyboardToolStripMenuItem.Size = new System.Drawing.Size(630, 46);
            this.switchKeyboardToolStripMenuItem.Text = "Switch Keyboard";
            this.switchKeyboardToolStripMenuItem.Click += new System.EventHandler(this.switchKeyboardToolStripMenuItem_Click);
            // 
            // addKeyboardToolStripMenuItem
            // 
            this.addKeyboardToolStripMenuItem.Name = "addKeyboardToolStripMenuItem";
            this.addKeyboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.addKeyboardToolStripMenuItem.Size = new System.Drawing.Size(630, 46);
            this.addKeyboardToolStripMenuItem.Text = "Add Keyboard";
            this.addKeyboardToolStripMenuItem.Click += new System.EventHandler(this.addKeyboardToolStripMenuItem_Click);
            // 
            // modifyExistingKeyboardToolStripMenuItem
            // 
            this.modifyExistingKeyboardToolStripMenuItem.Name = "modifyExistingKeyboardToolStripMenuItem";
            this.modifyExistingKeyboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.K)));
            this.modifyExistingKeyboardToolStripMenuItem.Size = new System.Drawing.Size(630, 46);
            this.modifyExistingKeyboardToolStripMenuItem.Text = "Modify Existing Keyboard";
            this.modifyExistingKeyboardToolStripMenuItem.Click += new System.EventHandler(this.modifyExistingKeyboardToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(627, 6);
            // 
            // saveKeyboardToolStripMenuItem
            // 
            this.saveKeyboardToolStripMenuItem.Name = "saveKeyboardToolStripMenuItem";
            this.saveKeyboardToolStripMenuItem.Size = new System.Drawing.Size(630, 46);
            this.saveKeyboardToolStripMenuItem.Text = "Save Keyboard";
            this.saveKeyboardToolStripMenuItem.Click += new System.EventHandler(this.saveKeyboardToolStripMenuItem_Click);
            // 
            // loadKeyboardToolStripMenuItem
            // 
            this.loadKeyboardToolStripMenuItem.Name = "loadKeyboardToolStripMenuItem";
            this.loadKeyboardToolStripMenuItem.Size = new System.Drawing.Size(630, 46);
            this.loadKeyboardToolStripMenuItem.Text = "Load Keyboard";
            this.loadKeyboardToolStripMenuItem.Click += new System.EventHandler(this.loadKeyboardToolStripMenuItem_Click);
            // 
            // wordsToolStripMenuItem
            // 
            this.wordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDictionaryToolStripMenuItem,
            this.addWordsToolStripMenuItem,
            this.removeWordRangeToolStripMenuItem,
            this.toolStripSeparator5,
            this.exportDictionaryToolStripMenuItem});
            this.wordsToolStripMenuItem.Name = "wordsToolStripMenuItem";
            this.wordsToolStripMenuItem.Size = new System.Drawing.Size(116, 48);
            this.wordsToolStripMenuItem.Text = "Words";
            // 
            // showDictionaryToolStripMenuItem
            // 
            this.showDictionaryToolStripMenuItem.Name = "showDictionaryToolStripMenuItem";
            this.showDictionaryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.showDictionaryToolStripMenuItem.Size = new System.Drawing.Size(606, 46);
            this.showDictionaryToolStripMenuItem.Text = "Show Dictionary";
            this.showDictionaryToolStripMenuItem.Click += new System.EventHandler(this.showDictionaryToolStripMenuItem_Click);
            // 
            // addWordsToolStripMenuItem
            // 
            this.addWordsToolStripMenuItem.Name = "addWordsToolStripMenuItem";
            this.addWordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.addWordsToolStripMenuItem.Size = new System.Drawing.Size(606, 46);
            this.addWordsToolStripMenuItem.Text = "Add Words";
            this.addWordsToolStripMenuItem.Click += new System.EventHandler(this.AddWords_Click);
            // 
            // removeWordRangeToolStripMenuItem
            // 
            this.removeWordRangeToolStripMenuItem.Name = "removeWordRangeToolStripMenuItem";
            this.removeWordRangeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.removeWordRangeToolStripMenuItem.Size = new System.Drawing.Size(606, 46);
            this.removeWordRangeToolStripMenuItem.Text = "Remove Word Range";
            this.removeWordRangeToolStripMenuItem.Click += new System.EventHandler(this.removeWordRangeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(92, 48);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(215, 46);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeyboardStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1941, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // KeyboardStatus
            // 
            this.KeyboardStatus.Name = "KeyboardStatus";
            this.KeyboardStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fonts,
            this.FontSize,
            this.ColourButton,
            this.toolStripSeparator2,
            this.LeftAlignmentButton,
            this.CentreAlignmentButton,
            this.RightAlignmentButton,
            this.toolStripSeparator4,
            this.BoldButton,
            this.ItalicButton,
            this.UnderlineButton,
            this.toolStripSeparator3,
            this.SuperscriptButton,
            this.SubscriptButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 58);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1941, 49);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Fonts
            // 
            this.Fonts.Name = "Fonts";
            this.Fonts.Size = new System.Drawing.Size(300, 49);
            this.Fonts.SelectedIndexChanged += new System.EventHandler(this.Fonts_SelectedIndexChanged);
            // 
            // FontSize
            // 
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(100, 49);
            this.FontSize.Text = "12";
            this.FontSize.Validating += new System.ComponentModel.CancelEventHandler(this.FontSize_Validating);
            // 
            // ColourButton
            // 
            this.ColourButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ColourButton.Image = ((System.Drawing.Image)(resources.GetObject("ColourButton.Image")));
            this.ColourButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColourButton.Name = "ColourButton";
            this.ColourButton.Size = new System.Drawing.Size(111, 46);
            this.ColourButton.Text = "Colour";
            this.ColourButton.Click += new System.EventHandler(this.ColourButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 49);
            // 
            // LeftAlignmentButton
            // 
            this.LeftAlignmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LeftAlignmentButton.Image = ((System.Drawing.Image)(resources.GetObject("LeftAlignmentButton.Image")));
            this.LeftAlignmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeftAlignmentButton.Name = "LeftAlignmentButton";
            this.LeftAlignmentButton.Size = new System.Drawing.Size(71, 46);
            this.LeftAlignmentButton.Text = "Left";
            this.LeftAlignmentButton.Click += new System.EventHandler(this.AlignmentButton_Click);
            // 
            // CentreAlignmentButton
            // 
            this.CentreAlignmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CentreAlignmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CentreAlignmentButton.Name = "CentreAlignmentButton";
            this.CentreAlignmentButton.Size = new System.Drawing.Size(110, 46);
            this.CentreAlignmentButton.Text = "Centre";
            this.CentreAlignmentButton.Click += new System.EventHandler(this.AlignmentButton_Click);
            // 
            // RightAlignmentButton
            // 
            this.RightAlignmentButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RightAlignmentButton.Image = ((System.Drawing.Image)(resources.GetObject("RightAlignmentButton.Image")));
            this.RightAlignmentButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RightAlignmentButton.Name = "RightAlignmentButton";
            this.RightAlignmentButton.Size = new System.Drawing.Size(92, 46);
            this.RightAlignmentButton.Text = "Right";
            this.RightAlignmentButton.Click += new System.EventHandler(this.AlignmentButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 49);
            // 
            // BoldButton
            // 
            this.BoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BoldButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldButton.Image")));
            this.BoldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(82, 46);
            this.BoldButton.Text = "Bold";
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // ItalicButton
            // 
            this.ItalicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ItalicButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicButton.Image")));
            this.ItalicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(83, 46);
            this.ItalicButton.Text = "Italic";
            this.ItalicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UnderlineButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineButton.Image")));
            this.UnderlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(151, 46);
            this.UnderlineButton.Text = "Underline";
            this.UnderlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 49);
            // 
            // SuperscriptButton
            // 
            this.SuperscriptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SuperscriptButton.Image = ((System.Drawing.Image)(resources.GetObject("SuperscriptButton.Image")));
            this.SuperscriptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SuperscriptButton.Name = "SuperscriptButton";
            this.SuperscriptButton.Size = new System.Drawing.Size(171, 46);
            this.SuperscriptButton.Text = "Superscript";
            this.SuperscriptButton.Click += new System.EventHandler(this.SuperscriptButton_Click);
            // 
            // SubscriptButton
            // 
            this.SubscriptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SubscriptButton.Image = ((System.Drawing.Image)(resources.GetObject("SubscriptButton.Image")));
            this.SubscriptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SubscriptButton.Name = "SubscriptButton";
            this.SubscriptButton.Size = new System.Drawing.Size(145, 46);
            this.SubscriptButton.Text = "Subscript";
            this.SubscriptButton.Click += new System.EventHandler(this.SubscriptButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Conpad Files (*.cpd)|*.cpd";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Conpad Files (*.cpd)|*.cpd";
            // 
            // saveKeyboardFileDialog
            // 
            this.saveKeyboardFileDialog.Filter = "Conpad Keyboard Files (*.cpkbd)|*.cpkbd";
            // 
            // openKeyboardFileDialog
            // 
            this.openKeyboardFileDialog.Filter = "Conpad Keyboard Files (*.cpkbd)|*.cpkbd";
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "All supported images (*.jpeg, *.jpg, *.png, *.gif)|*.jpeg;*.jpg;*.png;*.gif|JPEG " +
    "images (*.jpeg, *.jpg)|*.jpeg;*.jpg|PNG images (*.png)|*.png|GIF images (*.gif)|" +
    "*.gif";
            // 
            // importDialog
            // 
            this.importDialog.Filter = "RTF (Rich Text Format) Files (*.rtf)|*.rtf|Text files (*.txt)|*.txt";
            // 
            // exportDialog
            // 
            this.exportDialog.Filter = "RTF (Rich Text Format) Files (*.rtf)|*.rtf|Text files (*.txt)|*.txt|Webpages/HTML" +
    " files (*.html)|*.html";
            // 
            // conTextEdit1
            // 
            this.conTextEdit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conTextEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conTextEdit1.KeyboardIdentifiers = ((System.Collections.Generic.List<string>)(resources.GetObject("conTextEdit1.KeyboardIdentifiers")));
            this.conTextEdit1.KeyboardInUse = 0;
            this.conTextEdit1.Keyboards = ((System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>)(resources.GetObject("conTextEdit1.Keyboards")));
            this.conTextEdit1.Location = new System.Drawing.Point(0, 107);
            this.conTextEdit1.Name = "conTextEdit1";
            this.conTextEdit1.Size = new System.Drawing.Size(1941, 1268);
            this.conTextEdit1.TabIndex = 5;
            this.conTextEdit1.Text = "";
            this.conTextEdit1.TextStyleChanged += new Conpad.TextStyleChangedEventHandler(this.conTextEdit1_ManageStyles);
            this.conTextEdit1.TextChanged += new System.EventHandler(this.conTextEdit1_TextChanged);
            this.conTextEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.conTextEdit1_KeyDown);
            this.conTextEdit1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.conTextEdit1_KeyUp);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(603, 6);
            // 
            // exportDictionaryToolStripMenuItem
            // 
            this.exportDictionaryToolStripMenuItem.Name = "exportDictionaryToolStripMenuItem";
            this.exportDictionaryToolStripMenuItem.Size = new System.Drawing.Size(606, 46);
            this.exportDictionaryToolStripMenuItem.Text = "Export";
            this.exportDictionaryToolStripMenuItem.Click += new System.EventHandler(this.exportDictionaryToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1941, 1397);
            this.Controls.Add(this.conTextEdit1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Main";
            this.Text = "Conpad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel KeyboardStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox Fonts;
        private System.Windows.Forms.ToolStripButton ItalicButton;
        private System.Windows.Forms.ToolStripButton BoldButton;
        private System.Windows.Forms.ToolStripButton UnderlineButton;
        private System.Windows.Forms.ToolStripTextBox FontSize;
        private System.Windows.Forms.ToolStripMenuItem addKeyboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyExistingKeyboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem removeWordRangeToolStripMenuItem;
        public ConTextEdit conTextEdit1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchKeyboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveKeyboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadKeyboardToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveKeyboardFileDialog;
        private System.Windows.Forms.OpenFileDialog openKeyboardFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton SuperscriptButton;
        private System.Windows.Forms.ToolStripButton SubscriptButton;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.ToolStripMenuItem insertImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ColourButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton LeftAlignmentButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton CentreAlignmentButton;
        private System.Windows.Forms.ToolStripButton RightAlignmentButton;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog importDialog;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exportDictionaryToolStripMenuItem;
    }
}

