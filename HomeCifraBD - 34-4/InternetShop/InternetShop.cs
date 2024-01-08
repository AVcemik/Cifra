using InternetShop;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;



ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("ConnectionString.json");

var config = builder.Build();
string? connectionString = config.GetConnectionString("DefaultConnection");

DbContextOptionsBuilder<DatabaseContext> optionsBuilder = new();
MySqlServerVersion vers = new(new Version(8, 0, 25));


StreamWriter logError = WriterLog("error.log", LogLevel.Error);
StreamWriter logInfo = WriterLog("log.log", LogLevel.Information);
StreamWriter logDebug = WriterLog("debug.log", LogLevel.Debug); // Записываает только этот файл, так как он последний!!! не смог решить проблему что бы записываалось все


DbContextOptions<DatabaseContext> options = optionsBuilder.UseMySql(connectionString, vers).Options;


using (DatabaseContext context = new(options))
{

}

logError.Close();
logInfo.Close();
logDebug.Close();

StreamWriter WriterLog(string path, LogLevel level)
{
    StreamWriter writer = new(path, true);
    optionsBuilder.LogTo(writer.WriteLine, level);
    return writer;
}