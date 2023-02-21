using composite_pattern.Composite;
using composite_pattern.Leaf;

Console.WriteLine("Company expense calculator!");

Console.WriteLine(Environment.NewLine);

Developer dev1 = new("Developer 1", 4200);
Developer dev2 = new("Developer 2", 4000);
Developer dev3 = new("Developer 3", 4200);
Developer dev4 = new("Developer 4", 4000);

BusinessAnalyst ba = new("Business Analyst 1", 4500);

ProductOwner po = new("Product Owner 1", 4000);

Department it = new("IT", 1500);

it.Add(po);
it.Add(ba);
it.Add(dev1);
it.Add(dev2);
it.Add(dev3);
it.Add(dev4);

it.CalculateExpense();