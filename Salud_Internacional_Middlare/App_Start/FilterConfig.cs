using System.Web;
using System.Web.Mvc;

namespace Salud_Internacional_Middlare
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
