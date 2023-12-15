using StackExchange.Redis;
using System;
// Connection string to the Redis cache
string cacheConnection = "";
// Name of the Redis cache
//string cacheName = "";
// Key to read from the Redis cache
string cacheKey = "thename";
// Connect to the Redis cache
ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(cacheConnection);
// Get the Redis cache database
IDatabase cache = connection.GetDatabase();
// Read the value from the Redis cache
string cacheValue = cache.StringGet(cacheKey);
// Display the value read from the Redis cache
Console.WriteLine("Value read from Redis cache: " + cacheValue);