namespace EFCodeFirst.Entities
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UserDbContext : DbContext
    {
        // Your context has been configured to use a 'UserDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EFCodeFirst.Entities.UserDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'UserDbContext' 
        // connection string in the application configuration file.
        public UserDbContext()
            : base("name=UserDbContext")
        {
                                        
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Student> Students { get; set; }
         public virtual DbSet<Group> Groups { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}