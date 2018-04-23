using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Ribbon;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Printing.Native;
using DevExpress.XtraPrinting.Native;

namespace RibbonPrintPreviewDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXRibbonWindow {
        public MainWindow() {
            InitializeComponent();
        }

        static MainWindow() {
            BarManager.CheckBarItemNames = false;
            ThemeManager.ApplicationThemeName = "Office2010Black";
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            XtraReport1 report = new XtraReport1();
            ((XtraReportPreviewModel)preview.Model).Report = report;
            report.CreateDocument(false);
        }

        void documentMap_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e) {
            XtraReportPreviewModel model = (XtraReportPreviewModel)preview.Model;

            if (model != null)
                model.DocumentMapSelectedNode = e.NewValue as DocumentMapTreeViewNode;
        }

    }
}
