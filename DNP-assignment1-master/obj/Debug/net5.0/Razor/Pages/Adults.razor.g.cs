#pragma checksum "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0643a7b4005de6f41b30bc8211af66f17e2d6558"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
using Assignment1.Persistance;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "style", "font-size:30px");
            __builder.AddContent(3, "    Filter by first or last name: ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                                                     arg => FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:250px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    Filter by hair color: ");
            __builder.OpenElement(8, "select");
            __builder.AddAttribute(9, "name", "hairColors");
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                                                                arg => FilterByHairColor(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(11, "option");
            __builder.AddContent(12, "All");
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
         foreach (string color in FileAdapter.GetHairColors())
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "option");
            __builder.AddContent(14, 
#nullable restore
#line 16 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                     color

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n    <br>\n    ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-outline-warning btn-lg btn-block");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                                                                       NavigateToAddAdult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Add adult");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
 if (toShowAdults == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<p><em>Loading...</em></p>");
#nullable restore
#line 27 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
    }
    else if (!toShowAdults.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<p><em>No Adults items exist. Please add some.</em></p>");
#nullable restore
#line 33 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "id", "adultsTable");
            __builder.AddAttribute(24, "class", "table table-hover");
            __builder.AddMarkupContent(25, @"<thead class=""thead-light""><tr><th>Adult ID</th>
                <th>Name</th>
                <th>Age</th>
                <th>Sex</th>
                <th>Job title</th>
                <th>Salary</th>
                <th>Hair color</th>
                <th>Eye color</th>
                <th>Weight</th>
                <th>Height</th>
                <th>Remove</th>
                <th>Update</th></tr></thead>
            ");
            __builder.OpenElement(26, "tbody");
#nullable restore
#line 54 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
             foreach (var adult in toShowAdults)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 57 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                         adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 58 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                         adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, " ");
            __builder.AddContent(34, 
#nullable restore
#line 58 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                                               adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 59 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                         adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 60 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                         adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 61 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                         adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 62 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                         adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 63 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                         adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n                    ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 64 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                         adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 65 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                         adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n                    ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 66 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                         adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n                    ");
            __builder.OpenElement(60, "td");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                                            () => RemoveAdult(adult.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(63, "<i class=\"oi oi-trash\" style=\"color:pink\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n                    ");
            __builder.OpenElement(65, "td");
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
                                            () => Edit(adult.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "<i class=\"oi oi-pencil\" style=\"color:#90c565\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\sandr\Downloads\DNP-assignment1-master (3)\DNP-assignment1-master\Pages\Adults.razor"
       
    private IList<Adult> adults;
    private IList<Adult> toShowAdults;

    private string filterByName;
    private string filterHairColor;
    
    protected override async Task OnInitializedAsync()
    {
        adults = FileAdapter.GetAdults();
        toShowAdults = adults;
    }

    private void RemoveAdult(int id)
    {
        Adult toRemove = adults.First(a => a.Id == id);
        FileAdapter.RemoveAdult(id);
        adults.Remove(toRemove);
        toShowAdults.Remove(toRemove);
    }

    private void FilterByName(ChangeEventArgs changeEventArgs)
    {
        filterByName = null;
        try
        {
            filterByName = changeEventArgs.Value.ToString();
        }
        catch (Exception e){}
        ExecuteFilter();
    }

    private void FilterByHairColor(ChangeEventArgs changeEventArgs)
    {
        filterHairColor = null;
        try
        {
            filterHairColor = changeEventArgs.Value.ToString();
        }
        catch(Exception e){}
        ExecuteFilter();
    }

    private void Edit(int id)
    {
        NavigationManager.NavigateTo($"Edit/{id}");
    }

    private void ExecuteFilter()
    {
        toShowAdults = adults.Where(a =>
            ( ( filterByName != null && ( a.FirstName.ToLower().Contains( filterByName.ToLower() ) || a.LastName.ToLower().Contains( filterByName.ToLower() ) ) ) || filterByName == null) 
            &&
            (filterHairColor != null && a.HairColor == filterHairColor || filterHairColor == "All")).ToList();

    }

    private void NavigateToAddAdult()
    {
        NavigationManager.NavigateTo("/AddAdult");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileAdapter FileAdapter { get; set; }
    }
}
#pragma warning restore 1591
