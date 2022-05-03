using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaCacheRedis
{
    public static class CacheRedisMultiplexer
    {
        private static Lazy<ConnectionMultiplexer> CrearConexion =
            new Lazy<ConnectionMultiplexer>(() => {
                return ConnectionMultiplexer.Connect(
                    "cacheredistajamarrc.redis.cache.windows.net:6380," +
                    "password=TN4qnd0XyC9BoY2uC5KSY1w2IBTlerBCYdbVLYP63Gk=," +
                    "ssl=True,abortConnect=False");
            });

        public static ConnectionMultiplexer Connection
        {
            get { return CrearConexion.Value; }
        }

    }
}
