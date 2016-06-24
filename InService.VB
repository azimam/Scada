Sub Inservive()
	dim qry, Name , i ,obj
	
	set qry = server.query("SELECT FullName FROM ChannelScanner")
	for i=0 To (qry.rowcount -1)
		Name = qry.rows
		Set obj=server.FindObject(Name &  ".InService")
		Server.SetOPCValue obj, TRUE
	Next	
		
End Sub

