namespace ArithmeticVisitor
{
    public class BracketsExpression : BaseArithmeticExpression
    {
        private readonly IArithmeticExpression _innerExpression;

        public BracketsExpression(IArithmeticExpression innerExpression)
        {
            _innerExpression = innerExpression;
        }

        public IArithmeticExpression InnerExpression
        {
            get { return _innerExpression; }
        }

        public override void Accept(IArithmeticVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}