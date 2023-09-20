using System;

namespace AerialVehicleLibrary
{
    public class Engine : AerialVehicle
    {
        public bool IsStarted { get; set; }

        public Engine() 
        {
           this.IsStarted = false;
        }

        public string About()
        {
            if (IsStarted == false)
                return "not started";
            else
                return "started";
        }

        public void start()
        {
            IsStarted= true;
        }

        public void stop()
        {
            IsStarted= false;
        }
    }
}