using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;
using System.Dynamic;

namespace Exam_70_483
{
    public class Program
    {
        public static void Main()
        {
        }
    }
    interface IEntity
    {
        int Id { get; }
    }
    class Repository<T>
     where T : IEntity
    {
        protected IEnumerable<T> _elements;
        public Repository(IEnumerable<T> elements)
        {
            _elements = elements;
        }
        public T FindById(int id)
        {
            return _elements.SingleOrDefault(e => e.Id == id);
        }
    }
}