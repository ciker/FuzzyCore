﻿using System;
using MongoDB.Bson;
using FuzzyCore.Server;
using MongoDB.Driver;

namespace FuzzyCore.Database
{
    public class mongodb
    {
        ConsoleMessage Message = new ConsoleMessage();
        const string defaultHostName = "mongodb://localhost:27017";
        MongoClient monClient;
        public bool MongoInıt
        {
            get
            {
                return MongoInıt_Pri;
            }
        }
        private bool MongoInıt_Pri = false;
        public IMongoDatabase monData;
        public mongodb(string Database)
        {
            try
            {
                monClient = new MongoClient(defaultHostName);
                monData = monClient.GetDatabase(Database);
                bool isMongoLive = monData.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);

                if (isMongoLive)
                {
                    Message.Write("Connected MongoDB!", ConsoleMessage.MessageType.SUCCESS);
                    MongoInıt_Pri = true;
                }
                else
                {
                    Message.Write("Not Connected MongoDB!", ConsoleMessage.MessageType.ERROR);
                    MongoInıt_Pri = false;
                }
            }
            catch (Exception ex)
            {
                Message.Write(ex.Message.ToString(),ConsoleMessage.MessageType.ERROR);
            }
        }
        public mongodb(string Database,string Host , string UserName , string Password)
        {
            try
            {
                monClient = new MongoClient(Host);
                monData = monClient.GetDatabase(Database);
                bool isMongoLive = monData.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);

                if (isMongoLive)
                {
                    Message.Write("Connected MongoDB!", ConsoleMessage.MessageType.SUCCESS);
                    MongoInıt_Pri = true;
                }
                else
                {
                    Message.Write("Not Connected MongoDB!", ConsoleMessage.MessageType.ERROR);
                    MongoInıt_Pri = false;
                }
            }
            catch (Exception ex)
            {
                Message.Write(ex.Message.ToString(), ConsoleMessage.MessageType.ERROR);
            }
        }
        public mongodb(string Database , string Host)
        {
            try
            {
                monClient = new MongoClient(Host);
                monData = monClient.GetDatabase(Database);
                bool isMongoLive = monData.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);

                if (isMongoLive)
                {
                    Message.Write("Connected MongoDB!", ConsoleMessage.MessageType.SUCCESS);
                    MongoInıt_Pri = true;
                }
                else
                {
                    Message.Write("Not Connected MongoDB!", ConsoleMessage.MessageType.ERROR);
                    MongoInıt_Pri = false;
                }
            }
            catch (Exception ex)
            {
                Message.Write(ex.Message.ToString(), ConsoleMessage.MessageType.ERROR);
            }
        }
    }
}
