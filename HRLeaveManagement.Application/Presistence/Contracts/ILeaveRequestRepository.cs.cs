using HRLeaveManagement.Application.DTOs.LeaveRequest;
using HRLeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.Presistence.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        object GetLeaveRequestsWithDetails();
        LeaveRequestDto GetLeaveRequestWithDetails(int id);
    }
}
