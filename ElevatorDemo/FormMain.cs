using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using ElevatorDemo.Properties;

namespace ElevatorDemo
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void quitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      DisplayTitle();
      GetWindowValue();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBox1 ab = new AboutBox1();
      ab.ShowDialog();
    }

    private void toFrenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      fileToolStripMenuItem.Text = Settings.Default.FRMenuFichier;
      quitToolStripMenuItem.Text = Settings.Default.FRMenuQuitter;

      languageToolStripMenuItem.Text = Settings.Default.FRMenuLangage;
      toFrenchToolStripMenuItem.Text = Settings.Default.FRMenuFrancais;
      toEnglishToolStripMenuItem.Text = Settings.Default.FRMenuAnglais;

      toolsToolStripMenuItem.Text = Settings.Default.FRMenuOutils;
      optionsToolStripMenuItem.Text = Settings.Default.FRMenuOptions;

      helpToolStripMenuItem.Text = Settings.Default.FRMenuAide;
      aboutToolStripMenuItem.Text = Settings.Default.FRMenuAPropos;
    }

    private void toEnglishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      fileToolStripMenuItem.Text = Settings.Default.USMenuFile;
      quitToolStripMenuItem.Text = Settings.Default.USMenuQuit;

      languageToolStripMenuItem.Text = Settings.Default.USMenuLanguage;
      toFrenchToolStripMenuItem.Text = Settings.Default.USMenuFrench;
      toEnglishToolStripMenuItem.Text = Settings.Default.USMenuEnglish;


      toolsToolStripMenuItem.Text = Settings.Default.USMenuTools;
      optionsToolStripMenuItem.Text = Settings.Default.USMenuOptions;


      helpToolStripMenuItem.Text = Settings.Default.USMenuHelp;
      aboutToolStripMenuItem.Text = Settings.Default.USMenuAbout;
    }

    private void DisplayTitle()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Text += string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void GetWindowValue()
    {
      // Set this if you want a minimum width
      //Width = Settings.Default.WindowWidth < 395 ? 395 : Settings.Default.WindowWidth;
      Width = Settings.Default.WindowWidth;
      // Set this if you want a minimum Height
      // Height = Settings.Default.WindowHeight < 180 ? 180 : Settings.Default.WindowHeight;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveWindowValue();
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      Settings.Default.Save();
    }
  }
}