using CQRSDemoUsingMediateR.Models;
using CQRSDemoUsingMediateR.Queries;
using CQRSDemoUsingMediateR.Repositories;
using MediatR;

namespace CQRSDemoUsingMediateR.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<StudentDetails>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentDetails>> Handle(GetStudentListQuery query, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentListAsync();
        }
    }
}
