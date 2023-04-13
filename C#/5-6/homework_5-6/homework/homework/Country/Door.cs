using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using methods;

using SouthKorea;
using France;
using UnitedKingstom;

namespace homework_5_6
{
    public class DoorForCountry
    {
        public bool isMorePopulation(city first, city second)
        {

            return first.Population > second.Population;
        }

        public city switchCity(int select)
        {
            switch (select)
            {
                case 1:
                    return new Seoul();
                case 2:
                    return new Paris();
                case 3:
                    return new London();
            }
            return null;
        }

        public void Start()
        {
            int first = 0;
            int second = 0;

            Console.WriteLine(isMorePopulation(new Seoul(), new London()));
            while (first < 1 || first > 3) { first = alg.toIntTryParse("Enter first country (1.South Korea, 2.France, 3.United Kingstom)"); }
            city firstCity=switchCity(first);
            
            while (second < 1 || second > 3 || second==first) { second = alg.toIntTryParse("Enter second country (1.South Korea, 2.France, 3.United Kingstom) no first country"); }
            city secondCity = switchCity(second);

            Console.WriteLine($"Больше ли {firstCity.ToString()}, чем {secondCity.ToString()}? {isMorePopulation(firstCity, secondCity)}");


        }
    }
}
