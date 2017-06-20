using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Windows.Forms;
using System.Data;

namespace Logica
{
    public class MenuItemService
    {
        private List<ListviewBestellen> listVoorListview = new List<ListviewBestellen>();
        MenuItemDAO menuItem = new MenuItemDAO();

        public MenuItemService()
        {

        }

        public List<ListviewBestellen> ListVoorListview
        {
            get { return listVoorListview; }
            set { listVoorListview = value; }
        }

        //Code Alex
        public List<Button> MenuItemNaarButton(TabControl tab, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();

            List<Button> btnList = new List<Button>();
            Button button = null;

            if (tab.SelectedTab.Name == "HoofdgerechtLunch")
            {
                List<Model.MenuItem> menuItemsLunchVoor = menuItem.GetSpecefiekegerechtItems(2);

                foreach (Model.MenuItem x in menuItemsLunchVoor)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 255;
                    button.Height = 120;

                    btnList.Add(button);
                    panel.Controls.Add(button);
                    
                }
                return btnList;
            }
            else if (tab.SelectedTab.Name == "VoorgerechtLunch")
            {
                List<Model.MenuItem> menuItemsLunchHoofd = menuItem.GetSpecefiekegerechtItems(1);

                foreach (Model.MenuItem x in menuItemsLunchHoofd)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 255;
                    button.Height = 120;


                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
            else if (tab.SelectedTab.Name == "NagerechtLunch")
            {
                List<Model.MenuItem> menuItemsLunchNa = menuItem.GetSpecefiekegerechtItems(3);

                foreach (Model.MenuItem x in menuItemsLunchNa)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 255;
                    button.Height = 120;

                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
            else if (tab.SelectedTab.Name == "VoorgerechtDiner")
            {
                List<Model.MenuItem> menuItemsDinerVoor = menuItem.GetSpecefiekegerechtItems(4);

                foreach (Model.MenuItem x in menuItemsDinerVoor)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 255;
                    button.Height = 120;

                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
            else if (tab.SelectedTab.Name == "TussengerechtDiner")
            {
                List<Model.MenuItem> menuItemsDinerTussen = menuItem.GetSpecefiekegerechtItems(5);

                foreach (Model.MenuItem x in menuItemsDinerTussen)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 255;
                    button.Height = 120;

                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
            else if (tab.SelectedTab.Name == "HoofdgerechtDiner")
            {
                List<Model.MenuItem> menuItemsDinerHoofd = menuItem.GetSpecefiekegerechtItems(6);

                foreach (Model.MenuItem x in menuItemsDinerHoofd)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 255;
                    button.Height = 120;

                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
            else if (tab.SelectedTab.Name == "NagerechtDiner")
            {
                List<Model.MenuItem> menuItemsDinerNa = menuItem.GetSpecefiekegerechtItems(7);

                foreach (Model.MenuItem x in menuItemsDinerNa)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 255;
                    button.Height = 120;

                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
            else if (tab.SelectedTab.Name == "Frisdrank")
            {
                List<Model.MenuItem> menuItemsFris = menuItem.GetSpecefiekegerechtItems(8);

                foreach (Model.MenuItem x in menuItemsFris)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 125;
                    button.Height = 120;

                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
            else if (tab.SelectedTab.Name == "Bier")
            {
                List<Model.MenuItem> menuItemsBier = menuItem.GetSpecefiekegerechtItems(9);

                foreach (Model.MenuItem x in menuItemsBier)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 255;
                    button.Height = 120;

                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
            else if (tab.SelectedTab.Name == "Wijn")
            {
                List<Model.MenuItem> menuItemsWijn = menuItem.GetSpecefiekegerechtItems(10);

                foreach (Model.MenuItem x in menuItemsWijn)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 167;
                    button.Height = 120;

                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
            else if (tab.SelectedTab.Name == "Gedistileerd")
            {
                List<Model.MenuItem> menuItemsGedis = menuItem.GetSpecefiekegerechtItems(11);

                foreach (Model.MenuItem x in menuItemsGedis)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 167;
                    button.Height = 100;

                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
            else
            {
                List<Model.MenuItem> menuItemsKoffthee = menuItem.GetSpecefiekegerechtItems(12);

                foreach (Model.MenuItem x in menuItemsKoffthee)
                {
                    button = new Button();
                    button.Tag = x.Naam;
                    button.Text = x.Naam + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 255;
                    button.Height = 120;

                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
        }

        //Code Alex
        public ListviewBestellen MenuItemNaarList(Button button, int aantal, string opmerking)
        {
            List<Model.MenuItem> menuItems = menuItem.GetMenuItems();

            ListviewBestellen item = new ListviewBestellen();

            foreach (Model.MenuItem x in menuItems)
            {
                if (x.Naam == button.Tag.ToString())
                {
                    item.Naam = x.Naam;
                    item.Aantal = aantal;
                    item.Opmerking = opmerking;
                    item.ItemPrijs = x.Prijs;
                    item.Prijs = (x.Prijs * aantal);
                    item.MenuItemID = x.MenuItemID;
                }
            }
            return item;
        }

        //Code Alex
        public List<ListviewBestellen> MenuItemNaarListView(ListView list, ListviewBestellen item)
        {
            list.Items.Clear();
            bool itemIsInList = false;

            foreach (ListviewBestellen x in listVoorListview)
            {
                if (item.Naam == x.Naam && string.IsNullOrEmpty(x.Opmerking) && string.IsNullOrEmpty(item.Opmerking))
                {
                    itemIsInList = true;
                    int aantalWijzig = x.Aantal;
                    aantalWijzig = aantalWijzig + item.Aantal;
                    x.Aantal = aantalWijzig;

                    x.Prijs = (x.ItemPrijs * aantalWijzig);
                    break;
                }
            }

            if (itemIsInList == false)
            {
                listVoorListview.Add(item);
            }

            foreach (ListviewBestellen x in listVoorListview)
            {
                ListViewItem MenuItems = new ListViewItem(x.Naam);
                MenuItems.SubItems.Add(x.Aantal.ToString());
                MenuItems.SubItems.Add(x.Opmerking);
                MenuItems.SubItems.Add(x.Prijs.ToString());
                MenuItems.SubItems.Add(x.MenuItemID.ToString());

                list.Items.Add(MenuItems);
            }

            return listVoorListview;
        }

        //Code Alex
        public void UpdateVoorraad(List<ListviewBestellen> list)
        {
            menuItem.UpdateVoorraad(list);
        }

        //Code Alex
        public List<Model.MenuItem> GetVoorraad()
        {
            List<Model.MenuItem> checkVoorraad = menuItem.GetMenuItems();

            return checkVoorraad;
        }
    }
}
