using MVCDemo.Models;
using System.Collections.Generic;

namespace MVCDemo.Repository
{
    public class PersonList
    {
        static List<PersonModel> people = new List<PersonModel>()
        {
               new PersonModel { First = "DAD", Last = "Nguyen", Name = "Study", About = "Study for test", Done = false, Id = 1 },
               new PersonModel { First = "David", Last = "Smith", Name = "Grocery", About = "Buy apple and bananana", Done = true , Id = 2},
               new PersonModel { First = "Tom", Last = "Davidson", Name = "Fix car", About = "Headlight and mirror is broken", Done = false, Id = 3 },
               new PersonModel { First = "Maddie", Last = "Madison", Name = "Job application", About = "Follow up on job interview ", Done = false , Id = 4}
        };

        public static List<PersonModel> SelectList()
        {
            return people;
        }

        public static void InserList(PersonModel per)
        {
            people.Add(per);
        }
        public static void UpdateList(PersonModel per)
        {
            PersonModel perUpdate = people.Find(x => x.Id == per.Id);
            perUpdate.Id = per.Id;
            perUpdate.First = per.First;
            perUpdate.Last = per.Last;
            perUpdate.Name = per.Name;
            perUpdate.About = per.About;
            perUpdate.Done = per.Done;
        }

        public static void DeleteList(int id)
        {
            PersonModel perDelete = people.Find(x => x.Id == id);
            people.Remove(perDelete);
        }

    }
}