'This Program  is mimic script and open a meter which selected from embedded List 
	
Function ShowStation()
sStation = Mimic.Layers("New Layer").Item("CompList").CurrentRowName
sStationIdx = Mimic.Layers("New Layer").Item("CompList").CurrentRowIdx

IF sStationIdx >= 0 Then 

'build menu so you can navigate from record/Meter
	Menu.Init
	Menu.AddItem("Show Compressor Station")
	'Menu.AddItem("Show Trend")
	index = Menu.Display

	
	'msgbox sMeter
		Select Case index
		Case 1
				if sStation <> "" then
				Mimic.OpenInset("SCX:////CMimic/" & sStation  & ".~Compressor Overview"), "10", "50", "80", "80"
				end if
		
	'	Case 2
	'		if sMeter <> "" then
	'			Mimic.OpenInset("SCX:////CGraph/" & sMeter &".Trends.Pressure Trend"), "10", "50", "80", "80"
	'		end if
			
		Case Else
	End Select

End If

End Function

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	
Function ShowWellpad()
sWell = Mimic.Layers("New Layer").Item("Wellpad_List").CurrentRowName
sWellIdx = Mimic.Layers("New Layer").Item("Wellpad_List").CurrentRowIdx

IF sWellIdx >= 0 Then 

'build menu so you can navigate from record/Meter
	Menu.Init
	Menu.AddItem("Show Wellpad Meter List")
	index = Menu.Display

	
	'msgbox sMeter
		Select Case index
		Case 1
				if sWell <> "" then
				Mimic.OpenInset("SCX:////CMimic/" & sWell  & ".~Meter list"), "10", "50", "80", "40"
				end if
		

			
		Case Else
	End Select

End If

End Function

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


Function ShowSalesPoint()
sWell = Mimic.Layers("New Layer").Item("SalesPoint_List").CurrentRowName
sWellIdx = Mimic.Layers("New Layer").Item("SalesPoint_List").CurrentRowIdx

IF sWellIdx >= 0 Then 

'build menu so you can navigate from record/Meter
	Menu.Init
	Menu.AddItem("Show Sales Point Meter List")
	index = Menu.Display

	
	'msgbox sMeter
		Select Case index
		Case 1
				if sWell <> "" then
				Mimic.OpenInset("SCX:////CMimic/" & sWell  & ".~Meter list"), "10", "50", "80", "40"
				end if
		

			
		Case Else
	End Select

End If

End Function

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
