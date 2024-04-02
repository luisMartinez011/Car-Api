using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using ServiceStack;

namespace CarApi.Middlewares
{
    public class ClaimAuthorizationFilter :  Attribute, IAuthorizationFilter
    {
        private readonly string _claimType;
        private readonly string _claimValue;

        public ClaimAuthorizationFilter(string claimType, string claimValue)
        {
            _claimType = claimType;
            _claimValue = claimValue;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //var resp = context.HttpContext.User;
            var claimValue = context.RouteData.Values[_claimValue].ToString();

            //!context.HttpContext.User.HasClaim(_claimType, "ce58c3da - 270a - 464f - 820c - 5cdfa0851623");
            if (!context.HttpContext.User.HasClaim(_claimType, claimValue))
            {
                context.Result = new ForbidResult();
            }
        }
    }
}
