import Card from "./Card";

const yearData = [
  {
    term: "1. Yarıyıl",
    transcript: [
      { courseName: "Matematik-I", type: "Zorunlu", grade: "AA", ects: 6 },
      { courseName: "Fizik-I", type: "Zorunlu", grade: "BB", ects: 6 },
      {
        courseName: "Programlamaya Giriş",
        type: "Zorunlu",
        grade: "BA",
        ects: 5,
      },
    ],
    summary: {
      termEcts: 17,
      termWeighted: 39,
      termAvg: "2,29",
      generalEcts: 17,
      generalWeighted: 39,
      generalAvg: "2,29",
    },
  },
  {
    term: "2. Yarıyıl",
    transcript: [
      { courseName: "Matematik-II", type: "Zorunlu", grade: "BA", ects: 6 },
      { courseName: "Fizik-II", type: "Zorunlu", grade: "CB", ects: 6 },
      {
        courseName: "Nesneye Yönelik Prog.",
        type: "Zorunlu",
        grade: "AA",
        ects: 6,
      },
    ],
    summary: {
      termEcts: 18,
      termWeighted: 42,
      termAvg: "2,33",
      generalEcts: 35,
      generalWeighted: 81,
      generalAvg: "2,31",
    },
  },
  {
    term: "3. Yarıyıl",
    transcript: [
      { courseName: "Algoritmalar", type: "Zorunlu", grade: "AA", ects: 6 },
      { courseName: "Veri Yapıları", type: "Zorunlu", grade: "AA", ects: 5 },
      { courseName: "Veritabanı", type: "Zorunlu", grade: "BA", ects: 4 },
    ],
    summary: {
      termEcts: 15,
      termWeighted: 39,
      termAvg: "2,60",
      generalEcts: 50,
      generalWeighted: 120,
      generalAvg: "2,40",
    },
  },
  {
    term: "4. Yarıyıl",
    transcript: [
      { courseName: "Web Programlama", type: "Zorunlu", grade: "AA", ects: 6 },
      {
        courseName: "İşletim Sistemleri",
        type: "Zorunlu",
        grade: "BB",
        ects: 5,
      },
      {
        courseName: "Bilgisayar Organizasyonu",
        type: "Zorunlu",
        grade: "CB",
        ects: 5,
      },
    ],
    summary: {
      termEcts: 16,
      termWeighted: 34,
      termAvg: "2,12",
      generalEcts: 66,
      generalWeighted: 154,
      generalAvg: "2,33",
    },
  },
];

function TranscriptItem() {
  return (
    <div className="grid lg:grid-cols-1 xl:grid-cols-2 gap-7">
      {yearData.map((year, index) => (
        <Card key={index}>
          <div className="p-7">
            {/* Dönem Başlığı */}
            <div className="bg-[#E7E7EF] p-5 rounded mb-4">
              <h2 className="text-[#EB5C09] text-lg poppins-regular">
                {year.term}
              </h2>
            </div>

            {/* Ders Tablosu */}
            <div className="overflow-x-auto">
              <table className="table text-sm">
                <thead>
                  <tr>
                    <th>Ders Adı</th>
                    <th>Ders Tipi</th>
                    <th>Başarı Notu</th>
                    <th>AKTS</th>
                  </tr>
                </thead>
                <tbody>
                  {year.transcript.map((course, cIndex) => (
                    <tr key={cIndex}>
                      <td className="poppins-medium">{course.courseName}</td>
                      <td>{course.type}</td>
                      <td>{course.grade}</td>
                      <td>{course.ects}</td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>

            {/* Dönem Özeti */}
            <div className="mt-6">
              <table className="table text-sm">
                <thead>
                  <tr>
                    <th></th>
                    <th>Toplam AKTS Kredi</th>
                    <th>Toplam Ağırlıklı</th>
                    <th>Ortalama</th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <th className="poppins-medium">Dönem Sonu:</th>
                    <td>{year.summary.termEcts}</td>
                    <td>{year.summary.termWeighted}</td>
                    <td>{year.summary.termAvg}</td>
                  </tr>
                  <tr>
                    <th className="poppins-medium">Genel:</th>
                    <td>{year.summary.generalEcts}</td>
                    <td>{year.summary.generalWeighted}</td>
                    <td>{year.summary.generalAvg}</td>
                  </tr>
                </tbody>
              </table>
            </div>
          </div>
        </Card>
      ))}
    </div>
  );
}

export default TranscriptItem;
