#pragma checksum "C:\Users\almaz\Desktop\WolfAuf\GGS\GGS\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "948582ebffc9464874f185296e2bb4e830d90bfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
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
#line 1 "C:\Users\almaz\Desktop\WolfAuf\GGS\GGS\Views\_ViewImports.cshtml"
using GGS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\almaz\Desktop\WolfAuf\GGS\GGS\Views\_ViewImports.cshtml"
using GGS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"948582ebffc9464874f185296e2bb4e830d90bfc", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71ba87d36d5547e0294ccb0a57cd26c6059fe36b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/Logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logotim"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("15%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("15%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\almaz\Desktop\WolfAuf\GGS\GGS\Views\Home\Main.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948582ebffc9464874f185296e2bb4e830d90bfc5811", async() => {
                WriteLiteral(@"
    <style type=""text/css"">


        body {
            background-image: url('../Images/bacground-image.jpg');
            background-repeat: no-repeat;
            background-attachment: fixed;
        }
		.logo{
			position: absolute;
			left:0;
			top:0;
		}
		.search{
			position: absolute;
			left:10.4%;
			top:25px;

		}

		#enter{
			text-align: right;
			color:black;
		}
		.enter_or_autentification{
			word-spacing: 15px;
			border-width: 4px;
			border-style: double;
			border-color:black;
			background-color: white;
			white-space: pre;



		}
		.menubar1,.menubar2{
			white-space: pre;
			border-width: 4px;
			border-style: double;
			border-color:black;
			background-color: white;

		}
		.menbar{
			position: absolute;
			top:39px;
			left:45%;

		}
		.mainmenubar{
			word-spacing: 6px;
			position: absolute;
			top:150px;
			left:38.5%;
			border-width: 4px;
			border-style: double;
			border-color:black;
			background-color: black;

");
                WriteLiteral(@"		}
		.mainmenubar1{
			border-width: 4px;
			border-style: double;
			border-color:black;
			white-space: pre;
			background-color: white;
		}
		a{
			text-decoration: none;
			text-transform: uppercase;

			color:black;

		}
		/*Сверху все стили для header */
		/*Ниже для article */
		.hits_of_season{
			position: absolute;
			top: 21%;
			left:5%;
		}
		.ZagolovokJanr{
			position: absolute;
			top:68%;
			left:6.9%;

		}
		.ZagolovokRazdel{
			position: absolute;
			top:118%;
			left:6.9%;
		}
		h1.hits_span{
			font-weight:600;
			font-size: 30px;
			color:white;
			color:white;
		}
		h1.ZagolovokJanr1{
			font-weight:600;
			font-size: 30px;
			color:white;
		}
		h1.ZagolovokRazdel1{
			font-weight:600;
			font-size: 30px;
		}
		.janr{  /*Таблица жанров */
			border-width: 2px;
			border-style: double;
			border-color:white;
			position: absolute;
			top:75%;
			left:5%;

		}
		.razdel{/*Таблица разделов */
			border-width: 2px;
			border-style:");
                WriteLiteral(@" double;
			border-color:white;
			position: absolute;
			top:125%;
			left:5%;

		}
		td{/*Выравнивание таблиц */
			text-align: center;
			border-color: black;
			background-color: white;

		}
		.menubarofgame{
			position: absolute;
			top:73%;
			left:40.5%;

		}
		.footer{
			position: absolute;
			top:155%;
			left:50%;
			color:white;
		}

		.menubar1:hover{
			background-color: lightgray;
		}
		.menubar2:hover{
			background-color: lightgray;
		}
		.enter_or_autentification:hover{
			background-color: lightgray;
		}
		.mainmenubar1:hover{
			background-color: lightgray;
		}
		td:hover{
			background-color: lightgray;
		}
		.search_sumbit{
			position: absolute;
  			top: 4;
  			right: -20px;
  			width: 36px;
 			height: 21px;
  			border: none;

  			background: lightgray;
  			border-radius: 0 5px 5px 0;
  			cursor: pointer;
		}
		.search_sumbit:before{
			content: ""\f002"";
  			font-family: FontAwesome;
  			font-size: 16px;
  			color: bla");
                WriteLiteral(@"ck;
		}
		.search_text{
			padding-left: 10px;
			border: 2px solid lightgray;
 			border-radius: 5px;
			outline: none;
  			background: white;
  			color: black;
		}



    </style>
    <meta charset=""UTF-8"">
    <meta rel=""stylesheet"" href=""MainPage.css"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>MainPage</title>
    <link rel=""icon"" href=""3Variant_3.ico"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948582ebffc9464874f185296e2bb4e830d90bfc10397", async() => {
                WriteLiteral("\r\n    <header>\r\n        <div class=\"logo\"><a href=\"MainPage.html\" target=\"_self\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "948582ebffc9464874f185296e2bb4e830d90bfc10743", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a></div> <!--Логотип -->\r\n\r\n        <div id=\"enter\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948582ebffc9464874f185296e2bb4e830d90bfc12164", async() => {
                    WriteLiteral(@"
                <a href=""/Home/Login"" target=""_self""><span class=""enter_or_autentification"">  Вход </span></a> <a href=""Autentification.html"" target=""_self""><span class=""enter_or_autentification""> Регистрация </span></a>  <!--Вход/выход или аутентификация -->


            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <div class=\"search\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948582ebffc9464874f185296e2bb4e830d90bfc14107", async() => {
                    WriteLiteral("\r\n                <p class=\"p1\">\r\n                    <input type=\"search\" name=\"Search\" placeholder=\"Поиск по магазину\" class=\"search_text\">  <!--Поисковая строчка -->\r\n                    <button type=\"submit\"");
                    BeginWriteAttribute("value", " value=\"", 4414, "\"", 4422, 0);
                    EndWriteAttribute();
                    WriteLiteral(" name=\"Search\" class=\"search_sumbit\"></button>\r\n                </p>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n        <nav>\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948582ebffc9464874f185296e2bb4e830d90bfc16230", async() => {
                    WriteLiteral("\r\n                <div class=\"menbar\"><a href=\"#\" target=\"_self\"><span class=\"menubar1\"> Личный кабинет  </span></a> <a href=\"Basket.html\" target=\"_self\"><span class=\"menubar2\"> Корзина</span></a></div>\r\n\r\n\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        </nav>\r\n\r\n        <nav>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948582ebffc9464874f185296e2bb4e830d90bfc18114", async() => {
                    WriteLiteral(@"
                <div class=""mainmenubar"">
                    <a href=""MainPage.html"" target=""_self""><span class=""mainmenubar1	"">  Главная  </span></a>
                    <a href=""#"" target=""_self""><span class=""mainmenubar1	"">  Новинки  </span></a>
                    <a href=""#"" target=""_self""><span class=""mainmenubar1	""> Предзаказ  </span></a>
                    <a href=""#"" target=""_self""><span class=""mainmenubar1	""> Скидки  </span></a>

                </div>

            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        </nav>

    </header>

    <article>
        <section>
            <!-- Секция с интерктивным, двигающимся меню выбора игр -->
            <div class=""hits_of_season"">
                <h1 class=""hits_span"">Хиты сезона!</h1>
            </div>
        </section>


        <section>
            <!--	Меню выбора жанра -->
            <div class=""ZagolovokJanr""><h1 class=""ZagolovokJanr1"">Жанр</h1></div>
            <div class=""janr"">
                <table border=""2"" cellpadding=""3px"" bordercolor=""white"" width=""150px"">

                    <tr><td><a href=""#""> Экшн</a></td></tr>
                    <tr><td><a href=""#""> Шутеры</a></td></tr>
                    <tr><td><a href=""#""> Приключения</a></td></tr>
                    <tr><td><a href=""#""> Ролевые</a></td></tr>
                    <tr><td><a href=""#""> Инди</a></td></tr>
                    <tr><td><a href=""#""> Симуляторы</a></td></tr>
                    <tr><td><a href=""#""> Стратегии</a></td></tr>
                    <");
                WriteLiteral(@"tr><td><a href=""#""> Аркады</a></td></tr>
                    <tr><td><a href=""#""> Спорт и гонки</a></td></tr>
                    <tr><td><a href=""#""> Казуальные</a></td></tr>
                    <tr><td><a href=""#""> Хоррор</a></td></tr>
                    <tr><td><a href=""#""> Выживание</a></td></tr>
                    <tr><td><a href=""#""> Открытый мир</a></td></tr>
                    <tr><td><a href=""#""> С сюжетом</a></td></tr>
                </table>
            </div>


        </section>
        <section>
            <!--	Меню выбора раздела -->
            <div class=""ZagolovokRazdel""><h1 class=""ZagolovokJanr1"">Раздел</h1></div>
            <div class=""razdel"">
                <table border=""2px"" cellpadding=""3px"" bordercolor=""white"" width=""150px"">

                    <tr><td><a href=""#""> Steam</a></td></tr>
                    <tr><td><a href=""#""> Origin</a></td></tr>
                    <tr><td><a href=""#""> Uplay</a></td></tr>
                    <tr><td><a href=""#""> Battle.ne");
                WriteLiteral(@"t</a></td></tr>
                    <tr><td><a href=""#""> XBox</a></td></tr>
                    <tr><td><a href=""#""> Playstation</a></td></tr>
                    <tr><td><a href=""#""> Mac OS X</a></td></tr>
                    <tr><td><a href=""#""> Linux + Steam OS</a></td></tr>

                </table>
            </div>
        </section>


        <section>
            <!--Меню выбора игры -->
            <div class=""menubarofgame"">
                <a href=""MainPage.html"" target=""_self""><span class=""mainmenubar1	"">  Каталог  </span></a>
                <a href=""#"" target=""_self""><span class=""mainmenubar1	"">  Новые  </span></a>
                <a href=""#"" target=""_self""><span class=""mainmenubar1	""> Популярные  </span></a>
                <a href=""#"" target=""_self""><span class=""mainmenubar1	""> Ожидаемые  </span></a>

            </div>

        </section>




    </article>


    <div class=""footer""><footer> Team WOLFAUF</footer></div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
