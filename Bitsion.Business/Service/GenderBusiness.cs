﻿using Bitsion.ContextData;
using Bitsion.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bitsion.Business.Service
{
    public class GenderBusiness
    {
        public List<Gender> GenderList()
        {
            using (var db = new BitsionDB())
            {
                return db.Genders.ToList();
            }
        }
    }
}