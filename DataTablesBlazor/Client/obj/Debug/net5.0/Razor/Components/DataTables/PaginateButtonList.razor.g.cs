#pragma checksum "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d4d92884079f9bbdd34b4187934447c0e123e80"
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
    public partial class PaginateButtonList<Type> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dataTables_info");
            __builder.AddAttribute(2, "id", "example_info");
            __builder.AddAttribute(3, "role", "status");
            __builder.AddAttribute(4, "aria-live", "polite");
            __builder.AddMarkupContent(5, "\r\n    Showing ");
            __builder.AddContent(6, 
#nullable restore
#line 4 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
             From

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " to ");
            __builder.AddContent(8, 
#nullable restore
#line 4 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
                      To

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " of ");
            __builder.AddContent(10, 
#nullable restore
#line 4 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
                             DataTablesResponse.RecordsFiltered

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, " entries\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "dataTables_paginate paging_simple_numbers");
            __builder.AddAttribute(15, "id", "example_paginate");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "class", "paginate_button" + " previous" + " " + (
#nullable restore
#line 7 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
                                        _disabledPrevious

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
                                                                     PreviousClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "aria-controls", "example");
            __builder.AddAttribute(20, "data-dt-idx", "0");
            __builder.AddAttribute(21, "tabindex", "-1");
            __builder.AddAttribute(22, "id", "example_previous");
            __builder.AddContent(23, "Previous");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "span");
#nullable restore
#line 10 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
         if (List != null)
        {
            foreach (var item in List)
            {
                var index = List.IndexOf(item);

                if (index > 0 && index <= List.Count - 1)
                {
                    var precedingItem = List[index - 1];

                    if (item.Number - 1 != precedingItem.Number)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<span class=\"ellipsis\">…</span>");
#nullable restore
#line 23 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
                    }
                }


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<DataTablesBlazor.Client.Components.DataTables.PaginateButton>(27);
            __builder.AddAttribute(28, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<DataTablesBlazor.Client.Components.DataTables.PaginateButton>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DataTablesBlazor.Client.Components.DataTables.PaginateButton>(this, 
#nullable restore
#line 26 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
                                                                                                                              OnClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(29, "Number", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
                                              item.Number

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "NumberChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.Number = __value, item.Number))));
            __builder.AddAttribute(31, "Class", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
                                                                        item.Class

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "ClassChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.Class = __value, item.Class))));
            __builder.AddAttribute(33, "IsCurrent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
                                                                                                     item.IsCurrent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "IsCurrentChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.IsCurrent = __value, item.IsCurrent))));
            __builder.CloseComponent();
#nullable restore
#line 27 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "paginate_button" + " next" + " " + (
#nullable restore
#line 31 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
                                    _disabledNext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
                                                             NextClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "aria-controls", "example");
            __builder.AddAttribute(40, "data-dt-idx", "7");
            __builder.AddAttribute(41, "tabindex", "0");
            __builder.AddAttribute(42, "id", "example_next");
            __builder.AddContent(43, "Next");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\ilyas.varol\source\repos\DataTablesBlazor\DataTablesBlazor\Client\Components\DataTables\PaginateButtonList.razor"
       

    private string _disabledNext = "", _disabledPrevious = "";
    private int _maxnumber;

    private IList<PaginateButton> List { get; set; }

    protected override Task OnInitializedAsync()
    {
        DataTablesRequest.CurrentNumber = 1;

        RefreshList(true);

        return base.OnInitializedAsync();
    }

    [CascadingParameter]
    private Table<Type> Parent { get; set; }

    [Parameter]
    public DataTablesRequest DataTablesRequest { get; set; }

    [Parameter]
    public DataTablesResponse<Type> DataTablesResponse { get; set; }


    [Parameter]
    public EventCallback<DataTablesRequest> DataTablesRequestChanged { get; set; }

    [Parameter]
    public EventCallback<DataTablesResponse<Type>> DataTablesResponseChanged { get; set; }


    private int From
    {
        get
        {
            return DataTablesRequest.CurrentNumber * DataTablesRequest.Length - DataTablesRequest.Length + 1;
        }
    }

    private int To
    {
        get
        {
            return DataTablesRequest.CurrentNumber * DataTablesRequest.Length;
        }
    }


    public void OnClick(PaginateButton ClickedButton)
    {
        DataTablesRequest.CurrentNumber = ClickedButton.Number;

        RefreshList(true);
    }

    public void PreviousClick()
    {
        if (DataTablesRequest.CurrentNumber > 1)
            DataTablesRequest.CurrentNumber -= 1;

        RefreshList(true);
    }

    public void NextClick()
    {
        if (DataTablesRequest.CurrentNumber < _maxnumber)
            DataTablesRequest.CurrentNumber += 1;

        RefreshList(true);
    }


    public void RefreshList(bool refresh = false)
    {
        int pageCount = (int)Math.Ceiling((double)DataTablesResponse.RecordsFiltered / (double)DataTablesRequest.Length);

        _maxnumber = pageCount;

        List = new List<PaginateButton>();

        List.Add(new PaginateButton() { Number = 1 });

        var startingIndex = 2;

        if (pageCount >= 2)
        {
            if (DataTablesRequest.CurrentNumber - 1 <= 3)
            {
                List.Add(new PaginateButton() { Number = 2 });

                startingIndex = 3;
            }
            else
            {
                startingIndex = DataTablesRequest.CurrentNumber - 1;
            }

            int i = 0;

            if (pageCount > 5 && pageCount - DataTablesRequest.CurrentNumber <= 3)
            {
                i -= 3;
                startingIndex = pageCount - 4;
            }

            for (; startingIndex < pageCount; startingIndex++)
            {
                List.Add(new PaginateButton() { Number = startingIndex });

                if (++i == 3) break;
            }

            if (pageCount > 2)
                List.Add(new PaginateButton() { Number = pageCount });
        }

        List = List.OrderBy(o => o.Number).ToList();

        if (DataTablesRequest.CurrentNumber == pageCount) _disabledNext = "disabled"; else _disabledNext = "";
        if (DataTablesRequest.CurrentNumber == 1) _disabledPrevious = "disabled"; else _disabledPrevious = "";

        foreach (var item in List)
        {
            item.IsCurrent = item.Number == DataTablesRequest.CurrentNumber;
            item.SetCurrentClass();
        }

        if (refresh)
        {
            DataTablesRequest.Start = From - 1;

            Parent.RefreshData();
        }
    }

    protected override Task OnParametersSetAsync()
    {
        RefreshList();

        return base.OnParametersSetAsync();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
