using CompanyFinder.Business.Abstract;
using CompanyFinder.Business.Concrete;
using CompanyFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyFinder : ControllerBase
    {
        ICompanyServices _cm;

        public CompanyFinder(ICompanyServices cm)
        {
            _cm = cm;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var company= _cm.GetAllCompany();
            return Ok(company);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var company= _cm.GetById(id);

            if (company != null)
            {

                return Ok(company);
            }
            else
            {
                return NotFound();    
            }
            
        }

        [HttpPost]
        public IActionResult AddCompany([FromBody] Company company)
        {
            var createdcompany= _cm.CreateCompany(company);
            return Ok(createdcompany);
        }

        [HttpPut]
        public IActionResult PutCompany([FromBody] Company company)
        {
            if (GetById(company.CompanyId) != null)
            {
                var updateCompany= _cm.UpdateCompany(company);
                return Ok(updateCompany);
            }
            else
            {
                return NotFound();
            }
            
           
             
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCompany(int id)
        {
                 _cm.DeleteCompany(id);
                return Ok();
           
        }

    }
}
