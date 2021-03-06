#pragma checksum "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c571939d31e2e0428389cb9dfb8159621f587aa2"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class PaginateButton : ItemComponent<PaginateButton>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddMultipleAttributes(1, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 3 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButton.razor"
                InputAttributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 3 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButton.razor"
                                         Class

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButton.razor"
                                                          (()=>OnClick.InvokeAsync(this))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, 
#nullable restore
#line 3 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButton.razor"
                                                                                            Number

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButton.razor"
       

    private readonly string _paginate_button = "paginate_button";
    private readonly string _current = "current";

    [Parameter]
    public int Number { get; set; }

    [Parameter]
    public EventCallback<int> NumberChanged { get; set; }

    public void SetCurrentClass()
    {
        Class = IsCurrent ? $"{_paginate_button} {_current}" : _paginate_button;
    }

    private Dictionary<string, object> InputAttributes { get; set; } = new Dictionary<string, object>()
    {
        { "aria-controls", "example" },
        { "data-dt-idx", "2" },
        { "tabindex", "0" },
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
