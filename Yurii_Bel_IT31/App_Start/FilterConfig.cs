using System.Web;
using System.Web.Mvc;

namespace Yurii_Bel_IT31
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}