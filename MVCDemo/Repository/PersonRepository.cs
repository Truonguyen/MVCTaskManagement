using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo.Models;

namespace MVCDemo.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public void DeleteList(int id)
        {
            PersonList.DeleteList(id);
        }

        public void InsertList(PersonModel per)
        {
            PersonList.InserList(per);
        }

        public PersonModel SelectId(int id)
        {

            return PersonList.SelectList().Find(x => x.Id == id);
        }

        public List<PersonModel> SelectList()
        {
            return PersonList.SelectList();
        }

        public void UpdateList(PersonModel per)
        {
            PersonList.UpdateList(per);
        }
    }
}