﻿using GameStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GameStore.Data.Services
{
    public class PlatformsService : IPlatformsService
    {
        private readonly AppDbContext _context;
        public PlatformsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Platforms Platforms)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Platforms>> GetAll()
        {
            var result =await _context.Platforms.ToListAsync();
            return result;
        }

        public Platforms GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Platforms Update(int id, Platforms newPlatforms)
        {
            throw new NotImplementedException();
        }
        // Get: Platforms/Create
        public IPlatformsService Create()
        {
            return View();
        }

        private IPlatformsService View()
        {
            throw new NotImplementedException();
        }
    }
}
