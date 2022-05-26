RESTORE FILELISTONLY
FROM DISK = 'C:\x\AdventureWorks2016.BAK'
RESTORE DATABASE AdventureWorks2016
FROM DISK = 'C:\x\AdventureWorks2016.BAK'
WITH RECOVERY, STATS=10,
MOVE 'AdventureWorks2016_DATA' TO 'C:\SQL2016\SQL_DATA\AdventureWorks2016_Data.mdf',
MOVE 'AdventureWorks2016_log' TO 'C:\SQL2016\SQL_LOG\AdventureWorks2016_Log.ldf'

