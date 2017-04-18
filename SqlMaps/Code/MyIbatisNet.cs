using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBatisNet.DataMapper;
using System.Reflection;
using System.IO;
using IBatisNet.DataMapper.Configuration;

namespace SqlMaps
{
  public class MyIbatisNet
    {
      public static ISqlMapper SqlMap;
      private static readonly object syncObj = new object();
      static MyIbatisNet() 
      {
          if (SqlMap == null) 
          {
              lock (syncObj) 
              {
                  if (SqlMap == null)
                  {
                      Assembly assembly = Assembly.Load("SqlMaps");
                      Stream stream = assembly.GetManifestResourceStream("SqlMaps.sqlmap.config");
                      DomSqlMapBuilder builder = new DomSqlMapBuilder();
                      SqlMap = builder.Configure(stream);
                  }
              }
          }
      }
    }
}
