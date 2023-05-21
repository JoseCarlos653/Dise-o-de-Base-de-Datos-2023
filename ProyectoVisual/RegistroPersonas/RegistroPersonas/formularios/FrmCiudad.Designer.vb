<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCiudad
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.GrbDatos = New System.Windows.Forms.GroupBox()
        Me.RBtnActivo = New System.Windows.Forms.RadioButton()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.GrbRegistros = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.DgvRegistros = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.GrbDatos.SuspendLayout()
        Me.GrbRegistros.SuspendLayout()
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.BtnGuardar, Me.BtnEditar, Me.BtnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(477, 27)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.RegistroPersonas.My.Resources.Resources.limpiar
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(29, 24)
        Me.btnNuevo.Text = "Nuevo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnGuardar.Image = Global.RegistroPersonas.My.Resources.Resources.agregar
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(29, 24)
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnEditar
        '
        Me.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditar.Image = Global.RegistroPersonas.My.Resources.Resources.editar
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(29, 24)
        Me.BtnEditar.Text = "Editar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEliminar.Image = Global.RegistroPersonas.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(29, 24)
        Me.BtnEliminar.Text = "Eliminar"
        '
        'GrbDatos
        '
        Me.GrbDatos.Controls.Add(Me.RBtnActivo)
        Me.GrbDatos.Controls.Add(Me.TxtId)
        Me.GrbDatos.Controls.Add(Me.Label2)
        Me.GrbDatos.Controls.Add(Me.Label1)
        Me.GrbDatos.Controls.Add(Me.TxtNombre)
        Me.GrbDatos.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbDatos.ForeColor = System.Drawing.Color.White
        Me.GrbDatos.Location = New System.Drawing.Point(11, 53)
        Me.GrbDatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrbDatos.Name = "GrbDatos"
        Me.GrbDatos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrbDatos.Size = New System.Drawing.Size(453, 158)
        Me.GrbDatos.TabIndex = 2
        Me.GrbDatos.TabStop = False
        Me.GrbDatos.Text = "Datos de la Ciudad"
        '
        'RBtnActivo
        '
        Me.RBtnActivo.AutoSize = True
        Me.RBtnActivo.Location = New System.Drawing.Point(343, 44)
        Me.RBtnActivo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RBtnActivo.Name = "RBtnActivo"
        Me.RBtnActivo.Size = New System.Drawing.Size(82, 27)
        Me.RBtnActivo.TabIndex = 7
        Me.RBtnActivo.TabStop = True
        Me.RBtnActivo.Text = "Activo"
        Me.RBtnActivo.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtId.Enabled = False
        Me.TxtId.ForeColor = System.Drawing.Color.Black
        Me.TxtId.Location = New System.Drawing.Point(133, 44)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(138, 30)
        Me.TxtId.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Código:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre:"
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombre.ForeColor = System.Drawing.Color.Black
        Me.TxtNombre.Location = New System.Drawing.Point(133, 101)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(293, 30)
        Me.TxtNombre.TabIndex = 3
        '
        'GrbRegistros
        '
        Me.GrbRegistros.Controls.Add(Me.BtnBuscar)
        Me.GrbRegistros.Controls.Add(Me.TxtValor)
        Me.GrbRegistros.Controls.Add(Me.DgvRegistros)
        Me.GrbRegistros.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrbRegistros.ForeColor = System.Drawing.Color.White
        Me.GrbRegistros.Location = New System.Drawing.Point(12, 249)
        Me.GrbRegistros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrbRegistros.Name = "GrbRegistros"
        Me.GrbRegistros.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GrbRegistros.Size = New System.Drawing.Size(453, 414)
        Me.GrbRegistros.TabIndex = 3
        Me.GrbRegistros.TabStop = False
        Me.GrbRegistros.Text = "Registros Guardados: 0"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Location = New System.Drawing.Point(312, 43)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(135, 32)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(7, 43)
        Me.TxtValor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(296, 30)
        Me.TxtValor.TabIndex = 1
        '
        'DgvRegistros
        '
        Me.DgvRegistros.AllowUserToAddRows = False
        Me.DgvRegistros.AllowUserToResizeColumns = False
        Me.DgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRegistros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvRegistros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.DgvRegistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRegistros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvRegistros.ColumnHeadersHeight = 30
        Me.DgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvRegistros.EnableHeadersVisualStyles = False
        Me.DgvRegistros.GridColor = System.Drawing.Color.SteelBlue
        Me.DgvRegistros.Location = New System.Drawing.Point(5, 107)
        Me.DgvRegistros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgvRegistros.Name = "DgvRegistros"
        Me.DgvRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRegistros.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvRegistros.RowHeadersVisible = False
        Me.DgvRegistros.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvRegistros.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvRegistros.RowTemplate.Height = 24
        Me.DgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRegistros.Size = New System.Drawing.Size(443, 293)
        Me.DgvRegistros.TabIndex = 0
        '
        'FrmCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(477, 672)
        Me.Controls.Add(Me.GrbRegistros)
        Me.Controls.Add(Me.GrbDatos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmCiudad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Ciudades"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GrbDatos.ResumeLayout(False)
        Me.GrbDatos.PerformLayout()
        Me.GrbRegistros.ResumeLayout(False)
        Me.GrbRegistros.PerformLayout()
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents GrbDatos As GroupBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents GrbRegistros As GroupBox
    Friend WithEvents DgvRegistros As DataGridView
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RBtnActivo As RadioButton
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents BtnBuscar As Button
End Class
