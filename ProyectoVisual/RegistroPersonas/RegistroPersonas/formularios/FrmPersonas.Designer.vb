<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPersonas
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
        Dim IdPersonaLabel As System.Windows.Forms.Label
        Dim PrimerNombreLabel As System.Windows.Forms.Label
        Dim SegundoNombreLabel As System.Windows.Forms.Label
        Dim PrimerApellidoLabel As System.Windows.Forms.Label
        Dim SegundoApellidoLabel As System.Windows.Forms.Label
        Dim FechaNacLabel As System.Windows.Forms.Label
        Dim SexoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim IdCiudadLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Me.DSDBPrueba26 = New RegistroPersonas.DSDBPrueba26()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonaTableAdapter = New RegistroPersonas.DSDBPrueba26TableAdapters.PersonaTableAdapter()
        Me.TableAdapterManager = New RegistroPersonas.DSDBPrueba26TableAdapters.TableAdapterManager()
        Me.IdPersonaTextBox = New System.Windows.Forms.TextBox()
        Me.PrimerNombreTextBox = New System.Windows.Forms.TextBox()
        Me.SegundoNombreTextBox = New System.Windows.Forms.TextBox()
        Me.PrimerApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.SegundoApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ActivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.CmbIdCiudad = New System.Windows.Forms.ComboBox()
        IdPersonaLabel = New System.Windows.Forms.Label()
        PrimerNombreLabel = New System.Windows.Forms.Label()
        SegundoNombreLabel = New System.Windows.Forms.Label()
        PrimerApellidoLabel = New System.Windows.Forms.Label()
        SegundoApellidoLabel = New System.Windows.Forms.Label()
        FechaNacLabel = New System.Windows.Forms.Label()
        SexoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        IdCiudadLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CType(Me.DSDBPrueba26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdPersonaLabel
        '
        IdPersonaLabel.AutoSize = True
        IdPersonaLabel.Location = New System.Drawing.Point(71, 66)
        IdPersonaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdPersonaLabel.Name = "IdPersonaLabel"
        IdPersonaLabel.Size = New System.Drawing.Size(83, 19)
        IdPersonaLabel.TabIndex = 1
        IdPersonaLabel.Text = "id Persona:"
        '
        'PrimerNombreLabel
        '
        PrimerNombreLabel.AutoSize = True
        PrimerNombreLabel.Location = New System.Drawing.Point(365, 66)
        PrimerNombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrimerNombreLabel.Name = "PrimerNombreLabel"
        PrimerNombreLabel.Size = New System.Drawing.Size(119, 19)
        PrimerNombreLabel.TabIndex = 3
        PrimerNombreLabel.Text = "primer Nombre:"
        '
        'SegundoNombreLabel
        '
        SegundoNombreLabel.AutoSize = True
        SegundoNombreLabel.Location = New System.Drawing.Point(702, 66)
        SegundoNombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SegundoNombreLabel.Name = "SegundoNombreLabel"
        SegundoNombreLabel.Size = New System.Drawing.Size(130, 19)
        SegundoNombreLabel.TabIndex = 5
        SegundoNombreLabel.Text = "segundo Nombre:"
        '
        'PrimerApellidoLabel
        '
        PrimerApellidoLabel.AutoSize = True
        PrimerApellidoLabel.Location = New System.Drawing.Point(31, 127)
        PrimerApellidoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrimerApellidoLabel.Name = "PrimerApellidoLabel"
        PrimerApellidoLabel.Size = New System.Drawing.Size(120, 19)
        PrimerApellidoLabel.TabIndex = 7
        PrimerApellidoLabel.Text = "primer Apellido:"
        '
        'SegundoApellidoLabel
        '
        SegundoApellidoLabel.AutoSize = True
        SegundoApellidoLabel.Location = New System.Drawing.Point(353, 126)
        SegundoApellidoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SegundoApellidoLabel.Name = "SegundoApellidoLabel"
        SegundoApellidoLabel.Size = New System.Drawing.Size(131, 19)
        SegundoApellidoLabel.TabIndex = 9
        SegundoApellidoLabel.Text = "segundo Apellido:"
        '
        'FechaNacLabel
        '
        FechaNacLabel.AutoSize = True
        FechaNacLabel.Location = New System.Drawing.Point(753, 123)
        FechaNacLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaNacLabel.Name = "FechaNacLabel"
        FechaNacLabel.Size = New System.Drawing.Size(79, 19)
        FechaNacLabel.TabIndex = 11
        FechaNacLabel.Text = "fecha Nac:"
        '
        'SexoLabel
        '
        SexoLabel.AutoSize = True
        SexoLabel.Location = New System.Drawing.Point(108, 189)
        SexoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SexoLabel.Name = "SexoLabel"
        SexoLabel.Size = New System.Drawing.Size(44, 19)
        SexoLabel.TabIndex = 13
        SexoLabel.Text = "sexo:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(420, 189)
        TelefonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(69, 19)
        TelefonoLabel.TabIndex = 15
        TelefonoLabel.Text = "telefono:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(780, 189)
        CorreoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(58, 19)
        CorreoLabel.TabIndex = 17
        CorreoLabel.Text = "correo:"
        '
        'IdCiudadLabel
        '
        IdCiudadLabel.AutoSize = True
        IdCiudadLabel.Location = New System.Drawing.Point(79, 247)
        IdCiudadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdCiudadLabel.Name = "IdCiudadLabel"
        IdCiudadLabel.Size = New System.Drawing.Size(77, 19)
        IdCiudadLabel.TabIndex = 19
        IdCiudadLabel.Text = "id Ciudad:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(413, 247)
        DireccionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(75, 19)
        DireccionLabel.TabIndex = 21
        DireccionLabel.Text = "direccion:"
        '
        'DSDBPrueba26
        '
        Me.DSDBPrueba26.DataSetName = "DSDBPrueba26"
        Me.DSDBPrueba26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "Persona"
        Me.PersonaBindingSource.DataSource = Me.DSDBPrueba26
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CiudadTableAdapter = Nothing
        Me.TableAdapterManager.PersonaTableAdapter = Me.PersonaTableAdapter
        Me.TableAdapterManager.UpdateOrder = RegistroPersonas.DSDBPrueba26TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdPersonaTextBox
        '
        Me.IdPersonaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "idPersona", True))
        Me.IdPersonaTextBox.Location = New System.Drawing.Point(159, 61)
        Me.IdPersonaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdPersonaTextBox.Name = "IdPersonaTextBox"
        Me.IdPersonaTextBox.Size = New System.Drawing.Size(132, 26)
        Me.IdPersonaTextBox.TabIndex = 2
        '
        'PrimerNombreTextBox
        '
        Me.PrimerNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "primerNombre", True))
        Me.PrimerNombreTextBox.Location = New System.Drawing.Point(492, 61)
        Me.PrimerNombreTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PrimerNombreTextBox.Name = "PrimerNombreTextBox"
        Me.PrimerNombreTextBox.Size = New System.Drawing.Size(132, 26)
        Me.PrimerNombreTextBox.TabIndex = 4
        '
        'SegundoNombreTextBox
        '
        Me.SegundoNombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "segundoNombre", True))
        Me.SegundoNombreTextBox.Location = New System.Drawing.Point(841, 61)
        Me.SegundoNombreTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SegundoNombreTextBox.Name = "SegundoNombreTextBox"
        Me.SegundoNombreTextBox.Size = New System.Drawing.Size(132, 26)
        Me.SegundoNombreTextBox.TabIndex = 6
        '
        'PrimerApellidoTextBox
        '
        Me.PrimerApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "primerApellido", True))
        Me.PrimerApellidoTextBox.Location = New System.Drawing.Point(159, 123)
        Me.PrimerApellidoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PrimerApellidoTextBox.Name = "PrimerApellidoTextBox"
        Me.PrimerApellidoTextBox.Size = New System.Drawing.Size(132, 26)
        Me.PrimerApellidoTextBox.TabIndex = 8
        '
        'SegundoApellidoTextBox
        '
        Me.SegundoApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "segundoApellido", True))
        Me.SegundoApellidoTextBox.Location = New System.Drawing.Point(492, 123)
        Me.SegundoApellidoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SegundoApellidoTextBox.Name = "SegundoApellidoTextBox"
        Me.SegundoApellidoTextBox.Size = New System.Drawing.Size(132, 26)
        Me.SegundoApellidoTextBox.TabIndex = 10
        '
        'FechaNacDateTimePicker
        '
        Me.FechaNacDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PersonaBindingSource, "fechaNac", True))
        Me.FechaNacDateTimePicker.Location = New System.Drawing.Point(841, 117)
        Me.FechaNacDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaNacDateTimePicker.Name = "FechaNacDateTimePicker"
        Me.FechaNacDateTimePicker.Size = New System.Drawing.Size(265, 26)
        Me.FechaNacDateTimePicker.TabIndex = 12
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(492, 184)
        Me.TelefonoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(132, 26)
        Me.TelefonoTextBox.TabIndex = 16
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(841, 184)
        Me.CorreoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(265, 26)
        Me.CorreoTextBox.TabIndex = 18
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonaBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(492, 243)
        Me.DireccionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DireccionTextBox.Multiline = True
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DireccionTextBox.Size = New System.Drawing.Size(346, 87)
        Me.DireccionTextBox.TabIndex = 22
        '
        'ActivoCheckBox
        '
        Me.ActivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PersonaBindingSource, "activo", True))
        Me.ActivoCheckBox.Location = New System.Drawing.Point(967, 243)
        Me.ActivoCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ActivoCheckBox.Name = "ActivoCheckBox"
        Me.ActivoCheckBox.Size = New System.Drawing.Size(139, 35)
        Me.ActivoCheckBox.TabIndex = 24
        Me.ActivoCheckBox.Text = "Activo"
        Me.ActivoCheckBox.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.BtnGuardar, Me.BtnEditar, Me.BtnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1153, 27)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.RegistroPersonas.My.Resources.Resources.limpiar
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(24, 24)
        Me.btnNuevo.Text = "Nuevo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnGuardar.Image = Global.RegistroPersonas.My.Resources.Resources.agregar
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(24, 24)
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnEditar
        '
        Me.BtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditar.Image = Global.RegistroPersonas.My.Resources.Resources.editar
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(24, 24)
        Me.BtnEditar.Text = "Editar"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEliminar.Image = Global.RegistroPersonas.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(24, 24)
        Me.BtnEliminar.Text = "Eliminar"
        '
        'CmbSexo
        '
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.CmbSexo.Location = New System.Drawing.Point(159, 183)
        Me.CmbSexo.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(132, 27)
        Me.CmbSexo.TabIndex = 26
        '
        'CmbIdCiudad
        '
        Me.CmbIdCiudad.FormattingEnabled = True
        Me.CmbIdCiudad.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.CmbIdCiudad.Location = New System.Drawing.Point(159, 244)
        Me.CmbIdCiudad.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbIdCiudad.Name = "CmbIdCiudad"
        Me.CmbIdCiudad.Size = New System.Drawing.Size(132, 27)
        Me.CmbIdCiudad.TabIndex = 27
        '
        'FrmPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1153, 658)
        Me.Controls.Add(Me.CmbIdCiudad)
        Me.Controls.Add(Me.CmbSexo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ActivoCheckBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(IdCiudadLabel)
        Me.Controls.Add(CorreoLabel)
        Me.Controls.Add(Me.CorreoTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(SexoLabel)
        Me.Controls.Add(FechaNacLabel)
        Me.Controls.Add(Me.FechaNacDateTimePicker)
        Me.Controls.Add(SegundoApellidoLabel)
        Me.Controls.Add(Me.SegundoApellidoTextBox)
        Me.Controls.Add(PrimerApellidoLabel)
        Me.Controls.Add(Me.PrimerApellidoTextBox)
        Me.Controls.Add(SegundoNombreLabel)
        Me.Controls.Add(Me.SegundoNombreTextBox)
        Me.Controls.Add(PrimerNombreLabel)
        Me.Controls.Add(Me.PrimerNombreTextBox)
        Me.Controls.Add(IdPersonaLabel)
        Me.Controls.Add(Me.IdPersonaTextBox)
        Me.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPersonas"
        Me.Text = "FrmPersonas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DSDBPrueba26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSDBPrueba26 As DSDBPrueba26
    Friend WithEvents PersonaBindingSource As BindingSource
    Friend WithEvents PersonaTableAdapter As DSDBPrueba26TableAdapters.PersonaTableAdapter
    Friend WithEvents TableAdapterManager As DSDBPrueba26TableAdapters.TableAdapterManager
    Friend WithEvents IdPersonaTextBox As TextBox
    Friend WithEvents PrimerNombreTextBox As TextBox
    Friend WithEvents SegundoNombreTextBox As TextBox
    Friend WithEvents PrimerApellidoTextBox As TextBox
    Friend WithEvents SegundoApellidoTextBox As TextBox
    Friend WithEvents FechaNacDateTimePicker As DateTimePicker
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ActivoCheckBox As CheckBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents CmbIdCiudad As ComboBox
End Class
