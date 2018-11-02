Imports System.IO
Imports System.Reflection
Imports ActiveConnection

Class GetControls
    Public Shared Sub loadmodule(tcmain As Object, ByVal modulesform As String, ByVal formcontrol As String, ByVal Optional controllname As String = Nothing)
        Try
            tcmain = MainForm.ClosableTabControl1
            Dim Modules As New Dictionary(Of String, List(Of Object))
            Modules.Clear()
            Dim oAssembly As Assembly
            Dim tp As TabPage
            Dim oControl As Object
            Dim l As List(Of Object)
            Dim b As Byte()
            b = File.ReadAllBytes("modules\" & modulesform & ".dll")
            oAssembly = Assembly.Load(b)
            oControl = oAssembly.CreateInstance(modulesform & "." & formcontrol)
            tcmain.TabPages.Add(controllname)
            tp = CType(tcmain.TabPages(tcmain.TabPages.Count - 1), TabPage)
            tp.Name = "dll" & modulesform & "-" & "form" & formcontrol
            tp.Controls.Add(oControl)
            DirectCast(oControl, UserControl).Dock = DockStyle.Fill
            l = New List(Of Object)
            l.Add(oControl)
            l.Add(tp)
            Modules.Add(controllname, l)
            tcmain.SelectedTab = tp
            log_file.storedata(Now + "-> User loaded module : " + modulesform)
        Catch ex As Exception
            log_file.storedata(Now + "-> Error : " + ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class