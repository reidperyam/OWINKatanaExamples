using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigKatana.Model
{
    public interface IBugsRepository
    {
        IEnumerable<Bug> GetBugs();
    }
}
