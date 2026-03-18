class Person
{
    private string name;
    public string surname;

    public Person(string name)
    {
        this.name = name;
    }

    public void GetInfo()
    {
        Console.WriteLine(this.name);
    }
}
