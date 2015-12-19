Imports System.IO.Directory
Public Class Ayuda
    Public ruta As String
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            If TreeView1.SelectedNode.Name = "Nodo2" Then
                WebBrowser1.Navigate("file://" + GetCurrentDirectory().ToString() + "/Help/Guardar.html")
            ElseIf TreeView1.SelectedNode.Name = "Nodo3" Then
                WebBrowser1.Navigate("file://" + GetCurrentDirectory().ToString() + "/Help/Buscar.html")
            ElseIf TreeView1.SelectedNode.Name = "Nodo4" Then
                WebBrowser1.Navigate("file://" + GetCurrentDirectory().ToString() + "/Help/Actualizar.html")
            ElseIf TreeView1.SelectedNode.Name = "Nodo5" Then
                WebBrowser1.Navigate("file://" + GetCurrentDirectory().ToString() + "/Help/Eliminar.html")
            ElseIf TreeView1.SelectedNode.Name = "Nodo6" Then
                WebBrowser1.Navigate("file://" + GetCurrentDirectory().ToString() + "/Help/Guardar_cita.html")
            ElseIf TreeView1.SelectedNode.Name = "Nodo7" Then
                WebBrowser1.Navigate("file://" + GetCurrentDirectory().ToString() + "/Help/Buscar_cita.html")
            ElseIf TreeView1.SelectedNode.Name = "Nodo8" Then
                WebBrowser1.Navigate("file://" + GetCurrentDirectory().ToString() + "/Help/Actualizar_cita.html")
            ElseIf TreeView1.SelectedNode.Name = "Nodo9" Then
                WebBrowser1.Navigate("file://" + GetCurrentDirectory().ToString() + "/Help/Eliminar_cita.html")
            ElseIf TreeView1.SelectedNode.Name = "Nodo10" Then
                WebBrowser1.Navigate("file://" + GetCurrentDirectory().ToString() + "/Help/video.html")
            End If
        Catch ex As Exception

        End Try
    End Sub

    
End Class