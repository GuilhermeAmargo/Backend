List <Account> accounts = new List<Account> ();

Account a1 = new("Caina Antunes",1002);
Account a2 = new("Andre Cassulino",1004);
Account a3 = new("Gabriel Claro",1003);
Account a4 = new("Glauco Todesco",1001);

accounts.Add(a1);
accounts.Add(a2);
accounts.Add(a3);
accounts.Add(a4);

accounts.Sort();

foreach(Account account in accounts)
    Console.WriteLine(account);

Console.WriteLine("-----------------------");

accounts.Sort(new UserComparer());

foreach(Account account in accounts)
    Console.WriteLine(account);


