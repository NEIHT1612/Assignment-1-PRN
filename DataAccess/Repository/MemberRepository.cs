using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess;
namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memberID) => MemberDAO.Instance.Remove(memberID);

        public List<Member> GetMemberByCityAndCountry(string city, string country) => MemberDAO.Instance.SearchByCityAndCountry(city, country);

        public Member GetMemberByID(int memberID) => MemberDAO.Instance.GetMemberByID(memberID);

        public List<Member> GetMemberByIdAndName(int memberID, string name) => MemberDAO.Instance.SearchByIdAndName(memberID, name);

        public List<Member> GetMemberDescending() => MemberDAO.Instance.SortedMemberDescending();

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMember;

        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);

        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);

        public Member GetMemberByEmail(string email) => MemberDAO.Instance.GetMemberByEmail(email);
    }
}
