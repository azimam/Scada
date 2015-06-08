''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' VBSCript  
' this program read the digital OPC point current value and change it to other status 
' When the push-bottom is pressed it is used to open or close valve in clearScada
' Status=0 means close position and 1 means open
' By Azima , 2015

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Sub changeStatus()

     If server.getopcvalue ("..Status.CurrentValue") =0 Then
          server.setopcvalue "..Status.CurrentValue",1 
    
     	Else 
     		server.setopcvalue "..Status.CurrentValue",0


End if

End Sub
