using System;

namespace HTShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }

        string CreatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        string UpdatedBy { get; set; }

        string MetaKeyword { get; set; }
        string MetaDescripstion { get; set; }

        bool Status { get; set; }
    }
}