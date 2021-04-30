#pragma checksum "C:\Pooja Dashora\ToyRobot\ToyRobot\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea15eaee5b33711669c8be520e7abac66e6cc4ee"
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
#line 1 "C:\Pooja Dashora\ToyRobot\ToyRobot\Views\_ViewImports.cshtml"
using ToyRobot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Pooja Dashora\ToyRobot\ToyRobot\Views\_ViewImports.cshtml"
using ToyRobot.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea15eaee5b33711669c8be520e7abac66e6cc4ee", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0be0c52933575b383d5772df9a4239d8c61b5ae", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa7a36672704cd4c8c9092ee4d0f223bd579b55a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Pooja Dashora\ToyRobot\ToyRobot\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row pt-5"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title h6 mb-0"">Toy Robot Challange Guideline </h4>
            </div>
            <div class=""card-body"">

                <section>
                    <h4>Description</h4>
                    <p>
                        The application is a simulation of a toy robot moving on a square tabletop, of dimensions 5 units x 5 units.
                        There are no other obstructions on the table surface.
                    </p>
                    <p>The robot is free to roam around the surface of the table, but must be prevented from falling to destruction. Any movement that would result in the robot falling from the table must be prevented, however further valid movement commands must still be allowed.</p>
                    <p>Create an application that can read in commands of the following form:</p>
                    <ul>
                        <li>PLACE ");
            WriteLiteral(@"X,Y, FACING</li>
                        <li>MOVE</li>
                        <li>LEFT</li>
                        <li>RIGHT</li>
                        <li>REPORT</li>
                    </ul>
                    <p><strong>PLACE</strong> will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST.</p>
                    <p>The origin (0,0) can be considered to be the SOUTH WEST most corner.</p>
                    <p>The first valid command to the robot is a PLACE command, after that, any sequence of commands may be issued, in any order, including another PLACE command. The application should discard all commands in the sequence until a valid PLACE command has been executed.</p>
                    <p>
                        <strong>MOVE</strong> will move the toy robot one unit forward in the direction it is currently facing.
                        LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without changing the position of the robot.
    ");
            WriteLiteral(@"                </p>
                    <p><strong>REPORT</strong> will announce the X,Y and FACING of the robot. This can be in any form, but standard output is sufficient.</p>
                    <p>A robot that is not on the table can choose the ignore the MOVE, LEFT, RIGHT and REPORT commands.</p>
                    <p>Input can be from <em>a file</em>, or from standard input, as the developer chooses.</p>
                    <p><strong>Provide test data to exercise the application.</strong></p>
                    
                    <h4>Example Input and Output</h4>
                    <div class=""sampleCommand"">
                        <code>
                            PLACE 0,0,NORTH
                            MOVE
                            REPORT
                        </code>
                        <span>Output: 0,1,NORTH</span>
                    </div>

                    <div class=""sampleCommand"">
                        <code>
                            PLACE 0,0,NORTH
             ");
            WriteLiteral(@"               LEFT
                            REPORT
                        </code>
                        <span>Output: 0,0,WEST</span>
                    </div>

                    <div class=""sampleCommand"">
                        <code>
                            PLACE 1,2,EAST
                            MOVE
                            MOVE
                            LEFT
                            MOVE
                            REPORT
                        </code>
                        <span>Output: 3,3,NORTH</span>
                    </div>

                </section>

            </div>
        </div>
    </div>
</div>
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
