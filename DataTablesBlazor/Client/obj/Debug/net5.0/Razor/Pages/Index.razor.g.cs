#pragma checksum "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcff7493701efc52a1cf13f9a162f79720c5b81e"
// <auto-generated/>
#pragma warning disable 1591
namespace DataTablesBlazor.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DataTablesBlazor.Client.Components.DataTables.Table<Mock>>(0);
            __builder.AddAttribute(1, "RequestUri", "Mock");
            __builder.AddAttribute(2, "ColumnList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IList<DataTablesBlazor.Client.Components.DataTables.Column>>(
#nullable restore
#line 3 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Pages\Index.razor"
                                                 ColumnList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "SearchColumn", "Name");
            __builder.AddAttribute(4, "Body", (Microsoft.AspNetCore.Components.RenderFragment<Mock>)((item) => (__builder2) => {
                __builder2.OpenElement(5, "tr");
                __builder2.OpenElement(6, "td");
                __builder2.AddContent(7, 
#nullable restore
#line 6 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Pages\Index.razor"
                 item.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenElement(9, "td");
                __builder2.AddContent(10, 
#nullable restore
#line 7 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Pages\Index.razor"
                 item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, 
#nullable restore
#line 8 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Pages\Index.razor"
                 item.Surname

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 9 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Pages\Index.razor"
                 item.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenElement(18, "td");
                __builder2.AddContent(19, 
#nullable restore
#line 10 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Pages\Index.razor"
                 item.Gender

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Pages\Index.razor"
      

    List<Column> ColumnList = new List<Column>()
    {
        new Column() { Name= "Id", IsCurrent = true},
        new Column() { Name= "Name"},
        new Column() { Name= "Surname"},
        new Column() { Name= "Email"},
        new Column() { Name= "Gender"}
    };


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
