using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace PizzaWinForm
{
    class ControllerPizza
    {
        //checkbox is selected
        //Make the function for only one check box
        //Not the best solution. Testing purpose
        public static bool IsCheckedOne(CheckBox checkBox)
        {
            if (checkBox.Checked == true)
            {
                return true;
            }
            return false;
        }

        public static bool IsChecked3(CheckBox checkbox1, CheckBox checkbox2, CheckBox checkbox3)
        {
            if  (  IsCheckedOne(checkbox1) == true 
                || IsCheckedOne(checkbox2) == true 
                || IsCheckedOne(checkbox3) == true
                )
            {
                return true;
            }
            return false;
        }


        public static bool IsChecked6(CheckBox checkbox1, CheckBox checkbox2, CheckBox checkbox3, CheckBox checkbox4, CheckBox checkbox5, CheckBox checkbox6)
        {
            if (  IsCheckedOne(checkbox1) == true 
               || IsCheckedOne(checkbox2) == true 
               || IsCheckedOne(checkbox3) == true
               || IsCheckedOne(checkbox4) == true 
               || IsCheckedOne(checkbox5) == true 
               || IsCheckedOne(checkbox6) == true
               )
            {
                return true;
            }
            return false;
        }
        public static void Calculeaza()
        {

        }
    }
}
