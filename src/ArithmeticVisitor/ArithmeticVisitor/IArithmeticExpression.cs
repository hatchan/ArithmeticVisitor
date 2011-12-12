namespace ArithmeticVisitor
{
    public interface IArithmeticExpression
    {
        void Accept(IArithmeticVisitor visitor);
    }
}