using System;

namespace ArithmeticVisitor
{
    public class ConsoleArithmeticVisitor : IArithmeticVisitor
    {
        #region IArithmeticVisitor Members

        public void Visit(ConstantExpression expression)
        {
            Console.Write(expression.Value);
        }

        public void Visit(AdditionExpression expression)
        {

            // Handle left: 
            expression.LeftArithmeticExpression.Accept(this);

            Console.Write(" + ");

            // Handle right: 
            expression.RightArithmeticExpression.Accept(this);
        }

        public void Visit(SubtractionExpression expression)
        {
            // Handle left: 
            expression.LeftArithmeticExpression.Accept(this);

            Console.Write(" - ");

            // Handle right: 
            expression.RightArithmeticExpression.Accept(this);
        }

        public void Visit(BracketsExpression expression)
        {
            Console.Write(" ( ");

            expression.InnerExpression.Accept(this);

            Console.Write(" ) ");
        }

        public void Visit(MultiplicationExpression expression)
        {
            // Handle left: 
            expression.LeftArithmeticExpression.Accept(this);

            Console.Write(" * ");

            // Handle right: 
            expression.RightArithmeticExpression.Accept(this);
        }

        public void Visit(DivisionExpression expression)
        {
            // Handle left: 
            expression.LeftArithmeticExpression.Accept(this);

            Console.Write(" / ");

            // Handle right: 
            expression.RightArithmeticExpression.Accept(this);
        }

        #endregion
    }
}