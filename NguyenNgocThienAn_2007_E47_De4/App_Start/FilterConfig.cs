using System.Web;
using System.Web.Mvc;

namespace NguyenNgocThienAn_2007_E47_De4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
