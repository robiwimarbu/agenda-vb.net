Public Class frmRecordatorio

    Private Sub frmRecordatorio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim table As DataTable
        Dim r As New Datos()
        r.conectar()
        table = r.filtro("Cita.id_cita AS ID,Cita.fecha AS FECHA,Contacto.nombre AS NOMBRE,Cita.lugar AS LUGAR", "DATEVALUE(Cita.fecha)=DATEVALUE('" + Format(Date.Now(), "dd/MM/yyyy").ToString() + "') AND Cita.Contacto=Contacto.id", "Cita,Contacto")
        r.desconectar()
        If table.Rows.Count() > 0 Then

            Dim cont As Integer = table.Rows.Count()
            Label1.Text = "CITAS PARA HOY " + cont.ToString()
            Dim ydistancia As Integer = 25
            For X As Integer = 0 To cont - 1 Step 1
                Dim fechahora As New Label()
                Dim contacto As New Label()
                Dim lugar As New Label()
                fechahora.Top = 80 + (X * ydistancia)
                fechahora.Left = 20
                fechahora.Width = 180
                fechahora.Text = table.Rows(X)(1).ToString()
                Me.Controls.Add(fechahora)
                contacto.Top = 80 + (X * ydistancia)
                contacto.Left = 220
                contacto.Width = 180
                contacto.Text = table.Rows(X)(2).ToString()
                Me.Controls.Add(contacto)
                lugar.Top = 80 + (X * ydistancia)
                lugar.Left = 420
                lugar.Width = 180
                lugar.Text = table.Rows(X)(3).ToString()
                Me.Controls.Add(lugar)
            Next
        Else
            Label1.Top = 130
            Label1.Text = "NO HAY CITAS PARA HOY "
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class