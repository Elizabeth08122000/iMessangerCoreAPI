using System;
using System.Collections.Generic;

namespace iMessangerCoreAPI.Models
{
    public class RGDialogsClients
    {
        public Guid IDUnique { get; set; }


        public Guid IDRGDialog { get; set; }
        public Guid IDClient { get; set; }
        public DateTime? DateEvent { get; set; }

    }
}
