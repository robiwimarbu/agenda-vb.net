Public Class frmnuevo
    Public ID As Integer 'variable usada para identificar el modo de uso para el formulario
    Private Function ValidarCampos() As Boolean
        Dim x As Boolean = True
        Dim errores As String = ""
        If TxtNombre.TextLength = 0 Then
            errores += "Campo Nombre no debe contener Valores nulos" & vbCrLf
            x = False
        End If
        If TxtApellido.TextLength = 0 Then
            errores += "Campo Apellido no debe contener Valores nulos" & vbCrLf
            x = False
        End If
        If TxtTel.TextLength = 0 Then
            errores += "Campo Telefono no debe contener Valores nulos puede darle valor de cero(0)" & vbCrLf
            x = False
        ElseIf Not IsNumeric(TxtTel.Text) Then
            errores += "Campo Telefono debe contener solo numeros" & vbCrLf
            x = False
        End If
        
        If TxtMovil.TextLength = 0 Then
            errores += "Campo Movil no debe contener Valores nulos puede darle valor de cero(0)" & vbCrLf
            x = False
        ElseIf Not IsNumeric(TxtMovil.Text) Then
            errores += "Campo Movil debe contener solo numeros" & vbCrLf
            x = False
        End If
        If x = False Then
            MessageBox.Show(errores, "Alerta")
        End If
        Return x
    End Function
    Private Sub BtnAccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccion.Click
        If ID = 0 Then 'SI EL FORMULARIO SE ABRE PARA INSERTAR DATOS
            Dim x As Boolean
            x = ValidarCampos()
            If x = True Then
                Dim r As Datos
                Dim campos As String 'cadenas para los campos a insertar
                Dim valores As String 'cadena para los valores a insertar
                Dim respuesta As Integer 'variable que tomara el valor retornado por metodo guardar
                campos = "nombre,apellido,direccion,telefono,movil,email,comentarios"
                valores = "'" + TxtNombre.Text + "'," 'concatenar cadena para valores
                valores += "'" + TxtApellido.Text + "',"
                valores += "'" + TxtDir.Text + "',"
                valores += "'" + TxtTel.Text + "',"
                valores += "'" + TxtMovil.Text + "',"
                valores += "'" + TxtEmail.Text + "',"
                valores += "'" + RTxtCom.Text + "'"
                r = New Datos() 'objeto r de la clase datos
                r.conectar() 'abro la coneccion a la db
                respuesta = r.guardar(campos, "Contacto", valores) 'utilizo metodo guardar
                r.desconectar() 'cierro la coneccion a la db
                If respuesta > 0 Then 'si el valor retornado por metodo guardar es mayor que cero
                    MessageBox.Show("Datos Guardados") 'muestro msj 
                    TxtNombre.Clear() 'limpio los campos del formulario
                    TxtApellido.Clear()
                    TxtDir.Clear()
                    TxtTel.Clear()
                    TxtMovil.Clear()
                    TxtEmail.Clear()
                    RTxtCom.Clear()
                End If
            End If
        ElseIf ID >= 1 Then 'SI EL FORMULARIO SE ABRE PARA ACTUALIZACION
            Dim valores As String 'cadena para los valores a insertar
            Dim respuesta As Integer 'variable que tomara el valor retornado por metodo Actualizar
            valores = "nombre='" + TxtNombre.Text + "'," 'concateno los campos y sus valores actualizar
            valores += "apellido='" + TxtApellido.Text + "',"
            valores += "direccion='" + TxtDir.Text + "',"
            valores += "telefono='" + TxtTel.Text + "',"
            valores += "movil='" + TxtMovil.Text + "',"
            valores += "email='" + TxtEmail.Text + "',"
            valores += "comentarios='" + RTxtCom.Text + "'"
            Dim r As New Datos() 'objeto de clase r
            r.conectar() 'abro la coneccion a la db
            respuesta = r.Actualizar(valores, "Contacto", "id=" + ID.ToString()) 'utilizo el metodo actualizar
            r.desconectar()
            If (respuesta > 0) Then
                MessageBox.Show("Datos actualizados")
                frmFiltrar.recargar()
            End If
        End If
    End Sub

    Private Sub launch() 'funcion que carga los datos en el formulario desde una consulta
        Dim r As New Datos()
        Dim dt As New DataTable()
        r.conectar()
        dt = r.filtro("id=" + ID.ToString(), "Contacto") 'consulto datos dependiendo del ID
        r.desconectar()
        TxtId.Text = ID.ToString()
        TxtNombre.Text = dt.Rows(0)(1).ToString()
        TxtApellido.Text = dt.Rows(0)(2).ToString()
        TxtDir.Text = dt.Rows(0)(3).ToString()
        TxtTel.Text = dt.Rows(0)(4).ToString()
        TxtMovil.Text = dt.Rows(0)(5).ToString()
        TxtEmail.Text = dt.Rows(0)(6).ToString()
        RTxtCom.Text = dt.Rows(0)(7).ToString()
    End Sub
    Private Sub frmnuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ID = 0 Then 'si el ID=0  uso para guardar datos
            Me.Text = "Nuevo Contacto" 'cambio el titulo del formulario
            BtnAccion.Text = "Guardar" 'cambio el titulo del boton
        ElseIf ID >= 1 Then 'si el ID>=1 uso para actualizar datos
            TxtId.Visible = True 'se hace visible el campo id
            Label7.Visible = True 'se hace visible la etiqueta de id
            Me.Text = "Actualizar Contacto" 'cambio el titulo del formulario
            BtnAccion.Text = "Actualizar" 'cambio el titulo del boton
            launch() 'cargo el formulario con los datos
        End If
    End Sub
End Class