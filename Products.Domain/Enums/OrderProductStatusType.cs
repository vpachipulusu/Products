using System.ComponentModel;

namespace Products.Domain.Enums
{
    public enum OrderProductStatusType
    {
        [Description("Unknown")]
        Unknown = 0,
        [Description("Booked")]
        Booked = 1,
        [Description("Dispatched")]
        Dispatched = 2,
        [Description("Delivered")]
        Delivered = 3,
        [Description("Invoiced")]
        Invoiced = 4,
        [Description("Paid")]
        Paid = 5,
        [Description("Cancelled")]
        Cancelled = 6,
        [Description("Returned")]
        Returned = 7,
        [Description("Vendor Shipped")]
        VendorShipped = 8
    }
}
