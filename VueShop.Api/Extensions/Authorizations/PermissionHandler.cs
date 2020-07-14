using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace VueShop.Api.Extensions.Authorizations
{
    /// <summary>
    /// 复杂权限验证处理类
    /// 继承原生的 AuthorizationHandler，然后重写原生的HandleRequirementAsync处理事件，这样就可以自定义自己的处理逻辑了
    /// </summary>
    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public PermissionHandler()
        {
        }

        /// <summary>
        /// 在这里重写你的验证逻辑
        /// </summary>
        /// <param name="context"></param>
        /// <param name="requirement"></param>
        /// <returns></returns>
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            throw new NotImplementedException();
        }
    }
}