using DataLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete.EfCore
{
    public class EfCoreCustomerRepository : EfCoreGenericRepository<Customer>, ICustomerRepository
    {
        public EfCoreCustomerRepository(Context context) : base(context)
        {

        }

        private Context Context
        {
            get { return context as Context; }
        }

    }
}
