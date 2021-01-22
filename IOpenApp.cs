using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UsageStatsApp
{
    public interface IOpenApp
    {
        Task<bool> LaunchApp(string uri);
    }
}
