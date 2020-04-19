using DomainModel;
using System.Collections.Generic;

namespace Mm.BusinessLayer
{
    public interface IBusinessLayer
    {
        #region Teacher
        IList<Teacher> GetAllTeachers();
        Teacher GetTeacherByName(string teacherName);
        Teacher GetTeacherById(int teacherId);
        void AddTeacher(params Teacher[] teachers);
        void UpdateTeacher(params Teacher[] teachers);
        void RemoveTeacher(params Teacher[] teachers);
        #endregion

        #region Course
        IList<Course> GetCoursesByTeacherId(int teacherId);
        IList<Course> GetAllCourses();
        Course GetCourseByName(string courseName);
        Course GetCourseById(int courseId);
        void AddCourse(params Course[] courses);
        void UpdateCourse(params Course[] courses);
        void RemoveCourse(params Course[] courses);
        #endregion

        #region Standard
        IList<Standard> GetAllStandards();
        Standard GetStandardByID(int standardId);
        Standard GetStandardByName(string standardName);
        void AddStandard(params Standard[] standards);
        void UpdateStandard(params Standard[] standards);
        void RemoveStandard(params Standard[] standards);
        #endregion

        #region Student
        IList<Student> GetAllStudents();
        Student GetStudentByName(string studentName);
        Student GetStudentById(int studentId);
        void AddStudent(params Student[] students);
        void UpdateStudent(params Student[] students);
        void RemoveStudent(params Student[] students); 
        #endregion


    }
}