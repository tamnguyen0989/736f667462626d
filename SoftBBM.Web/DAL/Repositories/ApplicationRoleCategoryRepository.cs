﻿using SoftBBM.Web.DAL.Infrastructure;
using SoftBBM.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftBBM.Web.DAL.Repositories
{

    public interface IApplicationRoleCategoryRepository : IRepository<ApplicationRoleCategory>
    {

    }
    public class ApplicationRoleCategoryRepository : RepositoryBase<ApplicationRoleCategory>, IApplicationRoleCategoryRepository
    {
        public ApplicationRoleCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}