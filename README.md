# ProductProject
 Console .Net Core CodeFirst
 
 
1 Add Project<p>
2 Add Project Layers (Dal,Bll)
3 Add EntityFramework All Layers
4 Add Tables in Entity Layer
5 Add DbContext in Dal
6 Add SqlConnectionString in app.config.
7 Add enable-migrations from dal layer in package console
8 Add-migration migration1 in package manager console
9-Set AutomaticMigrationsEnabled=True; and save.
10-Add update-database in package console.

Add Entity + DbContext in Dal and send update-database package console.

1 Add Project
2 Add Project Layers (Dal,Bll)
3 Add EntityFramework All Layers
4 Add Tables in Entity Layer
5 Add DbContext in Dal
6 Add SqlConnectionString in app.config.
7 Add enable-migrations from dal layer in package console
8 Add-migration migration1 in package manager console
9-Set AutomaticMigrationsEnabled=True; and save.
10-Add update-database in package console.


Update Revision 2

Add Entity + DbContext in Dal and send update-database package console.

11-Add IRepository interface in Dal/Abstract folder.
12-Add Crud Methhods
13-Add ICategoryDal inherit IRepository with Category Entitiy Class
14- Add Repository class in root Dal Layer.
15- Add Implement method for dbcontext on Object
16-Add Managers class in Business Layer.
17- Add CategoryManager and Repository from Dal.
18- Added GetAll() method.
19- Add The Business Layer which one layer need to List.
20- Add Db insert for Category Table
21- Add Find method IRepository   T Find(Expression<Func<T, bool>> where);
22- Add Implement again repository Class.
23- Add BllAdd method for add and delete. Now using Linq Expression.
24- Add BllUpate method in category manager.
25- Add List with parameter in category manager
26- Implented Repository.class in Dal
27- Add new search method GetbyName in Product Manager.

