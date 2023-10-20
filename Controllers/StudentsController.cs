using CQRSDemoUsingMediateR.Commands;
using CQRSDemoUsingMediateR.Models;
using CQRSDemoUsingMediateR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDemoUsingMediateR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator mediator;

        public StudentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAllStudent")]
        public async Task<List<StudentDetails>> GetStudentListAsync()
        {
            var studentDetails = await mediator.Send(new GetStudentListQuery());

            return studentDetails;
        }

        [HttpGet("GetStudentById")]
        public async Task<StudentDetails> GetStudentByIdAsync(int studentId)
        {
            var studentDetails = await mediator.Send(new GetStudentByIdQuery() { Id = studentId });

            return studentDetails;
        }

        [HttpPost("CreateStudent")]
        public async Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails)
        {
            var studentDetail = await mediator.Send(new CreateStudentCommand(
                studentDetails.StudentName,
                studentDetails.StudentEmail,
                studentDetails.StudentAddress,
                studentDetails.StudentAge));
            return studentDetail;
        }

        [HttpPut("UpdateStudent")]
        public async Task<int> UpdateStudentAsync(StudentDetails studentDetails)
        {
            var isStudentDetailUpdated = await mediator.Send(new UpdateStudentCommand(
               studentDetails.Id,
               studentDetails.StudentName,
               studentDetails.StudentEmail,
               studentDetails.StudentAddress,
               studentDetails.StudentAge));
            return isStudentDetailUpdated;
        }

        [HttpDelete("UserDelete")]
        public async Task<int> DeleteStudentAsync(int Id)
        {
            return await mediator.Send(new DeleteStudentCommand() { Id = Id });
        }
    }
}
