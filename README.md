# HeroGame

###Little game to progress into ASP .NET Core 

### Requirements : 
- .NET Core 3.1 or higher
- SQLServer
- SQL Management Server 2017

##Install Steps

###1. You have to generate the project to install all NuGet to run the app or run the following command : 
```
Update-Package
```

###2. You have to install SQLServer.

###3. You have to install SQL Management Server 2017.

###4. Create your database.

###5. In appsettings.json you have to change parameter `Server` and `DataBase` to your own environnement.

###5.1 Right click on jeuhero.BackOffice.Web.UI project and click on `Manage secret user data` and change them for your own environnement. To connect with facebook.

###6. You have to run those command in the jeuhero.BackOffice.Web.UI project: 
``` 
   dotnet ef migrations add CreateIdentitySchema --context jeuherobackofficeWebUIContext
   dotnet ef database update --context jeuherobackofficeWebUIContext 
``` 

### WARNING

If dotnet ef is not recognized  run this command  : 
```
dotnet tool install --global dotnet -ef
```

###7. You have to run those command in the jeuhero.Core.Data project: 
``` 
   dotnet ef migrations add MigrationName
   dotnet ef database update
``` 


##BackOffice.Web.UI

I create a BackOffice to manage the content of the game

##jeuhero.Web.UI 

The plateforme to play to the game

