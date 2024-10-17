using Microsoft.AspNetCore.Mvc;
using MyTrailer.Application.DTOs;
using MyTrailer.Application.Services;
using MyTrailer.Domain.ValueObjects;

namespace MyTrailer.WebAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public IActionResult RegisterCustomer([FromBody] RegisterCustomerDTO customerDto)
        {
            var address = new Address(customerDto.Street, customerDto.City, customerDto.PostalCode);
            _customerService.RegisterCustomer(customerDto.Name, customerDto.Email, address);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById(Guid id)
        {
            var customer = _customerService.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
    }
}
