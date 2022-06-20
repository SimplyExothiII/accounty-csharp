namespace Account
{
    class Account
    {
        static void Main(string[] args)
        {
          if (File.Exists("password.txt") == false) {
            Console.WriteLine("Enter new password: ");
            string password = Console.ReadLine();
            File.WriteAllText("password.txt", password);
            Console.WriteLine("Password file made.");
          }
          if (File.Exists("username.txt") == false) {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            File.WriteAllText("username.txt", username);
            Console.WriteLine("Username file made.");
          } else if (File.Exists("username.txt") == true) {
            string read = File.ReadAllText("username.txt");
            Console.WriteLine("Hello there, " + read + ".");
            if (File.Exists("password.txt") == true) {
              Console.WriteLine("Enter password: ");
              string readp = File.ReadAllText("password.txt");
              string passwordenter = Console.ReadLine();
              if (passwordenter == readp) {
                Console.WriteLine("Succesfully logged in.");
                Console.WriteLine("Would you like to reset password? Y/N");
                string enter = Console.ReadLine();
                if (enter == "Y") {
                  Console.WriteLine("Enter the password you desire.");
                  string newpassword = Console.ReadLine();
                  File.WriteAllText("password.txt", newpassword);
                  Console.WriteLine("Password file made.");
                  Console.WriteLine("New password: " + newpassword);
                  Console.WriteLine("Bye!");
                } else if (enter == "N") {
                  Console.WriteLine("Bye!");
                }
              } else {
                Console.WriteLine("The password you entered is incorrect.");
                Console.WriteLine("Ending script...");
              }
            }
          }
        }
    }
}