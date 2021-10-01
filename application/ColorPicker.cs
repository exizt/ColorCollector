using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace SHColorPicker
{
    class ColorPicker : IDisposable
    {
        /// <summary>
        /// 확대 배율. (기본값으로는 2배. 차후 변경 가능하게 구성)
        /// </summary>
        int magnif = 2;

        /// <summary>
        /// point 0, 0
        /// </summary>
        private Point ptZero = new Point(0, 0);

        /// <summary>
        /// 미리보기 이미지의 사이즈. (배율만큼 확대)
        /// </summary>
        Size previewSize;

        /// <summary>
        /// 색상을 추출하기위한 Scope의 사이즈. (미리보기 이미지의 역배율로 축소)
        /// </summary>
        public Size ScopeSize;

        /// <summary>
        /// Scope의 XY 좌표
        /// </summary>
        Point ScopePosition;

        private bool disposedValue;

        public ColorPicker()
        {
        }

        public ColorPicker(int magnif, Size previewSize)
        {
            Init(magnif, previewSize);
        }

        /// <summary>
        /// 배율, 미리보기 사이즈 등을 지정하는 초기화 메소드.
        /// </summary>
        /// <param name="magnif">배율</param>
        /// <param name="previewSize">미리보기 사이즈</param>
        public void Init(int magnif, Size previewSize)
        {
            // 미리보기 이미지 크기
            this.previewSize = previewSize;

            // 배율 지정
            this.magnif = magnif;

            // Scope영역 계산 (배율 역계산. 확대할 영역을 말함)
            ScopeSize.Width = this.previewSize.Width / this.magnif;
            ScopeSize.Height = this.previewSize.Height / this.magnif;
        }


        /// <summary>
        /// 마우스 좌표를 기준으로 preview 이미지를 생성
        /// </summary>
        /// <param name="mousePosition"></param>
        /// <param name="previewBitmap"></param>
        public void CallEventColorPicker(Point mousePosition, Bitmap previewBitmap)
        {
            // Scope영역의 XY 좌표
            // 마우스 위치에 따라서 이동.
            ScopePosition.X = mousePosition.X - (ScopeSize.Width / 2);
            ScopePosition.Y = mousePosition.Y - (ScopeSize.Height / 2);

            try
            {
                DrawPreviewBitmap(ScopePosition, ScopeSize, previewBitmap);
            } catch(Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 스크린에서 시작 좌표, 크기 기준으로 이미지를 생성
        /// </summary>
        /// <param name="_startPoint">시작 좌표</param>
        /// <param name="_blockSize">픽업 영역</param>
        /// <param name="previewBitmap">결과를 담을 이미지 (영역 사이즈와 동일하게 하면 1:1)</param>
        public void DrawPreviewBitmap(Point _startPoint, Size _blockSize, Bitmap previewBitmap)
        {
            try
            {
                // 임시 bitmap 생성.
                using (Bitmap bitmap = new Bitmap(_blockSize.Width, _blockSize.Height, PixelFormat.Format32bppArgb))
                {
                    // 임시 bitmap에 드로잉
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        // 인수:스크린좌표,그리기시작좌표,그리는사이즈.
                        g.CopyFromScreen(_startPoint, ptZero, _blockSize);
                        // g.CopyFromScreen(_startPoint, ptZero, _blockSize, CopyPixelOperation.SourceCopy);
                    }

                    // 이미지 확대처리
                    using (Graphics g = Graphics.FromImage(previewBitmap))
                    {
                        //이 항목이 있어야 선명하게 확대가 된다.
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                        //이미지 확대 (임시 bitmap보다 previewBitmap 사이즈가 크므로 확대가 됨)
                        g.DrawImage(bitmap, 0, 0, previewBitmap.Width, previewBitmap.Height);
                    }
                }
            }
            catch (Exception e)
            {
                // Debug("[Exception][drawPreviewBitmap]", ex);
                throw e;
            }
        }

        /// <summary>
        /// 이미지의 정가운데에 있는 픽셀의 값을 가져옴
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        /// 
        public Color GetColorFromImage(Image image)
        {
            using (Bitmap b = new Bitmap(image))
            {
                return b.GetPixel((int)(image.Width / 2), (int)(image.Height / 2));
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 관리형 상태(관리형 개체)를 삭제합니다.
                }

                // TODO: 비관리형 리소스(비관리형 개체)를 해제하고 종료자를 재정의합니다.
                // TODO: 큰 필드를 null로 설정합니다.
                disposedValue = true;
            }
        }

        // // TODO: 비관리형 리소스를 해제하는 코드가 'Dispose(bool disposing)'에 포함된 경우에만 종료자를 재정의합니다.
        // ~ColorPicker()
        // {
        //     // 이 코드를 변경하지 마세요. 'Dispose(bool disposing)' 메서드에 정리 코드를 입력합니다.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // 이 코드를 변경하지 마세요. 'Dispose(bool disposing)' 메서드에 정리 코드를 입력합니다.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
