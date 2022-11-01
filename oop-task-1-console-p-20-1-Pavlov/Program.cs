using oop_task_1_console_p_20_1_Pavlov.Core;

Adress adress = new Adress();
adress.Index = "602035";
adress.Counrty = "Russia";
adress.City = "Moscow";
adress.Street = "Oktybrskaya";
adress.House = "20";
adress.Apartment = "4";

Console.WriteLine($"{adress.Index}, {adress.Counrty}, {adress.City}, {adress.Street}, {adress.House}, {adress.Apartment}");