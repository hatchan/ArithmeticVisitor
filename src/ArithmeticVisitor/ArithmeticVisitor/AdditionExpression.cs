namespace ArithmeticVisitor
{
    public class AdditionExpression : BinaryArithmeticExpression
    {
        public AdditionExpression(IArithmeticExpression leftArithmeticExpression,
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