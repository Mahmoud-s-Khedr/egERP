-- ====================================
-- Dummy Data for Department Table
-- ====================================
INSERT INTO department (name, description) VALUES
('Human Resources', 'Handles recruitment, employee relations, and benefits.'),
('Sales', 'Responsible for selling products and services.'),
('Information Technology', 'Manages technology infrastructure and support.'),
('Finance', 'Oversees financial planning, analysis, and reporting.'),
('Marketing', 'Handles advertising, market research, and brand management.');

-- ====================================
-- Dummy Data for Admin Table
-- ====================================
INSERT INTO admin (username, password, authority, department) VALUES
('admin_john', 'securePass1', 'superuser', 1),
('admin_jane', 'securePass2', 'manager', 2),
('admin_mike', 'securePass3', 'manager', 3);

-- ====================================
-- Dummy Data for Employee Table
-- ====================================
INSERT INTO employee (first_name, last_name, email, net_salary, department, gender, birth_date, job_title, rete_of_sale, authority) VALUES
('John', 'Doe', 'john.doe@example.com', 60000.00, 2, 'male', '1985-04-12', 'Sales Executive', 15, 'sales'),
('Jane', 'Smith', 'jane.smith@example.com', 75000.00, 1, 'female', '1990-07-19', 'HR Manager', 0, 'hr'),
('Mike', 'Johnson', 'mike.johnson@example.com', 80000.00, 3, 'male', '1982-11-05', 'IT Specialist', 0, 'it'),
('Emily', 'Davis', 'emily.davis@example.com', 70000.00, 4, 'female', '1988-02-23', 'Financial Analyst', 0, 'finance'),
('David', 'Wilson', 'david.wilson@example.com', 65000.00, 5, 'male', '1992-09-14', 'Marketing Coordinator', 0, 'marketing');

-- ====================================
-- Dummy Data for Employee_Address Table
-- ====================================
INSERT INTO employee_address (employee_id, address, city, country, zip_code, state, availability) VALUES
(1, '123 Maple Street', 'Springfield', 'USA', '62704', 'IL', 'available'),
(2, '456 Oak Avenue', 'Metropolis', 'USA', '62960', 'IL', 'available'),
(3, '789 Pine Road', 'Gotham', 'USA', '10001', 'NY', 'not available'),
(4, '321 Birch Boulevard', 'Star City', 'USA', '98101', 'WA', 'available'),
(5, '654 Cedar Lane', 'Central City', 'USA', '60614', 'IL', 'available');

-- ====================================
-- Dummy Data for Employee_Contact Table
-- ====================================
INSERT INTO employee_contact (employee_id, contact) VALUES
(1, '555-1234'),
(1, 'john.doe@workemail.com'),
(2, '555-5678'),
(3, '555-9012'),
(4, '555-3456'),
(5, '555-7890');

-- ====================================
-- Dummy Data for Employee_Attendance Table
-- ====================================
INSERT INTO employee_attendance (employee_id, date, status) VALUES
(1, '2024-04-01 08:00:00', 'on-time'),
(1, '2024-04-02 08:05:00', 'late'),
(2, '2024-04-01 09:00:00', 'on-time'),
(3, '2024-04-01 08:15:00', 'late'),
(4, '2024-04-01 08:00:00', 'on-time'),
(5, '2024-04-01 08:10:00', 'late');

-- ====================================
-- Dummy Data for Employee_Leave Table
-- ====================================
INSERT INTO employee_leave (employee_id, start_date, end_date, status) VALUES
(1, '2024-05-10', '2024-05-15', 'approved'),
(2, '2024-06-01', '2024-06-05', 'pending'),
(3, '2024-07-20', '2024-07-25', 'rejected'),
(4, '2024-08-15', '2024-08-20', 'approved'),
(5, '2024-09-05', '2024-09-10', 'approved');

-- ====================================
-- Dummy Data for Employee_Payroll Table
-- ====================================
INSERT INTO employee_payroll (employee_id, months, tax, deduction, bonus, rate) VALUES
(1, '2024-04-01', 12000.00, 2000.00, 500.00, 0.05),
(2, '2024-04-01', 15000.00, 2500.00, 700.00, 0.07),
(3, '2024-04-01', 16000.00, 3000.00, 800.00, 0.06),
(4, '2024-04-01', 14000.00, 2200.00, 600.00, 0.04),
(5, '2024-04-01', 13000.00, 2100.00, 550.00, 0.05);

-- ====================================
-- Dummy Data for User_Login Table
-- ====================================
INSERT INTO user_login (employee_id, username, password) VALUES
(1, 'john.doe@example.com', 'johnPass1'),
(2, 'jane.smith@example.com', 'janePass2'),
(3, 'mike.johnson@example.com', 'mikePass3'),
(4, 'emily.davis@example.com', 'emilyPass4'),
(5, 'david.wilson@example.com', 'davidPass5');

-- ====================================
-- Dummy Data for Department_Manager Table
-- ====================================
INSERT INTO department_manager (department_id, employee_id, start_date) VALUES
(1, 2, '2024-01-01'),
(2, 1, '2024-01-15'),
(3, 3, '2024-02-01'),
(4, 4, '2024-03-01'),
(5, 5, '2024-04-01');

-- ====================================
-- Dummy Data for Department_Contact Table
-- ====================================
INSERT INTO department_contact (department_id, contact, employee_id, start_date) VALUES
(1, 'hr_contact@company.com', 2, '2024-01-01'),
(2, 'sales_contact@company.com', 1, '2024-01-15'),
(3, 'it_contact@company.com', 3, '2024-02-01'),
(4, 'finance_contact@company.com', 4, '2024-03-01'),
(5, 'marketing_contact@company.com', 5, '2024-04-01');

-- ====================================
-- Dummy Data for Customer Table
-- ====================================
INSERT INTO customer (first_name, last_name, email) VALUES
('Alice', 'Williams', 'alice.williams@example.com'),
('Bob', 'Brown', 'bob.brown@example.com'),
('Charlie', 'Davis', 'charlie.davis@example.com'),
('Diana', 'Evans', 'diana.evans@example.com'),
('Ethan', 'Foster', 'ethan.foster@example.com');

-- ====================================
-- Dummy Data for Customer_Address Table
-- ====================================
INSERT INTO customer_address (customer_id, address, city, country, zip_code, state, availability) VALUES
(1, '1001 Sunset Blvd', 'Los Angeles', 'USA', '90028', 'CA', 'available'),
(2, '2022 Sunrise Ave', 'New York', 'USA', '10001', 'NY', 'available'),
(3, '3033 Moonlight Dr', 'Chicago', 'USA', '60616', 'IL', 'not available'),
(4, '4044 Starlight St', 'Houston', 'USA', '77002', 'TX', 'available'),
(5, '5055 Twilight Terrace', 'Phoenix', 'USA', '85001', 'AZ', 'available');

-- ====================================
-- Dummy Data for Customer_Contact Table
-- ====================================
INSERT INTO customer_contact (customer_id, contact) VALUES
(1, '555-1111'),
(1, 'alice.williams@contact.com'),
(2, '555-2222'),
(3, '555-3333'),
(4, '555-4444'),
(5, '555-5555');

-- ====================================
-- Dummy Data for Customer_Internal_Notes Table
-- ====================================
INSERT INTO customer_internal_notes (customer_id, employee_id, note) VALUES
(1, 1, 'Interested in bulk purchases.'),
(2, 2, 'Requested a callback regarding product X.'),
(3, 3, 'Issues with recent order delivery.'),
(4, 4, 'Positive feedback on customer service.'),
(5, 5, 'Potential for long-term partnership.');

-- ====================================
-- Dummy Data for Customer_Login Table
-- ====================================
INSERT INTO customer_login (customer_id, username, password) VALUES
(1, 'alice.williams@example.com', 'alicePass1'),
(2, 'bob.brown@example.com', 'bobPass2'),
(3, 'charlie.davis@example.com', 'charliePass3'),
(4, 'diana.evans@example.com', 'dianaPass4'),
(5, 'ethan.foster@example.com', 'ethanPass5');

-- ====================================
-- Dummy Data for Supplier Table
-- ====================================
INSERT INTO supplier (name, email) VALUES
('Tech Supplies Inc.', 'contact@techsupplies.com'),
('Office Essentials', 'sales@officeessentials.com'),
('Gadget World', 'info@gadgetworld.com'),
('Furniture Hub', 'support@furniturehub.com'),
('Software Solutions', 'service@softwaresolutions.com');

-- ====================================
-- Dummy Data for Supplier_Internal_Notes Table
-- ====================================
INSERT INTO supplier_internal_notes (supplier_id, employee_id, note) VALUES
(1, 3, 'Reliable supplier for electronics.'),
(2, 1, 'Offers competitive pricing on office supplies.'),
(3, 5, 'Consistent delivery times.'),
(4, 4, 'High-quality furniture products.'),
(5, 2, 'Excellent software support.');

-- ====================================
-- Dummy Data for Supplier_Address Table
-- ====================================
INSERT INTO supplier_address (supplier_id, address, city, country, zip_code, state, availability) VALUES
(1, '789 Tech Park', 'San Jose', 'USA', '95112', 'CA', 'available'),
(2, '456 Office Blvd', 'Boston', 'USA', '02108', 'MA', 'available'),
(3, '123 Gadget Lane', 'Seattle', 'USA', '98101', 'WA', 'available'),
(4, '321 Furniture St', 'Denver', 'USA', '80202', 'CO', 'available'),
(5, '654 Software Ave', 'Austin', 'USA', '73301', 'TX', 'available');

-- ====================================
-- Dummy Data for Supplier_Contact Table
-- ====================================
INSERT INTO supplier_contact (supplier_id, contact) VALUES
(1, '555-6666'),
(2, '555-7777'),
(3, '555-8888'),
(4, '555-9999'),
(5, '555-0000');

-- ====================================
-- Dummy Data for Warehouse Table
-- ====================================
INSERT INTO warehouse (name, address, city, country, zip_code, state, capacity) VALUES
('Main Warehouse', '1000 Warehouse Way', 'Dallas', 'USA', '75201', 'TX', 20000),
('Secondary Warehouse', '2000 Storage Blvd', 'Atlanta', 'USA', '30301', 'GA', 15000),
('Overflow Warehouse', '3000 Depot Dr', 'Chicago', 'USA', '60601', 'IL', 10000);

-- ====================================
-- Dummy Data for Warehouse_Manager Table
-- ====================================
INSERT INTO warehouse_manager (warehouse_id, employee_id, start_date) VALUES
(1, 3, '2024-01-10'),
(2, 5, '2024-02-20'),
(3, 4, '2024-03-15');

-- ====================================
-- Dummy Data for Warehouse_Contact Table
-- ====================================
INSERT INTO warehouse_contact (warehouse_id, contact, employee_id, start_date) VALUES
(1, 'main.@company.com', 3, '2024-01-10'),
(2, 'secondaehouse@company.com', 5, '2024-02-20'),
(3, 'overflow.wareompany.com', 4, '2024-03-15');

-- ====================================
-- Dummy Data for Product Table
-- ====================================
INSERT INTO product (name, price, stock, description, availability, category, supplier) VALUES
('Laptop Model X', 1200.00, 50, 'High-performance laptop suitable for all purposes.', 'available', 'Electronics', 1),
('Office Chair', 250.00, 200, 'Ergonomic office chair with lumbar support.', 'available', 'Furniture', 4),
('Wireless Mouse', 45.00, 500, 'Bluetooth-enabled wireless mouse with adjustable DPI.', 'available', 'Accessories', 1),
('Standing Desk', 400.00, 150, 'Height-adjustable standing desk for better posture.', 'available', 'Furniture', 4),
('Antivirus Software', 60.00, 300, 'Comprehensive antivirus protection for your devices.', 'available', 'Software', 5);

-- ====================================
-- Dummy Data for Warehouse_Product Table
-- ====================================
INSERT INTO warehouse_product (warehouse_id, product_id, quantity) VALUES
(1, 1, 20),
(1, 2, 50),
(1, 3, 150),
(2, 1, 15),
(2, 4, 40),
(3, 5, 100),
(3, 3, 200);

-- ====================================
-- Dummy Data for Service Table
-- ====================================
INSERT INTO service (product_id, employee_id, name, price, description, availability) VALUES
(1, 3, 'Laptop Setup', 100.00, 'Comprehensive setup and configuration of your new laptop.', 'available'),
(3, 3, 'Mouse Customization', 20.00, 'Customize mouse settings and DPI according to user preference.', 'available'),
(5, 2, 'Software Installation', 80.00, 'Installation and setup of antivirus software on your devices.', 'available');

-- ====================================
-- Dummy Data for Project Table
-- ====================================
INSERT INTO project (name, description, start_date, end_date, status) VALUES
('Website Redesign', 'Revamp the company website for improved user experience.', '2024-01-15', '2024-06-30', 'ongoing'),
('New Product Launch', 'Launch the new Laptop Model X in the North American market.', '2024-02-01', '2024-07-31', 'ongoing'),
('Office Expansion', 'Expand the main office to accommodate more employees.', '2024-03-10', '2024-12-31', 'ongoing');

-- ====================================
-- Dummy Data for Project_Internal_Notes Table
-- ====================================
INSERT INTO project_internal_notes (employee_id, project_id, note) VALUES
(1, 1, 'Focus on mobile responsiveness.'),
(2, 2, 'Coordinate with marketing for launch events.'),
(3, 1, 'Ensure backend scalability.'),
(4, 3, 'Plan workspace layout effectively.'),
(5, 2, 'Secure partnerships with distributors.');

-- ====================================
-- Dummy Data for Project_Employee Table
-- ====================================
INSERT INTO project_employee (project_id, employee_id, start_date, end_date) VALUES
(1, 1, '2024-01-15', '2024-06-30'),
(1, 3, '2024-01-20', '2024-06-25'),
(2, 1, '2024-02-01', '2024-07-31'),
(2, 2, '2024-02-05', '2024-07-25'),
(3, 4, '2024-03-10', '2024-12-31'),
(3, 5, '2024-03-15', '2024-12-15');

-- ====================================
-- Dummy Data for Project_Service Table
-- ====================================
INSERT INTO project_service (project_id, service_id, price, start_date, end_date) VALUES
(1, 1, 100.00, '2024-01-15', '2024-06-30'),
(1, 3, 20.00, '2024-01-20', '2024-06-25'),
(2, 1, 100.00, '2024-02-01', '2024-07-31'),
(2, 3, 20.00, '2024-02-05', '2024-07-25');

-- ====================================
-- Dummy Data for Project_Product Table
-- ====================================
INSERT INTO project_product (project_id, product_id, quantity, price, start_date, end_date) VALUES
(1, 1, 10, 1200.00, '2024-01-15', '2024-06-30'),
(2, 1, 50, 1200.00, '2024-02-01', '2024-07-31'),
(2, 3, 100, 45.00, '2024-02-05', '2024-07-25'),
(3, 2, 50, 250.00, '2024-03-10', '2024-12-31'),
(3, 4, 20, 400.00, '2024-03-15', '2024-12-15');

-- ====================================
-- Dummy Data for Project_Customer Table
-- ====================================
INSERT INTO project_customer (project_id, customer_id, start_date, end_date) VALUES
(2, 1, '2024-02-01', '2024-07-31'),
(2, 2, '2024-02-05', '2024-07-25'),
(3, 3, '2024-03-10', '2024-12-31'),
(3, 4, '2024-03-15', '2024-12-15');

-- ====================================
-- Dummy Data for Project_Manager Table
-- ====================================
INSERT INTO project_manager (project_id, employee_id, start_date, end_date) VALUES
(1, 1, '2024-01-15', '2024-06-30'),
(2, 2, '2024-02-01', '2024-07-31'),
(3, 4, '2024-03-10', '2024-12-31');

-- ====================================
-- Dummy Data for Project_Supplier Table
-- ====================================
INSERT INTO project_supplier (project_id, supplier_id, start_date, end_date) VALUES
(1, 1, '2024-01-15', '2024-06-30'),
(2, 1, '2024-02-01', '2024-07-31'),
(2, 3, '2024-02-05', '2024-07-25'),
(3, 4, '2024-03-10', '2024-12-31'),
(3, 5, '2024-03-15', '2024-12-15');

-- ====================================
-- Dummy Data for Project_Manager Table
-- ====================================
-- Note: This table was already populated above.

-- ====================================
-- Dummy Data for Project_Employee Table
-- ====================================
-- Note: This table was already populated above.

-- ====================================
-- Dummy Data for Project_Service Table
-- ====================================
-- Note: This table was already populated above.

-- ====================================
-- Dummy Data for Project_Product Table
-- ====================================
-- Note: This table was already populated above.

-- ====================================
-- Dummy Data for Project_Customer Table
-- ====================================
-- Note: This table was already populated above.

-- ====================================
-- Dummy Data for Service_Order Table
-- ====================================
INSERT INTO service_order (customer_id, service_id, product_id, employee_id, price, status, payment, paid_amount) VALUES
(1, 1, 1, 1, 100.00, 'ordered', 'unpaid', 0.00),
(2, 3, 3, 1, 20.00, 'done', 'paid', 20.00),
(3, 2, 5, 2, 80.00, 'waiting', 'partially paid', 40.00),
(4, 1, 1, 3, 100.00, 'cancelled', 'unpaid', 0.00),
(5, 3, 3, 5, 20.00, 'done', 'paid', 20.00);

-- ====================================
-- Dummy Data for Product_Order Table
-- ====================================
INSERT INTO product_order (customer_id, employee_id, product_id, quantity, price, status, payment, paid_amount) VALUES
(1, 1, 1, 2, 2400.00, 'ordered', 'unpaid', 0.00),
(2, 2, 2, 5, 1250.00, 'shipped', 'partially paid', 600.00),
(3, 3, 3, 10, 450.00, 'delivered', 'paid', 450.00),
(4, 4, 4, 1, 400.00, 'cancelled', 'unpaid', 0.00),
(5, 5, 5, 3, 180.00, 'ordered', 'unpaid', 0.00);

-- ====================================
-- Dummy Data for Product_Order_Shipment Table
-- ====================================
INSERT INTO product_order_shipment ( start_date, estimated_end_date, actual_end_date) VALUES
( '2024-04-02', '2024-04-07', NULL),
( '2024-04-03', '2024-04-08', '2024-04-07'),
( '2024-04-04', '2024-04-09', '2024-04-08'),
( '2024-04-05', '2024-04-10', NULL);

-- ====================================
-- Dummy Data for Supplier_Orderer_Product Table
-- ====================================
INSERT INTO supplier_orderer_product (supplier_id, product_id, quantity, price, warehouse_id, order_date, status, employee_id, payment, paid_amount) VALUES
(1, 1, 100, 1150.00, 1, '2024-04-01', 'ordered', 3, 'unpaid', 0.00),
(2, 2, 200, 230.00, 1, '2024-04-02', 'shipped', 1, 'paid', 230.00),
(3, 3, 500, 40.00, 3, '2024-04-03', 'delivered', 5, 'paid', 200.00),
(4, 4, 150, 380.00, 2, '2024-04-04', 'cancelled', 4, 'unpaid', 0.00),
(5, 5, 300, 55.00, 3, '2024-04-05', 'ordered', 2, 'partially paid', 150.00);

-- ====================================
-- Dummy Data for Service_Supplier_Order Table
-- ====================================
INSERT INTO service_supplier_order (supplier_id, price, details, order_date, status, employee_id, payment, paid_amount) VALUES
(1, 500.00, 'Bulk purchase of laptops for project X.', '2024-04-01', 'ordered', 3, 'unpaid', 0.00),
(2, 300.00, 'Office chairs for new employees.', '2024-04-02', 'waiting', 1, 'paid', 150.00),
(3, 200.00, 'Wireless mice for all departments.', '2024-04-03', 'done', 5, 'paid', 200.00),
(4, 400.00, 'Standing desks for the main office.', '2024-04-04', 'cancelled', 4, 'unpaid', 0.00),
(5, 150.00, 'Antivirus software licenses.', '2024-04-05', 'done', 2, 'paid', 150.00);

-- ====================================
-- Dummy Data for Supplier_Orderer_Shipment Table
-- ====================================
INSERT INTO supplier_orderer_shipment (supplier_orderer_id, shipment, start_date, estimated_end_date, actual_end_date) VALUES
(1, 100.00, '2024-04-02', '2024-04-07', NULL),
(2, 60.00, '2024-04-03', '2024-04-08', '2024-04-07'),
(3, 40.00, '2024-04-04', '2024-04-09', '2024-04-08'),
(5, 30.00, '2024-04-05', '2024-04-10', NULL);

-- ====================================
-- Dummy Data for Product_Order_Invoice Table
-- ====================================
INSERT INTO product_order_invoice (product_order_id, invoice_number, total_amount, tax, discount, due_date, status) VALUES
(1, 'PO-INV-1001', 2400.00, 240.00, 0.00, '2024-05-01', 'unpaid'),
(2, 'PO-INV-1002', 1250.00, 125.00, 100.00, '2024-05-05', 'paid'),
(3, 'PO-INV-1003', 450.00, 45.00, 0.00, '2024-05-10', 'paid'),
(5, 'PO-INV-1004', 180.00, 18.00, 0.00, '2024-05-15', 'unpaid');

-- ====================================
-- Dummy Data for Service_Order_Invoice Table
-- ====================================
INSERT INTO service_order_invoice (service_order_id, invoice_number, total_amount, tax, discount, due_date, status) VALUES
(1, 'SO-INV-2001', 100.00, 10.00, 0.00, '2024-04-15', 'unpaid'),
(2, 'SO-INV-2002', 20.00, 2.00, 0.00, '2024-04-20', 'paid'),
(3, 'SO-INV-2003', 80.00, 8.00, 0.00, '2024-04-25', 'waiting'),
(5, 'SO-INV-2004', 20.00, 2.00, 0.00, '2024-04-30', 'paid');

-- ====================================
-- Dummy Data for Customer_Review Table
-- ====================================
INSERT INTO customer_review (customer_id, product_id, rating, review) VALUES
(1, 1, 5, 'Excellent laptop! Fast and reliable.'),
(2, 3, 4, 'Good mouse, but could be more ergonomic.'),
(3, 5, 3, 'Antivirus works fine, but the interface is clunky.'),
(4, 2, 5, 'The office chair is very comfortable and sturdy.'),
(5, 4, 4, 'Standing desk helps improve posture.');

-- ====================================
-- Dummy Data for Service_Review Table
-- ====================================
INSERT INTO service_review (customer_id, service_id, rating, review) VALUES
(1, 1, 5, 'Laptop setup was thorough and efficient.'),
(2, 3, 4, 'Mouse customization met my needs.'),
(3, 5, 3, 'Software installation was okay, but took longer than expected.'),
(4, 1, 5, 'Great setup service for my new laptop!'),
(5, 3, 4, 'Quick and professional mouse customization.');

-- ====================================
-- Dummy Data for Employee_Training Table
-- ====================================
INSERT INTO employee_training (employee_id, supplier_id, training_title, description, start_date, end_date, status) VALUES
(1, 1, 'Advanced Sales Techniques', 'Training on advanced sales strategies and customer engagement.', '2024-05-01', '2024-05-05', 'completed'),
(2, 2, 'HR Compliance', 'Comprehensive training on HR policies and compliance.', '2024-06-10', '2024-06-15', 'ongoing'),
(3, 3, 'IT Security Essentials', 'Essential training on IT security protocols and best practices.', '2024-07-20', '2024-07-25', 'cancelled'),
(4, 4, 'Financial Reporting', 'Training on financial analysis and reporting techniques.', '2024-08-15', '2024-08-20', 'completed'),
(5, 5, 'Digital Marketing Strategies', 'Advanced strategies for digital marketing and brand management.', '2024-09-05', '2024-09-10', 'completed');

-- ====================================
-- Dummy Data for Product Table
-- ====================================
-- Already populated above.

-- ====================================
-- Dummy Data for Service Table
-- ====================================
-- Already populated above.

-- ====================================
-- Dummy Data for Orders and Shipments
-- ====================================
-- Already populated above.

-- ====================================
-- Additional Tables (If Any)
-- ====================================

-- You can continue adding dummy data for other tables following the same pattern.
