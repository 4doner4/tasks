using System;
using System.Collections.Generic;
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
    class Hierarchy
    {
        public static void ShowHierarchy()
        {
            Hierarchy hierarchy = new Hierarchy();
        }
    }

    class Root
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }

}
