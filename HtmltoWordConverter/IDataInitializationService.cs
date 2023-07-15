using HtmltoWordConverter.Models;
using System.Collections.Generic;

namespace HtmltoWordConverter
{
    public interface IDataInitializationService
    {
        List<Company> GetCompanies();
        List<Client> getClients();
        List<Department> getDepartments();
        List<Observation1> getObservations();
        List<Products> GetProducts();
        List<SubDepartment> GetSubDepartments(int id);

        //void InitializeData();
    }
}
