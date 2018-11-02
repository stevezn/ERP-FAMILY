Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports TextEdit = DevExpress.XtraEditors.TextEdit
Imports System.IO
Imports System.Drawing
Imports System.Net
Imports System.Web.Script.Serialization
Imports System.Reflection
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Net.NetworkInformation

Public Class AccessHandler
    Public Shared Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function

    Public Shared Function ImageToBase64(image As Image, format As Imaging.ImageFormat) As String
        Try
            Using ms As New MemoryStream()
                image.Save(ms, format)
                Dim imageBytes As Byte() = ms.ToArray()
                Dim base64String As String = Convert.ToBase64String(imageBytes)
                Return base64String
                log_file.storedata(Now & "-> Succesfully convert image to base64")
            End Using
        Catch ex As Exception
            Return MsgBox(ex.Message, MsgBoxStyle.Information)
            log_file.storedata(Now & "-> Error on ActiveCon-AccessHandler(ImageToBase64) : " & ex.Message)
        End Try
    End Function

    Public Shared Function NextNum(id As String, role As String, type As String)
        Try
            Dim request As WebRequest
            request = WebRequest.Create(DB.getlink("GetNextUser"))
            Dim response As WebResponse
            Dim postData As String = "{'tgl':'" & Now.ToString("yyyy-MM") & "%" & "','club':'" & id & "','role':'" & role & "', 'case':'" & type & "'}"
            Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(postData.Replace("'", Chr(34)))
            request.Method = WebRequestMethods.Http.Post
            request.ContentType = "application/json"
            request.ContentLength = data.Length
            Dim stream As Stream = request.GetRequestStream()
            stream.Write(data, 0, data.Length)
            stream.Close()
            response = request.GetResponse()
            Dim sr As New StreamReader(response.GetResponseStream())
            Dim json As New JavaScriptSerializer
            Dim jsondata As Dictionary(Of String, Object) = json.Deserialize(Of Dictionary(Of String, Object))(sr.ReadToEnd)
            For Each item In jsondata("data")
                Return item("result")
                log_file.storedata(Now + "-> Succesfully generated running number : " & jsondata("data"))
            Next
        Catch ex As Exception
            log_file.storedata(Now + "-> Error on ActiveCon-accesshandler(NextNum) : " + ex.Message)
            Return ex.Message
        End Try
    End Function

    Public Shared Function attach(img As Image) As Byte()
        Dim imgData As Byte()
        Dim cvt As New ImageConverter
        imgData = CType(cvt.ConvertTo(img, GetType(Byte())), Byte())
        Return imgData
    End Function

    Public Shared Function GetResizedImage(ByVal Data As Byte(), ByVal NewWidth As Integer, ByVal NewHeight As Integer) As Byte()
        Try
            Dim ms As New MemoryStream(Data)
            Dim bmp As New Bitmap(ms)
            Dim ResizedBMP As New Bitmap(NewWidth, NewHeight)
            Dim g As Graphics = Graphics.FromImage(bmp)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(ResizedBMP, 0, 0, NewWidth, NewHeight)
            Dim NewImageStream As New MemoryStream
            ResizedBMP.Save(NewImageStream, Imaging.ImageFormat.Jpeg)
            Return NewImageStream.ToArray
        Catch
            Throw
        End Try
    End Function

    Public Shared Sub arraytoimg(img As Byte())
        Try
            Dim sfilepath As String
            Dim buffer As Byte()
            buffer = CType(img, Byte())
            sfilepath = Path.GetTempFileName()
            File.Move(sfilepath, Path.ChangeExtension(sfilepath, ".jpg"))
            sfilepath = Path.ChangeExtension(sfilepath, ".jpg")
            File.WriteAllBytes(sfilepath, buffer)
            Dim op As New Process
            op.StartInfo = New ProcessStartInfo(CType(sfilepath, String))
            op.Start()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Shared Sub ClearForm(Optional ByVal root As Control = Nothing)
        For Each ctrl As Control In root.Controls
            ClearForm(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            ElseIf TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            ElseIf TypeOf ctrl Is TextEdit Then
                CType(ctrl, TextEdit).Text = String.Empty
            ElseIf TypeOf ctrl Is CheckEdit Then
                CType(ctrl, CheckEdit).Checked = False
            ElseIf TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Value = Now
                'ElseIf TypeOf ctrl Is PictureBox Then
                '    CType(ctrl, PictureBox).Image = Nothing
            ElseIf TypeOf ctrl Is PictureEdit Then
                CType(ctrl, PictureEdit).Image = Nothing
            End If
        Next ctrl
    End Sub

    Public Shared Sub loadmodule(tcmain As Object, ByVal modulesform As String, ByVal formcontrol As String, ByVal Optional controllname As String = Nothing)
        Try
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
            log_file.storedata(Now + "-> Error on ActiveCon-accesshandler(loadmodules): " + ex.Message)
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Shared Function CreateMergingEnabledMenuItem(ByVal view As GridView,
   ByVal rowHandle As Integer) As DXMenuCheckItem
        Dim checkItem As New DXMenuCheckItem("&Merging Enabled", view.OptionsView.AllowCellMerge, Nothing, AddressOf OnMergingEnabledClick)
        checkItem.Tag = New RowInfo(view, rowHandle)
        Return checkItem
    End Function

    'The handler for the DeleteRow menu item
    Sub OnDeleteRowClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = CType(sender, DXMenuItem)
        Dim info As RowInfo = CType(item.Tag, RowInfo)
        info.View.DeleteRow(info.RowHandle)
    End Sub

    'The handler for the MergingEnabled menu item
    Public Shared Sub OnMergingEnabledClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuCheckItem = CType(CType(sender, DXMenuItem), DXMenuCheckItem)
        Dim info As RowInfo = CType(item.Tag, RowInfo)
        info.View.OptionsView.AllowCellMerge = item.Checked
    End Sub
    ' ...
    ' The class that stores menu specific information
    Class RowInfo
        Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
            Me.RowHandle = rowHandle
            Me.View = view
        End Sub
        Public View As GridView
        Public RowHandle As Integer
    End Class
End Class