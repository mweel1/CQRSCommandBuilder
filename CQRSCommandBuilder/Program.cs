using System;
using CQRSCommandBuilder;

var name = args[1];
var ns = args[0];


var s = new Service(name, ns);

s.Build();



