﻿using IOprojekt.Interfaces;
using MongoDB.Driver;
using System;

namespace IOprojekt.Factories
{
    public class MongoDatabaseFactory : IMongoDatabaseFactory
    {
        public IMongoDatabase Connect(string connectionString, string dbName)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("connectionString");
            if (string.IsNullOrWhiteSpace(dbName))
                throw new ArgumentNullException("dbName");

            var dbClient = new MongoClient(connectionString);
            return dbClient.GetDatabase(dbName);
        }
    }
}
