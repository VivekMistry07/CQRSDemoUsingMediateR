using CQRSDemoUsingMediateR.Models;
using MediatR;

namespace CQRSDemoUsingMediateR.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
