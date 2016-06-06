using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Stocklist.Models;

namespace Stocklist.Controllers
{
    public class StockItemsController : ApiController
    {
        List<StockItem> StockItems = new List<StockItem>()
        { 
            new StockItem { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new StockItem { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new StockItem { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };

        [HttpGet]
        public IEnumerable<StockItem> GetAllStockItems()
        {
            return StockItems;
        }

        [HttpGet]
        public StockItem GetStockItem(int id)
        {
            var stockItem = StockItems.FirstOrDefault((p) => p.Id == id);
            if (stockItem == null)
            {
                return null;
            }
            return stockItem;
        }

        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage DeleteStockItem(int id)
        {
            var stockItem = StockItems.FirstOrDefault((p) => p.Id == id);
            if (stockItem == null)
            {
                return new HttpResponseMessage()
                    {
                        Content = new StringContent("Not found selected")
                    };
            }
            else
            {
                StockItems.Remove(stockItem);
            }

            return new HttpResponseMessage()
            {
                Content = new StringContent("Item deleted successfully")
            };
        }
    }
}
