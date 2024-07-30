using RepositryParttrnWithSql.Models;

namespace RepositryParttrnWithSql.Repiostery.Interfaces
{
    public interface IStudent: IDisposable
    {
     IEnumerable<StdentModel>GetAllStudents();
        StdentModel GetStudentById(int id);
        int CreateStudent(StdentModel student);
        int UpdateStudent(StdentModel student);
        int DeleteStudent(int id);


    }
}
