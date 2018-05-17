using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    public class UserRepository : IUserRepository
    {
        EcourierDbContext context = new EcourierDbContext();

        public List<User> GetAll()
        {
            return context.Users.ToList();
        }

        public User Get(int id)
        {
            return context.Users.SingleOrDefault(u => u.Userid == id);
        }

        public int Insert(User user)
        {
            user.UserType = "user";
            user.Status = "pending";
            context.Users.Add(user);
            return context.SaveChanges();
        }

        public int Update(User user)
        {
            User userToUpdate = context.Users.SingleOrDefault(u => u.Userid == user.Userid);
            userToUpdate.Password = user.Password;
            userToUpdate.Name = user.Name;
            userToUpdate.Status = user.Status;
            userToUpdate.Phone = user.Phone;
            userToUpdate.Gender = user.Gender;
            userToUpdate.Email = user.Email;
            userToUpdate.DateOfBirth = user.DateOfBirth;
            userToUpdate.City = user.City;
            userToUpdate.Address = user.Address;
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            User userToDelete = context.Users.SingleOrDefault(u => u.Userid == id);
            context.Users.Remove(userToDelete);
            return context.SaveChanges();
        }
    }
}
