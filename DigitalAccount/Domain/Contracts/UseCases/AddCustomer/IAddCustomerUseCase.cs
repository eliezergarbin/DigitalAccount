using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.UseCases.AddCustomer
{
    public interface IAddCustomerUseCase
    {
        void AddCustomer(Entities.Customer customer);
    }
}
