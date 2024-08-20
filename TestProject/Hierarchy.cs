using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    /*
Есть класс
class
{
	public int Id {get;set;}
	public string Name {get;set;}
	public int? ParentId {get;set;}
}

Набор данных представляет собой плоскую коллекцию с n кол-вом данных. У данных есть связь по ParentId (родитель-ребенок)
Написать алгоритм (метод) который превратит плоскую структуру в иерархическую

    */
    public class Node<Root>
    {
        public Node(Root data)
        {
            Data = data;
        }
        public Root Data { get; set; }
        public Node<Root>? Next { get; set; }
    }
    public class LinkedListHierarchy<Root> : IEnumerable<Root>  // односвязный список
    {
        Node<Root>? head; // головной/первый элемент
        Node<Root>? tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void Add(Root data)
        {
            Node<Root> node = new Node<Root>(data);

            if (head == null)
                head = node;
            else
                tail!.Next = node;
            tail = node;

            count++;
        }

        public IEnumerator<Root> GetEnumerator()
        {
            Node<Root>? current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Root>)this).GetEnumerator();
        }
    }
    class Root
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? ParentId { get; set; }

    }

}
