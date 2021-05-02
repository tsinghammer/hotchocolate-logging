using System;
using Microsoft.Extensions.Logging;

namespace LoggingDemo
{
    public class Query
    {
        private readonly ILogger<Query> _logger;

        public Query(ILogger<Query> logger)
        {
            _logger = logger;
        }

        public Book GetBook()
        {
            _logger.LogInformation("Query book");
            return new()
            {
                Title = "C# in depth.",
                Author = new Author
                {
                    Name = "Jon Skeet"
                }
            };
        }
    }
}
