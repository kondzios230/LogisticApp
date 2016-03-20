using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.ValueObjects;
using CommonComponents;
namespace Domain.ValueObjects.Repositories
{
    public interface IOrderDocumentRepository : IGenericRepository<OrderDocument>
    {
    }
}
