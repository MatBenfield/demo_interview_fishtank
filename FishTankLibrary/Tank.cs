using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FishTankLibrary
{
    public class Tank
    {
        public List<Fish> Fish;

        public Tank()
        {
            Fish = new List<Fish>();
        }

        public void AddFish(Fish fish)
        {
            if (Fish.All(p => p.Name != fish.Name))
                Fish.Add(fish);
            else
                throw new DuplicateNameException($"A fish with this name ({fish.Name}) already exists");
        }

        public double Feed()
        {
            var result = 0.0;
            Fish.ForEach(f => result += f.AmountOfFoodRequiredInGrams);
            return result;
        }

        public string Count()
        {
            return Fish.Count.ToString();
        }

        public string GetNames()
        {
            return string.Join(", ", Fish.Select(f => f.Name));

        }
    }
}