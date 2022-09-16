# RabbitMqProductAPI
Connect Oracle with .Net Core 6 WebAPI while using RabbitMQ

I use connection to Oracle instead of MqSql
Source:
https://www.c-sharpcorner.com/article/rabbitmq-message-queue-using-net-core-6-web-api/


Oracle Data Source sample 
"Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = HOST_NAME)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = ORCL)));" + "User Id= User_ID;Password=******"  


or  just 

"DataSource=localhost:1521/orcl;"


or 

OtacleConfiguration.OracleDataSources.Add("orcl","(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = HOST_NAME)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = ORCL)));" + "User Id= User_ID;Password=******");

and then use it 

"DataSource=orcl;"


For reading about Oracle connections may be ,
https://www.c-sharpcorner.com/UploadFile/nipuntomar/connection-strings-for-oracle/




