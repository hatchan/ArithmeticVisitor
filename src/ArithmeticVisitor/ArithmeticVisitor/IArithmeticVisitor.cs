namespace ArithmeticVisitor
{
    public interface IArithmeticVisitor
    {
        void Visit(ConstantExpression expression);
        void Visit(AdditionExpression expression);
        void Visit(SubtractionExpression expression);
        void Visit(BracketsExpression expression);
    }
}