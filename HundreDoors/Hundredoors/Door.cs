using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundredoors
{
    public class Door
    {
        private Status status;

        public Door(Status status)
        {
            this.status = status;
        }

        public void Toogle()
        {
            status = status == Status.Closed ? Status.Open : Status.Closed;
        }

        public Status GetSatus()
        {
            return status;
        }
    }
}
