using System.Collections.Generic;
using System.IO;

namespace Midterm_Project_for_Group
{
    // jon
    class Recipt
    {

        static bool run = true;


        public Recipt(List<MenuItem> orderBasket, string reciptLine, int customerNumber)
        {
            run = true;

            while (run == true)
            {
                using (FileStream filestream = File.Create("Customer" + customerNumber + ".txt"))
                using (StreamWriter writer = new StreamWriter(filestream))
                {
                    foreach (MenuItem item in orderBasket)
                    {
                        writer.WriteLine(item.itemName + "\t\t" + item.itemCost);

                    }
                    customerNumber++;
                    System.Console.WriteLine(customerNumber);
                    writer.WriteLine(reciptLine);
                    writer.Close();
                    run = false;
                }

            }

        }
    }

}



//            File recipt = new File("Customer" + i + ".txt");
//            StreamReader file = new StreamReader("Customer" + i + ".txt");

//            file.Close();

//            StreamWriter recipt = new StreamWriter(path + i + ".txt");
//            Process.Start("Customer_Number_" + i);

//            System.Console.WriteLine(reciptLine);
//            i++;
//            run = false;



//        }
//            using (StreamWriter CustomerRecord = new StreamWriter(path + ".csv", true))
//            {
//                foreach (MenuItem item in orderBasket)
//                {

//                    CustomerRecord.WriteLine(item.itemCost + "," + item.itemName);
//                }
//CustomerRecord.WriteLine(i + ",");
//            }
//            List<MenuItem> mcMenu = FoodMenu.MakeFoodMenu();

//        }
//    }
//}