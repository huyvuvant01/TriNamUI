using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTelerikNetCoreV5.Data;

namespace TestTelerikNetCoreV5.Pages
{
    public class IndexModel : PageModel
    {
        public static IList<OrderViewModel> orders;

        public void OnGet()
        {
            if (orders == null)
            {
                orders = new List<OrderViewModel>();

                Enumerable.Range(0, 50).ToList().ForEach(i => orders.Add(new OrderViewModel
                {
                    OrderID = i + 1,
                    Freight = i * 10,
                    OrderDate = new DateTime(2016, 9, 15).AddDays(i % 7),
                    ShipName = "ShipName " + i,
                    ShipCity = "ShipCity " + i
                }));

            }
        }

        public JsonResult OnPostRead([DataSourceRequest] DataSourceRequest request)
        {
            return new JsonResult(orders.ToDataSourceResult(request));
        }

        public JsonResult OnPostCreate([DataSourceRequest] DataSourceRequest request, OrderViewModel order)
        {
            order.OrderID = orders.Count + 2;
            orders.Add(order);

            return new JsonResult(new[] { order }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult OnPostUpdate([DataSourceRequest] DataSourceRequest request, OrderViewModel order)
        {
            orders.Where(x => x.OrderID == order.OrderID).Select(x => order);

            return new JsonResult(new[] { order }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult OnPostDestroy([DataSourceRequest] DataSourceRequest request, OrderViewModel order)
        {
            orders.Remove(orders.First(x => x.OrderID == order.OrderID));

            return new JsonResult(new[] { order }.ToDataSourceResult(request, ModelState));
        }
    }
}
