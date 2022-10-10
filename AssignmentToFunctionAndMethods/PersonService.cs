using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentToFunctionAndMethods
{
    class PersonService
    {
        // метод 16 задания
        public string PersonFullInfo(PersonInfo personInfo, PersonParams personParams)

        {
            string result=$"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n";
            return result;
        }

        // метод 17 задания (классификация по максимальному возрасту)
        public string MaxAge(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            string result = $"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n";
            if (personParams.age> personParams1.age)
            {
                result=$"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n";
                return result;
            }
            return result;
        }

        // метод 17 задания (классификация по максимальному весу)
        public string MaxWeight(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            string result = $"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n";
            if (personParams.weight> personParams1.weight)
            {
                result=$"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n";
                return result;
            }
            return result;
        }

        // метод 17 задания (классификация по максимальному росту)
        public string MaxGrowth(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            string result = $"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n";
            if (personParams.growth> personParams1.growth)
            {
                result=$"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n";
                return result;
            }
            return result;
        }

        // метод 17 задания (классификация по минимальному возрасту)
        public string MinAge(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            string result = $"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n";
            if (personParams.age < personParams1.age)
            {
                result=$"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n";
                return result;
            }
            return result;
        }

        // метод 17 задания (классификация по минимальному весу)
        public string MinWeight(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            string result = $"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n";
            if (personParams.weight < personParams1.weight)
            {
                result=$"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n";
                return result;
            }
            return result;
        }

        // метод 17 задания (классификация по минимальному росту)
        public string MinGrowth(PersonParams personParams, PersonParams personParams1, PersonInfo personInfo, PersonInfo personInfo1)
        {
            string result = $"Имя - {personInfo1.name}\nПол - {personInfo1.gender}\nВозраст - {personParams1.age}\nВес - {personParams1.weight}\nРост - {personParams1.growth}\n";
            if (personParams.growth < personParams1.growth)
            {
                result =$"Имя - {personInfo.name}\nПол - {personInfo.gender}\nВозраст - {personParams.age}\nВес - {personParams.weight}\nРост - {personParams.growth}\n";
                return result;
            }
            return result;
        }
    }
}
