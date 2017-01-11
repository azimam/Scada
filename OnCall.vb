sub SubEmail1()
    
   Dim obj
   Set obj=server.FindObject("~Email Redirection.E-Mail Action 1")
   		IF obj.Interface.InService = 0 then
   		
			obj.Interface.InService = 1
			MsgBox "Cody is On-Call" , vbOKOnly, "On-Call"
		ELSE 
		
			obj.Interface.InService = 0
		END If

End Sub
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
sub SubEmail2()
    
   Dim obj
   Set obj=server.FindObject("~Email Redirection.E-Mail Action 2")
   		IF obj.Interface.InService = 0 then
   	
			obj.Interface.InService = 1 
			MsgBox "Josh is On-Call" , vbOKOnly, "On-Call"
		ELSE obj.Interface.InService = 0
		END If
	
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
sub SubEmail3()
    
   Dim obj
   Set obj=server.FindObject("~Email Redirection.E-Mail Action 3")
   		IF obj.Interface.InService = 0 then
   	
			obj.Interface.InService = 1 
			MsgBox "Jr is On-Call" , vbOKOnly, "On-Call"
		ELSE obj.Interface.InService = 0
		END If
	
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
sub SubEmail4()
    
   Dim obj
   Set obj=server.FindObject("~Email Redirection.E-Mail Action 4")
   		IF obj.Interface.InService = 0 then
   	
			obj.Interface.InService = 1 
			MsgBox "Jason is On-Call" , vbOKOnly, "On-Call"
		ELSE obj.Interface.InService = 0
		END If
	
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
sub SubEmail5()
    
   Dim obj
   Set obj=server.FindObject(".~Email Redirection.E-Mail Action 5")
   		IF obj.Interface.InService = 0 then
   	
			obj.Interface.InService = 1 
			MsgBox "Greg is On-Call" , vbOKOnly, "On-Call"
		ELSE obj.Interface.InService = 0
		END If
	
End Sub
