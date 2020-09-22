using System;
using jeuhero.backoffice.Web.UI.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(jeuhero.backoffice.Web.UI.Areas.Identity.IdentityHostingStartup))]
namespace jeuhero.backoffice.Web.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<jeuherobackofficeWebUIContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("jeuherobackofficeWebUIContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<jeuherobackofficeWebUIContext>();
            });
        }
    }
}