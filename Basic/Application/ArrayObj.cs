

namespace Basic.Application.ArrayObj
{
    public class ArrayObj
    {

        public void CopyArray()
        {

            int[] src = new int[3] { 4, 1, 2 };
            int[] dest = new int[3];
            src.CopyTo(dest, 0);   //starting index in dest array
                                   //dest=(int[]) src.Clone();
            dest[0] = 10;
            // Array.Copy(src,dest,src.Length);
            Console.WriteLine("Source Array: ");
            foreach (var item in src)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nDestination Array: ");
            foreach (var item in dest)
            {
                Console.Write(item + " ");
            }
          List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
          int[] arrayFromList = list.ToArray();
            Console.WriteLine("\nArray from List: ");
            foreach (var item in arrayFromList)
            {
                Console.Write(item + " ");
            }
        }
        //Iclonable example
        public void EmpArray()
        {
            Emp[] employees =
            [
                new Emp(1, "Alice") { Salary = 5000M },
                new Emp(2, "Bob") { Salary = 6000M },
                new Emp(3, "Charlie") { Salary = 7000M },
            ];


            // Emp newEmp = employees[0].CreateNewEmp();
            Emp[] emp_deepArray = new Emp[employees.Length];
            for (int i = 0; i < employees.Length; i++)
            {
                emp_deepArray[i] = employees[i].CreateNewEmp();
            }



            Console.WriteLine("\nAfter Updating Salary:");
            // Display updated employee details
            emp_deepArray[0].Salary = 8000M;
            // Display employee details
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }

            Emp[] emp_deepArray1 = new Emp[employees.Length];
            for (int i = 0; i < employees.Length; i++)
            {
                emp_deepArray1[i] = (Emp)employees[i].Clone();
            }
            emp_deepArray1[1].Salary = 9000M;

            foreach (var emp in emp_deepArray1)
            {
                if (emp is null) continue;

                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }

    }

}