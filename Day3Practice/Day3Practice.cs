using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Practice
{
    class CourseDetails//create coursedetails class containg cid,cname ,fees
    {
        int cid, fees;
        string cname;
        internal static string institutionname;

        internal CourseDetails(int cid,int fees,string cname)
        {
            this.cid = cid;
            this.fees = fees;
            this.cname = cname;
        }

        internal void DisplayCourseDetail()
        {
            Console.WriteLine(" Cid:{0}||Fees:{1}||Cname:{2}||InstitutionName", cid, fees, cname/*,institutionname*/);
        }

        static int collegeid = 25607;
        internal static int DisplayCollegeid()
        {
            return collegeid;
        }

        class Day3Practice
        {
            static void Main()
            {
                Console.WriteLine(" Enter InstitutionName");
                CourseDetails.institutionname = Console.ReadLine();
                Console.WriteLine("enter No Of Courses ");
                int size = Convert.ToInt32(Console.ReadLine());
                CourseDetails[] courses = new CourseDetails[size];
                int cid, fees;
                string cname;
                for (int i=0;i<size;i++)
                {
                    Console.WriteLine("Enter the Cid ,Fees and Cname");
                    cid = Convert.ToInt32(Console.ReadLine());
                    fees = Convert.ToInt32(Console.ReadLine());
                    cname = Console.ReadLine();
                    courses[i] = new CourseDetails(cid, fees, cname);
                }
                for (int i = 0; i < size; i++)
                {
                    courses[i].DisplayCourseDetail();
                }
                Console.Read();
            }
        }
        
    }

}
