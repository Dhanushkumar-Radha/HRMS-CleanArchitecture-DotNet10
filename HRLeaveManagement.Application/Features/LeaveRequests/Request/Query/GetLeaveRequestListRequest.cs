using HRLeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRLeaveManagement.Application.Features.LeaveRequests.Request.Query
{
    public  class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDto>>
    {
    }
}
