using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WondersOfTheWorld;

namespace homework_5_6
{
    public class Door
    {
        public void Start()
        {
            GreatPyramidOfGiza greatPyramidOfGiza = new GreatPyramidOfGiza();
            ColossusOfRhodes colossusOfRhodes = new ColossusOfRhodes();
            HangingGardensOfBabylon hangingGardensOfBabylon = new HangingGardensOfBabylon();
            LighthouseOfAlexandria lighthouseOfAlexandria = new LighthouseOfAlexandria();
            MausoleumAtHalicarnassus mausoleumAtHalicarnassus = new MausoleumAtHalicarnassus();
            StatueOfZeusAtOlympia statueOfZeusAtOlympia = new StatueOfZeusAtOlympia();
            TempleOfArtemis templeOfArtemis = new TempleOfArtemis();
            greatPyramidOfGiza.print();
            colossusOfRhodes.print();
            hangingGardensOfBabylon.print();
            lighthouseOfAlexandria.print();
            mausoleumAtHalicarnassus.print();
            statueOfZeusAtOlympia.print();
            templeOfArtemis.print();
        }
    }
}
