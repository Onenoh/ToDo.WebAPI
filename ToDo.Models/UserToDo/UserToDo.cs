using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Models.UserToDo
{
    public class UserToDo : UserToDoCreate
    {
        public int ApplicationUserId { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime UpdateDate { get; set; }
       
    }
}
