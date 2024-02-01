using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{

    public class EfUserDal : IUserDal
    {
        private readonly RentACarContext _context;

        public EfUserDal(RentACarContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public User Add(User entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.Password = HashPassword(entity.Password);
            _context.Users.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public User Delete(User entity, bool isSoftDelete = true)
        {
            if (isSoftDelete)
            {
                entity.DeletedAt = DateTime.UtcNow;
                _context.Users.Update(entity);
            }
            else
            {
                _context.Users.Remove(entity);
            }

            _context.SaveChanges();
            return entity;
        }


        public User? Get(Func<User, bool> predicate)
        {
            try
            {
                return _context.Users.FirstOrDefault(predicate);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IList<User> GetList(Func<User, bool>? predicate = null)
        {
            IQueryable<User> query = _context.Set<User>();
            if (predicate != null)
                query = query.Where(predicate).AsQueryable();

            return query.ToList();
        }

        public User Update(User entity)
        {
            entity.UpdateAt = DateTime.UtcNow;
            _context.Users.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
