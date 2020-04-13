﻿using Leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_management.Contracts
{
    public interface ILeaveTypeRespository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}
