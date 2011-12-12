namespace ArithmeticVisitor
{
    public class ConstantExpression : BaseArithmeticExpression
    {
        private readonly int _value;

        public ConstantExpression(int value)
        {
            _value = value;
        }

        public int Value
        {
            get { return _value; }
        }

        public override void Accept(IArithmeticVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}