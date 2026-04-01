using _09_UpcastingDowncastingExplicitImplicit;

static void Main(string[] args)
{
    // Dog dog = new Dog { AvgLifeTime = 13, Breed = "kangal", Gender = "male", Name = "Hatice" };
    // Eagele eagele = new Eagele { AvgLifeTime = 130, FlySpeed = 100, Gender = "Female" };


    // Animal animal = dog;
    // Animal animal2 = eagele;

    //Dog dog1 = (Dog)animal;
    //Eagele eagele1 = (Eagele)animal;

    // Animal[] animal = { eagele, dog };
    // foreach (var anim in animals)
    //// {
    //  Eagele eagele1 = animal as Eagele;

    /// if (animal is eagele1)
    //{
    //     Eagele eagele2 = (Eagele)animal;
    // }
    // }

    Dollar dollar = new (200);
   

    Manatcs manat = new (140);

    Dollar dollar1 = manat;
    Console.WriteLine(dollar1.USD);

    Manatcs manat1 = dollar;
    Console.WriteLine(manat1.AZN);
}
