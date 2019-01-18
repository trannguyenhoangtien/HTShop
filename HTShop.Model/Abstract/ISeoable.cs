using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTShop.Model.Abstract
{
    public interface ISeoable
    {
        string MetaKeyword { get; set; }
        string MetaDescripstion { get; set; }
    }
}
