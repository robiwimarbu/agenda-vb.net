Public Class frmCitas
    Public ID As Integer
    Private Sub btnCitas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCitas.Click
        Dim Fecha, fcita, hor As Date
        hor = DtmHora.Value
        Try
            Fecha = Format(DtmFecha.Value.Date, "dd/MM/yyyy")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        Dim cadena As String
        Try
            cadena = Fecha.Day().ToString() + "/" + Fecha.Month.ToString() + "/" + Fecha.Year.ToString() + " " + hor.Hour.ToString() + ":" + hor.Minute.ToString() + ":" + hor.Second.ToString()
            fcita = Convert.ToDateTime(cadena)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        If ID = 0 Then 'si no llega el id es porque se usara para insertar nuevas citas
            Dim r As New Datos()
            Dim x As String
            Dim i As Integer
            x = "'" + fcita.ToString() + "'," + CbmContacto.SelectedValue.ToString() + ",'" + txtLugar.Text + "'"
            r.conectar()
            i = r.guardar("fecha,contacto,lugar", "Cita", x)
            r.desconectar()
            If i > 0 Then
                MessageBox.Show("Datos guardados")
                ClearForm()
            End If

        ElseIf ID > 0 Then 'se usara para modificar datos cargados
            Dim r As New Datos()
            Dim x As String
            Dim i As Integer
            x = "fecha='" + fcita.ToString() + "',Contacto=" + CbmContacto.SelectedValue.ToString() + ",lugar='" + txtLugar.Text + "'"
            r.conectar()
            i = r.Actualizar(x, "Cita", "id_cita=" + ID.ToString())
            r.desconectar()
            If i > 0 Then
                MessageBox.Show("Datos Actualizados")
                frmFiltrarCitas.cargar()
            End If
        End If
    End Sub
    Private Sub ClearForm()
        txtLugar.Clear()
        DtmFecha.Text = ""
        DtmHora.Text = ""
    End Sub
    Private Sub CargaCombo()
        CbmContacto.Items.Clear()
        Dim r As New Datos()
        Dim registros As DataTable
        r.conectar()
        registros = r.filtro("id<>0", "Contacto")
        r.desconectar()
        CbmContacto.DataSource = registros
        CbmContacto.DisplayMember = "nombre"
        CbmContacto.ValueMember = "id"

    End Sub
    Public Sub Carga_form()
        If ID = 0 Then
            Me.Text = "CREAR CITAS"
            btnCitas.Text = "GUARDAR"
        ElseIf ID > 0 Then
            Me.Text = "ACTUALIZAR CITAS"
            btnCitas.Text = "ACTUALIZAR"
            Dim r As New Datos()
            Dim contacto As DataTable
            r.conectar()
            contacto = r.filtro("id_cita=" + ID.ToString(), "Cita")
            r.desconectar()
            DtmFecha.Text = contacto(0)(1).ToString()
            DtmHora.Text = contacto(0)(1).ToString()
            CbmContacto.SelectedValue = Int(contacto(0)(2).ToString())
            txtLugar.Text = contacto(0)(3).ToString()
        End If
    End Sub



    Private Sub frmCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaCombo()
        Carga_form()
    End Sub
End Class