using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Demo
{
    public interface ILogger
    {
        void Log(string message);
    }

    internal class SubscriptionSystem
    {
        private ILogger logger;
        
        // Property 

        public ICollection<User> Users { get; set; }

        public SubscriptionSystem(ILogger logger)
        {
            this.Users = new List<User>();
            this.logger = logger;
        }

        internal void Subscribe(User user)
        {
            this.Users.Add(user);
        }

        internal void Charge(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException();
            }

            foreach (var user in this.Users)
            {
                user.Balance += amount;
            }

            logger.Log(amount.ToString()); 
        }
    }
}