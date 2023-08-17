using System.Collections.Generic;

public class StudentList<T>
{
    private List<T> students = new List<T>();

    public void Add(T student)
    {
        students.Add(student);
    }

    public List<T> GetAll()
    {
        return students;
    }
}
