
using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext{
    public DbSet<Customer> Customers{get;set;}
    public DbSet<CustomerAddress> CustomerAddresses{get;set;}
    public DbSet<CustomerContact> CustomerContacts{get;set;}
    public DbSet<Employee> Employees{get;set;}
    public DbSet<LogInModel> LogInModels{get;set;}

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CustomerModelConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerAddressModelConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerContactModelConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeModelConfiguration());
        modelBuilder.ApplyConfiguration(new LogInModelConfiguration());
    }
}