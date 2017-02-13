namespace Jan162017.Visitor
{
    public interface ITransactionVisitor
    {
        void Visit(Transaction transaction);
    }
}
