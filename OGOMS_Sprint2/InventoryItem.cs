public class InventoryItem {

    //**Variables**
    public int productID;
    public string description, supplierName, brandName;
    private int onHandQuantity, pendingDelivery;

    //Constructors**
    public InventoryItem(int productID, int onHandQuantity, int pendingDelivery, string description, string supplierName, string brandName) {
        this.productID = productID;
        this.description = description;
        this.supplierName = supplierName;
        this.onHandQuantity = onHandQuantity;
        this.pendingDelivery = pendingDelivery;
        this.brandName = brandName;
    }

    /// <summary>
    /// ToString Override designed for testing purposes; Displays all attributes in a neat format.
    /// </summary>
    /// <returns>String representation of this object</returns>
    public override string ToString() {
        return ("Product ID: " + productID + "\nDescription: " + description + "\nSupplier Name: " + supplierName + "\nOn-Hand Quantity: " + onHandQuantity + "\nPending Deliver: " + pendingDelivery);
    }

}
