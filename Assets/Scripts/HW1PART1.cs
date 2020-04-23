using System;

namespace DefaultNamespace
{
    public class HW1PART1
    {
        
    }
    
    public class Customer
    {
        public long Id { get; set; }
        public string Description { get; set; }

        public Customer()
        {
            Id = CalculateId();
        }

        private long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }

    public class Store
    {
        public long Id { get; set; }

        public Store()
        {
            Id = CalculateId();
        }

        private long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }

}