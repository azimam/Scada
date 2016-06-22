'This Program  is mimic script and open a meter which selected from embedded List 
	
Function ShowMeter()
Dim ControlMax,ControlMin

sStation = Mimic.Layers("New Layer").Item("MeterList").CurrentRowName
sStationIdx = Mimic.Layers("New Layer").Item("MeterList").CurrentRowIdx


IF sStationIdx >= 0 Then 
'build menu so you can navigate from record/Meter or cotrol an specific point.
	Menu.Init
	Menu.AddItem("Show Meter")
	menu.addseparator
	Menu.AddItem("Control Noms")
	index = Menu.Display

	
'msgbox sMeter
		Select Case index
		Case 1
				if sStation <> "" then
				Mimic.OpenInset("SCX:////CMimic/" & sStation  & ".Graphics.Meter"), "10", "10", "80", "80"
				end if
		Case 2
				if sStation <> "" then
'Control an internal point			  
				set  Obj=server.FindObject(sStation &  ".Nominations.CDay Noms")
				'ControlMax = obj.interface.Control.ControlMaximum
				'ControlMin = obj.interface.Control.ControlMinimum
				ControlMax=10000000
				ControlMin=0
				Form.Init "Control " & Obj.FullName
				Form.AddGroupBox 0,0,100,8,""
				set frmStaticText = Form.AddStaticText(2,1,"")	
				Form.AddStaticText 2,3, "Enter a value between " & ControlMin & " and " & ControlMax & ":"
				Set frmEditBox = Form.AddEditBox(60,3)
				frmEditBox.SetRange ControlMinim,ControlMax
					
				frmEditBox.Value = obj.interface.currentvalue
				Set frmOKButton = Form.AddPushButton(60,5,"OK")
				frmOKButton.Default = True
				Set frmCancelButton = Form.AddPushButton(75,5,"Cancel")
				Form.Show
				
					Do While Form.Selection = "OK" and (frmEditBox.Value < ControlMin or frmEditBox.Value > ControlMax)
						frmStaticText.Text = "Entered Value is out of acceptable Range"
						frmEditBox.Value = obj.interface.currentvalue
						Form.Show
					Loop
					If Form.Selection = "OK" Then
						if frmEditBox.Value <> obj.interface.currentvalue then
							obj.interface.currentvalue = frmEditBox.Value
						end if
					ElseIf (Form.Selection = "" OR Form.Selection = frmCancelButton) Then'This is when they click Esc or the X, allows them to get some feedback.
						'We don't give feedback when they click Cancel
						iReturnValue = MsgBox("Control cancelled", vbOKOnly+vbInformation, "Control not executed")
					End If
				
			end if
			
		Case Else
	End Select

End If

End Function
