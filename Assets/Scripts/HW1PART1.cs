using System;

namespace DefaultNamespace
{
    public class HW1PART1
    {
        
    }

    public abstract class EntityBase
    {
        public long Id { get; set; }

        public EntityBase()
        {
            Id = CalculateId();
        }
        
        private long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
    
    public class Customer : EntityBase
    {
        public string Description { get; set; }
    }

    public class Store
    {
       //Что-то для этого класса
    }

}