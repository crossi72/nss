Public Class frmNegotiation

#Region " Variables and constants "

	Private Const digits As Integer = 5

	'record ID for data table
	Private ID As Integer

	Private myMathWrapper As MW.MathWrapper

	Private groupBoxesID As Integer
	Private groupBoxes(9) As NSSGroupBox

	'variables for negotiation outcome
	Private turkishAgree, iraqiAgree As Boolean

	'mathematica algorithm variables
	Private Tmaxagrwat, Tminagrwat, Tindwat, Tminenewat As Double
	Private Tmaxintwat, Tpop, Twatper, Tpopwat, Teva, Tret As Double
	Private Imaxagrwat, Iminagrwat, Iindwat, Imarwat As Double
	Private Inavwat, Ipop, Iwatper, Ipopwat, Stotwat As Double
	Private Owat, Ta, Tb, Tc, Td, Te, Tg, Tf, Tmaxpolintc As Double
	Private Ia, Ib, Ic, Tmarwat, Tnsh, Tsidpay, Insh As Double
	Private Isidpay, Tagrwat, Tnb, OnbSOL As Double
	Private F1, F2, F3, F4, F5, F6, F7, F8, F9, F10 As Double
	Private F11, F12, F13, F14, F15, F16, F17, F18 As Double
	Private Iequthr, Tequthr, Inshthr, Tnshthr As Double
	Private TequDifPerF3, TequDifPerF7, TequDifPerF11, TequDifPerF15 As Double
	Private TnshDifPerF3, TnshDifPerF7, TnshDifPerF11, TnshDifPerF15 As Double
	Private IequDifPerF4, IequDifPerF8, IequDifPerF12, IequDifPerF16 As Double
	Private InshDifPerF4, InshDifPerF8, InshDifPerF12, InshDifPerF16 As Double

	'variables for dinamic constraints
	Private oldTmarWat, oldTnsh, oldTsidpay, oldImarWat, oldInsh As Double
	Private oldIsidpay, oldTagrwat, oldTnb, oldIagrwat, oldInb As Double
	Private oldF2, oldF4, oldF1, oldF3 As Double

	Private Enum enumTurkeyIraq
		Iraq = 0
		Turkey = 1
	End Enum

#End Region

#Region " New "

	Public Sub New()

		' Chiamata richiesta da Progettazione Windows Form.
		InitializeComponent()

		' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
		Me.SqlConnection1.ConnectionString = My.Settings.NSSConnectionString
		If Me.Init() Then
			'init groupBoxes array
			Me.groupBoxes(0) = Me.grbCommonWaterTurkey
			Me.groupBoxes(1) = Me.grbCommonWaterIraq
			Me.groupBoxes(2) = Me.grbCommonBoth
			Me.groupBoxes(3) = Me.grbCommonBenefitTurkey
			Me.groupBoxes(4) = Me.grbCommonBenefitsIraq
			Me.groupBoxes(5) = Me.grbConfidentialTurkey
			Me.groupBoxes(6) = Me.grbConfidentialIraq
			Me.groupBoxes(7) = Me.grbConfidentialWaterTurkey
			Me.groupBoxes(8) = Me.grbConfidentialWaterIraq
			Me.groupBoxes(9) = Me.grbNegotiationOutcome

			Me.groupBoxesID = 0
			Me.ShowBox()
			Me.ReadDinamicConstraints()
		Else
			End
		End If
	End Sub

#End Region

#Region " Private methods "

	''' <summary>
	''' resets data to defaults
	''' </summary>
	''' <remarks></remarks>
	Private Sub Reset()
		Dim tmpDataRowView As DataRowView

		If MessageBox.Show("Are you sure you want to reset data to default values?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
			'read data from DB
			Me.TADefaultData.Fill(Me.DSDefaultData.dati)

			If Me.DSDefaultData.dati.DefaultView.Count <> 0 Then
				tmpDataRowView = Me.DSData.data.DefaultView.Item(0)

				Me.nudTmaxagrwat.Value = tmpDataRowView.Item("datTmaxagrwat")
				Me.nudTminagrwat.Value = tmpDataRowView.Item("datTminagrwat")
				Me.nudTindwat.Value = tmpDataRowView.Item("datTindwat")
				Me.nudTminenewat.Value = tmpDataRowView.Item("datTminenewat")
				Me.nudTmaxintwat.Value = tmpDataRowView.Item("datTmaxintwat")
				Me.nudTpop.Value = tmpDataRowView.Item("datTpop")
				Me.nudTwatper.Value = tmpDataRowView.Item("datTwatper")
				Me.nudTeva.Value = tmpDataRowView.Item("datTeva")
				Me.nudTret.Value = tmpDataRowView.Item("datTret")
				Me.nudStotwat.Value = tmpDataRowView.Item("datStotwat")
				Me.nudTa.Value = tmpDataRowView.Item("datTa")
				Me.nudTb.Value = tmpDataRowView.Item("datTb")
				Me.nudTc.Value = tmpDataRowView.Item("datTc")
				Me.nudTd.Value = tmpDataRowView.Item("datTd")
				Me.nudTe.Value = tmpDataRowView.Item("datTe")
				Me.nudTg.Value = tmpDataRowView.Item("datTg")
				Me.nudTf.Value = tmpDataRowView.Item("datTf")
				Me.nudTmaxpolintc.Value = tmpDataRowView.Item("datTmaxpolintc")
				Me.nudTmarwat.Value = tmpDataRowView.Item("datTmarwat")
				Me.nudTnsh.Value = tmpDataRowView.Item("datTnsh")
				Me.nudTsidpay.Value = tmpDataRowView.Item("datTsidpay")
				Me.nudImaxagrwat.Value = tmpDataRowView.Item("datImaxagrwat")
				Me.nudIminagrwat.Value = tmpDataRowView.Item("datIminagrwat")
				Me.nudIindwat.Value = tmpDataRowView.Item("datIindwat")
				Me.nudImarwat.Value = tmpDataRowView.Item("datImarwat")
				Me.nudInavwat.Value = tmpDataRowView.Item("datInavwat")
				Me.nudIpop.Value = tmpDataRowView.Item("datIpop")
				Me.nudIwatper.Value = tmpDataRowView.Item("datIwatper")
				Me.nudIa.Value = tmpDataRowView.Item("datIa")
				Me.nudIb.Value = tmpDataRowView.Item("datIb")
				Me.nudIc.Value = tmpDataRowView.Item("datIc")
				Me.nudInsh.Value = tmpDataRowView.Item("datInsh")
				Me.nudIsidpay.Value = tmpDataRowView.Item("datIsidpay")
			Else
				'no data in DB
				Me.nudTmaxagrwat.Value = 0
				Me.nudTminagrwat.Value = 0
				Me.nudTindwat.Value = 0
				Me.nudTminenewat.Value = 0
				Me.nudTmaxintwat.Value = 0
				Me.nudTpop.Value = 0
				Me.nudTwatper.Value = 0
				Me.nudTeva.Value = 0
				Me.nudTret.Value = 0
				Me.nudStotwat.Value = 0
				Me.nudTa.Value = 0
				Me.nudTb.Value = 0
				Me.nudTc.Value = 0
				Me.nudTd.Value = 0
				Me.nudTe.Value = 0
				Me.nudTg.Value = 0
				Me.nudTf.Value = 0
				Me.nudTmaxpolintc.Value = 0
				Me.nudTmarwat.Value = 0
				Me.nudTnsh.Value = 0
				Me.nudTsidpay.Value = 0
				Me.nudImaxagrwat.Value = 0
				Me.nudIminagrwat.Value = 0
				Me.nudIindwat.Value = 0
				Me.nudImarwat.Value = 0
				Me.nudInavwat.Value = 0
				Me.nudIpop.Value = 0
				Me.nudIwatper.Value = 0
				Me.nudIa.Value = 0
				Me.nudIb.Value = 0
				Me.nudIc.Value = 0
				Me.nudInsh.Value = 0
				Me.nudIsidpay.Value = 0
			End If
		End If
	End Sub

	''' <summary>
	''' change text on btnNext
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetNextText()
		If Me.groupBoxesID = 6 Then
			Me.btnNext.Text = "Calculate"
		Else
			Me.btnNext.Text = "Next"
		End If
	End Sub

	''' <summary>
	''' change text on btnPrev
	''' </summary>
	''' <remarks></remarks>
	Private Sub SetPrevText()
		If Me.groupBoxesID = 0 Then
			Me.btnPrev.Text = "Reset"
		Else
			Me.btnPrev.Text = "Previous"
		End If
	End Sub

	''' <summary>
	''' show previous input/output panel
	''' </summary>
	''' <remarks></remarks>
	Private Sub PreviousStep()
		Me.groupBoxesID -= 1
		Me.ShowBox()
	End Sub

	''' <summary>
	''' show next input/output panel
	''' </summary>
	''' <remarks></remarks>
	Private Sub NextStep()
		Dim ProbOwat As Double
		Dim skip As Boolean

		Me.groupBoxesID += 1
		skip = False

		Me.SetPrevText()

		If Me.groupBoxesID = Me.groupBoxes.Length Then
			Me.Close()
		Else
			If Me.groupBoxesID = 3 Then
				Me.myMathWrapper.WaitAndDiscardAnswer("a = 9.57249")
				Me.myMathWrapper.WaitAndDiscardAnswer("b = 161.728*31536/1000000")
				Me.ReadValues()
				Me.Owat = Me.myMathWrapper.WaitAndEvaluateAsDouble("Owat = NIntegrate[x*PDF[GammaDistribution[a, b], x], {x, " & Me.Tminagrwat.ToString.Replace(",", ".") & " + " & Me.Tindwat.ToString.Replace(",", ".") & " + " & Me.Tminenewat.ToString.Replace(",", ".") & " + " & Me.Tpopwat.ToString.Replace(",", ".") & " + " & Me.Iminagrwat.ToString.Replace(",", ".") & " + " & Me.Iindwat.ToString.Replace(",", ".") & " + " & Me.Inavwat.ToString.Replace(",", ".") & " + " & Me.Ipopwat.ToString.Replace(",", ".") & " + " & Me.Stotwat.ToString.Replace(",", ".") & ", 150}]")
				ProbOwat = Me.myMathWrapper.WaitAndEvaluateAsDouble("ProbOwat = NIntegrate[PDF[GammaDistribution[a, b], x], {x, " & Me.Tminagrwat.ToString.Replace(",", ".") & " + " & Me.Tindwat.ToString.Replace(",", ".") & " + " & Me.Tminenewat.ToString.Replace(",", ".") & " + " & Me.Tpopwat.ToString.Replace(",", ".") & " + " & Me.Iminagrwat.ToString.Replace(",", ".") & " + " & Me.Iindwat.ToString.Replace(",", ".") & " + " & Me.Inavwat.ToString.Replace(",", ".") & " + " & Me.Ipopwat.ToString.Replace(",", ".") & " + " & Me.Stotwat.ToString.Replace(",", ".") & ", 150}]")
				If MessageBox.Show("Expected water to be allocated " & Format(Me.Owat, "0.000") & " BCM" & ControlChars.CrLf & "Probability that the water to be allocated is positive " & Format(ProbOwat * 100, "0.00") & "%", "The statistical significance level of negotiation outcomes", MessageBoxButtons.OKCancel) <> Windows.Forms.DialogResult.OK Then
					skip = True
				End If
			End If

			If Not skip Then
				If Me.groupBoxesID < Me.groupBoxes.Length - 3 Then
					Me.btnPrev.Visible = True
					Me.btnNext.Visible = True
				Else
					Me.btnPrev.Visible = False
					Me.btnNext.Visible = False
				End If

				If Me.groupBoxesID = Me.groupBoxes.Length - 3 Then
					'end of input phase
					Me.Enabled = False
					Me.Cursor = Cursors.WaitCursor
					Me.Calculate()
					Me.Enabled = True
					Me.Cursor = Cursors.Default
				End If

				Me.ShowBox()

				If Me.groupBoxesID = Me.groupBoxes.Length Then
					Me.Close()
				End If
			End If
		End If
	End Sub

	''' <summary>
	''' shows current groupBox
	''' </summary>
	''' <remarks></remarks>
	Private Sub ShowBox()
		Dim i As Integer

		Me.SetPrevText()
		Me.SetNextText()

		For i = 0 To Me.groupBoxes.Length - 1
			Me.groupBoxes(i).Visible = False
		Next

		Me.groupBoxes(Me.groupBoxesID).NSSVisible = True
	End Sub

	''' <summary>
	''' execute computation using Wolfram Mathematica kernel
	''' </summary>
	''' <remarks></remarks>
	Private Sub Calculate()
		Me.ReadValues()

		Me.DAData.Fill(Me.dsData)

		If Me.DSData.data.Rows.Count > 0 Then
			'there are some data in 'data' table
			Me.ID = DirectCast(Me.DSData.data.Rows(0).Item("datID"), Integer) + 1
		Else
			'table is empty
			Me.ID = 1
		End If

		'Me.myMathWrapper.WaitAndDiscardAnswer("Solve[Iagrwat == Owat - Stotwat - Tpopwat - Tindwat - Ipopwat - Iindwat - Inavwat - Imarwat + Teva*Tagrwat - (1 - Tret) Tagrwat, Tagrwat]")
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tmaxagrwat = " & Tmaxagrwat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tminagrwat  = " & Tminagrwat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tindwat = " & Tindwat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tminenewat = " & Tminenewat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tmaxintwat = " & Tmaxintwat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tpop = " & Tpop.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Twatper = " & Twatper.ToString.Replace(","c, "."c))

		Me.Tpopwat = Me.myMathWrapper.WaitAndEvaluateAsDouble("Tpopwat = Twatper*Tpop/1000")

		Me.myMathWrapper.WaitAndEvaluateAsDouble("Teva = " & Teva.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tret = " & Tret.ToString.Replace(","c, "."c))

		Me.myMathWrapper.WaitAndEvaluateAsDouble("Imaxagrwat = " & Imaxagrwat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Iminagrwat = " & Iminagrwat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Iindwat = " & Iindwat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Inavwat = " & Inavwat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Ipop = " & Ipop.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Iwatper = " & Iwatper.ToString.Replace(","c, "."c))

		Me.Ipopwat = Me.myMathWrapper.WaitAndEvaluateAsDouble("Ipopwat = Iwatper*Ipop/1000")

		Me.myMathWrapper.WaitAndEvaluateAsDouble("Stotwat = " & Stotwat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Owat = " & Owat.ToString.Replace(","c, "."c))

		Me.myMathWrapper.WaitAndEvaluateAsDouble("Ta = " & Ta.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tb = " & Tb.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tc = " & Tc.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Td = " & Td.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Te = " & Te.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tf = " & Tf.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tg = " & Tg.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tmaxpolintc = " & Tmaxpolintc.ToString.Replace(","c, "."c))

		Me.myMathWrapper.WaitAndEvaluateAsDouble("Ia = " & Ia.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Ib = " & Ib.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Ic = " & Ic.ToString.Replace(","c, "."c))

		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tmarwat = " & Tmarwat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tnsh = " & Tnsh.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Tsidpay = " & Tsidpay.ToString.Replace(","c, "."c))

		Me.myMathWrapper.WaitAndEvaluateAsDouble("Imarwat = " & Imarwat.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Insh = " & Insh.ToString.Replace(","c, "."c))
		Me.myMathWrapper.WaitAndEvaluateAsDouble("Isidpay = " & Isidpay.ToString.Replace(","c, "."c))

		Me.myMathWrapper.WaitAndDiscardAnswer("Tagrwat  = .")
		Me.myMathWrapper.WaitAndDiscardAnswer("Iagrwat = .")

		'end of initaliazions, begin of calculations
		Me.myMathWrapper.WaitAndDiscardAnswer("Tecodomb = Piecewise[{{Ta*Tagrwat, Tagrwat <= Tmaxagrwat}, {Ta*Tmaxagrwat, Tagrwat > Tmaxagrwat}}]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Tecodomc = Piecewise[{{Tb*Tagrwat, Tagrwat <= Tminenewat}, {(Tb + Tc)*Tagrwat, Tagrwat > Tminenewat}}]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Tecointb = Td * Tecodomb")
		Me.myMathWrapper.WaitAndDiscardAnswer("Tecointc = Piecewise[{{0, Tagrwat <= Tmaxintwat}, {Te*Tagrwat, Tagrwat > Tmaxintwat}}]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Tpolintc = Piecewise[{{0, Tagrwat <= Tmaxintwat}, {Tmaxpolintc, Tagrwat > Tmaxintwat}}]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Tpoldomb = Piecewise[{{Tf*Tagrwat, Tagrwat <= Tmaxagrwat}, {Tf*Tmaxagrwat, Tagrwat > Tmaxagrwat}}]")
		Me.myMathWrapper.WaitAndDiscardAnswer("Twatquac = Tg *Tagrwat")
		Me.myMathWrapper.WaitAndDiscardAnswer("Tnb = Tecodomb + Tecointb + Tpoldomb - Tecodomc - Tecointc - Tpolintc - Twatquac")

		Me.myMathWrapper.WaitAndDiscardAnswer("Inb = Piecewise[{{Ia Iagrwat, Iagrwat <= Imaxagrwat}, {Ia*Imaxagrwat, Iagrwat > Imaxagrwat}}]")
		Me.myMathWrapper.WaitAndDiscardAnswer("InbT = Piecewise[{{Ia Iagrwat, Iagrwat <= Imaxagrwat}, {Ia*Imaxagrwat, Iagrwat > Imaxagrwat}}]  /. Iagrwat -> Owat - Stotwat - Tpopwat - Tindwat - Ipopwat - Iindwat - Inavwat - Tmarwat + Teva*Tagrwat - (1 - Tret) Tagrwat")

		Me.myMathWrapper.WaitAndDiscardAnswer("TnbT = Tnb /. Tagrwat -> (Iagrwat + Iindwat + Tmarwat + Inavwat + Ipopwat - Owat + Stotwat + Tindwat + Tpopwat)/(-1 + Teva + Tret)")

		Me.myMathWrapper.WaitAndDiscardAnswer("Onb = Tnb + InbT")

		Me.F5 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F5 = Tmaxagrwat")
		Me.F6 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F6 = Owat-Stotwat-Tpopwat-Tindwat-Ipopwat-Iindwat-Inavwat-Tmarwat+Teva*Tagrwat-(1-Tret) Tagrwat /.Tagrwat->F5")
		Me.F7 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F7 = Tnb /. Tagrwat -> F5")
		Me.F8 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F8 = Inb /. Iagrwat -> F6")
		Me.myMathWrapper.WaitAndDiscardAnswer("F8min = Inb /. Iagrwat -> Iminagrwat")

		Me.F10 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F10 = Imaxagrwat")
		Me.F9 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F9 = (Owat-Stotwat-Tpopwat-Tindwat-Ipopwat-Iindwat-Inavwat-Tmarwat-Iagrwat)/((1-Tret)-Teva) /.Iagrwat->F10")
		Me.F11 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F11 = Tnb /. Tagrwat -> F9")
		Me.myMathWrapper.WaitAndDiscardAnswer("F11min = Tnb /. Tagrwat -> Tminagrwat")

		Me.F12 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F12 = Inb /. Iagrwat -> F10")
		Me.myMathWrapper.WaitAndDiscardAnswer("F8nn = If[F8 > F8min, F8, F8min]")
		Me.myMathWrapper.WaitAndDiscardAnswer("F11nn = If[F11 > F11min, F11, F11min]")

		Try
			Me.F1 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F1 = Tagrwat /. Last[NMaximize[{Tnb, F12 - Insh*F12 <= InbT && (F12 - InbT)/(F12 - F8nn) <= (F7 - Tnb)/(F7 - F11nn) && Tagrwat >= Tminagrwat && Tagrwat <= Tmaxagrwat}, {Tagrwat}]]")
		Catch ex As Exception
			MessageBox.Show("water inputs might not be feasible", "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Application.Exit()
			End
		End Try

		Me.F2 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F2 = Owat- Stotwat - Tpopwat - Tindwat - Ipopwat -Iindwat - Inavwat -Tmarwat+Teva*Tagrwat-(1-Tret)* Tagrwat /.Tagrwat->F1")
		Me.F3 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F3 = Tnb /. Tagrwat -> F1")
		Me.F4 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F4 = Inb /. Iagrwat -> F2")
		Me.F13 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F13 = Tagrwat /. Last[NMaximize[{Onb, Tagrwat >= Tminagrwat && Tagrwat <= Tmaxagrwat}, {Tagrwat}]]")

		OnbSOL = Me.myMathWrapper.WaitAndEvaluateAsDouble("OnbSOL = Onb /.Tagrwat->F13")

		Me.F14 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F14 = Owat-Stotwat-Tpopwat-Tindwat - Ipopwat - Iindwat - Inavwat - Tmarwat+Teva*Tagrwat-(1-Tret) Tagrwat/.Tagrwat->F13")
		Me.F15 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F15 = OnbSOL/2+(F1-F13)*Isidpay")
		Me.F16 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F16 = OnbSOL/2+(F2-F14)*Tsidpay")
		Me.F17 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F17 = Round[(F1-F13)*Isidpay, 0.001]")
		Me.F18 = Me.myMathWrapper.WaitAndEvaluateAsDouble("F18 = Round[(F2-F14)*Tsidpay, 0.001]")

		'Me.myMathWrapper.WaitAndDiscardAnswer("FindRoot[InbT == (F12 - ((F12 - F8) ((F7 - Tnb)/(F7 - F11)))), {Tagrwat, 0}]")
		'Me.myMathWrapper.WaitAndDiscardAnswer("FindRoot[Tnb == (F7 - ((F7 - F11) ((F12 - InbT)/(F12 - F8)))), {Tagrwat, 0}]")
		'Me.myMathWrapper.WaitAndDiscardAnswer("FindRoot[Insh == ((F12 - InbT)/F12), {Tagrwat, 0}]")
		'Me.myMathWrapper.WaitAndDiscardAnswer("FindRoot[Tnsh == ((F7 - Tnb)/F7), {Tagrwat, 0}]")

		Me.pboIraq1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("If[F12 - F8nn > 0, Plot[(Inb - F12 + (F12 - F8nn) ((F7 - TnbT)/(F7 - F11nn))), {Iagrwat, 0, Imaxagrwat}, AxesLabel -> {""Iagrwat, BCM"", ""Equitable use for Iraq, B$""}, Filling -> True], Plot[(Inb + F12 - (F12 - F8nn) ((F7 - TnbT)/(F7 - F11nn))), {Iagrwat, 0, Imaxagrwat}, AxesLabel -> {""Iagrwat, BCM"", ""Equitable use for Iraq, B$""}, Filling -> True]]", Me.pboIraq1.Width, Me.pboIraq1.Height)
		Me.pboTurkey1.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("If[F7 - F11 > 0, Plot[(Tnb - F7 + ((F7 - F11) ((F12 - InbT)/(F12 - F8nn)))), {Tagrwat, 0, Tmaxagrwat}, AxesLabel -> {""Tagrwat, BCM"", ""Equitable use for Turkey, B$""}, Filling -> True], Plot[(Tnb + F7 - ((F7 - F11nn) ((F12 - InbT)/(F12 - F8nn)))), {Tagrwat, 0, Tmaxagrwat}, AxesLabel -> {""Tagrwat, BCM"", ""Equitable use for Turkey, B$""}, Filling -> True]]", Me.pboTurkey1.Width, Me.pboTurkey1.Height)
		Me.pboIraq2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[100 (Insh - ((F12 - Inb)/F12)), {Iagrwat, 0, Imaxagrwat}, AxesLabel -> {""Iagrwat, BCM"", ""Non-significan harm for Iraq, %""}, Filling -> True]", Me.pboIraq2.Width, Me.pboIraq2.Height)
		Me.pboTurkey2.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[100 (Tnsh - ((F7 - Tnb)/F7)), {Tagrwat, 0, Tmaxagrwat}, AxesLabel -> {""Tagrwat, BCM"", ""Non-significan harm for Turkey, %""}, Filling -> True]", Me.pboTurkey2.Width, Me.pboTurkey2.Height)
		Me.pboIraq3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[Inb, {Iagrwat, 0, Imaxagrwat}, AxesLabel -> {""Iagrwat, BCM"", ""Inb, B$""}, Filling -> True]", Me.pboIraq3.Width, Me.pboIraq3.Height)
		Me.pboTurkey3.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[Tnb, {Tagrwat, 0, Tmaxagrwat}, AxesLabel -> {""Tagrwat, BCM"", ""Tnb, B$""}, Filling -> True]", Me.pboTurkey3.Width, Me.pboTurkey3.Height)
		Me.pboIraq4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[Onb, {Tagrwat, 0, Tmaxagrwat}, AxesLabel -> {""Tagrwat, BCM"", ""Onb, B$""}, Filling -> True]", Me.pboIraq4.Width, Me.pboIraq4.Height)
		Me.pboTurkey4.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Plot[Onb, {Tagrwat, 0, Tmaxagrwat}, AxesLabel -> {""Tagrwat, BCM"", ""Onb, B$""}, Filling -> True]", Me.pboTurkey4.Width, Me.pboTurkey4.Height)

		Me.Iequthr = Me.myMathWrapper.WaitAndEvaluateAsDouble("Iequthr = Iagrwat /. FindRoot[Inb == (F12 - ((F12 - F8nn) ((F7 - TnbT)/(F7 - F11nn)))), {Iagrwat, 0, Imaxagrwat}]")
		Me.Tequthr = Me.myMathWrapper.WaitAndEvaluateAsDouble("Tequthr = Tagrwat /. FindRoot[Tnb == (F7 - ((F7 - F11nn) ((F12 - InbT)/(F12 - F8nn)))), {Tagrwat, 0, Tmaxagrwat}]")
		Me.Inshthr = Me.myMathWrapper.WaitAndEvaluateAsDouble("Inshthr = Iagrwat /. FindRoot[Insh == ((F12 - Inb)/F12), {Iagrwat, 0, Imaxagrwat}]")
		Me.Tnshthr = Me.myMathWrapper.WaitAndEvaluateAsDouble("Tnshthr = Tagrwat /. FindRoot[Tnsh == ((F7 - Tnb)/F7), {Tagrwat, 0, Tmaxagrwat}]")

		'equitable  Turkey
		Me.TequDifPerF3 = Me.myMathWrapper.WaitAndEvaluateAsDouble("TequDifPerF3 = (F3/Tnb - 1)*100 /. Tagrwat -> Tequthr")
		Me.TequDifPerF7 = Me.myMathWrapper.WaitAndEvaluateAsDouble("TequDifPerF7 = (F7/Tnb - 1)*100 /. Tagrwat -> Tequthr")
		Me.TequDifPerF11 = Me.myMathWrapper.WaitAndEvaluateAsDouble("TequDifPerF11 = (F11/Tnb - 1)*100 /. Tagrwat -> Tequthr")
		Me.TequDifPerF15 = Me.myMathWrapper.WaitAndEvaluateAsDouble("TequDifPerF15 = (F15/Tnb - 1 )*100 /. Tagrwat -> Tequthr")

		'harm Turkey
		Me.TnshDifPerF3 = Me.myMathWrapper.WaitAndEvaluateAsDouble("TnshDifPerF3 = (F3/Tnb - 1)*100 /. Tagrwat -> Tnshthr")
		Me.TnshDifPerF7 = Me.myMathWrapper.WaitAndEvaluateAsDouble("TnshDifPerF7 = (F7/Tnb - 1 )*100 /. Tagrwat -> Tnshthr")
		Me.TnshDifPerF11 = Me.myMathWrapper.WaitAndEvaluateAsDouble("TnshDifPerF11 = (F11/Tnb - 1)*100 /. Tagrwat -> Tnshthr")
		Me.TnshDifPerF15 = Me.myMathWrapper.WaitAndEvaluateAsDouble("TnshDifPerF15 = (F15/Tnb - 1 )*100 /. Tagrwat -> Tnshthr")

		'equitable  Iraq
		Me.IequDifPerF4 = Me.myMathWrapper.WaitAndEvaluateAsDouble("IequDifPerF4 = (F4/Inb - 1 )*100 /. Iagrwat -> Iequthr")
		Me.IequDifPerF8 = Me.myMathWrapper.WaitAndEvaluateAsDouble("IequDifPerF8 = (F8/Inb - 1)*100 /. Iagrwat -> Iequthr")
		Me.IequDifPerF12 = Me.myMathWrapper.WaitAndEvaluateAsDouble("IequDifPerF12 = (F12/Inb - 1 )*100 /. Iagrwat -> Iequthr")
		Me.IequDifPerF16 = Me.myMathWrapper.WaitAndEvaluateAsDouble("IequDifPerF16 = (F16/Inb - 1 )*100 /. Iagrwat -> Iequthr")

		'harm Iraq
		Me.InshDifPerF4 = Me.myMathWrapper.WaitAndEvaluateAsDouble("InshDifPerF4 = (F4/Inb - 1 )*100 /. Iagrwat -> Inshthr")
		Me.InshDifPerF8 = Me.myMathWrapper.WaitAndEvaluateAsDouble("InshDifPerF8 = (F8/Inb - 1)*100 /. Iagrwat -> Inshthr")
		Me.InshDifPerF12 = Me.myMathWrapper.WaitAndEvaluateAsDouble("InshDifPerF12 = (F12/Inb - 1 )*100 /. Iagrwat -> Inshthr")
		Me.InshDifPerF16 = Me.myMathWrapper.WaitAndEvaluateAsDouble("InshDifPerF16 = (F16/Inb - 1 )*100 /. Iagrwat -> Inshthr")

		Me.WriteValues()
		Me.WriteValuesToDB()
	End Sub

	''' <summary>
	''' writes data into DB
	''' </summary>
	''' <remarks></remarks>
	Private Sub WriteValuesToDB()
		Dim newRow As DataRow

		newRow = Me.DSData.Tables("data").NewRow

		'newRow("datID") = DBNull.Value
		newRow("datTmaxagrwat") = Me.Tmaxagrwat
		newRow("datTminagrwat") = Me.Tminagrwat
		newRow("datTindwat") = Me.Tindwat
		newRow("datTminenewat") = Me.Tminenewat
		newRow("datTmaxintwat") = Me.Tmaxintwat
		newRow("datTpop") = Me.Tpop
		newRow("datTwatper") = Me.Twatper
		newRow("datTpopwat") = Me.Tpopwat
		newRow("datTeva") = Me.Teva * 100
		newRow("datTret") = Me.Tret * 100
		newRow("datImaxagrwat") = Me.Imaxagrwat
		newRow("datIminagrwat") = Me.Iminagrwat
		newRow("datIindwat") = Me.Iindwat
		newRow("datImarwat") = Me.Imarwat
		newRow("datInavwat") = Me.Inavwat
		newRow("datIpop") = Me.Ipop
		newRow("datIwatper") = Me.Iwatper
		newRow("datIpopwat") = Me.Ipopwat
		newRow("datStotwat") = Me.Stotwat
		newRow("datOwat") = Me.Owat
		newRow("datTa") = Me.Ta
		newRow("datTb") = Me.Tb
		newRow("datTc") = Me.Tc
		newRow("datTd") = Me.Td * 100
		newRow("datTe") = Me.Te
		newRow("datTf") = Me.Tf
		newRow("datTg") = Me.Tg
		newRow("datTmaxpolintc") = Me.Tmaxpolintc
		newRow("datIa") = Me.Ia
		newRow("datIb") = Me.Ib
		newRow("datIc") = Me.Ic
		newRow("datTmarwat") = Me.Tmarwat
		newRow("datTnsh") = Me.Tnsh * 100
		newRow("datTsidpay") = Me.Tsidpay
		newRow("datInsh") = Me.Insh * 100
		newRow("datIsidpay") = Me.Isidpay
		newRow("datTagrwat") = Me.Tagrwat
		newRow("datTnb") = Me.Tnb
		newRow("datF1") = Me.F1
		newRow("datF2") = Me.F2
		newRow("datF3") = Me.F3
		newRow("datF4") = Me.F4
		newRow("datF5") = Me.F5
		newRow("datF6") = Me.F6
		newRow("datF7") = Me.F7
		newRow("datF8") = Me.F8
		newRow("datF9") = Me.F9
		newRow("datF10") = Me.F10
		newRow("datF11") = Me.F11
		newRow("datF12") = Me.F12
		newRow("datF13") = Me.F13
		newRow("datF14") = Me.F14
		newRow("datF15") = Me.F15
		newRow("datF16") = Me.F16
		newRow("datF17") = Me.F17
		newRow("datF18") = Me.F18
		newRow("datIequthr") = Me.Iequthr
		newRow("datTequthr") = Me.Tequthr
		newRow("datInshthr") = Me.Inshthr
		newRow("datTnshthr") = Me.Tnshthr
		newRow("datTequDifPerF3") = Me.TequDifPerF3
		newRow("datTequDifPerF7") = Me.TequDifPerF7
		newRow("datTequDifPerF11") = Me.TequDifPerF11
		newRow("datTequDifPerF15") = Me.TequDifPerF15
		newRow("datTnshDifPerF3") = Me.TnshDifPerF3
		newRow("datTnshDifPerF7") = Me.TnshDifPerF7
		newRow("datTnshDifPerF11") = Me.TnshDifPerF11
		newRow("datTnshDifPerF15") = Me.TnshDifPerF15
		newRow("datIequDifPerF4") = Me.IequDifPerF4
		newRow("datIequDifPerF8") = Me.IequDifPerF8
		newRow("datIequDifPerF12") = Me.IequDifPerF12
		newRow("datIequDifPerF16") = Me.IequDifPerF16
		newRow("datInshDifPerF4") = Me.InshDifPerF4
		newRow("datInshDifPerF8") = Me.InshDifPerF8
		newRow("datInshDifPerF12") = Me.InshDifPerF12
		newRow("datInshDifPerF16") = Me.InshDifPerF16

		newRow("DataCreazione") = Now
		newRow("UtenteCreazione") = 1
		newRow("DataAggiornamento") = Now
		newRow("UtenteAggiornamento") = 1
		newRow("Annullato") = 0
		newRow.EndEdit()

		Me.DSData.Tables("data").Rows.Add(newRow)

		Me.DAData.Update(Me.DSData, "data")
	End Sub

	''' <summary>
	''' write results tu GUI
	''' </summary>
	''' <remarks></remarks>
	Private Sub WriteValues()
		Me.nudTmaxagrwat.Value = Me.Tmaxagrwat
		Me.nudTminagrwat.Value = Me.Tminagrwat
		Me.nudTindwat.Value = Me.Tindwat
		Me.nudTminenewat.Value = Me.Tminenewat
		Me.nudTmaxintwat.Value = Me.Tmaxintwat
		Me.nudTpop.Value = Me.Tpop
		Me.nudTwatper.Value = Me.Twatper
		Me.nudTeva.Value = Me.Teva
		Me.nudTret.Value = Me.Tret
		Me.nudImaxagrwat.Value = Me.Imaxagrwat
		Me.nudIminagrwat.Value = Me.Iminagrwat
		Me.nudIindwat.Value = Me.Iindwat
		Me.nudImarwat.Value = Me.Imarwat
		Me.nudInavwat.Value = Me.Inavwat
		Me.nudIpop.Value = Me.Ipop
		Me.nudIwatper.Value = Me.Iwatper
		Me.nudStotwat.Value = Me.Stotwat
		Me.nudTa.Value = Me.Ta
		Me.nudTb.Value = Me.Tb
		Me.nudTc.Value = Me.Tc
		Me.nudTd.Value = Me.Td
		Me.nudTe.Value = Me.Te
		Me.nudTf.Value = Me.Tf
		Me.nudTg.Value = Me.Tg
		Me.nudTmaxpolintc.Value = Me.Tmaxpolintc
		Me.nudIa.Value = Me.Ia
		Me.nudIb.Value = Me.Ib
		Me.nudIc.Value = Me.Ic
		Me.nudTmarwat.Value = Me.Tmarwat
		Me.nudTnsh.Value = Me.Tnsh
		Me.nudTsidpay.Value = Me.Tsidpay
		Me.nudInsh.Value = Me.Insh
		Me.nudIsidpay.Value = Me.Isidpay
		Me.lblF1.Text = Format(Me.F1, "0.000")
		Me.lblF2.Text = Format(Me.F2, "0.000")
		Me.lblF3.Text = Format(Me.F3, "0.000")
		Me.lblF4.Text = Format(Me.F4, "0.000")
		Me.lblF5.Text = Format(Me.F5, "0.000")
		Me.lblF6.Text = Format(Me.F6, "0.000")
		Me.lblF7.Text = Format(Me.F7, "0.000")
		Me.lblF8.Text = Format(Me.F8, "0.000")
		Me.lblF9.Text = Format(Me.F9, "0.000")
		Me.lblF10.Text = Format(Me.F10, "0.000")
		Me.lblF11.Text = Format(Me.F11, "0.000")
		Me.lblF12.Text = Format(Me.F12, "0.000")
		Me.lblF13.Text = Format(Me.F13, "0.000")
		Me.lblF14.Text = Format(Me.F14, "0.000")
		Me.lblF15.Text = Format(Me.F15, "0.000")
		Me.lblF16.Text = Format(Me.F16, "0.000")
		Me.lblF17.Text = Format(Me.F17, "0.000")
		Me.lblF18.Text = Format(Me.F18, "0.000")

		Me.lblTequDifPerF3.Text = Format(Me.TequDifPerF3, "0")
		Me.lblTequDifPerF7.Text = Format(Me.TequDifPerF7, "0")
		Me.lblTequDifPerF11.Text = Format(Me.TequDifPerF11, "0")
		Me.lblTequDifPerF15.Text = Format(Me.TequDifPerF15, "0")

		Me.lblTnshDifPerF3.Text = Format(Me.TnshDifPerF3, "0")
		Me.lblTnshDifPerF7.Text = Format(Me.TnshDifPerF7, "0")
		Me.lblTnshDifPerF11.Text = Format(Me.TnshDifPerF11, "0")
		Me.lblTnshDifPerF15.Text = Format(Me.TnshDifPerF15, "0")

		Me.lblIequDifPerF4.Text = Format(Me.IequDifPerF4, "0")
		Me.lblIequDifPerF8.Text = Format(Me.IequDifPerF8, "0")
		Me.lblIequDifPerF12.Text = Format(Me.IequDifPerF12, "0")
		Me.lblIequDifPerF16.Text = Format(Me.IequDifPerF16, "0")

		Me.lblInshDifPerF4.Text = Format(Me.InshDifPerF4, "0")
		Me.lblInshDifPerF8.Text = Format(Me.InshDifPerF8, "0")
		Me.lblInshDifPerF12.Text = Format(Me.InshDifPerF12, "0")
		Me.lblInshDifPerF16.Text = Format(Me.InshDifPerF16, "0")
	End Sub

	''' <summary>
	''' read values from user interface to global variables
	''' </summary>
	''' <remarks></remarks>
	Private Sub ReadValues()
		Me.Tmaxagrwat = Me.nudTmaxagrwat.Value
		Me.Tminagrwat = Me.nudTminagrwat.Value
		Me.Tindwat = Me.nudTindwat.Value
		Me.Tminenewat = Me.nudTminenewat.Value
		Me.Tmaxintwat = Me.nudTmaxintwat.Value
		Me.Tpop = Me.nudTpop.Value
		Me.Twatper = Me.nudTwatper.Value
		Me.Teva = Me.nudTeva.Value / 100
		Me.Tret = Me.nudTret.Value / 100
		Me.Imaxagrwat = Me.nudImaxagrwat.Value
		Me.Iminagrwat = Me.nudIminagrwat.Value
		Me.Iindwat = Me.nudIindwat.Value
		Me.Imarwat = Me.nudImarwat.Value
		Me.Inavwat = Me.nudInavwat.Value
		Me.Ipop = Me.nudIpop.Value
		Me.Iwatper = Me.nudIwatper.Value
		Me.Stotwat = Me.nudStotwat.Value
		Me.Ta = Me.nudTa.Value
		Me.Tb = Me.nudTb.Value
		Me.Tc = Me.nudTc.Value
		Me.Td = Me.nudTd.Value / 100
		Me.Te = Me.nudTe.Value
		Me.Tf = Me.nudTf.Value
		Me.Tg = Me.nudTg.Value
		Me.Tmaxpolintc = Me.nudTmaxpolintc.Value
		Me.Ia = Me.nudIa.Value
		Me.Ib = Me.nudIb.Value
		Me.Ic = Me.nudIc.Value
		Me.Tmarwat = Me.nudTmarwat.Value
		Me.Tnsh = Me.nudTnsh.Value / 100
		Me.Tsidpay = Me.nudTsidpay.Value
		Me.Insh = Me.nudInsh.Value / 100
		Me.Isidpay = Me.nudIsidpay.Value
	End Sub

	''' <summary>
	''' starts Mathematica kernel and read last record from DB
	''' </summary>
	''' <remarks></remarks>
	Private Function Init() As Boolean
		Dim kernelPath As String
		Dim result As Boolean
		Dim tmpDataRowView As DataRowView

		result = False
		kernelPath = ""

		Try
			'read parameters
			Me.DAParameters.Fill(Me.DSParameters)

			kernelPath = Me.DSParameters._parameters.Rows(0).Item("parKernelPath").ToString
		Catch ex As Exception
			MessageBox.Show("Error reading parameters form database", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try

		If kernelPath = "" OrElse Not System.IO.File.Exists(kernelPath) Then
			'kernel path not present or wrong path is present in db
			MessageBox.Show("Wolfram Mathematica executable kernel path is missing or wrong" & ControlChars.CrLf & "please set correct path", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

			Dim myfrmParameters As New frmParameters

			myfrmParameters.ShowDialog()
			End
		Else
			'start Mathematica kernel
			Me.myMathWrapper = New MW.MathWrapper(kernelPath)
			If Me.myMathWrapper.KernelReady Then
				result = True
			Else
				Exit Function
			End If
			Try
				'read data from DB
				Me.DAData.Fill(Me.DSData)

				If Me.DSData.data.DefaultView.Count > 0 Then
					Me.DSData.data.DefaultView.Sort = " datID ASC "
					tmpDataRowView = Me.DSData.data.DefaultView.Item(Me.DSData.data.DefaultView.Count - 1)

					Me.nudTmaxagrwat.Value = tmpDataRowView.Item("datTmaxagrwat")
					Me.nudTminagrwat.Value = tmpDataRowView.Item("datTminagrwat")
					Me.nudTindwat.Value = tmpDataRowView.Item("datTindwat")
					Me.nudTminenewat.Value = tmpDataRowView.Item("datTminenewat")
					Me.nudTmaxintwat.Value = tmpDataRowView.Item("datTmaxintwat")
					Me.nudTpop.Value = tmpDataRowView.Item("datTpop")
					Me.nudTwatper.Value = tmpDataRowView.Item("datTwatper")
					Me.nudTeva.Value = tmpDataRowView.Item("datTeva")
					Me.nudTret.Value = tmpDataRowView.Item("datTret")
					Me.nudStotwat.Value = tmpDataRowView.Item("datStotwat")
					Me.nudTa.Value = tmpDataRowView.Item("datTa")
					Me.nudTb.Value = tmpDataRowView.Item("datTb")
					Me.nudTc.Value = tmpDataRowView.Item("datTc")
					Me.nudTd.Value = tmpDataRowView.Item("datTd")
					Me.nudTe.Value = tmpDataRowView.Item("datTe")
					Me.nudTg.Value = tmpDataRowView.Item("datTg")
					Me.nudTf.Value = tmpDataRowView.Item("datTf")
					Me.nudTmaxpolintc.Value = tmpDataRowView.Item("datTmaxpolintc")
					Me.nudTmarwat.Value = tmpDataRowView.Item("datTmarwat")
					Me.nudTnsh.Value = tmpDataRowView.Item("datTnsh")
					Me.nudTsidpay.Value = tmpDataRowView.Item("datTsidpay")
					Me.nudImaxagrwat.Value = tmpDataRowView.Item("datImaxagrwat")
					Me.nudIminagrwat.Value = tmpDataRowView.Item("datIminagrwat")
					Me.nudIindwat.Value = tmpDataRowView.Item("datIindwat")
					Me.nudImarwat.Value = tmpDataRowView.Item("datImarwat")
					Me.nudInavwat.Value = tmpDataRowView.Item("datInavwat")
					Me.nudIpop.Value = tmpDataRowView.Item("datIpop")
					Me.nudIwatper.Value = tmpDataRowView.Item("datIwatper")
					Me.nudIa.Value = tmpDataRowView.Item("datIa")
					Me.nudIb.Value = tmpDataRowView.Item("datIb")
					Me.nudIc.Value = tmpDataRowView.Item("datIc")
					Me.nudInsh.Value = tmpDataRowView.Item("datInsh")
					Me.nudIsidpay.Value = tmpDataRowView.Item("datIsidpay")
				Else
					'no data in DB
					Me.nudTmaxagrwat.Value = 0
					Me.nudTminagrwat.Value = 0
					Me.nudTindwat.Value = 0
					Me.nudTminenewat.Value = 0
					Me.nudTmaxintwat.Value = 0
					Me.nudTpop.Value = 0
					Me.nudTwatper.Value = 0
					Me.nudTeva.Value = 0
					Me.nudTret.Value = 0
					Me.nudStotwat.Value = 0
					Me.nudTa.Value = 0
					Me.nudTb.Value = 0
					Me.nudTc.Value = 0
					Me.nudTd.Value = 0
					Me.nudTe.Value = 0
					Me.nudTg.Value = 0
					Me.nudTf.Value = 0
					Me.nudTmaxpolintc.Value = 0
					Me.nudTmarwat.Value = 0
					Me.nudTnsh.Value = 0
					Me.nudTsidpay.Value = 0
					Me.nudImaxagrwat.Value = 0
					Me.nudIminagrwat.Value = 0
					Me.nudIindwat.Value = 0
					Me.nudImarwat.Value = 0
					Me.nudInavwat.Value = 0
					Me.nudIpop.Value = 0
					Me.nudIwatper.Value = 0
					Me.nudIa.Value = 0
					Me.nudIb.Value = 0
					Me.nudIc.Value = 0
					Me.nudInsh.Value = 0
					Me.nudIsidpay.Value = 0
				End If
			Catch ex As Exception
				MessageBox.Show("Error reading data form database", "CRITICAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End If

		Return result
	End Function

	''' <summary>
	''' update database with Turkish or Iraqi agreement or disagreement
	''' </summary>
	''' <param name="turkeyIraq">Turkey or Iraq to be updated</param>
	''' <param name="agreement">status of agreement</param>
	''' <remarks></remarks>
	Private Sub UpdateDB(ByVal turkeyIraq As enumTurkeyIraq, ByVal agreement As Boolean)
		Dim sqlCommand As New System.Text.StringBuilder

		sqlCommand.Append("UPDATE data" & ControlChars.CrLf)
		Select Case turkeyIraq
			Case enumTurkeyIraq.Iraq
				If agreement Then
					sqlCommand.Append("SET datIraqiAgreement = 1," & ControlChars.CrLf)
					Me.iraqiAgree = True
				Else
					sqlCommand.Append("SET datIraqiAgreement = 0," & ControlChars.CrLf)
					Me.iraqiAgree = False
				End If
			Case enumTurkeyIraq.Turkey
				If agreement Then
					sqlCommand.Append("SET datTurkishAgreement = 1," & ControlChars.CrLf)
					Me.turkishAgree = True
				Else
					sqlCommand.Append("SET datTurkishAgreement = 0," & ControlChars.CrLf)
					Me.turkishAgree = False
				End If
		End Select

		sqlCommand.Append("dataAggiornamento = '" & Now.ToShortDateString & " " & Now.ToShortTimeString.Replace("."c, ":"c) & "'" & ControlChars.CrLf)
		sqlCommand.Append("WHERE datID = " & Me.ID & ControlChars.CrLf)

		clsUtility.ExecuteSQL(sqlCommand.ToString, Me.SqlConnection1)
		Me.NextStep()
	End Sub

	''' <summary>
	''' read dinamic constraints from database
	''' </summary>
	''' <remarks></remarks>
	Private Sub ReadDinamicConstraints()
		Dim tempRow As DataRow

		'read Turkish data
		Me.DataTableAdapter.Fill(Me.dsOldTurkishConstraints.data)

		If Me.dsOldTurkishConstraints.data.Rows.Count > 0 Then
			'there are some data in 'data' table
			tempRow = Me.dsOldTurkishConstraints.data.Rows(0)

			Me.oldTmarWat = tempRow.Item("oldTmarWat")
			Me.oldTnsh = tempRow.Item("oldTnsh")
			Me.oldTsidpay = tempRow.Item("oldTsidpay")
			Me.oldF1 = tempRow.Item("oldF1")
			Me.oldF3 = tempRow.Item("oldF3")
		Else
			'table is empty
			Me.oldTmarWat = 0
			Me.oldTnsh = 0
			Me.oldTsidpay = 0
			Me.oldF1 = 0
			Me.oldF3 = 0
		End If

		'read Iraqi data
		Me.DataTableAdapter1.Fill(Me.dsOldIraqiConstraints.data)

		If Me.dsOldIraqiConstraints.data.Rows.Count > 0 Then
			'there are some data in 'data' table
			tempRow = Me.dsOldIraqiConstraints.data.Rows(0)

			Me.oldImarWat = tempRow.Item("oldImarWat")
			Me.oldInsh = tempRow.Item("oldInsh")
			Me.oldIsidpay = tempRow.Item("oldIsidpay")
			Me.oldF2 = tempRow.Item("oldF2")
			Me.oldF4 = tempRow.Item("oldF4")
		Else
			'table is empty
			Me.oldImarWat = 0
			Me.oldInsh = 0
			Me.oldIsidpay = 0
			Me.oldF2 = 0
			Me.oldF4 = 0
		End If
	End Sub

	''' <summary>
	''' evaluate dynamic constraints and lock/unlock controls
	''' </summary>
	''' <param name="turkeyIraq">Turkey or Iraq to be evaluated</param>
	''' <remarks></remarks>
	Private Sub EvaluateInputConstraints(ByVal turkeyIraq As enumTurkeyIraq)
		Dim hasError As Boolean

		hasError = False
		Select Case turkeyIraq
			Case enumTurkeyIraq.Iraq
				If Math.Round(Me.nudInsh.Value, digits, MidpointRounding.AwayFromZero) < Math.Round(Me.oldInsh, digits, MidpointRounding.AwayFromZero) Then
					Me.lblInshError.Visible = True
					hasError = True
				Else
					Me.lblInshError.Visible = False
				End If
				If Math.Round(Me.nudImarwat.Value, digits, MidpointRounding.AwayFromZero) < Math.Round(Me.oldImarWat, digits, MidpointRounding.AwayFromZero) Then
					hasError = True
					Me.lblImarwatError.Visible = True
				Else
					Me.lblImarwatError.Visible = False
				End If
				If Math.Round(Me.nudIsidpay.Value, digits, MidpointRounding.AwayFromZero) < Math.Round(Me.oldIsidpay, digits, MidpointRounding.AwayFromZero) Then
					Me.lblIsidpayError.Visible = True
					hasError = True
				Else
					Me.lblIsidpayError.Visible = False
				End If
			Case enumTurkeyIraq.Turkey
				If Math.Round(Me.nudTmarwat.Value, digits, MidpointRounding.AwayFromZero) < Math.Round(Me.oldTmarWat, digits, MidpointRounding.AwayFromZero) Then
					Me.lblTmarwatError.Visible = True
					hasError = True
				Else
					Me.lblTmarwatError.Visible = False
				End If
				If Math.Round(Me.nudTnsh.Value, digits, MidpointRounding.AwayFromZero) < Math.Round(Me.oldTnsh, digits, MidpointRounding.AwayFromZero) Then
					Me.lblTnshError.Visible = True
					hasError = True
				Else
					Me.lblTnshError.Visible = False
				End If
				If Math.Round(Me.nudTsidpay.Value, digits, MidpointRounding.AwayFromZero) < Math.Round(Me.oldTsidpay, digits, MidpointRounding.AwayFromZero) Then
					Me.lblTsidpayError.Visible = True
					hasError = True
				Else
					Me.lblTsidpayError.Visible = False
				End If
		End Select

		Me.btnPrev.Enabled = Not hasError
		Me.btnNext.Enabled = Not hasError
	End Sub

#End Region

#Region " Event management "

	Private Sub frmNegotiation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		'close Mathematica kernel
		Me.myMathWrapper.KernelStop()
	End Sub

	Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
		Me.NextStep()
	End Sub

	Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
		If Me.groupBoxesID = 0 Then
			Me.Reset()
		Else
			Me.PreviousStep()
		End If
	End Sub

	Private Sub btnTurkishAgree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTurkishAgree.Click
		Me.UpdateDB(enumTurkeyIraq.Turkey, True)
	End Sub

	Private Sub btnTurkishDisagree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTurkishDisagree.Click
		Me.UpdateDB(enumTurkeyIraq.Turkey, False)
	End Sub

	Private Sub btnIraqiAgree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIraqiAgree.Click
		Me.UpdateDB(enumTurkeyIraq.Iraq, True)
	End Sub

	Private Sub btnIraqiDisagree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIraqiDisagree.Click
		Me.UpdateDB(enumTurkeyIraq.Iraq, False)
	End Sub

	Private Sub grbConfidentialWaterIraq_NSSInit() Handles grbConfidentialWaterIraq.NSSInit
		If Math.Round(Me.F2, digits, MidpointRounding.AwayFromZero) >= Math.Round(Me.oldF2, digits, MidpointRounding.AwayFromZero) AndAlso Math.Round(Me.F4, digits, MidpointRounding.AwayFromZero) >= Math.Round(Me.oldF4, digits, MidpointRounding.AwayFromZero) Then
			Me.btnIraqiDisagree.Enabled = False
		Else
			Me.btnIraqiDisagree.Enabled = True
		End If
	End Sub

	Private Sub grbConfidentialWaterTurkey_NSSInit() Handles grbConfidentialWaterTurkey.NSSInit
		If Math.Round(Me.F1, digits, MidpointRounding.AwayFromZero) >= Math.Round(Me.oldF1, digits, MidpointRounding.AwayFromZero) AndAlso Math.Round(Me.F3, digits, MidpointRounding.AwayFromZero) >= Math.Round(Me.oldF3, digits, MidpointRounding.AwayFromZero) Then
			Me.btnTurkishDisagree.Enabled = False
		Else
			Me.btnTurkishDisagree.Enabled = True
		End If
	End Sub

	Private Sub grbConfidentialTurkey_NSSInit() Handles grbConfidentialTurkey.NSSInit
		Me.nudTmarwat.Value = Me.oldTmarWat
		Me.nudTsidpay.Value = Me.oldTsidpay
		Me.nudTnsh.Value = Me.oldTnsh
	End Sub

	Private Sub grbConfidentialIraq_NSSInit() Handles grbConfidentialIraq.NSSInit
		Me.nudImarwat.Value = Me.oldImarWat
		Me.nudIsidpay.Value = Me.oldIsidpay
		Me.nudInsh.Value = Me.oldInsh
	End Sub

	Private Sub nudTmarwat_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudTmarwat.Validated
		Me.EvaluateInputConstraints(enumTurkeyIraq.Turkey)
	End Sub

	Private Sub nudTsidpay_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudTsidpay.Validated
		Me.EvaluateInputConstraints(enumTurkeyIraq.Turkey)
	End Sub

	Private Sub nudTnsh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudTnsh.Validated
		Me.EvaluateInputConstraints(enumTurkeyIraq.Turkey)
	End Sub

	Private Sub nudImarwat_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudImarwat.Validated
		Me.EvaluateInputConstraints(enumTurkeyIraq.Iraq)
	End Sub

	Private Sub nudisidpay_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudIsidpay.Validated
		Me.EvaluateInputConstraints(enumTurkeyIraq.Iraq)
	End Sub

	Private Sub nudinsh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudInsh.Validated
		Me.EvaluateInputConstraints(enumTurkeyIraq.Iraq)
	End Sub

	Private Sub grbNegotiationOutcome_NSSInit() Handles grbNegotiationOutcome.NSSInit
		Dim plotGraph As Boolean

		plotGraph = False

		If Me.turkishAgree Then
			If Me.iraqiAgree Then
				'Turkey agreed, Iraq agreed
				Me.lblNegotiationOutcome.Text = "The negotiation was successful"
				plotGraph = True
			Else
				'Turkey agreed, Iraq disagreed
				Me.lblNegotiationOutcome.Text = "The negotiation was unsuccessful because Iraq disagreed"
			End If
		Else
			If Me.iraqiAgree Then
				'Turkey disagreed, Iraq agreed
				Me.lblNegotiationOutcome.Text = "The negotiation was unsuccessful because Turkey disagreed"
			Else
				'Turkey disagreed, Iraq disagreed
				Me.lblNegotiationOutcome.Text = "The negotiation was unsuccessful because both disagreed"
			End If
		End If

		If plotGraph Then
			Me.lblGraphLabel.Visible = True
			Me.lblGraphLabel.Text = "The point on the dashed isoline (the equally weighted total net benefits) and the point without an isoline refer to the negotiation and cooperation outcomes, respectively. The highest horizontal grid line highlights the Turkish maximum net benefits once the maximum agricultural water demands are met; the intermediate horizontal grid line identifies the non-significant harm constraint for Turkey; the lowest horizontal grid line highlights the Turkish minimum net benefits once the minimum agricultural water demands are met. Vertical grid lines have a similar meaning for Iraq. Blue and purple areas identify feasible and equitable use (for Iraq) allocations, respectively."
			Me.myMathWrapper.WaitAndDiscardAnswer("TnbC = Tnb /. Tagrwat -> 1/(Ia (-1 + Teva + Tret)) (Ia Iindwat + Ia Tmarwat + Ia Inavwat + InbC + Ia Ipopwat - Ia Owat + Ia Stotwat + Ia Tindwat + Ia Tpopwat)")
			Me.myMathWrapper.WaitAndDiscardAnswer("TnbKS = -(((F7 - F11nn)/(F12 - F8nn)) (F12 - InbC) - F7)")
			Me.myMathWrapper.WaitAndDiscardAnswer("TnbL = (1 - Tnsh)*F7")
			Me.myMathWrapper.WaitAndDiscardAnswer("InbL = (1 - Insh)*F12")
			Me.myMathWrapper.WaitAndDiscardAnswer("TnbO = Tnb /. Tagrwat -> F13")
			Me.myMathWrapper.WaitAndDiscardAnswer("InbO = Inb /. Iagrwat -> F14")
			Me.myMathWrapper.WaitAndDiscardAnswer("NegBen = N[F4 + F3] - InbC")
			Me.myMathWrapper.WaitAndDiscardAnswer("IntBen = N[InbO + TnbO] – InbC")
			Me.myMathWrapper.WaitAndDiscardAnswer("dat = {{F4, F3}, {InbO, TnbO}}")
			Me.myMathWrapper.WaitAndDiscardAnswer("p1 = Plot[{TnbC, TnbKS}, {InbC, 0, F12 + 1}, PlotRange -> {0, F7 + 1}, Epilog -> {PointSize[Medium], Point[dat]}, AxesLabel -> {""Inb, B$"", ""Tnb, B$""}, Filling -> Axis, PlotStyle -> {Blue, Purple}, GridLines -> {{F8nn, InbL, F12}, {F11nn, TnbL, F7}}]")
			Me.myMathWrapper.WaitAndDiscardAnswer("p2 = Plot[{NegBen, IntBen}, {InbC, 0, F12 + 1}, PlotRange -> {0, F7 + 1}, Epilog -> {PointSize[Medium], Point[dat]}, AxesLabel -> {""Inb, B$"", ""Tnb, B$""}, PlotStyle -> {Dashed, Thick}]")
			Me.pboOutcome.Image = Me.myMathWrapper.WaitAndEvaluateAsImage("Show[p1, p2]", Me.pboOutcome.Width, Me.pboOutcome.Height)
		Else
			Me.lblGraphLabel.Visible = False
			Me.pboOutcome.Visible = False
		End If

	End Sub

#End Region

End Class