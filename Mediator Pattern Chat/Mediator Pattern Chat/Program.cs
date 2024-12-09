using Mediator_Pattern_Chat;


namespace ChatSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chatMediator = new ChatMediator();

            User user1 = new User("Книга Матвей", chatMediator);
            User user2 = new User("Колосов ДА", chatMediator);
            User user3 = new User("Гойденко Егор", chatMediator);

            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            user1.SendMessage("Привет, Боб!", "Колосов ДА");
            user2.SendMessage("Привет, Элис! Как дела?", "Книга Матвей");
            user3.SendMessage("Привет всем!", "Книга Матвей");

            Console.WriteLine();
            chatMediator.ShowMessageHistory("Книга Матвей");
            chatMediator.ShowMessageHistory("Колосов ДА");

            chatMediator.RemoveUser("Гойденко Егор");
        }
    }
}
