using fantasy_app.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace fantasy_app.EntityFramework.Services.Common
{
    public class NonQueryDataService<T> where T:DomainObject 
    {
        private readonly DesignTimeDbContextFactory _contextFactory;

        public NonQueryDataService(DesignTimeDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }


    }
}
