using MVCCacheRedis.Helpers;
using MVCCacheRedis.Models;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCacheRedis.Services
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
        public void AlmacenarProducto(Producto producto)
        {
            String json = cacheRedis.StringGet("favoritos");
            List<Producto> productos;
            if (json == null)
            {
                productos = new List<Producto>();
            }
            else
            {
                productos = JsonConvert.DeserializeObject<List<Producto>>(json);
            }
            productos.Add(producto);
            json = JsonConvert.SerializeObject(productos);
            cacheRedis.StringSet("favoritos", json, TimeSpan.FromMinutes(15));

        }
        public void EliminarProducto(String id)
        {
            String json = cacheRedis.StringGet("favoritos");
            List<Producto> productos;

            if(json!=null)
            {
                productos = JsonConvert.DeserializeObject<List<Producto>>(json);
                Producto prod = productos.SingleOrDefault(x => x.Id == id);
                productos.Remove(prod);
                if(productos.Count == 0)
                {
                    cacheRedis.KeyDelete("favoritos");
                }
                else
                {
                    json = JsonConvert.SerializeObject(productos);
                    cacheRedis.StringSet("favoritos", json, TimeSpan.FromMinutes(15));

                }
            }
            
            
        }
        public void DeleteProductos()
        {
            cacheRedis.KeyDelete("favoritos");
        }
    }
}
