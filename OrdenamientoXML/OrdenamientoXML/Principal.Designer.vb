<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCarpeta = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.txtIngreso = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEgreso = New System.Windows.Forms.Label()
        Me.txtTraslado = New System.Windows.Forms.Label()
        Me.txtNomina = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.Label()
        Me.txtOtro = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 74)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 68)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ordenamiento XML"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.OrdenamientoXML.My.Resources.Resources.logo_13Ponientes
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(68, 68)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtCarpeta)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 78)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar carpeta:"
        '
        'txtCarpeta
        '
        Me.txtCarpeta.BackColor = System.Drawing.Color.White
        Me.txtCarpeta.Location = New System.Drawing.Point(23, 34)
        Me.txtCarpeta.Name = "txtCarpeta"
        Me.txtCarpeta.Size = New System.Drawing.Size(294, 30)
        Me.txtCarpeta.TabIndex = 0
        Me.txtCarpeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(323, 34)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 31)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.txtOtro)
        Me.GroupBox2.Controls.Add(Me.txtPago)
        Me.GroupBox2.Controls.Add(Me.txtNomina)
        Me.GroupBox2.Controls.Add(Me.txtTraslado)
        Me.GroupBox2.Controls.Add(Me.txtEgreso)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnIniciar)
        Me.GroupBox2.Controls.Add(Me.txtIngreso)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 214)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles de análisis de XML"
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.ForeColor = System.Drawing.Color.White
        Me.btnIniciar.Location = New System.Drawing.Point(274, 174)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(120, 31)
        Me.btnIniciar.TabIndex = 1
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'txtIngreso
        '
        Me.txtIngreso.BackColor = System.Drawing.Color.White
        Me.txtIngreso.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtIngreso.Location = New System.Drawing.Point(114, 33)
        Me.txtIngreso.Name = "txtIngreso"
        Me.txtIngreso.Size = New System.Drawing.Size(87, 25)
        Me.txtIngreso.TabIndex = 0
        Me.txtIngreso.Text = "0"
        Me.txtIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingreso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(23, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Egreso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(23, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Traslado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(23, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nómina:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(23, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Pago:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(23, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Otro:"
        '
        'txtEgreso
        '
        Me.txtEgreso.BackColor = System.Drawing.Color.White
        Me.txtEgreso.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtEgreso.Location = New System.Drawing.Point(114, 61)
        Me.txtEgreso.Name = "txtEgreso"
        Me.txtEgreso.Size = New System.Drawing.Size(87, 25)
        Me.txtEgreso.TabIndex = 8
        Me.txtEgreso.Text = "0"
        Me.txtEgreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTraslado
        '
        Me.txtTraslado.BackColor = System.Drawing.Color.White
        Me.txtTraslado.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtTraslado.Location = New System.Drawing.Point(114, 90)
        Me.txtTraslado.Name = "txtTraslado"
        Me.txtTraslado.Size = New System.Drawing.Size(87, 25)
        Me.txtTraslado.TabIndex = 9
        Me.txtTraslado.Text = "0"
        Me.txtTraslado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNomina
        '
        Me.txtNomina.BackColor = System.Drawing.Color.White
        Me.txtNomina.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtNomina.Location = New System.Drawing.Point(114, 119)
        Me.txtNomina.Name = "txtNomina"
        Me.txtNomina.Size = New System.Drawing.Size(87, 25)
        Me.txtNomina.TabIndex = 10
        Me.txtNomina.Text = "0"
        Me.txtNomina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPago
        '
        Me.txtPago.BackColor = System.Drawing.Color.White
        Me.txtPago.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtPago.Location = New System.Drawing.Point(114, 148)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(87, 25)
        Me.txtPago.TabIndex = 11
        Me.txtPago.Text = "0"
        Me.txtPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOtro
        '
        Me.txtOtro.BackColor = System.Drawing.Color.White
        Me.txtOtro.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtOtro.Location = New System.Drawing.Point(114, 177)
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.Size = New System.Drawing.Size(87, 25)
        Me.txtOtro.TabIndex = 12
        Me.txtOtro.Text = "0"
        Me.txtOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 399)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenar XML"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCarpeta As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtOtro As Label
    Friend WithEvents txtPago As Label
    Friend WithEvents txtNomina As Label
    Friend WithEvents txtTraslado As Label
    Friend WithEvents txtEgreso As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents txtIngreso As Label
End Class
