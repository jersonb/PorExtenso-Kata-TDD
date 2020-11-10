using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class DatabaseService
    {
        private readonly IMongoCollection<Consulta> _collection;

        public DatabaseService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<Consulta>(settings.CollectionName);
        }

        public List<Consulta> Get() 
            => _collection.Find<Consulta>(consulta => string.IsNullOrEmpty(consulta.Id)).ToList();

        public Consulta Get(string id) 
            => _collection.Find(consulta => consulta.Id == id).FirstOrDefault();

        public Consulta Create(Consulta consulta)
        {
            try
            {
                _collection.InsertOne(consulta);
                return consulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(string id, Consulta consulta) =>
            _collection.ReplaceOne(book => book.Id == id, consulta);

        public void Remove(Consulta consulta) =>
            _collection.DeleteOne(c => c.Id == consulta.Id);

        public void Remove(string id) =>
            _collection.DeleteOne(consulta => consulta.Id == id);
    }
}