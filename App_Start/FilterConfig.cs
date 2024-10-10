using System.Web;
using System.Web.Mvc;

namespace NguyenHoaiDuc_KTraF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
