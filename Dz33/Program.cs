public class Converter
{
    private decimal euro;
    private decimal dollar;
    public Converter(decimal euro, decimal dollar)
    {
        this.euro = euro;
        this.dollar = dollar;
    }

    public decimal euroToUah(decimal uah)
    {
        return uah * euro;
    }
    public decimal dollarToUah(decimal uah)
    {
        return uah * dollar;
    }
    public decimal uahToEuro(decimal uah)
    {
        return uah / euro;
    }
    public decimal uahToDollar(decimal uah)
    {
        return uah / dollar;
    }

}

internal class Program
{
    private static void Main(string[] args)
    {
        var converter = new Converter(40, 42);
        Console.Write("Enter the amount of money: ");
        decimal amountOfUah = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Choose your option:");
        Console.WriteLine("1-Uah To Euro");
        Console.WriteLine("2-Uah To Dollars");
        Console.WriteLine("3-Euro To Uah");
        Console.WriteLine("4-Dollar To Uah"); 

        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine(converter.uahToEuro(amountOfUah));
                break;
            case 2:
                Console.WriteLine(converter.uahToDollar(amountOfUah));
                break;
            case 3:
                Console.WriteLine(converter.euroToUah(amountOfUah));
                break;
            case 4:
                Console.WriteLine(converter.dollarToUah(amountOfUah));
                break;
        }
    }
}