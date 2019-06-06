using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace FinacialStatement.Filters
{
    public class HttpAllowCors: ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //base.OnActionExecuted(actionExecutedContext);
            if (actionExecutedContext.Exception == null)
                //actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:4200");
                actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            else
                throw actionExecutedContext.Exception;
        }
    }
}