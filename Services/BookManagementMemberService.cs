using Repositories.Entities;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookManagementMemberService
    {

     
        public BookManagementMember? CheckLogin(string email, string password)
        {
            BookMemberRepo repo = new BookMemberRepo();

            BookManagementMember account = repo.Get(email);

            //if (account == null)
            //    return null; //email ko tồn tai
            //if (account.Password == password)
            //    return account;
            //return null;

            return account != null && account.Password == password ? account : null;
        } 

    }
}
