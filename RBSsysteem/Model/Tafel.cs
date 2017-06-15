using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tafel
    {
        public int tafelId { get; set; }
        public string status { get; set; }
        public int capaciteit { get; set; }

        public Tafel()
        {

        }

        public Tafel(int tafelId, string status, int capaciteit)
        {
            this.tafelId = tafelId;
            this.status = status;
            this.capaciteit = capaciteit;
        }
    }
}