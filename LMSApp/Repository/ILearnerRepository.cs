using LMSApp.Model;

namespace LMSApp.Repository
{
    public interface ILearnerRepository
    {
        void Add(Learner learner);

        List<Learner> GetAll();

        Learner? GetById(int id);
    }
}
