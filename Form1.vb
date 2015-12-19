'Formulario padre que contendra los formularios 
Public Class Form1

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        'Abro el formulario frmnuevo 
        frmnuevo.MdiParent = Me
        frmnuevo.StartPosition = FormStartPosition.Manual
        frmnuevo.ID = 0 'cambio el valor de la variable ID para que abra el frmnuevo para guardar
        frmnuevo.Show()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        'abro el formulario frmfiltrar
        frmFiltrar.MdiParent = Me
        frmFiltrar.StartPosition = FormStartPosition.Manual
        frmFiltrar.OPCION = 2 'cambio el valor de la variable OPCION para que abra en modo de actualizar
        frmFiltrar.Show()

    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        'abro el formulario frmfiltrar
        frmFiltrar.MdiParent = Me
        frmFiltrar.StartPosition = FormStartPosition.Manual
        frmFiltrar.OPCION = 1 'cambio el valor de la variable OPCION para que abra en filtro
        frmFiltrar.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        'abro el formulario frmfiltrar
        frmFiltrar.MdiParent = Me
        frmFiltrar.StartPosition = FormStartPosition.Manual
        frmFiltrar.OPCION = 3 'cambio el valor de la variable OPCION para que abra en modo de elminar
        frmFiltrar.Show()
    End Sub


    Private Sub VerAyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerAyudaToolStripMenuItem.Click
        Ayuda.Show()
    End Sub

    Private Sub AcercaDeAgendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeAgendaToolStripMenuItem.Click
        Acercade.MdiParent = Me
        Acercade.Show()
    End Sub

    Private Sub NuevaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaToolStripMenuItem.Click
        frmCitas.MdiParent = Me
        frmCitas.ID = 0
        frmCitas.StartPosition = FormStartPosition.Manual
        frmCitas.Show()
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem1.Click
        frmFiltrarCitas.MdiParent = Me
        frmFiltrarCitas.OPCION = 0
        frmFiltrarCitas.StartPosition = FormStartPosition.Manual
        frmFiltrarCitas.Show()

    End Sub

    Private Sub ActualizarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem1.Click
        frmFiltrarCitas.MdiParent = Me
        frmFiltrarCitas.OPCION = 2
        frmFiltrarCitas.StartPosition = FormStartPosition.Manual
        frmFiltrarCitas.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem1.Click
        frmFiltrarCitas.MdiParent = Me
        frmFiltrarCitas.OPCION = 3
        frmFiltrarCitas.StartPosition = FormStartPosition.Manual
        frmFiltrarCitas.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmRecordatorio.MdiParent = Me
        frmRecordatorio.Show()
    End Sub
End Class
