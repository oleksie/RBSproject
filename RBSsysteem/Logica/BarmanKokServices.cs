using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Model;

namespace Logica
{
    public class BarmanKokServices
    {
        //maakt de verschillende connecties aan
        BestellingItemDAO bestelitemconnect = new BestellingItemDAO();
        BestellingDAO bestellingconnect = new BestellingDAO();
        MenuItemDAO menuitemconnect = new MenuItemDAO();

        //de meest logische operaties
        public string[] bestellingArray(BestellingItem currentbestelling,Model.MenuItem currentmenuitem,Bestelling currentbestellingtafel)
        {
            //array maken die in UI in item gaat en vervolgens in de listviewitemlist
            string[] arr = new string[7];
            arr[0] = Convert.ToString(currentbestelling.BestelitemID);
            arr[1] = currentmenuitem.Naam;
            arr[2] = Convert.ToString(currentbestelling.Aantal);
            arr[3] = currentbestelling.Commentaar;
            arr[4] = currentbestelling.Status;
            arr[5] = Convert.ToString(currentbestelling.TijdOpgenomen);
            arr[6] = Convert.ToString(currentbestellingtafel.TafelId);
            return arr;
        }
        public bool kok(Medewerker medewerker, Model.MenuItem categorie)
        {
            ///vanzelfsprekend
            if (medewerker.Rol == Rol.Kok & categorie.CategorieID <= 7)//nelleke vindt dit getal minder zie uitleg hieronder
            {
                return true;
            }

            //7 en lager is eten 8 en hoger is drinken
            if (medewerker.Rol == Rol.Barman & categorie.CategorieID >= 8)
            {
                return false;
            }
            return true;
        }

        //deze manier ga ik niet toepassen want 100+ regels code om 1 getal weg te laten is crazy
        //in DAL nieuwe file categorieDAO
        //die ophaalt categorie on bestelitem +-70 regels code
        //toevoegin in UI waarin die lijst wordt opgehaald + service waarin hij wordt doorgegeven +-30 regels code
        //dan kunnen ze worden doorgegeven aan bool kok en wordt het 
        //if (medewerker.Rol==Rol.kok & categorie.naam == lunch|diner(dit kan niet eens dus heeft ook een verandering in DB nodig haast)


        //3 nieuwe methods om dingen door te geven thats all folks
        public List<BestellingItem> BestellingItemList()
        {
            List<BestellingItem> currentbestelling = new List<BestellingItem>();

            currentbestelling = bestelitemconnect.GetAll();

            return currentbestelling;
        }
        public List<Model.MenuItem> MenuItemList()
        {
            List<Model.MenuItem> currentmenuitem = new List<Model.MenuItem>();
            
            currentmenuitem = menuitemconnect.GetNaamCategorie();

            return currentmenuitem;
        }

        public List<Bestelling> BestellingList()
        {
            List<Bestelling> currentbestelingtafel = new List<Bestelling>();

            currentbestelingtafel = bestellingconnect.GetTafel();

            return currentbestelingtafel;
        }
        

        public void Updatebestelitem(int bestelitemid,string status)
        {
            //de status moet het tegenovergestelde zijn(daarnaar moet ie veranderd worden)
            if (status == "besteld")
            {
                status = "bereid";
            }
            else if (status == "bereid")
            {
                status = "besteld";
            }
            bestelitemconnect.UpdateStatus(bestelitemid,status);
        }
        
    }
}

