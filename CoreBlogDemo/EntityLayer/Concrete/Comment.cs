using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommendID { get; set; }
        public string CommendUserName { get; set; }
        public string CommendContent { get; set; }
        public string CommendTitle { get; set; }
        public DateTime CommendDate { get; set; }
        public bool CommendStatus { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }

    }
}
