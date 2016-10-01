namespace Notepad {
  partial class Editor {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
      this.menu = new System.Windows.Forms.MenuStrip();
      this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.pageSetupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dateTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.formatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.wordWrapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fontStyleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.backColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fontColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.undoContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.cutContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.colorPicker = new System.Windows.Forms.ColorDialog();
      this.fontPicker = new System.Windows.Forms.FontDialog();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.newToolButton = new System.Windows.Forms.ToolStripButton();
      this.openToolButton = new System.Windows.Forms.ToolStripButton();
      this.cutToolButton = new System.Windows.Forms.ToolStripButton();
      this.copyToolButton = new System.Windows.Forms.ToolStripButton();
      this.pasteToolButton = new System.Windows.Forms.ToolStripButton();
      this.saveToolButton = new System.Windows.Forms.ToolStripButton();
      this.undoToolButton = new System.Windows.Forms.ToolStripButton();
      this.redoToolButton = new System.Windows.Forms.ToolStripButton();
      this.searchToolTextbox = new System.Windows.Forms.ToolStripTextBox();
      this.searchToolButton = new System.Windows.Forms.ToolStripButton();
      this.editorArea = new System.Windows.Forms.RichTextBox();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.printDialog = new System.Windows.Forms.PrintDialog();
      this.menu.SuspendLayout();
      this.contextMenu.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menu
      // 
      this.menu.BackColor = System.Drawing.SystemColors.Control;
      this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.formatMenuItem,
            this.helpMenuItem});
      this.menu.Location = new System.Drawing.Point(0, 0);
      this.menu.Name = "menu";
      this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.menu.Size = new System.Drawing.Size(884, 24);
      this.menu.TabIndex = 0;
      this.menu.Text = "menuStrip1";
      // 
      // fileMenuItem
      // 
      this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.toolStripSeparator1,
            this.pageSetupMenuItem,
            this.printMenuItem,
            this.toolStripSeparator2,
            this.exitMenuItem});
      this.fileMenuItem.Name = "fileMenuItem";
      this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileMenuItem.Text = "File";
      // 
      // newMenuItem
      // 
      this.newMenuItem.Name = "newMenuItem";
      this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newMenuItem.Size = new System.Drawing.Size(138, 22);
      this.newMenuItem.Text = "New";
      this.newMenuItem.Click += new System.EventHandler(this.createNewFile);
      // 
      // openMenuItem
      // 
      this.openMenuItem.Name = "openMenuItem";
      this.openMenuItem.Size = new System.Drawing.Size(138, 22);
      this.openMenuItem.Text = "Open";
      this.openMenuItem.Click += new System.EventHandler(this.openFile);
      // 
      // saveMenuItem
      // 
      this.saveMenuItem.Name = "saveMenuItem";
      this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveMenuItem.Size = new System.Drawing.Size(138, 22);
      this.saveMenuItem.Text = "Save";
      this.saveMenuItem.Click += new System.EventHandler(this.saveFIle);
      // 
      // saveAsMenuItem
      // 
      this.saveAsMenuItem.Name = "saveAsMenuItem";
      this.saveAsMenuItem.Size = new System.Drawing.Size(138, 22);
      this.saveAsMenuItem.Text = "Save As";
      this.saveAsMenuItem.Click += new System.EventHandler(this.saveFileAs);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
      // 
      // pageSetupMenuItem
      // 
      this.pageSetupMenuItem.Name = "pageSetupMenuItem";
      this.pageSetupMenuItem.Size = new System.Drawing.Size(138, 22);
      this.pageSetupMenuItem.Text = "Page Setup";
      // 
      // printMenuItem
      // 
      this.printMenuItem.Name = "printMenuItem";
      this.printMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.printMenuItem.Size = new System.Drawing.Size(138, 22);
      this.printMenuItem.Text = "Print";
      this.printMenuItem.Click += new System.EventHandler(this.printFile);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(135, 6);
      // 
      // exitMenuItem
      // 
      this.exitMenuItem.Name = "exitMenuItem";
      this.exitMenuItem.Size = new System.Drawing.Size(138, 22);
      this.exitMenuItem.Text = "Exit";
      this.exitMenuItem.Click += new System.EventHandler(this.closeApp);
      // 
      // editMenuItem
      // 
      this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.toolStripSeparator3,
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem,
            this.deleteMenuItem,
            this.toolStripSeparator5,
            this.selectAllMenuItem,
            this.dateTimeMenuItem});
      this.editMenuItem.Name = "editMenuItem";
      this.editMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editMenuItem.Text = "Edit";
      // 
      // undoMenuItem
      // 
      this.undoMenuItem.Name = "undoMenuItem";
      this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.undoMenuItem.Size = new System.Drawing.Size(160, 22);
      this.undoMenuItem.Text = "Undo";
      this.undoMenuItem.Click += new System.EventHandler(this.undoAction);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
      // 
      // cutMenuItem
      // 
      this.cutMenuItem.Name = "cutMenuItem";
      this.cutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.cutMenuItem.Size = new System.Drawing.Size(160, 22);
      this.cutMenuItem.Text = "Cut";
      this.cutMenuItem.Click += new System.EventHandler(this.cutText);
      // 
      // copyMenuItem
      // 
      this.copyMenuItem.Name = "copyMenuItem";
      this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyMenuItem.Size = new System.Drawing.Size(160, 22);
      this.copyMenuItem.Text = "Copy";
      this.copyMenuItem.Click += new System.EventHandler(this.copyText);
      // 
      // pasteMenuItem
      // 
      this.pasteMenuItem.Name = "pasteMenuItem";
      this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteMenuItem.Size = new System.Drawing.Size(160, 22);
      this.pasteMenuItem.Text = "Paste";
      this.pasteMenuItem.Click += new System.EventHandler(this.pasteText);
      // 
      // deleteMenuItem
      // 
      this.deleteMenuItem.Name = "deleteMenuItem";
      this.deleteMenuItem.Size = new System.Drawing.Size(160, 22);
      this.deleteMenuItem.Text = "Delete";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
      // 
      // selectAllMenuItem
      // 
      this.selectAllMenuItem.Name = "selectAllMenuItem";
      this.selectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.selectAllMenuItem.Size = new System.Drawing.Size(160, 22);
      this.selectAllMenuItem.Text = "Select All";
      this.selectAllMenuItem.Click += new System.EventHandler(this.selectAllText);
      // 
      // dateTimeMenuItem
      // 
      this.dateTimeMenuItem.Name = "dateTimeMenuItem";
      this.dateTimeMenuItem.Size = new System.Drawing.Size(160, 22);
      this.dateTimeMenuItem.Text = "Date/Time";
      this.dateTimeMenuItem.Click += new System.EventHandler(this.insertDateTime);
      // 
      // formatMenuItem
      // 
      this.formatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapMenuItem,
            this.fontMenuItem});
      this.formatMenuItem.Name = "formatMenuItem";
      this.formatMenuItem.Size = new System.Drawing.Size(55, 20);
      this.formatMenuItem.Text = "Format";
      // 
      // wordWrapMenuItem
      // 
      this.wordWrapMenuItem.Checked = true;
      this.wordWrapMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.wordWrapMenuItem.Name = "wordWrapMenuItem";
      this.wordWrapMenuItem.Size = new System.Drawing.Size(134, 22);
      this.wordWrapMenuItem.Text = "Word Wrap";
      this.wordWrapMenuItem.Click += new System.EventHandler(this.toggleWordWrap);
      // 
      // fontMenuItem
      // 
      this.fontMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontStyleMenuItem,
            this.backColorMenuItem,
            this.fontColorMenuItem});
      this.fontMenuItem.Name = "fontMenuItem";
      this.fontMenuItem.Size = new System.Drawing.Size(134, 22);
      this.fontMenuItem.Text = "Font";
      // 
      // fontStyleMenuItem
      // 
      this.fontStyleMenuItem.Name = "fontStyleMenuItem";
      this.fontStyleMenuItem.Size = new System.Drawing.Size(168, 22);
      this.fontStyleMenuItem.Text = "Font Style";
      this.fontStyleMenuItem.Click += new System.EventHandler(this.setFontStyle);
      // 
      // backColorMenuItem
      // 
      this.backColorMenuItem.Name = "backColorMenuItem";
      this.backColorMenuItem.Size = new System.Drawing.Size(168, 22);
      this.backColorMenuItem.Text = "Background Color";
      this.backColorMenuItem.Click += new System.EventHandler(this.setBackgroundColor);
      // 
      // fontColorMenuItem
      // 
      this.fontColorMenuItem.Name = "fontColorMenuItem";
      this.fontColorMenuItem.Size = new System.Drawing.Size(168, 22);
      this.fontColorMenuItem.Text = "Font Color";
      this.fontColorMenuItem.Click += new System.EventHandler(this.setFontColor);
      // 
      // helpMenuItem
      // 
      this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.aboutMenuItem});
      this.helpMenuItem.Name = "helpMenuItem";
      this.helpMenuItem.Size = new System.Drawing.Size(43, 20);
      this.helpMenuItem.Text = "Help";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
      // 
      // aboutMenuItem
      // 
      this.aboutMenuItem.Name = "aboutMenuItem";
      this.aboutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
      this.aboutMenuItem.Size = new System.Drawing.Size(199, 22);
      this.aboutMenuItem.Text = "About Notepad";
      this.aboutMenuItem.Click += new System.EventHandler(this.showAbout);
      // 
      // contextMenu
      // 
      this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoContextMenuItem,
            this.toolStripSeparator7,
            this.cutContextMenuItem,
            this.copyContextMenuItem,
            this.pasteContextMenuItem,
            this.toolStripSeparator8,
            this.selectAllContextMenuItem});
      this.contextMenu.Name = "contextMenuStrip1";
      this.contextMenu.Size = new System.Drawing.Size(121, 126);
      // 
      // undoContextMenuItem
      // 
      this.undoContextMenuItem.Name = "undoContextMenuItem";
      this.undoContextMenuItem.Size = new System.Drawing.Size(120, 22);
      this.undoContextMenuItem.Text = "Undo";
      this.undoContextMenuItem.Click += new System.EventHandler(this.undoAction);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(117, 6);
      // 
      // cutContextMenuItem
      // 
      this.cutContextMenuItem.Name = "cutContextMenuItem";
      this.cutContextMenuItem.Size = new System.Drawing.Size(120, 22);
      this.cutContextMenuItem.Text = "Cut";
      this.cutContextMenuItem.Click += new System.EventHandler(this.cutText);
      // 
      // copyContextMenuItem
      // 
      this.copyContextMenuItem.Name = "copyContextMenuItem";
      this.copyContextMenuItem.Size = new System.Drawing.Size(120, 22);
      this.copyContextMenuItem.Text = "Copy";
      this.copyContextMenuItem.Click += new System.EventHandler(this.copyText);
      // 
      // pasteContextMenuItem
      // 
      this.pasteContextMenuItem.Name = "pasteContextMenuItem";
      this.pasteContextMenuItem.Size = new System.Drawing.Size(120, 22);
      this.pasteContextMenuItem.Text = "Paste";
      this.pasteContextMenuItem.Click += new System.EventHandler(this.pasteText);
      // 
      // toolStripSeparator8
      // 
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new System.Drawing.Size(117, 6);
      // 
      // selectAllContextMenuItem
      // 
      this.selectAllContextMenuItem.Name = "selectAllContextMenuItem";
      this.selectAllContextMenuItem.Size = new System.Drawing.Size(120, 22);
      this.selectAllContextMenuItem.Text = "Select All";
      this.selectAllContextMenuItem.Click += new System.EventHandler(this.selectAllText);
      // 
      // fontPicker
      // 
      this.fontPicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      // 
      // openFileDialog
      // 
      this.openFileDialog.DefaultExt = "txt";
      this.openFileDialog.FileName = "openFileDialog";
      // 
      // toolStrip
      // 
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolButton,
            this.openToolButton,
            this.cutToolButton,
            this.copyToolButton,
            this.pasteToolButton,
            this.saveToolButton,
            this.undoToolButton,
            this.redoToolButton,
            this.searchToolTextbox,
            this.searchToolButton});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(884, 25);
      this.toolStrip.TabIndex = 3;
      this.toolStrip.Text = "toolStrip1";
      // 
      // newToolButton
      // 
      this.newToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.newToolButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolButton.Image")));
      this.newToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolButton.Name = "newToolButton";
      this.newToolButton.Size = new System.Drawing.Size(23, 22);
      this.newToolButton.Text = "New";
      this.newToolButton.Click += new System.EventHandler(this.createNewFile);
      // 
      // openToolButton
      // 
      this.openToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.openToolButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolButton.Image")));
      this.openToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolButton.Name = "openToolButton";
      this.openToolButton.Size = new System.Drawing.Size(23, 22);
      this.openToolButton.Text = "Open";
      this.openToolButton.Click += new System.EventHandler(this.openFile);
      // 
      // cutToolButton
      // 
      this.cutToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.cutToolButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolButton.Image")));
      this.cutToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutToolButton.Name = "cutToolButton";
      this.cutToolButton.Size = new System.Drawing.Size(23, 22);
      this.cutToolButton.Text = "Cut";
      this.cutToolButton.Click += new System.EventHandler(this.cutText);
      // 
      // copyToolButton
      // 
      this.copyToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.copyToolButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolButton.Image")));
      this.copyToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolButton.Name = "copyToolButton";
      this.copyToolButton.Size = new System.Drawing.Size(23, 22);
      this.copyToolButton.Text = "Copy";
      this.copyToolButton.Click += new System.EventHandler(this.copyText);
      // 
      // pasteToolButton
      // 
      this.pasteToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.pasteToolButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolButton.Image")));
      this.pasteToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolButton.Name = "pasteToolButton";
      this.pasteToolButton.Size = new System.Drawing.Size(23, 22);
      this.pasteToolButton.Text = "Paste";
      this.pasteToolButton.Click += new System.EventHandler(this.pasteText);
      // 
      // saveToolButton
      // 
      this.saveToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolButton.Image")));
      this.saveToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolButton.Name = "saveToolButton";
      this.saveToolButton.Size = new System.Drawing.Size(23, 22);
      this.saveToolButton.Text = "Save";
      this.saveToolButton.Click += new System.EventHandler(this.saveFIle);
      // 
      // undoToolButton
      // 
      this.undoToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.undoToolButton.Image = ((System.Drawing.Image)(resources.GetObject("undoToolButton.Image")));
      this.undoToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.undoToolButton.Name = "undoToolButton";
      this.undoToolButton.Size = new System.Drawing.Size(23, 22);
      this.undoToolButton.Text = "Undo";
      this.undoToolButton.Click += new System.EventHandler(this.undoAction);
      // 
      // redoToolButton
      // 
      this.redoToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.redoToolButton.Image = ((System.Drawing.Image)(resources.GetObject("redoToolButton.Image")));
      this.redoToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.redoToolButton.Name = "redoToolButton";
      this.redoToolButton.Size = new System.Drawing.Size(23, 22);
      this.redoToolButton.Text = "redo";
      this.redoToolButton.Click += new System.EventHandler(this.redoAction);
      // 
      // searchToolTextbox
      // 
      this.searchToolTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.searchToolTextbox.Name = "searchToolTextbox";
      this.searchToolTextbox.Size = new System.Drawing.Size(180, 25);
      this.searchToolTextbox.ToolTipText = "Search Box";
      this.searchToolTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchText);
      // 
      // searchToolButton
      // 
      this.searchToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.searchToolButton.Image = ((System.Drawing.Image)(resources.GetObject("searchToolButton.Image")));
      this.searchToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.searchToolButton.Name = "searchToolButton";
      this.searchToolButton.Size = new System.Drawing.Size(23, 22);
      this.searchToolButton.Text = "Search";
      this.searchToolButton.Click += new System.EventHandler(this.searchText);
      // 
      // editorArea
      // 
      this.editorArea.BackColor = System.Drawing.SystemColors.Window;
      this.editorArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.editorArea.ContextMenuStrip = this.contextMenu;
      this.editorArea.Dock = System.Windows.Forms.DockStyle.Fill;
      this.editorArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.editorArea.Location = new System.Drawing.Point(0, 49);
      this.editorArea.Name = "editorArea";
      this.editorArea.Size = new System.Drawing.Size(884, 516);
      this.editorArea.TabIndex = 4;
      this.editorArea.Text = "";
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.DefaultExt = "txt";
      // 
      // printDialog
      // 
      this.printDialog.UseEXDialog = true;
      // 
      // Editor
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(884, 565);
      this.Controls.Add(this.editorArea);
      this.Controls.Add(this.toolStrip);
      this.Controls.Add(this.menu);
      this.MainMenuStrip = this.menu;
      this.Name = "Editor";
      this.Text = "Notepad";
      this.menu.ResumeLayout(false);
      this.menu.PerformLayout();
      this.contextMenu.ResumeLayout(false);
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menu;
    private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem pageSetupMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editMenuItem;
    private System.Windows.Forms.ToolStripMenuItem formatMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wordWrapMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fontMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fontStyleMenuItem;
    private System.Windows.Forms.ToolStripMenuItem backColorMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
    private System.Windows.Forms.ColorDialog colorPicker;
    private System.Windows.Forms.ToolStripMenuItem fontColorMenuItem;
    private System.Windows.Forms.FontDialog fontPicker;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dateTimeMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenu;
    private System.Windows.Forms.ToolStripMenuItem undoContextMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripMenuItem cutContextMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyContextMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteContextMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripMenuItem selectAllContextMenuItem;
    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.ToolStripTextBox searchToolTextbox;
    private System.Windows.Forms.ToolStripButton searchToolButton;
    private System.Windows.Forms.ToolStripButton openToolButton;
    private System.Windows.Forms.ToolStripButton cutToolButton;
    private System.Windows.Forms.ToolStripButton copyToolButton;
    private System.Windows.Forms.ToolStripButton pasteToolButton;
    private System.Windows.Forms.ToolStripButton saveToolButton;
    private System.Windows.Forms.RichTextBox editorArea;
    private System.Windows.Forms.ToolStripButton newToolButton;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.PrintDialog printDialog;
    private System.Windows.Forms.ToolStripButton undoToolButton;
    private System.Windows.Forms.ToolStripButton redoToolButton;
  }
}

