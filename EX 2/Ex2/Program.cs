int option = 0;
int choice = 0;

StockManager stockManager = new StockManager();

do
{
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Cadastrar novo produto.");
    Console.WriteLine("2 - Remover produto.");
    Console.WriteLine("3 - Pesquisar um produto.");
    Console.WriteLine("4 - Listar produtos.");
    Console.WriteLine("0 - Sair.");

    option = Convert.ToInt32(Console.ReadLine());

    switch(option)
    {
        case 0: Console.WriteLine("Saindo do programa");
        break;

        case 1: Console.WriteLine("---------------------------------");
        Console.WriteLine("Informe o nome do produto:");
        string name = Console.ReadLine();
        Console.WriteLine("Informe o preço do produto:");
        double price = Convert.ToDouble(Console.ReadLine());
        stockManager.AddProduct(name, price);
        break;

        case 2: Console.WriteLine("---------------------------------");
        Console.WriteLine("Informe o nome do produto");
        name = Console.ReadLine();
        if(stockManager.RemoveProduct(name))
            Console.WriteLine($"Produto {name} removido com sucesso");
        else
            Console.WriteLine($"O produto não existe no estoque!");
        break;

        case 3: Console.WriteLine("---------------------------------");
        Console.WriteLine("Informe o nome do produto:");
        name = Console.ReadLine();
        Console.WriteLine(stockManager.SearchProduct(name));
        break;

        case 4: Console.WriteLine("---------------------------------");
        Console.WriteLine("Deseja organizar por preço ou nome?\n1. Preço\n2. Nome");
        choice = Convert.ToInt32(Console.ReadLine());
            if(choice==1)
                stockManager.ListAllProducts();
            if(choice==2)
                stockManager.ListAllProductsName();
        break;

        default: Console.WriteLine("---------------------------------");
        Console.WriteLine("Opção inválida!");
        break;

    }

}while(option!=0);