using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sp_user_cart")]
    public partial class sp_user_cart
    {
        public sp_user_cart()
        {
        }

        /// <summary>
        /// Desc:主键
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int cart_id { get; set; }

        /// <summary>
        /// Desc:学员id
        /// Default:
        /// Nullable:False
        /// </summary>
        public int user_id { get; set; }

        /// <summary>
        /// Desc:购物车详情信息，二维数组序列化信息
        /// Default:
        /// Nullable:True
        /// </summary>
        public string cart_info { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public DateTime? created_at { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public DateTime? updated_at { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public DateTime? delete_time { get; set; }
    }
}