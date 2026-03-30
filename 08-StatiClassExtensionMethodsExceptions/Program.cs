static void Main()
{
    LoginSystem system = new LoginSystem();
    while (true)
    {
        try
        {
            Console.WriteLine("Username");
            string username = Console.ReadLine();

            Console.WriteLine("Password");
            string password = Console.ReadLine();

            break;
        }
        catch (InvalidUsernameException ex)
        {
            Console.WriteLine("Error" + ex.Message);
        }
        catch (UserNotFoundException ex)
        {
            Console.WriteLine("Error" + ex.Message);
        }
        catch (AccountLockedException ex)
        {
            Console.WriteLine("CRITICAL: " + ex.Message + " Contact admin.");
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine("UNEXPECTED ERROR: " + ex.Message);
        }
    }
}

