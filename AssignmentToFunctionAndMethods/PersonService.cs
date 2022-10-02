using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentToFunctionAndMethods
{
    class PersonService
    {
        // метод 16 задания
        PersonInfo personInfo = new PersonInfo();
        PersonParams personParams = new PersonParams();
        public void PersonFullInfo(PersonInfo personInfo, PersonParams personParams)

        {
            Console.WriteLine($"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n");
        }

        // метод 17 задания (классификация по максимальному возрасту)
        PersonInfo personInfo1 = new PersonInfo();
        PersonParams personParams1 = new PersonParams();
        public void MaxAge(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            if (personParams.age> personParams1.age)
            {
                Console.WriteLine($"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n");
            }
            else
            {
                Console.WriteLine($"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n");
            }
        }
        // метод 17 задания (классификация по максимальному весу)
        public void MaxWeight(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            if (personParams.weight> personParams1.weight)
            {
                Console.WriteLine($"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n");
            }
            else
            {
                Console.WriteLine($"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n");
            }
        }
        // метод 17 задания (классификация по максимальному росту)
        public void MaxGrowth(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            if (personParams.growth> personParams1.growth)
            {
                Console.WriteLine($"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n");
            }
            else
            {
                Console.WriteLine($"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n");
            }
        }
        // метод 17 задания (классификация по минимальному возрасту)
        public void MinAge(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            if (personParams.age < personParams1.age)
            {
                Console.WriteLine($"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n");
            }
            else
            {
                Console.WriteLine($"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n");
            }
        }
        // метод 17 задания (классификация по минимальному весу)
        public void MinWeight(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            if (personParams.weight < personParams1.weight)
            {
                Console.WriteLine($"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n");
            }
            else
            {
                Console.WriteLine($"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n");
            }
        }
        // метод 17 задания (классификация по минимальному росту)
        public void MinGrowth(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            if (personParams.growth < personParams1.growth)
            {
                Console.WriteLine($"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n");
            }
            else
            {
                Console.WriteLine($"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n");
            }
        }
    }
}
