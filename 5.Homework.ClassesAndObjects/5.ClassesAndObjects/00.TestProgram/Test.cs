using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ヴィトはクソファゴットです。

class Test
{
    static void Main(string[] args)
    {
        Car car = new Car("Lada", "Samara", 1987);
        car.Manifacturer = "Mercedes";
        car.StartEngine();

        
        Console.WriteLine(Math.Sin(Math.PI/4));

        DateTime today = DateTime.Now;
        DateTime halloween = DateTime.MaxValue;
        Console.WriteLine(halloween);

        Console.WriteLine(car);
    }
}

class Car
{
    const int WheelsCount = 4;
    static readonly string CarClassName = "Car"; //не могат да бъдат променяни - 2 вида константи

    private string manifacturer; //член променлива Field (member variables)
    string model;
    int yearOfManifacture;
    //описват състоянието на нашия обект Car

    public Car(string manufacturer, string model, int yearOfManifacture)
    {
        this.manifacturer = manufacturer; // this оказва че работим с текущата променлива нма инстанцията от класа
        this.model = model;
        this.yearOfManifacture = yearOfManifacture;

    }

    public string Manifacturer //свойство Property
    //public e модификатор за достъп
    {
        get { return this.manifacturer; } //accessor get връща стойността на член променливата

        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot be null!");
            }

            this.manifacturer = value;
        } //задава стойността й
    }

    public void StartEngine()
    {
        System.Console.WriteLine("Engine started.");
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.AppendFormat("{0} {1} {2}", this.Manifacturer, this.model, this.yearOfManifacture);
        return output.ToString();
    }
}
