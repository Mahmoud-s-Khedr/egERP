using Backend.Models;

namespace Backend.Functions;
public static class Checker
{
    public static bool loginCheck(string email,string password) {
        if(email == null || password == null || email == "" || password == "" || password.Length < 8 || 
          !email.Contains("@") || !email.Contains(".")) {
            return false;
        }

        return true;
    }

    public static bool UserCheck(User user) {
        if(user == null || user.IsActive == false) {
            return false;
        }
        return true;
    }
}