using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingDataFixFinderLibrary;

namespace MissingDataFixFinderFormsUI
{
  public static class SearchLogic
  {
    public static List<DataFixModel> FindMismatches(string selectedFolder, List<DataFixModel> foundInDatabaseButNotFolderDataFixModels, List<DataFixModel> foundInFolderButNotDatabaseDataFixModels)
    {
      List<DataFixModel> foundInFolderDataFixModels = new List<DataFixModel>();
      List<DataFixModel> foundInDataBaseDataFixModels = new List<DataFixModel>();
      List<DataFixModel> foundInFolderAndDatabaseDataFixModels = new List<DataFixModel>(); 
      foundInFolderDataFixModels = FolderSearcher.FindDataFixModelsInFolders( selectedFolder );
      foundInDataBaseDataFixModels = SqlConnector.FindDataFixesInDataBase();

      //DataFixModel testFolder = foundInFolderDataFixModels.Where( x => x.MajorVersion == 2018 && x.MinorVersion == 19 && x.BuildVersion == 0 && x.RevnVersion == 2 ).FirstOrDefault();
      //DataFixModel testDatabase = foundInDataBaseDataFixModels.Where(x => x.MajorVersion == 2018 && x.MinorVersion == 19 && x.BuildVersion == 0 && x.RevnVersion == 2).FirstOrDefault();

      //foundInFolderDataFixModels.Clear();
      //foundInFolderDataFixModels.Add(testFolder);

      //foundInDataBaseDataFixModels.Clear();
      //foundInDataBaseDataFixModels.Add(testDatabase  );

      //foundInFolderDataFixModels.OrderBy( x => x.Version );
      //foundInDataBaseDataFixModels.OrderBy(x => x.Version);

      foreach (DataFixModel dm in foundInFolderDataFixModels)
      {
        DataFixModel res;
        res = foundInDataBaseDataFixModels.Where( x => x.MajorVersion == dm.MajorVersion
                                                       && x.MinorVersion == dm.MinorVersion
                                                       && x.BuildVersion == dm.BuildVersion
                                                       && x.RevnVersion == dm.RevnVersion ).FirstOrDefault();
        if ( res != null )
        {
          foundInFolderAndDatabaseDataFixModels.Add(dm);
        }
      }


      foreach (DataFixModel dm in foundInDataBaseDataFixModels)
      {
        DataFixModel res;
        DataFixModel resTwo;

        res = foundInFolderDataFixModels.Where(x => x.MajorVersion == dm.MajorVersion
                                                      && x.MinorVersion == dm.MinorVersion
                                                      && x.BuildVersion == dm.BuildVersion
                                                      && x.RevnVersion == dm.RevnVersion).FirstOrDefault();
        if (res != null)
        {
          resTwo = foundInFolderAndDatabaseDataFixModels.Where(x => x.MajorVersion == dm.MajorVersion
                                                      && x.MinorVersion == dm.MinorVersion
                                                      && x.BuildVersion == dm.BuildVersion
                                                      && x.RevnVersion == dm.RevnVersion).FirstOrDefault();
          if ( resTwo == null )
          {
            foundInFolderAndDatabaseDataFixModels.Add( dm );
          }
        }
      }


      foreach (DataFixModel dm in foundInDataBaseDataFixModels)
      {
        DataFixModel res;
        res = foundInFolderDataFixModels.Where(x => x.MajorVersion == dm.MajorVersion
                                                      && x.MinorVersion == dm.MinorVersion
                                                      && x.BuildVersion == dm.BuildVersion
                                                      && x.RevnVersion == dm.RevnVersion).FirstOrDefault();
        if (res == null)
        {
          foundInDatabaseButNotFolderDataFixModels.Add(dm);
        }
      }

      foreach (DataFixModel dm in foundInFolderDataFixModels)
      {
        DataFixModel res;
        res = foundInDataBaseDataFixModels.Where(x => x.MajorVersion == dm.MajorVersion
                                                      && x.MinorVersion == dm.MinorVersion
                                                      && x.BuildVersion == dm.BuildVersion
                                                      && x.RevnVersion == dm.RevnVersion).FirstOrDefault();
        if (res == null)
        {
          foundInFolderButNotDatabaseDataFixModels.Add(dm);
        }
      }

      return foundInFolderAndDatabaseDataFixModels;
    }
  }
}
