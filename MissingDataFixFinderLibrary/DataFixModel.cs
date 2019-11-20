using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingDataFixFinderLibrary
{
  public class DataFixModel
  {
    public string Version
    {
      get { return $"{MajorVersion}.{MinorVersion}.{BuildVersion}.{RevnVersion}"; }
    }
    public int MajorVersion { get; set; }
    public int MinorVersion { get; set; }
    public int BuildVersion { get; set; }
    public int RevnVersion { get; set; }

    public override string ToString()
    {
      return Version;
    }
  }
}
