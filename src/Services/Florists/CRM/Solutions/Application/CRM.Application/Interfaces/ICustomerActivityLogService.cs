using System.Collections.Generic;
using System.Threading.Tasks;
using CRM.Domain.Models;

namespace CRM.Application.Interfaces
{
    public interface ICustomerActivityLogService
    {
        Task<IEnumerable<CustomerActivityLogDerivedModel>> GetCustomerActivityLog(SearchCustomerActivityLog searchCustomerActivityLog);
    }
}