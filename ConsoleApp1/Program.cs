// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

object[] parameters = {new String("Q"), new int()};
List<DataObject> dataObjects = parameters[0] switch
{
    DataObject dataObject           => new List<DataObject> {dataObject},
    List<DataObject> dataObjectList => dataObjectList,
    _                               => default
};

if (dataObjects.IsNullOrZero())
{
    return;
}

for (int i = 0; i < dataObjects.Count; i++)
{
    Console.WriteLine(dataObjects[i]);
}