using Dapper;
using MySqlConnector;

namespace Lexicon_Dapper
{
    public static class CityQuery
    {

        public static List<City> GetCitiesPopulationSpan(int start, int end) {
            string sql = "SELECT * FROM world.city WHERE Population >= " + start + " AND Population <= + " + end + ";";

            return GetCities(sql);
        }

        public static List<City> GetCities(string sql) {
            List<City> cities = new List<City>();

            string connectionString = "Server=localhost;Database=world;User=root;Password=abc123;";

            using(var connection = new MySqlConnection(connectionString)) {
                cities = connection.Query<City>(sql).ToList();
            }

            return cities;
        }
    }
}
