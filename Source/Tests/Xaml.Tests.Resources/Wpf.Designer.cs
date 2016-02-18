﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xaml.Tests.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Wpf {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Wpf() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Xaml.Tests.Resources.Wpf", typeof(Wpf).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;&gt;
        ///  &lt;StackPanel&gt;      
        ///    &lt;TextBlock Text=&quot;{Binding Path=SampleString}&quot; /&gt;
        ///  &lt;/StackPanel&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string Bindings {
            get {
                return ResourceManager.GetString("Bindings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
        ///        xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;&gt;
        ///  &lt;Window.Resources&gt;
        ///    &lt;Color x:Key=&quot;color&quot;&gt;#ff808080&lt;/Color&gt;
        ///  &lt;/Window.Resources&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string ColorResource {
            get {
                return ResourceManager.GetString("ColorResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
        ///        xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;&gt;
        ///  &lt;Window.Resources&gt;
        ///    &lt;!-- Expected Errors (as reported in WPF):
        ///         - The type &apos;ColumnDefinition&apos; does not support direct content.
        ///         - The TypeConverter for &quot;ColumnDefinition&quot; does not support converting from a string.	
        ///    --&gt;
        ///    &lt;ColumnDefinition x:Key=&quot;col&quot;&gt;Foo&lt;/ColumnDefinition&gt;
        ///  &lt;/Window.Resources&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string ColumnDefinitionResourceError {
            get {
                return ResourceManager.GetString("ColumnDefinitionResourceError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot; Title=&quot;Hello from OmniXaml!&quot; Width=&quot;800&quot; Height=&quot;600&quot;&gt;
        ///  &lt;ListBox ItemsSource=&quot;{Binding Path=Collection}&quot;&gt;
        ///    &lt;ListBox.ItemTemplate&gt;
        ///      &lt;DataTemplate&gt;
        ///        &lt;Button Content=&quot;{Binding}&quot;/&gt;
        ///      &lt;/DataTemplate&gt;
        ///    &lt;/ListBox.ItemTemplate&gt;
        ///  &lt;/ListBox&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string DataTemplate {
            get {
                return ResourceManager.GetString("DataTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot; Title=&quot;Hello from OmniXaml!&quot; Width=&quot;800&quot; Height=&quot;600&quot;&gt;
        ///  &lt;ListBox ItemsSource=&quot;{Binding Path=Collection}&quot;&gt;
        ///    &lt;ListBox.ItemTemplate&gt;
        ///      &lt;DataTemplate&gt;
        ///        &lt;Button Content=&quot;Greetings!&quot;/&gt;
        ///      &lt;/DataTemplate&gt;
        ///    &lt;/ListBox.ItemTemplate&gt;
        ///  &lt;/ListBox&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string DataTemplateNoBinding {
            get {
                return ResourceManager.GetString("DataTemplateNoBinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
        ///        xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;&gt;
        ///  &lt;Window.Resources&gt;
        ///    &lt;Button x:Key=&quot;MyButton&quot; Content=&quot;Hohoho&quot; /&gt;
        ///  &lt;/Window.Resources&gt;
        ///  &lt;ContentControl Content=&quot;{DynamicResource MyButton}&quot; /&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string DynamicResource {
            get {
                return ResourceManager.GetString("DynamicResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;&gt;
        ///    &lt;ListBox&gt;
        ///        &lt;ListBoxItem&gt;
        ///            &lt;TextBox Text=&quot;{Binding DoubleValue, Mode=TwoWay}&quot;/&gt;
        ///        &lt;/ListBoxItem&gt;
        ///    &lt;/ListBox&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string InnerBinding {
            get {
                return ResourceManager.GetString("InnerBinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
        ///        xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;&gt;
        ///  &lt;Window.Resources&gt;
        ///    &lt;Button x:Key=&quot;MyButton&quot; Content=&quot;Hohoho&quot; /&gt;
        ///  &lt;/Window.Resources&gt;
        ///  &lt;ContentControl Content=&quot;{StaticResource MyButton}&quot; /&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string KeyDirective {
            get {
                return ResourceManager.GetString("KeyDirective", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Menu xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;&gt;
        ///  &lt;MenuItem Header=&quot;File&quot;&gt;
        ///    &lt;MenuItem /&gt;
        ///  &lt;/MenuItem&gt;
        ///&lt;/Menu&gt;.
        /// </summary>
        public static string MicroShowCase {
            get {
                return ResourceManager.GetString("MicroShowCase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Grid xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;&gt;
        ///    &lt;Grid.RowDefinitions&gt;
        ///        &lt;RowDefinition /&gt;
        ///        &lt;RowDefinition /&gt;
        ///        &lt;RowDefinition /&gt;
        ///    &lt;/Grid.RowDefinitions&gt;
        ///    &lt;TextBlock Text=&quot;Hola&quot;&gt;
        ///        &lt;Grid.Row&gt;0&lt;/Grid.Row&gt;
        ///    &lt;/TextBlock&gt;
        ///    &lt;TextBlock Text=&quot;Tío&quot;&gt;
        ///        &lt;Grid.Row&gt;1&lt;/Grid.Row&gt;
        ///    &lt;/TextBlock&gt;
        ///    &lt;TextBlock Text=&quot;¿Cómo vas?&quot;&gt;
        ///        &lt;Grid.Row&gt;2&lt;/Grid.Row&gt;
        ///    &lt;/TextBlock&gt;
        ///&lt;/Grid&gt;.
        /// </summary>
        public static string NestedAttachedProperty {
            get {
                return ResourceManager.GetString("NestedAttachedProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window Title=&quot;MainWindow&quot; xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot; Height=&quot;350&quot; Width=&quot;525&quot;&gt;
        ///  &lt;Grid&gt;
        ///    &lt;Grid.RowDefinitions&gt;
        ///      &lt;RowDefinition Height=&quot;Auto&quot;/&gt;
        ///      &lt;RowDefinition /&gt;
        ///    &lt;/Grid.RowDefinitions&gt;
        ///    &lt;Menu&gt;
        ///      &lt;MenuItem Header=&quot;File&quot;&gt;
        ///        &lt;MenuItem Header=&quot;Open&quot;&gt;
        ///          &lt;MenuItem.Icon&gt;
        ///            &lt;Image Source=&quot;github_icon.png&quot;&gt;&lt;/Image&gt;
        ///          &lt;/MenuItem.Icon&gt;
        ///        &lt;/MenuItem&gt;
        ///        &lt;MenuItem Header=&quot;Save&quot;&gt;
        ///          &lt;MenuItem He [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ShowCase {
            get {
                return ResourceManager.GetString("ShowCase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
        ///        xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;&gt;
        ///  &lt;Window.Resources&gt;
        ///    &lt;SolidColorBrush x:Key=&quot;brush&quot;&gt;#ff808080&lt;/SolidColorBrush&gt;
        ///  &lt;/Window.Resources&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string SolidColorBrushResource {
            get {
                return ResourceManager.GetString("SolidColorBrushResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
        ///        xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;&gt;
        ///  &lt;Window.Resources&gt;
        ///    &lt;!-- Expected Error: Element attributes are not allowed on objects created via TypeConverter. --&gt;
        ///    &lt;SolidColorBrush x:Key=&quot;brush&quot; Opacity=&quot;0.5&quot;&gt;#ff808080&lt;/SolidColorBrush&gt;
        ///  &lt;/Window.Resources&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string SolidColorBrushResourceError {
            get {
                return ResourceManager.GetString("SolidColorBrushResourceError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot; Title=&quot;Hello OmniXaml!&quot;&gt;
        ///  &lt;Window.Content&gt;
        ///    &lt;Grid&gt;
        ///      &lt;Grid.ColumnDefinitions&gt;
        ///        &lt;ColumnDefinition /&gt;
        ///        &lt;ColumnDefinition /&gt;
        ///      &lt;/Grid.ColumnDefinitions&gt;
        ///      &lt;Grid.Children&gt;
        ///        &lt;TextBlock Text=&quot;XAML is the way&quot; Grid.Column=&quot;0&quot; /&gt;
        ///        &lt;TextBlock Text=&quot;To make you invincible :D&quot; Grid.Column=&quot;1&quot; /&gt;
        ///      &lt;/Grid.Children&gt;
        ///    &lt;/Grid&gt;
        ///  &lt;/Window.Content&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string Stage1 {
            get {
                return ResourceManager.GetString("Stage1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window x:Class=&quot;WpfApplication_test1.MainWindow&quot;
        ///        xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
        ///        xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;
        ///        xmlns:d=&quot;http://schemas.microsoft.com/expression/blend/2008&quot;
        ///        xmlns:mc=&quot;http://schemas.openxmlformats.org/markup-compatibility/2006&quot;        
        ///        mc:Ignorable=&quot;d&quot;
        ///        Title=&quot;MainWindow&quot; Height=&quot;350&quot; Width=&quot;525&quot;&gt;
        ///  &lt;Grid Background=&quot;BlueViolet&quot;&gt;
        ///    &lt;Grid.RowDefinitions&gt;
        ///      &lt;RowDefinition He [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Stage2 {
            get {
                return ResourceManager.GetString("Stage2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;UserControl
        ///    x:Class=&quot;NcoreCpuMarkW8.UI.Controls.UcSpeedmeter&quot;
        ///    xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;
        ///    xmlns:x=&quot;http://schemas.microsoft.com/winfx/2006/xaml&quot;
        ///    xmlns:d=&quot;http://schemas.microsoft.com/expression/blend/2008&quot;
        ///    xmlns:mc=&quot;http://schemas.openxmlformats.org/markup-compatibility/2006&quot;
        ///    mc:Ignorable=&quot;d&quot;
        ///    d:DesignHeight=&quot;400&quot;
        ///    d:DesignWidth=&quot;600&quot;&gt;
        ///  &lt;Grid MinHeight=&quot;400&quot; MinWidth=&quot;600&quot;&gt;
        ///    &lt;Canvas&gt;
        ///      &lt;Image&gt;&lt;/Image&gt;
        ///      &lt;Image x:Nam [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Stage3 {
            get {
                return ResourceManager.GetString("Stage3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;&gt;&lt;/Window&gt;.
        /// </summary>
        public static string Window {
            get {
                return ResourceManager.GetString("Window", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Window xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;&gt;
        ///  &lt;Window.Content&gt;
        ///    &lt;TextBlock Text=&quot;Saludos cordiales!&quot; /&gt;
        ///  &lt;/Window.Content&gt;
        ///&lt;/Window&gt;.
        /// </summary>
        public static string WindowWithContent {
            get {
                return ResourceManager.GetString("WindowWithContent", resourceCulture);
            }
        }
    }
}
