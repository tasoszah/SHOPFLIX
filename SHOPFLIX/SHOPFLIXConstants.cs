using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOPFLIX
{
    /// <summary>
    /// Constants related to SHOPFLIX
    /// </summary>
    public static class SHOPFLIXConstants
    {
        /// <summary>
        /// Maps the <see cref="OrderStatus"/>es to their related <see cref="string"/>s
        /// </summary>
        public static Dictionary<OrderStatus, string> OrderStatusToStringMapper { get; } = new Dictionary<OrderStatus, string>()
        {
            {OrderStatus.Placed, "O" },
            {OrderStatus.Processing, "G" },
            {OrderStatus.ToBeShipped, "H" },
            {OrderStatus.Shipped, "J" },
            {OrderStatus.PartialDelivery, "E" },
            {OrderStatus.FailedToDeliver, "L" },
            {OrderStatus.Delivered, "K" },
            {OrderStatus.Rejected, "D" },
            {OrderStatus.Canceled, "I" },
            {OrderStatus.Completed, "C" }
        };

    }
}
