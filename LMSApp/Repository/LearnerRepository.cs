using LMSApp.Model;

namespace LMSApp.Repository
{
    public class LearnerRepository:ILearnerRepository
    {
        // In-memory collection
        private readonly List<Learner> _learners ;
        // Constructor
        public LearnerRepository()
        {
            _learners = new List<Learner>()
        {
            new Learner
            {
                LearnerId = 1,
                Name = "Rahul",
                Email = "rahul@gmail.com",
                Course = "C#",
                Age = 26
            },
            new Learner
            {
                LearnerId = 2,
                Name = "Priya",
                Email = "priya@gmail.com",
                Course = "Python",
                Age = 23
            },
            new Learner
            {
                LearnerId = 3,
                Name = "Amit",
                Email = "amit@gmail.com",
                Course = "React",
                Age = 26
            }
        };
        }
        // Add learner
        public void Add(Learner learner)
        {
            learner.LearnerId = _learners.Count == 0
                ? 1
                : _learners.Max(x => x.LearnerId) + 1;

            _learners.Add(learner);
        }

        // Get all learners
        public List<Learner> GetAll()
        {
            return _learners;
        }

        // Get learner by ID
        public Learner? GetById(int id)
        {
            return _learners.Find(x => x.LearnerId == id);
        }
    }
}
