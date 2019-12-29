using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo.Models;

namespace MVCDemo.Repository
{
    public interface IPersonRepository
    {
        List<PersonModel> SelectList();
        PersonModel SelectId(int id);
        void InsertList(PersonModel per);
        void UpdateList(PersonModel per);
        void DeleteList(int id);
      
    }
}