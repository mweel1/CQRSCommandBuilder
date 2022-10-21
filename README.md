# Clean Archiecture CQRSCommandBuilder
CQRS Command Builder

This will build your CQRS Command and DTO Files

-----
TODOS : 

  - Get smarter on resolving namespaces vs. sending in as an attribute
  - Make it a Visual Studio Plugin
  - Used named args instead of indexes
  
USAGE :

CQRSCommandBuilder <<namespace>> <<commandDtoName>>

1) Creates a directory that you use for the commandDtoName
2) Creates a command class file as <<commandDtoName>>Command.cs
2) Creates a dto class file as <<commandDtoName>>Dto.cs

  
  
