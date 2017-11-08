using System.Web;
using System.Web.Mvc;

namespace FinancialReportingPage_Project1_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
