sub History()
    
   Dim obj
   Set obj=server.FindObject("...Tanks.Condensate Tank Level")
   		
   		'sDataTime = Format(Server.GetOPCValue ("..Tanks.Date Time"), "yyyy MMM dd hh:nn:ss")
		obj.Interface.Historic.LoadDataValue 4, 192, Server.GetOPCValue ("..Tanks.Logic Points.Date Time"), Server.GetOPCValue ("..Tanks.Logic Points.Condensate Tank Level")

''''''''''''''''''''''''''''''''''
 Set obj=server.FindObject("..Tanks.Condensate Tank Tickets")
 obj.Interface.Historic.LoadDataValue 4, 192, Server.GetOPCValue (".n.Tanks.Logic Points.Date Time"), Server.GetOPCValue ("..Tanks.Logic Points.Condensate Tank Tickets")
	
''''''''''''''''''''''''''''''''''
 Set obj=server.FindObject("..Tanks.Condensate Tank Volume")
 obj.Interface.Historic.LoadDataValue 4, 192, Server.GetOPCValue ("V..Tanks.Logic Points.Date Time"), Server.GetOPCValue ("..Tanks.Logic Points.Condensate Tank Volume")
	
''''''''''''''''''''''''''''''''''
 Set obj=server.FindObject("..Tanks.Slop Tank Level")
 obj.Interface.Historic.LoadDataValue 4, 192, Server.GetOPCValue ("..Tanks.Logic Points.Date Time"), Server.GetOPCValue ("..Tanks.Logic Points.Slop Tank Level")

''''''''''''''''''''''''''''''''''
 Set obj=server.FindObject("..Tanks.Slop Tank Volume")
 obj.Interface.Historic.LoadDataValue 4, 192, Server.GetOPCValue ("..Tanks.Logic Points.Date Time"), Server.GetOPCValue ("..Tanks.Logic Points.Slop Tank Volume")
									
	 MsgBox "History loaded.", vbOKOnly, "Done"
end sub
