<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeAgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactoToolStripMenuItem, Me.CitasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(843, 35)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContactoToolStripMenuItem.Image = Global.AGENDA.My.Resources.Resources.contactos
        Me.ContactoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(103, 31)
        Me.ContactoToolStripMenuItem.Text = "&Contactos"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.AGENDA.My.Resources.Resources.nuevocontacto
        Me.NuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Image = Global.AGENDA.My.Resources.Resources.lupa
        Me.BuscarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.BuscarToolStripMenuItem.Text = "&Buscar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.AGENDA.My.Resources.Resources.actualizar
        Me.ActualizarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.ActualizarToolStripMenuItem.Text = "&Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.AGENDA.My.Resources.Resources.eliminar
        Me.EliminarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.EliminarToolStripMenuItem.Text = "&Eliminar"
        '
        'CitasToolStripMenuItem
        '
        Me.CitasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.BuscarToolStripMenuItem1, Me.ActualizarToolStripMenuItem1, Me.EliminarToolStripMenuItem1})
        Me.CitasToolStripMenuItem.Image = Global.AGENDA.My.Resources.Resources.citas
        Me.CitasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.CitasToolStripMenuItem.Name = "CitasToolStripMenuItem"
        Me.CitasToolStripMenuItem.Size = New System.Drawing.Size(69, 31)
        Me.CitasToolStripMenuItem.Text = "C&itas"
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Image = Global.AGENDA.My.Resources.Resources.ncita
        Me.NuevaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(144, 24)
        Me.NuevaToolStripMenuItem.Text = "N&ueva"
        '
        'BuscarToolStripMenuItem1
        '
        Me.BuscarToolStripMenuItem1.Image = Global.AGENDA.My.Resources.Resources.Bcita
        Me.BuscarToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.White
        Me.BuscarToolStripMenuItem1.Name = "BuscarToolStripMenuItem1"
        Me.BuscarToolStripMenuItem1.Size = New System.Drawing.Size(144, 24)
        Me.BuscarToolStripMenuItem1.Text = "B&uscar"
        '
        'ActualizarToolStripMenuItem1
        '
        Me.ActualizarToolStripMenuItem1.Image = Global.AGENDA.My.Resources.Resources.Mcita1
        Me.ActualizarToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.White
        Me.ActualizarToolStripMenuItem1.Name = "ActualizarToolStripMenuItem1"
        Me.ActualizarToolStripMenuItem1.Size = New System.Drawing.Size(144, 24)
        Me.ActualizarToolStripMenuItem1.Text = "Ac&tualizar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Image = Global.AGENDA.My.Resources.Resources.Ecita
        Me.EliminarToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.White
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(144, 24)
        Me.EliminarToolStripMenuItem1.Text = "E&liminar"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerAyudaToolStripMenuItem, Me.AcercaDeAgendaToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Image = Global.AGENDA.My.Resources.Resources.ayuda
        Me.AyudaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(79, 31)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'VerAyudaToolStripMenuItem
        '
        Me.VerAyudaToolStripMenuItem.Image = Global.AGENDA.My.Resources.Resources.verayuda
        Me.VerAyudaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.VerAyudaToolStripMenuItem.Name = "VerAyudaToolStripMenuItem"
        Me.VerAyudaToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.VerAyudaToolStripMenuItem.Text = "Ver Ayuda"
        '
        'AcercaDeAgendaToolStripMenuItem
        '
        Me.AcercaDeAgendaToolStripMenuItem.Image = Global.AGENDA.My.Resources.Resources.agenda
        Me.AcercaDeAgendaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.AcercaDeAgendaToolStripMenuItem.Name = "AcercaDeAgendaToolStripMenuItem"
        Me.AcercaDeAgendaToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.AcercaDeAgendaToolStripMenuItem.Text = "Acerca de Agenda"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AGENDA.My.Resources.Resources.blue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(843, 465)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "AGENDA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ContactoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CitasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerAyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeAgendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
