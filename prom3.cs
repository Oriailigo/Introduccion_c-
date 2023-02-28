// /*
// NO FUNCIONA SE DEBE VER EN PLATZI LOS COMPONENTES VISUALES
//  * Creado por SharpDevelop.
//  * Usuario: Alumnos
//  * Fecha: 5/8/2019
//  * Hora: 10:06 PM
//  * 
//  * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
//  */
// using System;
// using System.Collections.Generic;
// using System.Drawing;
// using System.Windows;

// namespace tp8b_eje1
// {
//     /// <summary>
//     /// Description of MainForm.
//     /// </summary>
//     public partial class MainForm : Form
//     {
//         static int cont1 = 0;
//         static int cont2 = 0;
//         static int cont3 = 0;
//         static int cont4 = 0;
//         int aux_left = 0;
//         int aux_width= 0;
//         int aux_top = 0;
//         int aux_height= 0;
        
//         public MainForm()
//         {
//             //
//             // The InitializeComponent() call is required for Windows Forms designer support.
//             //
//             InitializeComponent();
            
//             //
//             // TODO: Add constructor code after the InitializeComponent() call.
//             //
//         }
//         void Label1Click(object sender, EventArgs e)
//         {
//             this.label1.Left = aux_left;
//             this.label1.Width = aux_width;
//             this.label1.Top = aux_top;
//             this.label1.Height = aux_height;
//         }
//         void Label2Click(object sender, EventArgs e)
//         {
            
//         }
//         void TextBox1TextChanged(object sender, EventArgs e)
//         {
            
//         }
//         void MainFormLoad(object sender, EventArgs e)
//         {
//             string st = @"C:\Users\Alumnos\Desktop\neeeeet\izquierda.png";
//             button1.Image = Image.FromFile(st);
//             //button1.Size= new Size(){Width=0,Height=0};
//             st = @"C:\Users\Alumnos\Desktop\neeeeet\abajo.png";
//             button2.Image = Image.FromFile(st);
//             st = @"C:\Users\Alumnos\Desktop\neeeeet\arriba.png";
//             button3.Image = Image.FromFile(st);
//             st = @"C:\Users\Alumnos\Desktop\neeeeet\derecha.png";
//             button4.Image = Image.FromFile(st);
//             st = "Label de " + label1.Width + " pixeles de ancho y " + label1.Height + " de alto";
//             label1.Text = st;
            
//             //Guardo valores por default 
//             aux_left = this.label1.Left;
//             aux_width =this.label1.Width;
//             aux_top = this.label1.Top;
//             aux_height = this.label1.Height;
//         }
//         /*Caso boton izquierda*/
//         void Button1Click(object sender, EventArgs e)
//         {
//             if (cont1++ != 10) {
//                 this.label1.Left -= 10;
//                 this.label1.Width += 10;
//             } else
//                 this.button1.Enabled = false;
//         }
//         /*Caso boton abajo*/
//         void Button2Click(object sender, EventArgs e)
//         {
//             if (cont2++ != 10) {
//                 this.label1.Height += 10;
//             } else
//                 this.button2.Enabled = false;
//         }
//         /*Caso boton arriba*/
//         void Button3Click(object sender, EventArgs e)
//         {
//             if (cont3++ != 10) {
//                 this.label1.Top -= 10;
//                 this.label1.Height += 10;
//             } else
//                 this.button3.Enabled = false;
//         }
//         /*Caso boton derecha*/
//         void Button4Click(object sender, EventArgs e)
//         {
//             if (cont4++ != 10) {
//                 this.label1.Width += 10;
//             } else
//                 this.button4.Enabled = false;
//         }
//     }
// }
