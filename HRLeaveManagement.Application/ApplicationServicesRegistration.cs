using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HRLeaveManagement.Application
{
    public  class ApplicationServicesRegistration
    {
        public ApplicationServicesRegistration(IServiceCollection services)
        {
         //services.AddAutoMapper(typeof(ApplicationServicesRegistration));
         services.AddAutoMapper(Assembly.GetExecutingAssembly());
          
        }
    }
}
