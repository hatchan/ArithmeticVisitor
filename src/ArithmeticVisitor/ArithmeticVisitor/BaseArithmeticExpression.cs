namespace ArithmeticVisitor
{
    public abstract class BaseArithmeticExpression : IArithmeticExpression
    {
        #region IArithmeticExpression Members

        public abstract void Accept(IArithmeticVisitor visitor);

        #endregion
    }
}