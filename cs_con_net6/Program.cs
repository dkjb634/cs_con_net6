// See https://aka.ms/new-console-template for more information

using System.Collections;
using MyConnector;

var obj = "QQ";
Console.WriteLine("Hello, World! ");

var connection = Connector.getConnection();
var ConDetails = connection.getConnectionDetails();
var con = Connector.getConnection().getConnectionDetails();
Console.WriteLine(con);

