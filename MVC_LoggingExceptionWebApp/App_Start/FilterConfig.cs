using MVC_LoggingExceptionWebApp.CustomFilter;
using System.Web;
using System.Web.Mvc;

namespace MVC_LoggingExceptionWebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ExceptionHandlerAttribute());
        }
    }
}
