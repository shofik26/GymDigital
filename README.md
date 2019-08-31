# GymDigital (A GYM Management System)

### Project Initilize
Firstly clone "GymDigital" using this commend.
``` git clone https://github.com/shofik26/GymDigital.git ```

### Add migrations
``` 
 dotnet ef migrations add "IniialCreate" -o "Data/Migrations" --project src/Infrastructure --startup-project src/web
 ```


### Update Database

```
 dotnet ef database update --project src/Infrastructure --startup-project src/web 
```
