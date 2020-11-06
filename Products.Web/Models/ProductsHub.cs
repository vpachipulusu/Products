using Microsoft.AspNetCore.SignalR;
using Products.Web.Common;
using System.Threading.Tasks;

namespace Products.Web.Models
{
    public class ProductsHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            if (this.Context.User.IsInRole(GlobalConstants.AdministratorRoleName))
            {
                this.Groups.AddToGroupAsync(this.Context.ConnectionId, GlobalConstants.AdministratorRoleName);
            }
            else
            {
                this.Groups.AddToGroupAsync(this.Context.ConnectionId, this.Context.User.Identity.Name);
            }

            return base.OnConnectedAsync();
        }
    }
}
