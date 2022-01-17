using System;

namespace VSCFirst
{
    class Program
    {
        static List<Member> members = new List<Member>{
          new Member{
              FirstName = "Truong",
              LastName = "Nguyen Tien",
              Gender = "Male",
              dateOfBirth = new GetDateOfBirth(2000, 2, 1),
              PhoneNumber = "",
              BirdPlace = "Bac Ninh",
              IsGraduated = false
          },
          new Member{
              FirstName = "Hai",
              LastName = "Nguyen Van",
              Gender = "Male",
              dateOfBirth = new DateTime(2001, 2, 1),
              PhoneNumber = "",
              BirdPlace = "Ha Noi",
              IsGraduated = false
          },  
          new Member{
              FirstName = "Nam",
              LastName = "Nguyen Thanh",
              Gender = "Male",
              dateOfBirth = new DateTime(2002, 2, 1),
              PhoneNumber = "",
              BirdPlace = "Bac Giang",
              IsGraduated = false
          },  
          new Member{
              FirstName = "Tuan",
              LastName = "Tran Tien",
              Gender = "Male",
              dateOfBirth = new DateTime(2003, 2, 1),
              PhoneNumber = "",
              BirdPlace = "Bac Kan",
              IsGraduated = false
          },    
        };

        static void Main(string[] args)
        {
            var maleMembers = GetMaleMembers();
            PrintData(maleMembers);
        }

        static  void PrintData(List<Member> data){
            foreach (var item in data)
            {
                Console.WriteLine((item.LastName) (item.FirstName)  (item.dateOfBirth.toString("dd/MM/yyyy")));
                
            }

        }

        static List<Member> GetMaleMembers()
        {
           var result = new List<Member>{};
           foreach (var member in Members)
           {
               if(member.Gender == "Male")
               {
                   result.Add(member);
               }             
           }
           return result;
        }
    }
}
