﻿using AllegyNoThankYouDAL.UOW;

namespace AllegyNoThankYouDAL.Facade
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
