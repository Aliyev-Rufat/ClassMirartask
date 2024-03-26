//********************task1*************************

//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Car Car = new Car();
//        Car.Brand = "Hunadi";
//        Car.Model = "i30";
//        Car.Yurus = 50000;
//        Car.QapiNum = 4;
//        Car.ShowFullInfo();

//        Motorcycle Motorcycle = new Motorcycle();
//        Motorcycle.Brand = "Honda";
//        Motorcycle.Model = "CBR500R";
//        Motorcycle.Yurus = 10000;
//        Motorcycle.TekerSayi = 2;
//        Motorcycle.ShowFullInfo();


//    }
//}
//class Vehicle
//{
//    public string Brand;
//    public string Model;
//    public double Yurus;
//}

//class Car : Vehicle
//{
//    public int QapiNum;
//    public void ShowFullInfo()
//    {
//        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Yurus: {Yurus}, Qapilarin sayi: {QapiNum}");
//    }
//}

//class Motorcycle : Vehicle
//{
//    public int TekerSayi;

//    public void ShowFullInfo()
//    {
//        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Yurus: {Yurus}, Tekerlerin sayi: {TekerSayi}");
//    }
//}


//***********task2********************


//class Program
//{
//    static void Main(string[] args)
//    {
//        Notebook notebook = new Notebook();
//        notebook.Name = "HP";
//        notebook.Count = 5;
//        notebook.IsStock = true;
//        notebook.Price = 1999.99;
//        notebook.RAM = 16;
//        notebook.Storage = 512;
//        notebook.Sale();
//        notebook.ShowFullData();
//    }
//}
//class Product
//{
//    public string Name;
//    public string Description;
//    public int Count;
//    public bool IsStock;
//    public double Price;

//    public void Sale()
//    {
//        if (IsStock && Count > 0)
//        {
//            Count--;
//            Console.WriteLine($"{Name} mehsulu yeteri qederdir.");
//        }
//        else
//        {
//            Console.WriteLine("Məhsul yoxdur");
//        }
//    }
//}

//class Notebook : Product
//{
//    public int RAM;
//    public int Storage;


//    public void ShowFullData()
//    {
//        if (IsStock && Count > 0)
//        {
//            Console.WriteLine($"Name: {Name}, Description: {Description}, Count: {Count}, Price: {Price}, RAM: {RAM}, Storage: {Storage}");
//        }
//        else
//        {
//            Console.WriteLine("Məhsul yoxdur");
//        }
//    }
//}