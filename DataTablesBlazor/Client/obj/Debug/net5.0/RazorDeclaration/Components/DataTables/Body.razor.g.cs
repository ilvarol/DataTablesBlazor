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
    public partial class Body : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\Body.razor"
           

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        List<Column> ColumnList = new List<Column>();

        internal void Add(Column column)
        {
            ColumnList.Add(column);
            StateHasChanged();
        }

        //public override void OnClick(Title title)
        //{
        //    foreach (var item in List)
        //    {
        //        item.IsCurrent = item.Name == title.Name;
        //        item.SetOrderDirectionClass();
        //    }
        //}

        //After parameters are set, this method run
        //protected override async Task OnParametersSetAsync()
        //{
        //    foreach (var item in List)
        //    {
        //        item.SetOrderDirectionClass();
        //    }
        //}
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
