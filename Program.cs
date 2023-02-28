// using System;
// // See https://aka.ms/new-console-template for more information
// namespace Program
// {
//     class Program
//     {         

//         static void Main(string[] args){

//             // See https://aka.ms/new-console-template for more information
//             // Console.WriteLine("Hello, World!");
//             // Console.WriteLine("Write your full name please");

//             // string fullName=Console.ReadLine();
//             // Console.WriteLine("Hola "+fullName+" welcome to platzi");

//             // int number1;
//             // int number2;
//             // Console.WriteLine("Hello world");
//             // Console.WriteLine("Input the first number");
//             // // number1=int.Parse(Console.ReadLine());
//             // number1=Convert.ToInt32(Console.ReadLine()); //casteo explicito
//             // Console.WriteLine("Input the first number");
//             // number2=Convert.ToInt32(Console.ReadLine()); //casteo explicito

//             // int result= number1*number2;
//             // Console.WriteLine("the result is:  "+result);
//             // int height=169;
//             // int age=26;
//             // string name="Oriana Ailigo";
//             // string placeholder="The information you resquested is: ";
//             // string information=placeholder+"\n user name: "+name+"\n height: "+height+"\n age: "+age;
//             // Console.WriteLine(information);

//             // string [] coffeTypes;
//             // float [] coffeValues; 

//             // coffeTypes= new[] {"express","late"};
//             // coffeValues= new[] {24.5f,34.45f};
//             // int i=0;
//             // foreach (var item in coffeTypes)
//             // {
//             //     Console.WriteLine(item+" prizes: "+coffeValues[i]);
//             //     i++;
//             // }

//             // List<string> tacoShoppingList= new List<string>();
//             // tacoShoppingList.Add("taco relleno");
//             // tacoShoppingList.Add("taco tomate");
//             // tacoShoppingList.Add("taco verduras");
//             // // si fuera un for taco.Count
//             // foreach (var item in tacoShoppingList)
//             // {
//             //         Console.WriteLine(item);
//             //         Console.WriteLine(tacoShoppingList.Count);
//             // }

//             // Random rnd=new Random();
//             // Console.WriteLine($"{rnd.Next(1,10)}");
//             /*
//                 1.validar si es usuario existente o si se debe resitrar, y generar
//                 un sistema de registro o login.
//                 2.El programa debe ser capaz de darle la bienvenida a un
//                 usuario existente si en efecto existe.
//                 3. El programa debe repetirse hasta que se registren las 10
//                 personas.
//             */
//             string [] userNames=new string[3]{"","",""};
//             int arrayCurrentIndex=0;
//             bool userType;
//             string userSearch;
//             Console.WriteLine("Welcome to the best restaurant in the world");
//             while(arrayCurrentIndex<3){
                
//                 Console.WriteLine("\n \n Are you a registered user? Write true, or write false to register");
//                 userType=Convert.ToBoolean(Console.ReadLine());
//                 if(userType==true){
//                     Console.WriteLine("Hello you are a registered user, please enter your exact user name.");
//                     userSearch=Console.ReadLine();
//                     Console.WriteLine("The user you serched is {0}", userSearch);
//                     int index=Array.IndexOf(userNames,userSearch);
//                     if(index==-1){
//                         Console.WriteLine("User not found, try again or register");
//                     }
//                     else{
//                         Console.WriteLine("Welcome {0}, it is a pleasure to give you food.",userNames[index]);
//                     }
//                 }else{
//                     if(userType==false){
//                         Console.WriteLine("Please write and remember your user name");
//                         userNames[arrayCurrentIndex]=Console.ReadLine();
//                         Console.WriteLine("Your user has been saved succesfully \n"+
//                         "Your user name is {0}",userNames[arrayCurrentIndex]);
//                         arrayCurrentIndex++;
//                     }
//                 }
//             }

            
//             Console.WriteLine("The restaurant is full, try again next year. \n"+
//             "These are the guests to the dinner: ");
//             int auxIndex=0;
//             foreach (var item in userNames)
//             {
//                 Console.WriteLine("User Number:{0} and User Name:{1} ",auxIndex++,item);
                
//             }

                 
//             Environment.Exit(0);
            
//         }
//     }
// }

