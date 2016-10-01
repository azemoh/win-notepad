using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Notepad {

  public partial class Editor : Form {
    private string openedFilePath;
    private bool fileIsOpen;
    private static long instanceCount;

    public Editor() {
      fileIsOpen = false;
      Interlocked.Increment(ref instanceCount);
      InitializeComponent();
    }

    ~Editor() {
      Interlocked.Decrement(ref instanceCount);
    }

    #region Event Handlers

    // Change background color.
    private void setBackgroundColor(object sender, EventArgs e) {
      colorPicker.ShowDialog();
      editorArea.BackColor = colorPicker.Color;
    }

    // Change font color.
    private void setFontColor(object sender, EventArgs e) {
      colorPicker.ShowDialog();
      editorArea.ForeColor = colorPicker.Color;
    }

    private void setFontStyle(object sender, EventArgs e) {
      fontPicker.ShowDialog();
      editorArea.Font = fontPicker.Font;
    }

    // Open text file.
    private void openFile(object sender, EventArgs e) {
      open();
    }

    // Save file
    private void saveFIle(object sender, EventArgs e) {

      save();
    }
    private void saveFileAs(object sender, EventArgs e) {
      saveAs();
    }

    // Exit Application
    private void closeApp(object sender, EventArgs e) {
      if (instanceCount > 1) {
        this.Close();
      } else {
        Application.Exit();
      }
    }

    // New text file i.e new window.
    private void createNewFile(object sender, EventArgs e) {
      newFile();
    }

    // Cut highlighted text.
    private void cutText(object sender, EventArgs e) {
      editorArea.Cut();
    }

    // Copy highlighted text.
    private void copyText(object sender, EventArgs e) {
      editorArea.Copy();
    }

    // Paste text.
    private void pasteText(object sender, EventArgs e) {
      editorArea.Paste();
    }

    // Undo last action
    private void undoAction(object sender, EventArgs e) {
      editorArea.Undo();
    }

    // Redo last action
    private void redoAction(object sender, EventArgs e) {
      editorArea.Redo();
    }

    // Select all i.e highligth all text
    private void selectAllText(object sender, EventArgs e) {
      editorArea.SelectAll();
    }

    // Insert date and time to text.
    private void insertDateTime(object sender, EventArgs e) {
      editorArea.Text = editorArea.Text + " " + DateTime.Now;
      editorArea.Select(editorArea.Text.Length, 0);
    }

    // perform search
    private void searchText(object sender, EventArgs e) {
      search();
    }

    private void searchText(object sender, KeyEventArgs e) {
      search();
    }

    // Word wrap toggle
    private void toggleWordWrap(object sender, EventArgs e) {
      if (wordWrapMenuItem.Checked) {
        wordWrapMenuItem.Checked = false;
        editorArea.WordWrap = false;
      } else {
        wordWrapMenuItem.Checked = true;
        editorArea.WordWrap = true;
      }
    }

    // Print document
    private void printFile(object sender, EventArgs e) {
      printDialog.ShowDialog();
    }

    // Show About
    private void showAbout(object sender, EventArgs e) {
      About about = new About();
      about.Show();
    }

    #endregion Event Handlers

    #region Helper Methods

    // Save current file.
    private void save() {
      if (fileIsOpen) {
        Stream st = File.Open(openedFilePath, FileMode.Create);
        StreamWriter sw = new StreamWriter(st);
        sw.Write(editorArea.Text);
      } else {
        saveAs();
      }
    }

    // Save as new file.
    private void saveAs() {
      if (saveFileDialog.ShowDialog() == DialogResult.OK) {
        Stream st = File.Open(saveFileDialog.FileName, FileMode.CreateNew);
        StreamWriter sw = new StreamWriter(st);
        sw.Write(editorArea.Text);
      }
    }

    // Open text file.
    private void open() {
      Stream st;
      if (openFileDialog.ShowDialog() == DialogResult.OK) {
        if ((st = openFileDialog.OpenFile()) != null) {
          string filename = openFileDialog.FileName;
          string filetext = File.ReadAllText(filename);
          editorArea.Text = filetext;
          // Save the opened file path.
          openedFilePath = filename;
          fileIsOpen = true;
        }
      }
    }

    // Open new text window
    private void newFile() {
      Editor app = new Editor();
      app.Show();
    }

    // Search function. Highlight matching text from the text box.
    private void search() {
      int index = 0;

      String text = editorArea.Text;
      String searchWord = searchToolTextbox.Text;

      while (index < text.LastIndexOf(searchWord)) {
        editorArea.Find(searchWord, index, editorArea.TextLength, RichTextBoxFinds.None);
        editorArea.SelectionBackColor = Color.Orange;
        index = text.IndexOf(searchWord, index) + 1;
      }
    }

    #endregion Helper Methods

  }
}