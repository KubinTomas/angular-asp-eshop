using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace EshopSpareParts.Models.Authorize
{
    public class AdminAuthorize : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext httpContext)
        {

            try
            {
                IEnumerable<string> values;
                httpContext.Request.Headers.TryGetValues("user", out values);
                string token = values?.FirstOrDefault();

                var request = HttpContext.Current.Request;

                var headers = request.Headers;

                string user = headers.GetValues("user").FirstOrDefault();

                if (string.IsNullOrEmpty(user))
                {
                    return false;
                }


                using (var contex = new ApplicationDbContext())
                {


                    //var access = _entities.admin_access.FirstOrDefault(f => f.sessionId == token); //&& f.IsValid

                    //if (access == null)//není vytvořen platný záznam -> potřeba nějak jinak získat personId a systemId a do správného záznamu uložit tento token
                    //{
                    //    return false;
                    //}

                 
                }


                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}