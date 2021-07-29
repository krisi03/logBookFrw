using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***USER_TASK MODEL***/
  [Table("user_task")]
 public partial class User_Task : IMicron
 {
        [Primary]
        public Int32 id {get; set;}
        public String task_title {get; set;}
        public String task_description {get; set;}
        public String task_time {get; set;}
        public String task_date {get; set;}
        [Foreign(typeof(User_Info))]
        public Int32 user_id {get; set;}
 }
}
