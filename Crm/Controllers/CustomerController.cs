
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using AppContext;
using Microsoft.EntityFrameworkCore;
namespace CRM.Controllers{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController:ControllerBase{
        private AppDbContext _context;
        public CustomerController(AppDbContext context)
        {
            this._context=context;
            
        }
        [HttpGet]
        [Route("")]

        public ActionResult<IEnumerable<Customer>> getall(){
            return Ok(_context.Customers);
        }
        [HttpPost]
        [Route("Create")]

        public ActionResult<int> Create(Customer customer){
            if(customer==null
                ||string.IsNullOrEmpty(customer.FirstName)||string.IsNullOrWhiteSpace(customer.FirstName)
                ||string.IsNullOrEmpty(customer.LastName)||string.IsNullOrWhiteSpace(customer.LastName)
                ||string.IsNullOrEmpty(customer.Email)||string.IsNullOrWhiteSpace(customer.Email)
            ){
                return BadRequest("invalid inputs");
            }
            var email=_context.Customers.SingleOrDefault(e=>e.Email==customer.Email);
            if(email!=null){
                return BadRequest("the email is used before");
            }
            try{
                _context.Customers.Add(customer);
                _context.SaveChanges();
            } catch(Exception ex){
                System.Console.WriteLine(ex.Message);
                return BadRequest("invalid operation");
            }
            return Ok("Saved");    
        }


        [HttpPost]
        [Route("Update")]

        public ActionResult<int> Update(int Id,Customer customer){
            var WantedCustomer = _context.Customers.SingleOrDefault(e=>e.Id==Id);
            if(WantedCustomer==null){
                return BadRequest("undefined customer");
            }
            try{
                if(customer==null
                    ||string.IsNullOrEmpty(customer.FirstName)||string.IsNullOrWhiteSpace(customer.FirstName)
                    ||string.IsNullOrEmpty(customer.LastName)||string.IsNullOrWhiteSpace(customer.LastName)
                    ||string.IsNullOrEmpty(customer.Email)||string.IsNullOrWhiteSpace(customer.Email)
                ){
                    return BadRequest("invalid inputs");
                }
                WantedCustomer.FirstName=customer.FirstName;
                WantedCustomer.LastName=customer.LastName;
                WantedCustomer.Email=customer.Email;
                _context.SaveChanges();

            }catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }
            return Ok("updated");
        }



    }
}