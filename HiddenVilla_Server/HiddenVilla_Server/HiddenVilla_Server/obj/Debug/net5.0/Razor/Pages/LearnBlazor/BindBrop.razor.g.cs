#pragma checksum "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "136bf0cee5bb5212f7888a3ca509ad9e0bfcef3c"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bindProp")]
    public partial class BindBrop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"bg-light border p-2\">\r\n    First Room\r\n</h2>\r\nRoom Name: ");
            __builder.AddContent(1, 
#nullable restore
#line 7 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
            Room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n<br>\r\nRoom Price: ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
             Room.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "number");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                                  Room.Price

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(8, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.Price = __value, Room.Price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "checkbox");
            __builder.AddAttribute(12, "checked", 
#nullable restore
#line 14 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                                                              Room.IsActive? "checked": null

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                                    Room.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Room.IsActive = __value, Room.IsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, " &nbsp; Is Active\r\n<br>\r\n");
            __builder.OpenElement(16, "span");
            __builder.AddContent(17, "This room is ");
            __builder.AddContent(18, 
#nullable restore
#line 16 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                     Room.IsActive?"Active":"Inactive"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n<br>\r\n");
            __builder.OpenElement(20, "select");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
               selectedRoomProp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedRoomProp = __value, selectedRoomProp));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 19 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
     foreach (var item in Room.RoomProps)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 21 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                        item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, 
#nullable restore
#line 21 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                                    item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "span");
            __builder.AddContent(28, "The selected room is: ");
            __builder.AddContent(29, 
#nullable restore
#line 24 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                             selectedRoomProp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.OpenElement(31, "div");
            __builder.AddMarkupContent(32, "<br>\r\n    ");
            __builder.AddMarkupContent(33, "<h2 class=\"text-info\">Room List in lavina hotel</h2>\r\n    ");
            __builder.OpenElement(34, "table");
            __builder.AddAttribute(35, "class", "table table-dark");
#nullable restore
#line 30 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
         foreach (var room in RoomList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "tr");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "text");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                                                room.RoomName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.RoomName = __value, room.RoomName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "td");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "text");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                                                room.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => room.Price = __value, room.Price));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
             foreach (var roomProp in room.RoomProps)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 37 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                     roomProp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(50, " - ");
            __builder.AddContent(51, 
#nullable restore
#line 37 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                                      roomProp.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
     foreach (var room in RoomList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "p");
            __builder.AddContent(53, 
#nullable restore
#line 44 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
            room.RoomName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(54, "\'s price is ");
            __builder.AddContent(55, 
#nullable restore
#line 44 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
                                      room.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\PhongNV\Desktop\HiddenVilla_Server\HiddenVilla_Server\HiddenVilla_Server\Pages\LearnBlazor\BindBrop.razor"
      
    string selectedRoomProp = "";

    List<BlazorRoom> RoomList = new List<BlazorRoom>();

    BlazorRoom Room = new BlazorRoom()
    {
        Id = 1,
        RoomName = "Lux",
        IsActive = true,
        Price = 1000,
        RoomProps = new List<BlazorRoomProp>
{
            new BlazorRoomProp{Id = 1, Name="Sq Ft", Value="330"},
            new BlazorRoomProp{Id = 2, Name="Occupancy", Value="4"},
        }
    };

    protected override void OnInitialized()
    {
        base.OnInitialized();

        RoomList.Add(new BlazorRoom()
        {
            Id = 201,
            RoomName = "Lux with one bed",
            IsActive = true,
            Price = 350,
            RoomProps = new List<BlazorRoomProp>
            {
                new BlazorRoomProp{Id = 1, Name="Sq Ft", Value="150"},
                new BlazorRoomProp{Id = 2, Name="Occupancy", Value="6"},
            }
        });

        RoomList.Add(new BlazorRoom()
        {
            Id = 202,
            RoomName = "Lux with two bed",
            IsActive = true,
            Price = 670,
            RoomProps = new List<BlazorRoomProp>
            {
                new BlazorRoomProp{Id = 1, Name="Sq Ft", Value="450"},
                new BlazorRoomProp{Id = 2, Name="Occupancy", Value="8"},
            }
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
