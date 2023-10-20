using MediatR;

namespace CQRSDemoUsingMediateR.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
