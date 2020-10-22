using System.ComponentModel;

namespace Products.Domain.Enums
{
    public enum AddressType
    {
        [Description("Unknown")]
        Unknown = 0,
        [Description("Billing Address")]
        Billing = 1,
        [Description("Deliver Address")]
        Delivery = 2,
        [Description("Office Address")]
        Office = 3,
        [Description("Shipping Address")]
        Shipping = 4
    }
}
