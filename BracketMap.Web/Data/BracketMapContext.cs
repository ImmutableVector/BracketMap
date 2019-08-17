using BracketMap.Web.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BracketMap.Web.Data
{
    public class BracketMapContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public BracketMapContext(DbContextOptions
            options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<BracketData> NodeMaps { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
