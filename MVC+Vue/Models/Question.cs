using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Vue.Models
{
    public class Question
    {
        [SugarColumn(IsNullable = false, IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        [SugarColumn(IsNullable = true)]
        public string Title { get; set; }
        [SugarColumn(IsNullable = true)]

        public string More { get; set; }
        /// <summary>
        /// 2012-09-09
        /// 签到日期
        /// </summary>
        public string Plan { get; set; }
        /// <summary>
        /// 33、44
        /// </summary>
        [SugarColumn(IsNullable = true)]
        public string Author { get; set; }

        [SugarColumn(IsNullable = true)]
        public string IP { get; set; }
        public string CreateDate { get; set; }
    }
}
