using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ConsoleAppEstudo
{
    class Program
    {
        #region Exercicio 1

        //static void Main(string[] args)
        //{
        //    double Largura, Altura;

        //    Console.WriteLine("Entre a largura e altura do retângulo"); // WriteLine quebra a linha no final

        //    Largura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        //    Altura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        //    Console.WriteLine($"AREA = {Area(Largura, Altura).ToString("F2", CultureInfo.InvariantCulture)}");
        //    Console.WriteLine($"PERÍMETRO = {Perimetro(Largura, Altura).ToString("F2", CultureInfo.InvariantCulture)}");
        //    Console.WriteLine($"DIAGONAL = {Diagonal(Largura, Altura).ToString("F2", CultureInfo.InvariantCulture)}");
        //}

        //public static double Area(double largura, double altura)
        //{
        //    return largura * altura;
        //}

        //public static double Perimetro(double largura, double altura)
        //{
        //    return 2 * (largura + altura);
        //}

        //public static double Diagonal(double largura, double altura)
        //{
        //    return Math.Sqrt(largura * largura + altura * altura);
        //}

        #endregion

        #region Exercicio 2

        //static void Main(string[] args)
        //{
        //    string Nome;
        //    double SalarioBruto, Imposto, Porcentagem;

        //    Console.Write("Nome: "); // Write não quebra a linha no final
        //    Nome = Console.ReadLine();

        //    Console.Write("Salário Bruto: ");
        //    SalarioBruto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        //    Console.Write("Imposto: ");
        //    Imposto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        //    Console.WriteLine();

        //    Console.WriteLine($"Funcionário: {Nome}, $ {SalarioLiquido(SalarioBruto, Imposto).ToString("F2", CultureInfo.InvariantCulture)}");

        //    Console.WriteLine();

        //    Console.Write("Digite a porcentagem para aumentar o salário: ");
        //    Porcentagem = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        //    Console.WriteLine();

        //    Console.WriteLine($"Dados atualizados: {Nome}, $ {AumentarSalario(Porcentagem, SalarioBruto, Imposto).ToString("F2", CultureInfo.InvariantCulture)}");
        //}

        //public static double SalarioLiquido(double salarioBruto, double imposto)
        //{
        //    return salarioBruto - imposto;
        //}

        //public static double AumentarSalario(double porcentagem, double salarioBruto, double imposto)
        //{
        //    return SalarioLiquido(salarioBruto, imposto) + ((salarioBruto * porcentagem) / 100);
        //}

        #endregion

        #region Exercicio 3

        //static void Main(string[] args)
        //{
        //    string NomeAluno;
        //    double N1, N2, N3, NotaFinal;

        //    Console.Write("Nome do aluno: ");
        //    NomeAluno = Console.ReadLine();

        //    Console.WriteLine("Digite as três notas do aluno:");
        //    N1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        //    N2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        //    N3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        //    NotaFinal = N1 + N2 + N3;

        //    Console.WriteLine($"NOTA FINAL = {NotaFinal.ToString("F2", CultureInfo.InvariantCulture)}");

        //    if (NotaFinal > 60.00)
        //    {
        //        Console.WriteLine("APROVADO");
        //    }
        //    else
        //    {
        //        Console.WriteLine("REPROVADO");
        //        Console.WriteLine($"FALTARAM {(60.00 - NotaFinal).ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
        //    }
        //}

        #endregion

        #region Exerciocio fixação static

        //static void Main(string[] args)
        //{
        //    double Cotacao, QtdDolar;

        //    Console.Write("Qual é a cotação do dolar? ");
        //    Cotacao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        //    Console.Write("Quantos dolares você vai comrar? ");
        //    QtdDolar = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        //    Console.Write($"Valor a ser pago em reais = {ValorPago(Cotacao, QtdDolar)}");

        //}

        //public static double ValorPago(double cotacao, double qtdDolar)
        //{
        //    double valor = cotacao * qtdDolar;
        //    double iof = valor * 6 / 100;

        //    return valor + iof;
        //}

        #endregion

        #region Encapsulamento

        //static void Main(string[] args)
        //{
        //    int numeroConta;
        //    string nomeTitular, temDepositoInicial;
        //    double saldo = 0;

        //    Console.Write("Entre o número da conta: ");
        //    numeroConta = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Entre o titular da conta: ");
        //    nomeTitular = Console.ReadLine();

        //    Console.Write("Haverá depósito inicial (s/n)? ");
        //    temDepositoInicial = Console.ReadLine();

        //    if (temDepositoInicial.ToLower() == "s")
        //    {
        //        Console.Write("Entre o valor de depósito inicial: ");
        //        saldo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        //    }

        //    Console.WriteLine();

        //    Console.WriteLine("Dados da conta:");
        //    Console.WriteLine($"Conta {numeroConta}, Titular {nomeTitular}, Saldo: {saldo.ToString("F2", CultureInfo.InvariantCulture)}");

        //    Console.WriteLine();

        //    Console.Write("Entre um valor para depósito: ");
        //    saldo += Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        //    Console.WriteLine("Dados da conta atualizados:");
        //    Console.WriteLine($"Conta {numeroConta}, Titular {nomeTitular}, Saldo: {saldo.ToString("F2", CultureInfo.InvariantCulture)}");

        //    Console.WriteLine();

        //    Console.Write("Entre um valor para saque: ");
        //    saldo -= Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        //    saldo -= 5.00;

        //    Console.WriteLine("Dados da conta atualizados:");
        //    Console.WriteLine($"Conta {numeroConta}, Titular {nomeTitular}, Saldo: {saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        //}

        #endregion

        #region Array

        //static void Main(string[] args)
        //{
        //    Room[] rooms = new Room[10];

        //    Console.Write("Quantos quartos serão alugados? ");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine();

        //    for (int i = 1; i <= n; i++)
        //    {
        //        Console.WriteLine();

        //        Console.WriteLine($"Aluguel #{i}");

        //        Console.Write("Nome: ");
        //        string name = Console.ReadLine();

        //        Console.Write("Email: ");
        //        string email = Console.ReadLine();

        //        Console.Write("Quarto: ");
        //        int roomNumber = Convert.ToInt32(Console.ReadLine());

        //        rooms[i] = new Room { Name = name, Email = email, RoomNumber = roomNumber };
        //    }


        //    Console.WriteLine("Quartos ocupados:");

        //    for (int i = 0; i < 10; i++)
        //    {
        //        if (rooms[i] != null)
        //            Console.WriteLine($"{rooms[i].RoomNumber} : {rooms[i].Name}, {rooms[i].Email}");
        //    }
        //}

        #endregion

        #region List

        //static void Main(string[] args)
        //{
        //    List<Employee> employees = new List<Employee>();

        //    Console.Write("How many employees will be registered? ");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 1; i <= n; i++)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine($"Employee #{i}");

        //        Console.Write("Id: ");
        //        int id = Convert.ToInt32(Console.ReadLine());

        //        Console.Write("Name: ");
        //        string name = Console.ReadLine();

        //        Console.Write("Salary: ");
        //        double salary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        //        employees.Add(new Employee { Id = id, Name = name, Salary = salary});
        //    }

        //    Console.WriteLine();
        //    Console.Write("Enter the employee id that will have salary increase: ");
        //    int idWilSearch = Convert.ToInt32(Console.ReadLine());

        //    var employee = employees.Find(x => x.Id == idWilSearch);

        //    if (employee != null)
        //    {
        //        Console.Write("Enter the percentage: ");
        //        double percentage = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        //        var increaseSalary = employee.Salary * percentage / 100;
        //        employee.Salary = employee.Salary + increaseSalary;
        //    }
        //    else
        //    {
        //        Console.WriteLine("This id does not exist!");
        //    }


        //    Console.WriteLine();
        //    Console.WriteLine("Updated list of employees:");

        //    for (int i = 0; i < employees.Count; i++)
        //    {
        //        Console.WriteLine($"{employees[i].Id}, {employees[i].Name}, {employees[i].Salary.ToString("F2", CultureInfo.InvariantCulture)}");
        //    }
        //}

        #endregion

        #region Matrizes (Esse eu copiei)

        //static void Main(string[] args)
        //{
        //    string[] line = Console.ReadLine().Split(' ');
        //    int m = int.Parse(line[0]);
        //    int n = int.Parse(line[1]);

        //    int[,] mat = new int[m, n];

        //    for (int i = 0; i < m; i++)
        //    {
        //        string[] values = Console.ReadLine().Split(' ');
        //        for (int j = 0; j < n; j++)
        //        {
        //            mat[i, j] = int.Parse(values[j]);
        //        }
        //    }

        //    int x = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (mat[i, j] == x)
        //            {
        //                Console.WriteLine("Position " + i + "," + j + ":");
        //                if (j > 0)
        //                {
        //                    Console.WriteLine("Left: " + mat[i, j - 1]);
        //                }
        //                if (i > 0)
        //                {
        //                    Console.WriteLine("Up: " + mat[i - 1, j]);
        //                }
        //                if (j < n - 1)
        //                {
        //                    Console.WriteLine("Right: " + mat[i, j + 1]);
        //                }
        //                if (i < m - 1)
        //                {
        //                    Console.WriteLine("Down: " + mat[i + 1, j]);
        //                }
        //            }
        //        }
        //    }
        //}

        #endregion

        #region Conjuntos

        //static void Main(string[] args)
        //{
        //    Console.Write("O curso A possui quantos alunos? ");
        //    int qtdCursoA = Convert.ToInt32(Console.ReadLine());
        //    HashSet<int> codigosAlunosCursoA = new HashSet<int>();

        //    Console.WriteLine("Digite os códigos dos alunos do curso A: ");
        //    for (int i = 0; i < qtdCursoA; i++)
        //    {
        //        codigosAlunosCursoA.Add(Convert.ToInt32(Console.ReadLine()));
        //    }

        //    Console.Write("O curso B possui quantos alunos? ");
        //    int qtdCursoB = Convert.ToInt32(Console.ReadLine());
        //    HashSet<int> codigosAlunosCursoB = new HashSet<int>();

        //    Console.WriteLine("Digite os códigos dos alunos do curso B: ");
        //    for (int i = 0; i < qtdCursoB; i++)
        //    {
        //        codigosAlunosCursoB.Add(Convert.ToInt32(Console.ReadLine()));
        //    }

        //    Console.Write("O curso B possui quantos alunos? ");
        //    int qtdCursoC = Convert.ToInt32(Console.ReadLine());
        //    HashSet<int> codigosAlunosCursoC = new HashSet<int>();

        //    Console.WriteLine("Digite os códigos dos alunos do curso B: ");
        //    for (int i = 0; i < qtdCursoC; i++)
        //    {
        //        codigosAlunosCursoC.Add(Convert.ToInt32(Console.ReadLine()));
        //    }

        //    codigosAlunosCursoA.UnionWith(codigosAlunosCursoB);
        //    codigosAlunosCursoA.UnionWith(codigosAlunosCursoC);

        //    Console.WriteLine($"Total de alunos: {codigosAlunosCursoA.Count}");
        //}

        #endregion

        #region Composição e Enumeração

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter cliente data: ");
        //    Console.Write("Name: ");
        //    string name = Console.ReadLine();

        //    Console.Write("Email: ");
        //    string email = Console.ReadLine();

        //    Console.Write("Birth date (DD/MM/YYYY): ");
        //    DateTime birth = DateTime.Parse(Console.ReadLine());

        //    Client client = new Client(name, email, birth);

        //    Console.WriteLine("Enter order data: ");

        //    Console.Write("Status: ");
        //    OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        //    Console.Write("How many items to this order? ");
        //    int n = int.Parse(Console.ReadLine());

        //    Order order = new Order(DateTime.Now, status, client);

        //    for (int i = 1; i <= n; i++)
        //    {
        //        Console.WriteLine($"Enter #{i} item data:");
        //        Console.Write("Product name: ");
        //        string productName = Console.ReadLine();

        //        Console.Write("Product price: ");
        //        double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //        Console.Write("Quantity: ");
        //        int quantity = int.Parse(Console.ReadLine());

        //        Product product = new Product(productName, productPrice);

        //        OrderItem orderItem = new OrderItem(quantity, productPrice);
        //        orderItem.Product = product;

        //        order.AddItem(orderItem);
        //    }

        //    Console.WriteLine();

        //    Console.WriteLine("ORDER SUMMARY:");
        //    Console.WriteLine($"Order moment: {order.Moment.ToString("dd/MM/yyyy hh:mm:ss")}");
        //    Console.WriteLine($"Order Status: {order.OrderStatus}");
        //    Console.WriteLine($"Client: {order.Client.Name} ({order.Client.BirthDate.ToShortDateString()}) - {order.Client.Email}");
        //    Console.WriteLine("Order Items: ");
        //    for (int i = 0; i < order.Items.Count; i++)
        //    {
        //        Console.WriteLine($"{order.Items[i].Product.Name}, ${order.Items[i].Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {order.Items[i].Quantity}, SubTotal: ${order.Items[i].subTotal().ToString("F2", CultureInfo.InvariantCulture)} ");
        //    }
        //    Console.WriteLine($"Total price: ${order.Total().ToString("F2", CultureInfo.InvariantCulture)}");
        //}

        #endregion

        #region Herança

        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the number of products: ");
        //    int qttProducts = int.Parse(Console.ReadLine());

        //    Product p = new Product();
        //    ImportedProduct ip = new ImportedProduct();
        //    UsedProduct up = new UsedProduct();

        //    for (int i = 1; i <= qttProducts; i++)
        //    {
        //        Console.WriteLine($"Product #{i} data:");
        //        Console.Write("Common, used or imported (c/u/i)? ");
        //        char type = char.Parse(Console.ReadLine());
        //        string name = "";
        //        double price = 0;


        //        switch (type)
        //        {
        //            case 'c':
        //                Console.Write("Name: ");
        //                name = Console.ReadLine();
        //                Console.Write("Price: ");
        //                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //                p = new Product(name, price);
        //                break;
        //            case 'u':
        //                Console.Write("Name: ");
        //                name = Console.ReadLine();
        //                Console.Write("Price: ");
        //                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //                Console.Write("Manufacture Date (DD/MM/YYYY): ");
        //                var manufactureDate = DateTime.Parse(Console.ReadLine());
        //                up = new UsedProduct(manufactureDate, name, price);
        //                break;
        //            case 'i':
        //                Console.Write("Name: ");
        //                name = Console.ReadLine();
        //                Console.Write("Price: ");
        //                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //                Console.Write("Cusmots fee: ");
        //                var customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //                ip = new ImportedProduct(customsFee, name, price);
        //                break;
        //            default:
        //                break;
        //        }
        //    }

        //    Console.WriteLine("PRICE TAGS:");
        //    Console.WriteLine($"{ip.PriceTag()}");
        //    Console.WriteLine($"{p.PriceTag()}");
        //    Console.WriteLine($"{up.PriceTag()}");
        //}

        #endregion

        #region Métodos Abstratos e classes Abstratas

        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the number of tax payers: ");
        //    int qtt = int.Parse(Console.ReadLine());
        //    List<TaxPayer> taxPayer = new List<TaxPayer>();

        //    for (int i = 1; i <= qtt; i++)
        //    {
        //        Console.WriteLine($"Tax payer #{i} data: ");
        //        Console.Write("Individual or company (i/c)? ");
        //        char type = char.Parse(Console.ReadLine());

        //        if (type == 'i')
        //        {
        //            Console.Write("Name: ");
        //            var name = Console.ReadLine();
        //            Console.Write("Anual income: ");
        //            var income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //            Console.Write("Health expenditures: ");
        //            var healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //            taxPayer.Add(new Individual(healthExpenditures, name, income));
        //        }
        //        else if (type == 'c')
        //        {
        //            Console.Write("Name: ");
        //            var name = Console.ReadLine();
        //            Console.Write("Anual income: ");
        //            var income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //            Console.Write("Number of employees: ");
        //            var numberOfEmployees = int.Parse(Console.ReadLine());

        //            taxPayer.Add(new Company(numberOfEmployees, name, income));
        //        }
        //    }

        //    Console.WriteLine();

        //    Console.WriteLine("TAXES PAID:");
        //    double totalTax = 0;

        //    for (int i = 0; i < taxPayer.Count; i++)
        //    {
        //        Console.WriteLine($"{taxPayer[i].Name}: $ {taxPayer[i].Tax().ToString("F2", CultureInfo.InvariantCulture)}");
        //        totalTax += taxPayer[i].Tax();
        //    }

        //    Console.WriteLine();

        //    Console.WriteLine($"TOTAL TAXES: ${totalTax.ToString("F2", CultureInfo.InvariantCulture)}");
        //}

        #endregion

        #region Tratamento de Exceções e personalização delas

        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holderName = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("WithDraw limit: ");
            double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(accountNumber, holderName, balance, withDrawLimit);

            try
            {
                account.WithDraw(withDraw);

                Console.Write($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (Exception e)
            {
                Console.Write($"WiithDraw error: {e.Message}");
            }
        }*/

        #endregion

        #region Manipulação de arquivo. Copei do github do Nélio Alves

        //static void Main(string[] args)
        //{
        //    Console.Write("Enter file full path: ");
        //    string sourceFilePath = Console.ReadLine();

        //    try
        //    {
        //        string[] lines = File.ReadAllLines(sourceFilePath);

        //        string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
        //        string targetFolderPath = sourceFolderPath + @"\out";
        //        string targetFilePath = targetFolderPath + @"\summary.csv";

        //        Directory.CreateDirectory(targetFolderPath);

        //        using (StreamWriter sw = File.AppendText(targetFilePath))
        //        {
        //            foreach (string line in lines)
        //            {

        //                string[] fields = line.Split(',');
        //                string name = fields[0];
        //                double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
        //                int quantity = int.Parse(fields[2]);

        //                Product prod = new Product(name, price, quantity);

        //                sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
        //            }
        //        }
        //    }
        //    catch (IOException e)
        //    {
        //        Console.WriteLine("An error occurred");
        //        Console.WriteLine(e.Message);
        //    }
        //}

        #endregion

        #region Interfaces

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter contract data");

        //    Console.Write("Number: ");
        //    int contractNumber = int.Parse(Console.ReadLine());

        //    Console.Write("Date (dd/MM/yyyy): ");
        //    DateTime contractDate = DateTime.Parse(Console.ReadLine());

        //    Console.Write("Contract value: ");
        //    double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //    Console.Write("Enter number of installments: ");
        //    int installments = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Installments:");

        //    var contractService = new ContractService(new PaymentService());
        //    var contract = contractService.FillContract(contractNumber, contractDate, contractValue, installments);

        //    for (int i = 0; i < contract.Installments.Count; i++)
        //    {
        //        Console.WriteLine($"{contract.Installments[i].DueDate.ToString("dd/MM/yyyy")} - {contract.Installments[i].Amount.ToString("F2", CultureInfo.InvariantCulture)}");
        //    }
        //}

        #endregion

        #region Linq

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter full file path: ");
                string path = Console.ReadLine();

                Console.Write("Enter salary: ");
                double userSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                List<Employee> employees = new List<Employee>();

                using (StreamReader streamReader = File.OpenText(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string[] data = streamReader.ReadLine().Split(",");
                        string name = data[0];
                        string email = data[1];
                        double salary = double.Parse(data[2], CultureInfo.InvariantCulture);

                        employees.Add(new Employee(name, email, salary));
                    }
                }

                Console.WriteLine($"Email of people whose salary is more than {userSalary.ToString("F2", CultureInfo.InvariantCulture)}");

                var emails = employees.Where(e => e.Salary > userSalary).OrderBy(e => e.Email).Select(e => e.Email);
                foreach (var item in emails)
                {
                    Console.WriteLine(item);
                }

                var sumSalary = employees.Where(e => e.Name.StartsWith("M")).Select(e => e.Salary).Sum();
                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sumSalary.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        #endregion
    }

    //class Room
    //{
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public int RoomNumber { get; set; }
    //}

    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public double Salary { get; set; }
    //}

    //public enum OrderStatus
    //{
    //    PendingStatus = 0,
    //    Processing = 1,
    //    Shipped = 2,
    //    Delivered = 3
    //}

    //public class Product
    //{
    //    public string Name { get; set; }
    //    public double Price { get; set; }

    //    public Product()
    //    {
    //    }

    //    public Product(string name, double price)
    //    {
    //        Name = name;
    //        Price = price;
    //    }
    //}

    //public class OrderItem
    //{
    //    public int Quantity { get; set; }
    //    public double Price { get; set; }
    //    public Product Product { get; set; }

    //    public OrderItem()
    //    {

    //    }

    //    public OrderItem(int qunatity, double price)
    //    {
    //        Quantity = qunatity;
    //        Price = price;
    //    }

    //    public double subTotal()
    //    {
    //        return Quantity * Price;
    //    }
    //}

    //public class Client
    //{
    //    public string Name { get; set; }
    //    public string Email { get; set; }
    //    public DateTime BirthDate { get; set; }

    //    public Client()
    //    {

    //    }

    //    public Client(string name, string email, DateTime birthDate)
    //    {
    //        Name = name;
    //        Email = email;
    //        BirthDate = birthDate;
    //    }
    //}

    //public class Order
    //{
    //    public DateTime Moment { get; set; }
    //    public OrderStatus OrderStatus { get; set; }
    //    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    //    public Client Client { get; set; }

    //    public Order()
    //    {

    //    }

    //    public Order(DateTime moment, OrderStatus orderStatus, Client client)
    //    {
    //        Moment = moment;
    //        OrderStatus = orderStatus;
    //        Client = client;
    //    }

    //    public void AddItem(OrderItem orderItem)
    //    {
    //        Items.Add(orderItem);
    //    }

    //    public void RemoveItem(OrderItem orderItem)
    //    {
    //        Items.Remove(orderItem);
    //    }

    //    public double Total()
    //    {
    //        double total = 0;

    //        for (int i = 0; i < Items.Count; i++)
    //        {
    //            total += Items[i].subTotal();
    //        }

    //        return total;
    //    }
    //}

    //public class Product
    //{
    //    public string Name { get; set; }
    //    public double Price { get; set; }

    //    public Product(string name, double price)
    //    {
    //        Name = name;
    //        Price = price;
    //    }

    //    public Product()
    //    {

    //    }

    //    public virtual string PriceTag()
    //    {
    //        return $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
    //    }
    //}

    //public class ImportedProduct : Product
    //{
    //    public double CustomsFee { get; set; }

    //    public ImportedProduct()
    //    {

    //    }

    //    public ImportedProduct(double customsFee, string name, double price) : base(name, price)
    //    {
    //        CustomsFee = customsFee;
    //    }

    //    public override string PriceTag()
    //    {
    //        return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs Fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
    //    }

    //    public double TotalPrice()
    //    {
    //        return Price + CustomsFee;
    //    }
    //}

    //public class UsedProduct : Product
    //{
    //    public DateTime ManufactureDate { get; set; }

    //    public UsedProduct()
    //    {

    //    }

    //    public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price)
    //    {
    //        ManufactureDate = manufactureDate;
    //    }

    //    public override string PriceTag()
    //    {
    //        return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture Date: {ManufactureDate.ToShortDateString()})";
    //    }
    //}


    //public abstract class TaxPayer
    //{
    //    public string Name { get; set; }
    //    public double AnualIncome { get; set; }

    //    public TaxPayer()
    //    {

    //    }

    //    protected TaxPayer(string name, double anualIncome)
    //    {
    //        Name = name;
    //        AnualIncome = anualIncome;
    //    }

    //    public abstract double Tax();
    //}

    //public class Individual : TaxPayer
    //{
    //    public double HealthExpenditures { get; set; }

    //    public Individual()
    //    {

    //    }

    //    public Individual(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
    //    {
    //        HealthExpenditures = healthExpenditures;
    //    }

    //    public override double Tax()
    //    {
    //        if (AnualIncome <= 20000.00)
    //            return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
    //        else if (AnualIncome > 20000.00)
    //            return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);

    //        return AnualIncome;
    //    }
    //}

    //public class Company : TaxPayer
    //{
    //    public int NumberOfEmployees { get; set; }

    //    public Company()
    //    {

    //    }

    //    public Company(int numberOfEmployees, string name, double anualIncome) : base(name, anualIncome)
    //    {
    //        NumberOfEmployees = numberOfEmployees;
    //    }

    //    public override double Tax()
    //    {
    //        if (NumberOfEmployees <= 10)
    //        {
    //            return AnualIncome * 0.16;
    //        }
    //        else if (NumberOfEmployees > 10)
    //        {
    //            return AnualIncome * 0.14;
    //        }

    //        return AnualIncome;
    //    }
    //}

    //public class DomainException : ApplicationException
    //{
    //    public DomainException(string message) : base(message)
    //    {
    //    }
    //}

    //public class Account
    //{

    //    public int Number { get; set; }
    //    public string Holder { get; set; }
    //    public double Balance { get; set; }
    //    public double WithDrawLimit { get; set; }

    //    public Account(int number, string holder, double balance, double withDrawLimit)
    //    {
    //        Number = number;
    //        Holder = holder;
    //        Balance = balance;
    //        WithDrawLimit = withDrawLimit;
    //    }

    //    public void Deposit(double amount)
    //    {
    //        Balance += amount;
    //    }

    //    public void WithDraw(double amount)
    //    {
    //        if (amount > Balance)
    //            throw new DomainException("Not enough balance");

    //        if (amount > WithDrawLimit)
    //            throw new DomainException("The amount exceeds withdraw limit");

    //        Balance -= amount;
    //    }
    //}

    //class Product
    //{
    //    public string Name { get; set; }
    //    public double Price { get; set; }
    //    public int Quantity { get; set; }

    //    public Product(string name, double price, int quantity)
    //    {
    //        Name = name;
    //        Price = price;
    //        Quantity = quantity;
    //    }

    //    public double Total()
    //    {
    //        return Price * Quantity;
    //    }
    //}

    //class Contract
    //{
    //    public Contract(int number, DateTime date, double totalValue)
    //    {
    //        Number = number;
    //        Date = date;
    //        TotalValue = totalValue;
    //    }

    //    public int Number { get; set; }
    //    public DateTime Date { get; set; }
    //    public double TotalValue { get; set; }

    //    public List<Installment> Installments { get; set; } = new List<Installment>();
    //}

    //class Installment
    //{
    //    public Installment(DateTime dueDate, double amount)
    //    {
    //        DueDate = dueDate;
    //        Amount = amount;
    //    }

    //    public DateTime DueDate { get; set; }
    //    public double Amount { get; set; }
    //}

    //interface IPaymentService
    //{
    //    Contract ProcessPaymentInstallments(Contract contract, int installments);
    //}

    //class PaymentService : IPaymentService
    //{
    //    public Contract ProcessPaymentInstallments(Contract contract, int installments)
    //    {
    //        var valueInstallments = contract.TotalValue / installments;

    //        for (int i = 1; i <= installments; i++)
    //        {
    //            var interest = valueInstallments * 0.01 * i + valueInstallments;
    //            var paypal = interest * 0.02 + interest;

    //            var installment = new Installment(contract.Date.AddMonths(i), paypal);

    //            contract.Installments.Add(installment);
    //        }

    //        return contract;
    //    }
    //}

    //interface IContractService
    //{
    //    Contract FillContract(int number, DateTime date, double value, int installments);
    //}

    //class ContractService : IContractService
    //{
    //    IPaymentService _paymentService;

    //    public ContractService(IPaymentService paymentService)
    //    {
    //        _paymentService = paymentService;
    //    }

    //    public Contract FillContract(int number, DateTime date, double value, int installments)
    //    {
    //        return _paymentService.ProcessPaymentInstallments(new Contract(number, date, value), installments);
    //    }
    //}

    class Employee
    {
        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
    }
}
