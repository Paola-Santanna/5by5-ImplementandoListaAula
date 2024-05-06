using Implementando_Lista___aula_13;

Console.WriteLine("Hello, Listas!!");

ContactList l1 = new ContactList();

Contact contact1 = new("Bernardo", "123");

l1.Add(contact1);

Contact contact2 = new("Ana", "321");

l1.Add(contact2);

Contact contact3 = new("Caue", "456");

l1.Add(contact3);

l1.Add(new Contact("Bruna", "987"));

Console.WriteLine();

string nome, telefone;
int continuar = 0;

while (continuar != 2)
{
    Console.Write("Digite o nome de quem você quer eliminar da lista: ");
    nome = Console.ReadLine();
    l1.RemoveByName(nome);

    Console.WriteLine();
    Console.WriteLine("Deseja remover mais alguém?");
    Console.WriteLine("1 - Sim \t2 - Não");
    continuar = int.Parse(Console.ReadLine());

    switch (continuar)
    {
        case 1:
            Console.WriteLine("Continuando...\n");
            break;
        case 2:
            Console.WriteLine("Encerrando...\n");
            break ;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

l1.ShowAll();