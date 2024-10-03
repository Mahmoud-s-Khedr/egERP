
using Microsoft.EntityFrameworkCore;
 namespace AppContext
{
 public class AppDbContext:DbContext{
    
    public DbSet<Customer> Customers{set;get;}
    public DbSet<CustomerAddress> CustomerAddresses{set;get;}
    public DbSet<CustomerContact>CustomerContacts{set;get;}
    public DbSet<CustomerInternalNote> CustomerInternalNotes{set;get;}
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CustomerModelConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerAddressModleConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerContactModelConfiguration() );
        modelBuilder.ApplyConfiguration(new CustomerInternalNoteModelConfiguration());
    }


}   
}
