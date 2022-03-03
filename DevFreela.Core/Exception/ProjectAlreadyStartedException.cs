using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Exception
{
    public class ProjectAlreadyStartedException: IOException
    {
        public ProjectAlreadyStartedException(): base("Project is already in Started status")
        {             
        }
    }
}
