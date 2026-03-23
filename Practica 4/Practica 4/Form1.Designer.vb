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
        Me.components = New System.ComponentModel.Container()
        Me.Hora = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minutos = New System.Windows.Forms.Label()
        Me.Dias = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Segundos = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tiempo = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Hora
        '
        Me.Hora.AutoSize = True
        Me.Hora.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 65.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Hora.Location = New System.Drawing.Point(88, 109)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(140, 98)
        Me.Hora.TabIndex = 0
        Me.Hora.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 65.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(234, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 98)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'Minutos
        '
        Me.Minutos.AutoSize = True
        Me.Minutos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 65.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Minutos.Location = New System.Drawing.Point(306, 109)
        Me.Minutos.Name = "Minutos"
        Me.Minutos.Size = New System.Drawing.Size(140, 98)
        Me.Minutos.TabIndex = 2
        Me.Minutos.Text = "00"
        '
        'Dias
        '
        Me.Dias.AutoSize = True
        Me.Dias.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dias.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dias.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dias.Location = New System.Drawing.Point(200, 219)
        Me.Dias.Name = "Dias"
        Me.Dias.Size = New System.Drawing.Size(124, 37)
        Me.Dias.TabIndex = 3
        Me.Dias.Text = "Viernes"
        Me.Dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Fecha.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Fecha.Location = New System.Drawing.Point(110, 270)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(313, 37)
        Me.Fecha.TabIndex = 4
        Me.Fecha.Text = "13 de marzo del 2026"
        Me.Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox2.Image = Global.Practica_4.My.Resources.Resources.descarga
        Me.PictureBox2.Location = New System.Drawing.Point(398, 310)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Practica_4.My.Resources.Resources._1731664017_apple_watch_10_67371865a87cc1
        Me.PictureBox1.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(496, 436)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Segundos)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Location = New System.Drawing.Point(77, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 198)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'Segundos
        '
        Me.Segundos.AutoSize = True
        Me.Segundos.Location = New System.Drawing.Point(307, 25)
        Me.Segundos.Name = "Segundos"
        Me.Segundos.Size = New System.Drawing.Size(39, 13)
        Me.Segundos.TabIndex = 8
        Me.Segundos.Text = "Label2"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Blanco", "Rojo", "Azul", "Amarillo", "Verde"})
        Me.ComboBox1.Location = New System.Drawing.Point(121, 110)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(126, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(104, 14)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(162, 24)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Configuraciones"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Reset)
        Me.Panel2.Controls.Add(Me.Start)
        Me.Panel2.Controls.Add(Me.Tiempo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 198)
        Me.Panel2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cronometro"
        '
        'Tiempo
        '
        Me.Tiempo.AutoSize = True
        Me.Tiempo.Location = New System.Drawing.Point(37, 58)
        Me.Tiempo.Name = "Tiempo"
        Me.Tiempo.Size = New System.Drawing.Size(39, 13)
        Me.Tiempo.TabIndex = 1
        Me.Tiempo.Text = "Label3"
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(97, 117)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(71, 30)
        Me.Start.TabIndex = 3
        Me.Start.Text = "Button2"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(205, 117)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(83, 26)
        Me.Reset.TabIndex = 4
        Me.Reset.Text = "Button3"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.Dias)
        Me.Controls.Add(Me.Minutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Hora)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Reloj Digital"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Hora As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Minutos As Label
    Friend WithEvents Dias As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Segundos As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Reset As Button
    Friend WithEvents Start As Button
    Friend WithEvents Tiempo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer3 As Timer
End Class
