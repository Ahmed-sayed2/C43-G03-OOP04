using ConsoleApp8.First_Project;
using ConsoleApp8.Question_01;
using ConsoleApp8.Question_02;
using ConsoleApp8.Question_03;
using ConsoleApp8.Second_Project;
using ConsoleApp8.Third_Project;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Security;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01:
            //Circle circle = new Circle(10);
            //Rectangle rectangle = new Rectangle(20);
            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();
            #endregion
            #region Question 02:
            //IAuthenticationService authService = new AuthenticationService("ahmed","123","admin");
            //Console.WriteLine(authService.AuthenticateUser("mohamed", "ss"));
            //Console.WriteLine(authService.AuthorizeUser("mohamed", "user"));
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine(authService.AuthenticateUser("ahmed", "123"));
            //Console.WriteLine(authService.AuthorizeUser("ahmed", "admin"));
            #endregion
            #region Question 03:
            //SmsNotificationService sms=new SmsNotificationService();
            //sms.SendNotification("Ahmed","hi");
            //PushNotificationService push = new PushNotificationService();
            //push.SendNotification("mohamed", "222");
            //EmailNotificationService email = new EmailNotificationService();
            //email.SendNotification("Sayed", "333");
            #endregion
            #region First Project
            //    int x, y, z;bool b;
            //    //A3DPoint a3DPoint=new A3DPoint(10,10,10);
            //    //Console.WriteLine(a3DPoint);
            //    Console.WriteLine("enter first coordinates");
            //    x=int.Parse(Console.ReadLine());
            //a: b = int.TryParse(Console.ReadLine(), out y);
            //    if (b)
            //        z = Convert.ToInt32(Console.ReadLine());
            //    else
            //        goto a;  
            //    A3DPoint p1= new A3DPoint(x, y, z);
            //    Console.WriteLine(p1);
            //    Console.WriteLine("---------------------------------");
            //    Console.WriteLine("enter seconed coordinates");
            //    x = int.Parse(Console.ReadLine());
            //aa: b = int.TryParse(Console.ReadLine(), out y);
            //    if (b)
            //        z = Convert.ToInt32(Console.ReadLine());
            //    else
            //        goto aa;
            //    A3DPoint p2 = new A3DPoint(x, y, z);
            //    Console.WriteLine(p2);
            //    if (p1 == p2) // no its compare the hashcode of each one  
            //        Console.WriteLine(p1.ToString);
            //    p2=(A3DPoint)p1.Clone();

            #endregion
            #region SecondProject
            //Console.WriteLine(Maths.Add(1, 2));
            //Console.WriteLine(Maths.Subtract(1, 2));
            //Console.WriteLine(Maths.Divide(1, 2));
            //Console.WriteLine(Maths.Multiply(1, 2));
            #endregion
            #region ThirdProject
            Discount user;int n, amount=100,q;decimal per = .05m,price ;bool f,f1,f2;
            A: Console.WriteLine("choose User type \n1-Regular\n2-Premium\n3-Guest\n-----------");
            f = int.TryParse(Console.ReadLine(),out n);
            if (f)
            {
                
                switch (n)
                {
                    case 1:
                        Check(out price, out q);
                        user = new PercentageDiscount(per);
                        user.CalculateDiscount(price, q);
                        Console.WriteLine($"the discount is {user.DiscountProp} the old price is {price} , new= {price - user.DiscountProp}");
                        break;
                    case 2:
                        Check(out price, out q);
                        user = new FlatDiscount(amount);
                        user.CalculateDiscount(price, q);
                        Console.WriteLine($"the discount is {user.DiscountProp} the old price is {price} , new= {price - user.DiscountProp}");
                        break;
                    case 3:
                        Check(out price, out q);
                        Console.WriteLine($"there no discount the price is {price}");
                        break;
                    default:
                        Console.WriteLine("--------\ninvalid number\n------");
                        goto A ;
                }
            }
            else
            {
                Console.WriteLine("select from the list \n---------------------");
                goto A;
            }
            
            
            #endregion


        }

       static public bool Check(out decimal p,out int q)
        {
            p = 0; q = 0;
            bool  f1, f2;
        B: Console.Write("------\nenter price= ");
            f1 = decimal.TryParse(Console.ReadLine(), out p);
            ;
            if (f1)
            {
            c: Console.Write("enter quantity=");
                f2 = int.TryParse(Console.ReadLine(), out q);
                if (f2)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("enter num");
                    goto c;
                }
            }
            else
            {
                Console.WriteLine("enter num");
                goto B;
            }

        }

    }
    }

