using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class PhoneBook
    {
        string[] names;
        long[] numbers;

        //Constructor
        public PhoneBook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }

        //public methods
        public void AddPerson(string name, long number, int Index)
        {
            names[Index] = name;
            numbers[Index] = number;
        }
        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return numbers[i];
                }
            }

            return -1;
        }
        public void UpdateNumber(string name, long newNumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    numbers[i] = newNumber;
                    return;
                }
            }
        }
        public string GetName(long number)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return names[i];
                }
            }

            return "";
        }
        public void UpdateName(long number, string newName)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                {
                    names[i] = newName;
                    return;
                }
            }
        }

        //Indexer property
        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }

                return -1;
            }

            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                        return;
                    }
                }
            }
        }

        public string this[long number]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        return names[i];
                    }
                }

                return "";
            }

            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        names[i] = value;
                        return;
                    }
                }
            }
        }
    }
}
