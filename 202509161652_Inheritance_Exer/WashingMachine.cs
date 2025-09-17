using System;


namespace Electronics
{

    class WashingMachine
    {
        public enum WashingType
        {
            Vertical,   // 수직
            Horizontal  // 수평
        }

        float _height;  // 높이
        float _width;   // 폭
        float _depth;   // 깊이
        DateTime _manufactureDate;  // 제조년월일
        string _manufacturer;   // 제조회사
        float _weight;  // 중량
        string _positionData;   // 위치 정보

        // 추가 정보
        float _laundryCapacity; // 세탁 용량
        WashingType _type;      // 세탁방식


        public WashingMachine(
            float height,
            float width,
            float depth,
            DateTime manufactureDate,
            string manufacturer,
            float weight,
            string positionData,
            float laundryCapacity,
            WashingType type

         )
        {
            _height = height;
            _width = width;
            _depth = depth;
            _manufactureDate = manufactureDate;
            _manufacturer = manufacturer;
            _weight = weight;
            _laundryCapacity = laundryCapacity;
            _type = type;
        }



        public string GetPosition()
        {
            return _positionData;
        }

        public void Info()
        {
            Console.WriteLine("상품: 세탁기");
            Console.WriteLine($"세탁용량: {_laundryCapacity}, \t세탁방식: {_type}");
            Console.WriteLine($"높이: {_height}, \t폭: {_width}, \t깊이: {_depth}, \t중량: {_weight}");
            Console.WriteLine($"제조회사: {_manufacturer}, \t제조년월일: {_manufactureDate}");
            Console.WriteLine($"위치정보: {_positionData}");
        }

    }
}
