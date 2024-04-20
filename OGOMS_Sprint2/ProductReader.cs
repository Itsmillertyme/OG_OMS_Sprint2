//   StreamReader productList = new StreamReader("MasterProductList.txt");
//   // Reads the product list

//List<string> products = new List<string>();
//   // This list contains products in their entirety [Format: products[i] will be equal to a string like "Field,Field,Field,Field,..."]

//List<string[]> formattedProducts = new List<string[]>();
//   // This list is composed of string arrays; each index contains an array of the individual fields. [Format: formattedProducts[i][i] == Field, formattedProducts[i][i+1] == secondField, etc.]

////Since we have no fixed number of products [technically 300 here], I created a list to dynamically manage incoming products.
//List<InventoryItem> inventory = new List<InventoryItem>();

//while (!productList.EndOfStream)
//{
//	products.Add(productList.ReadLine());
//}

//for (int i = 0; i < products.Count; i++)
//{
//	formattedProducts.Add(products[i].Split(','));
//	// Code below creates a new InventoryItem for each product on the master list and pushes it to an Arraylist
//	inventory.Add(new InventoryItem(Convert.ToInt32(formattedProducts[i][1]), Convert.ToInt32(formattedProducts[i][11]), Convert.ToInt32(formattedProducts[i][14]), formattedProducts[i][6] ,formattedProducts[i][3]));
//  // Hard coded index files should be fine. Each product will always contain the same number of data fields, as confirmed by the Master Product list.
//     // Any field missing data will simple be null; it will still exist.
//   }

///*
//// Check that each inventory item created functions properly using a ToString override for testing
//foreach(InventoryItem i in inventory)
//{
//	Console.WriteLine(i.ToString());
//	Console.WriteLine();
//}
//*/
