using System;
namespace None.Commands
{class ipconfig
{public ipconfig(string[] args)
{Console.WriteLine(@"
Windows IP Configuration


Ethernet adapter Ethernet:
   Connection -specific DNS Suffix  . :
   IPv4 Address. . . . . . . . . . . : 10.10.150.5
   Subnet Mask . . . . . . . . . . . : 255.255.0.0
   Default Gateway . . . . . . . . . : 10.10.1.1");

}}}