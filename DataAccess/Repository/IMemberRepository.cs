using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int memberID);
        void InsertMember(Member member);
        void DeleteMember(int memberID);
        void UpdateMember(Member member);
        List<Member> GetMemberByName(string name);
        List<Member> GetMemberByCityAndCountry(string city, string country);
        List<Member> GetMemberDescending();
        Member GetMemberByEmail(string email);

    }
}
