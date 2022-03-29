# 1 - Ajouter les packages Nugget dans le projet:
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

# 2 - Créer les Classes :
Student.cs

# 3 - Créer la Class DbContext pour EF :
EFCoreDemoContext.cs

# 4 - Dans appsettings.json :
Ajouter la connection string pour EF

# 5 - Ajouter le service pour EF dans le fichier :
Startup.cs

# 6 - Apres toute modification des classes
Add-Migration <Nom-Migration>

# 7 - Mettre à jour la base de donée
Update-Database