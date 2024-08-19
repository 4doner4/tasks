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
        public int Id { get; private set; } = 0;
        public List<Root> Childrens { get; private set; } = new();
        public void ShowHierarchy(int currentId, List<Root> roots)
        {
            this.Id = currentId;
            this.Childrens = roots.Where(x => x.ParentId == currentId).ToList();
            
        }
    }

    class Root
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? ParentId { get; set; }
    }

}
