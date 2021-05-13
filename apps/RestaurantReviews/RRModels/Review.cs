using System;
namespace RRModels
{
    public class Review
    {
        private int _rating;
        public int Rating 
        {   get { return _rating; }
            
            set 
            {
                // set validation logic in properties
                if (_rating < 0)
                {
                    throw new Exception("resturant should not that bad");
                }
                _rating = value; 
            }
        }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"\t Rating: {Rating} \n\t Description: {Description}";
        }
    }
}