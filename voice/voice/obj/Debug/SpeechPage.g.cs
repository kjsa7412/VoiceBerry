﻿

#pragma checksum "C:\Users\marsm_000\Documents\Visual Studio 2013\Projects\voice2\voice\SpeechPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5F628AD2E1CAE88385D4DC233605487A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace voice
{
    partial class SpeechPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 12 "..\..\SpeechPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AppBarButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 22 "..\..\SpeechPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.GView_SpeechPage_ItemClick;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


