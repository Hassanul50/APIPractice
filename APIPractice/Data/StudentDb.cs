using APIPractice.Model;

namespace APIPractice.Data
{
    public static class StudentDb
    {
      public static  List<Student> result = new List<Student>() { new Student { id = 01, studentName = "Akib",FatherName="Anwar",MotherName="Fer",Dob=new DateTime(2000,03,27),Address="Dhaka",Email="h@gmail.com" ,NId=123456},
        new Student{ id=02,studentName="banna",FatherName="Anwar",MotherName="Fer",Dob=new DateTime(2000,03,27),Address="Dhaka",Email="h@gmail.com" ,NId=123456} };
        //re
        //result.Add( new Student { id = 03, studentName = "Akib" });

    }
}
