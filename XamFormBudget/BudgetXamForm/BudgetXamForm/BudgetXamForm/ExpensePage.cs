using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms; 

namespace BudgetXamForm
{
    public class ExpensePage : ContentPage
    {
        public ExpensePage()
        {
            var label1 = new Label
            {
                Text = "Category",
                Font = Font.SystemFontOfSize(NamedSize.Medium) 
            };
            // make drop down menu, and learn how to be able to add item to drop down menu
            //put drop down menu and label1 into stacklayout horizontal 

            var label2 = new Label
            {
                Text = "Item",
                Font = Font.SystemFontOfSize(NamedSize.Medium)
            };
            var entry2 = new Entry
            {
                Placeholder = "Enter Item Name"
            };
            var layout2 = new StackLayout
            {
                Children = { label2, entry2 },
                HorizontalOptions = LayoutOptions.FillAndExpand
            }; 


            var label3 = new Label
            {
                Text = "Cost",
                Font = Font.SystemFontOfSize(NamedSize.Medium)
            };
            var entry3 = new Entry
            {
                Placeholder = "Enter price of item"
            };
            var layout3 = new StackLayout
            {
                Children = { label3, entry3 },
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var screenLayout = new StackLayout
            {
                Children = { layout2, layout3 }   // add in layout1 after you make it 
            };

            Content = screenLayout; 



        }
    }
}
