using PayrollManagementSystem.Core.Entities;

namespace PayrollManagementSystem.Core.Interfaces
{
    public interface ILeaveRepository
    {
        Task<Leave> Create(Leave Leave);
        Task<Leave> Update(Leave Leave);
        Task<bool> Delete(Guid LeaveId);
        Task<List<Leave>> GetAll();
        Task<Leave> GetById(Guid LeaveId);
    }
}
