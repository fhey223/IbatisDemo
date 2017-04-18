using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Calsses : Entity
    {
        private int id;
        /// <summary>
        /// 班级编号
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        /// <summary>
        /// 班级名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string description;
        /// <summary>
        /// 班级描述
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
