using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesBlazor.Shared.Models.DataTables
{
    public class DataTablesResponse<Type>
    {
        public int RecordsTotal { get; set; }

        public int RecordsFiltered { get; set; }

        public IList<Type> Data { get; set; }
    }
}
