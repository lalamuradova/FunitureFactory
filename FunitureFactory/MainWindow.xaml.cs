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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FunitureFactory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
 
    public partial class MainWindow : Window
    {
        interface IChair
        {
            bool sitOn();
            bool hasLegs();
        }
        class ArtDecoChair : IChair
        {
            public bool hasLegs()
            {
                return true;
            }

            public bool sitOn()
            {
                return true;
            }
        }
        class ModernChair : IChair
        {
            public bool hasLegs()
            {
                return true;
            }

            public bool sitOn()
            {
                return true;
            }
        }
        class VictorianChair : IChair
        {
            public bool hasLegs()
            {
                return true;
            }

            public bool sitOn()
            {
                return false;
            }
        }

        interface ITable
        {
            bool sitOn();
            bool hasLegs();
        }

        class ArtDecoTable : ITable
        {
            public bool hasLegs()
            {
                return true;
            }

            public bool sitOn()
            {
                return false;
            }
        }
        class ModernTable : ITable
        {
            public bool hasLegs()
            {
                return false;
            }

            public bool sitOn()
            {
                return true;
            }
        }
        class VictorianTable : ITable
        {
            public bool hasLegs()
            {
                return false;
            }

            public bool sitOn()
            {
                return true;
            }
        }

        interface ISofa
        {

            bool canEnlarge();
        }

        class ArtSofa : ISofa
        {
            public bool canEnlarge()
            {
                return false;
            }


        }
        class ModernSofa : ISofa
        {
            public bool canEnlarge()
            {
                return false;
            }

        }
        class VictorianSofa : ISofa
        {
            public bool canEnlarge()
            {
                return true;
            }

        }


        interface IFurnitureFactory
        {
            IChair CreateChar();
            ITable CreateTable();
            ISofa CreateSofa();
            void Show();
        }

        class ModernFunitureFactory : IFurnitureFactory
        {
            public IChair CreateChar()
            {
                return new ModernChair();
            }

            public ISofa CreateSofa()
            {
                return new ModernSofa();
            }

            public ITable CreateTable()
            {
                return new ModernTable();
            }

            public void Show()
            {
                Console.WriteLine("Modern Style");
                var chair = CreateChar();
                var table = CreateTable();
                var sofa = CreateSofa();
            }

        }

        class VictorianFunitureFactory : IFurnitureFactory
        {
            public IChair CreateChar()
            {
                return new VictorianChair();
            }

            public ISofa CreateSofa()
            {
                return new VictorianSofa();
            }

            public ITable CreateTable()
            {
                return new VictorianTable();
            }

            public void Show()
            {
                Console.WriteLine("Victorian Style");
                var chair = CreateChar();
                var table = CreateTable();
                var sofa = CreateSofa();
            }

        }
        class ArtDecoFunitureFactory : IFurnitureFactory
        {
            public IChair CreateChar()
            {
                return new ArtDecoChair();
            }

            public ISofa CreateSofa()
            {
                return new ArtSofa();
            }

            public ITable CreateTable()
            {
                return new ArtDecoTable();
            }

            public void Show()
            {

                Console.WriteLine("ArtDeco Style");
                var chair = CreateChar();
                var table = CreateTable();
                var sofa = CreateSofa();
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
        }
        class Program
        {
            static void Main(string[] args)
            {
                //GUIFactory f = new WinFactory();
                //Application app = new Application(f);
                var funiturefactory = new ModernFunitureFactory();
                funiturefactory.Show();

            }
        }

    }
}
