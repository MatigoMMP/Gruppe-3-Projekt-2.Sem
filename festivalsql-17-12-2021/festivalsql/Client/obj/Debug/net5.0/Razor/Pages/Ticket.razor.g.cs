#pragma checksum "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/Pages/Ticket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ed712a4fb5ca7e1a60c5aa2f1cdac1ba951c1fa"
// <auto-generated/>
#pragma warning disable 1591
namespace festivalsql.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using festivalsql.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using festivalsql.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Npgsql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/billet")]
    public partial class Ticket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "billet_container");
            __builder.AddMarkupContent(2, "<div class=\"billet_header\"><div><h1> Partoutbillet </h1></div>\n        <div><h1> Endagsbillet </h1></div></div>\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "billet_body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "billet_partout");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/Pages/Ticket.razor"
                                              Partoutbillet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, " Partout ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "billet_endags");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/Pages/Ticket.razor"
                                             Endagsbillet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, " Endags ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    <div class=\"billet_footer\"></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "/Users/jisoo/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-17-12-2021/festivalsql/Client/Pages/Ticket.razor"
       

    private void Partoutbillet()
        {
            NavigationManager.NavigateTo("partoutbillet");
        }
    private void Endagsbillet()
        {
            NavigationManager.NavigateTo("endagsbillet");
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
