﻿using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace TKMaster.AulaEnsinoJogos.Web.UI.Configurations
{
    public class AllowAnonymous : IAuthorizationHandler
    {
        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            foreach (IAuthorizationRequirement requirement in context.PendingRequirements.ToList())
                context.Succeed(requirement); //Simply pass all requirements

            return Task.CompletedTask;
        }
    }
}
