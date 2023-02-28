// namespace prom2
// {
// 	class Program
// 	{
// public static void Main(string[] args)
//         {
//             Console.CursorVisible = true;
//             ConsoleKeyInfo k = Console.ReadKey(true);
//             while (k.Key != ConsoleKey.Enter) {
//                 // 
//                 char aux = (char)k.KeyChar;
//                 if (Char.IsLetter(aux)) {
//                     Console.Write(Char.ToUpper(aux));
//                     k = Console.ReadKey(true);
//                 }
//                 if (Char.IsNumber(aux)) {
//                     Console.Write(aux);
//                     k = Console.ReadKey(true);
//                 }
//             } 
//         }
//     }
// }
// //Char.ToUpper(char) convierte minuscula en mayuscula
// //Char.IsLetter(char) devuelve un booleano 1 si es una letra, caso contrario 0.
