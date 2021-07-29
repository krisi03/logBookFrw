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

   public bool HasUser_Task(string where="true") {return DefaultDBContext.GetRecords<User_Task>("user_id = "+this.id+" AND "+where+" LIMIT 1").Count()>0;}
   public IEnumerable<User_Task> GetUser_Task(string where="true") {return DefaultDBContext.GetRecords<User_Task>("user_id = "+this.id+" AND "+where);}
    public void AddUser_Task(User_Task model) { model.SetUser_Info(this); }
    public void AddUser_Task(IEnumerable<User_Task> models) {foreach(var model in models) model.SetUser_Info(this); }

 }
#endregion
#region USER_TASK
 public partial class User_Task
 {
public MicronDbContext DefaultDBContext { get; set; }
  public  User_Info GetUser_Info() { return DefaultDBContext.GetRecord<User_Info>(this.user_id); }
   public void SetUser_Info(User_Info model)  {  DefaultDBContext.SetRelation(this, model);}


 }
#endregion

}
