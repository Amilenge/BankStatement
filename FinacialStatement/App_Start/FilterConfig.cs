using System.Web;
using System.Web.Mvc;
using FinacialStatement.Filters;

namespace FinacialStatement
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
