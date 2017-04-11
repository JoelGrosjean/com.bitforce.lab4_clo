using System.Web;
using System.Web.Mvc;

namespace com.bitforce.lab4_clo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
