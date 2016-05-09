using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Model;
using TSM = Tekla.Structures.Model;
using T3D = Tekla.Structures.Geometry3d;

namespace DMT_renameNameNumbering
{
    public class NameNumbering
    {
        public NameNumbering(bool vertical, string userPrefix, int startNumber, string stringStype, string userSuffix)
        {
            _vertical = vertical;
            _userPrefix = userPrefix;

            _startNumber = startNumber;
            _currentNumber = startNumber;

            _userSuffix = userSuffix;
            _stringStyle = stringStype;
        }

        bool _vertical;
        private string _userPrefix;
        private int _startNumber;
        private int _currentNumber;
        private string _stringStyle;
        private string _userSuffix;


        public int main(string selectionType)
        {
            Model myModel = new Model();
            if (!myModel.GetConnectionStatus()) return -1;

            ModelObjectEnumerator selectedObjects = getSelectedObjects();
            ArrayList selectedAssemblys = getSelectedAssemblys(selectedObjects);

            int changedNames = changeNames(selectedAssemblys, selectionType);

            myModel.CommitChanges();

            return (changedNames);
        }

        private ModelObjectEnumerator getSelectedObjects()
        {
            var selector = new TSM.UI.ModelObjectSelector();
            ModelObjectEnumerator selectionEnum = selector.GetSelectedObjects();

            return selectionEnum;
        }

        private ArrayList getSelectedAssemblys(ModelObjectEnumerator selectedObjects)
        {
            ArrayList selectedAssemblys = new ArrayList();

            while (selectedObjects.MoveNext())
            {
                if (selectedObjects.Current is Assembly)
                {
                    selectedAssemblys.Add(selectedObjects.Current as Assembly);
                }
            }

            return selectedAssemblys;
        }

        private int changeNames(ArrayList selectedAssemblys, string selectionType)
        {
            if (_vertical)
            {
                selectedAssemblys = sortByZ(selectedAssemblys);
            }

            foreach (Assembly currentAssembly in selectedAssemblys)
            {
                if (selectionType == "mainpart")
                {
                    changeMainPartName(currentAssembly);
                }
                else if (selectionType == "assembly")
                {
                    changeAssemblyName(currentAssembly);
                }
            }

            return _currentNumber - _startNumber;
        }

        private ArrayList sortByZ(ArrayList selectedAssemblys)
        {
            ArrayList sortedAssemblys = new ArrayList();
            List<Assembly> selectedBeams = new List<Assembly>();
            List<Assembly> selectedBrep = new List<Assembly>();
            List<Assembly> selectedContours = new List<Assembly>();
            List<Assembly> selectedPolyBeam = new List<Assembly>();

            foreach (Assembly currentAssembly in selectedAssemblys)
            {
                if (currentAssembly.GetMainPart() is Beam)
                    selectedBeams.Add(currentAssembly);
                else if (currentAssembly.GetMainPart() is Brep)
                    selectedBrep.Add(currentAssembly);
                else if (currentAssembly.GetMainPart() is ContourPlate)
                    selectedContours.Add(currentAssembly);
                else if (currentAssembly.GetMainPart() is PolyBeam)
                    selectedPolyBeam.Add(currentAssembly);
            }

            selectedBeams = selectedBeams.OrderBy(a => (a.GetMainPart() as Beam).StartPoint.Z).ToList();
            selectedBrep = selectedBrep.OrderBy(a => (a.GetMainPart() as Brep).StartPoint.Z).ToList();
            selectedContours = selectedContours.OrderBy(a => ((a.GetMainPart() as ContourPlate).Contour.ContourPoints[0] as ContourPoint).Z).ToList();
            selectedPolyBeam = selectedPolyBeam.OrderBy(a => ((a.GetMainPart() as PolyBeam).Contour.ContourPoints[0] as ContourPoint).Z).ToList();

            sortedAssemblys.AddRange(selectedBeams);
            sortedAssemblys.AddRange(selectedBrep);
            sortedAssemblys.AddRange(selectedContours);
            sortedAssemblys.AddRange(selectedPolyBeam);

            return sortedAssemblys;
        }

        private void changeMainPartName(Assembly currentAssembly)
        {
            Part currentMainPart = currentAssembly.GetMainPart() as Part;

            string userPos;

            if (_vertical)
            {
                userPos = _userPrefix + _currentNumber.ToString() + _userSuffix;
            }
            else
            {
                userPos = _userPrefix + _currentNumber.ToString(_stringStyle);
            }

            currentMainPart.Name = userPos;
            currentMainPart.Modify();

            _currentNumber++;
        }

        private void changeAssemblyName(Assembly currentAssembly)
        {
            string userPos;

            if (_vertical)
            {
                userPos = _userPrefix + _currentNumber.ToString() + _userSuffix;
            }
            else
            {
                userPos = _userPrefix + _currentNumber.ToString(_stringStyle);
            }

            currentAssembly.Name = userPos;
            currentAssembly.Modify();

            _currentNumber++;
        }

    }
}
