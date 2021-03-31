using System;

namespace DataTablesBlazor.Shared.Models.DataTables
{
    public class DataTablesRequest
    {
        public int Start { get; set; }

        public int Length { get; set; }

        public string OrderColumn { get; set; }

        public string OrderDirection { get; set; }

        public string Search { get; set; }

        public string SearchColumn { get; set; }

        public int CurrentNumber { get; set; }
    }
}
