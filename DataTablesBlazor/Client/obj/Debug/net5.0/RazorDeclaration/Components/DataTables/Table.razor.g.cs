// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DataTablesBlazor.Client.Components.DataTables
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using DataTablesBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using DataTablesBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using DataTablesBlazor.Client.Components.Base;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using DataTablesBlazor.Client.Components.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using DataTablesBlazor.Shared.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using DataTablesBlazor.Shared.Models.Mock;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    public partial class Table<Type> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\Table.razor"
       

    public DataTablesRequest DataTablesRequest { get; set; }
    public DataTablesResponse<Type> DataTablesResponse { get; set; }

    protected override async Task OnInitializedAsync()
    {
        DataTablesRequest = new DataTablesRequest() { Length = 10, SearchColumn = SearchColumn };
        DataTablesResponse = new DataTablesResponse<Type>() { RecordsTotal = 0 };

        foreach (var item in ColumnList)
        {
            item.SetOrderDirectionClass();
        }

        await Getitems();
    }

    [Parameter]
    public IList<Column> ColumnList { get; set; }

    [Parameter]
    public RenderFragment<Type> Body { get; set; }

    [Parameter]
    public string RequestUri { get; set; }

    [Parameter]
    public string SearchColumn { get; set; }


    private void LengthChanged(ChangeEventArgs e)
    {
        ResetDataTablesRequest();

        DataTablesRequest.Length = int.Parse(e.Value.ToString());

        RefreshData();
    }

    public void Enter(KeyboardEventArgs e)
    {
        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            ResetDataTablesRequest();

            RefreshData();
        }
    }

    public void ResetDataTablesRequest()
    {
        DataTablesRequest.Start = 0;

        DataTablesRequest.CurrentNumber = 1;
    }


    protected async Task Getitems()
    {
        var res = await Http.PostAsync(RequestUri,
            new StringContent(JsonSerializer.Serialize(DataTablesRequest),
            Encoding.UTF8, "application/json"));

        DataTablesResponse = JsonSerializer.Deserialize<DataTablesResponse<Type>>(await res.Content.ReadAsStringAsync());
    }

    public async Task RefreshData()
    {
        await Getitems();

        Refresh();
    }

    public void Refresh()
    {
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591