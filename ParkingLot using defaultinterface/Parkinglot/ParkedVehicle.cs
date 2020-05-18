namespace Parkinglot
{
    

    class ParkedVehicle
    {
        public string vehicleId { get; set; }
        public string vehicleType { get; set; }
        public int floors { get; set; }
        public int spots { get; set; }
        
        public bool isadvanced { get; set; }

        public ParkedVehicle(string type, string id, int floor, int spot,bool isadvanced)
        {
            this.vehicleId = id;
            this.vehicleType = type;
            this.floors = floor;
            this.spots = spot;
            this.isadvanced = isadvanced;
           
        }
    }
    }

