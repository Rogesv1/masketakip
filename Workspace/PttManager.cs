using Business.Concrete;
using Entities.Concrete;

internal class PttManager
{
    private ForeignerManeger foreignerManeger;

    public PttManager(ForeignerManeger foreignerManeger)
    {
        this.foreignerManeger = foreignerManeger;
    }

    internal void GiveMask(Person person1)
    {
        throw new NotImplementedException();
    }
}