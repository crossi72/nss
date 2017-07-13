Public Class NSSGroupBox

    Private firstIteration As Boolean

    Public Event NSSInit()

	<System.ComponentModel.DefaultValue(False)> _
	Public Property NSSVisible() As Boolean
		Get
			Return Me.Visible
		End Get
		Set(ByVal value As Boolean)
			Me.Visible = value
			If value AndAlso Me.firstIteration Then
				Me.firstIteration = False
				RaiseEvent NSSInit()
			End If
		End Set
	End Property

    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
		Me.firstIteration = True
		If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Runtime Then
			Me.Visible = False
		End If
	End Sub
End Class
