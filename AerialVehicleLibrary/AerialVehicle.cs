
using System;

namespace AerialVehicleLibrary
{
    public abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }

        public Engine Engine { get; set; }

        public bool IsFlying { get; set; }

        public int MaxAltitude { get; set; }

        

        public AerialVehicle()
        {
            this.Engine= new Engine();
            IsFlying=false;
            CurrentAltitude = 0;
          
        }

        public string About()
        {
            return $"This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.\nIt's current altitude is {CurrentAltitude} ft.\nOOPFlyingVehicle.Engine is {getEngineStartedString()}.";
        }

        public string TakeOff()
        {
                if(Engine.IsStarted == true)
                return "OOPFlyingVehicle.Airplane is flying";  
                else
                return "OOPFlyingVehicle.Airplane can't fly it's engine is not started.";

        }

        public void StartEngine()
        {
            Engine.IsStarted = true;
            getEngineStartedString();
        }

        public void FlyDown(int howMuch)
        {

            if (howMuch <= 41000)
                CurrentAltitude = 0;
            else
                CurrentAltitude = 41000;

        }

        public void FlyUp()
        {
            CurrentAltitude = 1000;
            if (CurrentAltitude >= 0)
            {
                IsFlying = true;
            }
        }

        public void FlyUp(int HowMuch)
        {
           if(HowMuch <= 41000)
            CurrentAltitude= HowMuch + CurrentAltitude;
           else
            CurrentAltitude= 1000;
        }

        public string getEngineStartedString()
        {
            if (Engine.IsStarted == true)
                return "started";
            else
                return "not started";
        }
    }
}