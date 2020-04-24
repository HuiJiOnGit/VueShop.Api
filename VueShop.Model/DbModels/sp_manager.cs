using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///管理员表
    ///</summary>
    [SugarTable("sp_manager")]
    public partial class sp_manager
    {
        public sp_manager()
        {
        }

        /// <summary>
        /// Desc:主键id
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int mg_id { get; set; }

        /// <summary>
        /// Desc:名称
        /// Default:
        /// Nullable:False
        /// </summary>
        public string mg_name { get; set; }

        /// <summary>
        /// Desc:密码
        /// Default:
        /// Nullable:False
        /// </summary>
        public string mg_pwd { get; set; }

        /// <summary>
        /// Desc:注册时间
        /// Default:
        /// Nullable:False
        /// </summary>
        public int mg_time { get; set; }

        /// <summary>
        /// Desc:角色id
        /// Default:0
        /// Nullable:False
        /// </summary>
        public byte role_id { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public string mg_mobile { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public string mg_email { get; set; }

        /// <summary>
        /// Desc:1：表示启用 0:表示禁用
        /// Default:1
        /// Nullable:True
        /// </summary>
        public byte? mg_state { get; set; }
    }
}