using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_again
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
       

        private bool  Check (Button [] che )
        {
            for (int i = 0; i <= che.Length - 1; i++)
            {
                if (che[i].BackColor == Color.Black)
                {
                    if(i==che.Length-1)
                    {
                        return true;
                    }
                   
                }
                else if (che[i].BackColor == Color.Yellow)
                {
                    return false; 
                }
            
            }
            return false ; 
               
            
        }

        private bool Done(Button[] D)
        {
            int x = 0; 
            for (int i = 0; i <= D.Length - 1; i++)
            {
                if (D[i].BackColor == Color.Yellow)
                {
                    x++;                 
                }
                
            }

            if (x == 7)
            { return true; }
            else { return false; }
        
        }


     
        
        

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button2, button3, button4, button5, button6, button7, button8 };
            Button[] colo = new Button[7] { button9, button17, button25, button33, button41, button49, button57 };
            Button[] Diameter1 = new Button[7] { button10, button19, button28, button37, button46, button55, button64 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true)
            {
                button1.BackColor = Color.Yellow;
            }

            else { button1.BackColor = Color.Black; }


        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button1, button3, button4, button5, button6, button7, button8 };
            Button[] colo = new Button[7] { button10, button18, button26, button34, button42, button50, button58 };
            Button[] Diameter1 = new Button[6] { button11, button20, button29, button38, button47, button56};
            Button[] Diameter2 = new Button[1] { button9 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button2.BackColor = Color.Yellow;
            }

            else { button2.BackColor = Color.Black; }

           
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button1, button2, button4, button5, button6, button7, button8 };
            Button[] colo = new Button[7] { button11, button19, button27, button35, button43, button51, button59 };
            Button[] Diameter1 = new Button[5] { button12, button21, button30, button39, button48};
            Button[] Diameter2 = new Button[2] { button10, button17 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button3.BackColor = Color.Yellow;
            }

            else { button3.BackColor = Color.Black; }

           

        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button1, button2, button3, button5, button6, button7, button8 };
            Button[] colo = new Button[7] { button12, button20, button28, button36, button44, button52, button60 };
            Button[] Diameter1 = new Button[4] { button13, button22, button31, button40};
            Button[] Diameter2 = new Button[3] { button11, button18, button25 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button4.BackColor = Color.Yellow;
            }

            else { button4.BackColor = Color.Black; }

           
        
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button1, button2, button3, button4, button6, button7, button8 };
            Button[] colo = new Button[7] { button13, button21, button29, button37, button45, button53, button61 };
            Button[] Diameter1 = new Button[3] { button14, button23, button32};
            Button[] Diameter2 = new Button[4] { button12, button19, button26, button33 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button5.BackColor = Color.Yellow;
            }

            else { button5.BackColor = Color.Black; }

           
        
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button1, button2, button3, button4, button5, button7, button8 };
            Button[] colo = new Button[7] { button14, button22, button30, button38, button46, button54, button62 };
            Button[] Diameter1 = new Button[2] { button15, button24};
            Button[] Diameter2 = new Button[5] { button13, button20, button27, button34, button41 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button6.BackColor = Color.Yellow;
            }

            else { button6.BackColor = Color.Black; }

           
        
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button1, button2, button3, button4, button5, button6, button8 };
            Button[] colo = new Button[7] { button15, button23, button31, button39, button47, button55, button63 };
            Button[] Diameter1 = new Button[1] { button16};
            Button[] Diameter2 = new Button[6] { button14, button21, button28, button35, button42, button49 };

            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button7.BackColor = Color.Yellow;
            }

            else { button7.BackColor = Color.Black; }

           
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button1, button2, button3, button4, button5, button6, button7 };
            Button[] colo = new Button[7] { button16, button24, button32, button40, button48, button56, button64 };
            Button[] Diameter2 = new Button[7] { button15, button22, button29, button36, button43, button50, button57 };

            if (Check(row) == true && Check(colo) == true && Check(Diameter2) == true)
            {
                button8.BackColor = Color.Yellow;
            }

            else { button8.BackColor = Color.Black; }

           
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button10, button11, button12, button13, button14, button15, button16 };
            Button[] colo = new Button[7] { button1, button17, button25, button33, button41, button49, button57 };
            Button[] Diameter1 = new Button[6] { button18, button27, button36, button45, button54, button63 };
            Button[] Diameter2 = new Button[1] { button2 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button9.BackColor = Color.Yellow;
            }

            else { button9.BackColor = Color.Black; }

           
            
        
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button9, button11, button12, button13, button14, button15, button16 };
            Button[] colo = new Button[7] { button2, button18, button26, button34, button42, button50, button58 };
            Button[] Diameter1 = new Button[5] { button19, button28, button37, button46, button55};
            Button[] Diameter2 = new Button[2] { button3, button17 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button10.BackColor = Color.Yellow;
            }

            else { button10.BackColor = Color.Black; }

           
        
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button9, button10, button12, button13, button14, button15, button16 };
            Button[] colo = new Button[7] { button3, button19, button27, button35, button43, button51, button59 };
            Button[] Diameter1 = new Button[4] { button20, button21, button38, button47};
            Button[] Diameter2 = new Button[3] { button4, button18, button25 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button11.BackColor = Color.Yellow;
            }

            else { button11.BackColor = Color.Black; }

           
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button9, button10, button11, button13, button14, button15, button16 };
            Button[] colo = new Button[7] { button4, button20, button28, button36, button44, button52, button60 };
            Button[] Diameter1 = new Button[5] { button3, button21, button30, button39, button48 };
            Button[] Diameter2 = new Button[4] { button5, button19, button26, button33 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button12.BackColor = Color.Yellow;
            }

            else { button12.BackColor = Color.Black; }

           
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button9, button10, button11, button12, button14, button15, button16 };
            Button[] colo = new Button[7] { button5, button21, button29, button37, button45, button53, button61 };
            Button[] Diameter1 = new Button[4] { button4, button22, button31, button40 };
            Button[] Diameter2 = new Button[5] { button6, button20, button27, button34, button41 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button13.BackColor = Color.Yellow;
            }

            else { button13.BackColor = Color.Black; }

           
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button9, button10, button11, button12, button13, button15, button16 };
            Button[] colo = new Button[7] { button6, button22, button30, button38, button46, button54, button62 };
            Button[] Diameter1 = new Button[3] { button5, button23, button32 };
            Button[] Diameter2 = new Button[6] { button7, button21, button28, button35, button42, button49 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button14.BackColor = Color.Yellow;
            }

            else { button14.BackColor = Color.Black; }

           
        
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button9, button10, button11, button12, button13, button14, button16 };
            Button[] colo = new Button[7] { button7, button23, button31, button39, button47, button55, button63 };
            Button[] Diameter1 = new Button[2] { button6, button24 };
            Button[] Diameter2 = new Button[7] { button8, button22, button29, button36, button43, button50, button57 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button15.BackColor = Color.Yellow;
            }

            else { button15.BackColor = Color.Black; }

           
        }

        private void button16_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button9, button10, button11, button12, button13, button14, button15 };
            Button[] colo = new Button[7] { button8, button24, button32, button40, button48, button56, button64 };
            Button[] Diameter1 = new Button[1] { button7 };
            Button[] Diameter2 = new Button[6] { button23, button30, button37, button44, button51, button58 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button16.BackColor = Color.Yellow;
            }

            else { button16.BackColor = Color.Black; }

           
        }

        private void button17_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button18, button19, button20, button21, button22, button23, button24 };
            Button[] colo = new Button[7] { button1, button9, button25, button33, button41, button49, button57 };
            Button[] Diameter1 = new Button[5] { button26, button35, button44, button53, button62 };
            Button[] Diameter2 = new Button[2] { button3, button10};
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button17.BackColor = Color.Yellow;
            }

            else { button17.BackColor = Color.Black; }

           
        }

        private void button18_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button17, button19, button20, button21, button22, button23, button24 };
            Button[] colo = new Button[7] { button2, button10, button26, button34, button42, button50, button58 };
            Button[] Diameter1 = new Button[6] { button9, button27, button36, button45, button54, button63 };
            Button[] Diameter2 = new Button[3] { button4, button11, button25 };

            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button18.BackColor = Color.Yellow;
            }

            else { button18.BackColor = Color.Black; }

           
        }

        private void button19_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button17, button18, button20, button21, button22, button23, button24 };
            Button[] colo = new Button[7] { button3, button11, button27, button35, button43, button51, button59 };
            Button[] Diameter1 = new Button[7] { button1, button10, button28, button37, button46, button55, button64 };
            Button[] Diameter2 = new Button[4] { button5, button12, button26, button33};
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button19.BackColor = Color.Yellow;
            }

            else { button19.BackColor = Color.Black; }

           
        }

        private void button20_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button17, button18, button19, button21, button22, button23, button24 };
            Button[] colo = new Button[7] { button4, button12, button28, button36, button44, button52, button60 };
            Button[] Diameter1 = new Button[6] { button2, button11, button29, button38, button47, button56};
            Button[] Diameter2 = new Button[5] { button6, button13, button27, button34, button41 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button20.BackColor = Color.Yellow;
            }

            else { button20.BackColor = Color.Black; }

           
        }

        private void button21_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button17 , button18, button19, button20, button22, button23, button24 };
            Button[] colo = new Button[7] { button5, button13, button29, button37, button45, button53, button61 };
            Button[] Diameter1 = new Button[5] { button3, button12, button30, button39, button48};
            Button[] Diameter2 = new Button[6] { button7, button14, button28, button35, button42, button49 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button21.BackColor = Color.Yellow;
            }

            else { button21.BackColor = Color.Black; }

           
        }

        private void button22_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button17, button18, button19, button20, button21, button23, button24 };
            Button[] colo = new Button[7] { button6, button14, button30, button38, button46, button54, button62 };
            Button[] Diameter1 = new Button[4] { button4, button13, button31, button40};
            Button[] Diameter2 = new Button[7] { button8, button15, button29, button36, button43, button50, button57 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button22.BackColor = Color.Yellow;
            }

            else { button22.BackColor = Color.Black; }

           
        }

        private void button23_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button17, button18, button19, button20, button21, button22, button24 };
            Button[] colo = new Button[7] { button7, button15, button31, button39, button47, button55, button63 };
            Button[] Diameter1 = new Button[3] { button5, button14, button32};
            Button[] Diameter2 = new Button[6] { button16, button30, button37, button44, button51, button58 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button23.BackColor = Color.Yellow;
            }

            else { button23.BackColor = Color.Black; }

           
        }

        private void button24_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button17, button18, button19, button20, button21, button22, button23 };
            Button[] colo = new Button[7] { button8, button16, button32, button40, button48, button56, button64 };
            Button[] Diameter1 = new Button[2] { button6, button15};
            Button[] Diameter2 = new Button[5] {  button31, button38, button45, button52, button59 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button24.BackColor = Color.Yellow;
            }

            else { button24.BackColor = Color.Black; }

           
        }

        private void button25_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button26, button27, button28, button29, button30, button31, button32};
            Button[] colo = new Button[7] { button1, button9, button17, button33, button41, button49, button57};
            Button[] Diameter1 = new Button[4] { button34, button43, button52, button61 };
            Button[] Diameter2 = new Button[3] { button4, button11, button18};
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button25.BackColor = Color.Yellow;
            }

            else { button25.BackColor = Color.Black; }

           
        }

        private void button26_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button25, button27, button28, button29, button30, button31, button32 };
            Button[] colo = new Button[7] { button2, button10, button18, button34, button42, button50, button58 };
            Button[] Diameter1 = new Button[5] { button17, button35, button44, button53, button62 };
            Button[] Diameter2 = new Button[4] { button5, button12, button19, button33 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button26.BackColor = Color.Yellow;
            }

            else { button26.BackColor = Color.Black; }

           
        }

        private void button27_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button25, button26, button28, button29, button30, button31, button32 };
            Button[] colo = new Button[7] { button3, button11, button19, button35, button43, button51, button59 };
            Button[] Diameter1 = new Button[6] { button9, button18, button36, button45, button54, button63 };
            Button[] Diameter2 = new Button[5] { button6, button13, button20, button34, button41 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button27.BackColor = Color.Yellow;
            }

            else { button27.BackColor = Color.Black; }

           
        }

        private void button28_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button25, button26, button27, button29, button30, button31, button32 };
            Button[] colo = new Button[7] { button4, button12, button20, button36, button44, button52, button60 };
            Button[] Diameter1 = new Button[7] { button1, button10, button19, button37, button46, button55, button64 };
            Button[] Diameter2 = new Button[6] { button7, button14, button21, button35, button42, button49};
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button28.BackColor = Color.Yellow;
            }

            else { button28.BackColor = Color.Black; }

           
        }

        private void button29_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button25, button26, button27, button28, button30, button31, button32 };
            Button[] colo = new Button[7] { button5, button13, button21, button37, button45, button53, button61 };
            Button[] Diameter1 = new Button[6] { button2, button11, button20, button38, button47, button56};
            Button[] Diameter2 = new Button[7] { button8, button15, button22, button36, button43, button50, button57 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button29.BackColor = Color.Yellow;
            }

            else { button29.BackColor = Color.Black; }

           
        }

        private void button30_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button25, button26, button27, button28, button29, button31, button32 };
            Button[] colo = new Button[7] { button6, button14, button22, button38, button46, button54, button62 };
            Button[] Diameter1 = new Button[5] { button3, button12, button21, button39, button48};
            Button[] Diameter2 = new Button[6] {  button16, button23, button37, button44, button51, button58 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button30.BackColor = Color.Yellow;
            }

            else { button30.BackColor = Color.Black; }

           
        }

        private void button31_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button25, button26, button27, button28, button29, button30, button32 };
            Button[] colo = new Button[7] { button7, button15, button23, button39, button47, button55, button63 };
            Button[] Diameter1 = new Button[4] { button4, button13, button22, button40};
            Button[] Diameter2 = new Button[5] { button24, button38, button45, button52, button59 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button31.BackColor = Color.Yellow;
            }

            else { button31.BackColor = Color.Black; }

        }

        private void button32_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button25, button26, button27, button28, button29, button30, button31 };
            Button[] colo = new Button[7] { button8, button16, button24, button40, button48, button56, button64 };
            Button[] Diameter1 = new Button[3] { button5, button14, button2};
            Button[] Diameter2 = new Button[4] {  button39, button46, button53, button60 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button32.BackColor = Color.Yellow;
            }

            else { button32.BackColor = Color.Black; }

        
        }

        private void button33_MouseClick(object sender, MouseEventArgs e)
        {
            
       Button[] row = new Button[7] { button34, button35, button36, button37, button38, button39, button40 };
       Button[] colo = new Button[7] { button1, button9, button17, button25, button41, button49, button57 };
         Button[] Diameter1 = new Button[3] { button42,button51,button60};
         Button[] Diameter2 = new Button[4] { button5, button12,button19,button26};
         if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
         {
             button33.BackColor = Color.Yellow;
         }

         else { button33.BackColor = Color.Black; }

        }

        private void button34_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button33, button35, button36, button37, button38, button39, button40 };
            Button[] colo = new Button[7] { button2, button10,button18, button26, button42, button50,button58};
            Button[] Diameter1 = new Button[4] { button25, button43, button52, button61 };
            Button[] Diameter2 = new Button[5] { button6, button13, button20, button27, button41 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button34.BackColor = Color.Yellow;
            }

            else { button34.BackColor = Color.Black; }

        }

        private void button35_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button33, button34, button36, button37, button38, button39, button40 };
            Button[] colo = new Button[7] { button3, button11, button19, button27, button43, button51, button59 };
            Button[] Diameter1 = new Button[5] { button17,button26, button44, button53, button62 };
            Button[] Diameter2 = new Button[6] { button7, button14, button21, button28, button42, button49 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button35.BackColor = Color.Yellow;
            }

            else { button35.BackColor = Color.Black; }

        }

        private void button36_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button33, button34, button35, button37, button38, button39, button40 };
            Button[] colo = new Button[7] { button4, button12, button20, button28, button44, button52, button60};
            Button[] Diameter1 = new Button[6] { button9, button18, button27, button45, button54, button63 };
            Button[] Diameter2 = new Button[7] { button8, button15, button22, button29, button43, button50, button57 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button36.BackColor = Color.Yellow;
            }

            else { button36.BackColor = Color.Black; }

        }

        private void button37_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button33, button34, button35, button36, button38, button39, button40 };
            Button[] colo = new Button[7] { button5, button13, button21, button29, button45, button53, button61 };
            Button[] Diameter1 = new Button[7] { button1, button10,button19, button28, button46, button55, button64 };
            Button[] Diameter2 = new Button[6] {  button16, button23, button30, button44, button51, button58 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button37.BackColor = Color.Yellow;
            }

            else { button37.BackColor = Color.Black; }

        }

        private void button38_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button33, button34, button35, button36, button37, button39, button40 };
            Button[] colo = new Button[7] { button6, button14, button22, button30, button46, button54, button62 };
            Button[] Diameter1 = new Button[6] { button2, button11, button20, button29, button47, button56 };
            Button[] Diameter2 = new Button[5] {  button24, button31, button45, button52, button59 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button38.BackColor = Color.Yellow;
            }

            else { button38.BackColor = Color.Black; }

        }

        private void button39_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button33, button34, button35, button36, button37, button38, button40 };
            Button[] colo = new Button[7] { button7, button15, button23, button31, button47, button55, button63 };
            Button[] Diameter1 = new Button[5] { button3, button12, button21, button30, button48 };
            Button[] Diameter2 = new Button[4] {button32, button46, button53, button60 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button39.BackColor = Color.Yellow;
            }

            else { button39.BackColor = Color.Black; }

        }

        private void button40_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button33, button34, button35, button36, button37, button38, button39 };
            Button[] colo = new Button[7] { button8, button16, button24, button32, button48, button56, button64 };
            Button[] Diameter1 = new Button[4] { button4, button13, button22, button31};
            Button[] Diameter2 = new Button[3] {  button47, button54, button61 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button40.BackColor = Color.Yellow;
            }

            else { button40.BackColor = Color.Black; }

        }

        private void button41_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button42, button43, button44, button45, button46, button47, button48 };
            Button[] colo = new Button[7] { button1, button9 , button17, button25, button41, button49, button57 };
            Button[] Diameter1 = new Button[2] { button50 , button59 };
            Button[] Diameter2 = new Button[5] { button6, button13, button20, button27, button34 };

            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button41.BackColor = Color.Yellow;
            }

            else { button41.BackColor = Color.Black; }

        }

        private void button42_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button41, button43, button44, button45, button46, button47, button48 };
            Button[] colo = new Button[7] { button2, button10,button18, button26, button42, button50, button58 };
            Button[] Diameter1 = new Button[3] { button33, button51, button60 };
            Button[] Diameter2 = new Button[6] { button7, button14, button21, button28, button35, button49};
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button42.BackColor = Color.Yellow;
            }

            else { button42.BackColor = Color.Black; }

        }

        private void button43_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button41, button42, button44, button45, button46, button47, button48 };
            Button[] colo = new Button[7] { button3, button11, button19, button27, button43, button51, button59 };
            Button[] Diameter1 = new Button[4] { button25, button34, button52, button61 };
            Button[] Diameter2 = new Button[7] { button8, button15, button22, button29, button36, button50, button57 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button43.BackColor = Color.Yellow;
            }

            else { button43.BackColor = Color.Black; }

        }

        private void button44_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button41, button42, button43, button45, button46, button47, button48 };
            Button[] colo = new Button[7] { button4, button12, button20, button28, button44, button52, button60 };
            Button[] Diameter1 = new Button[5] { button17, button26, button35, button53, button62 };
            Button[] Diameter2 = new Button[6] {  button16, button23, button30, button37, button51, button58 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button44.BackColor = Color.Yellow;
            }

            else { button44.BackColor = Color.Black; }

        }

        private void button45_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button41, button42, button43, button44, button46, button47, button48 };
            Button[] colo = new Button[7] { button5, button13, button21, button29, button45, button53, button61 };
            Button[] Diameter1 = new Button[6] { button9 , button18, button27, button36, button54, button63 };
            Button[] Diameter2 = new Button[5] {  button24, button31, button38, button52, button59 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button45.BackColor = Color.Yellow;
            }

            else { button45.BackColor = Color.Black; }

        }

        private void button46_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button41, button42, button43, button44, button45, button47, button48 };
            Button[] colo = new Button[7] { button6, button14, button22, button30, button46, button54, button62 };
            Button[] Diameter1 = new Button[7] { button1 , button10, button19, button28, button37, button55, button64 };
            Button[] Diameter2 = new Button[4] {  button32, button39, button53, button60 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button46.BackColor = Color.Yellow;
            }

            else { button46.BackColor = Color.Black; }

        }

        private void button47_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button41, button42, button43, button44, button45, button46, button48 };
            Button[] colo = new Button[7] { button7, button15, button23, button31, button47, button55, button63 };
            Button[] Diameter1 = new Button[6] { button2, button11, button20, button29, button38, button56 };
            Button[] Diameter2 = new Button[3] {button40, button54, button61 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button47.BackColor = Color.Yellow;
            }

            else { button47.BackColor = Color.Black; }

        
        }

        private void button48_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button41, button42, button43, button44, button45, button46, button47 };
            Button[] colo = new Button[7] { button8, button16, button24, button32, button48, button56, button64 };
            Button[] Diameter1 = new Button[5] { button3, button12, button21, button30, button39 };
            Button[] Diameter2 = new Button[2] {  button55, button62 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button48.BackColor = Color.Yellow;
            }

            else { button48.BackColor = Color.Black; }

        
        }

        private void button49_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button50, button51, button52, button53, button54, button55, button56 };
            Button[] colo = new Button[7] { button1, button9 , button17, button25, button33, button41, button57 };
            Button[] Diameter1 = new Button[1] { button58};
            Button[] Diameter2 = new Button[6] { button7, button14, button21, button28, button35, button42 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button49.BackColor = Color.Yellow;
            }

            else { button49.BackColor = Color.Black; }

        
        }

        private void button50_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button49, button51, button52, button53, button54, button55, button56 };
            Button[] colo = new Button[7] { button2, button10,button18, button26, button34, button42, button58 };
            Button[] Diameter1 = new Button[2] { button41, button59 };
            Button[] Diameter2 = new Button[7] { button8, button15, button22, button29, button36, button43, button57  };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button50.BackColor = Color.Yellow;
            }

            else { button50.BackColor = Color.Black; }

        
        }

        private void button51_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button49, button50, button52, button53, button54, button55, button56 };
            Button[] colo = new Button[7] { button3, button11, button19, button27, button35, button43, button59 };
            Button[] Diameter1 = new Button[3] { button33, button42, button60 };
            Button[] Diameter2 = new Button[6] {  button16, button23, button30, button37, button44, button58 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button51.BackColor = Color.Yellow;
            }

            else { button51.BackColor = Color.Black; }

        
        }

        private void button52_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button49, button50, button51, button53, button54, button55, button56 };
            Button[] colo = new Button[7] { button4, button12, button20, button28, button36, button44, button60 };
            Button[] Diameter1 = new Button[4] { button25, button34, button43, button61 };
            Button[] Diameter2 = new Button[5] {  button24, button31, button38, button45, button59 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button52.BackColor = Color.Yellow;
            }

            else { button52.BackColor = Color.Black; }

        }

        private void button53_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button49, button50, button51, button52, button54, button55, button56 };
            Button[] colo = new Button[7] { button5, button13, button21, button29, button37, button45, button61 };
            Button[] Diameter1 = new Button[5] { button17, button26, button35, button44, button62 };
            Button[] Diameter2 = new Button[4] {  button32, button39, button46, button60 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button53.BackColor = Color.Yellow;
            }

            else { button53.BackColor = Color.Black; }

        
        }

        private void button54_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button49, button50, button51, button52, button53, button55, button56 };
            Button[] colo = new Button[7] { button6, button14, button22, button30, button38, button46, button62 };
            Button[] Diameter1 = new Button[6] { button9, button18, button27, button36, button45, button63 };
            Button[] Diameter2 = new Button[3] {  button40, button47, button61 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button54.BackColor = Color.Yellow;
            }

            else { button54.BackColor = Color.Black; }

        
        }

        private void button55_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button49, button50, button51, button52, button53, button54, button56 };
            Button[] colo = new Button[7] { button7, button15, button23, button31, button39, button47, button63 };
            Button[] Diameter1 = new Button[7] { button1, button10,button19, button28, button37, button46, button64 };
            Button[] Diameter2 = new Button[2] {  button48, button62 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button55.BackColor = Color.Yellow;
            }

            else { button55.BackColor = Color.Black; }


        }

        private void button56_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button49, button50, button51, button52, button53, button54, button55 };
            Button[] colo = new Button[7] { button8, button16, button24, button32, button40, button48, button64 };
            Button[] Diameter1 = new Button[6] { button2, button11, button20, button29, button38, button47 };
            Button[] Diameter2 = new Button[1] {  button63 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button56.BackColor = Color.Yellow;
            }

            else { button56.BackColor = Color.Black; }

        }

        private void button57_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button58, button59, button60, button61, button62, button63, button64 };
            Button[] colo = new Button[7] { button1, button9 , button17, button25, button33, button41, button49 };
            Button[] Diameter2 = new Button[7] { button8, button15, button22, button29, button36, button43, button50 };
            if (Check(row) == true && Check(colo) == true  && Check(Diameter2) == true)
            {
                button57.BackColor = Color.Yellow;
            }

            else { button57.BackColor = Color.Black; }


        }

        private void button58_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button57, button59, button60, button61, button62, button63, button64 };
            Button[] colo = new Button[7] { button2, button10,button18, button26, button34, button42, button50 };
            Button[] Diameter1 = new Button[1] {button49 };
            Button[] Diameter2 = new Button[6] {  button16, button23, button30, button37, button44, button51 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button58.BackColor = Color.Yellow;
            }

            else { button58.BackColor = Color.Black; }


        }

        private void button59_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button57, button58, button60, button61, button62, button63, button64 };
            Button[] colo = new Button[7] { button3, button11, button19, button27, button35, button43, button51 };
            Button[] Diameter1 = new Button[2] { button41, button50  };
            Button[] Diameter2 = new Button[5] {  button24, button31, button38, button45, button52 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button59.BackColor = Color.Yellow;
            }

            else { button59.BackColor = Color.Black; }


        }

        private void button60_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] row = new Button[7] { button57, button58, button59, button61, button62, button63, button64 };
            Button[] colo = new Button[7] { button4, button12, button20, button28, button36, button44, button52 };
            Button[] Diameter1 = new Button[3] { button33, button42, button51 };
            Button[] Diameter2 = new Button[4] {  button32, button39, button46, button53 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button60.BackColor = Color.Yellow;
            }

            else { button60.BackColor = Color.Black; }

                    }

        private void button61_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button57, button58, button59, button60, button62, button63, button64 };
            Button[] colo = new Button[7] { button5, button13, button21, button29, button37, button45, button53 };
            Button[] Diameter1 = new Button[4] { button25, button34, button43, button52 };
            Button[] Diameter2 = new Button[3] {  button40, button47, button54 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button61.BackColor = Color.Yellow;
            }

            else { button61.BackColor = Color.Black; }

                   
        }

        private void button62_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button57, button58, button59, button60, button61, button63, button64 };
            Button[] colo = new Button[7] { button6, button14, button22, button30, button38, button46, button54 };
            Button[] Diameter1 = new Button[5] { button17, button26, button35, button44, button53 };
            Button[] Diameter2 = new Button[2] {  button48, button55 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button62.BackColor = Color.Yellow;
            }

            else { button62.BackColor = Color.Black; }

                   
        }

        private void button63_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button57, button58, button59, button60, button61, button62, button64 };
            Button[] colo = new Button[7] { button7, button15, button23, button31, button39, button47, button55 };
            Button[] Diameter1 = new Button[6] { button9 , button18, button27, button36, button45, button54 };
            Button[] Diameter2 = new Button[1] {  button56 };
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true && Check(Diameter2) == true)
            {
                button63.BackColor = Color.Yellow;
            }

            else { button63.BackColor = Color.Black; }

                   
        }

        private void button64_MouseClick(object sender, MouseEventArgs e)
        {

            Button[] row = new Button[7] { button57, button58, button59, button60, button61, button62, button63 };
            Button[] colo = new Button[7] { button8, button16, button24, button32, button40, button48, button56 };
            Button[] Diameter1 = new Button[7] { button1, button10, button19, button28, button37, button46, button55};
            if (Check(row) == true && Check(colo) == true && Check(Diameter1) == true )
            {
                button64.BackColor = Color.Yellow;
            }

            else { button64.BackColor = Color.Black; }


        }

        private void Done(object sender, EventArgs e)
        {
            Button[] a = new Button[64] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
            button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
            button21, button22, button23, button24, button25, button26, button27, button28, button29, button30 
            ,button31, button32, button33, button34, button35, button36, button37, button38, button39, button40 
            ,button41, button42, button43, button44, button45, button46, button47, button48, button49, button50
            ,button51, button52, button53, button54, button55, button56, button57, button58, button59, button60
            ,button61, button62, button63, button64};
            
            if (Done(a) == true)
            {
                MessageBox.Show("Congratulation sir ! ");
            }
            else
            {
                MessageBox.Show("Sorry not all thing right ");
            
            }
            
            }

        private void Clear_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] a = new Button[64] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
            button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
            button21, button22, button23, button24, button25, button26, button27, button28, button29, button30 
            ,button31, button32, button33, button34, button35, button36, button37, button38, button39, button40 
            ,button41, button42, button43, button44, button45, button46, button47, button48, button49, button50
            ,button51, button52, button53, button54, button55, button56, button57, button58, button59, button60
            ,button61, button62, button63, button64};
            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i].BackColor = Color.Black; 
            
            }
            
        }    
        }

        }
    

