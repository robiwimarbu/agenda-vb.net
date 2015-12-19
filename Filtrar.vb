Public Class frmFiltrar

    Public OPCION As Integer
    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click
        recargar()
    End Sub
    Public Sub recargar()
        Dim buscar As String = "" 'concatenacion de la cadena que sera la condcion para filtro
        If TxtNombre.TextLength > 0 Then
            buscar = "nombre like'" + TxtNombre.Text + "%'"
        Else
            buscar = "nombre like'%'"
        End If

        If TxtApellido.TextLength > 0 Then
            If buscar.Length > 0 Then
                buscar += " AND "
            End If
            buscar += " apellido like'" + TxtApellido.Text + "%'"
        End If

        If TxtDir.TextLength > 0 Then
            If buscar.Length > 0 Then
                buscar += " AND "
            End If
            buscar += " direccion like'" + TxtDir.Text + "%'"
        End If
        Dim r As New Datos()
        r.conectar()
        DataGridView1.DataSource = r.filtro(buscar, "Contacto") 'cargo el datagridview con los datos retornados por metodo filtro
        r.desconectar()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If OPCION = 2 Then
            Try
                frmnuevo.ID = DataGridView1(0, e.RowIndex()).Value
                frmnuevo.MdiParent = Me.MdiParent
                frmnuevo.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        ElseIf OPCION = 3 Then
            Try
                Dim r As New Datos()
                Dim respuesta As Integer
                If MessageBox.Show("Desea eliminar estos datos, Esta accion no se puede deshacer", "Alerta", MessageBoxButtons.YesNo) = vbYes Then
                    r.conectar()
                    respuesta = r.Elminar("Contacto", "id=" + DataGridView1(0, e.RowIndex()).Value.ToString())
                    r.desconectar()
                    If respuesta > 0 Then
                        MessageBox.Show("Datos Eliminados")
                        recargar()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End If
    End Sub
    

    Private Sub frmFiltrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If OPCION = 1 Then
            Me.Text = "FILTRAR DATOS"

        ElseIf OPCION = 2 Then
            Me.Text = "FILTRAR PARA ACTUALIZAR"
            Lblmessage.Text = "HAGA CLICK SOBRE LA FILA PARA CAMBIAR DATOS"
        ElseIf OPCION = 3 Then
            Me.Text = "FILTRAR PARA ELIMINAR"
            Lblmessage.Text = "HAGA CLICK SOBRE LA FILA PARA ELIMINAR DATO"
        End If
        recargar()
    End Sub
End Class