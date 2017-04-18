using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBatisNet.DataMapper;
using SqlMaps;

namespace BLLService
{ 
   public class BaseBLLService
    {
       protected static ISqlMapper SqlMap = MyIbatisNet.SqlMap;
    }
}
