using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace task_8
{
    class Clinic
    {

        private Pet[] rooms;
        public int Middle { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public Clinic(string name, int count)
        {
            Count = count;
            Middle = count / 2;
            Name = name;
            rooms = new Pet[count];
        }
        public bool Add(Pet pet)
        {
            var index = GetEnumerator();
            while (rooms[index.Current]!=null)
            {
                if (!index.MoveNext())
                {
                    return false;
                }
            }
            rooms[index.Current] = pet;
            return true;
        }
        private IEnumerator<int> GetEnumerator()
        {
            yield return Middle;
            for(int i=1; i <= Middle; i++)
            {
                yield return Middle + i;
                yield return Middle - i;
            }
        }
        public bool Release()
        {
            var index = GetIndex();
            while (index.MoveNext())
            {
                if (rooms[index.Current] != null)
                {
                    rooms[index.Current] = null;
                    return true;
                }
            }
            return false;
        }
        private IEnumerator<int> GetIndex()
        {
            for(int i = Middle; i < Count; i++)
            {
                yield return i;
            }
            for(int i = 0; i < Middle; i++)
            {
                yield return i;
            }
        }
        public void Print(int index)
        {
            Console.WriteLine($"{rooms[index-1].Name} {rooms[index-1].Age} {rooms[index-1].Kind}");///Tostring додати якщо не працюватиме
        }
        public void Print()
        {
            foreach(var i in rooms)
            {
                if (i == null)
                    Console.WriteLine("Empty room");
                Console.WriteLine($"{i.Name} {i.Age} {i.Kind}");
            }
        }
        public bool HasEmptyRooms()
        {
            foreach(var i in rooms)
            {
                if (i == null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
