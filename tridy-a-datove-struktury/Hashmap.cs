class User
{
    public string Name { get; set; }
    public int Age
    {
        get;
        set
        {
            if (value < 0) throw new Exception();
            field = value;
        }
    }
}

// class Program
// {
//     static void Main()
//     {
//         List<User> users = new List<User> {
//             new User { Name = "Alice", Age = 30 },
//             new User { Name = "Bob", Age = 25 },
//             new User { Name = "Alfons", Age = -12 }
//         };

//         string name = Console.ReadLine();
//         User foundUser = users.Find(user => user.Name == name);
//         Console.WriteLine($"{name}'s Age = {foundUser.Age}");
//     }
// }


class Program
{
    static void Main()
    {
        Dictionary<string, int> userAges = new Dictionary<string, int>
        {
            { "Alice", 20},
            { "Bob", 20},
            { "Alfons", 20}
        };
    }
}

