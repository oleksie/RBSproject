using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Windows.Forms;

namespace Logica
{
    public class MenuItemService
    {
        public MenuItemService()
        {

        }

        public List<Button> MenuItemNaarButton(TabControl tab, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();

            MenuItemDAO menuItem = new MenuItemDAO();

            List<Button> btnList = new List<Button>();
            Button button = null;

            if (tab.SelectedTab.Name == "HoofdgerechtLunch")
            {
                List<Model.MenuItem> menuItemsLunchVoor = menuItem.GetSpecefiekegerechtItems(1);

                foreach (Model.MenuItem x in menuItemsLunchVoor)
                {
                    button = new Button();
                    button.Text = x.Naam; // + Environment.NewLine + x.Omschrijving + Environment.NewLine + "€ " + x.Prijs;
                    button.Width = 200;
                    button.Height = 100;

                    btnList.Add(button);
                    panel.Controls.Add(button);
                    
                }
                return btnList;
            }
            else if (tab.SelectedTab.Name == "VoorgerechtLunch")
            {
                List<Model.MenuItem> menuItemsLunchHoofd = menuItem.GetSpecefiekegerechtItems(2);

                foreach (Model.MenuItem x in menuItemsLunchHoofd)
                {
                    button = new Button();
                    button.Text = x.Naam;

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
                    button.Text = x.Naam;

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
                    button.Text = x.Naam;

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
                    button.Text = x.Naam;

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
                    button.Text = x.Naam;

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
                    button.Text = x.Naam;

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
                    button.Text = x.Naam;

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
                    button.Text = x.Naam;

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
                    button.Text = x.Naam;

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
                    button.Text = x.Naam;

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
                    button.Text = x.Naam;

                    panel.Controls.Add(button);
                    btnList.Add(button);
                }
                return btnList;
            }
        }

        public void MenuItemNaarList(ListView list, Button button, int aantal, string opmerking)
        {
            MenuItemDAO menuItem = new MenuItemDAO();
            List<Model.MenuItem> menuItems = menuItem.GetMenuItems();
            foreach (Model.MenuItem x in menuItems)
            {
                if (button.Text == x.Naam)
                {
                    ListViewItem MenuItems = new ListViewItem(x.Naam);
                    MenuItems.SubItems.Add(aantal.ToString());
                    MenuItems.SubItems.Add(opmerking);
                    MenuItems.SubItems.Add((x.Prijs * aantal).ToString());
                    MenuItems.SubItems.Add(x.ID.ToString());
                    list.Items.Add(MenuItems);
                }
            }
        }
    }
}
