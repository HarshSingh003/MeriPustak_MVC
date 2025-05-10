using MeriPustak.DataAccess.Data;
using MeriPustak.DataAccess.Repository;
using MeriPustak.DataAccess.Repository.IRepository;
using MeriPustak.DataAccesss.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeriPustak.DataAccesss.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MeriPustakDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public UnitOfWork(MeriPustakDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRepository(_db);
        }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
