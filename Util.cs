using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.DB.Structure;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Modless
{
    public class Util
    {
        // 선택한 Face의 Edge를 Curve로 변환하여 List<Curve>로 반환하는 함수
        public static List<Curve> GetCrvFrFace(Face face)
        {
            List<Curve> curves = new List<Curve>();
            EdgeArrayArray edgeArrays = face.EdgeLoops;

            foreach (EdgeArray edgeArray in edgeArrays)
            {
                foreach (Edge edge in edgeArray)
                {
                    Curve c = edge.AsCurve();
                    curves.Add(c);
                }
            }
            return curves;
        }

        // XYZ 좌표 리스트를 받아서 Curve 리스트로 반환하는 함수
        public static List<Curve> GetCurveListFromPts(List<XYZ> points)
        {
            List<Curve> curves = new List<Curve>();
            for (int i = 0; i < points.Count - 1; i++)
            {
                Line line = Line.CreateBound(points[i], points[i + 1]);
                curves.Add(line);
            }
            return curves;
        }

        //XYZ 좌표 리스트를 받아서 CurveLoop로 반환하는 함수
        public static CurveLoop GetCurveLoopFromPTS(List<XYZ> points)
        {
            CurveLoop cl = new CurveLoop();
            for (int i = 0; i < points.Count - 1; i++)
            {
                Line line = Line.CreateBound(points[i], points[i + 1]);
                cl.Append(line);
            }
            else if (i == points.Count - 1)
            {
                Line line = Line.CreateBound(points[i], points[0]);
                cl.Append(line);
            }
        }
        return cl;   
        }
           

    public static void CreateFloor(Document doc, IList<CurveLoop> cl, ElementId floorid, ElementId levelid, double tt)
        {
            using (Transaction trans = new Transaction(doc, "바닥을 생성합니다."))
            {
                trans.Start();
                Floor f = Floor.Create(doc, cl, floorid, levelid);
                Parameter param = f.get_Parameter(BuiltInParameter.FLOOR_HEIGHTABOVELEVEL_PARAM);
                param.Set(tt);
                trans.Commit();
            }
        }

        public static FloorType FindFloorTypeByName(string name, Document doc)
        {
            FilteredElementCollector col = new FilteredElementCollector(doc);
            col.OfCategory(BuiltInCategory.OST_Floors);
            col.OfClass(typeof(FloorType));
            FloorType ft = null;
            foreach (FloorType item in col)
            {
                if (item.Name ==name)
                {
                    ft = item;
                    break;
                }
                return ft;
            }

            public static WallType GetWallTypeByName(Document doc, string name)
        {
            WallType wallType = null;
            FilteredElementCollector col = new FilteredElementCollector(dpc);
            col.OfCategory(BuiltInCategory.OST_Walls);
            col.OfClass(typeof(WallType));

            foreach(WallType wt in col)
            {
                if (wt.Name == name)
                {
                    wallType = wt;
                    break;
                }
            }
            return wallType;
        }

        public static void CreateWall(Document doc, Curve c, WallType wt, Level level, double t, bool isSTR)
        {
            using (Transaction trans = new Transaction(docm "마감벽을 그립니다."))
            {
                trans.Commit();
            }
        }

        public static double GetWallTHK(WallType wt)
        {
            Parameter param = wt.get_Parameter(BuiltInParameter.WALL_ATTR_WIDTH_PARAM);
            double t = param.AsDouble();
            return t;
        }

        public static DataTable GetDataTableFromSring(List<string> strs)
        {
            DataTable dt = new DataTable();
            foreach(string item in strs)
            {
                dt.Columns.Add(item);
            }
            return dt;
        }

        public static Level GetLevelByName(Document doc, string name)
        {
            Level findLevel = null;
            FilteredElementCollector col = new FilteredElementCollector(doc);
            col.OfClass(typeof(Level));

            foreach (Level item in col)
            {
                if (item.Name == name)
                {
                    findLevel = item;
                    break;
                }
            }
            return findLevel;
        }

        public static FloorType GetFloorTypeByName(Document doc, string name)
        {
            CeilingType findLevel = null;
            FilteredElementCollector col = new FilteredElementCollector(doc);
            col.OfClass(typeof(CeilingType));

            foreach (CeilingType item in col)
            {
                if (item.Name == name)
                {
                    findLevel = item;
                    break;
                }
            }
            return findLevel;
        }
    }
}
