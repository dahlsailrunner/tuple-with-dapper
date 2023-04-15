# Tuples with Dapper

This simple repo demonstrates how to use tuples
with Dapper to get strongly-typed output from a
query without needing to create a class / record
that exactly matches the output.

There is some simple prepared data in the SQLite
database that is in this project repo.

![data](data-in-sqlite.png)

The only code in the application is in `Program.cs`
and it is runnable by simply cloning the repo
and running it.  

The operative lines are the ones that use the `Query`
Dapper method, and the ones that read or iterate
the query results.
