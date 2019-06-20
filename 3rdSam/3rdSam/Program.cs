using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdSam{
    class Program{
        static void Main(string[] args){
            List<consignment> consignments = new List<consignment>();
            bool isEnd = false;
            do{
                Console.WriteLine("введите название партии");
                string name = Console.ReadLine();
                string answer;
                Console.WriteLine("партия бюджетная? (y/n)");
                answer = Console.ReadLine();
                bool budgetary = answer == "y" ? true : answer == "n" ? false : false;
                Console.WriteLine($"введите количество {(budgetary?"ассигнований":"депутатов")}");
                string sValue = Console.ReadLine();
                int value = Int32.Parse(sValue);
                consignment added = new consignment();
                added.addConsignment(name, budgetary, value);
                consignments.Add(added);
                Console.WriteLine("продолжить ввод? (y/n)");
                answer = Console.ReadLine();
                isEnd = answer == "y" ? true : answer == "n" ? false : false;
            } while (isEnd);
            foreach(var iter in consignments){
                if(iter.nameOfConsignment.StartsWith("А") || iter.nameOfConsignment.StartsWith("Б") || iter.nameOfConsignment.StartsWith("В") || iter.nameOfConsignment.StartsWith("Г") || iter.nameOfConsignment.StartsWith("Д") || iter.nameOfConsignment.StartsWith("Е") || iter.nameOfConsignment.StartsWith("Ж") || iter.nameOfConsignment.StartsWith("З") || iter.nameOfConsignment.StartsWith("И") || iter.nameOfConsignment.StartsWith("К")){
                    Console.WriteLine($"Название партии {iter.nameOfConsignment}");
                    Console.WriteLine($"Бюджетная - {(iter.getBudgetary() == true ? "Да" : "Нет")}");
                    Console.WriteLine($"Количество {(iter.getBudgetary() ? "ассигнований" : "депутатов")} - {iter.getAmount()}\n");
                }
            }
            Console.ReadLine();
            consignments.Clear();
        }
    }

    class consignment{
        public string nameOfConsignment;
        private bool budgetary;
        private int amount;
        public void addConsignment(string name, bool ifBudgetary, int value){
            this.nameOfConsignment = name;
            this.budgetary = ifBudgetary;
            this.amount = value;
        }
        public bool getBudgetary(){
            return budgetary;
        }
        public int getAmount(){
            return amount;
        }
    }
}