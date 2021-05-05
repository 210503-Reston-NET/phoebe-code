using System.Collections.Generic;
namespace RRModels
{
    public class Restaurant
    {
        public Restaurant() {}
        public Restaurant(string name, string city, string state)
        {
            this.Name = name;
            this.City = city;
            this.State = state;
        }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public List<Review> Reviews { get; set; }

        public override string ToString()
        {
            return $" Name: {Name} \n Location: {City}, {State}";
        }
    }
}