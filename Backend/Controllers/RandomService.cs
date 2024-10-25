using Backend.services;

namespace Backend.Controllers
{
    public class RandomService : IRandomServices
    {
        public readonly int _value;
        public int Value {
            get => _value;
        }

        public RandomService() 
        { 
            _value = new Random().Next(1000);
        }
    }
}
