using System.Web;
using System.Web.Mvc;

namespace _12_10_16_production_ref_portal_api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
