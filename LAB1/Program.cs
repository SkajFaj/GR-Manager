//ax2 + bx + c = 0;



//zadanie1();
//zadanie2();
using System.Security.Cryptography.X509Certificates;

zadanie3();



void zadanie1()
{
    double a = DoubleInput();
    double b = DoubleInput();
    double c = DoubleInput();
    double delta, x1, x2;

    if (a != 0)
    {
        delta = (Math.Pow(b, 2) - (4 * a * c));
        if (delta > 0)
        {
            x1 = (-b - Math.Sqrt(delta) / 2 * a);
            x2 = (-b + Math.Sqrt(delta) / 2 * a);
            Console.WriteLine($"Dwa rozwiązania: x1 = {x1:F3}\tx2 = {x2:F3}");
        }
        else if (delta == 0) 
        { 
            x1 = -b / (2 * a);
            Console.WriteLine($"Jedno rozwiązanie : x1 = {x1:F3}");
        }
        else
        {
            Console.WriteLine("Brak rozwiązania w zbiorze liczb rzeczywistych.");
        }
    }
    else
    {
        Console.WriteLine("To nie jest równanie kwadratowe!");
    }
}



double DoubleInput()
{
    Console.WriteLine("Podaj liczbe: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

int IntInput()
{
    Console.WriteLine("Podaj liczbe: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void zadanie2()
{
    while (true) 
    {
        
        Console.WriteLine("======== M U R Z Y N A T O R ========");
        Console.WriteLine("1. Suma\n2. Różnica\n3. Iloraz\n4. Iloczyn\n5. Potęgowanie\n6. Pierwiastek z liczby\n7. Wartośzi z funkcji trygonometrycznych\n8. Wyjście ");
        Console.WriteLine("======== K A L K U L A T O R ========");
        Console.WriteLine("Wybierz opcje: ");
        int choise = Convert.ToInt32(Console.ReadLine());

        switch (choise)
        {
            case 1: suma(); break;
            case 2: roznica(); break;
            case 3: iloraz(); break;
            case 4: iloczyn(); break;
            case 5: potegowanie(); break;
            case 6: pierwiastek(); break;
            case 7: trygonometria(); break;
            case 8: close(); break;
            default: Console.WriteLine("Błędne dane, spróbuj jeszcze raz"); Console.Clear(); zadanie2(); break;
        }
    }

    

}

void close()
{
    Console.WriteLine("Koniec programu");
    System.Environment.Exit(1);
}

void trygonometria()
{
    //double a = DoubleInput();
    //double b = DoubleInput();
    Console.WriteLine($"\n\n\n\n\n\n Tu powinna być trygonometria :) \n\n\n\n\n\n");
}

void pierwiastek()
{
    double a = DoubleInput();
    Console.WriteLine($"Wynik:  Pierwiastek z {a} = {Math.Sqrt(a)}");
}

void potegowanie()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Wynik:  {a}^{b} = {Math.Pow(a, b)}");
}

void iloczyn()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Wynik:  {a} / {b} = {a / b}");
}

void iloraz()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Wynik:  {a} * {b} = {a * b}");
}

void roznica()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Wynik:  {a} - {b} = {a - b}");
}

void suma()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Wynik:  {a} + {b} = {a+b}");
}

void zadanie3()
{
    int[] tablica = [];

    for( int i = 0; i < 9; i++)
    {
        int a = IntInput();
        tablica[i] = a;
    }
    Console.WriteLine(tablica);

    for (int i = 0; i < 9; i++)
    {
        int suma = 0;
        suma += tablica[i];

    }
}