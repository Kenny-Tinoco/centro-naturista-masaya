﻿using MasayaNaturistCenter.DAO.DAOInterfaces;
using MasayaNaturistCenter.Model.Entities;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace MasayaNaturistCenter.DAO.SqlServer
{
    public class ConsultDAOSQL : BaseDAOSQL, ConsultDAO
    {
        public ConsultDAOSQL(MasayaNaturistCenterDataBase dataBaseContext) : base(dataBaseContext)
        {
            entity = dataBaseContext.Consult;
        }

    }
}
