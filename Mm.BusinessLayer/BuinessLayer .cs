using DomainModel;
using Mm.DataAccessLayer;
using System.Collections.Generic;

namespace Mm.BusinessLayer
{
    public class BuinessLayer : IBusinessLayer
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IStandardRepository _standardRepository;

        public BuinessLayer()
        {
            _teacherRepository = new TeacherRepository();
            _courseRepository = new CourseRepository();
            _studentRepository = new StudentRepository();
            _standardRepository = new StandardRepository(); 
        }

        public BuinessLayer(ITeacherRepository teacherRepository, ICourseRepository courseRepository)
        {
            _teacherRepository = teacherRepository;
            _courseRepository = courseRepository;
        }

        //CRUD for teachers

        public IList<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAll();
        }

        public Teacher GetTeacherByName(string teacherName)
        {
            return _teacherRepository.GetSingle(
                d => d.TeacherName.Equals(teacherName),
                d => d.Courses); //include related Courses
        }

        public Teacher GetTeacherById(int teacherId)
        {
            return _teacherRepository.GetSingle(
                d => d.TeacherId.Equals(teacherId),
                d => d.Courses); //include related Courses
        }

        public void AddTeacher(params Teacher[] teachers)
        {
            _teacherRepository.Add(teachers);
        }

        public void UpdateTeacher(params Teacher[] teachers)
        {
            _teacherRepository.Update(teachers);
        }

        public void RemoveTeacher(params Teacher[] teachers)
        {
            _teacherRepository.Remove(teachers);
        }

        public IList<Course> GetCoursesByTeacherId(int teacherId)
        {
            return _courseRepository.GetList(c => c.Teacher.TeacherId.Equals(teacherId));
        }

        //CRUD for courses

        public IList<Course> GetAllCourses()
        {
            return _courseRepository.GetAll();
        }

        public Course GetCourseByName(string courseName)
        {
            return _courseRepository.GetSingle(
                d => d.CourseName.Equals(courseName),
                d => d.Teacher); //include related teacher
        }

        public Course GetCourseById(int courseId)
        {
            return _courseRepository.GetSingle(
                d => d.CourseId.Equals(courseId),
                d => d.Teacher); //include related teacher
        }

        public void AddCourse(params Course[] courses)
        {
            _courseRepository.Add(courses);
        }

        public void UpdateCourse(params Course[] courses)
        {
            _courseRepository.Update(courses);
        }

        public void RemoveCourse(params Course[] courses)
        {
            _courseRepository.Remove(courses);
        }

        //CRUD for standards

        public IList<Standard> GetAllStandards()
        {
            return _standardRepository.GetAll(); 
        }

        public Standard GetStandardByID(int standardId)
        {
            return _standardRepository.GetSingle(
               d => d.StandardId.Equals(standardId),
               d => d.Students); //include related Students
        }

        public Standard GetStandardByName(string standardName)
        {
            return _standardRepository.GetSingle(
               d => d.StandardName.Equals(standardName),
               d => d.Students); //include related Students
        }

        public void AddStandard(params Standard[] standards)
        {
            _standardRepository.Add(standards); 
        }

        public void UpdateStandard(params Standard[] standards)
        {
            _standardRepository.Update(standards); 
        }

        public void RemoveStandard(params Standard[] standards)
        {
            _standardRepository.Remove(standards); 
        }

        //CRUD for students

        public IList<Student> GetAllStudents()
        {
            return _studentRepository.GetAll(); 
        }

        public Student GetStudentByName(string studentName)
        {
            return _studentRepository.GetSingle(
               d => d.StudentName.Equals(studentName),
               d => d.Courses); //include related Courses
        }

        public Student GetStudentById(int studentId)
        {
            return _studentRepository.GetSingle(
               d => d.StudentID.Equals(studentId),
               d => d.Courses); //include related Courses
        }

        public void AddStudent(params Student[] students)
        {
            _studentRepository.Add(students); 
        }

        public void UpdateStudent(params Student[] students)
        {
            _studentRepository.Update(students); 
        }

        public void RemoveStudent(params Student[] students)
        {
            _studentRepository.Remove(students); 
        }
    }
}