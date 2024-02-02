using BusinessObject;
using System.Linq.Expressions;
namespace DataAccess
{
    public class MemberDAO
    {
        //Initialize member list
        private static List<Member> MemberList = new List<Member>()
        {
            new Member{ MemberID = 1, MemberName = "NEIHT", Email = "admin@fstore.com",
                        Password = "admin@@", City = "Ha Noi", Country = "Viet Nam"},
            new Member{ MemberID = 2, MemberName = "Thien", Email = "a@gmail.com",
                        Password = "123", City = "Ha Noi", Country = "Viet Nam"},
            new Member{ MemberID = 3, MemberName = "Quang", Email = "b@gmail.com",
                        Password = "123456", City = "Hue", Country = "Viet Nam"},
            new Member{ MemberID = 4, MemberName = "Minh", Email = "c@gmail.com",
                        Password = "1234", City = "Vinh", Country = "Viet Nam"}
        };

        //Using Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Member> GetMember => MemberList;
        public Member GetMemberByID(int MemberID)
        {
            //using LINQ to Object
            Member member = MemberList.SingleOrDefault(pro => pro.MemberID == MemberID);
            return member;
        }
        public Member GetMemberByEmail(string Email) 
        {
            Member member = MemberList.SingleOrDefault(pro => pro.Email == Email);
            return member;
        }
        //Add new a member
        public void AddNew(Member member)
        {
            Member pro = GetMemberByID(member.MemberID);
            if(pro == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Member is already exists.");
            }
        }
        //Update a member
        public void Update(Member member)
        {
            Member m = GetMemberByID(member.MemberID);
            if(m != null)
            {
                var index = MemberList.IndexOf(m);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        //Remove a member
        public void Remove(int MemberID)
        {
            Member p = GetMemberByID(MemberID);
            if(p != null)
            {
                MemberList.Remove(p);
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }

        public List<Member> SearchByName(string MemberName)
        {
            List<Member> Lmember = MemberList.Where(m => m.MemberName.Contains(MemberName, StringComparison.OrdinalIgnoreCase)).ToList();
            return Lmember;
        }
    
        public List<Member> SearchByCityAndCountry(string City, string Country)
        {
            List<Member> Lmember = MemberList.Where(m => m.City.Contains(City, StringComparison.OrdinalIgnoreCase) ||
                                                         m.Country.Contains(Country, StringComparison.OrdinalIgnoreCase)).ToList();
            return Lmember;
        }
        public List<Member> SortedMemberDescending()
        {
            List<Member> Lmember = MemberList.OrderByDescending(m => m.MemberName).ToList();
            return Lmember;
        }
    }
}
