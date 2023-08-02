## ToDo

### Backend

- [x] Paging, Sorting and Filtering

### Frontend

- [ ] Logs
- [ ] Routing
- [ ] Login

## Requirements

- donet-ef is installed `dotnet tool install --global dotnet-ef --version 7.0.9`
- SQLite and SQL Server Compact Toolbox (https://marketplace.visualstudio.com/items?itemName=ErikEJ.SQLServerCompactSQLiteToolbox) have been installed. This is used to query the SQLite database.

## Database

### Add migrations

```
dotnet ef migrations add <MigrationName> -s API -p Persistence
```

### Update database

The database is updated after every startup because of `await context.Database.MigrateAsync();` in Program.cs.

Use following command to update it manually.

```
dotnet ef database update -s API -p Persistence
```

## Visual Studio Configuration

### Use underscore for private fields

- Tools > Options > Text Editor > C# > Code Style > Naming
- https://ardalis.com/configure-visual-studio-to-name-private-fields-with-underscore/

## Architecture

- Clean architecture
- CQRS + Mediator pattern (https://code-maze.com/cqrs-mediatr-in-aspnet-core/)