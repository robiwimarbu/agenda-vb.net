'clase creada para conectar a la bd y realizar operacion de insercion,actualizacion,eliminacion, busqueda
Imports System.Data 'namespace para trabajar con colecciones de datos
Imports System.Data.OleDb 'namespace para conectar a la db 

Public Class Datos
    Private conexion As OleDbConnection 'variable para la conectar a bd
    'variable con la cadena de coneccion
    Private CadenaDeConecion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=DbAgendaVb1.mdb;"
    Private Comando As OleDbCommand 'variable que se usara para enviar comando sql
    Private Adaptador As OleDbDataAdapter 'variable que contendra los resultados de comando
    Public Sub conectar() 'metodo para conectar
        Try
            conexion = New OleDbConnection(CadenaDeConecion)
            conexion.Open()
        Catch E As Exception
            MessageBox.Show(E.Message.ToString())
        End Try
    End Sub
    Public Function guardar(ByVal campos As String, ByVal tabla As String, ByVal valores As String) As Integer 'funcion para guardar
        Dim i As Integer = 0
        Try
            Dim consulta As String
            consulta = "INSERT INTO "
            consulta += tabla + "( " + campos + ") VALUES(" + valores + ")"
            Comando = New OleDbCommand(consulta, conexion)
            i = Comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        Return i
    End Function
    Public Function filtro(ByVal condicion As String, ByVal tabla As String) As DataTable 'funcion para realizar busqueda de datos retornara un datatable
        Dim registros As DataTable
        registros = New DataTable()
        Try
            Dim consulta As String = "SELECT * FROM " + tabla + " WHERE " + condicion
            Comando = New OleDbCommand(consulta, conexion)
            Adaptador = New OleDbDataAdapter()
            Adaptador.SelectCommand = Comando
            Adaptador.Fill(registros) 'carga el datatable con el contenido de la consulta contenida en el dataadapter
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        Return registros
    End Function
    Public Function filtro(ByVal campos As String, ByVal condicion As String, ByVal tabla As String) As DataTable 'funcion para realizar busqueda de datos retornara un datatable
        Dim registros As DataTable
        registros = New DataTable()
        Try
            Dim consulta As String = "SELECT " + campos + " FROM " + tabla + " WHERE " + condicion
            Comando = New OleDbCommand(consulta, conexion)
            Adaptador = New OleDbDataAdapter()
            Adaptador.SelectCommand = Comando
            Adaptador.Fill(registros) 'carga el datatable con el contenido de la consulta contenida en el dataadapter
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        Return registros
    End Function
    Public Function Actualizar(ByVal Upset As String, ByVal Tabla As String, ByVal Condicion As String) As Integer 'funcion para actualizar retorna entero
        Dim r As Integer = 0
        Try
            Dim consulta As String = "UPDATE " + Tabla + " SET " + Upset + " WHERE " + Condicion
            Comando = New OleDbCommand(consulta, conexion)
            r = Comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        Return r
    End Function
    Public Function Elminar(ByVal tabla As String, ByVal condicion As String) As Integer 'funcion para eliminar retorna entero
        Dim r As Integer
        Try
            Dim consulta As String = "DELETE FROM " + tabla + " WHERE " + condicion
            Comando = New OleDbCommand(consulta, conexion)
            r = Comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        Return r
    End Function

    Public Sub desconectar() 'metodo para cerrar la coneccion de la db
        conexion.Close()
    End Sub
End Class
