using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ValueObjects;
namespace Domain.Entities
{
    public class Package
    {
        #region Properties
        public int ID { get; set; }
        public string Number { get; set; }
        public DateTime SendDate { get; set; }
        public Person Courier { get; set; }
        public Statuses Status { get; set; }
        public bool StickerPrinted { get; set; }
        #endregion

        #region PublicMethods

        #endregion
    }
}
