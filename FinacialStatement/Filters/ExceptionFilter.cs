using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace FinacialStatement.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            //base.OnException(actionExecutedContext);
            //if(actionExecutedContext.Exception != null)
            //{            }

            string exMessage = actionExecutedContext.Exception.Message;

            if (actionExecutedContext.Response == null)
                actionExecutedContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);

            // allow everything
            actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

            // set the body
            actionExecutedContext.Response.Content = new StringContent( exMessage );
            //actionExecutedContext.Response.Content = new StringContent( string.Format(@"{'status':'error','data': [],'exception':'{0}'}", exMessage));


        }
    }
}