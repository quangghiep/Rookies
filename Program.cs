using System;
using System.Collections.Generic;
namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>(){
                new Member{
                    FirstName ="Vu",
                    LastName ="Hiep",
                    Gender = "Male",
                    DateOfBirth  =new DateTime(2000,1,11),
                    PhoneNumber = "123456788",
                    BirthPlace = "HY",
                    IsGraduated = false,
                },
                new Member{
                    FirstName = "Vo",
                    LastName = "Huy",
                    Gender = "Female",
                    DateOfBirth = new DateTime(1999,1,11),
                    PhoneNumber = "123400088",
                    BirthPlace = "HN",
                    IsGraduated = false,
                },
                new Member{
                    FirstName = "V",
                    LastName = "Hy",
                    Gender = "Female",
                    DateOfBirth = new DateTime(2001,1,11),
                    PhoneNumber = "123400088",
                    BirthPlace = "HN",
                    IsGraduated = false,
                },
            };
            //ex1
            foreach (Member member in members)
            {
                if (member.Gender == "Male")
                {
                    Console.WriteLine("{0} {1}", member.FirstName, member.LastName);
                }
            }
            //ex2
            var max_age = 0;
            foreach (Member member in members)
            {
                if (member.Age < max_age)
                {
                    max_age = member.Age;
                }
            }
            foreach (var item in members)
            {
                if (item.Age == max_age)
                {
                    Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
                }
            }
            //ex3
            Console.WriteLine("Full Name");
            foreach (Member member in members)
            {
                Console.WriteLine(member.FirstName + " " + member.LastName);
            }

            //ex4
            List<Member> lessThan2000 = new List<Member>();
            List<Member> greaterThan2000 = new List<Member>();
            List<Member> equal2000 = new List<Member>();
            foreach (var member in members)
            {
                switch (member.DateOfBirth.Year)
                {
                    case < 2000:
                        lessThan2000.Add(member);
                        break;
                    case > 2000:
                        greaterThan2000.Add(member);
                        break;
                    default:
                        equal2000.Add(member);
                        break;
                }
            }

            Console.WriteLine("Less than 2000");
            foreach (Member member in lessThan2000)
            {
                Console.WriteLine(member.FirstName + " " + member.LastName);
            }

            Console.WriteLine("Greater than 2000");
            foreach (Member member in greaterThan2000)
            {
                Console.WriteLine(member.FirstName + " " + member.LastName);
            }

            Console.WriteLine("2000");
            foreach (Member member in equal2000)
            {
                Console.WriteLine(member.FirstName + " " + member.LastName);
            }
            //ex5
            int i = 0;
            while (true)
            {
                if (members[i].BirthPlace == "HN")
                {
                    Console.WriteLine(members[i].FirstName + " " + members[i].LastName);
                    break;
                }
                i++;
            }
        }
    }
}