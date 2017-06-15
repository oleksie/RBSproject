using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tafel
    {
        private int tafelId;
        private int capaciteit;
        private string status;

        public Tafel()
        {

        }

        public Tafel(int tafelId, int capaciteit, string status)
        {
            this.tafelId = tafelId;
            this.capaciteit = capaciteit;
            this.status = status;
        }
    }
}