using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject.Model
{
    public class MemberRegister
    {
        private List<Member> _members = new List<Member>() { };

        public MemberRegister()
        {
            var member = new Member() { Username = "user", Password = "userPassword" };
            _members.Add(member);
        }
        
        public Member Find(string user, string password)
        {
            return _members.FirstOrDefault(member => member.Username.Equals(user) && member.Password.Equals(password));
        }

        public Member Find(string memberName)
        {
            return _members.FirstOrDefault(member => member.Username.Equals(memberName));
        }

        public void Add(Member member)
        {
            _members.Add(member);
        }
    }
}
