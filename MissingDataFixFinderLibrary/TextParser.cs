using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MissingDataFixFinderLibrary
{
  public static class TextParser
  {
    public static DataFixModel FindVersionInfo( FileInfo file )
    {
      DataFixModel dm = new DataFixModel();
      Regex regex = new Regex(@"execute\s*dbo\.InsertVersion\s*'DataFix'\s*,\s*[0-9]{4}\s*,\s*[0-9]{1,}\s*,\s*[0-9]{1,}\s*,\s*[0-9]{1,}", RegexOptions.IgnoreCase);
      // "\s/Content/"         : space and then Content directory
      // "([a-zA-Z0-9\-]+?)    : group of alphanumeric characters and hyphen
      // ?                     : don't be greedy, match lazily
      // \.aspx                : file extension required for match
      using (StreamReader reader = new StreamReader(file.FullName))
      {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
          // Try to match each line against the Regex.
          Match match = regex.Match(line);
          if ( match.Success )
          {
            // Write original line and the value.
            string v = match.Groups[ 0 ].Value;
            Regex numbersRegex = new Regex( @"[0-9]{4}\s*,\s*[0-9]{1,}\s*,\s*[0-9]{1,}\s*,\s*[0-9]{1,}" );
            Match numbersMatch = numbersRegex.Match( v );
            if ( numbersMatch.Success )
            {
              string numbersV = numbersMatch.Groups[ 0 ].Value;
              string[] numbersVSplit = numbersV.Split( ',' );
              dm.MajorVersion = Convert.ToInt32(numbersVSplit[ 0 ]);
              dm.MinorVersion = Convert.ToInt32(numbersVSplit[ 1 ]);
              dm.BuildVersion = Convert.ToInt32(numbersVSplit[ 2 ]);
              dm.RevnVersion = Convert.ToInt32(numbersVSplit[ 3 ]);
            }
          }
        }
      }
      return dm;
    }
  }
}
