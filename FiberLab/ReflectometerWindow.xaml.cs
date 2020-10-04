using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FiberLab
{

    /// <summary>
    /// Логика взаимодействия для ReflectometerWindow.xaml
    /// </summary>
    public partial class ReflectometerWindow : Window
    {


        public ReflectometerWindow()
        {
            InitializeComponent();
            ApplySettings();
        }

        void ApplySettings()
        {
            RenderRftmPlot();
        }

        void RenderRftmPlot()
        {
            double[] dataX = new double[] { 1, 2, 3, 4, 5 }; 
            double[] dataY = new double[] { 1, 4, 9, 16, 25 };
            RftmPlot.plt.PlotScatter(dataX, dataY);

            RftmPlot.plt.Title("Reflectometer (OTDR) Output");
            RftmPlot.plt.YLabel("Power Loss, dB");
            RftmPlot.plt.XLabel("Distance, km");

            RftmPlot.plt.PlotHLine(y: 2, draggable: true, dragLimitLower: 0);
            RftmPlot.plt.PlotVLine(x: 2, draggable: true, dragLimitLower: 0);

            RftmPlot.plt.Grid(lineStyle: ScottPlot.LineStyle.Dot);

            RftmPlot.Render();

        }

    }
}
