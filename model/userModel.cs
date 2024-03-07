
using Microsoft.AspNetCore.Identity;

namespace auth_102.models;

public class ApplicationUser : IdentityUser
{
    public string u_Roles { get; set; }
    public string Fullname { get; set; }

    // public string usename { get; set; }
    // public string Password { get; set; }
}


public class RegisterModel 
{
    public string u_Roles { get; set; }
    public string Fullname { get; set; }

    public string usename { get; set; }
    public string Password { get; set; }
}