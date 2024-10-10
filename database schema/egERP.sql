

create table department(
                           id int primary key auto_increment,
                           name varchar(30),
                           description varchar(300)
);
create table admin(
                      id int primary key auto_increment,
                      username varchar(30),
                      password varchar(30),
                      authority varchar(30) default 'xxx',
                      department int,
                      foreign key (department) references department(id) on delete cascade
);

create index admin_username on admin(username,password);


create table employee(
                         id int primary key auto_increment,
                         first_name varchar(30),
                         last_name varchar(30),
                         email varchar(30),
                         net_salary double(10,2),
                         department int,
                         gender enum('male','female'),
                         birth_date datetime,
                         join_date datetime default current_timestamp,
                         job_title varchar(30),
                         rete_of_sale int default 0,
                         authority varchar(30),
                         foreign key (department) references department(id) on delete cascade
)

create index employee_email on employee(email,department);

create table employee_address(
                                 id int primary key auto_increment,
                                 employee_id int,
                                 address varchar(30),
                                 city varchar(30),
                                 country varchar(30),
                                 zip_code varchar(30),
                                 state varchar(30),
                                 availability enum('available','not available'),
                                 foreign key (employee_id) references employee(id) on delete cascade
)

create table employee_contact(
                                 id int primary key auto_increment,
                                 employee_id int,
                                 contact varchar(30),
                                 foreign key (employee_id) references employee(id) on delete cascade
)

create table employee_attendance(
                                    id int primary key auto_increment,
                                    employee_id int,
                                    date datetime default current_timestamp,
                                    status enum('on-time','late'),
                                    foreign key (employee_id) references employee(id) on delete cascade
)

create index employee_attendance_employee_id on employee_attendance(employee_id,date);

create table employee_leave(
                               id int primary key auto_increment,
                               employee_id int,
                               start_date datetime default current_timestamp,
                               end_date datetime,
                               status enum('pending','approved','rejected'),
                               foreign key (employee_id) references employee(id) on delete cascade
);
--need to be discussed
create index employee_leave_employee_id on employee_leave(employee_id,start_date,end_date);

create table employee_payroll(
                                 id int primary key auto_increment,
                                 employee_id int,
                                 months datetime default current_timestamp,
                                 tax double(10,2),
                                 deduction double(10,2),
                                 bonus double(10,2),
                                 rate double(10,2) default 0.0,
                                 foreign key (employee_id) references employee(id) on delete cascade
)

create index employee_payroll_employee_id on employee_payroll(employee_id,months);

create table user_login(
                           employee_id int primary key,
                           username varchar(30),
                           password varchar(30),
                           foreign key (employee_id) references employee(id) on delete cascade,
                               foreign key (username) references employee(email) on delete cascade
);
create index user_login_employee_id on user_login(username,password);

/*continue departments*/
create table department_manager(
                                   id int primary key auto_increment,
                                   department_id int,
                                   employee_id int,
                                   start_date datetime default current_timestamp,
                                   foreign key (employee_id) references employee(id) on delete cascade,
                                   foreign key (department_id) references department(id) on delete cascade
)

create table department_contact(
                                   id int primary key auto_increment,
                                   department_id int,
                                   contact varchar(30),
                                   employee_id int,
                                   start_date datetime default current_timestamp,
                                   foreign key (employee_id) references employee(id) on delete cascade,
                                   foreign key (department_id) references department(id) on delete cascade
)

create index department_contact_department_id on department_contact(department_id,contact);

/*start outsider "suppliers, customers"*/

create table customer(
                         id int primary key auto_increment,
                         first_name varchar(30),
                         last_name varchar(30),
                         email varchar(30)
)

create index customer_email on customer(last_name,first_name);

create table customer_address(
                                 id int primary key auto_increment,
                                 customer_id int,
                                 address varchar(30),
                                 city varchar(30),
                                 country varchar(30),
                                 zip_code varchar(30),
                                 state varchar(30),
                                 availability enum('available','not available'),
                                 foreign key (customer_id) references customer(id) on delete cascade
)

create table customer_contact(
                                 id int primary key auto_increment,
                                 customer_id int,
                                 contact varchar(30),
                                 foreign key (customer_id) references customer(id) on delete cascade
)

create index customer_contact_customer_id on customer_contact(customer_id);

create table customer_internal_notes(
                                        id int primary key auto_increment,
                                        customer_id int,
                                        employee_id int,
                                        note varchar(300),
                                        date datetime default current_timestamp,
                                        foreign key (customer_id) references customer(id) on delete cascade,
                                        foreign key (employee_id) references employee(id) on delete cascade
)

create table customer_login(
                               customer_id int primary key,
                               username varchar(30),
                               password varchar(30),
                               foreign key (customer_id) references customer(id) on delete cascade
)


create table supplier(
                         id int primary key auto_increment,
                         name varchar(30),
                         email varchar(30)
)

create index supplier_email on supplier(name);


create table supplier_internal_notes(
                                        id int primary key auto_increment,
                                        supplier_id int,
                                        employee_id int,
                                        note varchar(300),
                                        date datetime default current_timestamp,
                                        foreign key (supplier_id) references supplier(id) on delete cascade,
                                        foreign key (employee_id) references employee(id) on delete cascade
)

create table supplier_address(
                                 id int primary key auto_increment,
                                 supplier_id int,
                                 address varchar(30),
                                 city varchar(30),
                                 country varchar(30),
                                 zip_code varchar(30),
                                 state varchar(30),
                                 availability enum('available','not available'),
                                 foreign key (supplier_id) references supplier(id) on delete cascade
)

create table supplier_contact(
                                 id int primary key auto_increment,
                                 supplier_id int,
                                 contact varchar(30),
                                 foreign key (supplier_id) references supplier(id) on delete cascade
)

create index supplier_contact_supplier_id on supplier_contact(supplier_id);

/*continue company employee, warehouse, product,services,project*/

create table employee_training(
                                  id int primary key auto_increment,
                                  employee_id int,
                                  supplier_id int,
                                  training_title varchar(30),
                                  description varchar(300),
                                  start_date datetime default current_timestamp,
                                  end_date datetime default current_timestamp,
                                  status enum('ongoing','completed','cancelled'),
                                  foreign key (employee_id) references employee(id) on delete cascade,
                                  foreign key (supplier_id) references supplier(id) on delete cascade
)

create index employee_training_employee_id on employee_training(employee_id,training_title);
create index employee_training_date on employee_training(start_date,end_date);

create table warehouse(
                          id int primary key auto_increment,
                          name varchar(30),
                          address varchar(30),
                          city varchar(30),
                          country varchar(30),
                          zip_code varchar(30),
                          state varchar(30),
                          capacity int
)

create index warehouse_name on warehouse(name);

create table warehouse_manager(
                                  id int primary key auto_increment,
                                  warehouse_id int,
                                  employee_id int,
                                  start_date datetime default current_timestamp,
                                  foreign key (employee_id) references employee(id) on delete cascade,
                                  foreign key (warehouse_id) references warehouse(id) on delete cascade
)

create index warehouse_manager_warehouse_id on warehouse_manager(warehouse_id,employee_id);

create table warehouse_contact(
                                  id int primary key auto_increment,
                                  warehouse_id int,
                                  contact varchar(30),
                                  employee_id int,
                                  start_date datetime default current_timestamp,
                                  foreign key (employee_id) references employee(id) on delete cascade,
                                  foreign key (warehouse_id) references warehouse(id) on delete cascade
)

create index warehouse_contact_warehouse_id on warehouse_contact(warehouse_id,employee_id);

create table product(
                        id int primary key auto_increment,
                        name varchar(30),
                        price double(10,2),
                        stock int,
                        description varchar(300),
                        availability enum('available','not available','available online'),
                        category varchar(30),
                        supplier int,
                        foreign key (supplier) references supplier(id) on delete cascade
)

create index product_name on product(name,category,supplier);

create table warehouse_product(
                                  id int primary key auto_increment,
                                  warehouse_id int,
                                  product_id int,
                                  quantity int,
                                  foreign key (product_id) references product(id) on delete cascade,
                                  foreign key (warehouse_id) references warehouse(id) on delete cascade
)

create index warehouse_product_warehouse_id on warehouse_product(warehouse_id,product_id);

create table service(
                        id int primary key auto_increment,
                        product_id int,
                        employee_id int,
                        name varchar(30),
                        price double(10,2),
                        description varchar(300),
                        availability enum('available','not available'),
                        foreign key (product_id) references product(id) on delete cascade,
                        foreign key (employee_id) references employee(id) on delete cascade
)

create index service_product_id on service(name,employee_id,product_id);

create table project(
                        id int primary key auto_increment,
                        name varchar(30),
                        description varchar(300),
                        start_date datetime default current_timestamp,
                        end_date datetime default current_timestamp,
                        status enum('ongoing','completed','cancelled')
)

create index project_name on project(name);
create index project_date on project(start_date,end_date);


create table project_internal_notes(
                                       id int primary key auto_increment,
                                       employee_id int,
                                       project_id int,
                                       note varchar(300),
                                       date datetime default current_timestamp,
                                       foreign key (employee_id) references employee(id) on delete cascade,
                                       foreign key (project_id) references project(id) on delete cascade
)

create table project_employee(
                                 id int primary key auto_increment,
                                 project_id int,
                                 employee_id int,
                                 start_date datetime default current_timestamp,
                                 end_date datetime default current_timestamp,
                                 foreign key (project_id) references project(id) on delete cascade,
                                 foreign key (employee_id) references employee(id) on delete cascade
)

create index project_employee_project_id on project_employee(project_id,employee_id);

create index project_employee_date on project_employee(start_date,end_date);

create table project_service(
                                id int primary key auto_increment,
                                project_id int,
                                service_id int,
                                price double(10,2),
                                start_date datetime default current_timestamp,
                                end_date datetime default current_timestamp,
                                foreign key (project_id) references project(id) on delete cascade,
                                foreign key (service_id) references service(id) on delete cascade
)

create index project_service_project_id on project_service(project_id,service_id);

create table project_product(
                                id int primary key auto_increment,
                                project_id int,
                                product_id int,
                                quantity int,
                                price double(10,2),
                                start_date datetime default current_timestamp,
                                end_date datetime default current_timestamp,
                                foreign key (project_id) references project(id) on delete cascade,
                                foreign key (product_id) references product(id) on delete cascade
)

create index project_product_project_id on project_product(project_id,product_id);

create table project_customer(
                                 id int primary key auto_increment,
                                 project_id int,
                                 customer_id int,
                                 start_date datetime default current_timestamp,
                                 end_date datetime default current_timestamp,
                                 foreign key (project_id) references project(id) on delete cascade,
                                 foreign key (customer_id) references customer(id) on delete cascade
)

create index project_customer_project_id on project_customer(project_id,customer_id);

create index project_customer_date on project_customer(start_date,end_date);

create table project_manager(
                                id int primary key auto_increment,
                                project_id int,
                                employee_id int,
                                start_date datetime default current_timestamp,
                                end_date datetime default current_timestamp,
                                foreign key (project_id) references project(id) on delete cascade,
                                foreign key (employee_id) references employee(id) on delete cascade
)

create index project_manager_project_id on project_manager(project_id,employee_id);

create index project_manager_date on project_manager(start_date,end_date);

create table project_supplier(
                                 id int primary key auto_increment,
                                 project_id int,
                                 supplier_id int,
                                 start_date datetime default current_timestamp,
                                 end_date datetime default current_timestamp,
                                 foreign key (project_id) references project(id) on delete cascade,
                                 foreign key (supplier_id) references supplier(id) on delete cascade
)

create index project_supplier_project_id on project_supplier(project_id,supplier_id);

create index project_supplier_date on project_supplier(start_date,end_date);

/*finish with orders and invoices*/
create table product_order(
                              id int primary key auto_increment,
                              customer_id int,
                              employee_id int,
                              product_id int,
                              quantity int,
                              price double(10,2),
                              order_date datetime default current_timestamp,
                              status enum('ordered','shipped','delivered','cancelled'),
                              payment enum('paid','unpaid','partially paid'),
                              paid_amount double(10,2),
                              foreign key (customer_id) references customer(id) on delete cascade,
                              foreign key (employee_id) references employee(id) on delete cascade,
                              foreign key (product_id) references product(id) on delete cascade
)

create index product_order_date on product_order(order_date);

create index product_order_status_payment on product_order(payment,status);

create index product_order_product_id on product_order(product_id);

create index product_order_employee_id on product_order(employee_id);

create table product_order_shipment(
                                       product_order_id int primary key,
                                       start_date datetime default current_timestamp,
                                       estimated_end_date datetime default current_timestamp,
                                       actual_end_date datetime default current_timestamp,
                                       foreign key (product_order_id) references product_order(id) on delete cascade
);
create index product_order_shipment_date on product_order_shipment(start_date,estimated_end_date,actual_end_date);

create table service_order(
                              id int primary key auto_increment,
                              customer_id int,
                              service_id int,
                              product_id int,
                              employee_id int,
                              price double(10,2),
                              order_date datetime default current_timestamp,
                              status enum('ordered','waiting','done','cancelled'),
                              payment enum('paid','unpaid','partially paid'),
                              paid_amount double(10,2),
                              foreign key (customer_id) references customer(id) on delete cascade,
                              foreign key (service_id) references service(id) on delete cascade,
                              foreign key (product_id) references product(id) on delete cascade,
                              foreign key (employee_id) references employee(id) on delete cascade
)

create index service_order_date on service_order(order_date);

create index service_order_status_payment on service_order(payment,status);

create index service_order_employee_id on service_order(employee_id);

create index service_order_product_id on service_order(product_id);

create table supplier_orderer_product(
                                         id int primary key auto_increment,
                                         supplier_id int,
                                         product_id int,
                                         quantity int,
                                         price double(10,2),
                                         warehouse_id int,
                                         order_date datetime default current_timestamp,
                                         status enum('ordered','shipped','delivered','cancelled'),
                                         employee_id int,
                                         payment enum('paid','unpaid','partially paid'),
                                         paid_amount double(10,2),
                                         foreign key (supplier_id) references supplier(id) on delete cascade,
                                         foreign key (product_id) references product(id) on delete cascade,
                                         foreign key (warehouse_id) references warehouse(id) on delete cascade,
                                         foreign key (employee_id) references employee(id) on delete cascade
)

create index supplier_orderer_product_date on supplier_orderer_product(order_date);

create index supplier_orderer_product_status_payment on supplier_orderer_product(payment,status);

create index supplier_orderer_product_product_id on supplier_orderer_product(product_id);

create index supplier_orderer_product_employee_id on supplier_orderer_product(employee_id);

create index supplier_orderer_product_warehouse_id on supplier_orderer_product(warehouse_id);

create table service_supplier_order(
                                       id int primary key auto_increment,
                                       supplier_id int,
                                       price double(10,2),
                                       details varchar(300),
                                       order_date datetime default current_timestamp,
                                       status enum('ordered','waiting','done','cancelled'),
                                       employee_id int,
                                       payment enum('paid','unpaid'),
                                       paid_amount double(10,2),
                                       foreign key (supplier_id) references supplier(id) on delete cascade,
                                       foreign key (employee_id) references employee(id) on delete cascade
)

create index service_supplier_order_date on service_supplier_order(order_date);

create index service_supplier_order_status_payment on service_supplier_order(payment,status);

create index service_supplier_order_employee_id on service_supplier_order(employee_id);

create table supplier_orderer_shipment(
                                          supplier_orderer_id int,
                                          shipment_id int primary key auto_increment,
                                          shipment double(10,2) default 0.0,
                                          start_date datetime default current_timestamp,
                                          estimated_end_date datetime default current_timestamp,
                                          actual_end_date datetime default current_timestamp,
                                          foreign key (supplier_orderer_id) references supplier_orderer_product(id) on delete cascade
)

create index supplier_orderer_shipment_date on supplier_orderer_shipment(start_date,estimated_end_date,actual_end_date);

/* customer review ***/

/****performance optimization***/
