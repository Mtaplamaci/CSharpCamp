using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelling.DataAccess.Abstract
{
    public interface IDal
    {
        
        void Add();
        void Delete();
        void Update();
    }
}
