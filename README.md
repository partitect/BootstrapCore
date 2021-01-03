# BootstrapCore
![alt text](https://raw.githubusercontent.com/partitect/BootstrapCore/master/BootstrapCore/wwwroot/assets/img/Bootstrap-Core-Project.png)


# Local Sql Connection

scaffold-dbcontext "Data Source=(localdb)\mssqllocaldb;Initial Catalog=dbase;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -outputdir Models

# Add Table Update Connection
scaffold-dbcontext "Data Source=(localdb)\mssqllocaldb;Initial Catalog=dbase;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -outputdir Models -force
