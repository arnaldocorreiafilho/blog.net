using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
namespace Model
{
    [ActiveRecord("Post")]
    public class Post:ActiveRecordBase<Post>
    {
        [PrimaryKey]
        public int Id { get; set; }
        [Property]
        public string nome { get; set; }
    }
}
