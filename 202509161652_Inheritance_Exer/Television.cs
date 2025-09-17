using System;

namespace Electronics
{
    public class Rect
    {
        float _height;
        float _width;

        public Rect(float height, float width)
        {
            _height = height;
            _width = width;
        }

        public override string ToString()
        {
            return string.Format("가로: {0}, 세로: {0}", _width, _height);
        }
    }

    class Television
    {


        float _height;  // 높이
        float _width;   // 폭
        float _depth;   // 깊이
        DateTime _manufactureDate;  // 제조년월일
        string _manufacturer;   // 제조회사
        float _weight;  // 중량
        string _positionData;   // 위치 정보

        // 추가 정보
        float _resolution;  // 해상도
        Electronics.Rect _screenSize;


        public Television(
            float height,
            float width,
            float depth,
            DateTime manufactureDate,
            string manufacturer,
            float weight,
            string positionData,
            float resolution,
            Electronics.Rect screenSize
         )
        {
            _height = height;
            _width = width;
            _depth = depth;
            _manufactureDate = manufactureDate;
            _manufacturer = manufacturer;
            _weight = weight;
            _positionData = positionData;
            _screenSize = screenSize;
        }


        public string GetPosition()
        {
            return _positionData;
        }

        public void Info()
        {
            Console.WriteLine("상품: 텔레비젼");
            Console.WriteLine($"화면사이즈: {_screenSize}, \t해상도: {_resolution}");
            Console.WriteLine($"높이: {_height}, \t폭: {_width}, \t깊이: {_depth}, \t중량: {_weight}");
            Console.WriteLine($"제조회사: {_manufacturer}, \t제조년월일: {_manufactureDate}");
            Console.WriteLine($"위치정보: {_positionData}");
        }
    }

}
