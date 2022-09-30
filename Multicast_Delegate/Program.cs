// See https://aka.ms/new-console-template for more information

using Multicast_Delegate;

string message = "Multicast Delegate";
MyDelegate myDelegate01=MyClass.Print;
MyDelegate myDelegate02=MyClass.Show;
MyDelegate myCombinedDele = myDelegate01 + myDelegate02;
myCombinedDele(message);
MyDelegate myDelegate03=MyClass.Display;
myCombinedDele+=myDelegate03;
myCombinedDele(message);
