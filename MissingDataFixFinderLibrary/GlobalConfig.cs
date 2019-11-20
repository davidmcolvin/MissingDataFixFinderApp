using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingDataFixFinderFormsUI
{
  public static class GlobalConfig
  {
    public static readonly string PathToDataFixFolder = @"\AumentumTax\Modules\Alter\DB\DataFix";
    public static readonly List<string> FoldersToIgnore = new List<string>() { "Templates" };

    public static string CnnString(string name)
    {
      return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }

    public static string AppKeyLookup(string name)
    {
      return ConfigurationManager.AppSettings[name];
    }
  }
}
