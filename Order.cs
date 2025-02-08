using System;

// Base class Order
public class Order
{
    public int OrderId{ get; set; } // Order ID
    public DateTime OrderDate{ get; set; } // Order date
    
    public Order(int orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }
    
    // Virtual method to get the order status
    public virtual string GetOrderStatus()
    {
        return "Order placed";
    }

    // Method to display order details
    public virtual void DisplayOrderDetails()
    {
        Console.WriteLine($"Order ID: {OrderId}, Order Date: {OrderDate.ToShortDateString()}, Status: {GetOrderStatus()}");
    }
}

// Derived class ShippedOrder from Order
public class ShippedOrder : Order
{
    public string TrackingNumber{ get; set; } // Tracking number for shipment
    
    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber) : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }
    
    // Overriding GetOrderStatus method to indicate shipment
    public override string GetOrderStatus()
    {
        return "Order shipped";
    }

    // Overriding DisplayOrderDetails to include tracking number
    public override void DisplayOrderDetails()
    {
        base.DisplayOrderDetails();
        Console.WriteLine($"Tracking Number: {TrackingNumber}");
    }
}

// Derived class DeliveredOrder from ShippedOrder
public class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate{ get; set; } // Delivery date
    
    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate) : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }
    
    // Overriding GetOrderStatus method to indicate delivery
    public override string GetOrderStatus()
    {
        return "Order delivered";
    }

    // Overriding DisplayOrderDetails to include delivery date
    public override void DisplayOrderDetails()
    {
        base.DisplayOrderDetails();
        Console.WriteLine($"Delivery Date: {DeliveryDate.ToShortDateString()}");
    }
}

// Main program execution
public class Program
{
    public static void Main(String[] args)
    {
        // Creating an instance of Order
        Order order = new Order(101, DateTime.Now);
        
        // Creating an instance of ShippedOrder
        ShippedOrder shippedOrder = new ShippedOrder(102, DateTime.Now.AddDays(-3), "TRK12345");
        
        // Creating an instance of DeliveredOrder
        DeliveredOrder deliveredOrder = new DeliveredOrder(103, DateTime.Now.AddDays(-7), "TRK67890", DateTime.Now.AddDays(-2));
        
        // Displaying order details for each type of order
        order.DisplayOrderDetails();
        Console.WriteLine();
        shippedOrder.DisplayOrderDetails();
        Console.WriteLine();
        deliveredOrder.DisplayOrderDetails();
    }
}