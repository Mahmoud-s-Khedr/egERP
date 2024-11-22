CREATE DATABASE egERP;

USE egERP;

--  Departments Table
CREATE TABLE Departments (
    DepartmentID INT AUTO_INCREMENT PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL
);
--  Employees Table
CREATE TABLE Employees (
    EmployeeID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DepartmentID INT,
    JobTitle VARCHAR(100),
    HireDate DATE,
    Salary DECIMAL(10, 2),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);
CREATE INDEX EmployeeIndexUsingName ON Employees (FirstName, LastName);
create INDEX EmployeeIndexUsingJobTitle ON Employees (JobTitle);
CREATE INDEX EmployeeIndexUsingDepartment ON Employees (DepartmentID);
--  Roles Table
CREATE TABLE Roles (
    RoleID INT AUTO_INCREMENT PRIMARY KEY,
    RoleName VARCHAR(50) UNIQUE NOT NULL,
    Description TEXT
);
CREATE INDEX RoleIndex ON Roles (RoleName);

--  Permissions Table
CREATE TABLE Permissions (
    PermissionID INT AUTO_INCREMENT PRIMARY KEY,
    PermissionName VARCHAR(100) NOT NULL UNIQUE,
    PermissionDescription TEXT
);
CREATE INDEX PermissionIndex ON Permissions (PermissionName);
--  Users Table
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    PasswordHash VARCHAR(255) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    IsActive BOOLEAN DEFAULT TRUE,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
CREATE INDEX EmailIndex ON Users (Email);
--  RolePermissions Table
CREATE TABLE RolePermissions (
    RolePermissionID INT AUTO_INCREMENT PRIMARY KEY,
    RoleID INT NOT NULL,
    PermissionID INT NOT NULL,
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID),
    FOREIGN KEY (PermissionID) REFERENCES Permissions(PermissionID)
);
CREATE INDEX RolePermissionIndex ON RolePermissions (RoleID);
--  UserRoles Table
CREATE TABLE UserRoles (
    UserRoleID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    RoleID INT NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);
CREATE INDEX UserRoleIndex ON UserRoles (UserID);
-- AuditLog Table explain this one 
CREATE TABLE AuditLogs (
    AuditID INT AUTO_INCREMENT PRIMARY KEY,
    TableName VARCHAR(100) NOT NULL,
    RecordID INT NOT NULL,
    AuditAction ENUM('INSERT', 'UPDATE', 'DELETE') NOT NULL,
    UserID INT,
    ActionTime DATETIME DEFAULT CURRENT_TIMESTAMP,
    Reason TEXT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
CREATE INDEX AuditLogIndex ON AuditLogs (AuditAction);
--  DepartmentManagers Table
CREATE TABLE DepartmentManagers (
    ManagerID INT NOT NULL,
    DepartmentID INT NOT NULL,
    IsActive BOOLEAN DEFAULT TRUE,
    PRIMARY KEY (ManagerID, DepartmentID),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
    Foreign Key (ManagerID) REFERENCES Employees(EmployeeID)
);
--  EmployeeAddresses Table
CREATE TABLE EmployeeAddresses (
    AddressID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    AddressLine1 VARCHAR(100) NOT NULL,
    AddressLine2 VARCHAR(100),
    City VARCHAR(50) NOT NULL,
    Province VARCHAR(50) NOT NULL,
    Country VARCHAR(50) NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
CREATE index AddressIndex ON EmployeeAddresses (EmployeeID);
--  EmployeeContacts Table
CREATE TABLE EmployeeContacts (
    ContactID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    ContactType ENUM('Phone', 'Email') NOT NULL,
    ContactInfo VARCHAR(100) NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
CREATE INDEX ContactIndex ON EmployeeContacts (EmployeeID);
--  Skills Table
CREATE TABLE Skills (
    SkillID INT AUTO_INCREMENT PRIMARY KEY,
    SkillName VARCHAR(100) UNIQUE NOT NULL
);
--  EmployeeSkills Table
CREATE TABLE EmployeeSkills (
    EmployeeSkillID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    SkillID INT NOT NULL,
    ProficiencyLevel ENUM('Beginner', 'Intermediate', 'Expert'),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (SkillID) REFERENCES Skills(SkillID)
);
CREATE INDEX EmployeeSkillIndex ON EmployeeSkills (EmployeeID);
--  LeaveTypes Table
CREATE TABLE LeaveTypes (
    LeaveTypeID INT AUTO_INCREMENT PRIMARY KEY,
    LeaveTypeName VARCHAR(50) NOT NULL UNIQUE,
    LeaveTypeDescription TEXT
);
--  EmployeeLeaves Table
CREATE TABLE EmployeeLeaves (
    LeaveID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    LeaveTypeID INT NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    EmployeeLeaveStatus ENUM('Pending', 'Approved', 'Rejected') DEFAULT 'Pending',
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (LeaveTypeID) REFERENCES LeaveTypes(LeaveTypeID)
);
CREATE INDEX EmployeeLeaveIndex ON EmployeeLeaves (EmployeeID);
CREATE INDEX EmployeeLeaveEndDateIndex ON EmployeeLeaves (EndDate, EmployeeLeaveStatus);
-- EmployeeAttendances Table
CREATE TABLE EmployeeAttendances (
    AttendanceID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    AttendanceDate DATE NOT NULL,
    CheckInTime TIME,
    CheckOutTime TIME,
    EmployeeAttendanceStatus ENUM('Present', 'Absent', 'Late') DEFAULT 'Present',
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
CREATE INDEX EmployeeAttendanceIndex ON EmployeeAttendances (EmployeeID, AttendanceDate);
CREATE INDEX EmployeeAttendanceTypeIndex ON EmployeeAttendances (EmployeeAttendanceStatus);
--  Payroll Table
CREATE TABLE Payroll (
    PayrollID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    PayDate DATE NOT NULL,
    BaseSalary DECIMAL(10, 2),
    Bonuses DECIMAL(10, 2),
    Deductions DECIMAL(10, 2),
    GrossPay DECIMAL(10, 2) GENERATED ALWAYS AS (BaseSalary + Bonuses - Deductions),
    Taxes DECIMAL(10, 2),
    NetPay DECIMAL(10, 2) GENERATED ALWAYS AS (GrossPay - Taxes),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
CREATE INDEX PayrollIndex ON Payroll (EmployeeID, PayDate);
--  EmployeeBankAccounts Table
CREATE TABLE EmployeeBankAccounts (
    BankAccountID INT PRIMARY KEY AUTO_INCREMENT,
    EmployeeID INT,
    BankName VARCHAR(100),
    AccountNumber VARCHAR(50),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
CREATE INDEX EmployeeBankAccountIndex ON EmployeeBankAccounts (EmployeeID);
-- Employee Benefits Table
CREATE TABLE EmployeeBenefits (
    BenefitID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    BenefitName VARCHAR(100) NOT NULL,
    BenefitAmount DECIMAL(10, 2),
    BenefitDescription TEXT,
    BenefitType ENUM('Health', 'Dental', 'Vision'),
    IsActive BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
CREATE INDEX EmployeeBenefitsIndex ON EmployeeBenefits (EmployeeID);
-- Employee Performance Table
CREATE TABLE EmployeePerformance (
    PerformanceID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    ReviewDate DATE NOT NULL,
    PerformanceRating INT CHECK (PerformanceRating >= 1 AND PerformanceRating <= 5),
    PerformanceComments TEXT,
    SupervisorID INT CHECK (SupervisorID <> EmployeeID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (SupervisorID) REFERENCES Employees(EmployeeID)
);
CREATE INDEX EmployeePerformanceIndex ON EmployeePerformance (EmployeeID, ReviewDate);
-- Training Programs Table
CREATE TABLE TrainingPrograms (
    ProgramID INT AUTO_INCREMENT PRIMARY KEY,
    ProgramName VARCHAR(100) NOT NULL,
    TrainingProgramDescription TEXT,
    TrainingProgramCost DECIMAL(10, 2) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    TrainingProgramStatus ENUM('Active', 'Completed', 'Cancelled') DEFAULT 'Active',
    TrainingProvider VARCHAR(100) NOT NULL,
    TrainerName VARCHAR(100) NOT NULL
);
CREATE INDEX TrainingProgramIndex ON TrainingPrograms (TrainingProgramStatus);
CREATE INDEX TrainingProgramEndDateIndex ON TrainingPrograms (EndDate);
CREATE INDEX TrainingProgramTrainingProviderIndex ON TrainingPrograms (TrainingProvider);
-- Employee Training Table
CREATE TABLE EmployeeTraining (
  EmployeeTrainingID INT AUTO_INCREMENT PRIMARY KEY,
  EmployeeID INT NOT NULL,
  ProgramID INT NOT NULL,
  StartDate DATE NOT NULL,
  CompletionDate DATE,
  CompletionStatus ENUM('Completed', 'In Progress', 'Not Started') DEFAULT 'Not Started',
  FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
  FOREIGN KEY (ProgramID) REFERENCES TrainingPrograms(ProgramID) 
);
CREATE INDEX EmployeeTrainingIndex ON EmployeeTraining (EmployeeID);
CREATE INDEX EmployeeTrainingCompletionStatusIndex ON EmployeeTraining (CompletionStatus);
-- Employee Department Transfers Table
CREATE TABLE EmployeeDepartmentTransfers (
    TransferID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    TransferDate DATE NOT NULL,
    NewDepartmentID INT NOT NULL,
    Reason TEXT,
    EmployeeDepartmentTransferStatus ENUM('Pending', 'Approved', 'Rejected') DEFAULT 'Pending',
    OldDepartmentID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    FOREIGN KEY (NewDepartmentID) REFERENCES Departments(DepartmentID),
    FOREIGN KEY (OldDepartmentID) REFERENCES Departments(DepartmentID)
);
CREATE INDEX EmployeeDepartmentTransferIndex ON EmployeeDepartmentTransfers (EmployeeID, TransferDate);
--  Employee Contracts Table
CREATE TABLE EmployeeContracts (
    ContractID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    ContractStartDate DATE NOT NULL,
    ContractEndDate DATE NOT NULL,
    ContractType ENUM('Full Time', 'Part Time', 'Internship') DEFAULT 'Full Time',
    ContractDescription TEXT,
    EmployeeContractStatus ENUM('Active', 'Inactive') DEFAULT 'Active',
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
CREATE INDEX EmployeeContractIndex ON EmployeeContracts (EmployeeID);
-- Employee Resignations Table
CREATE TABLE EmployeeResignations (
    ResignationID INT AUTO_INCREMENT PRIMARY KEY,
    EmployeeID INT NOT NULL,
    ResignationDate DATE NOT NULL,
    Reason TEXT,
    EmployeeResignationStatus ENUM('Pending', 'Approved', 'Rejected') DEFAULT 'Pending',
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
CREATE INDEX EmployeeResignationIndex ON EmployeeResignations (EmployeeID, ResignationDate);
--  Warehouses Table
CREATE TABLE Warehouses (
    WarehouseID INT AUTO_INCREMENT PRIMARY KEY,
    WarehouseName VARCHAR(100) NOT NULL,
    IsActive BOOLEAN DEFAULT TRUE
);
CREATE INDEX WarehouseIndex ON Warehouses (IsActive,WarehouseName);

-- warehouse Managers Table
CREATE TABLE WarehouseManagers (
    WarehouseManagerID INT AUTO_INCREMENT PRIMARY KEY,
    WarehouseID INT NOT NULL,
    EmployeeID INT NOT NULL,
    FOREIGN KEY (WarehouseID) REFERENCES Warehouses(WarehouseID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

--  WarehouseLocations Table
CREATE TABLE WarehouseLocations (
    LocationID INT AUTO_INCREMENT PRIMARY KEY,
    WarehouseID INT NOT NULL,
    LocationName VARCHAR(100) NOT NULL,
    AddressLine1 VARCHAR(100) NOT NULL,
    AddressLine2 VARCHAR(100),
    City VARCHAR(50) NOT NULL,
    Province VARCHAR(50) NOT NULL,
    Country VARCHAR(50) NOT NULL,
    PostalCode VARCHAR(10) NOT NULL,
    FOREIGN KEY (WarehouseID) REFERENCES Warehouses(WarehouseID)
);
--  ProductCategories Table
CREATE TABLE ProductCategories (
    CategoryID INT PRIMARY KEY AUTO_INCREMENT,
    CategoryName VARCHAR(100) NOT NULL,
    ProductCategoryDescription TEXT
);
CREATE INDEX ProductCategoryIndex ON ProductCategories (CategoryName);
--  Products Table
CREATE TABLE Products (
    ProductID INT AUTO_INCREMENT PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    ProductModel VARCHAR(50) UNIQUE NOT NULL,
    UnitPrice DECIMAL(10, 2),
    QuantityInStock INT DEFAULT 0,
    CategoryID INT,
    FOREIGN KEY (CategoryID) REFERENCES ProductCategories(CategoryID)
);
CREATE INDEX ProductIndex ON Products (ProductName);
CREATE INDEX ProductCategoryIndex ON Products (CategoryID);
--  ProductWarehouses Table
CREATE TABLE ProductWarehouses (
    ProductWarehouseID INT AUTO_INCREMENT PRIMARY KEY,
    ProductID INT NOT NULL,
    WarehouseID INT NOT NULL,
    Quantity INT NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (WarehouseID) REFERENCES Warehouses(WarehouseID)
);

--  InventoryTransactions Table
CREATE TABLE InventoryTransactions (
    TransactionID INT AUTO_INCREMENT PRIMARY KEY,
    ProductID INT NOT NULL,
    TransactionType ENUM('IN', 'OUT', 'ADJUSTMENT') NOT NULL,
    Quantity INT NOT NULL,
    TransactionDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
CREATE INDEX InventoryTransactionIndex ON InventoryTransactions (ProductID);
CREATE INDEX InventoryTransactionTypeIndex ON InventoryTransactions (TransactionType);
--  Customers Table
CREATE TABLE Customers (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerName VARCHAR(100) NOT NULL
);
CREATE INDEX CustomerIndex ON Customers (CustomerName);
--  CustomerAddresses Table
CREATE TABLE CustomerAddresses (
    AddressID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    AddressLine1 VARCHAR(255) NOT NULL,
    AddressLine2 VARCHAR(255),
    City VARCHAR(100) NOT NULL,
    Province VARCHAR(50) NOT NULL,
    PostalCode VARCHAR(20) NOT NULL,
    Country VARCHAR(100) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
CREATE INDEX CustomerAddressIndex ON CustomerAddresses (CustomerID);
--  CustomerContacts Table
CREATE TABLE CustomerContacts (
    ContactID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    ContactType ENUM('Phone', 'Email') NOT NULL,
    ContactInfo VARCHAR(100) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
CREATE INDEX CustomerContactIndex ON CustomerContacts (CustomerID);
-- opportunities
CREATE TABLE Opportunities (
    OpportunityID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    OpportunityName VARCHAR(100),
    EstimatedValue DECIMAL(10, 2),
    CloseDate DATE,
    Probability DECIMAL(3, 2),
    OpportunityDescription TEXT,
    OpportunityStatus ENUM('Open', 'Won', 'Lost') DEFAULT 'Open',
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
CREATE INDEX OpportunityIndex ON Opportunities (CustomerID);
CREATE INDEX OpportunityStatusIndex ON Opportunities (OpportunityStatus);
--  OpportunityNotes Table
CREATE TABLE OpportunityNotes (
    NoteID INT AUTO_INCREMENT PRIMARY KEY,
    OpportunityID INT NOT NULL,
    NoteDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    NoteText TEXT NOT NULL,
    EmployeeID INT NOT NULL,
    FOREIGN KEY (OpportunityID) REFERENCES Opportunities(OpportunityID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
CREATE INDEX OpportunityNoteIndex ON OpportunityNotes (OpportunityID);
--  Orders Table
CREATE TABLE Orders (
    OrderID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    OrderStatus ENUM('Pending', 'Shipped', 'Completed', 'Cancelled') DEFAULT 'Pending',
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
CREATE INDEX OrderIndex ON Orders (OrderStatus);
--  OrderDetails Table
CREATE TABLE OrderDetails (
    OrderDetailID INT AUTO_INCREMENT PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
CREATE INDEX OrderDetailIndex ON OrderDetails (OrderID);
--  Invoices Table
CREATE TABLE Invoices (
    InvoiceID INT AUTO_INCREMENT PRIMARY KEY,
    OrderID INT NOT NULL,
    InvoiceDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    DueDate DATE,
    TotalAmount DECIMAL(10, 2),
    PaidAmount DECIMAL(10, 2) DEFAULT 0,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);
CREATE INDEX InvoiceIndex ON Invoices (OrderID);
--  Suppliers Table
CREATE TABLE Suppliers (
    SupplierID INT AUTO_INCREMENT PRIMARY KEY,
    SupplierName VARCHAR(100) NOT NULL
);
CREATE INDEX SupplierIndex ON Suppliers (SupplierName);
--  SupplierAddresses Table
CREATE TABLE SupplierAddresses (
    AddressID INT AUTO_INCREMENT PRIMARY KEY,
    SupplierID INT NOT NULL,
    AddressLine1 VARCHAR(255) NOT NULL,
    AddressLine2 VARCHAR(255),
    City VARCHAR(100) NOT NULL,
    Province VARCHAR(50) NOT NULL,
    PostalCode VARCHAR(20) NOT NULL,
    Country VARCHAR(100) NOT NULL,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);
CREATE INDEX SupplierAddressIndex ON SupplierAddresses (SupplierID);
--  SupplierContacts Table
CREATE TABLE SupplierContacts (
    ContactID INT AUTO_INCREMENT PRIMARY KEY,
    SupplierID INT NOT NULL,
    ContactType ENUM('Phone', 'Email') NOT NULL,
    ContactInfo VARCHAR(100) NOT NULL,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);
CREATE INDEX SupplierContactIndex ON SupplierContacts (SupplierID);
--  PurchaseOrders Table
CREATE TABLE PurchaseOrders (
    PurchaseOrderID INT AUTO_INCREMENT PRIMARY KEY,
    SupplierID INT NOT NULL,
    OrderDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    TotalAmount DECIMAL(10, 2),
    PurchaseOrderStatus ENUM('Pending', 'Received', 'Cancelled') DEFAULT 'Pending',
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);
CREATE INDEX PurchaseOrderIndex ON PurchaseOrders (PurchaseOrderStatus);
CREATE INDEX PurchaseOrderSupplierIndex ON PurchaseOrders (SupplierID);
--  PurchaseOrderDetails Table
CREATE TABLE PurchaseOrderDetails (
    PurchaseOrderDetailID INT AUTO_INCREMENT PRIMARY KEY,
    PurchaseOrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2),
    FOREIGN KEY (PurchaseOrderID) REFERENCES PurchaseOrders(PurchaseOrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
CREATE INDEX PurchaseOrderDetailIndex ON PurchaseOrderDetails (PurchaseOrderID);
CREATE INDEX PurchaseOrderDetailProductIndex ON PurchaseOrderDetails (ProductID);
--  Accounts Table
CREATE TABLE Accounts (
    AccountID INT AUTO_INCREMENT PRIMARY KEY,
    AccountName VARCHAR(100) NOT NULL,
    AccountType ENUM('Asset', 'Liability', 'Equity', 'Revenue', 'Expense') NOT NULL,
    Balance DECIMAL(15, 2) DEFAULT 0
);
CREATE INDEX AccountIndex ON Accounts (AccountType);
--  Transactions Table
CREATE TABLE AccountTransactions (
    TransactionID INT AUTO_INCREMENT PRIMARY KEY,
    AccountID INT NOT NULL,
    TransactionDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    Amount DECIMAL(15, 2) NOT NULL,
    AccountTransactionDescription TEXT,
    FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID)
);
CREATE INDEX TransactionAccountIndex ON AccountTransactions (AccountID);
--  CustomerInteractions Table
CREATE TABLE CustomerInteractions (
    InteractionID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerID INT NOT NULL,
    InteractionDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    InteractionType ENUM('Email', 'Phone', 'In-Person', 'Other'),
    Notes TEXT,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);
CREATE INDEX InteractionIndex ON CustomerInteractions (InteractionType);
CREATE INDEX InteractionCustomerIndex ON CustomerInteractions (CustomerID);

-- batch support 
CREATE TABLE Batches (
    BatchID INT AUTO_INCREMENT PRIMARY KEY,
    ProductID INT NOT NULL,
    BatchNumber VARCHAR(50) UNIQUE NOT NULL,
    ExpiryDate DATE,
    ProductionDate DATE,
    Quantity INT NOT NULL,
    Price DECIMAL(10, 2),
    WarehouseID INT NOT NULL,
    SupplierID INT NOT NULL,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (WarehouseID) REFERENCES Warehouses(WarehouseID)
);
CREATE INDEX BatchIndex ON Batches (ProductID);
CREATE INDEX BatchWarehouseIndex ON Batches (WarehouseID);