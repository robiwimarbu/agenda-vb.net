Public Class frmFiltrarCitas
    Public OPCION As Integer
    Public Sub cargar()
        Dim r As New Datos()
        Dim regt As New DataTable()
        r.conectar()
        regt = r.filtro("Cita.id_cita AS ID,Cita.fecha AS FECHA,Contacto.nombre AS NOMBRE,Cita.lugar AS LUGAR", "DATEVALUE(Cita.fecha)=DATEVALUE('" + Format(DtmFcita.Value.Date, "dd/MM/yyyy").ToString() + "') AND Cita.Contacto=Contacto.id", "Cita,Contacto")
        r.desconectar()
        DataGridView1.DataSource = regt
    End Sub

    Private Sub frmFiltrarCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub btnFitrarCitas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFitrarCitas.Click
        cargar()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If OPCION = 2 Then
            Try
                frmCitas.ID = DataGridView1(0, e.RowIndex()).Value
                frmCitas.MdiParent = Me.MdiParent
                frmCitas.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try

        ElseIf OPCION = 3 Then
            Dim r As New Datos()
            If MessageBox.Show("Si decide eliminar no se podra deshacer esta accion", "Alerta", MessageBoxButtons.YesNo) = vbYes Then
                r.conectar()
                r.Elminar("Cita", "id_cita=" + DataGridView1(0, e.RowIndex()).Value.ToString())
                r.desconectar()
                cargar()
            End If
        End If
    End Sub
End Class