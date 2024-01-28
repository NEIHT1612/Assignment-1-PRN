using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }
        public frmMemberDetails(Member member)
        {
            InitializeComponent();
            txtMemberId.Text = member.MemberID.ToString();
            txtMemberName.Text = member.MemberName.ToString();
            txtEmail.Text = member.Email.ToString();
            txtPassword.Text = member.Password.ToString();
            txtCity.Text = member.City.ToString();
            txtCountry.Text = member.Country.ToString();
        }
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member MemberInfo { get; set; }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtMemberId.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtMemberId.Text = MemberInfo.MemberID.ToString();
                txtMemberName.Text = MemberInfo.MemberName.ToString();
                txtEmail.Text = MemberInfo.Email.ToString();
                txtPassword.Text = MemberInfo.Password.ToString();
                txtCity.Text = MemberInfo.City.ToString();
                txtCountry.Text = MemberInfo.Country.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Member = new Member
                {
                    MemberID = int.Parse(txtMemberId.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };

                if(InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(Member);
                    this.Hide();
                    frmMemberManagement frmMemberManagement = new frmMemberManagement();
                    frmMemberManagement.ShowDialog();

                }
                else
                {
                    MemberRepository.UpdateMember(Member);
                    this.Hide();
                    frmMemberManagement frmMemberManagement = new frmMemberManagement();
                    frmMemberManagement.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
