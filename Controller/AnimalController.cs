public class AnimalController
{
    private AnimalDAO animalDAO;

    public AnimalController()
    {
        animalDAO = new AnimalDAO();
    }

    public void AddNewAnimal(string type)
    {
        Animal newAnimal = null;
        switch (type)
        {
            case "Cow":
                newAnimal = new Cow();
                break;
            case "Sheep":
                newAnimal = new Sheep();
                break;
            case "Goat":
                newAnimal = new Goat();
                break;
            default:
                break;
        }

        if (newAnimal != null)
        {
            newAnimal.BirthDate = DateTime.Now;
            animalDAO.AddAnimal(newAnimal);
        }
    }

    public string GetAnimalSounds()
    {
        List<Animal> animals = animalDAO.GetAllAnimals();
        string sounds = "";
        foreach (Animal animal in animals)
        {
            switch (animal.GetType().Name)
            {
                case "Cow":
                    sounds += ((Cow)animal).MakeSound() + " ";
                    break;
                case "Sheep":
                    sounds += ((Sheep)animal).MakeSound() + " ";
                    break;
                case "Goat":
                    sounds += ((Goat)animal).MakeSound() + " ";
                    break;
                default:
                    sounds += animal.MakeSound() + " ";
                    break;
            }
        }
        return sounds;
    }

    public void SimulateNewDay()
    {
        List<Animal> animals = animalDAO.GetAllAnimals(); 
        List<Animal> newbornAnimals = new List<Animal>();

        foreach (Animal animal in animals)
        {
            // Add milk
            decimal milkProduced = animal.ProduceMilk();
            animal.MilkGiven += milkProduced;
            animalDAO.UpdateMilkGiven(animal.AnimalId, animal.MilkGiven);

            // Add children
            int offspringCount = animal.GiveBirth(); 
            for (int i = 0; i < offspringCount; i++)
            {
                Animal newborn = null;
                switch (animal.AnimalType)
                {
                    case "Cow":
                        newborn = new Cow();
                        break;
                    case "Sheep":
                        newborn = new Sheep();
                        break;
                    case "Goat":
                        newborn = new Goat();
                        break;
                }

                if (newborn != null)
                {
                    newborn.BirthDate = DateTime.Now;
                    newbornAnimals.Add(newborn);
                }
            }
        }

        foreach (Animal newborn in newbornAnimals)
        {
            animalDAO.AddAnimal(newborn);
        }
    }
    public decimal GetTotalMilkProduced()
    {
        return animalDAO.GetTotalMilk();
    }
    public int GetAnimalCount(string animalType)
    {
        return animalDAO.GetAnimalCountByType(animalType);
    }
}