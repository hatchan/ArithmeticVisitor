using System;

namespace ArithmeticVisitor
{
    public class SubtractionExpression : BinaryArithmeticExpression
    {
        public SubtractionExpression(IArithmeticExpression leftArithmeticExpression,
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