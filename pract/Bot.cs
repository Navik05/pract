using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract
{
    internal class Bot
    {
        private int status;


        public Bot() 
        {
            status = 1;
        }
        public int getStatus()
        {
            return status;
        }

        public void setStatus(int status) 
        {
            this.status = status;
        }
    }
}
