using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class RedisCacheService
    {
        private readonly IDatabase _database;

        public RedisCacheService(string connectionString)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(connectionString);
            _database = redis.GetDatabase();
        }

        public void Set<T>(string key, T value, TimeSpan? expiry = null)
        {
            var json = JsonSerializer.Serialize(value);
            _database.StringSet(key, json, expiry);
        }

        public T? Get<T>(string key)
        {
            var value = _database.StringGet(key);
            return value.HasValue ? JsonSerializer.Deserialize<T>(value) : default;
        }

        public void Remove(string key)
        {
            _database.KeyDelete(key);
        }
    }
}
