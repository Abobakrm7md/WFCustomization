using System;
using WFCustomization.Shared.Kernel.BuildingBlocks;
using WFCustomization.Core.ValueObjects;

namespace WFCustomization.Core.Entities
{
    public class Buyer : IEntity<BuyerId>
    {
        public BuyerId Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public Address Address { get; private set; }
        public DateTime CreatedAt { get; private set; }

        private Buyer() { }

        public Buyer(BuyerId id, string firstName, string lastName, string email, Address address, DateTime createdAt)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            CreatedAt = createdAt;
        }
    }
}
