﻿namespace GitBasics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newItem = new List<string>();

            newItem.Add("Item 1");
            newItem.Add("Item 2");
            newItem.Add("Item 3");

            Console.WriteLine(newItem[1]);
        }
    }
}
