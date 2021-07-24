# NoPandaProtcolParser
A simple protocol info class that parses a windows protocol call into an object.

## How to use
```cs
ProtocolInfo info = ProtocolInfo.Parse("myapp://arg1/arg2");
```

## Properties
| Name         | Type           |
| ------------ | -------------- |
| ProtocolName | string         |
| ProtocolArgs | string[]       |
