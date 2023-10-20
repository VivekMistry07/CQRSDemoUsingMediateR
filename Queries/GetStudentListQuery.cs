using CQRSDemoUsingMediateR.Models;
using MediatR;

namespace CQRSDemoUsingMediateR.Queries
{
    public class GetStudentListQuery :IRequest<List<StudentDetails>>
    {
    }
}
