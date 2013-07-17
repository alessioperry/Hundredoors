using System.Collections.Generic;

namespace Hundredoors
{
    public class Tunnel
    {
        private readonly List<Door> tunnel;

        public Tunnel(int doors)
        {
            tunnel = new List<Door>();

            for (var i = 0; i < doors; i++)
            {
               tunnel.Add(new Door(Status.Closed)); 
            }
        }

        public Door GetDoor(int position)
        {
            return tunnel[position];
        }
    }
}