<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgregarCliente))
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.TxtRuc = New System.Windows.Forms.TextBox()
        Me.TxtDirecion = New System.Windows.Forms.TextBox()
        Me.TxtFijo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtZona = New System.Windows.Forms.TextBox()
        Me.Txtcelular = New System.Windows.Forms.TextBox()
        Me.BtnEditar = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRazonSocial.Location = New System.Drawing.Point(12, 61)
        Me.TxtRazonSocial.MaxLength = 100
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(401, 20)
        Me.TxtRazonSocial.TabIndex = 1
        '
        'TxtRuc
        '
        Me.TxtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRuc.Location = New System.Drawing.Point(12, 110)
        Me.TxtRuc.MaxLength = 11
        Me.TxtRuc.Name = "TxtRuc"
        Me.TxtRuc.Size = New System.Drawing.Size(401, 20)
        Me.TxtRuc.TabIndex = 3
        '
        'TxtDirecion
        '
        Me.TxtDirecion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDirecion.Location = New System.Drawing.Point(12, 158)
        Me.TxtDirecion.MaxLength = 100
        Me.TxtDirecion.Name = "TxtDirecion"
        Me.TxtDirecion.Size = New System.Drawing.Size(401, 20)
        Me.TxtDirecion.TabIndex = 5
        '
        'TxtFijo
        '
        Me.TxtFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFijo.Location = New System.Drawing.Point(12, 242)
        Me.TxtFijo.MaxLength = 11
        Me.TxtFijo.Name = "TxtFijo"
        Me.TxtFijo.Size = New System.Drawing.Size(401, 20)
        Me.TxtFijo.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Razón Social"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RUC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Celular"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telefono Fijo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Zona"
        '
        'TxtZona
        '
        Me.TxtZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtZona.Location = New System.Drawing.Point(12, 291)
        Me.TxtZona.MaxLength = 50
        Me.TxtZona.Name = "TxtZona"
        Me.TxtZona.Size = New System.Drawing.Size(401, 20)
        Me.TxtZona.TabIndex = 11
        '
        'Txtcelular
        '
        Me.Txtcelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtcelular.Location = New System.Drawing.Point(12, 199)
        Me.Txtcelular.MaxLength = 11
        Me.Txtcelular.Name = "Txtcelular"
        Me.Txtcelular.Size = New System.Drawing.Size(401, 20)
        Me.Txtcelular.TabIndex = 7
        '
        'BtnEditar
        '
        Me.BtnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.BtnEditar.IconColor = System.Drawing.Color.Black
        Me.BtnEditar.IconSize = 32
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(166, 335)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Rotation = 0R
        Me.BtnEditar.Size = New System.Drawing.Size(76, 29)
        Me.BtnEditar.TabIndex = 12
        Me.BtnEditar.Text = "Aceptar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'FrmAgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 376)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.TxtZona)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFijo)
        Me.Controls.Add(Me.Txtcelular)
        Me.Controls.Add(Me.TxtDirecion)
        Me.Controls.Add(Me.TxtRuc)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents TxtRuc As TextBox
    Friend WithEvents TxtDirecion As TextBox
    Friend WithEvents TxtFijo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtZona As TextBox
    Friend WithEvents Txtcelular As TextBox
    Friend WithEvents BtnEditar As FontAwesome.Sharp.IconButton
End Class
