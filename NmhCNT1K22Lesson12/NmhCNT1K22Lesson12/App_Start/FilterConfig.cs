using System.Web;
using System.Web.Mvc;

namespace NmhCNT1K22Lesson12
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
