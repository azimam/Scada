Sub Mimic_Load()
End Sub
''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Sub ServerQueryRowCount
 
Dim BAngRS   , BDigitRS
Dim BAngRows , BDigitRows
Dim BAngObj  , BDigitObj

Set BAngObj=server.FindObject("~MIS General.Brazos Alarm Ang count")
Set BAngRS = Server.Query("SELECT FullName FROM CPOINTALG WHERE PARENTGROUPNAME LIKE 'Brazos.%' AND ( ( HighHighSeverityType = 2 ) OR ( HighSeverityType = 2 ) OR ( LowSeverityType = 2 ) OR ( LowLowSeverityType = 2 ) OR ( OverrangeSeverityType = 2 ) OR ( UnderrangeSeverityType = 2 ) )") 
BAngRows=BAngRS.RowCount

BAngObj.Interface.CurrentValue=BAngRows

''''''''''''''''''''''''''''''''''''''''
Set BDigitObj=server.FindObject("~MIS General.Brazos Alarm Digital count")
Set BDigitRS = Server.Query("SELECT FullName FROM CPOINTDIGITAL WHERE PARENTGROUPNAME LIKE 'Brazos.%' AND ( STATE0SEVERITYTYPE = 2 OR STATE1SEVERITYTYPE = 2 ) ")
BDigitRows=BDigitRS.RowCount

BDigitObj.Interface.CurrentValue=BDigitRows


End Sub
