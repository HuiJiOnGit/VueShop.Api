using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace VueShop.Model.DBModels
{
    ///<summary>
    ///属性表
    ///</summary>
    [SugarTable("sp_attribute")]
    public partial class sp_attribute
    {
        public sp_attribute()
        {
        }

        /// <summary>
        /// Desc:主键id
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public short attr_id { get; set; }

        /// <summary>
        /// Desc:属性名称
        /// Default:
        /// Nullable:False
        /// </summary>
        public string attr_name { get; set; }

        /// <summary>
        /// Desc:外键，类型id
        /// Default:
        /// Nullable:False
        /// </summary>
        public short cat_id { get; set; }

        /// <summary>
        /// Desc:only:输入框(唯一)  many:后台下拉列表/前台单选框
        /// Default:only
        /// Nullable:False
        /// </summary>
        public string attr_sel { get; set; }

        /// <summary>
        /// Desc:manual:手工录入  list:从列表选择
        /// Default:manual
        /// Nullable:False
        /// </summary>
        public string attr_write { get; set; }

        /// <summary>
        /// Desc:可选值列表信息,例如颜色：白色,红色,绿色,多个可选值通过逗号分隔
        /// Default:
        /// Nullable:False
        /// </summary>
        public string attr_vals { get; set; }

        /// <summary>
        /// Desc:删除时间标志
        /// Default:
        /// Nullable:True
        /// </summary>
        public int? delete_time { get; set; }
    }
}