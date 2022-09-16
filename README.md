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


***
For reading about Oracle connections may be ,
https://www.c-sharpcorner.com/UploadFile/nipuntomar/connection-strings-for-oracle/

***
for RabbitMQ Docker installation 
Install Rabbitmq docker file using the following command (Note- docker desktop is in running mode):

docker pull rabbitmq:3-management

Next, create a container and start using the Rabbitmq Dockerfile that we downloaded:

docker run --rm -it -p 15672:15672 -p 5672:5672 rabbitmq:3-management

http://localhost:15672/      with guest/guest
and add a queue with name "product"





Enter default username ("guest") and password (also "guest"), and next you will see the dashboard.

*****
For the error message
"COULD NOT LOAD TYPE 'System.Security.Principal.WindowsImpersonationContext' from assembly 'mscorlib'",
I refer to the link 
https://stackoverflow.com/questions/68593542/could-not-load-type-system-security-principal-windowsimpersonationcontext-from/71467851#71467851

For dot net 6, I was getting the same exception. Only kept the package: Oracle.ManagedDataAccess.Core and removed all others related to oracle and it works.

Get rid of 'Oracle.ManagedDataAccess'. I had both 'Oracle.ManagedDataAccess' and 'Oracle.ManagedDataAccess.Core' installed. This issue is most likely caused because 'Oracle.ManagedDataAccess' is for .NET Framework and not .NET Core/.NET 6.





