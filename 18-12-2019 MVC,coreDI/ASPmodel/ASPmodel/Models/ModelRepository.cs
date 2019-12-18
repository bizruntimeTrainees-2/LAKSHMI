using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPmodel.Models
{
    public interface ModelRepository
    {
        Models GetModels(int id);

    }
}
