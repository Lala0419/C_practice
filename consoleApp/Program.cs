// See https://aka.ms/new-console-template for more information;

using System.Text;

string petFish = "pupper fish";

petFish = "porcupine " + petFish;

Console.WriteLine($"I AM BUYING {petFish}");
Console.WriteLine($"yes, ${petFish}");

Console.WriteLine(petFish);

//UPDATE
//petfish[0] = "P" // does not work with C#
string newPetFish = petFish.Replace("porcupine", "blue dot");

Console.WriteLine(newPetFish);

//DELETE
//String Builder
StringBuilder newPet = new ();
newPet.Append("shiba inu");
Console.WriteLine(newPet);
newPet.Remove(0, 5);
Console.WriteLine(newPet);