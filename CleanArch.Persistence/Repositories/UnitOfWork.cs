﻿using BlogApp.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly CleanArchDbContext _context;

        private I_IndexRepository _indexRepository;

        public UnitOfWork(CleanArchDbContext context)
        {
            _context = context;
        }

        public I_IndexRepository _IndexRepository { 
            get 
            {
                if (_indexRepository == null)
                    _indexRepository = new _IndexRepository(_context);
                return _indexRepository; 
            } 
         }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
