'this program put all scanner otstation and channel which are listed in the InService Channel Scanner datagrid,  
'inService or out of service
'By Azima 2016
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Sub Inservive()
	dim qry, Name , i ,obj
	'
	
	set qry = server.query("SELECT FullName FROM ChannelScanner")
	for i=0 To  (qry.rowcount - 1 )
		Name = qry.rows
		Set obj=server.FindObject(Name(i,0))
		obj.interface.Inservice=1
	Next	
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Sub OutOfservive()
	dim qry, Name , i ,obj
	'
	
	set qry = server.query("SELECT FullName FROM ChannelScanner")
	for i=0 To  (qry.rowcount - 1 )
		Name = qry.rows
		Set obj=server.FindObject(Name(i,0))
		obj.interface.Inservice=0
	Next	
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
