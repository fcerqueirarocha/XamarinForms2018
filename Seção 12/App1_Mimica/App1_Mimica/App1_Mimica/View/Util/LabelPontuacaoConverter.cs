using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace App1_Mimica.View.Util
{
    class LabelPontuacaoConverter : IValueConverter
    {

        // da view para a viewmodel
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
           if ((byte)value == 0)
            {
                return "Palabra";
            }
            else
            {
                return "Palavra - Pontuação: " + value;
            }
        }
        // da viewmodel para view
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
