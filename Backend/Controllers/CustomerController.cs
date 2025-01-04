using Backend.Data;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
namespace Backend.Controllers;

[Route("api/[controller]")]
[ApiController]

public class CustomerController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public CustomerController(ApplicationDbContext context)
    {
        _context = context;
    }
    [HttpGet("getAllCustomers")]
    public async Task<ActionResult<List<Customer>>> getAllCustomers(int page, int pageSize)
    {
        return _context.Customers.OrderBy(x => x.CustomerID).Skip((page - 1) * pageSize).Take(pageSize).ToList();

    }
    [HttpGet("getCustomerAllDataByID")]
    public async Task<ActionResult<Tuple<Customer, CustomerAddress, CustomerContact>>> getCustomer(int id)
    {
        var Customer = _context.Customers.Where(x => x.CustomerID == id).First();
        var CustomerAddress = _context.CustomerAddresses.Where(x => x.CustomerID == id).First();
        var CustomerContact = _context.CustomerContacts.Where(x => x.CustomerID == id).First();
        return new Tuple<Customer, CustomerAddress, CustomerContact>(Customer, CustomerAddress, CustomerContact);
    }
    [HttpGet("getCustomerByID")]
    public async Task<ActionResult<Customer>> getCustomerByID(int id){
        var Customer = _context.Customers.Where(x => x.CustomerID == id).First();
        return Customer;
    }
    [HttpGet("getCustomerByName")]
    public async Task<ActionResult<List<Customer>>> getCustomerByName(string name){
        var Customer = _context.Customers.Where(x => x.CustomerName == name).ToList();
        return Customer;
    }

    [HttpGet("getCustomerAddressByID")]
    public async Task<ActionResult<List<CustomerAddress>>> getCustomerAddressByID(int id, int page, int pageSize){
        var CustomerAddress = _context.CustomerAddresses.Where(x => x.CustomerID == id).Skip((page - 1) * pageSize).Take(pageSize).ToList();
        return CustomerAddress;
    }

    [HttpGet("getCustomerContactByID")]
    public async Task<ActionResult<List<CustomerContact>>> getCustomerContactByID(int id, int page, int pageSize){
        var CustomerContact = _context.CustomerContacts.Where(x => x.CustomerID == id).Skip((page - 1) * pageSize).Take(pageSize).ToList();
        return CustomerContact;
    }

    [HttpPost("addCustomer")]
    public async Task<ActionResult<Customer>> addCustomer(Customer customer){
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
        return customer;
    }

    [HttpPost("addCustomerAddress")]
    public async Task<ActionResult<CustomerAddress>> addCustomerAddress(CustomerAddress customerAddress){
        _context.CustomerAddresses.Add(customerAddress);
        await _context.SaveChangesAsync();
        return customerAddress;
    }

    [HttpPost("addCustomerContact")]
    public async Task<ActionResult<CustomerContact>> addCustomerContact(CustomerContact customerContact){
        _context.CustomerContacts.Add(customerContact);
        await _context.SaveChangesAsync();
        return customerContact;
    }

    [HttpPut("updateCustomer")]
    public async Task<ActionResult<Customer>> updateCustomer(Customer customer){
        _context.Customers.Update(customer);
        await _context.SaveChangesAsync();
        return customer;
    }

    [HttpPut("updateCustomerAddress")]
    public async Task<ActionResult<CustomerAddress>> updateCustomerAddress(CustomerAddress customerAddress){
        _context.CustomerAddresses.Update(customerAddress);
        await _context.SaveChangesAsync();
        return customerAddress;
    }
    
    [HttpPut("updateCustomerContact")]
    public async Task<ActionResult<CustomerContact>> updateCustomerContact(CustomerContact customerContact){
        _context.CustomerContacts.Update(customerContact);
        await _context.SaveChangesAsync();
        return customerContact;
    }

    [HttpDelete("deleteCustomer")]
    public async Task<ActionResult<Customer>> deleteCustomer(Customer customer){
        var customerAddress = _context.CustomerAddresses.Where(x => x.CustomerID == customer.CustomerID).ToList();
        var customerContact = _context.CustomerContacts.Where(x => x.CustomerID == customer.CustomerID).ToList();

        foreach(var address in customerAddress){
            _context.CustomerAddresses.Remove(address);
        }
        foreach(var contact in customerContact){
            _context.CustomerContacts.Remove(contact);
        }

        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();
        return customer;
    }

    [HttpDelete("deleteCustomerAddress")]
    public async Task<ActionResult<CustomerAddress>> deleteCustomerAddress(CustomerAddress customerAddress){
        _context.CustomerAddresses.Remove(customerAddress);
        await _context.SaveChangesAsync();
        return customerAddress;
    }

    [HttpDelete("deleteCustomerContact")]
    public async Task<ActionResult<CustomerContact>> deleteCustomerContact(CustomerContact customerContact){
        _context.CustomerContacts.Remove(customerContact);
        await _context.SaveChangesAsync();
        return customerContact; 
    }

    [HttpGet("return1")]

    public async Task<ActionResult<int>> return1(){
        return 1;
    }
    
}