using System.Collections.Generic;


namespace JobsDBTool.Models
{
    public partial class Account
    {
        [PetaPoco.Ignore]
        public Account_User AccountUser { get; set; }  //为了测试用

        [PetaPoco.Ignore]
        public List<Account_User> AccountUsers { get; set; }
    }
    public partial class Account_User
    {
        [PetaPoco.Ignore]
        public Account Account { get; set; }
    }

}
