using System;
using System.Windows.Forms;

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

    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBox1 ab = new AboutBox1();
      ab.ShowDialog();
    }

    private void toFrenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      fileToolStripMenuItem.Text = Properties.Settings.Default.FRMenuFichier;
      quitToolStripMenuItem.Text = Properties.Settings.Default.FRMenuQuitter;

      languageToolStripMenuItem.Text = Properties.Settings.Default.FRMenuLangage;
      toFrenchToolStripMenuItem.Text = Properties.Settings.Default.FRMenuFrancais;
      toEnglishToolStripMenuItem.Text = Properties.Settings.Default.FRMenuAnglais;

      toolsToolStripMenuItem.Text = Properties.Settings.Default.FRMenuOutils;
      optionsToolStripMenuItem.Text = Properties.Settings.Default.FRMenuOptions;

      helpToolStripMenuItem.Text = Properties.Settings.Default.FRMenuAide;
      aboutToolStripMenuItem.Text = Properties.Settings.Default.FRMenuAPropos;
    }

    private void toEnglishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      fileToolStripMenuItem.Text = Properties.Settings.Default.USMenuFile;
      quitToolStripMenuItem.Text = Properties.Settings.Default.USMenuQuit;

      languageToolStripMenuItem.Text = Properties.Settings.Default.USMenuLanguage;
      toFrenchToolStripMenuItem.Text = Properties.Settings.Default.USMenuFrench;
      toEnglishToolStripMenuItem.Text = Properties.Settings.Default.USMenuEnglish;


      toolsToolStripMenuItem.Text = Properties.Settings.Default.USMenuTools;
      optionsToolStripMenuItem.Text = Properties.Settings.Default.USMenuOptions;


      helpToolStripMenuItem.Text = Properties.Settings.Default.USMenuHelp;
      aboutToolStripMenuItem.Text = Properties.Settings.Default.USMenuAbout;
    }
  }
}