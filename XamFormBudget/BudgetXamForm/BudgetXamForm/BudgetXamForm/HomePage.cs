using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 

namespace BudgetXamForm
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {

            var label1 = new Label
            {
                Text = "Budget",
                Font = Font.BoldSystemFontOfSize(NamedSize.Large)
            };
            var modBudButton = new Button { Text = "Modify Budget" };
            var topLayout = new StackLayout
            {
                Children = { label1, modBudButton },
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var label2 = new Label
            {
                Text = "Expenses",
                Font = Font.SystemFontOfSize(NamedSize.Medium)
            };
            var addExpButton = new Button { Text = "Add Expense" };
            var midLayout = new StackLayout
            {
                Children = { label2, addExpButton },
                HorizontalOptions = LayoutOptions.FillAndExpand                
            };

            var listView = new ListView();
            listView.ItemsSource = new List<Expense>();

            var viewExpButton = new Button { Text = "View Expenses" };

            var screenLayout = new StackLayout
            {
                Children = { topLayout, midLayout, listView, viewExpButton }
            };

            Content = screenLayout; 
             
            
        }
    }
}
