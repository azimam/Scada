Select
	Name,
	SUM(CURRENTVALUEasreal),
	MIN(CURRENTQUALITY),
	MAX(CURRENTTIME)
FROM
	CSIMPLEPOINT
WHERE
	( NAME IN ( 'Flow Rate', 'Energy Rate', 'CDay Volume', 'CDay Energy', 'PDay Volume', 'PDay Energy' ) ) AND TYPENAME = 'COpcAlgPoint' AND 	PARENTGROUPNAME LIKE 'Howard.~Greenzweig.Inlet Meters.Roehrig Smith%'
Group by
	NAME
