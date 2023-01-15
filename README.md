# E-shop-IceSneakers
 ASP.NET Core reference web application, powered by Microsoft Visual Community.

pour pouvoir synchroniser la base de donnees avec microsoft visual, dans appsettings.json:

 - il faut changer les parametres sur ConnectionString comme suit:
 "ConnectionStrings": { "conn": "Data Source= (( server name ));Initial Catalog=snk_DB;Integrated Security=True" }
 
 - Acceder a Tools -> NuGet Packge Manager -> package manager console et ecrire: update-database
 
 
