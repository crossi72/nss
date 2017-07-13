<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNegotiation
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    '<System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNegotiation))
		Me.btnNext = New System.Windows.Forms.Button()
		Me.btnPrev = New System.Windows.Forms.Button()
		Me.DatiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DSParameters = New MathematicaUI.parameters()
		Me.ParametersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ParametersTableAdapter = New MathematicaUI.parametersTableAdapters.parametersTableAdapter()
		Me.dsOldIraqiConstraints = New MathematicaUI.oldIraqiConstraints()
		Me.DataBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataTableAdapter1 = New MathematicaUI.oldIraqiConstraintsTableAdapters.dataTableAdapter()
		Me.dsOldTurkishConstraints = New MathematicaUI.oldTurkishConstraints()
		Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DSDefaultData = New MathematicaUI.NSSforTWJDataSet1()
		Me.DataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.TADefaultData = New MathematicaUI.NSSforTWJDataSet1TableAdapters.datiTableAdapter()
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
		Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.DAData = New System.Data.SqlClient.SqlDataAdapter()
		Me.DAParameters = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.DSData = New MathematicaUI.DSData()
		Me.DataTableAdapter = New MathematicaUI.oldTurkishConstraintsTableAdapters.dataTableAdapter()
		Me.grbCommonWaterIraq = New MathematicaUI.NSSGroupBox()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.lblIminagrwat = New System.Windows.Forms.Label()
		Me.nudIminagrwat = New System.Windows.Forms.NumericUpDown()
		Me.lblIindwat = New System.Windows.Forms.Label()
		Me.lblImaxagrwat = New System.Windows.Forms.Label()
		Me.nudImaxagrwat = New System.Windows.Forms.NumericUpDown()
		Me.nudIindwat = New System.Windows.Forms.NumericUpDown()
		Me.nudInavwat = New System.Windows.Forms.NumericUpDown()
		Me.lblInavwat = New System.Windows.Forms.Label()
		Me.lblIwatper = New System.Windows.Forms.Label()
		Me.nudIpop = New System.Windows.Forms.NumericUpDown()
		Me.lblIpop = New System.Windows.Forms.Label()
		Me.nudIwatper = New System.Windows.Forms.NumericUpDown()
		Me.grbCommonWaterTurkey = New MathematicaUI.NSSGroupBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label36 = New System.Windows.Forms.Label()
		Me.Label35 = New System.Windows.Forms.Label()
		Me.Label34 = New System.Windows.Forms.Label()
		Me.Label28 = New System.Windows.Forms.Label()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.lblTeva = New System.Windows.Forms.Label()
		Me.lblTindwat = New System.Windows.Forms.Label()
		Me.lblTmaxintwat = New System.Windows.Forms.Label()
		Me.lblTwatper = New System.Windows.Forms.Label()
		Me.lblTmaxagrwat = New System.Windows.Forms.Label()
		Me.lblTminagrwat = New System.Windows.Forms.Label()
		Me.nudTminagrwat = New System.Windows.Forms.NumericUpDown()
		Me.nudTeva = New System.Windows.Forms.NumericUpDown()
		Me.nudTindwat = New System.Windows.Forms.NumericUpDown()
		Me.lblTret = New System.Windows.Forms.Label()
		Me.lblTminenewat = New System.Windows.Forms.Label()
		Me.nudTret = New System.Windows.Forms.NumericUpDown()
		Me.nudTminenewat = New System.Windows.Forms.NumericUpDown()
		Me.nudTmaxintwat = New System.Windows.Forms.NumericUpDown()
		Me.lblTpop = New System.Windows.Forms.Label()
		Me.nudTpop = New System.Windows.Forms.NumericUpDown()
		Me.nudTwatper = New System.Windows.Forms.NumericUpDown()
		Me.nudTmaxagrwat = New System.Windows.Forms.NumericUpDown()
		Me.grbNegotiationOutcome = New MathematicaUI.NSSGroupBox()
		Me.pboOutcome = New System.Windows.Forms.PictureBox()
		Me.lblGraphLabel = New System.Windows.Forms.Label()
		Me.lblNegotiationOutcome = New System.Windows.Forms.Label()
		Me.grbConfidentialWaterTurkey = New MathematicaUI.NSSGroupBox()
		Me.btnTurkishDisagree = New System.Windows.Forms.Button()
		Me.btnTurkishAgree = New System.Windows.Forms.Button()
		Me.tcoTurkey = New System.Windows.Forms.TabControl()
		Me.tpaDataTurkey = New System.Windows.Forms.TabPage()
		Me.Label48 = New System.Windows.Forms.Label()
		Me.Label49 = New System.Windows.Forms.Label()
		Me.lblTnshDifPerF15 = New System.Windows.Forms.Label()
		Me.lblTnshDifPerF7 = New System.Windows.Forms.Label()
		Me.lblTnshDifPerF11 = New System.Windows.Forms.Label()
		Me.lblTnshDifPerF3 = New System.Windows.Forms.Label()
		Me.lblF17 = New System.Windows.Forms.Label()
		Me.lblF15 = New System.Windows.Forms.Label()
		Me.lblF7 = New System.Windows.Forms.Label()
		Me.lblF11 = New System.Windows.Forms.Label()
		Me.lblF3 = New System.Windows.Forms.Label()
		Me.lblTequDifPerF15 = New System.Windows.Forms.Label()
		Me.lblTequDifPerF7 = New System.Windows.Forms.Label()
		Me.lblTequDifPerF11 = New System.Windows.Forms.Label()
		Me.lblTequDifPerF3 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblF13 = New System.Windows.Forms.Label()
		Me.lblF5 = New System.Windows.Forms.Label()
		Me.lblF9 = New System.Windows.Forms.Label()
		Me.lblF1 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label31 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.lblAgriculture = New System.Windows.Forms.Label()
		Me.Label29 = New System.Windows.Forms.Label()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.lblOutcomes = New System.Windows.Forms.Label()
		Me.tpaGraph1Turkey = New System.Windows.Forms.TabPage()
		Me.pboTurkey1 = New System.Windows.Forms.PictureBox()
		Me.tpaGraph2Turkey = New System.Windows.Forms.TabPage()
		Me.pboTurkey2 = New System.Windows.Forms.PictureBox()
		Me.tpaGraph3Turkey = New System.Windows.Forms.TabPage()
		Me.pboTurkey3 = New System.Windows.Forms.PictureBox()
		Me.tpaGraph4Turkey = New System.Windows.Forms.TabPage()
		Me.pboTurkey4 = New System.Windows.Forms.PictureBox()
		Me.grbConfidentialWaterIraq = New MathematicaUI.NSSGroupBox()
		Me.tcoIraq = New System.Windows.Forms.TabControl()
		Me.tpaDataIraq = New System.Windows.Forms.TabPage()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.lblInshDifPerF16 = New System.Windows.Forms.Label()
		Me.lblInshDifPerF8 = New System.Windows.Forms.Label()
		Me.lblInshDifPerF12 = New System.Windows.Forms.Label()
		Me.lblInshDifPerF4 = New System.Windows.Forms.Label()
		Me.lblF18 = New System.Windows.Forms.Label()
		Me.lblF16 = New System.Windows.Forms.Label()
		Me.lblF8 = New System.Windows.Forms.Label()
		Me.lblF12 = New System.Windows.Forms.Label()
		Me.lblF4 = New System.Windows.Forms.Label()
		Me.lblIequDifPerF16 = New System.Windows.Forms.Label()
		Me.lblIequDifPerF8 = New System.Windows.Forms.Label()
		Me.lblIequDifPerF12 = New System.Windows.Forms.Label()
		Me.lblIequDifPerF4 = New System.Windows.Forms.Label()
		Me.Label58 = New System.Windows.Forms.Label()
		Me.Label59 = New System.Windows.Forms.Label()
		Me.Label60 = New System.Windows.Forms.Label()
		Me.Label61 = New System.Windows.Forms.Label()
		Me.lblF14 = New System.Windows.Forms.Label()
		Me.lblF6 = New System.Windows.Forms.Label()
		Me.lblF10 = New System.Windows.Forms.Label()
		Me.lblF2 = New System.Windows.Forms.Label()
		Me.Label66 = New System.Windows.Forms.Label()
		Me.Label67 = New System.Windows.Forms.Label()
		Me.Label68 = New System.Windows.Forms.Label()
		Me.Label69 = New System.Windows.Forms.Label()
		Me.Label70 = New System.Windows.Forms.Label()
		Me.Label71 = New System.Windows.Forms.Label()
		Me.Label72 = New System.Windows.Forms.Label()
		Me.Label73 = New System.Windows.Forms.Label()
		Me.Label74 = New System.Windows.Forms.Label()
		Me.Label75 = New System.Windows.Forms.Label()
		Me.Label76 = New System.Windows.Forms.Label()
		Me.Label77 = New System.Windows.Forms.Label()
		Me.Label78 = New System.Windows.Forms.Label()
		Me.tpaGraph1Iraq = New System.Windows.Forms.TabPage()
		Me.pboIraq1 = New System.Windows.Forms.PictureBox()
		Me.tpaGraph2Iraq = New System.Windows.Forms.TabPage()
		Me.pboIraq2 = New System.Windows.Forms.PictureBox()
		Me.tpaGraph3Iraq = New System.Windows.Forms.TabPage()
		Me.pboIraq3 = New System.Windows.Forms.PictureBox()
		Me.tpaGraph4Iraq = New System.Windows.Forms.TabPage()
		Me.pboIraq4 = New System.Windows.Forms.PictureBox()
		Me.btnIraqiDisagree = New System.Windows.Forms.Button()
		Me.btnIraqiAgree = New System.Windows.Forms.Button()
		Me.grbConfidentialIraq = New MathematicaUI.NSSGroupBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblInshError = New System.Windows.Forms.Label()
		Me.lblIsidpayError = New System.Windows.Forms.Label()
		Me.lblImarwatError = New System.Windows.Forms.Label()
		Me.nudImarwat = New System.Windows.Forms.NumericUpDown()
		Me.nudIsidpay = New System.Windows.Forms.NumericUpDown()
		Me.nudInsh = New System.Windows.Forms.NumericUpDown()
		Me.lblIsidpay = New System.Windows.Forms.Label()
		Me.lblImarwat = New System.Windows.Forms.Label()
		Me.lblInsh = New System.Windows.Forms.Label()
		Me.grbConfidentialTurkey = New MathematicaUI.NSSGroupBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.lblTmarwatError = New System.Windows.Forms.Label()
		Me.lblTnshError = New System.Windows.Forms.Label()
		Me.lblTsidpayError = New System.Windows.Forms.Label()
		Me.nudTmarwat = New System.Windows.Forms.NumericUpDown()
		Me.lblTmarwat = New System.Windows.Forms.Label()
		Me.nudTnsh = New System.Windows.Forms.NumericUpDown()
		Me.lblTnsh = New System.Windows.Forms.Label()
		Me.nudTsidpay = New System.Windows.Forms.NumericUpDown()
		Me.lblTsidpay = New System.Windows.Forms.Label()
		Me.grbCommonBenefitTurkey = New MathematicaUI.NSSGroupBox()
		Me.Label37 = New System.Windows.Forms.Label()
		Me.Label38 = New System.Windows.Forms.Label()
		Me.Label45 = New System.Windows.Forms.Label()
		Me.Label46 = New System.Windows.Forms.Label()
		Me.Label44 = New System.Windows.Forms.Label()
		Me.Label43 = New System.Windows.Forms.Label()
		Me.Label42 = New System.Windows.Forms.Label()
		Me.Label41 = New System.Windows.Forms.Label()
		Me.lblTmaxpolintc = New System.Windows.Forms.Label()
		Me.nudTmaxpolintc = New System.Windows.Forms.NumericUpDown()
		Me.nudTa = New System.Windows.Forms.NumericUpDown()
		Me.nudTc = New System.Windows.Forms.NumericUpDown()
		Me.nudTf = New System.Windows.Forms.NumericUpDown()
		Me.lblTc = New System.Windows.Forms.Label()
		Me.lblTa = New System.Windows.Forms.Label()
		Me.lblTf = New System.Windows.Forms.Label()
		Me.nudTd = New System.Windows.Forms.NumericUpDown()
		Me.nudTb = New System.Windows.Forms.NumericUpDown()
		Me.nudTe = New System.Windows.Forms.NumericUpDown()
		Me.lblTb = New System.Windows.Forms.Label()
		Me.nudTg = New System.Windows.Forms.NumericUpDown()
		Me.lblTe = New System.Windows.Forms.Label()
		Me.lblTg = New System.Windows.Forms.Label()
		Me.lblTd = New System.Windows.Forms.Label()
		Me.grbCommonBenefitsIraq = New MathematicaUI.NSSGroupBox()
		Me.Label51 = New System.Windows.Forms.Label()
		Me.Label50 = New System.Windows.Forms.Label()
		Me.Label47 = New System.Windows.Forms.Label()
		Me.nudIa = New System.Windows.Forms.NumericUpDown()
		Me.nudIb = New System.Windows.Forms.NumericUpDown()
		Me.nudIc = New System.Windows.Forms.NumericUpDown()
		Me.lblIa = New System.Windows.Forms.Label()
		Me.lblIb = New System.Windows.Forms.Label()
		Me.lblIc = New System.Windows.Forms.Label()
		Me.grbCommonBoth = New MathematicaUI.NSSGroupBox()
		Me.Label39 = New System.Windows.Forms.Label()
		Me.nudStotwat = New System.Windows.Forms.NumericUpDown()
		Me.lblStotwat = New System.Windows.Forms.Label()
		CType(Me.DatiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DSParameters, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ParametersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dsOldIraqiConstraints, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dsOldTurkishConstraints, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DSDefaultData, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DSData, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbCommonWaterIraq.SuspendLayout()
		CType(Me.nudIminagrwat, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudImaxagrwat, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudIindwat, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInavwat, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudIpop, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudIwatper, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbCommonWaterTurkey.SuspendLayout()
		CType(Me.nudTminagrwat, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTeva, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTindwat, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTret, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTminenewat, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTmaxintwat, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTpop, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTwatper, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTmaxagrwat, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbNegotiationOutcome.SuspendLayout()
		CType(Me.pboOutcome, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbConfidentialWaterTurkey.SuspendLayout()
		Me.tcoTurkey.SuspendLayout()
		Me.tpaDataTurkey.SuspendLayout()
		Me.tpaGraph1Turkey.SuspendLayout()
		CType(Me.pboTurkey1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph2Turkey.SuspendLayout()
		CType(Me.pboTurkey2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph3Turkey.SuspendLayout()
		CType(Me.pboTurkey3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph4Turkey.SuspendLayout()
		CType(Me.pboTurkey4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbConfidentialWaterIraq.SuspendLayout()
		Me.tcoIraq.SuspendLayout()
		Me.tpaDataIraq.SuspendLayout()
		Me.tpaGraph1Iraq.SuspendLayout()
		CType(Me.pboIraq1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph2Iraq.SuspendLayout()
		CType(Me.pboIraq2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph3Iraq.SuspendLayout()
		CType(Me.pboIraq3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.tpaGraph4Iraq.SuspendLayout()
		CType(Me.pboIraq4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbConfidentialIraq.SuspendLayout()
		CType(Me.nudImarwat, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudIsidpay, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudInsh, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbConfidentialTurkey.SuspendLayout()
		CType(Me.nudTmarwat, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTnsh, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTsidpay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbCommonBenefitTurkey.SuspendLayout()
		CType(Me.nudTmaxpolintc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTa, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTc, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTf, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTd, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTb, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTe, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudTg, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbCommonBenefitsIraq.SuspendLayout()
		CType(Me.nudIa, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudIb, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.nudIc, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.grbCommonBoth.SuspendLayout()
		CType(Me.nudStotwat, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnNext
		'
		Me.btnNext.Location = New System.Drawing.Point(360, 406)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(90, 36)
		Me.btnNext.TabIndex = 0
		Me.btnNext.Text = "Next"
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'btnPrev
		'
		Me.btnPrev.Location = New System.Drawing.Point(261, 406)
		Me.btnPrev.Name = "btnPrev"
		Me.btnPrev.Size = New System.Drawing.Size(90, 36)
		Me.btnPrev.TabIndex = 29
		Me.btnPrev.Text = "Previous"
		Me.btnPrev.UseVisualStyleBackColor = True
		'
		'DSParameters
		'
		Me.DSParameters.DataSetName = "parameters"
		Me.DSParameters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'ParametersBindingSource
		'
		Me.ParametersBindingSource.DataMember = "parameters"
		Me.ParametersBindingSource.DataSource = Me.DSParameters
		'
		'ParametersTableAdapter
		'
		Me.ParametersTableAdapter.ClearBeforeFill = True
		'
		'dsOldIraqiConstraints
		'
		Me.dsOldIraqiConstraints.DataSetName = "oldIraqiConstraints"
		Me.dsOldIraqiConstraints.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'DataBindingSource2
		'
		Me.DataBindingSource2.DataMember = "data"
		Me.DataBindingSource2.DataSource = Me.dsOldIraqiConstraints
		'
		'DataTableAdapter1
		'
		Me.DataTableAdapter1.ClearBeforeFill = True
		'
		'dsOldTurkishConstraints
		'
		Me.dsOldTurkishConstraints.DataSetName = "oldTurkishConstraints"
		Me.dsOldTurkishConstraints.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'DataBindingSource
		'
		Me.DataBindingSource.DataMember = "data"
		Me.DataBindingSource.DataSource = Me.dsOldTurkishConstraints
		'
		'DSDefaultData
		'
		Me.DSDefaultData.DataSetName = "NSSforTWJDataSet1"
		Me.DSDefaultData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'DataBindingSource1
		'
		Me.DataBindingSource1.DataMember = "dati"
		Me.DataBindingSource1.DataSource = Me.DSDefaultData
		'
		'TADefaultData
		'
		Me.TADefaultData.ClearBeforeFill = True
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
		Me.SqlSelectCommand1.Connection = Me.SqlConnection1
		'
		'SqlConnection1
		'
		Me.SqlConnection1.ConnectionString = "Data Source=MMSERVER\SQLEXPRESS;Initial Catalog=nss;Persist Security Info=True;Us" & _
	"er ID=NSS"
		Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
		'
		'SqlInsertCommand1
		'
		Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
		Me.SqlInsertCommand1.Connection = Me.SqlConnection1
		Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@datTmaxagrwat", System.Data.SqlDbType.Float, 0, "datTmaxagrwat"), New System.Data.SqlClient.SqlParameter("@datTminagrwat", System.Data.SqlDbType.Float, 0, "datTminagrwat"), New System.Data.SqlClient.SqlParameter("@datTindwat", System.Data.SqlDbType.Float, 0, "datTindwat"), New System.Data.SqlClient.SqlParameter("@datTminenewat", System.Data.SqlDbType.Float, 0, "datTminenewat"), New System.Data.SqlClient.SqlParameter("@datTmaxintwat", System.Data.SqlDbType.Float, 0, "datTmaxintwat"), New System.Data.SqlClient.SqlParameter("@datTpop", System.Data.SqlDbType.Float, 0, "datTpop"), New System.Data.SqlClient.SqlParameter("@datTwatper", System.Data.SqlDbType.Float, 0, "datTwatper"), New System.Data.SqlClient.SqlParameter("@datTpopwat", System.Data.SqlDbType.Float, 0, "datTpopwat"), New System.Data.SqlClient.SqlParameter("@datTeva", System.Data.SqlDbType.Float, 0, "datTeva"), New System.Data.SqlClient.SqlParameter("@datTret", System.Data.SqlDbType.Float, 0, "datTret"), New System.Data.SqlClient.SqlParameter("@datImaxagrwat", System.Data.SqlDbType.Float, 0, "datImaxagrwat"), New System.Data.SqlClient.SqlParameter("@datIminagrwat", System.Data.SqlDbType.Float, 0, "datIminagrwat"), New System.Data.SqlClient.SqlParameter("@datIindwat", System.Data.SqlDbType.Float, 0, "datIindwat"), New System.Data.SqlClient.SqlParameter("@datImarwat", System.Data.SqlDbType.Float, 0, "datImarwat"), New System.Data.SqlClient.SqlParameter("@datInavwat", System.Data.SqlDbType.Float, 0, "datInavwat"), New System.Data.SqlClient.SqlParameter("@datIpop", System.Data.SqlDbType.Float, 0, "datIpop"), New System.Data.SqlClient.SqlParameter("@datIwatper", System.Data.SqlDbType.Float, 0, "datIwatper"), New System.Data.SqlClient.SqlParameter("@datIpopwat", System.Data.SqlDbType.Float, 0, "datIpopwat"), New System.Data.SqlClient.SqlParameter("@datStotwat", System.Data.SqlDbType.Float, 0, "datStotwat"), New System.Data.SqlClient.SqlParameter("@datOwat", System.Data.SqlDbType.Float, 0, "datOwat"), New System.Data.SqlClient.SqlParameter("@datTa", System.Data.SqlDbType.Float, 0, "datTa"), New System.Data.SqlClient.SqlParameter("@datTb", System.Data.SqlDbType.Float, 0, "datTb"), New System.Data.SqlClient.SqlParameter("@datTc", System.Data.SqlDbType.Float, 0, "datTc"), New System.Data.SqlClient.SqlParameter("@datTd", System.Data.SqlDbType.Float, 0, "datTd"), New System.Data.SqlClient.SqlParameter("@datTe", System.Data.SqlDbType.Float, 0, "datTe"), New System.Data.SqlClient.SqlParameter("@datTg", System.Data.SqlDbType.Float, 0, "datTg"), New System.Data.SqlClient.SqlParameter("@datTf", System.Data.SqlDbType.Float, 0, "datTf"), New System.Data.SqlClient.SqlParameter("@datTmaxpolintc", System.Data.SqlDbType.Float, 0, "datTmaxpolintc"), New System.Data.SqlClient.SqlParameter("@datIa", System.Data.SqlDbType.Float, 0, "datIa"), New System.Data.SqlClient.SqlParameter("@datIb", System.Data.SqlDbType.Float, 0, "datIb"), New System.Data.SqlClient.SqlParameter("@datIc", System.Data.SqlDbType.Float, 0, "datIc"), New System.Data.SqlClient.SqlParameter("@datTmarwat", System.Data.SqlDbType.Float, 0, "datTmarwat"), New System.Data.SqlClient.SqlParameter("@datTnsh", System.Data.SqlDbType.Float, 0, "datTnsh"), New System.Data.SqlClient.SqlParameter("@datTsidpay", System.Data.SqlDbType.Float, 0, "datTsidpay"), New System.Data.SqlClient.SqlParameter("@datInsh", System.Data.SqlDbType.Float, 0, "datInsh"), New System.Data.SqlClient.SqlParameter("@datIsidpay", System.Data.SqlDbType.Float, 0, "datIsidpay"), New System.Data.SqlClient.SqlParameter("@datTagrwat", System.Data.SqlDbType.Float, 0, "datTagrwat"), New System.Data.SqlClient.SqlParameter("@datTnb", System.Data.SqlDbType.Float, 0, "datTnb"), New System.Data.SqlClient.SqlParameter("@datF1", System.Data.SqlDbType.Float, 0, "datF1"), New System.Data.SqlClient.SqlParameter("@datF2", System.Data.SqlDbType.Float, 0, "datF2"), New System.Data.SqlClient.SqlParameter("@datF3", System.Data.SqlDbType.Float, 0, "datF3"), New System.Data.SqlClient.SqlParameter("@datF4", System.Data.SqlDbType.Float, 0, "datF4"), New System.Data.SqlClient.SqlParameter("@datF5", System.Data.SqlDbType.Float, 0, "datF5"), New System.Data.SqlClient.SqlParameter("@datF6", System.Data.SqlDbType.Float, 0, "datF6"), New System.Data.SqlClient.SqlParameter("@datF7", System.Data.SqlDbType.Float, 0, "datF7"), New System.Data.SqlClient.SqlParameter("@datF8", System.Data.SqlDbType.Float, 0, "datF8"), New System.Data.SqlClient.SqlParameter("@datF9", System.Data.SqlDbType.Float, 0, "datF9"), New System.Data.SqlClient.SqlParameter("@datF10", System.Data.SqlDbType.Float, 0, "datF10"), New System.Data.SqlClient.SqlParameter("@datF11", System.Data.SqlDbType.Float, 0, "datF11"), New System.Data.SqlClient.SqlParameter("@datF12", System.Data.SqlDbType.Float, 0, "datF12"), New System.Data.SqlClient.SqlParameter("@datF13", System.Data.SqlDbType.Float, 0, "datF13"), New System.Data.SqlClient.SqlParameter("@datF14", System.Data.SqlDbType.Float, 0, "datF14"), New System.Data.SqlClient.SqlParameter("@datF15", System.Data.SqlDbType.Float, 0, "datF15"), New System.Data.SqlClient.SqlParameter("@datF16", System.Data.SqlDbType.Float, 0, "datF16"), New System.Data.SqlClient.SqlParameter("@datF17", System.Data.SqlDbType.Float, 0, "datF17"), New System.Data.SqlClient.SqlParameter("@datF18", System.Data.SqlDbType.Float, 0, "datF18"), New System.Data.SqlClient.SqlParameter("@datIequthr", System.Data.SqlDbType.Float, 0, "datIequthr"), New System.Data.SqlClient.SqlParameter("@datTequthr", System.Data.SqlDbType.Float, 0, "datTequthr"), New System.Data.SqlClient.SqlParameter("@datInshthr", System.Data.SqlDbType.Float, 0, "datInshthr"), New System.Data.SqlClient.SqlParameter("@datTnshthr", System.Data.SqlDbType.Float, 0, "datTnshthr"), New System.Data.SqlClient.SqlParameter("@datTequDifPerF3", System.Data.SqlDbType.Float, 0, "datTequDifPerF3"), New System.Data.SqlClient.SqlParameter("@datTequDifPerF7", System.Data.SqlDbType.Float, 0, "datTequDifPerF7"), New System.Data.SqlClient.SqlParameter("@datTequDifPerF11", System.Data.SqlDbType.Float, 0, "datTequDifPerF11"), New System.Data.SqlClient.SqlParameter("@datTequDifPerF15", System.Data.SqlDbType.Float, 0, "datTequDifPerF15"), New System.Data.SqlClient.SqlParameter("@datTnshDifPerF3", System.Data.SqlDbType.Float, 0, "datTnshDifPerF3"), New System.Data.SqlClient.SqlParameter("@datTnshDifPerF7", System.Data.SqlDbType.Float, 0, "datTnshDifPerF7"), New System.Data.SqlClient.SqlParameter("@datTnshDifPerF11", System.Data.SqlDbType.Float, 0, "datTnshDifPerF11"), New System.Data.SqlClient.SqlParameter("@datTnshDifPerF15", System.Data.SqlDbType.Float, 0, "datTnshDifPerF15"), New System.Data.SqlClient.SqlParameter("@datIequDifPerF4", System.Data.SqlDbType.Float, 0, "datIequDifPerF4"), New System.Data.SqlClient.SqlParameter("@datIequDifPerF8", System.Data.SqlDbType.Float, 0, "datIequDifPerF8"), New System.Data.SqlClient.SqlParameter("@datIequDifPerF12", System.Data.SqlDbType.Float, 0, "datIequDifPerF12"), New System.Data.SqlClient.SqlParameter("@datIequDifPerF16", System.Data.SqlDbType.Float, 0, "datIequDifPerF16"), New System.Data.SqlClient.SqlParameter("@datInshDifPerF4", System.Data.SqlDbType.Float, 0, "datInshDifPerF4"), New System.Data.SqlClient.SqlParameter("@datInshDifPerF8", System.Data.SqlDbType.Float, 0, "datInshDifPerF8"), New System.Data.SqlClient.SqlParameter("@datInshDifPerF12", System.Data.SqlDbType.Float, 0, "datInshDifPerF12"), New System.Data.SqlClient.SqlParameter("@datInshDifPerF16", System.Data.SqlDbType.Float, 0, "datInshDifPerF16"), New System.Data.SqlClient.SqlParameter("@datTurkishAgreement", System.Data.SqlDbType.Bit, 0, "datTurkishAgreement"), New System.Data.SqlClient.SqlParameter("@datIraqiAgreement", System.Data.SqlDbType.Bit, 0, "datIraqiAgreement"), New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 0, "DataCreazione"), New System.Data.SqlClient.SqlParameter("@UtenteCreazione", System.Data.SqlDbType.Int, 0, "UtenteCreazione"), New System.Data.SqlClient.SqlParameter("@DataAggiornamento", System.Data.SqlDbType.DateTime, 0, "DataAggiornamento"), New System.Data.SqlClient.SqlParameter("@UtenteAggiornamento", System.Data.SqlDbType.Int, 0, "UtenteAggiornamento"), New System.Data.SqlClient.SqlParameter("@Annullato", System.Data.SqlDbType.Bit, 0, "Annullato"), New System.Data.SqlClient.SqlParameter("@DataEstrazione", System.Data.SqlDbType.DateTime, 0, "DataEstrazione")})
		'
		'SqlUpdateCommand1
		'
		Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
		Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
		Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@datTmaxagrwat", System.Data.SqlDbType.Float, 0, "datTmaxagrwat"), New System.Data.SqlClient.SqlParameter("@datTminagrwat", System.Data.SqlDbType.Float, 0, "datTminagrwat"), New System.Data.SqlClient.SqlParameter("@datTindwat", System.Data.SqlDbType.Float, 0, "datTindwat"), New System.Data.SqlClient.SqlParameter("@datTminenewat", System.Data.SqlDbType.Float, 0, "datTminenewat"), New System.Data.SqlClient.SqlParameter("@datTmaxintwat", System.Data.SqlDbType.Float, 0, "datTmaxintwat"), New System.Data.SqlClient.SqlParameter("@datTpop", System.Data.SqlDbType.Float, 0, "datTpop"), New System.Data.SqlClient.SqlParameter("@datTwatper", System.Data.SqlDbType.Float, 0, "datTwatper"), New System.Data.SqlClient.SqlParameter("@datTpopwat", System.Data.SqlDbType.Float, 0, "datTpopwat"), New System.Data.SqlClient.SqlParameter("@datTeva", System.Data.SqlDbType.Float, 0, "datTeva"), New System.Data.SqlClient.SqlParameter("@datTret", System.Data.SqlDbType.Float, 0, "datTret"), New System.Data.SqlClient.SqlParameter("@datImaxagrwat", System.Data.SqlDbType.Float, 0, "datImaxagrwat"), New System.Data.SqlClient.SqlParameter("@datIminagrwat", System.Data.SqlDbType.Float, 0, "datIminagrwat"), New System.Data.SqlClient.SqlParameter("@datIindwat", System.Data.SqlDbType.Float, 0, "datIindwat"), New System.Data.SqlClient.SqlParameter("@datImarwat", System.Data.SqlDbType.Float, 0, "datImarwat"), New System.Data.SqlClient.SqlParameter("@datInavwat", System.Data.SqlDbType.Float, 0, "datInavwat"), New System.Data.SqlClient.SqlParameter("@datIpop", System.Data.SqlDbType.Float, 0, "datIpop"), New System.Data.SqlClient.SqlParameter("@datIwatper", System.Data.SqlDbType.Float, 0, "datIwatper"), New System.Data.SqlClient.SqlParameter("@datIpopwat", System.Data.SqlDbType.Float, 0, "datIpopwat"), New System.Data.SqlClient.SqlParameter("@datStotwat", System.Data.SqlDbType.Float, 0, "datStotwat"), New System.Data.SqlClient.SqlParameter("@datOwat", System.Data.SqlDbType.Float, 0, "datOwat"), New System.Data.SqlClient.SqlParameter("@datTa", System.Data.SqlDbType.Float, 0, "datTa"), New System.Data.SqlClient.SqlParameter("@datTb", System.Data.SqlDbType.Float, 0, "datTb"), New System.Data.SqlClient.SqlParameter("@datTc", System.Data.SqlDbType.Float, 0, "datTc"), New System.Data.SqlClient.SqlParameter("@datTd", System.Data.SqlDbType.Float, 0, "datTd"), New System.Data.SqlClient.SqlParameter("@datTe", System.Data.SqlDbType.Float, 0, "datTe"), New System.Data.SqlClient.SqlParameter("@datTg", System.Data.SqlDbType.Float, 0, "datTg"), New System.Data.SqlClient.SqlParameter("@datTf", System.Data.SqlDbType.Float, 0, "datTf"), New System.Data.SqlClient.SqlParameter("@datTmaxpolintc", System.Data.SqlDbType.Float, 0, "datTmaxpolintc"), New System.Data.SqlClient.SqlParameter("@datIa", System.Data.SqlDbType.Float, 0, "datIa"), New System.Data.SqlClient.SqlParameter("@datIb", System.Data.SqlDbType.Float, 0, "datIb"), New System.Data.SqlClient.SqlParameter("@datIc", System.Data.SqlDbType.Float, 0, "datIc"), New System.Data.SqlClient.SqlParameter("@datTmarwat", System.Data.SqlDbType.Float, 0, "datTmarwat"), New System.Data.SqlClient.SqlParameter("@datTnsh", System.Data.SqlDbType.Float, 0, "datTnsh"), New System.Data.SqlClient.SqlParameter("@datTsidpay", System.Data.SqlDbType.Float, 0, "datTsidpay"), New System.Data.SqlClient.SqlParameter("@datInsh", System.Data.SqlDbType.Float, 0, "datInsh"), New System.Data.SqlClient.SqlParameter("@datIsidpay", System.Data.SqlDbType.Float, 0, "datIsidpay"), New System.Data.SqlClient.SqlParameter("@datTagrwat", System.Data.SqlDbType.Float, 0, "datTagrwat"), New System.Data.SqlClient.SqlParameter("@datTnb", System.Data.SqlDbType.Float, 0, "datTnb"), New System.Data.SqlClient.SqlParameter("@datF1", System.Data.SqlDbType.Float, 0, "datF1"), New System.Data.SqlClient.SqlParameter("@datF2", System.Data.SqlDbType.Float, 0, "datF2"), New System.Data.SqlClient.SqlParameter("@datF3", System.Data.SqlDbType.Float, 0, "datF3"), New System.Data.SqlClient.SqlParameter("@datF4", System.Data.SqlDbType.Float, 0, "datF4"), New System.Data.SqlClient.SqlParameter("@datF5", System.Data.SqlDbType.Float, 0, "datF5"), New System.Data.SqlClient.SqlParameter("@datF6", System.Data.SqlDbType.Float, 0, "datF6"), New System.Data.SqlClient.SqlParameter("@datF7", System.Data.SqlDbType.Float, 0, "datF7"), New System.Data.SqlClient.SqlParameter("@datF8", System.Data.SqlDbType.Float, 0, "datF8"), New System.Data.SqlClient.SqlParameter("@datF9", System.Data.SqlDbType.Float, 0, "datF9"), New System.Data.SqlClient.SqlParameter("@datF10", System.Data.SqlDbType.Float, 0, "datF10"), New System.Data.SqlClient.SqlParameter("@datF11", System.Data.SqlDbType.Float, 0, "datF11"), New System.Data.SqlClient.SqlParameter("@datF12", System.Data.SqlDbType.Float, 0, "datF12"), New System.Data.SqlClient.SqlParameter("@datF13", System.Data.SqlDbType.Float, 0, "datF13"), New System.Data.SqlClient.SqlParameter("@datF14", System.Data.SqlDbType.Float, 0, "datF14"), New System.Data.SqlClient.SqlParameter("@datF15", System.Data.SqlDbType.Float, 0, "datF15"), New System.Data.SqlClient.SqlParameter("@datF16", System.Data.SqlDbType.Float, 0, "datF16"), New System.Data.SqlClient.SqlParameter("@datF17", System.Data.SqlDbType.Float, 0, "datF17"), New System.Data.SqlClient.SqlParameter("@datF18", System.Data.SqlDbType.Float, 0, "datF18"), New System.Data.SqlClient.SqlParameter("@datIequthr", System.Data.SqlDbType.Float, 0, "datIequthr"), New System.Data.SqlClient.SqlParameter("@datTequthr", System.Data.SqlDbType.Float, 0, "datTequthr"), New System.Data.SqlClient.SqlParameter("@datInshthr", System.Data.SqlDbType.Float, 0, "datInshthr"), New System.Data.SqlClient.SqlParameter("@datTnshthr", System.Data.SqlDbType.Float, 0, "datTnshthr"), New System.Data.SqlClient.SqlParameter("@datTequDifPerF3", System.Data.SqlDbType.Float, 0, "datTequDifPerF3"), New System.Data.SqlClient.SqlParameter("@datTequDifPerF7", System.Data.SqlDbType.Float, 0, "datTequDifPerF7"), New System.Data.SqlClient.SqlParameter("@datTequDifPerF11", System.Data.SqlDbType.Float, 0, "datTequDifPerF11"), New System.Data.SqlClient.SqlParameter("@datTequDifPerF15", System.Data.SqlDbType.Float, 0, "datTequDifPerF15"), New System.Data.SqlClient.SqlParameter("@datTnshDifPerF3", System.Data.SqlDbType.Float, 0, "datTnshDifPerF3"), New System.Data.SqlClient.SqlParameter("@datTnshDifPerF7", System.Data.SqlDbType.Float, 0, "datTnshDifPerF7"), New System.Data.SqlClient.SqlParameter("@datTnshDifPerF11", System.Data.SqlDbType.Float, 0, "datTnshDifPerF11"), New System.Data.SqlClient.SqlParameter("@datTnshDifPerF15", System.Data.SqlDbType.Float, 0, "datTnshDifPerF15"), New System.Data.SqlClient.SqlParameter("@datIequDifPerF4", System.Data.SqlDbType.Float, 0, "datIequDifPerF4"), New System.Data.SqlClient.SqlParameter("@datIequDifPerF8", System.Data.SqlDbType.Float, 0, "datIequDifPerF8"), New System.Data.SqlClient.SqlParameter("@datIequDifPerF12", System.Data.SqlDbType.Float, 0, "datIequDifPerF12"), New System.Data.SqlClient.SqlParameter("@datIequDifPerF16", System.Data.SqlDbType.Float, 0, "datIequDifPerF16"), New System.Data.SqlClient.SqlParameter("@datInshDifPerF4", System.Data.SqlDbType.Float, 0, "datInshDifPerF4"), New System.Data.SqlClient.SqlParameter("@datInshDifPerF8", System.Data.SqlDbType.Float, 0, "datInshDifPerF8"), New System.Data.SqlClient.SqlParameter("@datInshDifPerF12", System.Data.SqlDbType.Float, 0, "datInshDifPerF12"), New System.Data.SqlClient.SqlParameter("@datInshDifPerF16", System.Data.SqlDbType.Float, 0, "datInshDifPerF16"), New System.Data.SqlClient.SqlParameter("@datTurkishAgreement", System.Data.SqlDbType.Bit, 0, "datTurkishAgreement"), New System.Data.SqlClient.SqlParameter("@datIraqiAgreement", System.Data.SqlDbType.Bit, 0, "datIraqiAgreement"), New System.Data.SqlClient.SqlParameter("@DataCreazione", System.Data.SqlDbType.DateTime, 0, "DataCreazione"), New System.Data.SqlClient.SqlParameter("@UtenteCreazione", System.Data.SqlDbType.Int, 0, "UtenteCreazione"), New System.Data.SqlClient.SqlParameter("@DataAggiornamento", System.Data.SqlDbType.DateTime, 0, "DataAggiornamento"), New System.Data.SqlClient.SqlParameter("@UtenteAggiornamento", System.Data.SqlDbType.Int, 0, "UtenteAggiornamento"), New System.Data.SqlClient.SqlParameter("@Annullato", System.Data.SqlDbType.Bit, 0, "Annullato"), New System.Data.SqlClient.SqlParameter("@DataEstrazione", System.Data.SqlDbType.DateTime, 0, "DataEstrazione"), New System.Data.SqlClient.SqlParameter("@IsNull_datTmaxagrwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTmaxagrwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTmaxagrwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTmaxagrwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTminagrwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTminagrwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTminagrwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTminagrwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTindwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTindwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTindwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTindwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTminenewat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTminenewat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTminenewat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTminenewat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTmaxintwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTmaxintwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTmaxintwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTmaxintwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTpop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTpop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTpop", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTpop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTwatper", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTwatper", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTwatper", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTwatper", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTpopwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTpopwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTpopwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTpopwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTeva", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTeva", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTeva", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTeva", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTret", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTret", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTret", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTret", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datImaxagrwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datImaxagrwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datImaxagrwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datImaxagrwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIminagrwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIminagrwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIminagrwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIminagrwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIindwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIindwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIindwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIindwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datImarwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datImarwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datImarwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datImarwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInavwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInavwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInavwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInavwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIpop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIpop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIpop", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIpop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIwatper", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIwatper", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIwatper", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIwatper", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIpopwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIpopwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIpopwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIpopwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datStotwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datStotwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datStotwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datStotwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datOwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datOwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datOwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datOwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTa", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTa", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTb", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTb", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTb", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTb", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTc", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTd", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTd", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTd", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTd", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTe", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTg", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTg", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTg", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTg", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTf", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTf", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTmaxpolintc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTmaxpolintc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTmaxpolintc", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTmaxpolintc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIa", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIa", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIb", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIb", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIb", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIb", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIc", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTmarwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTmarwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTmarwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTmarwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnsh", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnsh", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnsh", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnsh", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTsidpay", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTsidpay", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTsidpay", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTsidpay", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInsh", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInsh", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInsh", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInsh", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIsidpay", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIsidpay", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIsidpay", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIsidpay", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTagrwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTagrwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTagrwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTagrwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnb", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnb", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnb", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnb", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF5", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF6", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF9", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF9", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF9", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF10", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF10", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF10", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF13", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF13", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF13", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF13", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF14", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF14", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF14", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF14", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF15", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF15", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF15", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF16", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF16", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF16", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF16", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF17", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF17", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF17", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF17", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF18", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF18", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF18", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF18", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIequthr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIequthr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIequthr", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIequthr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTequthr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTequthr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTequthr", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTequthr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInshthr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInshthr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInshthr", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInshthr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnshthr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnshthr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnshthr", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnshthr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTequDifPerF3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTequDifPerF3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTequDifPerF3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTequDifPerF3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTequDifPerF7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTequDifPerF7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTequDifPerF7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTequDifPerF7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTequDifPerF11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTequDifPerF11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTequDifPerF11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTequDifPerF11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTequDifPerF15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTequDifPerF15", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTequDifPerF15", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTequDifPerF15", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnshDifPerF3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnshDifPerF3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnshDifPerF3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnshDifPerF3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnshDifPerF7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnshDifPerF7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnshDifPerF7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnshDifPerF7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnshDifPerF11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnshDifPerF11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnshDifPerF11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnshDifPerF11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnshDifPerF15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnshDifPerF15", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnshDifPerF15", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnshDifPerF15", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIequDifPerF4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIequDifPerF4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIequDifPerF4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIequDifPerF4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIequDifPerF8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIequDifPerF8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIequDifPerF8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIequDifPerF8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIequDifPerF12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIequDifPerF12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIequDifPerF12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIequDifPerF12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIequDifPerF16", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIequDifPerF16", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIequDifPerF16", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIequDifPerF16", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInshDifPerF4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInshDifPerF4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInshDifPerF4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInshDifPerF4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInshDifPerF8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInshDifPerF8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInshDifPerF8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInshDifPerF8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInshDifPerF12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInshDifPerF12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInshDifPerF12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInshDifPerF12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInshDifPerF16", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInshDifPerF16", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInshDifPerF16", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInshDifPerF16", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTurkishAgreement", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTurkishAgreement", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTurkishAgreement", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTurkishAgreement", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIraqiAgreement", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIraqiAgreement", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIraqiAgreement", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIraqiAgreement", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataCreazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UtenteCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UtenteCreazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UtenteCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UtenteCreazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataAggiornamento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataAggiornamento", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataAggiornamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UtenteAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UtenteAggiornamento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UtenteAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UtenteAggiornamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Annullato", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Annullato", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Annullato", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Annullato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataEstrazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataEstrazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataEstrazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataEstrazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_datID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@datID", System.Data.SqlDbType.Int, 4, "datID")})
		'
		'SqlDeleteCommand1
		'
		Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
		Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
		Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IsNull_datTmaxagrwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTmaxagrwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTmaxagrwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTmaxagrwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTminagrwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTminagrwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTminagrwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTminagrwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTindwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTindwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTindwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTindwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTminenewat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTminenewat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTminenewat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTminenewat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTmaxintwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTmaxintwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTmaxintwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTmaxintwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTpop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTpop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTpop", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTpop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTwatper", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTwatper", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTwatper", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTwatper", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTpopwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTpopwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTpopwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTpopwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTeva", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTeva", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTeva", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTeva", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTret", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTret", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTret", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTret", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datImaxagrwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datImaxagrwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datImaxagrwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datImaxagrwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIminagrwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIminagrwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIminagrwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIminagrwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIindwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIindwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIindwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIindwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datImarwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datImarwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datImarwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datImarwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInavwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInavwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInavwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInavwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIpop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIpop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIpop", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIpop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIwatper", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIwatper", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIwatper", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIwatper", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIpopwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIpopwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIpopwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIpopwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datStotwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datStotwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datStotwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datStotwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datOwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datOwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datOwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datOwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTa", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTa", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTb", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTb", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTb", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTb", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTc", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTd", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTd", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTd", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTd", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTe", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTg", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTg", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTg", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTg", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTf", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTf", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTf", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTmaxpolintc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTmaxpolintc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTmaxpolintc", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTmaxpolintc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIa", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIa", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIb", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIb", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIb", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIb", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIc", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIc", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTmarwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTmarwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTmarwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTmarwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnsh", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnsh", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnsh", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnsh", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTsidpay", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTsidpay", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTsidpay", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTsidpay", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInsh", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInsh", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInsh", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInsh", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIsidpay", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIsidpay", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIsidpay", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIsidpay", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTagrwat", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTagrwat", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTagrwat", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTagrwat", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnb", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnb", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnb", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnb", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF1", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF2", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF5", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF5", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF6", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF6", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF9", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF9", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF9", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF10", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF10", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF10", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF13", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF13", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF13", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF13", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF14", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF14", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF14", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF14", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF15", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF15", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF15", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF16", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF16", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF16", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF16", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF17", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF17", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF17", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF17", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datF18", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datF18", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datF18", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datF18", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIequthr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIequthr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIequthr", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIequthr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTequthr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTequthr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTequthr", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTequthr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInshthr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInshthr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInshthr", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInshthr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnshthr", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnshthr", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnshthr", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnshthr", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTequDifPerF3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTequDifPerF3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTequDifPerF3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTequDifPerF3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTequDifPerF7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTequDifPerF7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTequDifPerF7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTequDifPerF7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTequDifPerF11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTequDifPerF11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTequDifPerF11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTequDifPerF11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTequDifPerF15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTequDifPerF15", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTequDifPerF15", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTequDifPerF15", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnshDifPerF3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnshDifPerF3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnshDifPerF3", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnshDifPerF3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnshDifPerF7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnshDifPerF7", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnshDifPerF7", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnshDifPerF7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnshDifPerF11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnshDifPerF11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnshDifPerF11", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnshDifPerF11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTnshDifPerF15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTnshDifPerF15", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTnshDifPerF15", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTnshDifPerF15", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIequDifPerF4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIequDifPerF4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIequDifPerF4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIequDifPerF4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIequDifPerF8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIequDifPerF8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIequDifPerF8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIequDifPerF8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIequDifPerF12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIequDifPerF12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIequDifPerF12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIequDifPerF12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIequDifPerF16", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIequDifPerF16", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIequDifPerF16", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIequDifPerF16", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInshDifPerF4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInshDifPerF4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInshDifPerF4", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInshDifPerF4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInshDifPerF8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInshDifPerF8", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInshDifPerF8", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInshDifPerF8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInshDifPerF12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInshDifPerF12", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInshDifPerF12", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInshDifPerF12", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datInshDifPerF16", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datInshDifPerF16", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datInshDifPerF16", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datInshDifPerF16", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datTurkishAgreement", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datTurkishAgreement", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datTurkishAgreement", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datTurkishAgreement", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_datIraqiAgreement", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "datIraqiAgreement", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_datIraqiAgreement", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datIraqiAgreement", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataCreazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataCreazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UtenteCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UtenteCreazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UtenteCreazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UtenteCreazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataAggiornamento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataAggiornamento", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataAggiornamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_UtenteAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "UtenteAggiornamento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_UtenteAggiornamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UtenteAggiornamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Annullato", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Annullato", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Annullato", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Annullato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_DataEstrazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DataEstrazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_DataEstrazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DataEstrazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_datID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "datID", System.Data.DataRowVersion.Original, Nothing)})
		'
		'DAData
		'
		Me.DAData.DeleteCommand = Me.SqlDeleteCommand1
		Me.DAData.InsertCommand = Me.SqlInsertCommand1
		Me.DAData.SelectCommand = Me.SqlSelectCommand1
		Me.DAData.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "data", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("datTmaxagrwat", "datTmaxagrwat"), New System.Data.Common.DataColumnMapping("datTminagrwat", "datTminagrwat"), New System.Data.Common.DataColumnMapping("datTindwat", "datTindwat"), New System.Data.Common.DataColumnMapping("datTminenewat", "datTminenewat"), New System.Data.Common.DataColumnMapping("datTmaxintwat", "datTmaxintwat"), New System.Data.Common.DataColumnMapping("datTpop", "datTpop"), New System.Data.Common.DataColumnMapping("datTwatper", "datTwatper"), New System.Data.Common.DataColumnMapping("datTpopwat", "datTpopwat"), New System.Data.Common.DataColumnMapping("datTeva", "datTeva"), New System.Data.Common.DataColumnMapping("datTret", "datTret"), New System.Data.Common.DataColumnMapping("datImaxagrwat", "datImaxagrwat"), New System.Data.Common.DataColumnMapping("datIminagrwat", "datIminagrwat"), New System.Data.Common.DataColumnMapping("datIindwat", "datIindwat"), New System.Data.Common.DataColumnMapping("datImarwat", "datImarwat"), New System.Data.Common.DataColumnMapping("datInavwat", "datInavwat"), New System.Data.Common.DataColumnMapping("datIpop", "datIpop"), New System.Data.Common.DataColumnMapping("datIwatper", "datIwatper"), New System.Data.Common.DataColumnMapping("datIpopwat", "datIpopwat"), New System.Data.Common.DataColumnMapping("datStotwat", "datStotwat"), New System.Data.Common.DataColumnMapping("datOwat", "datOwat"), New System.Data.Common.DataColumnMapping("datTa", "datTa"), New System.Data.Common.DataColumnMapping("datTb", "datTb"), New System.Data.Common.DataColumnMapping("datTc", "datTc"), New System.Data.Common.DataColumnMapping("datTd", "datTd"), New System.Data.Common.DataColumnMapping("datTe", "datTe"), New System.Data.Common.DataColumnMapping("datTg", "datTg"), New System.Data.Common.DataColumnMapping("datTf", "datTf"), New System.Data.Common.DataColumnMapping("datTmaxpolintc", "datTmaxpolintc"), New System.Data.Common.DataColumnMapping("datIa", "datIa"), New System.Data.Common.DataColumnMapping("datIb", "datIb"), New System.Data.Common.DataColumnMapping("datIc", "datIc"), New System.Data.Common.DataColumnMapping("datTmarwat", "datTmarwat"), New System.Data.Common.DataColumnMapping("datTnsh", "datTnsh"), New System.Data.Common.DataColumnMapping("datTsidpay", "datTsidpay"), New System.Data.Common.DataColumnMapping("datInsh", "datInsh"), New System.Data.Common.DataColumnMapping("datIsidpay", "datIsidpay"), New System.Data.Common.DataColumnMapping("datTagrwat", "datTagrwat"), New System.Data.Common.DataColumnMapping("datTnb", "datTnb"), New System.Data.Common.DataColumnMapping("datF1", "datF1"), New System.Data.Common.DataColumnMapping("datF2", "datF2"), New System.Data.Common.DataColumnMapping("datF3", "datF3"), New System.Data.Common.DataColumnMapping("datF4", "datF4"), New System.Data.Common.DataColumnMapping("datF5", "datF5"), New System.Data.Common.DataColumnMapping("datF6", "datF6"), New System.Data.Common.DataColumnMapping("datF7", "datF7"), New System.Data.Common.DataColumnMapping("datF8", "datF8"), New System.Data.Common.DataColumnMapping("datF9", "datF9"), New System.Data.Common.DataColumnMapping("datF10", "datF10"), New System.Data.Common.DataColumnMapping("datF11", "datF11"), New System.Data.Common.DataColumnMapping("datF12", "datF12"), New System.Data.Common.DataColumnMapping("datF13", "datF13"), New System.Data.Common.DataColumnMapping("datF14", "datF14"), New System.Data.Common.DataColumnMapping("datF15", "datF15"), New System.Data.Common.DataColumnMapping("datF16", "datF16"), New System.Data.Common.DataColumnMapping("datF17", "datF17"), New System.Data.Common.DataColumnMapping("datF18", "datF18"), New System.Data.Common.DataColumnMapping("datIequthr", "datIequthr"), New System.Data.Common.DataColumnMapping("datTequthr", "datTequthr"), New System.Data.Common.DataColumnMapping("datInshthr", "datInshthr"), New System.Data.Common.DataColumnMapping("datTnshthr", "datTnshthr"), New System.Data.Common.DataColumnMapping("datTequDifPerF3", "datTequDifPerF3"), New System.Data.Common.DataColumnMapping("datTequDifPerF7", "datTequDifPerF7"), New System.Data.Common.DataColumnMapping("datTequDifPerF11", "datTequDifPerF11"), New System.Data.Common.DataColumnMapping("datTequDifPerF15", "datTequDifPerF15"), New System.Data.Common.DataColumnMapping("datTnshDifPerF3", "datTnshDifPerF3"), New System.Data.Common.DataColumnMapping("datTnshDifPerF7", "datTnshDifPerF7"), New System.Data.Common.DataColumnMapping("datTnshDifPerF11", "datTnshDifPerF11"), New System.Data.Common.DataColumnMapping("datTnshDifPerF15", "datTnshDifPerF15"), New System.Data.Common.DataColumnMapping("datIequDifPerF4", "datIequDifPerF4"), New System.Data.Common.DataColumnMapping("datIequDifPerF8", "datIequDifPerF8"), New System.Data.Common.DataColumnMapping("datIequDifPerF12", "datIequDifPerF12"), New System.Data.Common.DataColumnMapping("datIequDifPerF16", "datIequDifPerF16"), New System.Data.Common.DataColumnMapping("datInshDifPerF4", "datInshDifPerF4"), New System.Data.Common.DataColumnMapping("datInshDifPerF8", "datInshDifPerF8"), New System.Data.Common.DataColumnMapping("datInshDifPerF12", "datInshDifPerF12"), New System.Data.Common.DataColumnMapping("datInshDifPerF16", "datInshDifPerF16"), New System.Data.Common.DataColumnMapping("datTurkishAgreement", "datTurkishAgreement"), New System.Data.Common.DataColumnMapping("datIraqiAgreement", "datIraqiAgreement"), New System.Data.Common.DataColumnMapping("DataCreazione", "DataCreazione"), New System.Data.Common.DataColumnMapping("UtenteCreazione", "UtenteCreazione"), New System.Data.Common.DataColumnMapping("DataAggiornamento", "DataAggiornamento"), New System.Data.Common.DataColumnMapping("UtenteAggiornamento", "UtenteAggiornamento"), New System.Data.Common.DataColumnMapping("Annullato", "Annullato"), New System.Data.Common.DataColumnMapping("DataEstrazione", "DataEstrazione"), New System.Data.Common.DataColumnMapping("datID", "datID")})})
		Me.DAData.UpdateCommand = Me.SqlUpdateCommand1
		'
		'DAParameters
		'
		Me.DAParameters.InsertCommand = Me.SqlCommand2
		Me.DAParameters.SelectCommand = Me.SqlCommand3
		Me.DAParameters.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "parameters", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("parKernelPath", "parKernelPath")})})
		'
		'SqlCommand2
		'
		Me.SqlCommand2.CommandText = "INSERT INTO [parameters] ([parKernelPath]) VALUES (@parKernelPath)"
		Me.SqlCommand2.Connection = Me.SqlConnection1
		Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@parKernelPath", System.Data.SqlDbType.NVarChar, 0, "parKernelPath")})
		'
		'SqlCommand3
		'
		Me.SqlCommand3.CommandText = "SELECT        parKernelPath" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            parameters"
		Me.SqlCommand3.Connection = Me.SqlConnection1
		'
		'DSData
		'
		Me.DSData.DataSetName = "DSData"
		Me.DSData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'DataTableAdapter
		'
		Me.DataTableAdapter.ClearBeforeFill = True
		'
		'grbCommonWaterIraq
		'
		Me.grbCommonWaterIraq.Controls.Add(Me.Label22)
		Me.grbCommonWaterIraq.Controls.Add(Me.Label18)
		Me.grbCommonWaterIraq.Controls.Add(Me.Label19)
		Me.grbCommonWaterIraq.Controls.Add(Me.Label17)
		Me.grbCommonWaterIraq.Controls.Add(Me.Label16)
		Me.grbCommonWaterIraq.Controls.Add(Me.lblIminagrwat)
		Me.grbCommonWaterIraq.Controls.Add(Me.nudIminagrwat)
		Me.grbCommonWaterIraq.Controls.Add(Me.lblIindwat)
		Me.grbCommonWaterIraq.Controls.Add(Me.lblImaxagrwat)
		Me.grbCommonWaterIraq.Controls.Add(Me.nudImaxagrwat)
		Me.grbCommonWaterIraq.Controls.Add(Me.nudIindwat)
		Me.grbCommonWaterIraq.Controls.Add(Me.nudInavwat)
		Me.grbCommonWaterIraq.Controls.Add(Me.lblInavwat)
		Me.grbCommonWaterIraq.Controls.Add(Me.lblIwatper)
		Me.grbCommonWaterIraq.Controls.Add(Me.nudIpop)
		Me.grbCommonWaterIraq.Controls.Add(Me.lblIpop)
		Me.grbCommonWaterIraq.Controls.Add(Me.nudIwatper)
		Me.grbCommonWaterIraq.ForeColor = System.Drawing.Color.Black
		Me.grbCommonWaterIraq.Location = New System.Drawing.Point(33, 12)
		Me.grbCommonWaterIraq.Name = "grbCommonWaterIraq"
		Me.grbCommonWaterIraq.Size = New System.Drawing.Size(661, 312)
		Me.grbCommonWaterIraq.TabIndex = 21
		Me.grbCommonWaterIraq.TabStop = False
		Me.grbCommonWaterIraq.Text = "Common data on water flows and demands (Billion Cubic Meters = BCM) to be provide" & _
	"d by IRAQ"
		Me.grbCommonWaterIraq.Visible = False
		'
		'Label22
		'
		Me.Label22.Location = New System.Drawing.Point(426, 142)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(35, 20)
		Me.Label22.TabIndex = 24
		Me.Label22.Text = "BCM"
		Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label18
		'
		Me.Label18.Location = New System.Drawing.Point(106, 90)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(35, 20)
		Me.Label18.TabIndex = 24
		Me.Label18.Text = "BCM"
		Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label19
		'
		Me.Label19.Location = New System.Drawing.Point(426, 90)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(35, 20)
		Me.Label19.TabIndex = 24
		Me.Label19.Text = "CM"
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label17
		'
		Me.Label17.Location = New System.Drawing.Point(426, 41)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(35, 20)
		Me.Label17.TabIndex = 24
		Me.Label17.Text = "BCM"
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label16
		'
		Me.Label16.Location = New System.Drawing.Point(106, 41)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(35, 20)
		Me.Label16.TabIndex = 24
		Me.Label16.Text = "BCM"
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblIminagrwat
		'
		Me.lblIminagrwat.AutoSize = True
		Me.lblIminagrwat.Location = New System.Drawing.Point(331, 126)
		Me.lblIminagrwat.Name = "lblIminagrwat"
		Me.lblIminagrwat.Size = New System.Drawing.Size(227, 13)
		Me.lblIminagrwat.TabIndex = 22
		Me.lblIminagrwat.Text = "Minimum water for Iraqi agriculture (Iminagrwat)"
		'
		'nudIminagrwat
		'
		Me.nudIminagrwat.DecimalPlaces = 3
		Me.nudIminagrwat.Location = New System.Drawing.Point(331, 142)
		Me.nudIminagrwat.Name = "nudIminagrwat"
		Me.nudIminagrwat.Size = New System.Drawing.Size(90, 20)
		Me.nudIminagrwat.TabIndex = 5
		Me.nudIminagrwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblIindwat
		'
		Me.lblIindwat.AutoSize = True
		Me.lblIindwat.Location = New System.Drawing.Point(331, 25)
		Me.lblIindwat.Name = "lblIindwat"
		Me.lblIindwat.Size = New System.Drawing.Size(197, 13)
		Me.lblIindwat.TabIndex = 20
		Me.lblIindwat.Text = "Water planned for Iraqi industry (Iindwat)"
		'
		'lblImaxagrwat
		'
		Me.lblImaxagrwat.AutoSize = True
		Me.lblImaxagrwat.Location = New System.Drawing.Point(12, 25)
		Me.lblImaxagrwat.Name = "lblImaxagrwat"
		Me.lblImaxagrwat.Size = New System.Drawing.Size(230, 13)
		Me.lblImaxagrwat.TabIndex = 16
		Me.lblImaxagrwat.Text = "Water planned for Iraqi agriculture (Imaxagrwat)"
		'
		'nudImaxagrwat
		'
		Me.nudImaxagrwat.DecimalPlaces = 3
		Me.nudImaxagrwat.Location = New System.Drawing.Point(12, 41)
		Me.nudImaxagrwat.Name = "nudImaxagrwat"
		Me.nudImaxagrwat.Size = New System.Drawing.Size(90, 20)
		Me.nudImaxagrwat.TabIndex = 0
		Me.nudImaxagrwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudIindwat
		'
		Me.nudIindwat.DecimalPlaces = 3
		Me.nudIindwat.Location = New System.Drawing.Point(331, 41)
		Me.nudIindwat.Name = "nudIindwat"
		Me.nudIindwat.Size = New System.Drawing.Size(90, 20)
		Me.nudIindwat.TabIndex = 1
		Me.nudIindwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudInavwat
		'
		Me.nudInavwat.DecimalPlaces = 3
		Me.nudInavwat.Location = New System.Drawing.Point(12, 90)
		Me.nudInavwat.Name = "nudInavwat"
		Me.nudInavwat.Size = New System.Drawing.Size(90, 20)
		Me.nudInavwat.TabIndex = 2
		Me.nudInavwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblInavwat
		'
		Me.lblInavwat.AutoSize = True
		Me.lblInavwat.Location = New System.Drawing.Point(12, 73)
		Me.lblInavwat.Name = "lblInavwat"
		Me.lblInavwat.Size = New System.Drawing.Size(214, 13)
		Me.lblInavwat.TabIndex = 15
		Me.lblInavwat.Text = "Water planned for Iraqi navigation (Inavwat)"
		'
		'lblIwatper
		'
		Me.lblIwatper.AutoSize = True
		Me.lblIwatper.Location = New System.Drawing.Point(331, 73)
		Me.lblIwatper.Name = "lblIwatper"
		Me.lblIwatper.Size = New System.Drawing.Size(250, 13)
		Me.lblIwatper.TabIndex = 12
		Me.lblIwatper.Text = "Planned CM per capita for Iraqi population (IwatPer)"
		'
		'nudIpop
		'
		Me.nudIpop.DecimalPlaces = 3
		Me.nudIpop.Location = New System.Drawing.Point(12, 142)
		Me.nudIpop.Name = "nudIpop"
		Me.nudIpop.Size = New System.Drawing.Size(90, 20)
		Me.nudIpop.TabIndex = 4
		Me.nudIpop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblIpop
		'
		Me.lblIpop.AutoSize = True
		Me.lblIpop.Location = New System.Drawing.Point(12, 126)
		Me.lblIpop.Name = "lblIpop"
		Me.lblIpop.Size = New System.Drawing.Size(215, 13)
		Me.lblIpop.TabIndex = 4
		Me.lblIpop.Text = "Expected population in the basin area (Ipop)"
		'
		'nudIwatper
		'
		Me.nudIwatper.DecimalPlaces = 3
		Me.nudIwatper.Location = New System.Drawing.Point(331, 90)
		Me.nudIwatper.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.nudIwatper.Name = "nudIwatper"
		Me.nudIwatper.Size = New System.Drawing.Size(90, 20)
		Me.nudIwatper.TabIndex = 3
		Me.nudIwatper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'grbCommonWaterTurkey
		'
		Me.grbCommonWaterTurkey.Controls.Add(Me.Label13)
		Me.grbCommonWaterTurkey.Controls.Add(Me.Label36)
		Me.grbCommonWaterTurkey.Controls.Add(Me.Label35)
		Me.grbCommonWaterTurkey.Controls.Add(Me.Label34)
		Me.grbCommonWaterTurkey.Controls.Add(Me.Label28)
		Me.grbCommonWaterTurkey.Controls.Add(Me.Label26)
		Me.grbCommonWaterTurkey.Controls.Add(Me.Label25)
		Me.grbCommonWaterTurkey.Controls.Add(Me.Label24)
		Me.grbCommonWaterTurkey.Controls.Add(Me.lblTeva)
		Me.grbCommonWaterTurkey.Controls.Add(Me.lblTindwat)
		Me.grbCommonWaterTurkey.Controls.Add(Me.lblTmaxintwat)
		Me.grbCommonWaterTurkey.Controls.Add(Me.lblTwatper)
		Me.grbCommonWaterTurkey.Controls.Add(Me.lblTmaxagrwat)
		Me.grbCommonWaterTurkey.Controls.Add(Me.lblTminagrwat)
		Me.grbCommonWaterTurkey.Controls.Add(Me.nudTminagrwat)
		Me.grbCommonWaterTurkey.Controls.Add(Me.nudTeva)
		Me.grbCommonWaterTurkey.Controls.Add(Me.nudTindwat)
		Me.grbCommonWaterTurkey.Controls.Add(Me.lblTret)
		Me.grbCommonWaterTurkey.Controls.Add(Me.lblTminenewat)
		Me.grbCommonWaterTurkey.Controls.Add(Me.nudTret)
		Me.grbCommonWaterTurkey.Controls.Add(Me.nudTminenewat)
		Me.grbCommonWaterTurkey.Controls.Add(Me.nudTmaxintwat)
		Me.grbCommonWaterTurkey.Controls.Add(Me.lblTpop)
		Me.grbCommonWaterTurkey.Controls.Add(Me.nudTpop)
		Me.grbCommonWaterTurkey.Controls.Add(Me.nudTwatper)
		Me.grbCommonWaterTurkey.Controls.Add(Me.nudTmaxagrwat)
		Me.grbCommonWaterTurkey.ForeColor = System.Drawing.Color.Black
		Me.grbCommonWaterTurkey.Location = New System.Drawing.Point(33, 12)
		Me.grbCommonWaterTurkey.Name = "grbCommonWaterTurkey"
		Me.grbCommonWaterTurkey.Size = New System.Drawing.Size(661, 312)
		Me.grbCommonWaterTurkey.TabIndex = 13
		Me.grbCommonWaterTurkey.TabStop = False
		Me.grbCommonWaterTurkey.Text = "Common data on water flows and demands (Billion Cubic Meters = BCM) to be provide" & _
	"d by TURKEY"
		Me.grbCommonWaterTurkey.Visible = False
		'
		'Label13
		'
		Me.Label13.Location = New System.Drawing.Point(371, 171)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(35, 20)
		Me.Label13.TabIndex = 26
		Me.Label13.Text = "CM"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label36
		'
		Me.Label36.Location = New System.Drawing.Point(371, 215)
		Me.Label36.Name = "Label36"
		Me.Label36.Size = New System.Drawing.Size(35, 20)
		Me.Label36.TabIndex = 25
		Me.Label36.Text = "%"
		Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label35
		'
		Me.Label35.Location = New System.Drawing.Point(119, 215)
		Me.Label35.Name = "Label35"
		Me.Label35.Size = New System.Drawing.Size(35, 20)
		Me.Label35.TabIndex = 25
		Me.Label35.Text = "%"
		Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label34
		'
		Me.Label34.Location = New System.Drawing.Point(118, 76)
		Me.Label34.Name = "Label34"
		Me.Label34.Size = New System.Drawing.Size(35, 20)
		Me.Label34.TabIndex = 24
		Me.Label34.Text = "BCM"
		Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label28
		'
		Me.Label28.Location = New System.Drawing.Point(371, 34)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(35, 20)
		Me.Label28.TabIndex = 24
		Me.Label28.Text = "BCM"
		Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label26
		'
		Me.Label26.Location = New System.Drawing.Point(371, 122)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(35, 20)
		Me.Label26.TabIndex = 24
		Me.Label26.Text = "BCM"
		Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label25
		'
		Me.Label25.Location = New System.Drawing.Point(119, 122)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(35, 20)
		Me.Label25.TabIndex = 24
		Me.Label25.Text = "BCM"
		Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label24
		'
		Me.Label24.Location = New System.Drawing.Point(119, 34)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(35, 20)
		Me.Label24.TabIndex = 24
		Me.Label24.Text = "BCM"
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblTeva
		'
		Me.lblTeva.AutoSize = True
		Me.lblTeva.Location = New System.Drawing.Point(278, 200)
		Me.lblTeva.Name = "lblTeva"
		Me.lblTeva.Size = New System.Drawing.Size(312, 13)
		Me.lblTeva.TabIndex = 21
		Me.lblTeva.Text = "Extra non-beneficial EVAPO of hydropower vs. agriculture (Teva)"
		'
		'lblTindwat
		'
		Me.lblTindwat.AutoSize = True
		Me.lblTindwat.Location = New System.Drawing.Point(20, 60)
		Me.lblTindwat.Name = "lblTindwat"
		Me.lblTindwat.Size = New System.Drawing.Size(216, 13)
		Me.lblTindwat.TabIndex = 22
		Me.lblTindwat.Text = "Water planned for Turkish industry (Tindwat)"
		'
		'lblTmaxintwat
		'
		Me.lblTmaxintwat.AutoSize = True
		Me.lblTmaxintwat.Location = New System.Drawing.Point(278, 106)
		Me.lblTmaxintwat.Name = "lblTmaxintwat"
		Me.lblTmaxintwat.Size = New System.Drawing.Size(361, 13)
		Me.lblTmaxintwat.TabIndex = 17
		Me.lblTmaxintwat.Text = "Turkish agriculture water accepted by international community (Tmaxintwat)"
		'
		'lblTwatper
		'
		Me.lblTwatper.AutoSize = True
		Me.lblTwatper.Location = New System.Drawing.Point(278, 156)
		Me.lblTwatper.Name = "lblTwatper"
		Me.lblTwatper.Size = New System.Drawing.Size(241, 13)
		Me.lblTwatper.TabIndex = 13
		Me.lblTwatper.Text = "Planned CM per capita in the GAP area (Twatper)"
		'
		'lblTmaxagrwat
		'
		Me.lblTmaxagrwat.AutoSize = True
		Me.lblTmaxagrwat.Location = New System.Drawing.Point(20, 18)
		Me.lblTmaxagrwat.Name = "lblTmaxagrwat"
		Me.lblTmaxagrwat.Size = New System.Drawing.Size(249, 13)
		Me.lblTmaxagrwat.TabIndex = 14
		Me.lblTmaxagrwat.Text = "Water planned for Turkish agriculture (Tmaxagrwat)"
		'
		'lblTminagrwat
		'
		Me.lblTminagrwat.AutoSize = True
		Me.lblTminagrwat.Location = New System.Drawing.Point(278, 18)
		Me.lblTminagrwat.Name = "lblTminagrwat"
		Me.lblTminagrwat.Size = New System.Drawing.Size(246, 13)
		Me.lblTminagrwat.TabIndex = 12
		Me.lblTminagrwat.Text = "Minimum water for Turkish agriculture (Tminagrwat)"
		'
		'nudTminagrwat
		'
		Me.nudTminagrwat.DecimalPlaces = 3
		Me.nudTminagrwat.Location = New System.Drawing.Point(278, 34)
		Me.nudTminagrwat.Name = "nudTminagrwat"
		Me.nudTminagrwat.Size = New System.Drawing.Size(90, 20)
		Me.nudTminagrwat.TabIndex = 1
		Me.nudTminagrwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudTeva
		'
		Me.nudTeva.DecimalPlaces = 3
		Me.nudTeva.Location = New System.Drawing.Point(278, 215)
		Me.nudTeva.Name = "nudTeva"
		Me.nudTeva.Size = New System.Drawing.Size(90, 20)
		Me.nudTeva.TabIndex = 8
		Me.nudTeva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudTindwat
		'
		Me.nudTindwat.DecimalPlaces = 3
		Me.nudTindwat.Location = New System.Drawing.Point(20, 76)
		Me.nudTindwat.Name = "nudTindwat"
		Me.nudTindwat.Size = New System.Drawing.Size(90, 20)
		Me.nudTindwat.TabIndex = 2
		Me.nudTindwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblTret
		'
		Me.lblTret.AutoSize = True
		Me.lblTret.Location = New System.Drawing.Point(20, 200)
		Me.lblTret.Name = "lblTret"
		Me.lblTret.Size = New System.Drawing.Size(247, 13)
		Me.lblTret.TabIndex = 8
		Me.lblTret.Text = "Estimated return flow after Turkish agriculture (Tret)"
		'
		'lblTminenewat
		'
		Me.lblTminenewat.AutoSize = True
		Me.lblTminenewat.Location = New System.Drawing.Point(20, 106)
		Me.lblTminenewat.Name = "lblTminenewat"
		Me.lblTminenewat.Size = New System.Drawing.Size(232, 13)
		Me.lblTminenewat.TabIndex = 8
		Me.lblTminenewat.Text = "Minimum water for Turkish energy (Tminenewat)"
		'
		'nudTret
		'
		Me.nudTret.DecimalPlaces = 3
		Me.nudTret.Location = New System.Drawing.Point(20, 215)
		Me.nudTret.Name = "nudTret"
		Me.nudTret.Size = New System.Drawing.Size(90, 20)
		Me.nudTret.TabIndex = 7
		Me.nudTret.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudTminenewat
		'
		Me.nudTminenewat.DecimalPlaces = 3
		Me.nudTminenewat.Location = New System.Drawing.Point(20, 122)
		Me.nudTminenewat.Name = "nudTminenewat"
		Me.nudTminenewat.Size = New System.Drawing.Size(90, 20)
		Me.nudTminenewat.TabIndex = 3
		Me.nudTminenewat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudTmaxintwat
		'
		Me.nudTmaxintwat.DecimalPlaces = 3
		Me.nudTmaxintwat.Location = New System.Drawing.Point(278, 122)
		Me.nudTmaxintwat.Name = "nudTmaxintwat"
		Me.nudTmaxintwat.Size = New System.Drawing.Size(90, 20)
		Me.nudTmaxintwat.TabIndex = 4
		Me.nudTmaxintwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblTpop
		'
		Me.lblTpop.AutoSize = True
		Me.lblTpop.Location = New System.Drawing.Point(20, 156)
		Me.lblTpop.Name = "lblTpop"
		Me.lblTpop.Size = New System.Drawing.Size(216, 13)
		Me.lblTpop.TabIndex = 4
		Me.lblTpop.Text = "Expected population in the GAP area (Tpop)"
		'
		'nudTpop
		'
		Me.nudTpop.DecimalPlaces = 3
		Me.nudTpop.Location = New System.Drawing.Point(20, 171)
		Me.nudTpop.Name = "nudTpop"
		Me.nudTpop.Size = New System.Drawing.Size(90, 20)
		Me.nudTpop.TabIndex = 5
		Me.nudTpop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudTwatper
		'
		Me.nudTwatper.DecimalPlaces = 3
		Me.nudTwatper.Location = New System.Drawing.Point(278, 171)
		Me.nudTwatper.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.nudTwatper.Name = "nudTwatper"
		Me.nudTwatper.Size = New System.Drawing.Size(90, 20)
		Me.nudTwatper.TabIndex = 6
		Me.nudTwatper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudTmaxagrwat
		'
		Me.nudTmaxagrwat.DecimalPlaces = 3
		Me.nudTmaxagrwat.Location = New System.Drawing.Point(20, 34)
		Me.nudTmaxagrwat.Name = "nudTmaxagrwat"
		Me.nudTmaxagrwat.Size = New System.Drawing.Size(90, 20)
		Me.nudTmaxagrwat.TabIndex = 0
		Me.nudTmaxagrwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'grbNegotiationOutcome
		'
		Me.grbNegotiationOutcome.Controls.Add(Me.pboOutcome)
		Me.grbNegotiationOutcome.Controls.Add(Me.lblGraphLabel)
		Me.grbNegotiationOutcome.Controls.Add(Me.lblNegotiationOutcome)
		Me.grbNegotiationOutcome.ForeColor = System.Drawing.Color.Black
		Me.grbNegotiationOutcome.Location = New System.Drawing.Point(33, 12)
		Me.grbNegotiationOutcome.Name = "grbNegotiationOutcome"
		Me.grbNegotiationOutcome.Size = New System.Drawing.Size(630, 388)
		Me.grbNegotiationOutcome.TabIndex = 30
		Me.grbNegotiationOutcome.TabStop = False
		Me.grbNegotiationOutcome.Text = "Negotiation outcome"
		Me.grbNegotiationOutcome.Visible = False
		'
		'pboOutcome
		'
		Me.pboOutcome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.pboOutcome.Location = New System.Drawing.Point(3, 131)
		Me.pboOutcome.Name = "pboOutcome"
		Me.pboOutcome.Size = New System.Drawing.Size(621, 254)
		Me.pboOutcome.TabIndex = 17
		Me.pboOutcome.TabStop = False
		'
		'lblGraphLabel
		'
		Me.lblGraphLabel.Location = New System.Drawing.Point(15, 49)
		Me.lblGraphLabel.Name = "lblGraphLabel"
		Me.lblGraphLabel.Size = New System.Drawing.Size(602, 79)
		Me.lblGraphLabel.TabIndex = 8
		'
		'lblNegotiationOutcome
		'
		Me.lblNegotiationOutcome.Location = New System.Drawing.Point(15, 23)
		Me.lblNegotiationOutcome.Name = "lblNegotiationOutcome"
		Me.lblNegotiationOutcome.Size = New System.Drawing.Size(602, 27)
		Me.lblNegotiationOutcome.TabIndex = 8
		'
		'grbConfidentialWaterTurkey
		'
		Me.grbConfidentialWaterTurkey.Controls.Add(Me.btnTurkishDisagree)
		Me.grbConfidentialWaterTurkey.Controls.Add(Me.btnTurkishAgree)
		Me.grbConfidentialWaterTurkey.Controls.Add(Me.tcoTurkey)
		Me.grbConfidentialWaterTurkey.ForeColor = System.Drawing.Color.Black
		Me.grbConfidentialWaterTurkey.Location = New System.Drawing.Point(33, 12)
		Me.grbConfidentialWaterTurkey.Name = "grbConfidentialWaterTurkey"
		Me.grbConfidentialWaterTurkey.Size = New System.Drawing.Size(630, 430)
		Me.grbConfidentialWaterTurkey.TabIndex = 28
		Me.grbConfidentialWaterTurkey.TabStop = False
		Me.grbConfidentialWaterTurkey.Text = "Confidential water allocations and benefits for TURKEY"
		Me.grbConfidentialWaterTurkey.Visible = False
		'
		'btnTurkishDisagree
		'
		Me.btnTurkishDisagree.Location = New System.Drawing.Point(316, 388)
		Me.btnTurkishDisagree.Name = "btnTurkishDisagree"
		Me.btnTurkishDisagree.Size = New System.Drawing.Size(90, 36)
		Me.btnTurkishDisagree.TabIndex = 4
		Me.btnTurkishDisagree.Text = "I Disagree"
		Me.btnTurkishDisagree.UseVisualStyleBackColor = True
		'
		'btnTurkishAgree
		'
		Me.btnTurkishAgree.Location = New System.Drawing.Point(217, 388)
		Me.btnTurkishAgree.Name = "btnTurkishAgree"
		Me.btnTurkishAgree.Size = New System.Drawing.Size(90, 36)
		Me.btnTurkishAgree.TabIndex = 3
		Me.btnTurkishAgree.Text = "I Agree"
		Me.btnTurkishAgree.UseVisualStyleBackColor = True
		'
		'tcoTurkey
		'
		Me.tcoTurkey.Controls.Add(Me.tpaDataTurkey)
		Me.tcoTurkey.Controls.Add(Me.tpaGraph1Turkey)
		Me.tcoTurkey.Controls.Add(Me.tpaGraph2Turkey)
		Me.tcoTurkey.Controls.Add(Me.tpaGraph3Turkey)
		Me.tcoTurkey.Controls.Add(Me.tpaGraph4Turkey)
		Me.tcoTurkey.Location = New System.Drawing.Point(13, 18)
		Me.tcoTurkey.Name = "tcoTurkey"
		Me.tcoTurkey.SelectedIndex = 0
		Me.tcoTurkey.Size = New System.Drawing.Size(605, 360)
		Me.tcoTurkey.TabIndex = 17
		'
		'tpaDataTurkey
		'
		Me.tpaDataTurkey.Controls.Add(Me.Label48)
		Me.tpaDataTurkey.Controls.Add(Me.Label49)
		Me.tpaDataTurkey.Controls.Add(Me.lblTnshDifPerF15)
		Me.tpaDataTurkey.Controls.Add(Me.lblTnshDifPerF7)
		Me.tpaDataTurkey.Controls.Add(Me.lblTnshDifPerF11)
		Me.tpaDataTurkey.Controls.Add(Me.lblTnshDifPerF3)
		Me.tpaDataTurkey.Controls.Add(Me.lblF17)
		Me.tpaDataTurkey.Controls.Add(Me.lblF15)
		Me.tpaDataTurkey.Controls.Add(Me.lblF7)
		Me.tpaDataTurkey.Controls.Add(Me.lblF11)
		Me.tpaDataTurkey.Controls.Add(Me.lblF3)
		Me.tpaDataTurkey.Controls.Add(Me.lblTequDifPerF15)
		Me.tpaDataTurkey.Controls.Add(Me.lblTequDifPerF7)
		Me.tpaDataTurkey.Controls.Add(Me.lblTequDifPerF11)
		Me.tpaDataTurkey.Controls.Add(Me.lblTequDifPerF3)
		Me.tpaDataTurkey.Controls.Add(Me.Label3)
		Me.tpaDataTurkey.Controls.Add(Me.Label4)
		Me.tpaDataTurkey.Controls.Add(Me.Label2)
		Me.tpaDataTurkey.Controls.Add(Me.Label1)
		Me.tpaDataTurkey.Controls.Add(Me.lblF13)
		Me.tpaDataTurkey.Controls.Add(Me.lblF5)
		Me.tpaDataTurkey.Controls.Add(Me.lblF9)
		Me.tpaDataTurkey.Controls.Add(Me.lblF1)
		Me.tpaDataTurkey.Controls.Add(Me.Label6)
		Me.tpaDataTurkey.Controls.Add(Me.Label30)
		Me.tpaDataTurkey.Controls.Add(Me.Label33)
		Me.tpaDataTurkey.Controls.Add(Me.Label21)
		Me.tpaDataTurkey.Controls.Add(Me.Label32)
		Me.tpaDataTurkey.Controls.Add(Me.Label15)
		Me.tpaDataTurkey.Controls.Add(Me.Label31)
		Me.tpaDataTurkey.Controls.Add(Me.Label9)
		Me.tpaDataTurkey.Controls.Add(Me.lblAgriculture)
		Me.tpaDataTurkey.Controls.Add(Me.Label29)
		Me.tpaDataTurkey.Controls.Add(Me.Label20)
		Me.tpaDataTurkey.Controls.Add(Me.Label27)
		Me.tpaDataTurkey.Controls.Add(Me.lblOutcomes)
		Me.tpaDataTurkey.Location = New System.Drawing.Point(4, 22)
		Me.tpaDataTurkey.Name = "tpaDataTurkey"
		Me.tpaDataTurkey.Size = New System.Drawing.Size(597, 334)
		Me.tpaDataTurkey.TabIndex = 2
		Me.tpaDataTurkey.Text = "Data"
		Me.tpaDataTurkey.UseVisualStyleBackColor = True
		'
		'Label48
		'
		Me.Label48.Location = New System.Drawing.Point(24, 29)
		Me.Label48.Name = "Label48"
		Me.Label48.Size = New System.Drawing.Size(549, 23)
		Me.Label48.TabIndex = 93
		Me.Label48.Text = "Gain/loss due to unmet non significant harm = NON-SIG %"
		'
		'Label49
		'
		Me.Label49.Location = New System.Drawing.Point(24, 10)
		Me.Label49.Name = "Label49"
		Me.Label49.Size = New System.Drawing.Size(549, 23)
		Me.Label49.TabIndex = 92
		Me.Label49.Text = "Gain/loss due to unmet equitable use = EQU %"
		'
		'lblTnshDifPerF15
		'
		Me.lblTnshDifPerF15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTnshDifPerF15.Location = New System.Drawing.Point(464, 262)
		Me.lblTnshDifPerF15.Name = "lblTnshDifPerF15"
		Me.lblTnshDifPerF15.Size = New System.Drawing.Size(66, 23)
		Me.lblTnshDifPerF15.TabIndex = 46
		Me.lblTnshDifPerF15.Text = "."
		Me.lblTnshDifPerF15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblTnshDifPerF7
		'
		Me.lblTnshDifPerF7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTnshDifPerF7.Location = New System.Drawing.Point(464, 161)
		Me.lblTnshDifPerF7.Name = "lblTnshDifPerF7"
		Me.lblTnshDifPerF7.Size = New System.Drawing.Size(66, 23)
		Me.lblTnshDifPerF7.TabIndex = 45
		Me.lblTnshDifPerF7.Text = "."
		Me.lblTnshDifPerF7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblTnshDifPerF11
		'
		Me.lblTnshDifPerF11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTnshDifPerF11.Location = New System.Drawing.Point(464, 213)
		Me.lblTnshDifPerF11.Name = "lblTnshDifPerF11"
		Me.lblTnshDifPerF11.Size = New System.Drawing.Size(66, 23)
		Me.lblTnshDifPerF11.TabIndex = 48
		Me.lblTnshDifPerF11.Text = "."
		Me.lblTnshDifPerF11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblTnshDifPerF3
		'
		Me.lblTnshDifPerF3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTnshDifPerF3.Location = New System.Drawing.Point(464, 109)
		Me.lblTnshDifPerF3.Name = "lblTnshDifPerF3"
		Me.lblTnshDifPerF3.Size = New System.Drawing.Size(66, 23)
		Me.lblTnshDifPerF3.TabIndex = 47
		Me.lblTnshDifPerF3.Text = "."
		Me.lblTnshDifPerF3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF17
		'
		Me.lblF17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF17.Location = New System.Drawing.Point(331, 285)
		Me.lblF17.Name = "lblF17"
		Me.lblF17.Size = New System.Drawing.Size(66, 23)
		Me.lblF17.TabIndex = 41
		Me.lblF17.Text = "."
		Me.lblF17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF15
		'
		Me.lblF15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF15.Location = New System.Drawing.Point(331, 262)
		Me.lblF15.Name = "lblF15"
		Me.lblF15.Size = New System.Drawing.Size(66, 23)
		Me.lblF15.TabIndex = 40
		Me.lblF15.Text = "."
		Me.lblF15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF7
		'
		Me.lblF7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF7.Location = New System.Drawing.Point(331, 161)
		Me.lblF7.Name = "lblF7"
		Me.lblF7.Size = New System.Drawing.Size(66, 23)
		Me.lblF7.TabIndex = 42
		Me.lblF7.Text = "."
		Me.lblF7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF11
		'
		Me.lblF11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF11.Location = New System.Drawing.Point(331, 213)
		Me.lblF11.Name = "lblF11"
		Me.lblF11.Size = New System.Drawing.Size(66, 23)
		Me.lblF11.TabIndex = 44
		Me.lblF11.Text = "."
		Me.lblF11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF3
		'
		Me.lblF3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF3.Location = New System.Drawing.Point(331, 109)
		Me.lblF3.Name = "lblF3"
		Me.lblF3.Size = New System.Drawing.Size(66, 23)
		Me.lblF3.TabIndex = 43
		Me.lblF3.Text = "."
		Me.lblF3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblTequDifPerF15
		'
		Me.lblTequDifPerF15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTequDifPerF15.Location = New System.Drawing.Point(397, 262)
		Me.lblTequDifPerF15.Name = "lblTequDifPerF15"
		Me.lblTequDifPerF15.Size = New System.Drawing.Size(66, 23)
		Me.lblTequDifPerF15.TabIndex = 37
		Me.lblTequDifPerF15.Text = "."
		Me.lblTequDifPerF15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblTequDifPerF7
		'
		Me.lblTequDifPerF7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTequDifPerF7.Location = New System.Drawing.Point(397, 161)
		Me.lblTequDifPerF7.Name = "lblTequDifPerF7"
		Me.lblTequDifPerF7.Size = New System.Drawing.Size(66, 23)
		Me.lblTequDifPerF7.TabIndex = 36
		Me.lblTequDifPerF7.Text = "."
		Me.lblTequDifPerF7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblTequDifPerF11
		'
		Me.lblTequDifPerF11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTequDifPerF11.Location = New System.Drawing.Point(397, 213)
		Me.lblTequDifPerF11.Name = "lblTequDifPerF11"
		Me.lblTequDifPerF11.Size = New System.Drawing.Size(66, 23)
		Me.lblTequDifPerF11.TabIndex = 39
		Me.lblTequDifPerF11.Text = "."
		Me.lblTequDifPerF11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblTequDifPerF3
		'
		Me.lblTequDifPerF3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTequDifPerF3.Location = New System.Drawing.Point(397, 109)
		Me.lblTequDifPerF3.Name = "lblTequDifPerF3"
		Me.lblTequDifPerF3.Size = New System.Drawing.Size(66, 23)
		Me.lblTequDifPerF3.TabIndex = 38
		Me.lblTequDifPerF3.Text = "."
		Me.lblTequDifPerF3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(464, 52)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(102, 23)
		Me.Label3.TabIndex = 35
		Me.Label3.Text = "NON-SIG %"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(397, 52)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(66, 23)
		Me.Label4.TabIndex = 34
		Me.Label4.Text = "EQU %"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(331, 52)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(66, 23)
		Me.Label2.TabIndex = 33
		Me.Label2.Text = "B$"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(264, 52)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(66, 23)
		Me.Label1.TabIndex = 32
		Me.Label1.Text = "BCM"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF13
		'
		Me.lblF13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF13.Location = New System.Drawing.Point(264, 239)
		Me.lblF13.Name = "lblF13"
		Me.lblF13.Size = New System.Drawing.Size(66, 23)
		Me.lblF13.TabIndex = 29
		Me.lblF13.Text = "."
		Me.lblF13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF5
		'
		Me.lblF5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF5.Location = New System.Drawing.Point(264, 135)
		Me.lblF5.Name = "lblF5"
		Me.lblF5.Size = New System.Drawing.Size(66, 23)
		Me.lblF5.TabIndex = 28
		Me.lblF5.Text = "."
		Me.lblF5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF9
		'
		Me.lblF9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF9.Location = New System.Drawing.Point(264, 187)
		Me.lblF9.Name = "lblF9"
		Me.lblF9.Size = New System.Drawing.Size(66, 23)
		Me.lblF9.TabIndex = 31
		Me.lblF9.Text = "."
		Me.lblF9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF1
		'
		Me.lblF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF1.Location = New System.Drawing.Point(264, 83)
		Me.lblF1.Name = "lblF1"
		Me.lblF1.Size = New System.Drawing.Size(66, 23)
		Me.lblF1.TabIndex = 30
		Me.lblF1.Text = "."
		Me.lblF1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label6
		'
		Me.Label6.Location = New System.Drawing.Point(148, 285)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(155, 23)
		Me.Label6.TabIndex = 21
		Me.Label6.Text = "Side-payment from Iraq"
		'
		'Label30
		'
		Me.Label30.Location = New System.Drawing.Point(148, 262)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(117, 23)
		Me.Label30.TabIndex = 22
		Me.Label30.Text = "Agriculture"
		'
		'Label33
		'
		Me.Label33.Location = New System.Drawing.Point(148, 239)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(117, 23)
		Me.Label33.TabIndex = 19
		Me.Label33.Text = "Agriculture"
		'
		'Label21
		'
		Me.Label21.Location = New System.Drawing.Point(148, 161)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(117, 23)
		Me.Label21.TabIndex = 20
		Me.Label21.Text = "Total"
		'
		'Label32
		'
		Me.Label32.Location = New System.Drawing.Point(148, 213)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(117, 23)
		Me.Label32.TabIndex = 23
		Me.Label32.Text = "Total"
		'
		'Label15
		'
		Me.Label15.Location = New System.Drawing.Point(148, 135)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(117, 23)
		Me.Label15.TabIndex = 26
		Me.Label15.Text = "Agriculture"
		'
		'Label31
		'
		Me.Label31.Location = New System.Drawing.Point(148, 187)
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(117, 23)
		Me.Label31.TabIndex = 27
		Me.Label31.Text = "Agriculture"
		'
		'Label9
		'
		Me.Label9.Location = New System.Drawing.Point(148, 109)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(117, 23)
		Me.Label9.TabIndex = 24
		Me.Label9.Text = "Total"
		'
		'lblAgriculture
		'
		Me.lblAgriculture.Location = New System.Drawing.Point(148, 83)
		Me.lblAgriculture.Name = "lblAgriculture"
		Me.lblAgriculture.Size = New System.Drawing.Size(117, 23)
		Me.lblAgriculture.TabIndex = 25
		Me.lblAgriculture.Text = "Agriculture"
		'
		'Label29
		'
		Me.Label29.Location = New System.Drawing.Point(10, 239)
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(137, 23)
		Me.Label29.TabIndex = 16
		Me.Label29.Text = "Cooperation outcomes"
		'
		'Label20
		'
		Me.Label20.Location = New System.Drawing.Point(10, 135)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(137, 27)
		Me.Label20.TabIndex = 15
		Me.Label20.Text = "Turkey implements its plans"
		'
		'Label27
		'
		Me.Label27.Location = New System.Drawing.Point(10, 187)
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(137, 30)
		Me.Label27.TabIndex = 18
		Me.Label27.Text = "Iraq implements its plans"
		'
		'lblOutcomes
		'
		Me.lblOutcomes.Location = New System.Drawing.Point(10, 83)
		Me.lblOutcomes.Name = "lblOutcomes"
		Me.lblOutcomes.Size = New System.Drawing.Size(137, 23)
		Me.lblOutcomes.TabIndex = 17
		Me.lblOutcomes.Text = "Negotiation outcomes"
		'
		'tpaGraph1Turkey
		'
		Me.tpaGraph1Turkey.Controls.Add(Me.pboTurkey1)
		Me.tpaGraph1Turkey.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph1Turkey.Name = "tpaGraph1Turkey"
		Me.tpaGraph1Turkey.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph1Turkey.Size = New System.Drawing.Size(597, 334)
		Me.tpaGraph1Turkey.TabIndex = 0
		Me.tpaGraph1Turkey.Text = "Equitable use"
		Me.tpaGraph1Turkey.UseVisualStyleBackColor = True
		'
		'pboTurkey1
		'
		Me.pboTurkey1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pboTurkey1.Location = New System.Drawing.Point(3, 3)
		Me.pboTurkey1.Name = "pboTurkey1"
		Me.pboTurkey1.Size = New System.Drawing.Size(591, 328)
		Me.pboTurkey1.TabIndex = 16
		Me.pboTurkey1.TabStop = False
		'
		'tpaGraph2Turkey
		'
		Me.tpaGraph2Turkey.Controls.Add(Me.pboTurkey2)
		Me.tpaGraph2Turkey.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph2Turkey.Name = "tpaGraph2Turkey"
		Me.tpaGraph2Turkey.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph2Turkey.Size = New System.Drawing.Size(597, 334)
		Me.tpaGraph2Turkey.TabIndex = 1
		Me.tpaGraph2Turkey.Text = "Non significant harm"
		Me.tpaGraph2Turkey.UseVisualStyleBackColor = True
		'
		'pboTurkey2
		'
		Me.pboTurkey2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pboTurkey2.Location = New System.Drawing.Point(3, 3)
		Me.pboTurkey2.Name = "pboTurkey2"
		Me.pboTurkey2.Size = New System.Drawing.Size(591, 328)
		Me.pboTurkey2.TabIndex = 17
		Me.pboTurkey2.TabStop = False
		'
		'tpaGraph3Turkey
		'
		Me.tpaGraph3Turkey.Controls.Add(Me.pboTurkey3)
		Me.tpaGraph3Turkey.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph3Turkey.Name = "tpaGraph3Turkey"
		Me.tpaGraph3Turkey.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph3Turkey.Size = New System.Drawing.Size(597, 334)
		Me.tpaGraph3Turkey.TabIndex = 3
		Me.tpaGraph3Turkey.Text = "Net benefits"
		Me.tpaGraph3Turkey.UseVisualStyleBackColor = True
		'
		'pboTurkey3
		'
		Me.pboTurkey3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pboTurkey3.Location = New System.Drawing.Point(3, 3)
		Me.pboTurkey3.Name = "pboTurkey3"
		Me.pboTurkey3.Size = New System.Drawing.Size(591, 328)
		Me.pboTurkey3.TabIndex = 18
		Me.pboTurkey3.TabStop = False
		'
		'tpaGraph4Turkey
		'
		Me.tpaGraph4Turkey.Controls.Add(Me.pboTurkey4)
		Me.tpaGraph4Turkey.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph4Turkey.Name = "tpaGraph4Turkey"
		Me.tpaGraph4Turkey.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph4Turkey.Size = New System.Drawing.Size(597, 334)
		Me.tpaGraph4Turkey.TabIndex = 4
		Me.tpaGraph4Turkey.Text = "Overall net benefits"
		Me.tpaGraph4Turkey.UseVisualStyleBackColor = True
		'
		'pboTurkey4
		'
		Me.pboTurkey4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pboTurkey4.Location = New System.Drawing.Point(3, 3)
		Me.pboTurkey4.Name = "pboTurkey4"
		Me.pboTurkey4.Size = New System.Drawing.Size(591, 328)
		Me.pboTurkey4.TabIndex = 19
		Me.pboTurkey4.TabStop = False
		'
		'grbConfidentialWaterIraq
		'
		Me.grbConfidentialWaterIraq.Controls.Add(Me.tcoIraq)
		Me.grbConfidentialWaterIraq.Controls.Add(Me.btnIraqiDisagree)
		Me.grbConfidentialWaterIraq.Controls.Add(Me.btnIraqiAgree)
		Me.grbConfidentialWaterIraq.ForeColor = System.Drawing.Color.Black
		Me.grbConfidentialWaterIraq.Location = New System.Drawing.Point(33, 12)
		Me.grbConfidentialWaterIraq.Name = "grbConfidentialWaterIraq"
		Me.grbConfidentialWaterIraq.Size = New System.Drawing.Size(630, 430)
		Me.grbConfidentialWaterIraq.TabIndex = 27
		Me.grbConfidentialWaterIraq.TabStop = False
		Me.grbConfidentialWaterIraq.Text = "Confidential water allocations and benefits for IRAQ"
		Me.grbConfidentialWaterIraq.Visible = False
		'
		'tcoIraq
		'
		Me.tcoIraq.Controls.Add(Me.tpaDataIraq)
		Me.tcoIraq.Controls.Add(Me.tpaGraph1Iraq)
		Me.tcoIraq.Controls.Add(Me.tpaGraph2Iraq)
		Me.tcoIraq.Controls.Add(Me.tpaGraph3Iraq)
		Me.tcoIraq.Controls.Add(Me.tpaGraph4Iraq)
		Me.tcoIraq.Location = New System.Drawing.Point(13, 18)
		Me.tcoIraq.Name = "tcoIraq"
		Me.tcoIraq.SelectedIndex = 0
		Me.tcoIraq.Size = New System.Drawing.Size(605, 360)
		Me.tcoIraq.TabIndex = 56
		'
		'tpaDataIraq
		'
		Me.tpaDataIraq.Controls.Add(Me.Label23)
		Me.tpaDataIraq.Controls.Add(Me.Label14)
		Me.tpaDataIraq.Controls.Add(Me.lblInshDifPerF16)
		Me.tpaDataIraq.Controls.Add(Me.lblInshDifPerF8)
		Me.tpaDataIraq.Controls.Add(Me.lblInshDifPerF12)
		Me.tpaDataIraq.Controls.Add(Me.lblInshDifPerF4)
		Me.tpaDataIraq.Controls.Add(Me.lblF18)
		Me.tpaDataIraq.Controls.Add(Me.lblF16)
		Me.tpaDataIraq.Controls.Add(Me.lblF8)
		Me.tpaDataIraq.Controls.Add(Me.lblF12)
		Me.tpaDataIraq.Controls.Add(Me.lblF4)
		Me.tpaDataIraq.Controls.Add(Me.lblIequDifPerF16)
		Me.tpaDataIraq.Controls.Add(Me.lblIequDifPerF8)
		Me.tpaDataIraq.Controls.Add(Me.lblIequDifPerF12)
		Me.tpaDataIraq.Controls.Add(Me.lblIequDifPerF4)
		Me.tpaDataIraq.Controls.Add(Me.Label58)
		Me.tpaDataIraq.Controls.Add(Me.Label59)
		Me.tpaDataIraq.Controls.Add(Me.Label60)
		Me.tpaDataIraq.Controls.Add(Me.Label61)
		Me.tpaDataIraq.Controls.Add(Me.lblF14)
		Me.tpaDataIraq.Controls.Add(Me.lblF6)
		Me.tpaDataIraq.Controls.Add(Me.lblF10)
		Me.tpaDataIraq.Controls.Add(Me.lblF2)
		Me.tpaDataIraq.Controls.Add(Me.Label66)
		Me.tpaDataIraq.Controls.Add(Me.Label67)
		Me.tpaDataIraq.Controls.Add(Me.Label68)
		Me.tpaDataIraq.Controls.Add(Me.Label69)
		Me.tpaDataIraq.Controls.Add(Me.Label70)
		Me.tpaDataIraq.Controls.Add(Me.Label71)
		Me.tpaDataIraq.Controls.Add(Me.Label72)
		Me.tpaDataIraq.Controls.Add(Me.Label73)
		Me.tpaDataIraq.Controls.Add(Me.Label74)
		Me.tpaDataIraq.Controls.Add(Me.Label75)
		Me.tpaDataIraq.Controls.Add(Me.Label76)
		Me.tpaDataIraq.Controls.Add(Me.Label77)
		Me.tpaDataIraq.Controls.Add(Me.Label78)
		Me.tpaDataIraq.Location = New System.Drawing.Point(4, 22)
		Me.tpaDataIraq.Name = "tpaDataIraq"
		Me.tpaDataIraq.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaDataIraq.Size = New System.Drawing.Size(597, 334)
		Me.tpaDataIraq.TabIndex = 0
		Me.tpaDataIraq.Text = "Data"
		Me.tpaDataIraq.UseVisualStyleBackColor = True
		'
		'Label23
		'
		Me.Label23.Location = New System.Drawing.Point(17, 29)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(549, 23)
		Me.Label23.TabIndex = 91
		Me.Label23.Text = "Gain/loss due to unmet non significant harm = NON-SIG %"
		'
		'Label14
		'
		Me.Label14.Location = New System.Drawing.Point(17, 10)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(549, 23)
		Me.Label14.TabIndex = 90
		Me.Label14.Text = "Gain/loss due to unmet equitable use = EQU %"
		'
		'lblInshDifPerF16
		'
		Me.lblInshDifPerF16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInshDifPerF16.Location = New System.Drawing.Point(464, 270)
		Me.lblInshDifPerF16.Name = "lblInshDifPerF16"
		Me.lblInshDifPerF16.Size = New System.Drawing.Size(66, 23)
		Me.lblInshDifPerF16.TabIndex = 87
		Me.lblInshDifPerF16.Text = "."
		Me.lblInshDifPerF16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblInshDifPerF8
		'
		Me.lblInshDifPerF8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInshDifPerF8.Location = New System.Drawing.Point(464, 169)
		Me.lblInshDifPerF8.Name = "lblInshDifPerF8"
		Me.lblInshDifPerF8.Size = New System.Drawing.Size(66, 23)
		Me.lblInshDifPerF8.TabIndex = 86
		Me.lblInshDifPerF8.Text = "."
		Me.lblInshDifPerF8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblInshDifPerF12
		'
		Me.lblInshDifPerF12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInshDifPerF12.Location = New System.Drawing.Point(464, 221)
		Me.lblInshDifPerF12.Name = "lblInshDifPerF12"
		Me.lblInshDifPerF12.Size = New System.Drawing.Size(66, 23)
		Me.lblInshDifPerF12.TabIndex = 88
		Me.lblInshDifPerF12.Text = "."
		Me.lblInshDifPerF12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblInshDifPerF4
		'
		Me.lblInshDifPerF4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInshDifPerF4.Location = New System.Drawing.Point(464, 117)
		Me.lblInshDifPerF4.Name = "lblInshDifPerF4"
		Me.lblInshDifPerF4.Size = New System.Drawing.Size(66, 23)
		Me.lblInshDifPerF4.TabIndex = 89
		Me.lblInshDifPerF4.Text = "."
		Me.lblInshDifPerF4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF18
		'
		Me.lblF18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF18.Location = New System.Drawing.Point(331, 293)
		Me.lblF18.Name = "lblF18"
		Me.lblF18.Size = New System.Drawing.Size(66, 23)
		Me.lblF18.TabIndex = 82
		Me.lblF18.Text = "."
		Me.lblF18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF16
		'
		Me.lblF16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF16.Location = New System.Drawing.Point(331, 270)
		Me.lblF16.Name = "lblF16"
		Me.lblF16.Size = New System.Drawing.Size(66, 23)
		Me.lblF16.TabIndex = 81
		Me.lblF16.Text = "."
		Me.lblF16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF8
		'
		Me.lblF8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF8.Location = New System.Drawing.Point(331, 169)
		Me.lblF8.Name = "lblF8"
		Me.lblF8.Size = New System.Drawing.Size(66, 23)
		Me.lblF8.TabIndex = 83
		Me.lblF8.Text = "."
		Me.lblF8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF12
		'
		Me.lblF12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF12.Location = New System.Drawing.Point(331, 221)
		Me.lblF12.Name = "lblF12"
		Me.lblF12.Size = New System.Drawing.Size(66, 23)
		Me.lblF12.TabIndex = 85
		Me.lblF12.Text = "."
		Me.lblF12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF4
		'
		Me.lblF4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF4.Location = New System.Drawing.Point(331, 117)
		Me.lblF4.Name = "lblF4"
		Me.lblF4.Size = New System.Drawing.Size(66, 23)
		Me.lblF4.TabIndex = 84
		Me.lblF4.Text = "."
		Me.lblF4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblIequDifPerF16
		'
		Me.lblIequDifPerF16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIequDifPerF16.Location = New System.Drawing.Point(397, 270)
		Me.lblIequDifPerF16.Name = "lblIequDifPerF16"
		Me.lblIequDifPerF16.Size = New System.Drawing.Size(66, 23)
		Me.lblIequDifPerF16.TabIndex = 78
		Me.lblIequDifPerF16.Text = "."
		Me.lblIequDifPerF16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblIequDifPerF8
		'
		Me.lblIequDifPerF8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIequDifPerF8.Location = New System.Drawing.Point(397, 169)
		Me.lblIequDifPerF8.Name = "lblIequDifPerF8"
		Me.lblIequDifPerF8.Size = New System.Drawing.Size(66, 23)
		Me.lblIequDifPerF8.TabIndex = 77
		Me.lblIequDifPerF8.Text = "."
		Me.lblIequDifPerF8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblIequDifPerF12
		'
		Me.lblIequDifPerF12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIequDifPerF12.Location = New System.Drawing.Point(397, 221)
		Me.lblIequDifPerF12.Name = "lblIequDifPerF12"
		Me.lblIequDifPerF12.Size = New System.Drawing.Size(66, 23)
		Me.lblIequDifPerF12.TabIndex = 80
		Me.lblIequDifPerF12.Text = "."
		Me.lblIequDifPerF12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblIequDifPerF4
		'
		Me.lblIequDifPerF4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblIequDifPerF4.Location = New System.Drawing.Point(397, 117)
		Me.lblIequDifPerF4.Name = "lblIequDifPerF4"
		Me.lblIequDifPerF4.Size = New System.Drawing.Size(66, 23)
		Me.lblIequDifPerF4.TabIndex = 79
		Me.lblIequDifPerF4.Text = "."
		Me.lblIequDifPerF4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label58
		'
		Me.Label58.Location = New System.Drawing.Point(464, 60)
		Me.Label58.Name = "Label58"
		Me.Label58.Size = New System.Drawing.Size(102, 23)
		Me.Label58.TabIndex = 76
		Me.Label58.Text = "NON-SIG %"
		Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label59
		'
		Me.Label59.Location = New System.Drawing.Point(397, 60)
		Me.Label59.Name = "Label59"
		Me.Label59.Size = New System.Drawing.Size(66, 23)
		Me.Label59.TabIndex = 75
		Me.Label59.Text = "EQU %"
		Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label60
		'
		Me.Label60.Location = New System.Drawing.Point(331, 60)
		Me.Label60.Name = "Label60"
		Me.Label60.Size = New System.Drawing.Size(66, 23)
		Me.Label60.TabIndex = 74
		Me.Label60.Text = "B$"
		Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label61
		'
		Me.Label61.Location = New System.Drawing.Point(264, 60)
		Me.Label61.Name = "Label61"
		Me.Label61.Size = New System.Drawing.Size(66, 23)
		Me.Label61.TabIndex = 73
		Me.Label61.Text = "BCM"
		Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblF14
		'
		Me.lblF14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF14.Location = New System.Drawing.Point(264, 247)
		Me.lblF14.Name = "lblF14"
		Me.lblF14.Size = New System.Drawing.Size(66, 23)
		Me.lblF14.TabIndex = 70
		Me.lblF14.Text = "."
		Me.lblF14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF6
		'
		Me.lblF6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF6.Location = New System.Drawing.Point(264, 143)
		Me.lblF6.Name = "lblF6"
		Me.lblF6.Size = New System.Drawing.Size(66, 23)
		Me.lblF6.TabIndex = 69
		Me.lblF6.Text = "."
		Me.lblF6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF10
		'
		Me.lblF10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF10.Location = New System.Drawing.Point(264, 195)
		Me.lblF10.Name = "lblF10"
		Me.lblF10.Size = New System.Drawing.Size(66, 23)
		Me.lblF10.TabIndex = 72
		Me.lblF10.Text = "."
		Me.lblF10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblF2
		'
		Me.lblF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblF2.Location = New System.Drawing.Point(264, 91)
		Me.lblF2.Name = "lblF2"
		Me.lblF2.Size = New System.Drawing.Size(66, 23)
		Me.lblF2.TabIndex = 71
		Me.lblF2.Text = "."
		Me.lblF2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label66
		'
		Me.Label66.Location = New System.Drawing.Point(148, 293)
		Me.Label66.Name = "Label66"
		Me.Label66.Size = New System.Drawing.Size(147, 23)
		Me.Label66.TabIndex = 62
		Me.Label66.Text = "Side-payment from Turkey"
		'
		'Label67
		'
		Me.Label67.Location = New System.Drawing.Point(148, 270)
		Me.Label67.Name = "Label67"
		Me.Label67.Size = New System.Drawing.Size(117, 23)
		Me.Label67.TabIndex = 63
		Me.Label67.Text = "Agriculture"
		'
		'Label68
		'
		Me.Label68.Location = New System.Drawing.Point(148, 247)
		Me.Label68.Name = "Label68"
		Me.Label68.Size = New System.Drawing.Size(117, 23)
		Me.Label68.TabIndex = 60
		Me.Label68.Text = "Agriculture"
		'
		'Label69
		'
		Me.Label69.Location = New System.Drawing.Point(148, 169)
		Me.Label69.Name = "Label69"
		Me.Label69.Size = New System.Drawing.Size(117, 23)
		Me.Label69.TabIndex = 61
		Me.Label69.Text = "Total"
		'
		'Label70
		'
		Me.Label70.Location = New System.Drawing.Point(148, 221)
		Me.Label70.Name = "Label70"
		Me.Label70.Size = New System.Drawing.Size(117, 23)
		Me.Label70.TabIndex = 64
		Me.Label70.Text = "Total"
		'
		'Label71
		'
		Me.Label71.Location = New System.Drawing.Point(148, 143)
		Me.Label71.Name = "Label71"
		Me.Label71.Size = New System.Drawing.Size(117, 23)
		Me.Label71.TabIndex = 67
		Me.Label71.Text = "Agriculture"
		'
		'Label72
		'
		Me.Label72.Location = New System.Drawing.Point(148, 195)
		Me.Label72.Name = "Label72"
		Me.Label72.Size = New System.Drawing.Size(117, 23)
		Me.Label72.TabIndex = 68
		Me.Label72.Text = "Agriculture"
		'
		'Label73
		'
		Me.Label73.Location = New System.Drawing.Point(148, 117)
		Me.Label73.Name = "Label73"
		Me.Label73.Size = New System.Drawing.Size(117, 23)
		Me.Label73.TabIndex = 65
		Me.Label73.Text = "Total"
		'
		'Label74
		'
		Me.Label74.Location = New System.Drawing.Point(148, 91)
		Me.Label74.Name = "Label74"
		Me.Label74.Size = New System.Drawing.Size(117, 23)
		Me.Label74.TabIndex = 66
		Me.Label74.Text = "Agriculture"
		'
		'Label75
		'
		Me.Label75.Location = New System.Drawing.Point(14, 247)
		Me.Label75.Name = "Label75"
		Me.Label75.Size = New System.Drawing.Size(136, 23)
		Me.Label75.TabIndex = 57
		Me.Label75.Text = "Cooperation outcomes"
		'
		'Label76
		'
		Me.Label76.Location = New System.Drawing.Point(14, 143)
		Me.Label76.Name = "Label76"
		Me.Label76.Size = New System.Drawing.Size(136, 23)
		Me.Label76.TabIndex = 56
		Me.Label76.Text = "Turkey implements its plans"
		'
		'Label77
		'
		Me.Label77.Location = New System.Drawing.Point(14, 195)
		Me.Label77.Name = "Label77"
		Me.Label77.Size = New System.Drawing.Size(136, 23)
		Me.Label77.TabIndex = 59
		Me.Label77.Text = "Iraq implements its plans"
		'
		'Label78
		'
		Me.Label78.Location = New System.Drawing.Point(14, 91)
		Me.Label78.Name = "Label78"
		Me.Label78.Size = New System.Drawing.Size(136, 23)
		Me.Label78.TabIndex = 58
		Me.Label78.Text = "Negotiation outcomes"
		'
		'tpaGraph1Iraq
		'
		Me.tpaGraph1Iraq.Controls.Add(Me.pboIraq1)
		Me.tpaGraph1Iraq.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph1Iraq.Name = "tpaGraph1Iraq"
		Me.tpaGraph1Iraq.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph1Iraq.Size = New System.Drawing.Size(597, 334)
		Me.tpaGraph1Iraq.TabIndex = 1
		Me.tpaGraph1Iraq.Text = "Equitable use"
		Me.tpaGraph1Iraq.UseVisualStyleBackColor = True
		'
		'pboIraq1
		'
		Me.pboIraq1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pboIraq1.Location = New System.Drawing.Point(3, 3)
		Me.pboIraq1.Name = "pboIraq1"
		Me.pboIraq1.Size = New System.Drawing.Size(591, 328)
		Me.pboIraq1.TabIndex = 17
		Me.pboIraq1.TabStop = False
		'
		'tpaGraph2Iraq
		'
		Me.tpaGraph2Iraq.Controls.Add(Me.pboIraq2)
		Me.tpaGraph2Iraq.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph2Iraq.Name = "tpaGraph2Iraq"
		Me.tpaGraph2Iraq.Size = New System.Drawing.Size(597, 334)
		Me.tpaGraph2Iraq.TabIndex = 2
		Me.tpaGraph2Iraq.Text = "Non significant harm"
		Me.tpaGraph2Iraq.UseVisualStyleBackColor = True
		'
		'pboIraq2
		'
		Me.pboIraq2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pboIraq2.Location = New System.Drawing.Point(0, 0)
		Me.pboIraq2.Name = "pboIraq2"
		Me.pboIraq2.Size = New System.Drawing.Size(597, 334)
		Me.pboIraq2.TabIndex = 17
		Me.pboIraq2.TabStop = False
		'
		'tpaGraph3Iraq
		'
		Me.tpaGraph3Iraq.Controls.Add(Me.pboIraq3)
		Me.tpaGraph3Iraq.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph3Iraq.Name = "tpaGraph3Iraq"
		Me.tpaGraph3Iraq.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph3Iraq.Size = New System.Drawing.Size(597, 334)
		Me.tpaGraph3Iraq.TabIndex = 3
		Me.tpaGraph3Iraq.Text = "Net benefits"
		Me.tpaGraph3Iraq.UseVisualStyleBackColor = True
		'
		'pboIraq3
		'
		Me.pboIraq3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pboIraq3.Location = New System.Drawing.Point(3, 3)
		Me.pboIraq3.Name = "pboIraq3"
		Me.pboIraq3.Size = New System.Drawing.Size(591, 328)
		Me.pboIraq3.TabIndex = 18
		Me.pboIraq3.TabStop = False
		'
		'tpaGraph4Iraq
		'
		Me.tpaGraph4Iraq.Controls.Add(Me.pboIraq4)
		Me.tpaGraph4Iraq.Location = New System.Drawing.Point(4, 22)
		Me.tpaGraph4Iraq.Name = "tpaGraph4Iraq"
		Me.tpaGraph4Iraq.Padding = New System.Windows.Forms.Padding(3)
		Me.tpaGraph4Iraq.Size = New System.Drawing.Size(597, 334)
		Me.tpaGraph4Iraq.TabIndex = 4
		Me.tpaGraph4Iraq.Text = "Overall net benefits"
		Me.tpaGraph4Iraq.UseVisualStyleBackColor = True
		'
		'pboIraq4
		'
		Me.pboIraq4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pboIraq4.Location = New System.Drawing.Point(3, 3)
		Me.pboIraq4.Name = "pboIraq4"
		Me.pboIraq4.Size = New System.Drawing.Size(591, 328)
		Me.pboIraq4.TabIndex = 19
		Me.pboIraq4.TabStop = False
		'
		'btnIraqiDisagree
		'
		Me.btnIraqiDisagree.Location = New System.Drawing.Point(296, 384)
		Me.btnIraqiDisagree.Name = "btnIraqiDisagree"
		Me.btnIraqiDisagree.Size = New System.Drawing.Size(90, 36)
		Me.btnIraqiDisagree.TabIndex = 2
		Me.btnIraqiDisagree.Text = "I Disagree"
		Me.btnIraqiDisagree.UseVisualStyleBackColor = True
		'
		'btnIraqiAgree
		'
		Me.btnIraqiAgree.Location = New System.Drawing.Point(197, 384)
		Me.btnIraqiAgree.Name = "btnIraqiAgree"
		Me.btnIraqiAgree.Size = New System.Drawing.Size(90, 36)
		Me.btnIraqiAgree.TabIndex = 1
		Me.btnIraqiAgree.Text = "I Agree"
		Me.btnIraqiAgree.UseVisualStyleBackColor = True
		'
		'grbConfidentialIraq
		'
		Me.grbConfidentialIraq.Controls.Add(Me.Label8)
		Me.grbConfidentialIraq.Controls.Add(Me.Label7)
		Me.grbConfidentialIraq.Controls.Add(Me.Label5)
		Me.grbConfidentialIraq.Controls.Add(Me.lblInshError)
		Me.grbConfidentialIraq.Controls.Add(Me.lblIsidpayError)
		Me.grbConfidentialIraq.Controls.Add(Me.lblImarwatError)
		Me.grbConfidentialIraq.Controls.Add(Me.nudImarwat)
		Me.grbConfidentialIraq.Controls.Add(Me.nudIsidpay)
		Me.grbConfidentialIraq.Controls.Add(Me.nudInsh)
		Me.grbConfidentialIraq.Controls.Add(Me.lblIsidpay)
		Me.grbConfidentialIraq.Controls.Add(Me.lblImarwat)
		Me.grbConfidentialIraq.Controls.Add(Me.lblInsh)
		Me.grbConfidentialIraq.ForeColor = System.Drawing.Color.Black
		Me.grbConfidentialIraq.Location = New System.Drawing.Point(33, 12)
		Me.grbConfidentialIraq.Name = "grbConfidentialIraq"
		Me.grbConfidentialIraq.Size = New System.Drawing.Size(630, 333)
		Me.grbConfidentialIraq.TabIndex = 26
		Me.grbConfidentialIraq.TabStop = False
		Me.grbConfidentialIraq.Text = "Confidential data (Billion Cubic Meters = BCM) to be provided by IRAQ"
		Me.grbConfidentialIraq.Visible = False
		'
		'Label8
		'
		Me.Label8.Location = New System.Drawing.Point(111, 128)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(35, 20)
		Me.Label8.TabIndex = 23
		Me.Label8.Text = "$/CM"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label7
		'
		Me.Label7.Location = New System.Drawing.Point(111, 83)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(35, 20)
		Me.Label7.TabIndex = 23
		Me.Label7.Text = "%"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label5
		'
		Me.Label5.Location = New System.Drawing.Point(111, 39)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(35, 20)
		Me.Label5.TabIndex = 23
		Me.Label5.Text = "BCM"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblInshError
		'
		Me.lblInshError.ForeColor = System.Drawing.Color.Red
		Me.lblInshError.Location = New System.Drawing.Point(150, 83)
		Me.lblInshError.Name = "lblInshError"
		Me.lblInshError.Size = New System.Drawing.Size(117, 20)
		Me.lblInshError.TabIndex = 22
		Me.lblInshError.Text = "Non-feasible value"
		Me.lblInshError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblInshError.Visible = False
		'
		'lblIsidpayError
		'
		Me.lblIsidpayError.ForeColor = System.Drawing.Color.Red
		Me.lblIsidpayError.Location = New System.Drawing.Point(150, 128)
		Me.lblIsidpayError.Name = "lblIsidpayError"
		Me.lblIsidpayError.Size = New System.Drawing.Size(117, 20)
		Me.lblIsidpayError.TabIndex = 21
		Me.lblIsidpayError.Text = "Non-feasible value"
		Me.lblIsidpayError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblIsidpayError.Visible = False
		'
		'lblImarwatError
		'
		Me.lblImarwatError.ForeColor = System.Drawing.Color.Red
		Me.lblImarwatError.Location = New System.Drawing.Point(150, 39)
		Me.lblImarwatError.Name = "lblImarwatError"
		Me.lblImarwatError.Size = New System.Drawing.Size(117, 20)
		Me.lblImarwatError.TabIndex = 20
		Me.lblImarwatError.Text = "Non-feasible value"
		Me.lblImarwatError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblImarwatError.Visible = False
		'
		'nudImarwat
		'
		Me.nudImarwat.DecimalPlaces = 3
		Me.nudImarwat.Location = New System.Drawing.Point(15, 39)
		Me.nudImarwat.Name = "nudImarwat"
		Me.nudImarwat.Size = New System.Drawing.Size(90, 20)
		Me.nudImarwat.TabIndex = 0
		Me.nudImarwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudIsidpay
		'
		Me.nudIsidpay.DecimalPlaces = 3
		Me.nudIsidpay.Location = New System.Drawing.Point(15, 128)
		Me.nudIsidpay.Name = "nudIsidpay"
		Me.nudIsidpay.Size = New System.Drawing.Size(90, 20)
		Me.nudIsidpay.TabIndex = 2
		Me.nudIsidpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudInsh
		'
		Me.nudInsh.DecimalPlaces = 3
		Me.nudInsh.Location = New System.Drawing.Point(15, 83)
		Me.nudInsh.Name = "nudInsh"
		Me.nudInsh.Size = New System.Drawing.Size(90, 20)
		Me.nudInsh.TabIndex = 1
		Me.nudInsh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblIsidpay
		'
		Me.lblIsidpay.AutoSize = True
		Me.lblIsidpay.Location = New System.Drawing.Point(15, 112)
		Me.lblIsidpay.Name = "lblIsidpay"
		Me.lblIsidpay.Size = New System.Drawing.Size(211, 13)
		Me.lblIsidpay.TabIndex = 4
		Me.lblIsidpay.Text = "Maximum side-payments to Turkey (Isidpay)"
		'
		'lblImarwat
		'
		Me.lblImarwat.AutoSize = True
		Me.lblImarwat.Location = New System.Drawing.Point(15, 23)
		Me.lblImarwat.Name = "lblImarwat"
		Me.lblImarwat.Size = New System.Drawing.Size(270, 13)
		Me.lblImarwat.TabIndex = 8
		Me.lblImarwat.Text = "Minimum acceptable water to Iraqi marshlands (Imarwat)"
		'
		'lblInsh
		'
		Me.lblInsh.AutoSize = True
		Me.lblInsh.Location = New System.Drawing.Point(15, 67)
		Me.lblInsh.Name = "lblInsh"
		Me.lblInsh.Size = New System.Drawing.Size(233, 13)
		Me.lblInsh.TabIndex = 19
		Me.lblInsh.Text = "Maximum acceptable non-significant harm (Insh)"
		'
		'grbConfidentialTurkey
		'
		Me.grbConfidentialTurkey.Controls.Add(Me.Label10)
		Me.grbConfidentialTurkey.Controls.Add(Me.Label11)
		Me.grbConfidentialTurkey.Controls.Add(Me.Label12)
		Me.grbConfidentialTurkey.Controls.Add(Me.lblTmarwatError)
		Me.grbConfidentialTurkey.Controls.Add(Me.lblTnshError)
		Me.grbConfidentialTurkey.Controls.Add(Me.lblTsidpayError)
		Me.grbConfidentialTurkey.Controls.Add(Me.nudTmarwat)
		Me.grbConfidentialTurkey.Controls.Add(Me.lblTmarwat)
		Me.grbConfidentialTurkey.Controls.Add(Me.nudTnsh)
		Me.grbConfidentialTurkey.Controls.Add(Me.lblTnsh)
		Me.grbConfidentialTurkey.Controls.Add(Me.nudTsidpay)
		Me.grbConfidentialTurkey.Controls.Add(Me.lblTsidpay)
		Me.grbConfidentialTurkey.ForeColor = System.Drawing.Color.Black
		Me.grbConfidentialTurkey.Location = New System.Drawing.Point(33, 12)
		Me.grbConfidentialTurkey.Name = "grbConfidentialTurkey"
		Me.grbConfidentialTurkey.Size = New System.Drawing.Size(630, 310)
		Me.grbConfidentialTurkey.TabIndex = 25
		Me.grbConfidentialTurkey.TabStop = False
		Me.grbConfidentialTurkey.Text = "Confidential data (Billion Cubic Meters = BCM) to be provided by TURKEY"
		Me.grbConfidentialTurkey.Visible = False
		'
		'Label10
		'
		Me.Label10.Location = New System.Drawing.Point(112, 129)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(35, 20)
		Me.Label10.TabIndex = 26
		Me.Label10.Text = "$/CM"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label11
		'
		Me.Label11.Location = New System.Drawing.Point(112, 80)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(35, 20)
		Me.Label11.TabIndex = 25
		Me.Label11.Text = "%"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label12
		'
		Me.Label12.Location = New System.Drawing.Point(112, 35)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(35, 20)
		Me.Label12.TabIndex = 24
		Me.Label12.Text = "BCM"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblTmarwatError
		'
		Me.lblTmarwatError.ForeColor = System.Drawing.Color.Red
		Me.lblTmarwatError.Location = New System.Drawing.Point(149, 35)
		Me.lblTmarwatError.Name = "lblTmarwatError"
		Me.lblTmarwatError.Size = New System.Drawing.Size(117, 20)
		Me.lblTmarwatError.TabIndex = 23
		Me.lblTmarwatError.Text = "Non-feasible value"
		Me.lblTmarwatError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblTmarwatError.Visible = False
		'
		'lblTnshError
		'
		Me.lblTnshError.ForeColor = System.Drawing.Color.Red
		Me.lblTnshError.Location = New System.Drawing.Point(149, 80)
		Me.lblTnshError.Name = "lblTnshError"
		Me.lblTnshError.Size = New System.Drawing.Size(117, 20)
		Me.lblTnshError.TabIndex = 22
		Me.lblTnshError.Text = "Non-feasible value"
		Me.lblTnshError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblTnshError.Visible = False
		'
		'lblTsidpayError
		'
		Me.lblTsidpayError.ForeColor = System.Drawing.Color.Red
		Me.lblTsidpayError.Location = New System.Drawing.Point(149, 129)
		Me.lblTsidpayError.Name = "lblTsidpayError"
		Me.lblTsidpayError.Size = New System.Drawing.Size(117, 20)
		Me.lblTsidpayError.TabIndex = 21
		Me.lblTsidpayError.Text = "Non-feasible value"
		Me.lblTsidpayError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblTsidpayError.Visible = False
		'
		'nudTmarwat
		'
		Me.nudTmarwat.DecimalPlaces = 3
		Me.nudTmarwat.Location = New System.Drawing.Point(16, 35)
		Me.nudTmarwat.Name = "nudTmarwat"
		Me.nudTmarwat.Size = New System.Drawing.Size(90, 20)
		Me.nudTmarwat.TabIndex = 0
		Me.nudTmarwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblTmarwat
		'
		Me.lblTmarwat.AutoSize = True
		Me.lblTmarwat.Location = New System.Drawing.Point(16, 19)
		Me.lblTmarwat.Name = "lblTmarwat"
		Me.lblTmarwat.Size = New System.Drawing.Size(277, 13)
		Me.lblTmarwat.TabIndex = 4
		Me.lblTmarwat.Text = "Maximum acceptable water to Iraqi marshlands (Tmarwat)"
		'
		'nudTnsh
		'
		Me.nudTnsh.DecimalPlaces = 3
		Me.nudTnsh.Location = New System.Drawing.Point(16, 80)
		Me.nudTnsh.Name = "nudTnsh"
		Me.nudTnsh.Size = New System.Drawing.Size(90, 20)
		Me.nudTnsh.TabIndex = 1
		Me.nudTnsh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblTnsh
		'
		Me.lblTnsh.AutoSize = True
		Me.lblTnsh.Location = New System.Drawing.Point(16, 64)
		Me.lblTnsh.Name = "lblTnsh"
		Me.lblTnsh.Size = New System.Drawing.Size(237, 13)
		Me.lblTnsh.TabIndex = 8
		Me.lblTnsh.Text = "Maximum acceptable non-significant harm (Tnsh)"
		'
		'nudTsidpay
		'
		Me.nudTsidpay.DecimalPlaces = 3
		Me.nudTsidpay.Location = New System.Drawing.Point(16, 129)
		Me.nudTsidpay.Name = "nudTsidpay"
		Me.nudTsidpay.Size = New System.Drawing.Size(90, 20)
		Me.nudTsidpay.TabIndex = 2
		Me.nudTsidpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblTsidpay
		'
		Me.lblTsidpay.AutoSize = True
		Me.lblTsidpay.Location = New System.Drawing.Point(16, 113)
		Me.lblTsidpay.Name = "lblTsidpay"
		Me.lblTsidpay.Size = New System.Drawing.Size(200, 13)
		Me.lblTsidpay.TabIndex = 4
		Me.lblTsidpay.Text = "Maximum side-payments to Iraq (Tsidpay)"
		'
		'grbCommonBenefitTurkey
		'
		Me.grbCommonBenefitTurkey.Controls.Add(Me.Label37)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.Label38)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.Label45)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.Label46)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.Label44)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.Label43)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.Label42)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.Label41)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.lblTmaxpolintc)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.nudTmaxpolintc)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.nudTa)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.nudTc)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.nudTf)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.lblTc)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.lblTa)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.lblTf)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.nudTd)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.nudTb)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.nudTe)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.lblTb)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.nudTg)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.lblTe)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.lblTg)
		Me.grbCommonBenefitTurkey.Controls.Add(Me.lblTd)
		Me.grbCommonBenefitTurkey.ForeColor = System.Drawing.Color.Black
		Me.grbCommonBenefitTurkey.Location = New System.Drawing.Point(33, 12)
		Me.grbCommonBenefitTurkey.Name = "grbCommonBenefitTurkey"
		Me.grbCommonBenefitTurkey.Size = New System.Drawing.Size(630, 310)
		Me.grbCommonBenefitTurkey.TabIndex = 23
		Me.grbCommonBenefitTurkey.TabStop = False
		Me.grbCommonBenefitTurkey.Text = "Common data on benefits and costs (Billion USD = B$) to be provided by TURKEY"
		Me.grbCommonBenefitTurkey.Visible = False
		'
		'Label37
		'
		Me.Label37.Location = New System.Drawing.Point(105, 264)
		Me.Label37.Name = "Label37"
		Me.Label37.Size = New System.Drawing.Size(65, 20)
		Me.Label37.TabIndex = 43
		Me.Label37.Text = "$ per capita"
		Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label38
		'
		Me.Label38.Location = New System.Drawing.Point(105, 175)
		Me.Label38.Name = "Label38"
		Me.Label38.Size = New System.Drawing.Size(35, 20)
		Me.Label38.TabIndex = 42
		Me.Label38.Text = "%"
		Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label45
		'
		Me.Label45.Location = New System.Drawing.Point(364, 131)
		Me.Label45.Name = "Label45"
		Me.Label45.Size = New System.Drawing.Size(35, 20)
		Me.Label45.TabIndex = 41
		Me.Label45.Text = "$/CM"
		Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label46
		'
		Me.Label46.Location = New System.Drawing.Point(364, 264)
		Me.Label46.Name = "Label46"
		Me.Label46.Size = New System.Drawing.Size(35, 20)
		Me.Label46.TabIndex = 41
		Me.Label46.Text = "B$"
		Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label44
		'
		Me.Label44.Location = New System.Drawing.Point(105, 222)
		Me.Label44.Name = "Label44"
		Me.Label44.Size = New System.Drawing.Size(35, 20)
		Me.Label44.TabIndex = 41
		Me.Label44.Text = "$/CM"
		Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label43
		'
		Me.Label43.Location = New System.Drawing.Point(105, 131)
		Me.Label43.Name = "Label43"
		Me.Label43.Size = New System.Drawing.Size(35, 20)
		Me.Label43.TabIndex = 41
		Me.Label43.Text = "$/CM"
		Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label42
		'
		Me.Label42.Location = New System.Drawing.Point(105, 87)
		Me.Label42.Name = "Label42"
		Me.Label42.Size = New System.Drawing.Size(35, 20)
		Me.Label42.TabIndex = 41
		Me.Label42.Text = "$/CM"
		Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label41
		'
		Me.Label41.Location = New System.Drawing.Point(105, 43)
		Me.Label41.Name = "Label41"
		Me.Label41.Size = New System.Drawing.Size(35, 20)
		Me.Label41.TabIndex = 41
		Me.Label41.Text = "$/CM"
		Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblTmaxpolintc
		'
		Me.lblTmaxpolintc.AutoSize = True
		Me.lblTmaxpolintc.Location = New System.Drawing.Point(269, 248)
		Me.lblTmaxpolintc.Name = "lblTmaxpolintc"
		Me.lblTmaxpolintc.Size = New System.Drawing.Size(293, 13)
		Me.lblTmaxpolintc.TabIndex = 40
		Me.lblTmaxpolintc.Text = "Missed advantages from not joining the European Union (Th)"
		'
		'nudTmaxpolintc
		'
		Me.nudTmaxpolintc.DecimalPlaces = 3
		Me.nudTmaxpolintc.Location = New System.Drawing.Point(269, 264)
		Me.nudTmaxpolintc.Name = "nudTmaxpolintc"
		Me.nudTmaxpolintc.Size = New System.Drawing.Size(90, 20)
		Me.nudTmaxpolintc.TabIndex = 7
		Me.nudTmaxpolintc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudTa
		'
		Me.nudTa.DecimalPlaces = 5
		Me.nudTa.Location = New System.Drawing.Point(10, 43)
		Me.nudTa.Name = "nudTa"
		Me.nudTa.Size = New System.Drawing.Size(90, 20)
		Me.nudTa.TabIndex = 0
		Me.nudTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudTc
		'
		Me.nudTc.DecimalPlaces = 5
		Me.nudTc.Location = New System.Drawing.Point(10, 131)
		Me.nudTc.Name = "nudTc"
		Me.nudTc.Size = New System.Drawing.Size(90, 20)
		Me.nudTc.TabIndex = 2
		Me.nudTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudTf
		'
		Me.nudTf.DecimalPlaces = 5
		Me.nudTf.Location = New System.Drawing.Point(11, 264)
		Me.nudTf.Name = "nudTf"
		Me.nudTf.Size = New System.Drawing.Size(90, 20)
		Me.nudTf.TabIndex = 5
		Me.nudTf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblTc
		'
		Me.lblTc.AutoSize = True
		Me.lblTc.Location = New System.Drawing.Point(7, 115)
		Me.lblTc.Name = "lblTc"
		Me.lblTc.Size = New System.Drawing.Size(244, 13)
		Me.lblTc.TabIndex = 27
		Me.lblTc.Text = "Additional costs due to unmet energy demand (Tc)"
		'
		'lblTa
		'
		Me.lblTa.AutoSize = True
		Me.lblTa.Location = New System.Drawing.Point(13, 27)
		Me.lblTa.Name = "lblTa"
		Me.lblTa.Size = New System.Drawing.Size(469, 13)
		Me.lblTa.TabIndex = 37
		Me.lblTa.Text = "Average agricultural GDP ($) per additional water (CM), net of costs for hydrauli" & _
	"c infrastructure (Ta)"
		'
		'lblTf
		'
		Me.lblTf.AutoSize = True
		Me.lblTf.Location = New System.Drawing.Point(12, 248)
		Me.lblTf.Name = "lblTf"
		Me.lblTf.Size = New System.Drawing.Size(235, 13)
		Me.lblTf.TabIndex = 28
		Me.lblTf.Text = "National pride associated to the GAP project (Tf)"
		'
		'nudTd
		'
		Me.nudTd.DecimalPlaces = 5
		Me.nudTd.Location = New System.Drawing.Point(10, 175)
		Me.nudTd.Name = "nudTd"
		Me.nudTd.Size = New System.Drawing.Size(90, 20)
		Me.nudTd.TabIndex = 3
		Me.nudTd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudTb
		'
		Me.nudTb.DecimalPlaces = 5
		Me.nudTb.Location = New System.Drawing.Point(10, 87)
		Me.nudTb.Name = "nudTb"
		Me.nudTb.Size = New System.Drawing.Size(90, 20)
		Me.nudTb.TabIndex = 1
		Me.nudTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudTe
		'
		Me.nudTe.DecimalPlaces = 5
		Me.nudTe.Location = New System.Drawing.Point(10, 222)
		Me.nudTe.Name = "nudTe"
		Me.nudTe.Size = New System.Drawing.Size(90, 20)
		Me.nudTe.TabIndex = 4
		Me.nudTe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblTb
		'
		Me.lblTb.AutoSize = True
		Me.lblTb.Location = New System.Drawing.Point(12, 71)
		Me.lblTb.Name = "lblTb"
		Me.lblTb.Size = New System.Drawing.Size(348, 13)
		Me.lblTb.TabIndex = 33
		Me.lblTb.Text = "Opportunity cost of using thermal rather than hydropower production (Tb)"
		'
		'nudTg
		'
		Me.nudTg.DecimalPlaces = 5
		Me.nudTg.Location = New System.Drawing.Point(269, 131)
		Me.nudTg.Name = "nudTg"
		Me.nudTg.Size = New System.Drawing.Size(90, 20)
		Me.nudTg.TabIndex = 6
		Me.nudTg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblTe
		'
		Me.lblTe.AutoSize = True
		Me.lblTe.Location = New System.Drawing.Point(8, 207)
		Me.lblTe.Name = "lblTe"
		Me.lblTe.Size = New System.Drawing.Size(276, 13)
		Me.lblTe.TabIndex = 32
		Me.lblTe.Text = "Additional interest rate if financed by domestic bonds (Te)"
		'
		'lblTg
		'
		Me.lblTg.AutoSize = True
		Me.lblTg.Location = New System.Drawing.Point(269, 115)
		Me.lblTg.Name = "lblTg"
		Me.lblTg.Size = New System.Drawing.Size(174, 13)
		Me.lblTg.TabIndex = 34
		Me.lblTg.Text = "Average water treatement cost (Tg)"
		'
		'lblTd
		'
		Me.lblTd.AutoSize = True
		Me.lblTd.Location = New System.Drawing.Point(12, 156)
		Me.lblTd.Name = "lblTd"
		Me.lblTd.Size = New System.Drawing.Size(526, 13)
		Me.lblTd.TabIndex = 38
		Me.lblTd.Text = "Percentage of new crops planned to be exported * the shadow exchange rate / the o" & _
	"fficial exchange rate (Td)"
		'
		'grbCommonBenefitsIraq
		'
		Me.grbCommonBenefitsIraq.Controls.Add(Me.Label51)
		Me.grbCommonBenefitsIraq.Controls.Add(Me.Label50)
		Me.grbCommonBenefitsIraq.Controls.Add(Me.Label47)
		Me.grbCommonBenefitsIraq.Controls.Add(Me.nudIa)
		Me.grbCommonBenefitsIraq.Controls.Add(Me.nudIb)
		Me.grbCommonBenefitsIraq.Controls.Add(Me.nudIc)
		Me.grbCommonBenefitsIraq.Controls.Add(Me.lblIa)
		Me.grbCommonBenefitsIraq.Controls.Add(Me.lblIb)
		Me.grbCommonBenefitsIraq.Controls.Add(Me.lblIc)
		Me.grbCommonBenefitsIraq.ForeColor = System.Drawing.Color.Black
		Me.grbCommonBenefitsIraq.Location = New System.Drawing.Point(33, 12)
		Me.grbCommonBenefitsIraq.Name = "grbCommonBenefitsIraq"
		Me.grbCommonBenefitsIraq.Size = New System.Drawing.Size(630, 310)
		Me.grbCommonBenefitsIraq.TabIndex = 24
		Me.grbCommonBenefitsIraq.TabStop = False
		Me.grbCommonBenefitsIraq.Text = "Common data on benefits and costs to be provided by IRAQ"
		Me.grbCommonBenefitsIraq.Visible = False
		'
		'Label51
		'
		Me.Label51.Location = New System.Drawing.Point(105, 126)
		Me.Label51.Name = "Label51"
		Me.Label51.Size = New System.Drawing.Size(35, 20)
		Me.Label51.TabIndex = 26
		Me.Label51.Text = "$/CM"
		Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label50
		'
		Me.Label50.Location = New System.Drawing.Point(105, 85)
		Me.Label50.Name = "Label50"
		Me.Label50.Size = New System.Drawing.Size(35, 20)
		Me.Label50.TabIndex = 26
		Me.Label50.Text = "$/CM"
		Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label47
		'
		Me.Label47.Location = New System.Drawing.Point(105, 42)
		Me.Label47.Name = "Label47"
		Me.Label47.Size = New System.Drawing.Size(35, 20)
		Me.Label47.TabIndex = 26
		Me.Label47.Text = "$/CM"
		Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'nudIa
		'
		Me.nudIa.DecimalPlaces = 5
		Me.nudIa.Location = New System.Drawing.Point(10, 42)
		Me.nudIa.Name = "nudIa"
		Me.nudIa.Size = New System.Drawing.Size(90, 20)
		Me.nudIa.TabIndex = 0
		Me.nudIa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudIb
		'
		Me.nudIb.DecimalPlaces = 5
		Me.nudIb.Location = New System.Drawing.Point(10, 85)
		Me.nudIb.Name = "nudIb"
		Me.nudIb.Size = New System.Drawing.Size(90, 20)
		Me.nudIb.TabIndex = 1
		Me.nudIb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'nudIc
		'
		Me.nudIc.DecimalPlaces = 5
		Me.nudIc.Location = New System.Drawing.Point(10, 126)
		Me.nudIc.Name = "nudIc"
		Me.nudIc.Size = New System.Drawing.Size(90, 20)
		Me.nudIc.TabIndex = 3
		Me.nudIc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblIa
		'
		Me.lblIa.AutoSize = True
		Me.lblIa.Location = New System.Drawing.Point(10, 26)
		Me.lblIa.Name = "lblIa"
		Me.lblIa.Size = New System.Drawing.Size(465, 13)
		Me.lblIa.TabIndex = 4
		Me.lblIa.Text = "Average agricultural GDP ($) per additional water (CM), net of costs for hydrauli" & _
	"c infrastructure (Ia)"
		'
		'lblIb
		'
		Me.lblIb.AutoSize = True
		Me.lblIb.Location = New System.Drawing.Point(10, 69)
		Me.lblIb.Name = "lblIb"
		Me.lblIb.Size = New System.Drawing.Size(453, 13)
		Me.lblIb.TabIndex = 4
		Me.lblIb.Text = "Opportunity cost from using thermal rather than hydropower production per BCM of " & _
	"irrigation (Ib)"
		'
		'lblIc
		'
		Me.lblIc.AutoSize = True
		Me.lblIc.Location = New System.Drawing.Point(10, 110)
		Me.lblIc.Name = "lblIc"
		Me.lblIc.Size = New System.Drawing.Size(240, 13)
		Me.lblIc.TabIndex = 4
		Me.lblIc.Text = "Additional costs due to unmet energy demand (Ic)"
		'
		'grbCommonBoth
		'
		Me.grbCommonBoth.Controls.Add(Me.Label39)
		Me.grbCommonBoth.Controls.Add(Me.nudStotwat)
		Me.grbCommonBoth.Controls.Add(Me.lblStotwat)
		Me.grbCommonBoth.ForeColor = System.Drawing.Color.Black
		Me.grbCommonBoth.Location = New System.Drawing.Point(33, 12)
		Me.grbCommonBoth.Name = "grbCommonBoth"
		Me.grbCommonBoth.Size = New System.Drawing.Size(630, 310)
		Me.grbCommonBoth.TabIndex = 22
		Me.grbCommonBoth.TabStop = False
		Me.grbCommonBoth.Text = "Common data on water flows and demands (Billion Cubic Meters = BCM) to be provide" & _
	"d by BOTH TURKEY AND IRAQ"
		Me.grbCommonBoth.Visible = False
		'
		'Label39
		'
		Me.Label39.Location = New System.Drawing.Point(105, 42)
		Me.Label39.Name = "Label39"
		Me.Label39.Size = New System.Drawing.Size(35, 20)
		Me.Label39.TabIndex = 24
		Me.Label39.Text = "BCM"
		Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'nudStotwat
		'
		Me.nudStotwat.DecimalPlaces = 3
		Me.nudStotwat.Location = New System.Drawing.Point(10, 42)
		Me.nudStotwat.Name = "nudStotwat"
		Me.nudStotwat.Size = New System.Drawing.Size(90, 20)
		Me.nudStotwat.TabIndex = 0
		Me.nudStotwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblStotwat
		'
		Me.lblStotwat.AutoSize = True
		Me.lblStotwat.Location = New System.Drawing.Point(7, 25)
		Me.lblStotwat.Name = "lblStotwat"
		Me.lblStotwat.Size = New System.Drawing.Size(153, 13)
		Me.lblStotwat.TabIndex = 4
		Me.lblStotwat.Text = "Water allocated to Syria (Swat)"
		'
		'frmNegotiation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(723, 454)
		Me.Controls.Add(Me.grbCommonWaterIraq)
		Me.Controls.Add(Me.grbCommonWaterTurkey)
		Me.Controls.Add(Me.grbNegotiationOutcome)
		Me.Controls.Add(Me.grbConfidentialWaterTurkey)
		Me.Controls.Add(Me.grbConfidentialWaterIraq)
		Me.Controls.Add(Me.grbConfidentialIraq)
		Me.Controls.Add(Me.grbConfidentialTurkey)
		Me.Controls.Add(Me.grbCommonBenefitTurkey)
		Me.Controls.Add(Me.grbCommonBenefitsIraq)
		Me.Controls.Add(Me.grbCommonBoth)
		Me.Controls.Add(Me.btnPrev)
		Me.Controls.Add(Me.btnNext)
		Me.Name = "frmNegotiation"
		Me.Text = "NSS for Iraq - Turkey water disputes"
		CType(Me.DatiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DSParameters, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ParametersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dsOldIraqiConstraints, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dsOldTurkishConstraints, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DSDefaultData, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DSData, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbCommonWaterIraq.ResumeLayout(False)
		Me.grbCommonWaterIraq.PerformLayout()
		CType(Me.nudIminagrwat, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudImaxagrwat, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudIindwat, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInavwat, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudIpop, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudIwatper, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbCommonWaterTurkey.ResumeLayout(False)
		Me.grbCommonWaterTurkey.PerformLayout()
		CType(Me.nudTminagrwat, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTeva, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTindwat, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTret, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTminenewat, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTmaxintwat, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTpop, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTwatper, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTmaxagrwat, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbNegotiationOutcome.ResumeLayout(False)
		CType(Me.pboOutcome, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbConfidentialWaterTurkey.ResumeLayout(False)
		Me.tcoTurkey.ResumeLayout(False)
		Me.tpaDataTurkey.ResumeLayout(False)
		Me.tpaGraph1Turkey.ResumeLayout(False)
		CType(Me.pboTurkey1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph2Turkey.ResumeLayout(False)
		CType(Me.pboTurkey2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph3Turkey.ResumeLayout(False)
		CType(Me.pboTurkey3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph4Turkey.ResumeLayout(False)
		CType(Me.pboTurkey4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbConfidentialWaterIraq.ResumeLayout(False)
		Me.tcoIraq.ResumeLayout(False)
		Me.tpaDataIraq.ResumeLayout(False)
		Me.tpaGraph1Iraq.ResumeLayout(False)
		CType(Me.pboIraq1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph2Iraq.ResumeLayout(False)
		CType(Me.pboIraq2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph3Iraq.ResumeLayout(False)
		CType(Me.pboIraq3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.tpaGraph4Iraq.ResumeLayout(False)
		CType(Me.pboIraq4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbConfidentialIraq.ResumeLayout(False)
		Me.grbConfidentialIraq.PerformLayout()
		CType(Me.nudImarwat, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudIsidpay, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudInsh, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbConfidentialTurkey.ResumeLayout(False)
		Me.grbConfidentialTurkey.PerformLayout()
		CType(Me.nudTmarwat, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTnsh, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTsidpay, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbCommonBenefitTurkey.ResumeLayout(False)
		Me.grbCommonBenefitTurkey.PerformLayout()
		CType(Me.nudTmaxpolintc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTa, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTc, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTf, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTd, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTb, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTe, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudTg, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbCommonBenefitsIraq.ResumeLayout(False)
		Me.grbCommonBenefitsIraq.PerformLayout()
		CType(Me.nudIa, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudIb, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.nudIc, System.ComponentModel.ISupportInitialize).EndInit()
		Me.grbCommonBoth.ResumeLayout(False)
		Me.grbCommonBoth.PerformLayout()
		CType(Me.nudStotwat, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents nudTmaxagrwat As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTpop As System.Windows.Forms.Label
	Friend WithEvents nudTpop As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTmaxintwat As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTminenewat As System.Windows.Forms.Label
	Friend WithEvents nudTminenewat As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTindwat As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTminagrwat As System.Windows.Forms.Label
	Friend WithEvents nudTminagrwat As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTwatper As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudImaxagrwat As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTret As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTret As System.Windows.Forms.Label
	Friend WithEvents nudTeva As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudIpop As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblIpop As System.Windows.Forms.Label
	Friend WithEvents nudInavwat As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudImarwat As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblImarwat As System.Windows.Forms.Label
	Friend WithEvents nudIindwat As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudStotwat As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTmarwat As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblStotwat As System.Windows.Forms.Label
	Friend WithEvents nudTsidpay As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTmarwat As System.Windows.Forms.Label
	Friend WithEvents lblTsidpay As System.Windows.Forms.Label
	Friend WithEvents nudTnsh As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTnsh As System.Windows.Forms.Label
	Friend WithEvents nudIwatper As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblIwatper As System.Windows.Forms.Label
	Friend WithEvents nudIsidpay As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblIsidpay As System.Windows.Forms.Label
	Friend WithEvents nudInsh As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudIa As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudIb As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudIc As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblIa As System.Windows.Forms.Label
	Friend WithEvents lblIb As System.Windows.Forms.Label
	Friend WithEvents lblIc As System.Windows.Forms.Label
	Friend WithEvents DatiBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents grbCommonWaterTurkey As NSSGroupBox
	Friend WithEvents lblIindwat As System.Windows.Forms.Label
	Friend WithEvents lblTeva As System.Windows.Forms.Label
	Friend WithEvents lblTindwat As System.Windows.Forms.Label
	Friend WithEvents lblInsh As System.Windows.Forms.Label
	Friend WithEvents lblInavwat As System.Windows.Forms.Label
	Friend WithEvents lblImaxagrwat As System.Windows.Forms.Label
	Friend WithEvents lblTmaxintwat As System.Windows.Forms.Label
	Friend WithEvents lblTwatper As System.Windows.Forms.Label
	Friend WithEvents lblTmaxagrwat As System.Windows.Forms.Label
	Friend WithEvents grbCommonWaterIraq As NSSGroupBox
	Friend WithEvents grbCommonBoth As NSSGroupBox
	Friend WithEvents grbCommonBenefitTurkey As NSSGroupBox
	Friend WithEvents nudTa As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTc As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTd As System.Windows.Forms.Label
	Friend WithEvents nudTf As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTc As System.Windows.Forms.Label
	Friend WithEvents lblTa As System.Windows.Forms.Label
	Friend WithEvents lblTf As System.Windows.Forms.Label
	Friend WithEvents nudTd As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTb As System.Windows.Forms.NumericUpDown
	Friend WithEvents nudTe As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTb As System.Windows.Forms.Label
	Friend WithEvents nudTg As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblTe As System.Windows.Forms.Label
	Friend WithEvents lblTg As System.Windows.Forms.Label
	Friend WithEvents lblTmaxpolintc As System.Windows.Forms.Label
	Friend WithEvents nudTmaxpolintc As System.Windows.Forms.NumericUpDown
	Friend WithEvents grbCommonBenefitsIraq As NSSGroupBox
	Friend WithEvents grbConfidentialTurkey As NSSGroupBox
	Friend WithEvents grbConfidentialIraq As NSSGroupBox
	Friend WithEvents grbConfidentialWaterIraq As NSSGroupBox
	Friend WithEvents grbConfidentialWaterTurkey As NSSGroupBox
	Friend WithEvents btnNext As System.Windows.Forms.Button
	Friend WithEvents btnIraqiDisagree As System.Windows.Forms.Button
	Friend WithEvents btnIraqiAgree As System.Windows.Forms.Button
	Friend WithEvents btnTurkishDisagree As System.Windows.Forms.Button
	Friend WithEvents btnTurkishAgree As System.Windows.Forms.Button
	Friend WithEvents btnPrev As System.Windows.Forms.Button
	Friend WithEvents lblIminagrwat As System.Windows.Forms.Label
	Friend WithEvents nudIminagrwat As System.Windows.Forms.NumericUpDown
	Friend WithEvents dsOldTurkishConstraints As MathematicaUI.oldTurkishConstraints
	Friend WithEvents DataBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents DatIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmaxagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTminagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTindwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTminenewatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmaxintwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTpopDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTwatperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTpopwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTevaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTretDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatImaxagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIminagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIindwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatImarwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInavwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIpopDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIwatperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIpopwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatStotwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatOwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTfDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmaxpolintcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTmarwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTsidpayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIsidpayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTagrwatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF13DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF14DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF15DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF16DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF17DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatF18DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshthrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTequDifPerF15DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTnshDifPerF15DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatIequDifPerF16DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatInshDifPerF16DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DatTurkishAgreementDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents DatIraqiAgreementDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents DataCreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents UtenteCreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataAggiornamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents UtenteAggiornamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents AnnullatoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents DataEstrazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents dsOldIraqiConstraints As MathematicaUI.oldIraqiConstraints
	Friend WithEvents DataBindingSource2 As System.Windows.Forms.BindingSource
	Friend WithEvents DataTableAdapter1 As MathematicaUI.oldIraqiConstraintsTableAdapters.dataTableAdapter
	Friend WithEvents lblInshError As System.Windows.Forms.Label
	Friend WithEvents lblIsidpayError As System.Windows.Forms.Label
	Friend WithEvents lblImarwatError As System.Windows.Forms.Label
	Friend WithEvents lblTmarwatError As System.Windows.Forms.Label
	Friend WithEvents lblTnshError As System.Windows.Forms.Label
	Friend WithEvents lblTsidpayError As System.Windows.Forms.Label
	Friend WithEvents DSParameters As MathematicaUI.parameters
    Friend WithEvents ParametersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParametersTableAdapter As MathematicaUI.parametersTableAdapters.parametersTableAdapter
    Friend WithEvents grbNegotiationOutcome As MathematicaUI.NSSGroupBox
    Friend WithEvents lblNegotiationOutcome As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
	Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
	Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents tcoTurkey As System.Windows.Forms.TabControl
    Friend WithEvents tpaGraph1Turkey As System.Windows.Forms.TabPage
    Friend WithEvents pboTurkey1 As System.Windows.Forms.PictureBox
    Friend WithEvents tpaGraph2Turkey As System.Windows.Forms.TabPage
    Friend WithEvents pboTurkey2 As System.Windows.Forms.PictureBox
    Friend WithEvents tpaDataTurkey As System.Windows.Forms.TabPage
    Friend WithEvents lblTnshDifPerF15 As System.Windows.Forms.Label
    Friend WithEvents lblTnshDifPerF7 As System.Windows.Forms.Label
    Friend WithEvents lblTnshDifPerF11 As System.Windows.Forms.Label
    Friend WithEvents lblTnshDifPerF3 As System.Windows.Forms.Label
    Friend WithEvents lblF17 As System.Windows.Forms.Label
    Friend WithEvents lblF15 As System.Windows.Forms.Label
    Friend WithEvents lblF7 As System.Windows.Forms.Label
    Friend WithEvents lblF11 As System.Windows.Forms.Label
    Friend WithEvents lblF3 As System.Windows.Forms.Label
    Friend WithEvents lblTequDifPerF15 As System.Windows.Forms.Label
    Friend WithEvents lblTequDifPerF7 As System.Windows.Forms.Label
    Friend WithEvents lblTequDifPerF11 As System.Windows.Forms.Label
    Friend WithEvents lblTequDifPerF3 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblF13 As System.Windows.Forms.Label
    Friend WithEvents lblF5 As System.Windows.Forms.Label
    Friend WithEvents lblF9 As System.Windows.Forms.Label
    Friend WithEvents lblF1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblAgriculture As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblOutcomes As System.Windows.Forms.Label
    Friend WithEvents tcoIraq As System.Windows.Forms.TabControl
    Friend WithEvents tpaDataIraq As System.Windows.Forms.TabPage
    Friend WithEvents lblInshDifPerF16 As System.Windows.Forms.Label
    Friend WithEvents lblInshDifPerF8 As System.Windows.Forms.Label
    Friend WithEvents lblInshDifPerF12 As System.Windows.Forms.Label
    Friend WithEvents lblInshDifPerF4 As System.Windows.Forms.Label
    Friend WithEvents lblF18 As System.Windows.Forms.Label
    Friend WithEvents lblF16 As System.Windows.Forms.Label
    Friend WithEvents lblF8 As System.Windows.Forms.Label
    Friend WithEvents lblF12 As System.Windows.Forms.Label
    Friend WithEvents lblF4 As System.Windows.Forms.Label
    Friend WithEvents lblIequDifPerF16 As System.Windows.Forms.Label
    Friend WithEvents lblIequDifPerF8 As System.Windows.Forms.Label
    Friend WithEvents lblIequDifPerF12 As System.Windows.Forms.Label
    Friend WithEvents lblIequDifPerF4 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents lblF14 As System.Windows.Forms.Label
    Friend WithEvents lblF6 As System.Windows.Forms.Label
    Friend WithEvents lblF10 As System.Windows.Forms.Label
    Friend WithEvents lblF2 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents tpaGraph1Iraq As System.Windows.Forms.TabPage
    Friend WithEvents tpaGraph2Iraq As System.Windows.Forms.TabPage
    Friend WithEvents pboIraq1 As System.Windows.Forms.PictureBox
    Friend WithEvents pboIraq2 As System.Windows.Forms.PictureBox
    Friend WithEvents tpaGraph3Iraq As System.Windows.Forms.TabPage
    Friend WithEvents pboIraq3 As System.Windows.Forms.PictureBox
    Friend WithEvents tpaGraph3Turkey As System.Windows.Forms.TabPage
    Friend WithEvents pboTurkey3 As System.Windows.Forms.PictureBox
    Friend WithEvents tpaGraph4Iraq As System.Windows.Forms.TabPage
    Friend WithEvents pboIraq4 As System.Windows.Forms.PictureBox
    Friend WithEvents tpaGraph4Turkey As System.Windows.Forms.TabPage
    Friend WithEvents pboTurkey4 As System.Windows.Forms.PictureBox
    Friend WithEvents DSDefaultData As MathematicaUI.NSSforTWJDataSet1
    Friend WithEvents DataBindingSource1 As System.Windows.Forms.BindingSource
	Friend WithEvents TADefaultData As MathematicaUI.NSSforTWJDataSet1TableAdapters.datiTableAdapter
	Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
	Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
	Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
	Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
	Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
	Friend WithEvents DAData As System.Data.SqlClient.SqlDataAdapter
	Friend WithEvents DAParameters As System.Data.SqlClient.SqlDataAdapter
	Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
	Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
	Friend WithEvents DSData As MathematicaUI.DSData
	Friend WithEvents DataTableAdapter As MathematicaUI.oldTurkishConstraintsTableAdapters.dataTableAdapter
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents Label48 As System.Windows.Forms.Label
	Friend WithEvents Label49 As System.Windows.Forms.Label
	Friend WithEvents pboOutcome As System.Windows.Forms.PictureBox
	Friend WithEvents lblGraphLabel As System.Windows.Forms.Label

End Class
