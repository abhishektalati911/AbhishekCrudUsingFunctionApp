using AnishSqlWebApp.Models;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using System.Text.Json;

namespace AnishSqlWebApp.Services
{
    public class ProductService 
    {
        //private static string db_source = "anishwebappserver.database.windows.net";
        //private static string db_user = "anish";
        //private static string db_password = "Indu@123";
        //private static string db_database = "AnishWebAppDB";

        private readonly IConfiguration _configuration;

        public ProductService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // private SqlConnection GetConnection()
        // {
        //var _builder = new SqlConnectionStringBuilder();
        //_builder.DataSource = db_source;
        //_builder.UserID = db_user;
        //_builder.Password = db_password;
        //_builder.InitialCatalog = db_database;


        // return new SqlConnection(_builder.ConnectionString);

        // return new SqlConnection(_configuration.GetConnectionString("SqlConnection"));


        public async Task<List<Product>> GetProducts()
        {
            String FunctionURL = "https://azurefunctionapp91.azurewebsites.net/api/GetAllEmployee?code=1m5u8asMs6SlRx6WGaNbPW7oKc-sNFwaDeWFBRBtvG1TAzFuqKjCtQ==";

            using (HttpClient _client = new HttpClient())
            {
                HttpResponseMessage _response = await _client.GetAsync(FunctionURL);
                string _content = await _response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Product>>(_content);
            }

        }
    }
}

