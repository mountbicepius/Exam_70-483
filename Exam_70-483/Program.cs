using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_70_483
{
    public class Program
    {
        public static void Main()
        {
         CovarianceDel del;
        del = MethodStream;
        del = MethodString;
        }
        public delegate TextWriter CovarianceDel();
        public static StreamWriter MethodStream() { return null; }
    public static StringWriter MethodString() { return null; }
    } 
}