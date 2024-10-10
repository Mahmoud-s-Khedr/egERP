using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crm.Controllers{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomerController : ControllerBase{

        private readonly AppDbContext _context;
        public CustomerController(AppDbContext context){
            _context = context;
        }

        [HttpGet]
        [Route("Get")]

        public ActionResult<IEnumerable<Customer>> Get(){
            return _context.Customers.ToList();
        }

        [HttpGet]
        [Route("GetAddresses")]

       public ActionResult<IEnumerable<CustomerAddress>> GetAddresses(){
             
            return Ok(_context.CustomerAddresses.ToList());
        }

        [HttpGet]
        [Route("GetContacts")]
        public ActionResult<IEnumerable<CustomerContact>> GetContacts(){
            return Ok(_context.CustomerContacts.ToList());
        }

        [HttpPost]
        [Route("Create")]
        public ActionResult Create(Customer customer){
            try{
                var email=_context.Customers.AsNoTracking().FirstOrDefault(e=>e.Email==customer.Email);
                if(email!=null){
                    return BadRequest("Email already exists");
                }
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return Ok("Created Successfully");    
            }catch(Exception e){
                return BadRequest(e.Message);
            }
           
        }

    }


}