using Micron;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Models
{

#region USER_INFO
 public partial class User_Info
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region USER_TASK
 public partial class User_Task
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion

}
