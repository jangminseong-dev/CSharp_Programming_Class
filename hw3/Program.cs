using System;

//1번 문제
public class Computer
{
    string brand;
    string model;
    string purpose;
    string os;
    string ram;
    string storage;

    public static power() {} //Power Control Method

    public static exec() {} //Program Execution Method

    public static file_io() {} // File IO Method
}

//2번 문제
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

//3번 문제
public class Student
{
    int id;
    string name;
    string grade;
    string major;
    int contact;
    string email;

    public static void call() {} //make a phone call
    public static void send_email() {} //send email
}

//4번 문제
public class FoodOrder
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

//5번 문제
public class Reservation
{
    int id;
    string customer_name;
    DateTime start_date;
    DateTime end_date;
    string room_class;
    int room_id;

    public static void change_date(DateTime start, DateTime end)
    {
        start_date = start;
        end_date = end;
    }
    public static void change_room(int id, string r_class)
    {
        room_id = id;
        room_class = r_class;
    }
}

public class board
{
    int id;
    DateTime date;
    string writer;
    string content;
    public static void modify(string s)
    {
        content = s;
        date = DateTime.Now();
    }
}

public class music_queue
{
    string apt_key;
    List<string> queue;
    public static void add(string music)
    {
        if (!queue.Contains(music))
            queue.Add(music);
    }
    public static void remove(string music)
    {
        if (!queue.Contains(music))
            queue.Remove(music);
    }
}

public class StockSimulator
{
    double stockPrice;
    DateTime date;
    double currentInvestment;
    double currentStockPrice;

    public static void Buy(int numShares)
    {

    }

    public static void Sell(int numShares)
    {

    }
}