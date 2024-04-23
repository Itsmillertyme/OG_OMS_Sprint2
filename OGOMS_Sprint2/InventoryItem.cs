public class InventoryItem {
    public int productID;
    public string description, supplierName, brandName;
    private int onHandQuantity, pendingDelivery;


    public InventoryItem(int productID, int onHandQuantity, int pendingDelivery, string description, string supplierName, string brandName) {
        this.productID = productID;
        this.description = description;
        this.supplierName = supplierName;
        this.onHandQuantity = onHandQuantity;
        this.pendingDelivery = pendingDelivery;
        this.brandName = brandName;
    }

    // ToString Override designed for testing purposes; Displays all attributes in a neat format. 
    public override string ToString() {
        return ("Product ID: " + productID + "\nDescription: " + description + "\nSupplier Name: " + supplierName + "\nOn-Hand Quantity: " + onHandQuantity + "\nPending Deliver: " + pendingDelivery);
    }

}
