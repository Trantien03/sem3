using System;
namespace t2210m.Models
{
    public class UserRegisterModel
    {
        //private string email; // attribute

       // public string Email // property
       // {
       //     get => email;
       //     set => email = value;
       // }
        public int Id { get; set; } // abstract property
        public String Email { get; set; }
        public String FullName { get; set; }
        public String Telephone { get; set; }
    }
}
