using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingDataFixFinderFormsUI;

namespace MissingDataFixFinderLibrary
{
  public static class FolderSearcher
  {
    public static List<DataFixModel> FindDataFixModelsInFolders(string selectedFolder)
    {
      List<DataFixModel> foundInFolderDataFixModels = new List<DataFixModel>();
      //Set the current directory.
      DirectoryInfo di = new DirectoryInfo( selectedFolder );

      foundInFolderDataFixModels = WalkDirectoryTree(di, foundInFolderDataFixModels);

      return foundInFolderDataFixModels;
    }


    static List<DataFixModel> WalkDirectoryTree(System.IO.DirectoryInfo root, List<DataFixModel> foundInFolderDataFixModels)
    {
      System.IO.FileInfo[] files = null;
      System.IO.DirectoryInfo[] subDirs = null;

      // First, process all the files directly under this folder

      files = root.GetFiles("*.*");



      if (files != null)
      {
        foreach (System.IO.FileInfo fi in files)
        {
          // In this example, we only access the existing FileInfo object. If we
          // want to open, delete or modify the file, then
          // a try-catch block is required here to handle the case
          // where the file has been deleted since the call to TraverseTree().
          DataFixModel dm = new DataFixModel();
          dm = TextParser.FindVersionInfo( fi );
          if ( dm == null )
          {
            throw new DataMisalignedException("No version info in one of the files in the folder.");
          }
          foundInFolderDataFixModels.Add(dm);
        }

        // Now find all the subdirectories under this directory.
        subDirs = root.GetDirectories();

        List<DirectoryInfo> acceptableDirs = new List<DirectoryInfo>();

        foreach ( var s in subDirs )
        {
          if ( !GlobalConfig.FoldersToIgnore.Contains( s.Name ) )
          {
            acceptableDirs.Add(s);
          }
        }

        foreach (System.IO.DirectoryInfo dirInfo in acceptableDirs)
        {
          // Resursive call for each subdirectory.
          WalkDirectoryTree(dirInfo, foundInFolderDataFixModels);
        }
      }

      return foundInFolderDataFixModels;
    }
  }
}
