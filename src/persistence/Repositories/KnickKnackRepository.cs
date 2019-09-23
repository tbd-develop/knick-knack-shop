using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using models;
using persistence.Contracts;
using viewmodels;

namespace persistence.Repositories
{
    public class KnickKnackRepository : Repository<KnickKnack>, IKnickKnackRepository
    {
        public KnickKnackRepository(DbContext context) : base(context)
        {

        }

        public IEnumerable<KnickKnackViewModel> GetAllKnickKnacksForName(string name)
        {
            var knickKnacks = from x in Get()
                              where x.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase)
                              select new KnickKnackViewModel
                              {
                                  Id = x.Id,
                                  Name = x.Name,
                                  PricePaid = x.PricePaid,
                                  Valuation = x.Valuation,
                              };

            return knickKnacks;
        }
    }
}