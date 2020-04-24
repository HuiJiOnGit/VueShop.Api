using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sp_role")]
    public partial class sp_role
    {
        public sp_role()
        {
        }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public short role_id { get; set; }

        /// <summary>
        /// Desc:角色名称
        /// Default:
        /// Nullable:False
        /// </summary>
        public string role_name { get; set; }

        /// <summary>
        /// Desc:权限ids,1,2,5
        /// Default:
        /// Nullable:False
        /// </summary>
        public string ps_ids { get; set; }

        /// <summary>
        /// Desc:控制器-操作,控制器-操作,控制器-操作
        /// Default:
        /// Nullable:True
        /// </summary>
        public string ps_ca { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public string role_desc { get; set; }
    }
}