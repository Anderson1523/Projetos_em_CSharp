



Menu(); 

static void Menu()
{
    Console.WriteLine("Vamos Editar um texto?");
    Console.WriteLine("( ) SIM\n ( )NÃO");
    Console.WriteLine("Digite Abaixo: \n");
    String Decisao = Console.ReadLine();

    switch(Decisao)
    {
        case "SIM": Comeco(); break;

       case "NÃO":
        Console.WriteLine("Então Vamos encerrar, Tenha um ótimo dia!");
        Environment.Exit(0);
        break;
   
    }

    }

static void Comeco ()
{
    Console.WriteLine("--------------");
    Console.WriteLine("\n Bem vindo a um bloco de texto");

    Console.WriteLine("Deseja qual opção deseja");
    string op = Console.ReadLine();

switch (op) {
        case "a": Abrir();
            break;
        case "b": Criarnovo(); break;

        
    }

    
}

static void Criarnovo ()
{
    Console.WriteLine("Escreva abaixo: (Digite ESC para sair)\n");
    Console.WriteLine("Comece a escrever\n");
    String texto = "";
    do {
        texto += Console.ReadLine();
        texto += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);
    Salvar(texto);
    Console.Write(texto);
}
static void Salvar (string texto)
{
    Console.Clear();
    Console.WriteLine("Qual caminho para salvar o arquivo?");
    var patch = Console.ReadLine();

    using( var file = new StreamWriter(patch))
    {
        file.Write(texto);
    }
    Console.WriteLine($"Arquivo {patch} Salvo Com Sucesso!! ");
    Console.ReadLine();
    Menu();
}

static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Deseja Abrir qual arquivo?");
    String path = Console.ReadLine();

    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);

        Console.WriteLine(text);
        Console.WriteLine("");
        Console.ReadLine();
        Menu();
    }

}