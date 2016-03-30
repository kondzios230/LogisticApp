using System;

namespace Logistics.Domain.Aggregates.Package
{
    public class Package
    {
        #region Properties
        public int ID { get; set; }
        public string Number { get; set; }
        public DateTime SendDate { get; set; }
        public Courier Courier { get; set; }
        public Statuses Status { get; set; }
        public bool StickerPrinted { get; set; }
        #endregion

        #region PublicMethods

        #endregion
    }
}
