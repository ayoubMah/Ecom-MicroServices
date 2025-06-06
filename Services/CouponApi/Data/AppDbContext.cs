using Micro.Services.CouponApi.Model;
using Microsoft.EntityFrameworkCore;

namespace Services.CouponApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<Coupon> Coupons { get; set; }
        
    }
}