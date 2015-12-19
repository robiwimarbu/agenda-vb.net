<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCitas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtmFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbmContacto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtmHora = New System.Windows.Forms.DateTimePicker()
        Me.btnCitas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'DtmFecha
        '
        Me.DtmFecha.Location = New System.Drawing.Point(113, 47)
        Me.DtmFecha.Name = "DtmFecha"
        Me.DtmFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtmFecha.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contacto"
        '
        'CbmContacto
        '
        Me.CbmContacto.FormattingEnabled = True
        Me.CbmContacto.Location = New System.Drawing.Point(113, 120)
        Me.CbmContacto.Name = "CbmContacto"
        Me.CbmContacto.Size = New System.Drawing.Size(200, 21)
        Me.CbmContacto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hora"
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(113, 156)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(199, 20)
        Me.txtLugar.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Lugar"
        '
        'DtmHora
        '
        Me.DtmHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtmHora.Location = New System.Drawing.Point(113, 85)
        Me.DtmHora.Name = "DtmHora"
        Me.DtmHora.ShowUpDown = True
        Me.DtmHora.Size = New System.Drawing.Size(74, 20)
        Me.DtmHora.TabIndex = 8
        '
        'btnCitas
        '
        Me.btnCitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitas.Location = New System.Drawing.Point(27, 197)
        Me.btnCitas.Name = "btnCitas"
        Me.btnCitas.Size = New System.Drawing.Size(141, 28)
        Me.btnCitas.TabIndex = 9
        Me.btnCitas.Text = "Guardar"
        Me.btnCitas.UseVisualStyleBackColor = True
        '
        'frmCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 258)
        Me.Controls.Add(Me.btnCitas)
        Me.Controls.Add(Me.DtmHora)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLugar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbmContacto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtmFecha)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCitas"
        Me.Text = "Citas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtmFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbmContacto As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLugar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtmHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCitas As System.Windows.Forms.Button
End Class
