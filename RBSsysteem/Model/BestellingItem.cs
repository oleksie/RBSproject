using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BestellingItem
    {
        public MenuItem menuitem;
        public int aantal;
        public string commentaar;
        public string status;
        public DateTime tijdOpgenomen;

        public BestellingItem()
        {

        }
    }
}
