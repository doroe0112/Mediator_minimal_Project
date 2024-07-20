using MediatR;

namespace MediatorTest10.Rolladen;

public class RolladenHochCommandHandler: IRequestHandler<RolladenHochCommand, int>
{
    public async Task<int> Handle(RolladenHochCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine("Rolladen hochgefahren" + request.id);
        return 8;
    }
}