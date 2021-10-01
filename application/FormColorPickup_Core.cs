using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SHColorPicker
{
    public partial class FormColorPickup : Form
    {
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
            this.Pic_Pippet.Top = this.Height / 2 - this.Pic_Pippet.Height/2 - 7;

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
                using(ColorPicker colorPicker = new ColorPicker(magnif, previewSize))
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
    }
}
