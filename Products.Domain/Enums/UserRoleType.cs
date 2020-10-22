using System.ComponentModel;

namespace Products.Domain.Enums
{
    public enum UserRoleType
    {
        [Description("Unknown")]
        Unknown = 0,
        [Description("Administrator")]
        Administrator = 1,
        [Description("Normal")]
        Normal = 2,
        [Description("ProductOwner")]
        ProductOwner = 3,
    }
}
