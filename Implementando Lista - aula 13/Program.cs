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