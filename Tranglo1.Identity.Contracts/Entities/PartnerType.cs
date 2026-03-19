using System;
using System.Collections.Generic;
using System.Text;
using Tranglo1.Identity.Contracts.Common;

namespace Tranglo1.Identity.Contracts.Entities
{
    public class PartnerType : Enumeration
    {
        public PartnerType() : base()
        {

        }
        public PartnerType(int id, string name)
            : base(id, name)
        {

        }
        public static readonly PartnerType Sales_Partner = new PartnerType(1, "Sales Partner");
        public static readonly PartnerType Supply_Partner = new PartnerType(2, "Supply Partner");
    }
}
