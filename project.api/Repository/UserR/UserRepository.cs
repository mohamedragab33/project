﻿using project.api.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.api.Repository.UserR
{
    public  class UserRepository : IUserRepository, IDisposable
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext conn )
        {
            _context = conn;
        }

        public void AddUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

           
            user.ID_User = Guid.NewGuid();

            foreach (var posts in user.Posts)
            {
                posts.ID_Post = Guid.NewGuid();
            }

            _context.User.Add(user);
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers(string mainCategory)
        {
            throw new NotImplementedException();
        }

        public User GetUser(Guid userId)
        {
            if (userId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            return _context.User.FirstOrDefault(a => a.ID_User == userId);
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.User.ToList<User>();
        }

        public IEnumerable<User> GetUsers(IEnumerable<Guid> userIds)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(User userId)
        {
            throw new NotImplementedException();
        }
    }

        
    }

