using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Model
{
    public class UserManager
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedOn { get; set; }

        public static List<UserManager> SeedData()
        {
            return new List<UserManager>
            {
                new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 1",
                    LastName = "Test 1",
                    Username = "TestUsername1",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                },
                new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 2",
                    LastName = "Test 2",
                    Username = "TestUsername2",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                },
                new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 3",
                    LastName = "Test 3",
                    Username = "TestUsername3",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                },
                new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 4",
                    LastName = "Test 4",
                    Username = "TestUsername4",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                },
                new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 5",
                    LastName = "Test 5",
                    Username = "TestUsername5",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                },
                new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 6",
                    LastName = "Test 6",
                    Username = "TestUsername6",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                },
                new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 7",
                    LastName = "Test 7",
                    Username = "TestUsername7",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                },
                new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 8",
                    LastName = "Test 8",
                    Username = "TestUsername8",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                },
                new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 9",
                    LastName = "Test9 ",
                    Username = "TestUsername9",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                },
                new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 10",
                    LastName = "Test 10",
                    Username = "TestUsername10",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                },
                new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 11",
                    LastName = "Test 11",
                    Username = "TestUsername11",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                },new UserManager
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Test 12",
                    LastName = "Test 12",
                    Username = "TestUsername12",
                    Password = "123",
                    CreatedOn = DateTime.UtcNow
                }
            };
        }
    }
}
