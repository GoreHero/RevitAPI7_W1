using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

//здесь запускается окно
namespace RevitAPI7_W1
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var mainView = new MainView(commandData);
            mainView.ShowDialog();
            return Result.Succeeded;
        }
    }
}
