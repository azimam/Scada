'This Program  is mimic script and open a meter which selected from embedded List 
	
Function ShowMeter()
sMeter = Mimic.Layers("New Layer").Item("MeterList").CurrentRowName
sMeterIdx = Mimic.Layers("New Layer").Item("MeterList").CurrentRowIdx

IF sMeterIdx >= 0 Then 

'build menu so you can navigate from record/Meter
	Menu.Init
	Menu.AddItem("Show Meter")
	Menu.AddItem("Show Trend")
	index = Menu.Display

	
	'msgbox sMeter
		Select Case index
		Case 1
				if sMeter <> "" then
				Mimic.OpenInset("SCX:////CMimic/" & sMeter  & ".Graphics.Meter"), "10", "50", "80", "80"
				end if
		
		Case 2
			if sMeter <> "" then
				Mimic.OpenInset("SCX:////CGraph/" & sMeter &".Trends.Pressure Trend"), "10", "50", "80", "80"
			end if
			
		Case Else
	End Select

End If

End Function
