using System.Collections.Generic;
using System.Threading.Tasks;
using Tranglo1.Identity.Contracts.Entities;

namespace Tranglo1.Identity.Contracts.DomainServices
{
    public interface IStaffEntityQueryService
    {
        Task<List<TrangloStaffEntityAssignment>> GetTrangloStaffEntityAssignmentById(string loginId);
    }
}
