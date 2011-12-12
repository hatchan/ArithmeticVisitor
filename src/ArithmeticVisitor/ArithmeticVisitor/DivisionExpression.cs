using System;

namespace ArithmeticVisitor
{
    public class DivisionExpression : BinaryArithmeticExpression
    {
        public DivisionExpression(IArithmeticExpression leftArithmeticExpression,
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