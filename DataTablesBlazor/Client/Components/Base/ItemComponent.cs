using System;
using Microsoft.AspNetCore.Components;

namespace DataTablesBlazor.Client.Components.Base
{
    public abstract class ItemComponent<T> : ComponentBase
    {
        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public string Class { get; set; }

        [Parameter]
        public bool IsCurrent { get; set; }

        [Parameter]
        public EventCallback<bool> IsCurrentChanged { get; set; }

        [Parameter]
        public EventCallback<string> NameChanged { get; set; }

        [Parameter]
        public EventCallback<string> ClassChanged { get; set; }

        [Parameter]
        public EventCallback<T> OnClick { get; set; }
    }
}
