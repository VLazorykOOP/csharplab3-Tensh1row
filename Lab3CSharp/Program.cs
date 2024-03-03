//Exercise 1

using System; 

  

class DRomb 

{ 

    // Поля 

    protected int d1; // Перша діагональ 

    protected int d2; // Друга діагональ 

    protected int color; // Колір ромба 

  

    // Конструктор 

    public DRomb(int diagonal1, int diagonal2, int color) 

    { 

        this.d1 = diagonal1; 

        this.d2 = diagonal2; 

        this.color = color; 

    } 

  

    // Властивості 

    public int Diagonal1 

    { 

        get { return d1; } 

        set { d1 = value; } 

    } 

  

    public int Diagonal2 

    { 

        get { return d2; } 

        set { d2 = value; } 

    } 

  

    public int Color 

    { 

        get { return color; } 

    } 

  

    // Методи 

    public void PrintDimensions() 

    { 

        Console.WriteLine($"Перша діагональ: {d1}"); 

        Console.WriteLine($"Друга діагональ: {d2}"); 

    } 

  

    public double CalculatePerimeter() 

    { 

        return 2 * (d1 + d2); 

    } 

  

    public double CalculateArea() 

    { 

        return (d1 * d2) / 2.0; 

    } 

  

    public bool IsSquare() 

    { 

        return d1 == d2; 

    } 

} 

  

class Program 

{ 

    static void Main(string[] args) 

    { 

        // Створення ромбів із заданими параметрами 

        DRomb romb1 = new DRomb(5, 5, 1); // Квадрат 

        DRomb romb2 = new DRomb(6, 8, 2); // Звичайний ромб 

  

        // Виведення інформації про ромби 

        Console.WriteLine("Ромб 1:"); 

        romb1.PrintDimensions(); 

        Console.WriteLine($"Колір: {romb1.Color}"); 

        Console.WriteLine($"Периметр: {romb1.CalculatePerimeter()}"); 

        Console.WriteLine($"Площа: {romb1.CalculateArea()}"); 

        Console.WriteLine($"Чи є квадратом: {romb1.IsSquare()}"); 

  

        Console.WriteLine(); 

  

        Console.WriteLine("Ромб 2:"); 

        romb2.PrintDimensions(); 

        Console.WriteLine($"Колір: {romb2.Color}"); 

        Console.WriteLine($"Периметр: {romb2.CalculatePerimeter()}"); 

        Console.WriteLine($"Площа: {romb2.CalculateArea()}"); 

        Console.WriteLine($"Чи є квадратом: {romb2.IsSquare()}"); 

  

        Console.ReadLine(); 

    } 

} 


//Exercise 2

using System; 

using System.Collections.Generic; 

  

// Базовий клас 

class PrintedPublication 

{ 

    public string Title { get; set; } 

    public int Year { get; set; } 

    public string Publisher { get; set; } 

    public double Price { get; set; } 

  

    public PrintedPublication(string title, int year, string publisher, double price) 

    { 

        Title = title; 

        Year = year; 

        Publisher = publisher; 

        Price = price; 

    } 

  

    public virtual void Show() 

    { 

        Console.WriteLine($"Назва: {Title}"); 

        Console.WriteLine($"Рік видання: {Year}"); 

        Console.WriteLine($"Видавництво: {Publisher}"); 

        Console.WriteLine($"Ціна: {Price}"); 

    } 

} 

  

// Похідний клас Журнал 

class Journal : PrintedPublication 

{ 

    public int IssueNumber { get; set; } 

  

    public Journal(string title, int year, string publisher, double price, int issueNumber)  

        : base(title, year, publisher, price) 

    { 

        IssueNumber = issueNumber; 

    } 

  

    public override void Show() 

    { 

        base.Show(); 

        Console.WriteLine($"Номер випуску: {IssueNumber}"); 

    } 

} 

  

// Похідний клас Книга 

class Book : PrintedPublication 

{ 

    public string Author { get; set; } 

  

    public Book(string title, int year, string publisher, double price, string author)  

        : base(title, year, publisher, price) 

    { 

        Author = author; 

    } 

  

    public override void Show() 

    { 

        base.Show(); 

        Console.WriteLine($"Автор: {Author}"); 

    } 

} 

  

// Похідний клас Підручник 

class Textbook : PrintedPublication 

{ 

    public string Subject { get; set; } 

  

    public Textbook(string title, int year, string publisher, double price, string subject)  

        : base(title, year, publisher, price) 

    { 

        Subject = subject; 

    } 

  

    public override void Show() 

    { 

        base.Show(); 

        Console.WriteLine($"Предмет: {Subject}"); 

    } 

} 

  

class Program 

{ 

    static void Main(string[] args) 

    { 

        // Створюємо масив об'єктів базового класу 

        PrintedPublication[] publications = new PrintedPublication[4]; 

        publications[0] = new Journal("Модний одяг", 2022, "Модний дім", 25.50, 10); 

        publications[1] = new Book("Абетка", 2021, "Міністерство освіти", 40.00, "Авраменко"); 

        publications[2] = new Textbook("Математика для дітей", 2020, "Міністерство освіти", 55.00, "Математика"); 

        publications[3] = new Journal("Садівництво", 2022, "СадUA", 30.00, 11); 

  

        // Виводимо масив 

        Console.WriteLine("Друковані видання:"); 

        foreach (PrintedPublication publication in publications) 

        { 

            publication.Show(); 

            Console.WriteLine(); 

        } 

    } 

} 