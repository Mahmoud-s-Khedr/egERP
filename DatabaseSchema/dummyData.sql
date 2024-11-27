INSERT INTO Departments (DepartmentName) VALUES
    ('Sales'),
    ('Marketing'),
    ('IT'),
    ('HR'), 
    ('Finance'),
    ('Operations');

INSERT INTO Employees (FirstName, LastName, DepartmentID, JobTitle, HireDate, Salary) VALUES
    ('John', 'Doe', 1, 'Sales Manager', '2022-01-01', 50000.00),
    ('Jane', 'Smith', 2, 'Marketing Manager', '2022-02-01', 48000.00),
    ('Michael', 'Johnson', 3, 'IT Manager', '2022-03-01', 52000.00),
    ('Emily', 'Williams', 4, 'HR Manager', '2022-04-01', 49000.00),
    ('David', 'Brown', 5, 'Finance Manager', '2022-05-01', 55000.00),
    ('Sarah', 'Jones', 6, 'Operations Manager', '2022-06-01', 52000.00);

INSERT INTO Users (PasswordHash, Email, IsActive, EmployeeID) VALUES
    ('password1', '6Bxjz@example.com', TRUE, 1),
    ('password2', 'jwqQw@example.com', TRUE, 2),
    ('password3', 'J2J2g@example.com', TRUE, 3),
    ('password4', '2K8oK@example.com', TRUE, 4),
    ('password5', 'qL4Yt@example.com', TRUE, 5),
    ('password6', '0b4bM@example.com', TRUE, 6);

-- generate 40 customers
INSERT INTO Customers (CustomerName)
VALUES ('Customer 1'), ('Customer 2'), ('Customer 3'), ('Customer 4'), ('Customer 5'), ('Customer 6'), ('Customer 7'), ('Customer 8'), ('Customer 9'), ('Customer 10'),
       ('Customer 11'), ('Customer 12'), ('Customer 13'), ('Customer 14'), ('Customer 15'), ('Customer 16'), ('Customer 17'), ('Customer 18'), ('Customer 19'), ('Customer 20'),
       ('Customer 21'), ('Customer 22'), ('Customer 23'), ('Customer 24'), ('Customer 25'), ('Customer 26'), ('Customer 27'), ('Customer 28'), ('Customer 29'), ('Customer 30'),
       ('Customer 31'), ('Customer 32'), ('Customer 33'), ('Customer 34'), ('Customer 35'), ('Customer 36'), ('Customer 37'), ('Customer 38'), ('Customer 39'), ('Customer 40');

INSERT INTO CustomerAddresses (CustomerID, AddressLine1, AddressLine2, City, Province, PostalCode, Country)
VALUES
    (1, '123 Main St', NULL, 'City 1', 'Province 1', '12345', 'Country 1'),
    (2, '456 Elm St', NULL, 'City 2', 'Province 2', '67890', 'Country 2'),
    (3, '789 Oak St', NULL, 'City 3', 'Province 3', '54321', 'Country 3'),
    (4, '321 Pine St', NULL, 'City 4', 'Province 4', '98765', 'Country 4'),
    (5, '654 Maple St', NULL, 'City 5', 'Province 5', '43210', 'Country 5'),
    (6, '987 Cedar St', NULL, 'City 6', 'Province 6', '87654', 'Country 6'),
    (7, '111 Birch St', NULL, 'City 7', 'Province 7', '11111', 'Country 7'),
    (8, '222 Spruce St', NULL, 'City 8', 'Province 8', '22222', 'Country 8'),
    (9, '333 Walnut St', NULL, 'City 9', 'Province 9', '33333', 'Country 9'),
    (10, '444 Oak St', NULL, 'City 10', 'Province 10', '44444', 'Country 10'),
    (11, '555 Pine St', NULL, 'City 11', 'Province 11', '55555', 'Country 11'),
    (12, '666 Maple St', NULL, 'City 12', 'Province 12', '66666', 'Country 12'),    
    (13, '777 Cedar St', NULL, 'City 13', 'Province 13', '77777', 'Country 13'),
    (14, '888 Birch St', NULL, 'City 14', 'Province 14', '88888', 'Country 14'),
    (15, '999 Spruce St', NULL, 'City 15', 'Province 15', '99999', 'Country 15'),
    (16, '111 Walnut St', NULL, 'City 16', 'Province 16', '11111', 'Country 16'),
    (17, '222 Oak St', NULL, 'City 17', 'Province 17', '22222', 'Country 17'),
    (18, '333 Pine St', NULL, 'City 18', 'Province 18', '33333', 'Country 18'),
    (19, '444 Maple St', NULL, 'City 19', 'Province 19', '44444', 'Country 19'),
    (20, '555 Cedar St', NULL, 'City 20', 'Province 20', '55555', 'Country 20'),
    (21, '666 Birch St', NULL, 'City 21', 'Province 21', '66666', 'Country 21'),
    (22, '777 Spruce St', NULL, 'City 22', 'Province 22', '77777', 'Country 22'),
    (23, '888 Walnut St', NULL, 'City 23', 'Province 23', '88888', 'Country 23'),
    (24, '999 Oak St', NULL, 'City 24', 'Province 24', '99999', 'Country 24');

INSERT INTO CustomerContacts (CustomerID, ContactType, ContactInfo)
VALUES
    (1, 'Phone', '555-1234'),
    (2, 'Phone', '555-5678'),
    (3, 'Phone', '555-9012'),
    (4, 'Phone', '555-3456'),
    (5, 'Phone', '555-7890'),
    (6, 'Phone', '555-2345'),
    (7, 'Phone', '555-6789'),
    (8, 'Phone', '555-0123'),
    (9, 'Phone', '555-4567'),
    (10, 'Phone', '555-8901'),
    (11, 'Phone', '555-2345'),
    (12, 'Phone', '555-6789'),
    (13, 'Phone', '555-0123'),
    (14, 'Phone', '555-4567'),
    (15, 'Phone', '555-8901'),
    (16, 'Phone', '555-2345'),
    (17, 'Phone', '555-6789'),
    (18, 'Phone', '555-0123'),
    (19, 'Phone', '555-4567'),
    (20, 'Phone', '555-8901'),
    (21, 'Phone', '555-2345'),
    (22, 'Phone', '555-6789'),
    (23, 'Phone', '555-0123'),
    (24, 'Phone', '555-4567'),
    (25, 'Phone', '555-8901'),
    (26, 'Phone', '555-2345'),
    (27, 'Phone', '555-6789'),
    (28, 'Phone', '555-0123'),
    (29, 'Phone', '555-4567'),
    (30, 'Phone', '555-8901'),
    (31, 'Phone', '555-2345'),
    (32, 'Phone', '555-6789'),
    (33, 'Phone', '555-0123'),
    (34, 'Phone', '555-4567'),
    (35, 'Phone', '555-8901'),
    (36, 'Phone', '555-2345'),
    (37, 'Phone', '555-6789'),
    (38, 'Phone', '555-0123'),
    (39, 'Phone', '555-4567'),
    (40, 'Phone', '555-8901');