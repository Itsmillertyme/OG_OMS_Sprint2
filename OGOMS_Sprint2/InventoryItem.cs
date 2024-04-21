public class InventoryItem {
    public int productID;
    public double price;
    public string description, supplierName, brandName;
    private int onHandQuantity, pendingDelivery;


    public InventoryItem(int productID, int onHandQuantity, int pendingDelivery, string description, string supplierName, string brandName, double price) {
        this.productID = productID;
        this.description = description;
        this.supplierName = supplierName;
        this.onHandQuantity = onHandQuantity;
        this.pendingDelivery = pendingDelivery;
        this.brandName = brandName;
        this.price = price;
    }

    // ToString Override designed for testing purposes; Displays all attributes in a neat format. 
    public override string ToString() {
        return ("Product ID: " + productID + "\nDescription: " + description + "\nSupplier Name: " + supplierName + "\nOn-Hand Quantity: " + onHandQuantity + "\nPending Deliver: " + pendingDelivery);
    }

    /*
    No default constructor designed due to null information being irrelevant to system. Change as fit.
    The following methods originated from the ParseSQL interface which originated from a java perspective. Unsure of handling.

    public void FromSQL(Tuple<Object, Object> response)
    {

    }

    public string ToSQL(string[] options)
    {
        return " ";
    }
    */
}
