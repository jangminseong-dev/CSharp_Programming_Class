public class Order
{
    int oid;
    Customer user;
    DateTime date;
    string product;
    string quantity;
    int price;
    string status;

    public static void totalPrice() {} //Calculate the total price

    public static void changeState() {} //Change order state
}