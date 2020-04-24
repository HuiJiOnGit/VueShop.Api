using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///权限表
    ///</summary>
    [SugarTable("sp_permission")]
    public partial class sp_permission
    {
        public sp_permission()
        {
        }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public short ps_id { get; set; }

        /// <summary>
        /// Desc:权限名称
        /// Default:
        /// Nullable:False
        /// </summary>
        public string ps_name { get; set; }

        /// <summary>
        /// Desc:父id
        /// Default:
        /// Nullable:False
        /// </summary>
        public short ps_pid { get; set; }

        /// <summary>
        /// Desc:控制器
        /// Default:
        /// Nullable:False
        /// </summary>
        public string ps_c { get; set; }

        /// <summary>
        /// Desc:操作方法
        /// Default:
        /// Nullable:False
        /// </summary>
        public string ps_a { get; set; }

        /// <summary>
        /// Desc:权限等级
        /// Default:0
        /// Nullable:False
        /// </summary>
        public string ps_level { get; set; }
    }
}