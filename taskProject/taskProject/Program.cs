using System;

namespace taskProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            string option;

            do
            {
                Console.WriteLine("\n1.Qrup elave et");
                Console.WriteLine("2.Bütün qruplara bax");
                Console.WriteLine("3.Verilmis point aralığındaki qruplara bax");
                Console.WriteLine("4.Verilmis nömreli qrupa bax");
                Console.WriteLine("5.Verilmis qruplar üzre axtarış et");
                Console.WriteLine("0.Menudan cıx");

                Console.WriteLine("\nSeciminizi edin:");
                option= Console.ReadLine(); 

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Qrupu daxil edin:");
                        string name=Console.ReadLine();

                        Console.WriteLine("Ortalama point qeyd edin:");
                        string avgpointStr=Console.ReadLine();
                        double avgpoint=Convert.ToDouble(avgpointStr);

                        Group group = new Group
                        {
                            No = name,
                            AvgPoint=avgpoint

                        };
                        course.AddGroup(group);
                        break;

                    case "2":
                        for (int i = 0; i < course.groups.Length; i++)
                        {
                            Console.WriteLine($"\nNo: {course.groups[i].No}");
                            Console.WriteLine($"AvgPoint: {course.groups[i].AvgPoint}");
                        }
                            break;

                    case "3":

                        Console.WriteLine("Araligin min point  daxil edin:");
                        string minPointStr=Console.ReadLine();
                        double minPoint=Convert.ToDouble(minPointStr);

                        Console.WriteLine("Araligin max point  daxil edin:");
                        string maxPointStr=Console.ReadLine();
                        double maxPoint=Convert.ToDouble(maxPointStr);

                        course.GetGroupsByPointRange(minPoint, maxPoint);
                        Group wantedGroup = new Group();

                        for (int i = 0; i < course.groups.Length; i++)
                        {
                            Console.WriteLine($"\nNo: {course.groups[i].No}");
                            Console.WriteLine($"AvgPoint: {course.groups[i].AvgPoint}");
                        }
                        break;

                 case "4":
                        Console.WriteLine("Qrupun herifini daxil edin:");
                        string num=Console.ReadLine();
                        int no=Convert.ToInt32(num);

                        Group getGroupByNo = new Group();

                        course.GetGroupByNo(num);

                        for(int i = 0; i < course.groups.Length; i++)
                        {
                            Console.WriteLine($"\nNo: {course.groups[i].No}");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Qrup herfini daxil edin:");
                        string search = Console.ReadLine();
                        course.Search(search);
                        for (int i = 0; i < course.groups.Length; i++)
                        {
                            Console.WriteLine($"\nNo: {course.groups[i].No}");
                            Console.WriteLine($"AvgPoint: {course.groups[i].AvgPoint}");
                        }
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("Secim duzgun deyil");
                        break;
                }

            } while (option != "0");
        }
    }
}
