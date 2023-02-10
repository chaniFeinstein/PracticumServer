using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class UserRepository : IUser<User>
    {
        IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }
        public async Task<User> AddAsync(User entity)
        {
            EntityEntry<User> newOne = _context.UserContext.Add(entity);

            await _context.SaveChangesAsync();
            return newOne.Entity;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.UserContext.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.UserContext.FindAsync(id);
        }
    
    }
}
