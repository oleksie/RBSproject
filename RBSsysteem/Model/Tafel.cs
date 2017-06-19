using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tafel
    {
        public int Id { get; private set; }
        public string Status { get; private set; }
        public int Capaciteit { get; private set; }
        public int BezetDoor { get; private set; }
        
        public Tafel(int tafelId, string status, int capaciteit, int bezetDoor)
        {
            this.Id = tafelId;
            this.Status = status;
            this.Capaciteit = capaciteit;
            this.BezetDoor = bezetDoor;
        }
    }
}