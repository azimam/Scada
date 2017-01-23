'it look at all OPC analog point with alarm and check the tune limit for them
Public Sub TuningAllowed
dim qry, Name , i ,obj
Set qry = Server.Query("SELECT DISTINCT FullName FROM CPOINTALG WHERE PARENTGROUPNAME LIKE '%Howard.%' AND ( ( HighHighSeverityType = 2 ) OR ( HighSeverityType = 2 ) OR ( LowSeverityType = 2 ) OR ( LowLowSeverityType = 2 ) OR ( OverrangeSeverityType = 2 ) OR ( UnderrangeSeverityType = 2 ) )") 
for i=0 To  (qry.rowcount - 1 )
		Name = qry.rows
		Set obj=server.FindObject(Name(i,0))
		obj.interface.TuningAllowed=1
	Next	
End Sub
