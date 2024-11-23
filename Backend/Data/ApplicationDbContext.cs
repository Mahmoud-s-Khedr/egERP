using Microsoft.EntityFrameworkCore;
using Backend.Models;
namespace Backend.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }
    public DbSet<DepartmentManager> DepartmentManagers { get; set; }
    public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
    public DbSet<EmployeeContact> EmployeeContacts { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<EmployeeSkill> EmployeeSkills { get; set; }
    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<EmployeeLeave> EmployeeLeaves { get; set; }
    public DbSet<EmployeeAttendance> EmployeeAttendances { get; set; }
    public DbSet<Payroll> Payrolls { get; set; }
    public DbSet<EmployeeBankAccount> EmployeeBankAccounts { get; set; }
    public DbSet<EmployeeBenefit> EmployeeBenefits { get; set;}
    public DbSet<EmployeePerformance> EmployeePerformances { get; set; }
    public DbSet<TrainingProgram> TrainingPrograms { get; set; }
    public DbSet<EmployeeTraining> EmployeeTrainings { get; set; }
    public DbSet<EmployeeDepartmentTransfer> EmployeeDepartmentTransfers { get; set; }
    public DbSet<EmployeeContract> EmployeeContracts { get; set; }
    public DbSet<EmployeeResignation> employeeResignations { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<WarehouseLocation> WarehouseLocations { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductWarehouse> ProductWarehouses { get; set; }
    public DbSet<Batch> Batches { get; set; }
    public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerAddress> CustomerAddresses { get; set; }
    public DbSet<CustomerContact> CustomerContacts { get; set; }
    public DbSet<Opportunity> Opportunities { get; set; }
    public DbSet<OpportunityNote> OpportunityNotes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<SupplierAddress> SupplierAddresses { get; set; }
    public DbSet<SupplierContact> SupplierContacts { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
    public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountTransaction> AccountTransactions { get; set; }
    public DbSet<CustomerInteraction> CustomerInteractions { get; set; }
    public DbSet<WarehouseManager> WarehouseManagers { get; set; }

    protected override void OnModelCreating( ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new PermissionConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new RolePermissionConfiguration());
        modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        modelBuilder.ApplyConfiguration(new AuditLogConfiguration());
        modelBuilder.ApplyConfiguration(new DepartmentManagerConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeAddressConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeContactConfiguration());
        modelBuilder.ApplyConfiguration(new SkillConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeSkillConfiguration());
        modelBuilder.ApplyConfiguration(new LeaveTypeConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeLeaveConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeAttendanceConfiguration());
        modelBuilder.ApplyConfiguration(new PayrollConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeBankAccountConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeBenefitConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeePerformanceConfiguration());
        modelBuilder.ApplyConfiguration(new TrainingProgramConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeTrainingConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeDepartmentTransferConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeContractConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeResignationConfiguration());
        modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
        modelBuilder.ApplyConfiguration(new WarehouseLocationConfiguration());
        modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductWarehouseConfiguration());
        modelBuilder.ApplyConfiguration(new BatchConfiguration());
        modelBuilder.ApplyConfiguration(new InventoryTransactionConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerAddressConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerContactConfiguration());
        modelBuilder.ApplyConfiguration(new OpportunityConfiguration());
        modelBuilder.ApplyConfiguration(new OpportunityNoteConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
        modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
        modelBuilder.ApplyConfiguration(new SupplierConfiguration());
        modelBuilder.ApplyConfiguration(new SupplierAddressConfiguration());
        modelBuilder.ApplyConfiguration(new SupplierContactConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseOrderConfiguration());
        modelBuilder.ApplyConfiguration(new PurchaseOrderDetailConfiguration());
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new AccountTransactionConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerInteractionConfiguration());
        modelBuilder.ApplyConfiguration(new WarehouseManagerConfiguration());
    }
}