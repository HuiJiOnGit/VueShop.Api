using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///会员表
    ///</summary>
    [SugarTable("sp_user")]
    public partial class sp_user
    {
        public sp_user()
        {
        }

        /// <summary>
        /// Desc:自增id
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int user_id { get; set; }

        /// <summary>
        /// Desc:登录名
        /// Default:
        /// Nullable:False
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// Desc:qq官方唯一编号信息
        /// Default:
        /// Nullable:True
        /// </summary>
        public string qq_open_id { get; set; }

        /// <summary>
        /// Desc:登录密码
        /// Default:
        /// Nullable:False
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Desc:邮箱
        /// Default:
        /// Nullable:False
        /// </summary>
        public string user_email { get; set; }

        /// <summary>
        /// Desc:新用户注册邮件激活唯一校验码
        /// Default:
        /// Nullable:True
        /// </summary>
        public string user_email_code { get; set; }

        /// <summary>
        /// Desc:新用户是否已经通过邮箱激活帐号
        /// Default:否
        /// Nullable:True
        /// </summary>
        public string is_active { get; set; }

        /// <summary>
        /// Desc:性别
        /// Default:男
        /// Nullable:False
        /// </summary>
        public string user_sex { get; set; }

        /// <summary>
        /// Desc:qq
        /// Default:
        /// Nullable:False
        /// </summary>
        public string user_qq { get; set; }

        /// <summary>
        /// Desc:手机
        /// Default:
        /// Nullable:False
        /// </summary>
        public string user_tel { get; set; }

        /// <summary>
        /// Desc:学历
        /// Default:本科
        /// Nullable:False
        /// </summary>
        public string user_xueli { get; set; }

        /// <summary>
        /// Desc:爱好
        /// Default:
        /// Nullable:False
        /// </summary>
        public string user_hobby { get; set; }

        /// <summary>
        /// Desc:简介
        /// Default:
        /// Nullable:True
        /// </summary>
        public string user_introduce { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:False
        /// </summary>
        public int create_time { get; set; }

        /// <summary>
        /// Desc:修改时间
        /// Default:
        /// Nullable:False
        /// </summary>
        public int update_time { get; set; }
    }
}