using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class PersonProcessor
    {
        public static int CreatePerson(int personId, string firstName, string lastName, string email)
        {
            PersonModel data = new PersonModel
            {
                PersonId = personId,
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            string sql = @"insert into dbo.Person (PersonId, FirstName, LastName, Email) values (@PersonId, @FirstName, @LastName, @Email);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static int EditPerson(int personId, string firstName, string lastName, string email, int id)
        {
            PersonModel data = new PersonModel
            {
                Id = id,
                PersonId = personId,
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            string sql = @"update dbo.Person set PersonId = @PersonId, FirstName = @FirstName, LastName = @LastName, Email = @Email where Id = @Id;";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static int DeletePerson(int id)
        {
            PersonModel data = new PersonModel
            {
                Id = id
            };

            string sql = @"delete from dbo.Person where Id = @Id;";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<PersonModel> LoadPeople()
        {
            string sql = @"select * from dbo.Person;";
            return SqlDataAccess.LoadData<PersonModel>(sql);
        }
    }
}
