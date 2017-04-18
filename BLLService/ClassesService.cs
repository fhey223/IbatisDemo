using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace BLLService
{
    public class ClassesService : BaseBLLService
    {

        /// <summary>
        /// 2013-07-26
        /// 获取全部班级信息
        /// </summary>
        /// <returns>班级实体集合</returns>
        public IList<Calsses> GetAllClasses()
        {
            return SqlMap.QueryForList<Calsses>("SelectAllClasses", null);
        }
        /// <summary>
        /// 2013-07-26
        /// 查询班级实体
        /// </summary>
        /// <param name="calsses_id">班级编号</param>
       /// <returns>班级实体</returns>
        public Calsses GetClassesByid(int calsses_id)
        {
            return (Calsses)SqlMap.QueryForObject("SelectByClassesId", calsses_id);
        }
        /// <summary>
        /// 2013-07-26
        /// 添加班级信息
        /// </summary>
        /// <param name="calssses">班级实体</param>
        public void AddClaases(Calsses calssses)
        {
            SqlMap.Insert("InsertClasses", calssses);
        }
        /// <summary>
        /// 2013-07-26
        /// 修改班级信息
        /// </summary>
        /// <param name="calsses">班级实体</param>
        public void UpdateClasses(Calsses calsses)
        {
            SqlMap.Update("UpdateClasses",calsses);
        }
        /// <summary>
        /// 2013-07-26
        /// 删除班级信息
        /// </summary>
        /// <param name="calslesid">班级编号</param>
        public void DeleteClasses(int calslesid)
        {
            SqlMap.Delete("DeleteClasses", calslesid);
        }
    }
}
