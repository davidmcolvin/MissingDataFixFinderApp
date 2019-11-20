using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissingDataFixFinderLibrary;

namespace MissingDataFixFinderFormsUI
{
  public static class SqlConnector
  {
    public static List<DataFixModel> FindDataFixesInDataBase()
    {
      List<DataFixModel> dataFixesFoundInDatabase = new List<DataFixModel>();
      DataTable dt = new DataTable();
      int i = 0;
      StringBuilder sb = new StringBuilder();

      sb.Append(@"select majorVersion, minorVersion, buildVersion, RevnVersion from version v where v.app = 'DataFix'");
      sb.Append( $"{Environment.NewLine}" );
      sb.Append(@"order by v.majorversion desc, v.minorversion desc, v.buildversion desc, v.revnversion desc");

      using (var connection = new SqlConnection(GlobalConfig.CnnString(GlobalConfig.AppKeyLookup("ConnectionStringName"))))
      {
        SqlCommand command = new SqlCommand(sb.ToString(), connection);
        SqlDataAdapter adapter = new SqlDataAdapter(command);

        adapter.Fill(dt);

        foreach (DataRow row in dt.Rows)
        {
          DataFixModel dm = new DataFixModel();
          dm.MajorVersion = (int)row["majorVersion"];
          dm.MinorVersion = (int)row["minorVersion"];
          dm.BuildVersion = (int)row["buildVersion"];
          dm.RevnVersion = (int)row["RevnVersion"];
          dataFixesFoundInDatabase.Add(dm);
        }
      }

      return dataFixesFoundInDatabase;

      //List<DataFixModel> dataFixesFoundInFolderButNotInDatabase = new List<DataFixModel>();
      //List<DataFixModel> dataFixesFoundInDatabase = new List<DataFixModel>();
      //DataTable dt = new DataTable();
      //int i = 0;
      //StringBuilder sb = new StringBuilder();

      //sb.Append(@"select majorVersion, minorVersion, buildVersion, RevnVersion from version v where v.app = 'DataFix' ");
      //sb.Append($"{Environment.NewLine}");
      //sb.Append(@"and (");
      //foreach (DataFixModel d in dataFixesFoundInFolder)
      //{
      //  i++;
      //  sb.Append($"{Environment.NewLine}");
      //  sb.Append($@" (majorVersion = {d.MajorVersion} and minorVersion = {d.MinorVersion} and buildVersion = {d.BuildVersion} and revnVersion = {d.RevnVersion})");
      //  if (i < dataFixesFoundInFolder.Count)
      //  {
      //    sb.Append($" or ");
      //  }
      //}
      //sb.Append($"{Environment.NewLine}");
      //sb.Append(@" )");
      //sb.Append($"{Environment.NewLine}");
      //sb.Append(@"order by v.majorversion desc, v.minorversion desc, v.buildversion desc, v.revnversion desc");

      //using ( var connection = new SqlConnection( GlobalConfig.CnnString( GlobalConfig.AppKeyLookup( "ConnectionStringName" ) ) ) )
      //{
      //  SqlCommand command = new SqlCommand( sb.ToString(), connection );
      //  SqlDataAdapter adapter = new SqlDataAdapter(command);

      //  adapter.Fill(dt);

      //  foreach ( DataRow row in dt.Rows )
      //  {
      //    DataFixModel dm = new DataFixModel();
      //    dm.MajorVersion = row[ "majorVersion" ].ToString();
      //    dm.MinorVersion = row["minorVersion"].ToString();
      //    dm.BuildVersion = row["buildVersion"].ToString();
      //    dm.RevnVersion = row["RevnVersion"].ToString();
      //    dataFixesFoundInDatabase.Add(dm);
      //  }
      //  //output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();
      //}



      //return dataFixesFoundInFolderButNotInDatabase;
    }
  }

}
