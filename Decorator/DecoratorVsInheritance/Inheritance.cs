using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeginPaterrn.Decorator.NewFolder
{
    internal class Inheritance
    {
        /// <summary>
        /// افزودن پنجره های جدید با وراثت
        /// </summary>
        internal class Window
        {
        }


        internal class GalssWindow : Window
        {
        }

        internal class ColorsWindow : Window
        {
        }

        /// <summary>
        /// افزودن ویژگی بردر با وراثت
        /// </summary>

        internal class BorderWindow : Window
        {
        }

        internal class BorderGalssWindow : GalssWindow
        {
        }

        internal class BorderColorsWindow : ColorsWindow
        {
        }

        /// <summary>
        /// افزودن ویژگی اسکرول با وراثت
        /// </summary>

        internal class ScrollWindow : Window
        {
        }

        internal class ScrollGalssWindow : GalssWindow
        {
        }

        internal class ScrollColorsWindow : ColorsWindow
        {
        }
    }
}
