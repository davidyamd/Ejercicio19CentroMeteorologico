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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtRegionMenorPrecipitacion = New System.Windows.Forms.TextBox()
        Me.TxtMenorPrecipitacion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtTrimestralCentro = New System.Windows.Forms.TextBox()
        Me.TxtTrimestralOriente = New System.Windows.Forms.TextBox()
        Me.TxtTrimestralOccidente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCentroFebrero = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCentroMarzo = New System.Windows.Forms.TextBox()
        Me.TxtCentroEnero = New System.Windows.Forms.TextBox()
        Me.TxtOrienteMarzo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtOrienteFebrero = New System.Windows.Forms.TextBox()
        Me.TxtOrienteEnero = New System.Windows.Forms.TextBox()
        Me.TxtOccidenteMarzo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtOccidenteFebrero = New System.Windows.Forms.TextBox()
        Me.TxtOccidenteEnero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtRegionMayorPrecipitacion = New System.Windows.Forms.TextBox()
        Me.TxtMayorPrecipitacion = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Silver
        Me.BtnSalir.Location = New System.Drawing.Point(428, 259)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 45)
        Me.BtnSalir.TabIndex = 18
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.Color.Silver
        Me.BtnCalcular.Location = New System.Drawing.Point(340, 259)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(75, 45)
        Me.BtnCalcular.TabIndex = 17
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Silver
        Me.BtnLimpiar.Location = New System.Drawing.Point(252, 259)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 45)
        Me.BtnLimpiar.TabIndex = 16
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.TxtRegionMenorPrecipitacion)
        Me.GroupBox3.Controls.Add(Me.TxtMenorPrecipitacion)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 74)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Región con menor precipitación trimestral"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(277, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 24)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "l/m²"
        '
        'TxtRegionMenorPrecipitacion
        '
        Me.TxtRegionMenorPrecipitacion.BackColor = System.Drawing.SystemColors.Info
        Me.TxtRegionMenorPrecipitacion.Enabled = False
        Me.TxtRegionMenorPrecipitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegionMenorPrecipitacion.Location = New System.Drawing.Point(44, 30)
        Me.TxtRegionMenorPrecipitacion.Name = "TxtRegionMenorPrecipitacion"
        Me.TxtRegionMenorPrecipitacion.Size = New System.Drawing.Size(100, 28)
        Me.TxtRegionMenorPrecipitacion.TabIndex = 40
        '
        'TxtMenorPrecipitacion
        '
        Me.TxtMenorPrecipitacion.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMenorPrecipitacion.Enabled = False
        Me.TxtMenorPrecipitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMenorPrecipitacion.Location = New System.Drawing.Point(171, 30)
        Me.TxtMenorPrecipitacion.Name = "TxtMenorPrecipitacion"
        Me.TxtMenorPrecipitacion.Size = New System.Drawing.Size(100, 28)
        Me.TxtMenorPrecipitacion.TabIndex = 39
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(150, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 24)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = ":"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TxtTrimestralCentro)
        Me.GroupBox2.Controls.Add(Me.TxtTrimestralOriente)
        Me.GroupBox2.Controls.Add(Me.TxtTrimestralOccidente)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(576, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 155)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precipitación trimestral"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(122, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 17)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "l/m²"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(122, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 17)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "l/m²"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(122, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 17)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "l/m²"
        '
        'TxtTrimestralCentro
        '
        Me.TxtTrimestralCentro.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTrimestralCentro.Enabled = False
        Me.TxtTrimestralCentro.Location = New System.Drawing.Point(16, 118)
        Me.TxtTrimestralCentro.Name = "TxtTrimestralCentro"
        Me.TxtTrimestralCentro.Size = New System.Drawing.Size(100, 22)
        Me.TxtTrimestralCentro.TabIndex = 36
        '
        'TxtTrimestralOriente
        '
        Me.TxtTrimestralOriente.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTrimestralOriente.Enabled = False
        Me.TxtTrimestralOriente.Location = New System.Drawing.Point(16, 81)
        Me.TxtTrimestralOriente.Name = "TxtTrimestralOriente"
        Me.TxtTrimestralOriente.Size = New System.Drawing.Size(100, 22)
        Me.TxtTrimestralOriente.TabIndex = 35
        '
        'TxtTrimestralOccidente
        '
        Me.TxtTrimestralOccidente.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTrimestralOccidente.Enabled = False
        Me.TxtTrimestralOccidente.Location = New System.Drawing.Point(16, 44)
        Me.TxtTrimestralOccidente.Name = "TxtTrimestralOccidente"
        Me.TxtTrimestralOccidente.Size = New System.Drawing.Size(100, 22)
        Me.TxtTrimestralOccidente.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCentroFebrero)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtCentroMarzo)
        Me.GroupBox1.Controls.Add(Me.TxtCentroEnero)
        Me.GroupBox1.Controls.Add(Me.TxtOrienteMarzo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtOrienteFebrero)
        Me.GroupBox1.Controls.Add(Me.TxtOrienteEnero)
        Me.GroupBox1.Controls.Add(Me.TxtOccidenteMarzo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtOccidenteFebrero)
        Me.GroupBox1.Controls.Add(Me.TxtOccidenteEnero)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 155)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Precipitación mensual"
        '
        'TxtCentroFebrero
        '
        Me.TxtCentroFebrero.BackColor = System.Drawing.SystemColors.Info
        Me.TxtCentroFebrero.Location = New System.Drawing.Point(257, 118)
        Me.TxtCentroFebrero.Name = "TxtCentroFebrero"
        Me.TxtCentroFebrero.Size = New System.Drawing.Size(100, 22)
        Me.TxtCentroFebrero.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(439, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 15)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Marzo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(282, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 15)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Febrero"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(134, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Enero"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(516, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "l/m²"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(516, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "l/m²"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(363, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "l/m²"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(363, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "l/m²"
        '
        'TxtCentroMarzo
        '
        Me.TxtCentroMarzo.BackColor = System.Drawing.SystemColors.Info
        Me.TxtCentroMarzo.Location = New System.Drawing.Point(410, 118)
        Me.TxtCentroMarzo.Name = "TxtCentroMarzo"
        Me.TxtCentroMarzo.Size = New System.Drawing.Size(100, 22)
        Me.TxtCentroMarzo.TabIndex = 21
        '
        'TxtCentroEnero
        '
        Me.TxtCentroEnero.BackColor = System.Drawing.SystemColors.Info
        Me.TxtCentroEnero.Location = New System.Drawing.Point(104, 118)
        Me.TxtCentroEnero.Name = "TxtCentroEnero"
        Me.TxtCentroEnero.Size = New System.Drawing.Size(100, 22)
        Me.TxtCentroEnero.TabIndex = 19
        '
        'TxtOrienteMarzo
        '
        Me.TxtOrienteMarzo.BackColor = System.Drawing.SystemColors.Info
        Me.TxtOrienteMarzo.Location = New System.Drawing.Point(410, 81)
        Me.TxtOrienteMarzo.Name = "TxtOrienteMarzo"
        Me.TxtOrienteMarzo.Size = New System.Drawing.Size(100, 22)
        Me.TxtOrienteMarzo.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(516, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "l/m²"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(363, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "l/m²"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "l/m²"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "l/m²"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "l/m²"
        '
        'TxtOrienteFebrero
        '
        Me.TxtOrienteFebrero.BackColor = System.Drawing.SystemColors.Info
        Me.TxtOrienteFebrero.Location = New System.Drawing.Point(257, 81)
        Me.TxtOrienteFebrero.Name = "TxtOrienteFebrero"
        Me.TxtOrienteFebrero.Size = New System.Drawing.Size(100, 22)
        Me.TxtOrienteFebrero.TabIndex = 12
        '
        'TxtOrienteEnero
        '
        Me.TxtOrienteEnero.BackColor = System.Drawing.SystemColors.Info
        Me.TxtOrienteEnero.Location = New System.Drawing.Point(104, 81)
        Me.TxtOrienteEnero.Name = "TxtOrienteEnero"
        Me.TxtOrienteEnero.Size = New System.Drawing.Size(100, 22)
        Me.TxtOrienteEnero.TabIndex = 11
        '
        'TxtOccidenteMarzo
        '
        Me.TxtOccidenteMarzo.BackColor = System.Drawing.SystemColors.Info
        Me.TxtOccidenteMarzo.Location = New System.Drawing.Point(410, 44)
        Me.TxtOccidenteMarzo.Name = "TxtOccidenteMarzo"
        Me.TxtOccidenteMarzo.Size = New System.Drawing.Size(100, 22)
        Me.TxtOccidenteMarzo.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Centro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Oriente:"
        '
        'TxtOccidenteFebrero
        '
        Me.TxtOccidenteFebrero.BackColor = System.Drawing.SystemColors.Info
        Me.TxtOccidenteFebrero.Location = New System.Drawing.Point(257, 44)
        Me.TxtOccidenteFebrero.Name = "TxtOccidenteFebrero"
        Me.TxtOccidenteFebrero.Size = New System.Drawing.Size(100, 22)
        Me.TxtOccidenteFebrero.TabIndex = 6
        '
        'TxtOccidenteEnero
        '
        Me.TxtOccidenteEnero.BackColor = System.Drawing.SystemColors.Info
        Me.TxtOccidenteEnero.Location = New System.Drawing.Point(104, 44)
        Me.TxtOccidenteEnero.Name = "TxtOccidenteEnero"
        Me.TxtOccidenteEnero.Size = New System.Drawing.Size(100, 22)
        Me.TxtOccidenteEnero.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Occidente:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.TxtRegionMayorPrecipitacion)
        Me.GroupBox4.Controls.Add(Me.TxtMayorPrecipitacion)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(383, 173)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 74)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Región con mayor precipitación trimestral"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(277, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 24)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "l/m²"
        '
        'TxtRegionMayorPrecipitacion
        '
        Me.TxtRegionMayorPrecipitacion.BackColor = System.Drawing.SystemColors.Info
        Me.TxtRegionMayorPrecipitacion.Enabled = False
        Me.TxtRegionMayorPrecipitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegionMayorPrecipitacion.Location = New System.Drawing.Point(44, 30)
        Me.TxtRegionMayorPrecipitacion.Name = "TxtRegionMayorPrecipitacion"
        Me.TxtRegionMayorPrecipitacion.Size = New System.Drawing.Size(100, 28)
        Me.TxtRegionMayorPrecipitacion.TabIndex = 40
        '
        'TxtMayorPrecipitacion
        '
        Me.TxtMayorPrecipitacion.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMayorPrecipitacion.Enabled = False
        Me.TxtMayorPrecipitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMayorPrecipitacion.Location = New System.Drawing.Point(171, 30)
        Me.TxtMayorPrecipitacion.Name = "TxtMayorPrecipitacion"
        Me.TxtMayorPrecipitacion.Size = New System.Drawing.Size(100, 28)
        Me.TxtMayorPrecipitacion.TabIndex = 39
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(150, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 24)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = ":"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(755, 318)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnCalcular As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtRegionMenorPrecipitacion As System.Windows.Forms.TextBox
    Friend WithEvents TxtMenorPrecipitacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtTrimestralCentro As System.Windows.Forms.TextBox
    Friend WithEvents TxtTrimestralOriente As System.Windows.Forms.TextBox
    Friend WithEvents TxtTrimestralOccidente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCentroFebrero As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtCentroMarzo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCentroEnero As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrienteMarzo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtOrienteFebrero As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrienteEnero As System.Windows.Forms.TextBox
    Friend WithEvents TxtOccidenteMarzo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtOccidenteFebrero As System.Windows.Forms.TextBox
    Friend WithEvents TxtOccidenteEnero As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtRegionMayorPrecipitacion As System.Windows.Forms.TextBox
    Friend WithEvents TxtMayorPrecipitacion As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label

End Class
