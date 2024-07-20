namespace MediatorTest10.Rolladen;
using MediatR;


public class RolladenHochCommand:IRequest<int>
{
    public int id { get; set; }
}