public class InventoryItem
	{
		public int productID;
		public string description, supplierName;
		private int onHandQuantity, pendingDelivery;

		public InventoryItem(int productID, int onHandQuantity, int pendingDelivery, string description, string supplierName)
		{
			this.productID = productID;
			this.description = description;
			this.supplierName = supplierName;
			this.onHandQuantity = onHandQuantity;
			this.pendingDelivery = pendingDelivery;
		}

    // ToString Override designed for testing purposes; Displays all attributes in a neat format. 
		public override string ToString()
		{
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
