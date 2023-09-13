// See https://aka.ms/new-console-template for more information

using System.Collections;
using cs_con_net6;
using MyConnector;

var obj = "QQ";
Console.WriteLine("Hello, World! ");

PDFPrinter orinter = new PDFPrinter();
orinter.Print();

var connection = Connector.getConnection();
var ConDetails = connection.getConnectionDetails();
var con = Connector.getConnection().getConnectionDetails();
String str = "QWEWQE";
Console.WriteLine(con + str.Count());

