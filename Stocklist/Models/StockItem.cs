// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockItem.cs" company="Flush Arcade Pty Ltd.">
//   Copyright (c) 2015 Flush Arcade Pty Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Stocklist.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// The stock item
    /// </summary>
    public class StockItem
    {
        /// <summary>
        /// The id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The Price
        /// </summary>
        public decimal Price { get; set; }
    }
}