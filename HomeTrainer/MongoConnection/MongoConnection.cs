using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTrainer.Entities;
using MongoDB.Driver;

namespace HomeTrainer.MongoConnection
{
    public class MongoConnection
    {
        public User? currentUser;

        public static void AddUserToDb(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var collection = database.GetCollection<User>("UsersCollection");
            collection.InsertOne(user);
        }

        public User CheckLoginForUser(string login)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var filter = Builders<User>.Filter.Eq("Login", login);
            var collection = database.GetCollection<User>("DeveloperCollection");
            return collection.Find(filter).FirstOrDefault();

        }

        public User? CheckLogin(string login)
        {
            var loginUser = CheckLoginForUser(login);

            if (loginUser != null)
            {
                return loginUser
            }
            return null;
        }
    }
}
