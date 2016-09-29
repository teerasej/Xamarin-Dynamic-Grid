using Xamarin.Forms;
using System.Threading;
using System.Collections.Generic;

namespace DynamicGrid
{
	public partial class DynamicGridPage : ContentPage
	{
		private List<Product> productArrayList;

		public DynamicGridPage()
		{
			InitializeComponent();
			productArrayList = new List<Product>();
			productArrayList.Add(new Product { Name = "Mocca" });
			productArrayList.Add(new Product { Name = "Espresso" });
			productArrayList.Add(new Product { Name = "Latte" });
			productArrayList.Add(new Product { Name = "Americano" });
			productArrayList.Add(new Product { Name = "Arabica" });

			gridLayout.RowDefinitions.Add(new RowDefinition());
			gridLayout.RowDefinitions.Add(new RowDefinition());

			gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
			gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
			gridLayout.ColumnDefinitions.Add(new ColumnDefinition());

			var productIndex = 0;
			for (int rowIndex = 0; rowIndex < 2; rowIndex++)
			{
				for (int columnIndex = 0; columnIndex < 3; columnIndex++)
				{
					if (productIndex >= productArrayList.Count)
					{
						break;
					}
					var product = productArrayList[productIndex];
					productIndex += 1;
					var label = new Label
					{
						Text = product.Name,
						VerticalOptions = LayoutOptions.Center,
						HorizontalOptions = LayoutOptions.Center
					};
					gridLayout.Children.Add(label, columnIndex, rowIndex);
				}
			}
		}
	}
}
