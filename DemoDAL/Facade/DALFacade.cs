﻿using CustomerAppDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using CustomerAppDAL.UOW;

namespace DemoDAL.Facade
{
    public class DALFacade : IDALFacade
    {
        DbOptions opt;
        public DALFacade(DbOptions opt){
            this.opt = opt;
        }

        public IUnitOfWork UnitOfWork
		{
			get
			{
                return new UnitOfWork(opt);
			}
		}

    }
}
