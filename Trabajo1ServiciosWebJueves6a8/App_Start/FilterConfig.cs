using System.Web;
using System.Web.Mvc;

namespace Trabajo1ServiciosWebJueves6a8
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
