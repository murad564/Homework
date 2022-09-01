using System.Diagnostics.CodeAnalysis;

namespace Homework;

struct Article
{
    public string? ProductName;
    public string? ProductCode;
    public double Price;

    public object FullName { get; internal set; }
    public object Address { get; internal set; }

    public Article (string productN, string productC, double price)
    {
        ProductName = productN;
        ProductCode = productC;
        Price = price;
    }


    public static bool operator ==(Article productN, Article productC)
        => productN.ProductName == productC.ProductName && productN.ProductCode == productC.ProductCode ;

    public static bool operator !=(Article productN, Article productC)
        => !(productN.ProductName == productC.ProductName && productN.ProductCode == productC.ProductCode);


    public override string ToString() => $"ProductName={ProductName} : ProductCode={ProductCode} : Price={Price}";
}


struct Client
{
    public int ClientCode;
    public string? FullName;
    public string? Address;
    public string? Telephone;
    public int NumberOrdByCilent;
    public int TotalAmountOfOrders;

    public Client(int clientCode, string fullName, string address, string telephone,int numberOrdByCilent, int totalAmountOfOrders)
    {
        ClientCode = clientCode;
        FullName = fullName;
        Address = address;
        Telephone = telephone;
        NumberOrdByCilent = numberOrdByCilent;
        TotalAmountOfOrders = totalAmountOfOrders;
    }

    public static bool operator ==(Client fullName, Client address) =>
    fullName.FullName == address.FullName && fullName.Address == address.Address;
    


    public static bool operator !=(Client fullName, Client address) =>
        !(fullName.FullName == address.FullName && fullName.Address == address.Address);
    





    public override string ToString() => $"fullName={FullName} : Address={Address} : ClientCode={ClientCode} : Telephone={Telephone} : NumberOrdByCilent={NumberOrdByCilent} : TotalAmountOfOrders={TotalAmountOfOrders} ";
}




class Program
{
    static void Main()
    {
        //Article prN1 = new Article("Colgate", "120",2.5);
        //Article prN2 = new Article("Sensodine", "130",3.5);

        // bool equal = prN1 == prN2;
        // Console.WriteLine(equal);

        // Console.WriteLine(prN1);
        // Console.WriteLine(prN2);


        //////////////////////////////////////////////////////


        Client c1 = new Client(12, "Murad", "Mir Celal 103", "055-111-11-11",5,150);
        Client c2 = new Client(18, "Sabir", "Hemze Babashov 10", "050-222-22-22",3,120);
       

        bool equal = c1 == c2;
        Console.WriteLine(equal);

        Console.WriteLine(c1);
        Console.WriteLine(c2);



    }
}