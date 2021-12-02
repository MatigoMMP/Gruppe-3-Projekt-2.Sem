using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using festival.Models;

namespace festival.Services
{
    public class EmployeeService
    {
        private readonly IMongoCollection<Employee> _employees;

        public EmployeeService(IFestDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _employees = database.GetCollection<Employee>(settings.EmployeesCollectionName);
        }

        public List<Employee> Get() =>
            _employees.Find(book => true).ToList();

        public Employee Get(string id) =>
            _employees.Find<Employee>(book => book.Id == id).FirstOrDefault();

        public Employee Create(Employee book)
        {
            _employees.InsertOne(book);
            return book;
        }

        public void Update(string id, Employee bookIn) =>
            _employees.ReplaceOne(book => book.Id == id, bookIn);

        public void Remove(Employee bookIn) =>
            _employees.DeleteOne(book => book.Id == bookIn.Id);

        public void Remove(string id) =>
            _employees.DeleteOne(book => book.Id == id);
    }
}
