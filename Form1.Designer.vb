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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Pre1 = New System.Windows.Forms.Label()
		Me.Pre2 = New System.Windows.Forms.Label()
		Me.Pre3 = New System.Windows.Forms.Label()
		Me.Pre4 = New System.Windows.Forms.Label()
		Me.Pre5 = New System.Windows.Forms.Label()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.COLOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Button2 = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(12, 275)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(68, 70)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "CARGAR IMAGEN"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(421, 257)
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'Pre1
		'
		Me.Pre1.BackColor = System.Drawing.Color.Transparent
		Me.Pre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Pre1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Pre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Pre1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Pre1.Location = New System.Drawing.Point(86, 275)
		Me.Pre1.Name = "Pre1"
		Me.Pre1.Size = New System.Drawing.Size(71, 70)
		Me.Pre1.TabIndex = 7
		Me.Pre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Pre1.UseCompatibleTextRendering = True
		'
		'Pre2
		'
		Me.Pre2.BackColor = System.Drawing.Color.Transparent
		Me.Pre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Pre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Pre2.Location = New System.Drawing.Point(155, 275)
		Me.Pre2.Name = "Pre2"
		Me.Pre2.Size = New System.Drawing.Size(71, 70)
		Me.Pre2.TabIndex = 8
		Me.Pre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Pre3
		'
		Me.Pre3.BackColor = System.Drawing.Color.Transparent
		Me.Pre3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Pre3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Pre3.Location = New System.Drawing.Point(224, 275)
		Me.Pre3.Name = "Pre3"
		Me.Pre3.Size = New System.Drawing.Size(71, 70)
		Me.Pre3.TabIndex = 9
		Me.Pre3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Pre4
		'
		Me.Pre4.BackColor = System.Drawing.Color.Transparent
		Me.Pre4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Pre4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Pre4.Location = New System.Drawing.Point(293, 275)
		Me.Pre4.Name = "Pre4"
		Me.Pre4.Size = New System.Drawing.Size(71, 70)
		Me.Pre4.TabIndex = 10
		Me.Pre4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Pre5
		'
		Me.Pre5.BackColor = System.Drawing.Color.Transparent
		Me.Pre5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Pre5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Pre5.Location = New System.Drawing.Point(362, 275)
		Me.Pre5.Name = "Pre5"
		Me.Pre5.Size = New System.Drawing.Size(71, 70)
		Me.Pre5.TabIndex = 11
		Me.Pre5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COLOR, Me.CANTIDAD})
		Me.DataGridView1.Location = New System.Drawing.Point(523, 12)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.Size = New System.Drawing.Size(155, 333)
		Me.DataGridView1.TabIndex = 12
		'
		'COLOR
		'
		Me.COLOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.COLOR.HeaderText = "COLOR"
		Me.COLOR.Name = "COLOR"
		'
		'CANTIDAD
		'
		Me.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
		Me.CANTIDAD.HeaderText = "CANTIDAD"
		Me.CANTIDAD.Name = "CANTIDAD"
		Me.CANTIDAD.Width = 87
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(440, 12)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 333)
		Me.Button2.TabIndex = 13
		Me.Button2.Text = "CAMBIAR PALETA"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(523, 357)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Pre5)
		Me.Controls.Add(Me.Pre4)
		Me.Controls.Add(Me.Pre3)
		Me.Controls.Add(Me.Pre2)
		Me.Controls.Add(Me.Pre1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Button1)
		Me.Name = "Form1"
		Me.Text = "Palette Picker"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Button1 As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Pre1 As Label
	Friend WithEvents Pre2 As Label
	Friend WithEvents Pre3 As Label
	Friend WithEvents Pre4 As Label
	Friend WithEvents Pre5 As Label
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents COLOR As DataGridViewTextBoxColumn
	Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
	Friend WithEvents Button2 As Button
End Class
