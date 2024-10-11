// See https://aka.ms/new-console-template for more information
/*
int [] numbers1 = new int [10];

int [] numbers2 = null;

int [] numbers3 = {45,65,45,65};

Console.WriteLine(numbers1.Length);

string name1 = "Caina";
name1 = name1 + "Antunes";

foreach(int n in numbers1)
    Console.WriteLine(n);


Tv [] tvs = new Tv[10];

for (int i=0; i<tvs.Length; i++)
{
    tvs[i] = new Tv(55);
}

tvs[2].Channel = 10;

foreach(Tv tv in tvs)
    Console.WriteLine(tv);


int [] numbers = {0,5,6,7,1,4,3,8,2};

Array.Sort(numbers);

foreach(int n in numbers)
{
    Console.WriteLine(n);
}

Console.WriteLine(Array.BinarySearch(numbers,5));
Console.WriteLine(Array.BinarySearch(numbers,9));
*/

Product [] products = new Product [10];

products[0] = new Product ("Produto-1",4.50);
products[1] = new Product ("Produto-2",12.20);
products[2] = new Product ("Produto-3",6.10);
products[3] = new Product ("Produto-4",7.50);
products[4] = new Product ("Produto-5",54.20);
products[5] = new Product ("Produto-6",22.40);
products[6] = new Product ("Produto-7",32.60);
products[7] = new Product ("Produto-8",8.12);
products[8] = new Product ("Produto-9",9.40);
products[9] = new Product ("Produto-10",100.00);

Product maior = products[0];

for (int i=0; i<products.Length;i++)
{
  if (products[i].Price > maior.Price)
  maior = products[i];
}

Product segundoMaior = products[0];

for (int i=0;i<products.Length;i++)
{
  if (products[i].Price > segundoMaior.Price && !products[i].Name.Equals(maior.Name))
  segundoMaior = products[i];
}

Console.WriteLine("Produtos mais caros");
Console.WriteLine(maior);
Console.WriteLine(segundoMaior);

/*
foreach(Product n in products){
    Console.WriteLine(n);
}
*/