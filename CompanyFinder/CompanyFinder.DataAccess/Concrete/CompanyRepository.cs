using CompanyFinder.DataAccess.Abstract;
using CompanyFinder.Entities;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyFinder.DataAccess.Concrete
{

    public class CompanyRepository : ICompanyRepository
    {
        Context _context=new Context();


        public Company CreateCompany(Company company)
        {
            _context.Add(company);
            _context.SaveChanges();
            return company;
        }

        public void DeleteCompany(int id)
        {
            var deletedCompany = GetById(id);
            _context.Remove(deletedCompany);
            _context.SaveChanges();

        }

        public List<Company> GetAllCompany()
        {
            return _context.Companies.ToList();
        }

        public Company GetById(int id)
        {
           return _context.Companies.Find(id);
        }

        public Company UpdateCompany(Company company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
            return company;
            
        }
    }
}
