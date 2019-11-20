using MissingDataFixFinderLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MissingDataFixFinderFormsUI
{
  public partial class Form1 : Form
  {
    List<DataFixModel> foundInDatabaseButNotFolderDataFixModels = new List<DataFixModel>();
    List<DataFixModel> foundInFolderButNotDatabaseDataFixModels = new List<DataFixModel>();
    List<DataFixModel> foundInFolderAndDatabaseDataFixModels = new List<DataFixModel>();

    private string selectedFolder = @"C:\dev\AumentumTax\Modules\Alter\DB\DataFix";
    public Form1()
    {
      InitializeComponent();
      WireUpLists();
    }

    private void WireUpLists()
    {
      foundInDatabaseButNotFolderlistBox.DataSource = null;

      if ( foundInDatabaseButNotFolderDataFixModels.Count > 0 )
      {
        foundInDatabaseButNotFolderDataFixModels.OrderByDescending( x => x.MajorVersion )
                                                .ThenByDescending( x => x.MinorVersion )
                                                .ThenByDescending( x => x.BuildVersion )
                                                .ThenByDescending( x => x.RevnVersion );
      }

      foundInDatabaseButNotFolderlistBox.DataSource = foundInDatabaseButNotFolderDataFixModels;
      foundInDatabaseButNotFolderlistBox.DisplayMember = "Version";

      foundInFolderButNotDatabaselistBox.DataSource = null;

      if (foundInFolderButNotDatabaseDataFixModels.Count > 0)
      {
        foundInFolderButNotDatabaseDataFixModels.OrderByDescending(x => x.MajorVersion)
                                                .ThenByDescending(x => x.MinorVersion)
                                                .ThenByDescending(x => x.BuildVersion)
                                                .ThenByDescending(x => x.RevnVersion);
      }

      foundInFolderButNotDatabaselistBox.DataSource = foundInFolderButNotDatabaseDataFixModels;
      foundInFolderButNotDatabaselistBox.DisplayMember = "Version";

      foundInFolderAndDatabaselistBox.DataSource = null;

      if (foundInFolderAndDatabaseDataFixModels.Count > 0)
      {
        foundInFolderAndDatabaseDataFixModels.OrderByDescending(x => x.MajorVersion)
                                             .ThenByDescending(x => x.MinorVersion)
                                             .ThenByDescending(x => x.BuildVersion)
                                             .ThenByDescending(x => x.RevnVersion);
      }

      foundInFolderAndDatabaselistBox.DataSource = foundInFolderAndDatabaseDataFixModels;
      foundInFolderAndDatabaselistBox.DisplayMember = "Version";

      databaseNoFolderLabel.Text = foundInDatabaseButNotFolderDataFixModels.Count.ToString();
      folderNoDatabaseLabel.Text = foundInFolderButNotDatabaseDataFixModels.Count.ToString();
      foundInBothLabel.Text = foundInFolderAndDatabaseDataFixModels.Count.ToString();

    }

    private void button1_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = folderBrowserDialog1;
      if ( folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK )
      {
        selectedFolder = folderBrowserDialog.SelectedPath;
      }

    }

    private void searchButton_Click(object sender, EventArgs e)
    {
      try
      {
       foundInFolderAndDatabaseDataFixModels  = SearchLogic.FindMismatches( selectedFolder, foundInDatabaseButNotFolderDataFixModels, foundInFolderButNotDatabaseDataFixModels);
        WireUpLists();
      }
      catch ( DirectoryNotFoundException ex )
      {
        MessageBox.Show( $"The specified directory does not exist {selectedFolder}");
      }
    }

    private void foundInFolderButNotDatabaselistBox_KeyDown(object sender, KeyEventArgs e)
    {
      try
      {
        if (e.Control && e.KeyCode == Keys.C)
        {
          System.Text.StringBuilder copy_buffer = new System.Text.StringBuilder();
          foreach (object item in foundInFolderButNotDatabaselistBox.SelectedItems)
            copy_buffer.AppendLine(item.ToString());
          if (copy_buffer.Length > 0)
            Clipboard.SetText(copy_buffer.ToString());
        }
      }
      catch (Exception )
      {

        
      }
    }

    private void foundInDatabaseButNotFolderlistBox_KeyDown(object sender, KeyEventArgs e)
    {
      try
      {
        if ( e.Control && e.KeyCode == Keys.C )
        {
          System.Text.StringBuilder copy_buffer = new System.Text.StringBuilder();
          foreach ( object item in foundInDatabaseButNotFolderlistBox.SelectedItems )
            copy_buffer.AppendLine( item.ToString() );
          if ( copy_buffer.Length > 0 )
            Clipboard.SetText( copy_buffer.ToString() );
        }
      }
      catch ( Exception )
      {


      }
    }

    private void foundInFolderAndDatabaselistBox_KeyDown(object sender, KeyEventArgs e)
    {
      try
      {
        if (e.Control && e.KeyCode == Keys.C)
        {
          System.Text.StringBuilder copy_buffer = new System.Text.StringBuilder();
          foreach (object item in foundInFolderAndDatabaselistBox.SelectedItems)
            copy_buffer.AppendLine(item.ToString());
          if (copy_buffer.Length > 0)
            Clipboard.SetText(copy_buffer.ToString());
        }
      }
      catch (Exception)
      {


      }
    }
  }
}
