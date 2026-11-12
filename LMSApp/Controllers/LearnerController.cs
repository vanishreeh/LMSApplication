using LMSApp.Model;
using LMSApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMSApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearnerController : ControllerBase
    {
        private readonly ILearnerRepository _repository;

        public LearnerController(ILearnerRepository repository)
        {
            _repository = repository;
        }

        // POST: api/learners
        [HttpPost]
        public IActionResult AddLearner(Learner learner)
        {
            _repository.Add(learner);

            return Ok(new
            {
                message = "Learner added successfully",
                data = learner
            });
        }

        // GET: api/learners
        [HttpGet]
        public IActionResult GetAllLearners()
        {
            var learners = _repository.GetAll();

            return Ok(learners);
        }

        // GET: api/learners/1
        [HttpGet("{id:int}")]
        public IActionResult GetLearnerById(int id)
        {
            var learner = _repository.GetById(id);

            if (learner == null)
            {
                return NotFound("Learner not found");
            }

            return Ok(learner);
        }
    }
}
