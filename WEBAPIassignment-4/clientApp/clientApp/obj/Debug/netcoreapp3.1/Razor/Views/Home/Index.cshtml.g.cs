#pragma checksum "C:\Users\MamtaY\source\repos\WEBAPIassignment-4\clientApp\clientApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb882022bf65f4c99d63c29366f84cd8e26fe7f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\MamtaY\source\repos\WEBAPIassignment-4\clientApp\clientApp\Views\_ViewImports.cshtml"
using clientApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MamtaY\source\repos\WEBAPIassignment-4\clientApp\clientApp\Views\_ViewImports.cshtml"
using clientApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb882022bf65f4c99d63c29366f84cd8e26fe7f7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8010cdb0411a5238274f72839bb7479244533809", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MamtaY\source\repos\WEBAPIassignment-4\clientApp\clientApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb882022bf65f4c99d63c29366f84cd8e26fe7f73658", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""text-center"">





 
    <div class=""panel panel-primary"">
        <div class=""panel-heading"">
           
        </div>
        <div class=""panel-heading"">
            <input id=""btn-all"" type=""button"" value=""GetAllContacts"" />
            <input type=""text"" id=""txtcity"" name=""txtcity"" />
            <input id=""btn-city"" type=""button"" value=""GetContactsByCity"" />

        </div>
        <hr />
        <div class=""panel-body"">
            <table class=""table table-bordered"" id=""Table"">
                <tr>
                    <td>Id</td>
                    <td>Name</td>
                    <td>City</td>
                    <td>Contact</td>
                </tr>
                <tbody id=""Contacts""></tbody>
            </table>

        </div>
    </div>


    
</div>

<script type=""text/javascript"">
    //$(document).ready(function () {
    //    manager.getAllContacts();

    //})
    //var manager = {

    //    getAllContacts: function () {
    //");
            WriteLiteral(@"        var object = """";
    //        var serviceUrl = ""https://localhost:44377/api/Contact"";
    //        window.manager.GetAPI(serviceUrl, onSuccess, onFailed);
    //        function onSuccess(jsonData) {
    //            debugger;
    //            object = jsonData;
    //            $.each(jsonData, function (i, item) {
    //                var rows = ""<tr>"" +
    //                    ""<td id='Id'>"" + item.contactId + ""</td>"" +
    //                    ""<td id='Id'>"" + item.contactName + ""</td>"" +
    //                    ""<td id='Id'>"" + item.city + ""</td>"" +
    //                    ""<td id='Id'>"" + item.cellNo + ""</td>"" +
    //                    $(""#Table"").append(rows);
    //            });
    //        }
    //        function onFailed(error) {
    //            window.alert(error.statusText);
    //        }
    //        return object;
    //    },
    //    GetAPI: function (serviceUrl, successCallBack, errorCallBack) {
    //        $.ajax({
    //            t");
            WriteLiteral(@"ype: ""GET"",
    //            url: serviceUrl,
    //            dataType: ""json"",
    //            success: successCallBack,
    //            error: errorCallBack
    //        });

    //    },
    //}

    $(document).ready(function () {
        var Contacts = $('#Contacts');

        $('#btn-all').click(function () {
            $.ajax({
                type: 'GET',
                url: ""https://localhost:44377/api/Contact"",
                dataType: 'json',
                success: function (data) {
                    Contacts.empty();

                    $.each(data, function (index, val) {

                        Contacts.append(""<tr><td>"" + val.contactId + ""</td><td>"" + val.contactName + ""</td><td>"" + val.city + ""</td><td>"" + val.cellNo + ""</td></tr>"")
                    });
                }
            });
        });

        $(document).ready(function () {
            var Contacts = $('#Contacts');

            $('#btn-city').click(function () {
             ");
            WriteLiteral(@"   var city = $('#txtcity').val();
                var getUrl = ""https://localhost:44377/api/Contact/"" + city;
                console.log(getUrl);
                $.ajax({
                    type: 'GET',
                    url: getUrl,
                    dataType: 'json',
                    success: function (data) {
                        Contacts.empty();

                        $.each(data, function (index, val) {

                            Contacts.append(""<tr><td>"" + val.contactId + ""</td><td>"" + val.contactName + ""</td><td>"" + val.city + ""</td><td>"" + val.cellNo + ""</td></tr>"")
                        });
                    }
                });
            });
        });

        //$('#btnClear').click(function () {
        //    ulContacts.empty();
        //});
    });

</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
