using Microsoft.EntityFrameworkCore;
using WheelsCatalog.Domain.Common.Models;
using WheelsCatalog.Domain.PriceHistoryAggregate;
using WheelsCatalog.Persistence.Interceptors;

namespace WheelsCatalog.Persistence
{
    public class WheelsCatalogDbContext : DbContext
    {
        private readonly PublishDomainEventsInterceptor _publishDomainEventsInterceptor;

        public WheelsCatalogDbContext(DbContextOptions<WheelsCatalogDbContext> options, PublishDomainEventsInterceptor publishDomainEventsInterceptor) : base(options)
        {
            _publishDomainEventsInterceptor = publishDomainEventsInterceptor;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Ignore<List<IDomainEvent>>()
                .ApplyConfigurationsFromAssembly(typeof(WheelsCatalogDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<PriceHistory> PriceHistories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_publishDomainEventsInterceptor);
            base.OnConfiguring(optionsBuilder);
        }
    }
}