# ProductProject
 Console .Net Core CodeFirst
 
 
1 Add Project<p>
2 Add Project Layers (Dal,Bll)<p>
3 Add EntityFramework All Layers<p>
4 Add Tables in Entity Layer<p>
5 Add DbContext in Dal<p>
6 Add SqlConnectionString in app.config.<p>
7 Add enable-migrations from dal layer in package console<p>
8 Add-migration migration1 in package manager console<p>
9-Set AutomaticMigrationsEnabled=True; and save.<p>
10-Add update-database in package console.<p>

Add Entity + DbContext in Dal and send update-database package console.<p>


11-Add IRepository interface in Dal/Abstract folder.<p>
12-Add Crud Methhods<p>
13-Add ICategoryDal inherit IRepository with Category Entitiy Class<p>
14- Add Repository class in root Dal Layer.<p>
15- Add Implement method for dbcontext on Object<p>
16-Add Managers class in Business Layer.<p>
17- Add CategoryManager and Repository from Dal.<p>
18- Added GetAll() method.<p>
19- Add The Business Layer which one layer need to List.<p>
20- Add Db insert for Category Table<p>
21- Add Find method IRepository   T Find(Expression<Func<T, bool>> where);<p>
22- Add Implement again repository Class.<p>
23- Add BllAdd method for add and delete. Now using Linq Expression.<p>
24- Add BllUpate method in category manager.<p>
25- Add List with parameter in category manager<p>
26- Implented Repository.class in Dal<p>
27- Add new search method GetbyName in Product Manager.<p>

