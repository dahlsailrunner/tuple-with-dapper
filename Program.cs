using Dapper;
using Microsoft.Data.Sqlite;

using var sqliteConn = new SqliteConnection("Data Source=tuple-sample.db");

var ids = sqliteConn.Query<int>("SELECT id FROM customer");
foreach (var id in ids)
{
    Console.WriteLine($"Found id {id} with Query<int>");
}
Console.WriteLine("---------------------");
var customers = sqliteConn.Query<(int Id, string Name, string FavoriteColor)>
            (@"SELECT id, 
                  customer_name, 
                  fav_color, 
                  create_date
             FROM customer").ToList();

var firstCustomerName = customers.First().Name;
Console.WriteLine($"First customer name is {firstCustomerName} " +
                        "with Query<(int, string, string)>");
Console.WriteLine("---------------------");
// the tuple can be deconstructed into its individual parts
foreach (var (id, name, color) in customers)
{
    Console.WriteLine($"Found customer {id} ({name}) [{color}] " +
            "with Query<(int, string, string)>");
}
Console.WriteLine("---------------------");
// or the tuple can be used as a whole
// this results in the same output as the foreach loop above
foreach (var tuple in customers)
{
    Console.WriteLine($"Found customer {tuple.Id} ({tuple.Name}) [{tuple.FavoriteColor}] " +
                        "with Query<(int, string, string)>");
}
