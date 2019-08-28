# GymDigital
 - A GYM Management System


### Add migrations
``` 
 dotnet ef migrations add "IniialCreate" -o "Data/Migrations" --project src/Infrastructure --startup-project src/web
 ```


### Update Database

```
 dotnet ef database update --project src/Infrastructure --startup-project src/web 
```
