easy maintainable，flexible，extensible：

1. if there has new format,just add the config to transConfig.xml and develope one plugind.dll ,and did not need restart server

2. basic item process if there didn't need Transform，just set the sourceName and destName，you do not need write code.


Todo:

if want to promot the performance, the config.xml can save to the memory.
if want to know the progress rate， we can add some event to notify the caller when Transform the data.
if the caller did not start a new thread to call those method, it will blocked






Class diagram:

TransformLib:
       1. InputEntities ：the entities of original data ,and responsible for load data from csv file
	   2. OutputEntities: the entities of output data, and implemented the save method ，for example ，to db, to csv ,to ....
	   3.OutputEntity : the entity of output row.
	   4.parseFormatBasic: the Process plugin basic class, if the item need handle with plug-in , just set the isneedProcess=true of  transConfig.xml.
	   5.standParse: stand process plugin, just put the origianl data which colum name is sourceName to the object which fieldName is 'destName' in transConfig.xml
	   6.TransformFactory : the process plug-in factoryclass，through the GetParse method get the correct process object




	           



Process diagram：

1.   call InputEntities.ReadCSV -> get InputEntities object
2    call TransformFactory.getParse() -> get process plug-in object
3.   call parseFormatBasic.convert() -> get output object
4.   call outputEntities.toDB() -> save







Component moudle

 1. TransformLib.dll : basic moudle, include basic data structure and basic class

 2. ParseFormat1.dll : process plugin ,which is created by TransformFactory class dynamicly. 

 3. ParseFormat2.dll : process plugin ,which is created by TransformFactory class dynamicly. 

