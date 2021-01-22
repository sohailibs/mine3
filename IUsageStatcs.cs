using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UsageStatsApp.Models;

namespace UsageStatsApp
{
    public interface IUsageStatcs
    {
        Task<List<PackageInf>> GetUsagePackages();
        void UsageAccessPermission();
    }
}