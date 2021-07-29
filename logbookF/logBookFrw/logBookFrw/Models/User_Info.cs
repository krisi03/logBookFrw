using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***USER_INFO MODEL***/
  [Table("user_info")]
 public partial class User_Info : IMicron
 {
        [Primary]
        public Int32 id {get; set;}
        public String first_name {get; set;}
        public String last_name {get; set;}
        public String company_name {get; set;}
        public String phone_number {get; set;}
        public String username {get; set;}
        public String email {get; set;}
        public String password_u {get; set;}
 }
}
