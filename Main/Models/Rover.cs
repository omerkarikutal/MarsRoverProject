using Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.Models
{
    public class Rover
    {
        public Location RoverLocation { get; set; }
        public Directions RoverDirection { get; set; }
        public Location BaseLocation { get; set; }
        public Rover(Location location, Directions direction, Location baseLocation)
        {
            this.RoverLocation = location;
            this.RoverDirection = direction;
            this.BaseLocation = baseLocation;
        }
        public Response StartCalculateLocation(string map)
        {
            try
            {
                for (int i = 0; i < map.Length; i++)
                {
                    switch (map[i])
                    {
                        case 'L':
                            RoverDirection = (RoverDirection - 1) < Directions.N ? Directions.W : RoverDirection - 1;
                            break;
                        case 'R':
                            RoverDirection = (RoverDirection + 1) > Directions.W ? Directions.N : RoverDirection + 1;
                            break;
                        case 'M':
                            CalculateNewLocation();
                            break;
                    }
                }
                return new Response(true, $"{RoverLocation.X} {RoverLocation.Y} {RoverDirection}");
            }
            catch (Exception e)
            {
                return new Response(false, e.Message);
            }
        }
        private void CalculateNewLocation()
        {
            switch (RoverDirection)
            {
                case Directions.N:
                    RoverLocation.AddYCoordinate(1);
                    break;
                case Directions.E:
                    RoverLocation.AddXCoordinate(1);
                    break;
                case Directions.S:
                    RoverLocation.AddYCoordinate(-1);
                    break;
                case Directions.W:
                    RoverLocation.AddXCoordinate(-1);
                    break;
                default:
                    throw new ArgumentException("Hatalı Yön Değeri");
            }

            if (!IsInLocation())
                throw new Exception("Belirtilmiş bölgenin dışına çıkamazsınız!");
        }
        private bool IsInLocation()
        {
            return !(RoverLocation.X > BaseLocation.X || RoverLocation.X < 0 || RoverLocation.Y > BaseLocation.Y || RoverLocation.Y < 0);
        }
    }
}
