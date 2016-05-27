SELECT TOP( 100000 )
	"Source" AS "FullName", "RecordTime" AS "RecordTime", "Message", "Category"
FROM
	CDBEVENTJOURNAL
WHERE
	( "RecordTime" BETWEEN { OPC 'D' } AND { OPC 'D+1D' } ) AND ( ( "Source" LIKE '%Scanner%' ) OR ( "Source" LIKE '%Outstation%' ) ) 
	AND ( ( "Message" LIKE '%Failed%' ) OR ( "Message" LIKE '%Alarm%' ) OR ( "Message" LIKE '%alarm%' ) ) 
	AND ( "Source" LIKE '%ProjectNmae%' )
ORDER BY
	"RecordTime" DESC
