using APIPractice.Model;

namespace APIPractice.Data
{
    public static class StudentDb
    {
      public static  List<Student> result = new List<Student>() { new Student { id = 01, studentName = "akib" },
                                                        new Student{ id=02,studentName="banna"} };
        //re
        //result.Add( new Student { id = 03, studentName = "Akib" });

    }
}
