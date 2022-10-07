using CompanyFinder.Business.Abstract;
using CompanyFinder.DataAccess.Abstract;
using CompanyFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyFinder.Business.Concrete
{
    public class CompanyManager : ICompanyServices
    {
        ICompanyRepository _companyRepository;

       

        public CompanyManager(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public Company CreateCompany(Company company)
        {
            _companyRepository.CreateCompany(company);
            return company;
        }

        public void DeleteCompany(int id)
        {
            _companyRepository.DeleteCompany(id); 
        }

        public List<Company> GetAllCompany()
        {
           return _companyRepository.GetAllCompany();
        }

        public Company GetById(int id)
        {
            return _companyRepository.GetById(id);
        }

        public Company UpdateCompany(Company company)
        {
            _companyRepository.UpdateCompany(company);
            return company;
        }
    }
}
