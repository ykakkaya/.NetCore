using CompanyFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyFinder.Business.Abstract
{
    public interface ICompanyServices
    {
        List<Company> GetAllCompany();
        Company GetById(int id);
        Company CreateCompany(Company company);
        Company UpdateCompany(Company company);
        void DeleteCompany(int id);
    }
}
