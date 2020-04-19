using DomainModel;

namespace Mm.DataAccessLayer
{
    public interface ITeacherRepository : IGenericDataRepository<Teacher>
    {
    }

    public interface ICourseRepository : IGenericDataRepository<Course>
    {
    }

    public interface IStudentRepository : IGenericDataRepository<Student>
    {
    }

    public interface IStandardRepository : IGenericDataRepository<Standard>
    {
    }

    public class TeacherRepository : GenericDataRepository<Teacher>, ITeacherRepository
    {
    }

    public class CourseRepository : GenericDataRepository<Course>, ICourseRepository
    {
    }

    public class StudentRepository : GenericDataRepository<Student>, IStudentRepository
    {
    }

    public class StandardRepository : GenericDataRepository<Standard>, IStandardRepository
    {
    }
}
