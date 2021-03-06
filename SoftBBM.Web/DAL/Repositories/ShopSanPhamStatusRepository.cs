﻿using SoftBBM.Web.DAL.Infrastructure;
using SoftBBM.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftBBM.Web.DAL.Repositories
{
    public interface IShopSanPhamStatusRepository : IRepository<shop_sanphamStatus>
    {

    }
    public class ShopSanPhamStatusRepository : RepositoryBase<shop_sanphamStatus>, IShopSanPhamStatusRepository
    {
        public ShopSanPhamStatusRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}