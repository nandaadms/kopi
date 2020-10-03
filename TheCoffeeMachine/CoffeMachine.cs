using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;

        public CoffeMechine(CoffePowder powder, WaterGalon galon)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
        }

        public string makeCappuccino()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "sorry,the water is empty";

            }
            if (!this.coffePowder.isAvailable())
            {
                return "sorry,the water is empty";
            }

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "yey ! your coffe is ready";

        }

        public string checkAvailability()
        {
            return $"the water : {this.waterGalon.getVolume()}end the coffe powder : {this.coffePowder.getNetto()}";
        }

    }
}
