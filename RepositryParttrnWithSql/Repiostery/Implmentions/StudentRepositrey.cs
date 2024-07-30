using RepositryParttrnWithSql.Data;
using RepositryParttrnWithSql.Models;
using RepositryParttrnWithSql.Repiostery.Interfaces;

namespace RepositryParttrnWithSql.Repiostery.Implmentions
{
    public class StudentRepositrey : IStudent
    {
        private readonly StudentDBContext _StudentDb;

        public StudentRepositrey(StudentDBContext studentcontext)
        {
            _StudentDb = studentcontext;
        }

        public int CreateStudent(StdentModel student)
        {
            int result = -1;
            if (student == null)
            {
                result = 0;
            }
            else { 
            
             _StudentDb.StdentModels.Add(student);
                _StudentDb.SaveChanges();
                result = student.ID;
            }
            return result;
        }

        public int DeleteStudent(int id)
        {
            _StudentDb.StdentModels.Remove(GetStudentById(id));
            return _StudentDb.SaveChanges();

            //_studentApi.students.Remove(deleteStudent);
        }


        public void Dispose()
        {
            _StudentDb?.Dispose();
        }

        public IEnumerable<StdentModel> GetAllStudents()
        {
           var AllStudents =_StudentDb.StdentModels.ToList();
            return AllStudents;
        }

        public StdentModel GetStudentById(int id)
        {
            var StudentID = _StudentDb.StdentModels.Where(SID=>SID.ID==id).FirstOrDefault()??null;
            return StudentID;
        }

        public int UpdateStudent(StdentModel student)
        {
            var StudentID = _StudentDb.StdentModels.Where(SID => SID.ID ==student.ID).FirstOrDefault() ?? null;

            if (StudentID !=null)
            {
                StudentID.ID=student.ID;
                StudentID.Name=student.Name;
                StudentID.Gender=student.Gender;
                StudentID.Standrat=student.Standrat;
                _StudentDb.SaveChanges();
                return StudentID.ID;

            }
            return -1;
           
        }
    }
}
