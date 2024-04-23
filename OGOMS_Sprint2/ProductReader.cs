

using System.Diagnostics;

public class ProductReader {
    StreamReader productReader = new StreamReader("MasterProductList.txt");
    // Reads the product list

    List<string> productStrings = new List<string>();
    // This list contains products in their entirety [Format: products[i] will be equal to a string like "Field,Field,Field,Field,..."]

    List<string[]> formattedProducts = new List<string[]>();
    // This list is composed of string arrays; each index contains an array of the individual fields. [Format: formattedProducts[i][i] == Field, formattedProducts[i][i+1] == secondField, etc.]

    //Since we have no fixed number of products [technically 300 here], I created a list to dynamically manage incoming products.
    List<InventoryItem> inventory = new List<InventoryItem>();

    public ProductReader() {

        ReadProducts();
    }

    public void ReadProducts() {

        //File IO
        try {
            while (!productReader.EndOfStream) {
                productStrings.Add(productReader.ReadLine());
            }

            for (int i = 0; i < productStrings.Count; i++) {
                formattedProducts.Add(productStrings[i].Split(','));
                // Code below creates a new InventoryItem for each product on the master list and pushes it to an Arraylist
                inventory.Add(new InventoryItem(Convert.ToInt32(formattedProducts[i][1]), Convert.ToInt32(formattedProducts[i][11]), Convert.ToInt32(formattedProducts[i][14]), formattedProducts[i][2], formattedProducts[i][3], formattedProducts[i][4]));
                // Hard coded index files should be fine. Each product will always contain the same number of data fields, as confirmed by the Master Product list.
                // Any field missing data will simple be null; it will still exist.
            }
        }
        catch (Exception e) {
            Debug.WriteLine(e.Message);
        }

    }

    public List<InventoryItem> GetInventory() {
        return inventory;
    }


}

/*
// Check that each inventory item created functions properly using a ToString override for testing
foreach(InventoryItem i in inventory)
{
	Console.WriteLine(i.ToString());
	Console.WriteLine();
}
*/




