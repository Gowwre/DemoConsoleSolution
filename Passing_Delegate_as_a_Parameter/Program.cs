// See https://aka.ms/new-console-template for more information

using Passing_Delegate_as_a_Parameter;

static void InvokeDelegate(MyDelegate myDelegate,string message)
{
    myDelegate(message);
}

string message = "Passing Delegate As A Parameter";
InvokeDelegate(MyClass.Print, message);
InvokeDelegate(MyClass.Show,message);