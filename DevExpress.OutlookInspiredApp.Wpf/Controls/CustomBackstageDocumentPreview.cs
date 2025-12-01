using System.Windows;
using DevExpress.XtraReports;

namespace DevExpress.DevAV.Controls {
    public class CustomBackstageDocumentPreview : BackstageDocumentPreview {
        public static readonly DependencyProperty DocumentSourceProperty =
            DependencyProperty.Register("DocumentSource", typeof(IReport), typeof(CustomBackstageDocumentPreview), new PropertyMetadata(null));
        public IReport DocumentSource { get { return (IReport)GetValue(DocumentSourceProperty); } set { SetValue(DocumentSourceProperty, value); } }
    }
}
