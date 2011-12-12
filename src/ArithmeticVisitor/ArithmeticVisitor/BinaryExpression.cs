namespace ArithmeticVisitor
{
    public abstract class BinaryArithmeticExpression : BaseArithmeticExpression
    {
        private readonly IArithmeticExpression _leftArithmeticExpression;
        private readonly IArithmeticExpression _rightArithmeticExpression;

        protected BinaryArithmeticExpression(IArithmeticExpression leftArithmeticExpression,
                                             IArithmeticExpression rightArithmeticExpression)
        {
            _leftArithmeticExpression = leftArithmeticExpression;
            _rightArithmeticExpression = rightArithmeticExpression;
        }

        public IArithmeticExpression LeftArithmeticExpression
        {
            get { return _leftArithmeticExpression; }
        }

        public IArithmeticExpression RightArithmeticExpression
        {
            get { return _rightArithmeticExpression; }
        }
    }
}