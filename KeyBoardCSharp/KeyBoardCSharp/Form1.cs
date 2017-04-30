﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoardCSharp
{
    public partial class Form1 : Form
    {

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                    param.ExStyle |= 0x08000000;
                return param;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("Q");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;

            }
            else
            {
                SendKeys.Send("q");
            }
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("W");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("w");
            }
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("E");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("e");
            }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("R");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("r");
            }
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("T");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("t");
            }
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("Y");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("y");
            }
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("U");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("u");
            }
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("I");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("i");
            }
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("O");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("o");
            }
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("P");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("p");
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("A");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("a");
            }
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("S");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("s");
            }
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("F");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("f");
            }
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("G");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("g");
            }
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("H");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("h");
            }
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("J");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("j");
            }
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("K");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("k");
            }
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("L");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("l");
            }
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("Z");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("z");
            }
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("X");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("x");
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("C");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("c");
            }
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("V");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("v");
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("B");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("b");
            }
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("N");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("n");
            }
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("M");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("m");
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("D");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("d");
            }
        }

        private void buttonCurlyBracketOpen_Click(object sender, EventArgs e)
        {
            if(checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{{}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("[");
            }
        }

        private void buttonCurlyBracketClose_Click(object sender, EventArgs e)
        {
            if (checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{}}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("]");
            }

        }
    //
   //Implementation of Enter, esc, Fs
   //
   
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void buttonEsc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        //setting up all function keys
        private void buttonF1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void buttonF3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void buttonF4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void buttonF5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void buttonF6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void buttonF7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void buttonF8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void buttonF9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void buttonF10_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void buttonF11_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void buttonF12_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        private void buttonPrntScr_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

    
        private void buttonPageUp_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }

        private void buttonPageDown_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");            
        }



        private void buttonTab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void buttonLessThen_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("<");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send(",");
            }
        }

        private void buttonGreaterThen_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send(">");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send(".");
            }
        }

        private void buttonQuestionMarkSlash_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("?");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{/}");
            }
        }

        private void buttonColon_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send(":");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send(";");
            }
        }

        private void buttonQuotesComaRight_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("\"");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("'");
            }
        }

        private void buttonVerticalBarRigthSlash_Click(object sender, EventArgs e)
        {

            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("|");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("\\");
            }
        }

        private void buttonTildeComma_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{~}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("`");
            }
        }

        private void buttonNumOne_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("!");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{1}");
            }
        }

        private void buttonNumTwo_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("@");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{2}");
            }
        }

        private void buttonNumThree_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("#");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{3}");
            }
        }

        private void buttonNumFour_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("$");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{4}");
            }
        }

        private void buttonNumFive_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{%}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{5}");
            }
        }

        private void buttonNumSix_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{^}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{6}");
            }
        }

        private void buttonNumSeven_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("&");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{7}");
            }
        }

        private void buttonNumEight_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{*}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{8}");
            }
        }

        private void buttonNUmNine_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{(}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{9}");
            }
        }

        private void buttonNumZero_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{)}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{0}");
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("_");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("{-}");
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (checkBoxCapLock.Checked || checkBoxLeftShift.Checked || checkBoxRightShift.Checked)
            {
                SendKeys.Send("{+}");
                checkBoxLeftShift.Checked = false;
                checkBoxRightShift.Checked = false;
            }
            else
            {
                SendKeys.Send("=");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
         
            SendKeys.Send("{DELETE}");
        
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      int x = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
      int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
      this.Location = new Point(x, y);
      this.TopMost = true;
      this.Opacity = 0.9;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Visible = false;
    }

    private void checkBoxRightShift_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void buttonStartRight_Click(object sender, EventArgs e)
    {

    }

    private void buttonCtrlRight_Click(object sender, EventArgs e)
    {

    }

    private void buttonAltRight_Click(object sender, EventArgs e)
    {

    }

    private void buttonAltLeft_Click(object sender, EventArgs e)
    {

    }

    private void buttonStartLeft_Click(object sender, EventArgs e)
    {

    }

    private void checkBoxCtrlLeft_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBoxLeftShift_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBoxCapLock_CheckedChanged(object sender, EventArgs e)
    {

    }


    //helpful:

    //SendKeys.Send("{HOME}");
    //SendKeys.Send("{END}");


  }
}
