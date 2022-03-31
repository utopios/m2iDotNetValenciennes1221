# 1 - Installer les packages nuggets
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

# 2 - Mettre la connection string de la BDD dans appsettings.json
"ConnectionStrings": {
    "EFCoreDataBaseFirstContextConnection": "Data Source=(localdb)\\EntityDataBaseFirst;Integrated Security=True"
  }
# 3 - Générer les classes depuis la BDD => saisir instarcution dans le gestionnaire de packages nuggets
Scaffold-DbContext Name="EFCoreDataBaseFirstContextConnection" Microsoft.EntityFrameworkCore.SqlServer -outputDir Models

# 4 - Créer les controleurs & vues depuis nos models et note DBcontext
