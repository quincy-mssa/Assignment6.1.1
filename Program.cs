using System;

namespace Assignment6._1._1
//Implement a single linked list with each node representing a house. You may add data in it like house number, brief address, type of house ( like Ranch, Colonial) .
//each house (node) will be linked to next .Give facility to the user to search a house by its number and then display the details. ( Windows / Console)
{
    using System;

    public class House
    {
        public int HouseNumber { get; set; }
        public string Address { get; set; }
        public string HouseType { get; set; }
        public House Next { get; set; }

        public House(int houseNumber, string address, string houseType)
        {
            HouseNumber = houseNumber;
            Address = address;
            HouseType = houseType;
            Next = null;
        }
    }

    public class HouseLinkedList
    {
        private House head;

        public HouseLinkedList()
        {
            head = null;
        }

        public void AddHouse(int houseNumber, string address, string houseType)
        {
            House newHouse = new House(houseNumber, address, houseType);
            if (head == null)
            {
                head = newHouse;
            }
            else
            {
                House current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newHouse;
            }
        }

        public House SearchHouse(int houseNumber)
        {
            House current = head;
            while (current != null)
            {
                if (current.HouseNumber == houseNumber)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void DisplayHouseDetails(House house)
        {
            if (house != null)
            {
                Console.WriteLine($"House Number: {house.HouseNumber}");
                Console.WriteLine($"Address: {house.Address}");
                Console.WriteLine($"House Type: {house.HouseType}");
            }
            else
            {
                Console.WriteLine("House not found.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HouseLinkedList houseList = new HouseLinkedList();
            houseList.AddHouse(1, "606 Crenshaw Blvd", "Modern");
            houseList.AddHouse(2, "808 Mamba Court", "Contemporary");
            houseList.AddHouse(3, "202 Angel Way", "Bungalow");

            Console.WriteLine("Enter house number to search:");
            int houseNumber = int.Parse(Console.ReadLine());

            House house = houseList.SearchHouse(houseNumber);
            houseList.DisplayHouseDetails(house);
        }
    }
}