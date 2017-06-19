using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tafel
    {
        private int tafelID { get; set; }
        private string status { get; set; }
        private int capaciteit { get; set; }
        private int bezetDoor { get; set; }

        public Tafel()
        {

        }

        public Tafel(int tafelID, string status, int capaciteit, int bezetDoor)
        {
            this.tafelID = tafelID;
            this.status = status;
            this.capaciteit = capaciteit;
            this.bezetDoor = bezetDoor;
        }
    }
}