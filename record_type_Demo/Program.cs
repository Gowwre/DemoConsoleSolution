// See https://aka.ms/new-console-template for more information

using record_type_Demo;

Customer customer01 = new Customer { Name = "Vee", Age = 22 };
customer01.Print();
Customer customer02 = customer01 with { Name = "John" };
customer02.Print();
Customer customer03 = new();
customer03.Print();
