﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using WebCore.Models.Entities;

namespace WebCore.Context
{
    public partial interface ITestingContextProcedures
    {
        Task<List<SP_GetClientTypeResult>> SP_GetClientTypeAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> SP_TestAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
