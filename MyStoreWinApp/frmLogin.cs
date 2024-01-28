using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        
        MemberRepository memberRepository = new MemberRepository();
        
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            String password = txtPassword.Text;

            var Member = memberRepository.GetMembers().FirstOrDefault(x => x.Email == email && x.Password == password);
            if(Member != null)
            {
                if (Member.Email.Contains("admin@fstore.com") && Member.Password.Contains("admin@@"))
                {
                    frmMemberManagement frmMemberManagement = new frmMemberManagement();
                    frmMemberManagement.Show(); 
                }
                else
                {
                    frmMemberDetails frmMemberDetails = new frmMemberDetails(Member);
                    frmMemberDetails.Show();
                }
            }            
            else
            {
                MessageBox.Show("Wrong email or password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
