﻿using BinaryDiff.Shared.Infrastructure.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace BinaryDiff.Shared.Infrastructure.MongoDb
{
    public static class MongoDbFactory
    {
        public static IMongoClient GetClient(MongoDbConfiguration mongoConfig)
        {
            if (mongoConfig == null) throw new ArgumentNullException(nameof(mongoConfig));

            BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;

            var credentials = MongoCredential.CreateCredential(mongoConfig.UserDatabase, mongoConfig.User, mongoConfig.Password);

            var clientSettings = new MongoClientSettings
            {
                Credential = credentials,
                Server = new MongoServerAddress(mongoConfig.Host, mongoConfig.Port)
            };

            return new MongoClient(clientSettings);
        }
    }
}
