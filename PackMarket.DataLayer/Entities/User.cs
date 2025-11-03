using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackMarket.DataLayer.Entities.Entitieproduct;
using PackMarket.DataLayer.Entities.Entitieproduct.FaQ;

namespace PackMarket.DataLayer.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserAccount { get; set; }
        public string UserName { get; set; }
        public string UserFamily { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public DateTime CreateAccount { get; set; }

        #region Relation

        public List<Question> Questions { get; set; }
        public List<Comment> Comments { get; set; }

        #endregion
    }
}
