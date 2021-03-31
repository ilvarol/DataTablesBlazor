using System;
using DataTablesBlazor.Shared.Models.Mock;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;
using DataTablesBlazor.Shared.Models.DataTables;
using System.Linq;
using System.Reflection;

namespace DataTablesBlazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MockController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetList(DataTablesRequest dataTablesRequest)
        {
            var path = $"{AppDomain.CurrentDomain.BaseDirectory}/Data/Mock.json";
            var jsonString = System.IO.File.ReadAllText(path);
            var mockDataList = JsonSerializer.Deserialize<List<Mock>>(jsonString);
            var query = mockDataList.AsQueryable();

            //getting count info
            var total = query.Count();

            query = query.Contains(dataTablesRequest.SearchColumn, dataTablesRequest.Search);

            var filteredTotal = query.Count();

            query = query.OrderBy(dataTablesRequest.OrderColumn, dataTablesRequest.OrderDirection);
            query = query.Skip(dataTablesRequest.Start).Take(dataTablesRequest.Length);

            mockDataList = query.ToList();

            DataTablesResponse<Mock> result = new DataTablesResponse<Mock>()
            {
                Data = mockDataList,
                RecordsTotal = total,
                RecordsFiltered = !String.IsNullOrEmpty(dataTablesRequest.Search) ? filteredTotal : total,
            };

            return Ok(result);
        }
    }
}
