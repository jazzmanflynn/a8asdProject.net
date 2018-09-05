using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject.Model
{
    public class Library
    {
        public Library()
        {
            MemberRegister = new MemberRegister();
        }

        public bool IsMemberLoggedIn { get; set; }
        public MemberRegister MemberRegister { get; set; }
        public Member CurrentUser { get; set; }

        public void Login()
        {
            var member = MemberRegister.Find(CurrentUser.Username, CurrentUser.Password);
            IsMemberLoggedIn = member != null;
        }
    }
}
