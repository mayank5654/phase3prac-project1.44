namespace UsersLoginLib
{
    public class UserLogin
    {
        public string Login(string userName, string userPwd)
        {
            string result = "";
            if (userName == "mayank" && userPwd == "mayank@123")
            {
                result = "Login success";
            }
            else
            {
                result = "Login Failed";
            }
            return result;
        }
    }
}
