#pragma checksum "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bb453c84955b7638a0c9f944ec8601ea5643d71"
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
#line 1 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using festivalsql.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using festivalsql.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Npgsql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "body_container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "body_text");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "body_button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/Index.razor"
                                                                  Billet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "<span>MILJØ 2022 </span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "body_text");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "body_button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/Index.razor"
                                                                  Artister

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "<span>Artister </span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "body_text");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "body_button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/Index.razor"
                                                                  Mad

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(21, "<span>Mad </span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "body_text");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "body_button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/Index.razor"
                                                                  Frivillig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "<span>Frivillig </span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "body_text");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "body_button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/Index.razor"
                                                                  Overnatning

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "<span>Overnatning </span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "body_text");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "body_button");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/Index.razor"
                                                                  Om_os

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "<span>Om Miljø fest </span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/Users/victorpascale/Documents/GitHub/Gruppe-3-Projekt-2.Sem/festivalsql-15-12-2021/festivalsql/Client/Pages/Index.razor"
       

    private void Billet()
    {
        NavigationManager.NavigateTo("billet");
    }
    private void Artister()
    {
        NavigationManager.NavigateTo("artister");
    }
    private void Mad()
    {
        NavigationManager.NavigateTo("mad");
    }
    private void Frivillig()
    {
        NavigationManager.NavigateTo("frivillig");
    }
    private void Overnatning()
    {
        NavigationManager.NavigateTo("overnatning");
    }
    private void Om_os()
    {
        NavigationManager.NavigateTo("omOs");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime IJRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
