using Ems.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ems.Data.Models.Domain;
using System.Data;

namespace Ems.Data.Repository
{
    public class ReportsRepository : IReportRepository
    {
        private readonly ISqlDataAccess _db;

        public ReportsRepository(ISqlDataAccess db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Reports>>GetReportAsync()
        {
            var result = await _db.GetData<Reports, dynamic>("spEmsReports", new {});
            return result;
        }
    }
}
