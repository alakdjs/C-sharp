using System;


namespace Electronics
{
    class Refrigerator
    {
        float _height;  // 높이
        float _width;   // 폭
        float _depth;   // 깊이
        DateTime _manufactureDate;  // 제조년월일
        string _manufacturer;   // 제조회사
        float _weight;  // 중량
        string _positionData;   // 위치 정보

        // 추가정보
        float _capacity;    // 용량
        float _maximum_cooling_temperature; // 최대 냉각온도.
        float _electricity_usage;   // 전기 사용량

        public Refrigerator(
            float height,
            float width,
            float depth,
            DateTime manufactureDate,
            string manufacturer,
            float weight,
            string positionData,
            float capacity,
            float maximum_cooling_temperature,
            float electricity_usage

         )
        {
            _height = height;
            _width = width;
            _depth = depth;
            _manufactureDate = manufactureDate;
            _manufacturer = manufacturer;
            _weight = weight;
            _positionData = positionData;
            _capacity = capacity;
            _maximum_cooling_temperature = maximum_cooling_temperature;
            _electricity_usage = electricity_usage;
        }

        public string GetPosition()
        {
            return _positionData;
        }

        public void Info()
        {
            Console.WriteLine("상품: 냉장고");
            Console.WriteLine($"용량: {_capacity}, \t최대냉각온도: {_maximum_cooling_temperature}, \t전기사용량: {_electricity_usage}");
            Console.WriteLine($"높이: {_height}, \t폭: {_width}, \t깊이: {_depth}, \t중량: {_weight}");
            Console.WriteLine($"제조회사: {_manufacturer}, \t제조년월일: {_manufactureDate}");
            Console.WriteLine($"위치정보: {_positionData}");
        }
    }
}
