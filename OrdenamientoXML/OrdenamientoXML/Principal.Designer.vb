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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCarpeta = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalXML = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtOtro = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.Label()
        Me.txtNomina = New System.Windows.Forms.Label()
        Me.txtTraslado = New System.Windows.Forms.Label()
        Me.txtEgreso = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIngreso = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalNuevos = New System.Windows.Forms.Label()
        Me.btnProgreso = New System.Windows.Forms.ProgressBar()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(431, 74)
        Me.Panel1.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtCarpeta)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 78)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar carpeta:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(337, 34)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 31)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtCarpeta
        '
        Me.txtCarpeta.BackColor = System.Drawing.Color.White
        Me.txtCarpeta.Location = New System.Drawing.Point(23, 34)
        Me.txtCarpeta.Name = "txtCarpeta"
        Me.txtCarpeta.Size = New System.Drawing.Size(308, 30)
        Me.txtCarpeta.TabIndex = 0
        Me.txtCarpeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.btnProgreso)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtTotalNuevos)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtTotalXML)
        Me.GroupBox2.Controls.Add(Me.btnIniciar)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(414, 252)
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
        Me.btnIniciar.Location = New System.Drawing.Point(288, 214)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(120, 31)
        Me.btnIniciar.TabIndex = 1
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(230, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Total XML análizados:"
        '
        'txtTotalXML
        '
        Me.txtTotalXML.BackColor = System.Drawing.Color.White
        Me.txtTotalXML.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtTotalXML.Location = New System.Drawing.Point(233, 134)
        Me.txtTotalXML.Name = "txtTotalXML"
        Me.txtTotalXML.Size = New System.Drawing.Size(174, 25)
        Me.txtTotalXML.TabIndex = 13
        Me.txtTotalXML.Text = "0"
        Me.txtTotalXML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.txtOtro)
        Me.GroupBox3.Controls.Add(Me.txtPago)
        Me.GroupBox3.Controls.Add(Me.txtNomina)
        Me.GroupBox3.Controls.Add(Me.txtTraslado)
        Me.GroupBox3.Controls.Add(Me.txtEgreso)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtIngreso)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 42)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(209, 203)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nuevos XML encontrados"
        '
        'txtOtro
        '
        Me.txtOtro.BackColor = System.Drawing.Color.White
        Me.txtOtro.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtOtro.Location = New System.Drawing.Point(106, 168)
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.Size = New System.Drawing.Size(87, 25)
        Me.txtOtro.TabIndex = 24
        Me.txtOtro.Text = "0"
        Me.txtOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPago
        '
        Me.txtPago.BackColor = System.Drawing.Color.White
        Me.txtPago.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtPago.Location = New System.Drawing.Point(106, 139)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(87, 25)
        Me.txtPago.TabIndex = 23
        Me.txtPago.Text = "0"
        Me.txtPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNomina
        '
        Me.txtNomina.BackColor = System.Drawing.Color.White
        Me.txtNomina.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtNomina.Location = New System.Drawing.Point(106, 110)
        Me.txtNomina.Name = "txtNomina"
        Me.txtNomina.Size = New System.Drawing.Size(87, 25)
        Me.txtNomina.TabIndex = 22
        Me.txtNomina.Text = "0"
        Me.txtNomina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTraslado
        '
        Me.txtTraslado.BackColor = System.Drawing.Color.White
        Me.txtTraslado.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtTraslado.Location = New System.Drawing.Point(106, 81)
        Me.txtTraslado.Name = "txtTraslado"
        Me.txtTraslado.Size = New System.Drawing.Size(87, 25)
        Me.txtTraslado.TabIndex = 21
        Me.txtTraslado.Text = "0"
        Me.txtTraslado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEgreso
        '
        Me.txtEgreso.BackColor = System.Drawing.Color.White
        Me.txtEgreso.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtEgreso.Location = New System.Drawing.Point(106, 52)
        Me.txtEgreso.Name = "txtEgreso"
        Me.txtEgreso.Size = New System.Drawing.Size(87, 25)
        Me.txtEgreso.TabIndex = 20
        Me.txtEgreso.Text = "0"
        Me.txtEgreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(15, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Otro:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(15, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Pago:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(15, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nómina:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(15, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Traslado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(15, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Egreso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(15, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ingreso:"
        '
        'txtIngreso
        '
        Me.txtIngreso.BackColor = System.Drawing.Color.White
        Me.txtIngreso.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtIngreso.Location = New System.Drawing.Point(106, 24)
        Me.txtIngreso.Name = "txtIngreso"
        Me.txtIngreso.Size = New System.Drawing.Size(87, 25)
        Me.txtIngreso.TabIndex = 13
        Me.txtIngreso.Text = "0"
        Me.txtIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(230, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 19)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Total Nuevos XML:"
        '
        'txtTotalNuevos
        '
        Me.txtTotalNuevos.BackColor = System.Drawing.Color.White
        Me.txtTotalNuevos.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtTotalNuevos.Location = New System.Drawing.Point(233, 66)
        Me.txtTotalNuevos.Name = "txtTotalNuevos"
        Me.txtTotalNuevos.Size = New System.Drawing.Size(174, 25)
        Me.txtTotalNuevos.TabIndex = 16
        Me.txtTotalNuevos.Text = "0"
        Me.txtTotalNuevos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProgreso
        '
        Me.btnProgreso.Location = New System.Drawing.Point(234, 172)
        Me.btnProgreso.Name = "btnProgreso"
        Me.btnProgreso.Size = New System.Drawing.Size(172, 30)
        Me.btnProgreso.Step = 1
        Me.btnProgreso.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.btnProgreso.TabIndex = 18
        Me.btnProgreso.Value = 100
        Me.btnProgreso.Visible = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 437)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenar XML"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCarpeta As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalXML As Label
    Friend WithEvents GroupBox3 As GroupBox
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
    Friend WithEvents txtIngreso As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalNuevos As Label
    Friend WithEvents btnProgreso As ProgressBar
End Class
