using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using static Modless.FloorATT;
// WinForms 와 Revit API 에 같은 이름이 있는 클래스는 어느 쪽을 쓸지 지정합니다.
using TaskDialog = Autodesk.Revit.UI.TaskDialog;

namespace Modless
{
    // ═══════════════════════════════════════════════════════════════
    //  ExternalEvent 란?
    // ═══════════════════════════════════════════════════════════════
    //
    //  ■ 왜 필요한가?
    //    Revit 은 "지금은 애드인 차례" 라고 허락한 동안에만 Revit API 를 쓸 수 있게 합니다.
    //    (이 "애드인 차례" 를 API 컨텍스트 라고 부릅니다.)
    //    명령(Command)의 Execute() 가 실행되는 동안이 바로 "애드인 차례" 입니다.
    //
    //    [모달 폼 - ShowDialog()]
    //      명령 시작 → 폼 열림 → 버튼 클릭 → 폼 닫힘 → 명령 끝
    //      버튼을 누를 때 명령이 아직 안 끝났음 → "애드인 차례" → API 사용 O
    //      (대신 폼이 열려 있는 동안 Revit 을 조작할 수 없습니다)
    //
    //    [모드리스 폼 - Show()]
    //      명령 시작 → 폼 열림 → 명령 끝 (폼은 계속 떠 있음) → 버튼 클릭
    //      버튼을 누를 때 명령이 이미 끝났음 → "애드인 차례" 아님 → API 사용 X
    //      (억지로 사용하면 "... outside of API context is not allowed." 예외 발생)
    //
    //    비유 : 은행 창구
    //      창구 직원(Revit)은 번호표를 뽑고 내 차례가 된 손님만 업무를 봐 줍니다.
    //      ExternalEvent 가 바로 이 "번호표" 입니다.
    //
    //  ■ 해결 방법 : ExternalEvent (번호표)
    //    버튼을 누르면 번호표를 뽑아 두고, 내 차례가 되면 Revit 이 할 일을 실행해 줍니다.
    //
    //    1) ExternalEvent.Create(this)    → 번호표 기계 설치 (폼을 만들 때 한 번)
    //    2) exEvent.Raise()               → 번호표 뽑기 (버튼 클릭 시)
    //    3) Execute(UIApplication app)    → 내 차례! Revit 이 호출해 줌 (API 사용 O)
    //    4) exEvent.Dispose()             → 번호표 기계 철거 (폼을 닫을 때)
    //
    //    ※ 번호표를 뽑는다고 바로 실행되지 않습니다. 차례가 올 때까지 기다립니다.
    //
    //  ■ 흐름
    //    [버튼 클릭] → 번호표 뽑기 → (차례 기다림) → 내 차례 → { } 안의 코드 실행
    //
    //  ■ 사용 방법
    //    버튼 안에 아래 모양을 그대로 쓰고, { } 안에 할 일을 작성하면 됩니다.
    //
    //        RunRevit((uidoc, doc) =>
    //        {
    //            // 할 일
    //        });
    //
    // ═══════════════════════════════════════════════════════════════
    public partial class MainForm : System.Windows.Forms.Form, IExternalEventHandler
    {
        // 번호표 기계
        private readonly ExternalEvent _exEvent;
        // 번호표에 적어 둔 할 일 (내 차례가 되면 실행됨)
        private Action<UIDocument, Document> _action;

        public static string m_floorTypeName = "";

        public static string m_wallTypeName = "";
        public static string m_ceilingTypeName = "";

        public static string m_wallHeight = "";
        public static string m_ceilingHeight = "";
        public static Level m_BaseLevel;
        public static Level m_TopLevel;

        public static string m_BLevelstr = "";
        public static string m_TLevelstr = "";

        // 바닥 벽 천장 생성기용 전역변수

        public static bool m_isFloor = false;
        public static bool m_isWall = false;
        public static bool m_isCeiling = false;

        //
        public MainForm()
        {
            InitializeComponent();
            // 번호표 기계 설치
            // (폼은 Command.Execute() 안, 즉 "애드인 차례" 에 만들어지므로 여기서 설치할 수 있습니다)
            _exEvent = ExternalEvent.Create(this);
        }

        // ───────────── 버튼 ─────────────

        // 슬라브 생성
        private void button1_Click(object sender, EventArgs e)
        {
            RunRevit((uidoc, doc) =>
            {
                List<floor> fl = FloorATT.GetFloorList(doc, uidoc, m_floorTypeName);

                foreach (floor f in fl)
                {
                    Util.CreateFloor(doc, f.m_CurveLoop, f.m_FloorType, f.m_levelm f.m_floorTypeTHK);
                }
            });
        }

        // 기둥 생성
        private void button3_Click(object sender, EventArgs e)
        {
            RunRevit((uidoc, doc) =>
        }
    }
        // 벽생성
        private void button2_Click(object sender, EventArgs e)
        {
            RunRevit((uidoc, doc) =>
            {

            }
    }

        // 마감 벽 생성
        private void button5_Click(object sender, EventArgs e)
        {
            RunRevit((uidoc, doc) =>
            {
                Reference r = uidoc.Selection.PickObject(ObjectType.Face);
                Element e = doc.GetElement(r);
                GeometryObject go = e.GetGeometryObjectFromReference(r);
                Face face = go as Face;
                EdgeArrayArray eaa = face.EdgeLoops;

                List<CurveLoop> cls = new List<CurveLoop>();
                foreach (EdgeArray item1 in item)
            }



        // ───────────── 아래는 수정할 필요 없습니다 ─────────────

            /// <summary>
            /// 번호표를 뽑습니다. { } 안의 할 일은 내 차례가 되면 실행됩니다.
            /// </summary>
        private void RunRevit(Action<UIDocument, Document> action)
        {
            // 번호표에 할 일을 적고
            _action = action;
            // 번호표 뽑기 (바로 실행 X → 차례가 되면 Revit 이 Execute() 호출)
            // ※ 차례가 오기 전에 다시 누르면, 마지막에 누른 버튼의 할 일만 실행됩니다.
            _exEvent.Raise();
        }

        /// <summary>
        /// 내 차례! Revit 이 호출해 줍니다. 번호표에 적어 둔 할 일을 실행합니다.
        /// 이 안에서는 Revit API 를 자유롭게 사용할 수 있습니다.
        /// </summary>
        public void Execute(UIApplication app)
        {
            if (_action == null) return;

            UIDocument uidoc = app.ActiveUIDocument;
            if (uidoc == null)
            {
                TaskDialog.Show("Modless", "열려 있는 문서가 없습니다.");
                return;
            }

            try
            {
                _action(uidoc, uidoc.Document);
            }
            catch (Exception ex)
            {
                TaskDialog.Show("오류", ex.Message);
            }
            finally
            {
                _action = null;
            }
        }

        /// <summary>
        /// 핸들러 이름. (IExternalEventHandler)
        /// Revit 이 내부적으로 이벤트를 구분할 때 사용합니다. 아무 이름이나 괜찮습니다.
        /// </summary>
        public string GetName()
        {
            return "Modless";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // 번호표 기계 철거
            _exEvent.Dispose();
            base.OnFormClosed(e);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

