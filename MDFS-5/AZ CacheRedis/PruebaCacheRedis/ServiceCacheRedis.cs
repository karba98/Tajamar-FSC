
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCacheRedis
{
    public class ServiceCacheRedis
    {
        private IDatabase cacheRedis;
        public ServiceCacheRedis()
        {
            this.cacheRedis = CacheRedisMultiplexer.Connection.GetDatabase();
        }
        public List<Producto> GetProductos()
        {
            String json = cacheRedis.StringGet("favoritos");
            if(json != null)
            {
                List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(json);
                return productos;
            }
            else
            {
                return null;
            }
        }
        
    }
}
