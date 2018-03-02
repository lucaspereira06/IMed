using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace IMed
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            List<Page> itemsPage = new List<Page>();

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:

                    itemsPage.Add(new NavigationPage(new ItemsPage()){ Title = "Buscar", Icon = "tab_feed.png" });
                    itemsPage.Add(new NavigationPage(new ItemsPage()){ Title = "Promocões", Icon = "tab_feed.png" });
                    itemsPage.Add(new NavigationPage(new AboutPage()){ Title = "Pedidos", Icon = "tab_about.png" });
                    itemsPage.Add(new NavigationPage(new AboutPage()){ Title = "Eu", Icon = "tab_about.png" });

                    break;
                default:
                    itemsPage.Add(new ItemsPage() { Title = "IMed", Icon = "tab_feed.png" });
                    itemsPage.Add(new AboutPage() { Title = "Promocões", Icon = "tab_about.png" });
                    itemsPage.Add(new ItemsPage() { Title = "Pedidos", Icon = "tab_feed.png" });
                    itemsPage.Add(new AboutPage() { Title = "Eu", Icon = "tab_about.png" });
                    break;
            }

            foreach(var page in itemsPage){
                Children.Add(page);
            }

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
