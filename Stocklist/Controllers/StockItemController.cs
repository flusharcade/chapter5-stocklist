// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockItemsController.cs" company="Flush Arcade Pty Ltd.">
//   Copyright (c) 2015 Flush Arcade Pty Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using Stocklist.Models;

    /// <summary>
    /// The stock items controller.
    /// </summary>
    public class StockItemsController : ApiController
    {
        /// <summary>
        /// The static stock items.
        /// </summary>
        List<StockItem> StockItems = new List<StockItem>()
        { 
            new StockItem { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new StockItem { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new StockItem { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } 
        };

        /// <summary>
        /// Returns all static stock items.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<StockItem> GetAllStockItems()
        {
            return StockItems;
        }

        /// <summary>
        /// Retrieves a particular stock item.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
    }
}
