using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArithmeticVisitor.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IArithmeticVisitor visitor = new ConsoleArithmeticVisitor();

            IArithmeticExpression leftInnerNode = new ConstantExpression(39);
            IArithmeticExpression rightInnerNode = new ConstantExpression(13);

            IArithmeticExpression leftNode = new ConstantExpression(15);
            IArithmeticExpression rightNode = new SubtractionExpression(leftInnerNode, rightInnerNode);

            IArithmeticExpression rootNode = new AdditionExpression(leftNode, new BracketsExpression(rightNode));

            rootNode.Accept(visitor);
            
            Console.WriteLine();
        }
    }
}
