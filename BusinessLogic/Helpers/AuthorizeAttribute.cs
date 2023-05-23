using BusinessLogic.Dtos;
using Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
    private readonly IList<RoleCodes> roles;

    public AuthorizeAttribute(params RoleCodes[] roles)
    {
        this.roles = roles ?? new RoleCodes[] { };
        
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var user = (UserDto)context.HttpContext.Items["User"];
        if (user == null || roles.Any() && !roles.Contains((RoleCodes)user.Role.Id))
        {
            // not logged in
            context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
        }
    }
}