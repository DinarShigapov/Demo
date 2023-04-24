using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    public partial class Agent
    {
        public string FullName
        {
            get 
            {
                return $"{AgentType.Title} | {Title}";
            }
        }
    }
}
