#pragma checksum "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18a4603fa85ad1531901685ff568321241e2843c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Game), @"mvc.1.0.view", @"/Views/Home/Game.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Game.cshtml", typeof(AspNetCore.Views_Home_Game))]
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
#line 1 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 2 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18a4603fa85ad1531901685ff568321241e2843c", @"/Views/Home/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.GameModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml"
  
    ViewData["Title"] = "Game";
    var endTime = DateTime.UtcNow.AddSeconds(179);
    var timeRemaining = TimeSpan.FromTicks(endTime.Ticks - DateTime.UtcNow.Ticks).TotalSeconds;


#line default
#line hidden
            BeginContext(234, 195, true);
            WriteLiteral("\r\n\r\n<br />\r\n\r\n\r\n\r\n\r\n<br />\r\n<div class=\"col-lg-6 col-md-6 col-sm-6 col-xs-6\">\r\n    <div> Time: <b> <span id=\"minRemaining\"> </span> : <span id=\"secRemaining\"> </span> </b> </div>\r\n    <table>\r\n\r\n");
            EndContext();
#line 21 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml"
         for (int i = 0; i <= 3; i++)
        {

#line default
#line hidden
            BeginContext(479, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
#line 24 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml"
                 for (int j = 0; j <= 3; j++)
                {

#line default
#line hidden
            BeginContext(563, 23, true);
            WriteLiteral("                    <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 586, "\"", 595, 2);
#line 26 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml"
WriteAttributeValue("", 591, i, 591, 2, false);

#line default
#line hidden
#line 26 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml"
WriteAttributeValue("", 593, j, 593, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(596, 89, true);
            WriteLiteral(" style=\"border:solid;height:100px;width:100px;text-align:center;background-color:white;\">");
            EndContext();
            BeginContext(686, 23, false);
#line 26 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml"
                                                                                                                     Write(Model.LetterArray[i, j]);

#line default
#line hidden
            EndContext();
            BeginContext(709, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml"
                }

#line default
#line hidden
            BeginContext(735, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 29 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml"
        }

#line default
#line hidden
            BeginContext(765, 358, true);
            WriteLiteral(@"


    </table>
    <div class=""x_title"">

        <div class=""clearfix""></div>
        <h6 id=""start"">New word</h6>

    </div>
</div>

<div class=""col-lg-1 col-md-1 col-sm-1 col-xs-1"">
    <div class=""x_title"">
        <h4> Word is: </h4>
        <label id=""word""> </label>
        <br />


        <br />
        </div>
    </div>

");
            EndContext();
#line 53 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml"
     using (Html.BeginForm("Result", "Home", new { @class = "form-horizontal form-label-left" }))
    {

#line default
#line hidden
            BeginContext(1227, 1074, true);
            WriteLiteral(@"<div class=""col-lg-5 col-md-5 col-sm-5 col-xs-5"">
    <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-3"">
        <div class=""table-responsive"">
            <div class=""x_title"">
                <h4>PLAYER 1:</h4>
            </div>
            <table>
                <tbody id=""selectedTableItems""></tbody>
            </table>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-3"">
        <div class=""table-responsive"">
            <div class=""x_title"">
                <h4>PLAYER 2:</h4>
            </div>
            <table>
                <tbody id=""selectedTableItems2""></tbody>
            </table>
        </div>
    </div>
</div>
    <div class=""btn-group  pull-right"">

        <button type=""button"" id=""add"" class=""btn btn-primary"" onclick=""add1()""><span style=""color:#fff;""></span> ADD  </button>
        <button type=""button"" id=""add2"" class=""btn btn-danger"" onclick=""add22()""><span style=""color:#fff;""></span> ADD </button>
        <button type=""submit"" cla");
            WriteLiteral("ss=\"btn btn-success\">Finish</button>\r\n    </div>\r\n");
            EndContext();
#line 82 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml"
    }

#line default
#line hidden
            BeginContext(2308, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2335, 3703, true);
                WriteLiteral(@"


            <script>

            $('#add2').hide();

            $('document').ready(function () {
                var $td = $('td').click(function () {
                    var bgColor = $(this).css('backgroundColor');
                    var start = document.getElementById(""start"").innerText;
                    if (bgColor === ""rgb(255, 0, 0)"" || (bgColor === ""rgb(255, 255, 255)"" && start !== ""New word"")) {
                        alert(""Can't click"");
                    } else {
                        document.getElementById(""start"").innerText = "" "";
                        var $this = $(this);

                        for (i = 0; i <= 3; i++) {
                            for (j = 0; j <= 3; j++) {
                                if ($('#' + i + '' + j).css('backgroundColor') !== ""rgb(255, 0, 0)"") {
                                    $('#' + i + '' + j).css('backgroundColor', 'white');
                                }
                            }
                        }
");
                WriteLiteral(@"

                        $(this).css('backgroundColor', 'red');


                        var col = $this.index();
                        var row = $this.closest('tr').index();


                        var bgColor1 = $('#' + (row - 1) + '' + (col - 1)).css('backgroundColor');
                        if (bgColor1 !== ""rgb(255, 0, 0)"")
                            $('#' + (row - 1) + '' + (col - 1)).css('backgroundColor', 'grey');

                        var bgColor2 = $('#' + (row - 1) + '' + (col)).css('backgroundColor');
                        if (bgColor2 !== ""rgb(255, 0, 0)"")
                            $('#' + (row - 1) + '' + (col)).css('backgroundColor', 'grey');

                        var bgColor3 = $('#' + (row - 1) + '' + (col + 1)).css('backgroundColor');
                        if (bgColor3 !== ""rgb(255, 0, 0)"")
                            $('#' + (row - 1) + '' + (col + 1)).css('backgroundColor', 'grey');

                        var bgColor4 = $('#' + (row) + '' + (col ");
                WriteLiteral(@"- 1)).css('backgroundColor');
                        if (bgColor4 !== ""rgb(255, 0, 0)"")
                            $('#' + (row) + '' + (col - 1)).css('backgroundColor', 'grey');

                        var bgColor5 = $('#' + (row) + '' + (col)).css('backgroundColor');
                        if (bgColor5 !== ""rgb(255, 0, 0)"")
                            $('#' + (row) + '' + (col)).css('backgroundColor', 'grey');

                        var bgColor6 = $('#' + (row) + '' + (col + 1)).css('backgroundColor');
                        if (bgColor6 !== ""rgb(255, 0, 0)"")
                            $('#' + (row) + '' + (col + 1)).css('backgroundColor', 'grey');

                        var bgColor7 = $('#' + (row + 1) + '' + (col - 1)).css('backgroundColor');
                        if (bgColor7 !== ""rgb(255, 0, 0)"")
                            $('#' + (row + 1) + '' + (col - 1)).css('backgroundColor', 'grey');

                        var bgColor8 = $('#' + (row + 1) + '' + (col)).css('backgroun");
                WriteLiteral(@"dColor');
                        if (bgColor8 !== ""rgb(255, 0, 0)"")
                            $('#' + (row + 1) + '' + (col)).css('backgroundColor', 'grey');

                        var bgColor9 = $('#' + (row + 1) + '' + (col + 1)).css('backgroundColor');
                        if (bgColor9 !== ""rgb(255, 0, 0)"")
                            $('#' + (row + 1) + '' + (col + 1)).css('backgroundColor', 'grey');





                        document.getElementById(""word"").innerText += $(this).text();
                    }

                })




            });

            var remSeconds = parseFloat(");
                EndContext();
                BeginContext(6039, 13, false);
#line 167 "C:\Users\armin.basic\source\repos\WebApplication2\WebApplication2\Views\Home\Game.cshtml"
                                   Write(timeRemaining);

#line default
#line hidden
                EndContext();
                BeginContext(6052, 3605, true);
                WriteLiteral(@");
            var secondsCounter = remSeconds % 60;

        function formatNumber(number) {
            if (number < 10) return '0' + number;
            else return '' + number;
        }

        function startTick() {
            document.getElementById('secRemaining').innerText = formatNumber(secondsCounter);
            document.getElementById('minRemaining').innerText = formatNumber(remSeconds / 60);


            var _tick = setInterval(function ()
            {
                if (remSeconds > 0) {
                    remSeconds = remSeconds - 1;
                    secondsCounter = secondsCounter - 1;
                    document.getElementById('secRemaining').innerText = formatNumber(secondsCounter);
                    document.getElementById('minRemaining').innerText = formatNumber(parseInt(remSeconds / 60));

                    if (secondsCounter == 0)
                        secondsCounter = 60;


                } else {
                    alert('END!');
         ");
                WriteLiteral(@"           clearInterval(_tick);
                    $('#add').hide();
                    $('#add2').hide();
                }
            }, 1000);

        }

        startTick();


            var add1 = function () {
                addItem(document.getElementById(""word"").innerText);

                document.getElementById(""start"").innerText = ""New word"";
                $('#add').hide();
                $('#add2').show();

            }


            var addItem = function (item) {


                $('#selectedTableItems').append('<tr><td>' + item + '</td></tr>');
                item.Id = $('#selectedTableItems tr').length;
                createModelListItem(item)
                $('td').css('backgroundColor', 'white');
                document.getElementById(""word"").innerText = """";
            }


            var createModelListItem = function (item) {
                $('<input/>', {

                    name: ""Words"",
                    type: ""hidden"",
       ");
                WriteLiteral(@"             value: item
                }).appendTo('#selectedTableItems');

                $('<input/>', {

                    name: ""Words["" + $('#selectedTableItems tr').length + ""]"",
                    type: ""hidden"",
                    value: item

                }).appendTo('#selectedTableItems');

            }


            var add22 = function () {
                addItem2(document.getElementById(""word"").innerText);

                document.getElementById(""start"").innerText = ""New word"";
                $('#add2').hide();
                $('#add').show();
            }


            var addItem2 = function (item) {


                $('#selectedTableItems2').append('<tr><td>' + item + '</td></tr>');
                item.Id = $('#selectedTableItems2 tr').length;
                createModelListItem2(item)
                $('td').css('backgroundColor', 'white');
                document.getElementById(""word"").innerText = """";
            }


            var create");
                WriteLiteral(@"ModelListItem2 = function (item) {
                $('<input/>', {

                    name: ""Words1"",
                    type: ""hidden"",
                    value: item
                }).appendTo('#selectedTableItems2');

                $('<input/>', {

                    name: ""Words1["" + $('#selectedTableItems2 tr').length + ""]"",
                    type: ""hidden"",
                    value: item

                }).appendTo('#selectedTableItems2');

            }




            </script>
        ");
                EndContext();
            }
            );
            BeginContext(9660, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.GameModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
