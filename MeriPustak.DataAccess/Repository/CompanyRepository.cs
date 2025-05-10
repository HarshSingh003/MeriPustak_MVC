using MeriPustak.DataAccess.Data;
using MeriPustak.DataAccess.Repository.IRepository;
using MeriPustak.DataAccesss.Repository;
using MeriPustak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeriPustak.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private MeriPustakDbContext _db;
        public CompanyRepository(MeriPustakDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
