class Medico{
    public string Nome {get;private set;}

    public Medico(string nome){
        Nome = nome;
    }

    public void AtenderPaciente(Paciente paciente){
        Console.WriteLine($"O médico {Nome} está atendendo o paciente {paciente.Nome}");
    }
}