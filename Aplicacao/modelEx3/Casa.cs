using System.IO.Compression;

class Casa {

    private List<Comodo> comodos = new List<Comodo>();

    public void AddComodo(Comodo comodo){
        comodos.Add(comodo);
    }

    public void MostrarComodos(){
        if(comodos.Count!=0){
            foreach(Comodo comodo in comodos){
            Console.WriteLine(comodo.Nome);
        }
        }
    Console.WriteLine("Casa sem cômodos!");
        
    }
}