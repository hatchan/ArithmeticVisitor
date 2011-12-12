using System;

namespace ArithmeticVisitor
{
    public class MultiplicationExpression : BinaryArithmeticExpression
    {
        public MultiplicationExpression(IArithmeticExpression leftArithmeticExpression,
                                        IArithmeticExpression rightArithmeticExpression)
            : base(leftArithmeticExpression, rightArithmeticExpression)
        {
        }

        public override void Accept(IArithmeticVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}