using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Text;

/// <summary>
/// [구현 방식 설명]
/// 스포이드 모양의 이미지를 불러온다.
/// 이 이미지의 크기로 투명의 윈도우를 생성한다.
/// 이 윈도우는 마우스의 위치에 따라, 따라다니면서 움직이게 된다.
/// 이 과정에서 원래의 커서는 숨겨준다.
/// 이 창을 종료하게 되면 커서는 복구된다.
/// </summary>
namespace SHColorPicker
{
    public partial class FormColorPickup : Form
    {
        /// <summary>
        /// 부모폼을 담아올 용도.
        /// </summary>
        FormMain mParentForm;

        /// <summary>
        /// 로그 디버깅 옵션
        /// </summary>
        private bool isDebug = true;

        /// <summary>
        /// true 값으로 하면, 창의 투명화를 해제해서, 디버깅 하는 용도.
        /// </summary>
        bool isCursorDebug = false;

        /// <summary>
        /// 마우스의 좌표를 담을 용도.
        /// </summary>
        Point ptMouseCursor = new Point();

        /// <summary>
        /// 확대 배율. (기본값으로는 2배. 차후 변경 가능하게 구성)
        /// </summary>
        private int magnif = 2;

        /// <summary>
        /// 부모폼에 있는 미리보기 사이즈.
        /// </summary>
        Size previewSize = new Size(0, 0);

        // ColorPicker colorPicker = new ColorPicker();

        /// <summary>
        /// 생성자
        /// 기본 메서드. 폼 초기화.
        /// </summary>
        /// <param name="_parentForm"></param>
        public FormColorPickup(FormMain _parentForm)
        {
            //컴포넌트 초기화 메서드(기본적으로 들어감)
            InitializeComponent();

            //부모 폼 값
            mParentForm = _parentForm;

            // 부모 창의 isDebug 옵션의 영향이 우선시
            if (mParentForm.isDebug)
            {
                this.isDebug = true;
            }
        }

        /// <summary>
        /// 로드 되면서 발생되는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormColorPickup_Load(object sender, EventArgs e)
        {
            Debug("[Event]Load");

            /*
            * 1. 커서가 hidden 처리가 되지 않았다면, 여기서 hidden 처리를 한다.
            * 그러나 권장되는 것은, 이 윈도우가 뜨기 전에 이미 hide 처리 할 것을 권장한다.
            */
            // 테스트 중일 때에는 검은 화면으로 보면서 확인.
            if (isCursorDebug)
            {
                Cursor.Show();
                PictureBox_Scope.BackColor = Color.Black;
            }
            else
            {
                Cursor.Hide();
            }

            // 부모창의 미리보기 picturebox 의 Size 를 가져온다.
            previewSize.Width = mParentForm.PictureBox_Scope.Size.Width;
            previewSize.Height = mParentForm.PictureBox_Scope.Size.Height;

            //debug("FormColorPickup_Load 호출");
            //szImgPreviewParent = mParentForm.szPreviewImage;

            // spoid picturebox 를 조절하고, spoid 를 정가운데에 놓음
            LoadPicker();

            //이벤트 발생
            timerPick_Tick(sender, e);
            //timerPickupColor.Interval = 1;
            timerPick.Start();

        }

        /// <summary>
        /// Timer 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPick_Tick(object sender, EventArgs e)
        {
            //마우스 포인터에 변화가 없을 때에는 동작하지 않도록 합니다.
            if (Equals(ptMouseCursor, Control.MousePosition))
            {
                //return;
            }

            // 마우스 커서의 좌표를 가져오기
            ptMouseCursor = Control.MousePosition;

            // 이벤트 호출
            CallEventColorPickup();
        }

        /// <summary>
        /// this 창의 클릭 이벤트에 의해서 호출될 메서드 이다.
        /// 여기서 종료시에 처리할 구문을 모아둔다.
        /// </summary>
        private void ClosePicker()
        {
            timerPick.Stop();
            Cursor.Show();
            Close();
        }

        /// <summary>
        /// 창 클릭 시 발생되는 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Click(object sender, EventArgs e)
        {
            ClosePicker();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_Scope_Click(object sender, EventArgs e)
        {
            ClosePicker();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picSpoid_Click(object sender, EventArgs e)
        {
            ClosePicker();
        }

        /// <summary>
        /// 현재 창의 spoid Picturebox 영역의 크기를 확대축소 비율에 맞게 조절한다. 
        /// 스포이드 는 그 정가운데에 놓도록 한다.
        /// </summary>
        private void LoadPicker()
        {
            // picker 호출
            // colorPicker.Init(magnif, previewSize);

            // 필요한 만큼으로만 윈도우 폼 을 구성
            // this.Width = colorPicker.ScopeSize.Width + 200;
            // this.Height = colorPicker.ScopeSize.Height + 200;

            this.Width = 500;
            this.Height = 500;

            // ColorPickupForm 의 중간으로 Spoid Icon 위치
            this.Pic_Pippet.Left = this.Width / 2;
            this.Pic_Pippet.Top = this.Height / 2 - this.Pic_Pippet.Height / 2 - 7;

        }

        /// <summary>
        /// 타이머 로 로드할 메서드
        /// </summary>
        private void CallEventColorPickup()
        {

            // 마우스 커서를 기준으로 해당 윈도우 창 (픽업용 히든 윈도우) 이 
            // 따라 움직이게 XY 좌표를 이동
            this.Left = ptMouseCursor.X - (Size.Width / 2);
            this.Top = ptMouseCursor.Y - (Size.Height / 2);

            // 미리보기 이미지 를 생성
            //bitmapPreview = createPreviewBitmap(ptPreviewImageCompress, szPreviewImageCompress);
            try
            {
                using (ColorPicker colorPicker = new ColorPicker(magnif, previewSize))
                {
                    Bitmap bitmap = new Bitmap(previewSize.Width, previewSize.Height, PixelFormat.Format32bppArgb);
                    // ColorPicker.CallEventColorPicker()
                    // DrawPreviewBitmap(ScopePosition, ScopeSize, bitmap);
                    colorPicker.CallEventColorPicker(ptMouseCursor, bitmap);

                    // 색상코드 를 추출. 부모창에 대입.
                    Color color = colorPicker.GetColorFromImage(bitmap);
                    mParentForm.generateView_fromColor(color);

                    Image oldImage = mParentForm.PictureBox_Scope.Image;

                    // 결과를 부모창의 미리보기 이미지 에 대입
                    mParentForm.PictureBox_Scope.Image = bitmap;

                    bitmap = null;
                    if (oldImage != null) oldImage.Dispose();

                }
            }
            catch (Exception ex)
            {
                Debug("[Exception][callEventColorPickup-drawPreviewBitmap]", ex);
                return;
            }
        }

        /// <summary>
        /// debug 용 메서드
        /// </summary>
        /// <param name="msg"></param>
        private void Debug(string msg)
        {
            if (Enabled_Debug())
            {
                System.Diagnostics.Debug.WriteLine($"[FormColorPicker] {msg}");
            }
        }

        /// <summary>
        /// debug 용 메서드
        /// </summary>
        /// <param name="msg"></param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:사용되지 않는 private 멤버 제거", Justification = "<보류 중>")]
        private void Debug(string msg, string msg2)
        {
            if (Enabled_Debug())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(msg);
                sb.Append(msg2);
                Debug(sb.ToString());
                sb.Clear();
            }
        }

        /// <summary>
        /// 디버그용 메서드
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="obj"></param>
        private void Debug(string msg, Object obj)
        {
            if (Enabled_Debug())
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(msg);
                sb.Append(obj.ToString());
                Debug(sb.ToString());
                sb.Clear();
            }
        }

        /// <summary>
        /// debug 조건 체크
        /// </summary>
        /// <returns></returns>
        private bool Enabled_Debug()
        {
            return (bool)(isDebug && System.Diagnostics.Debugger.IsAttached);
        }
    }
}
