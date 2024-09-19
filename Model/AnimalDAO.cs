using System.Data.SqlClient;

public class AnimalDAO
{
    private string connectionString = "data source=LAPTOP-1RVEUU34;initial catalog=Farm;trusted_connection=true";

    public void AddAnimal(Animal animal)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Animals (AnimalType, BirthDate, MilkGiven) VALUES (@Type, @BirthDate, @Milk)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Type", animal.AnimalType);
                command.Parameters.AddWithValue("@BirthDate", animal.BirthDate);
                command.Parameters.AddWithValue("@Milk", animal.MilkGiven);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public List<Animal> GetAllAnimals()
    {
        List<Animal> animals = new List<Animal>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Animals";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Get the animal type from the database
                        string animalType = reader.GetString(reader.GetOrdinal("AnimalType"));

                        // Create animal object based on type
                        Animal animal = null;
                        switch (animalType)
                        {
                            case "Cow":
                                animal = new Cow();
                                break;
                            case "Sheep":
                                animal = new Sheep();
                                break;
                            case "Goat":
                                animal = new Goat();
                                break;
                            default:
                                animal = new Animal();
                                break;
                        }

                        if (animal != null)
                        {
                            animal.AnimalId = reader.GetInt32(reader.GetOrdinal("AnimalId"));
                            animal.AnimalType = animalType;
                            animal.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                            animals.Add(animal);
                        }
                    }
                }
            }
        }
        return animals;
    }

    public int GetAnimalCountByType(string animalType)
    {
        int count = 0;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(*) FROM Animals WHERE AnimalType = @Type";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Type", animalType);
                connection.Open();
                count = (int)command.ExecuteScalar();
            }
        }
        return count;
    }
    public void UpdateMilkGiven(int animalId, decimal milkGiven)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "UPDATE Animals SET MilkGiven = @Milk WHERE AnimalId = @Id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Milk", milkGiven);
                command.Parameters.AddWithValue("@Id", animalId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
    public decimal GetTotalMilk()
    {
        decimal totalMilk = 0;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT SUM(MilkGiven) FROM Animals";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalMilk = (decimal)result;
                }
            }
        }
        return totalMilk;
    }

}