using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace SHColorPicker
{
    public partial class FormColorPickup : Form
    {
        /// <summary>
        /// 확대 배율. (기본값으로는 2배. 차후 변경 가능하게 구성)
        /// </summary>
        int magnif = 2;

        /// <summary>
        /// point 0, 0
        /// </summary>
        Point ptZero = new Point(0, 0);

        /// <summary>
        /// 부모폼에 있는 미리보기 사이즈.
        /// </summary>
        Size ScopeViewSize = new Size(0, 0);

        /// <summary>
        /// 미리보기 사이즈 를 배율을 역으로 축소시킨 사이즈.
        /// </summary>
        Size ScopeSize;
        Point ScopeStartPoint;

        /// <summary>
        /// 처음에 한번만 호출되는 메서드 이다.
        /// 부모창의 Preview 와 동일한 크기의 Bitmap 생성
        /// 기본창의 '미리보기' PictureBox 가 있는데, 이것과 동일한 크기의 Bitmap 을 생성해놓는 작업이다.
        /// </summary>
        private void initPicker()
        {
            // 부모 창의 isDebug 옵션의 영향이 우선시
            if (mParentForm.isDebug)
            {
                this.isDebug = true;
            }

            // 부모창의 미리보기 picturebox 의 Size 를 가져온다.
            ScopeViewSize.Width = mParentForm.PictureBox_Scope.Size.Width;
            ScopeViewSize.Height = mParentForm.PictureBox_Scope.Size.Height;
        }

        /// <summary>
        /// 현재 창의 spoid Picturebox 영역의 크기를 확대축소 비율에 맞게 조절한다. 
        /// 스포이드 는 그 정가운데에 놓도록 한다.
        /// </summary>
        private void loadPicker()
        {
            // 확대될 영역 (축소된 영역) 을 계산 (배율 역계산)
            ScopeSize.Width = ScopeViewSize.Width / magnif;
            ScopeSize.Height = ScopeViewSize.Height / magnif;

            // 필요한 만큼으로만 윈도우 폼 을 구성
            this.Width = ScopeSize.Width + 200;
            this.Height = ScopeSize.Height + 200;

            // ColorPickupForm 의 중간으로 Spoid Icon 위치
            this.Pic_Pippet.Left = this.Width / 2;
            this.Pic_Pippet.Top = this.Height / 2 - this.Pic_Pippet.Height/2 - 7;
        }

        /// <summary>
        /// 타이머 로 로드할 메서드
        /// </summary>
        private void callEventColorPickup()
        {

            // 마우스 커서를 기준으로 해당 윈도우 창 (픽업용 히든 윈도우) 이 
            // 따라 움직이게 XY 좌표를 이동
            this.Left = ptMouseCursor.X - (Size.Width / 2);
            this.Top = ptMouseCursor.Y - (Size.Height / 2);

            // 축소된 영역의 XY 좌표
            ScopeStartPoint.X = ptMouseCursor.X - (ScopeSize.Width / 2);
            ScopeStartPoint.Y = ptMouseCursor.Y - (ScopeSize.Height / 2);

            // 미리보기 이미지 를 생성
            //bitmapPreview = createPreviewBitmap(ptPreviewImageCompress, szPreviewImageCompress);
            try
            {
                drawPreviewBitmap(ptPreviewCompress, szPreviewCompress, mParentForm.PreviewBitmap);
            }
            catch (Exception ex)
            {
                debug("[Exception][callEventColorPickup-drawPreviewBitmap]", ex.ToString());
                return;
            }

            // 색상코드 를 추출. 부모창에 대입.
            mParentForm.generateView_fromColor(getColor_fromImage(mParentForm.PreviewBitmap));

            // 결과를 부모창의 미리보기 이미지 에 대입
            mParentForm.PictureBox_Scope.Image = mParentForm.PreviewBitmap;
         }

        /// <summary>
        /// 스크린에서 시작 좌표, 크기 기준으로 이미지를 생성
        /// </summary>
        /// <param name="_startPoint">시작 좌표</param>
        /// <param name="_blockSize">픽업 영역</param>
        /// <param name="_resultImage">결과를 담을 이미지 (영역 사이즈와 동일하게 하면 1:1)</param>
        private void DrawPreviewBitmap(Point _startPoint, Size _blockSize, Image _resultImage)
        {
            try
            {
                // 임시 bitmap 생성. compress 사이즈 로 생성. using 내의 new 는 자동 해제
                using (Bitmap bitmap = new Bitmap(_blockSize.Width, _blockSize.Height, PixelFormat.Format32bppArgb))
                {
                    // 임시 bitmap 을 기준으로 grahipcs 를 시작.
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        // 인수:스크린좌표,그리기시작좌표,그리는사이즈.
                        g.CopyFromScreen(_startPoint, ptZero, _blockSize);
                    }

                    // 이미지 의 확대 동작
                    using (Graphics g = Graphics.FromImage(_resultImage))
                    {
                        //이 항목이 있어야 선명하게 확대가 된다.
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                        //이미지 확대 (bitmap 의 크기가 작고, szPreviewImage 의 크기가 커서 확대가 됨)
                        g.DrawImage(bitmap, 0, 0, ScopeViewSize.Width, ScopeViewSize.Height);
                    }
                }
            } catch (Exception ex)
            {
                debug("[Exception][drawPreviewBitmap]",ex.ToString());
                throw;
            }
        }

        /// <summary>
        /// 이미지 의 정가운데에 있는 픽셀의 값을 가져옴
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        /// 
        private Color getColor_fromImage(Image image)
        {
            using (Bitmap b = new Bitmap(image))
            {
                return b.GetPixel((int)(image.Width / 2), (int)(image.Height/2));
            }
        }

        /// <summary>
        /// 디버그용 메서드
        /// </summary>
        /// <param name="msg"></param>
        private void debug(string msg)
        {
            if(isDebug) System.Diagnostics.Debug.WriteLine(msg);
        }

        /// <summary>
        /// debug 용 메서드
        /// </summary>
        /// <param name="msg"></param>
        private void debug(string msg, string msg2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(msg);
            sb.Append(msg2);
            debug(sb.ToString());
            sb.Clear();
        }
    }
}
