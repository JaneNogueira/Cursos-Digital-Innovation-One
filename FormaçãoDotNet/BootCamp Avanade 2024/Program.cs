/*Explorando Sintaxe e Tipos de Dados
1 / 1 - Registro de Usuário*/

using System;

class Program
{
    static void Main(string[] args)
    {

// TODO: Declare as variáveis para guardar as informações de nome, email e senha:
    string registroEmail = "";
    string registroNome = "";
    string registroSenha = "";

// Obtém o email e nome do usuário a partir da entrada do console
    registroEmail = Console.ReadLine();
    registroNome = Console.ReadLine();

// TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
    Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");

    }
}


/*Explorando Sintaxe e Tipos de Dados
1 / 1 - Registro de Usuário */

using System;

class Program
{
    static void Main(string[] args)
    {

// TODO: Declare as variáveis para guardar as informações de nome, email e senha:
    string registroEmail = "";
    string registroNome = "";
    string registroSenha = "";
// Obtém o email e nome do usuário a partir da entrada do console
    registroEmail = Console.ReadLine();
    registroNome = Console.ReadLine();
// TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
    Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");

    }
}

/*Desvendando o Controle de Fluxo
1 / 1 - Soma de Números Pares em Intervalo */

using System;

class Program
{
    static void Main()
    {
    // Solicita ao usuário os limites inferiores e superiores
    int limiteInferior = int.Parse(Console.ReadLine());
    int limiteSuperior = int.Parse(Console.ReadLine());

    // Variável para acumular a soma dos números pares
    int somaPares = 0;

    // TODO: Crie um Loop para percorrer os números no intervalo
    for(int i = limiteInferior; i <= limiteSuperior; i++ )
    // TODO: Implemente o if para verificar se o número é par:
      {
        if(i % 2 == 0)
        {
          somaPares += i;
        }
      }
    // Exibe o resultado
    Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
    }
}

/*Utilizando Array e Listas
1 / 1 - Catálogo de Jogos*/

using System;

class Program
{
    static void Main()
    {
        // Pergunta ao usuário quantos jogos deseja adicionar:
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // TODO: Inicializa os arrays com base na quantidade informada pelo usuário:
        string[]nomesJogos = new string[quantidadeJogos];
        // TODO: Crie um Loop para adicionar jogos conforme a quantidade especificada:
        for(int i = 0; i < quantidadeJogos; i ++)
        //TODO: Chame a função AdicionarJogo para obter o nome do jogo e armazená-lo no array:
        {
          AdicionarJogo(i, nomesJogos);
        }

        // Exibe o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }
    
    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {string.Join(", ", nomes)} ao catalogo.");
    }
}

/*Manipulando Funções
1 / 1 - Cálculo de Pegada de Carbono */

using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário, quilômetros percorridos por dia, 
        // Horas de uso de eletrônicos por dia e o número de refeições com carne:
       string nome = Console.ReadLine();
       double quilometrosPorDia = double.Parse(Console.ReadLine());
       int horasDeEletronicos = int.Parse(Console.ReadLine());
       int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);
        
        // TODO: Exiba o resultado para o usuário:
          Console.WriteLine(nome + ", sua pegada de carbono e de " + pegadaDeCarbono + " toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
          Console.ReadLine();
    }

    // TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
    static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
      return(quilometrosPorDia * 365 * 0.2) + (horasDeEletronicos * 0.1) + (refeicoesComCarne * 0.5);
    }
    
}

/* Primeiro Desafio com POO
1 / 1 - Primeiro Desafio com POO */

using System;

class Pessoa
{
  
    private string nome;
    private int idade;
  
    public Pessoa(string n, int i)
    {
        nome = n;
        idade = i;
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
}

class Program
{
    static void Main()
    {
      string nome = Console.ReadLine();
      int idade = int.Parse(Console.ReadLine());
      
      Pessoa pessoa = new Pessoa(nome, idade);
      Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");
    }
}

/* Utilizando Propriedades e Métodos
1 / 1 - Controle de Velocidade do Robô*/

using System;

class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}

class Program
{
    static void Main()
    {
        string[] valores = Console.ReadLine().Split(' ');
        int vmin = int.Parse(valores[0]);
        int vmax = int.Parse(valores[1]);

        Robo robo = new Robo(vmin, vmax);
        
        string comandos = Console.ReadLine();

        foreach (char comando in comandos)
        {
            if (comando == 'A')
            {
                robo.Acelerar();
            }
            else if (comando == 'D')
            {
                robo.Desacelerar();
            }
        }
        Console.WriteLine(robo.VelocidadeAtual);
    }
}

/* Criando um Objeto com Atributos
1 / 1 - Criando um jogador de futebol*/

using System;

class Jogador
{
    public string Nome {get; set; }
    public string Nacionalidade {get; set; }
    public int Idade {get; set; }
    public string Posicao {get; set; }

    public Jogador()
    {
    }
    
    public static Jogador NovoJogador(string nome, string nacionalidade, int idade, string posicao)
    {
      Jogador novoJogador = new Jogador
      {
        Nome = nome,
        Nacionalidade = nacionalidade,
        Idade = idade,
        Posicao = posicao
      };
      return novoJogador;
    }
}

class Program
{

    static void Main()
    {
      string nome = Console.ReadLine();
      string nacionalidade = Console.ReadLine();
      int idade = int.Parse(Console.ReadLine());
      string posicao = Console.ReadLine();
  
      Jogador jogadorCriado = Jogador.NovoJogador(nome, nacionalidade, idade, posicao);
  
      Console.WriteLine("Jogador criado!");
      Console.WriteLine(jogadorCriado.Nome);
      Console.WriteLine(jogadorCriado.Nacionalidade);
      Console.WriteLine(jogadorCriado.Idade);
      Console.WriteLine($"Posição: {jogadorCriado.Posicao}");
    }
}

/*Utilizando Construtores
1 / 1 - Criando seu Personagem*/ 

using System;

class Personagem
{
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; } = 1;
    public int Vida { get; set; } = 10;

    public Personagem(string nome, string raca, string classe)
    {
        Nome = nome;
        Raca = raca;
        Classe = classe;
    }

    public void ExibirStatus()
    {
        Console.WriteLine("Status: ");
        Console.WriteLine("Nome:" + Nome);
        Console.WriteLine("Raça:" + Raca);
        Console.WriteLine("Classe:" + Classe);
        Console.WriteLine("Nível:" + Nivel);
        Console.WriteLine("Vida:" + Vida);
    }
}

class Program
{
    static void Main()
    {
      string nome = Console.ReadLine();
      string raca = Console.ReadLine();
      string classe = Console.ReadLine();
      
      
      Personagem novoPersonagem = new Personagem(nome, raca, classe);
      novoPersonagem.ExibirStatus();
    }
}

/* Utilizando Herança e Subclasses
1 / 1 - A batalha dos RPGistas: herança e subclasse! */

using System;

class Personagem
{
  public string Nome {get; set; }
  public int Mana {get; set; }

  public Personagem(string nome, int mana)
  {
    Nome = nome;
    Mana = mana;
  }
}

class Subclasse : Personagem
{
  public int DanoBase {get; set; }

  public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
  {
    DanoBase = danoBase;
  }

  public void CalcularDano()
  {
    Console.WriteLine(Nome + " atacou e causou " + DanoBase * Mana + " de dano!");
  }
}

class Program
{
  static void Main()
  {
    string nome = Console.ReadLine();
    int mana = int.Parse(Console.ReadLine());
    int danoBase = int.Parse(Console.ReadLine());
      
    Subclasse avatar = new Subclasse(nome, mana, danoBase);
    avatar.CalcularDano(); 
  }
}



