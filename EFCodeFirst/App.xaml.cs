using EFCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EFCodeFirst
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private App()
        {
            using(UserDbContext db=new UserDbContext())
            {
                Group group = new Group()
                {
                      GroupName="BestGroup"
                };
                Student student = new Student()
                {
                     GroupId=1,
                      Name="Elvin",
                       Surname="Camalzade"
                };

                db.Groups.Add(group);
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
}
