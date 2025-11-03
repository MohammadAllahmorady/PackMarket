using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackMarket.DataLayer.Entities.Entitieproduct
{
    public class PropertyName_Category
    {
        [Key]
        public int pcId { get; set; }

        public int PropertyNameId { get; set; }
        public int CategoryId { get; set; }

        #region Relation
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        [ForeignKey("PropertyNameId")]
        public PropertyName PropertyName { get; set; }
        #endregion
    }
}
