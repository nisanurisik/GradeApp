import Card from "./Card";

const gradesData = [
  {
    code: "NTP101",
    title: "NESNE TABANLI PROGRAMLAMA",
    class: "1. Sınıf",
    term: "Bahar Dönemi",
    grades: [
      { oran: 20, type: "Ara Sınav", note: 72 },
      { oran: 30, type: "Proje", note: 80 },
      { oran: 50, type: "Final", note: 90 },
      { oran: 100, type: "Başarı Notu", note: "BA" },
    ],
  },
  {
    code: "ALP101",
    title: "ALGORİTMA VE PROGRAMLAMA",
    class: "1. Sınıf",
    term: "Bahar Dönemi",
    grades: [
      { oran: 30, type: "Ara Sınav", note: 82 },
      { oran: 30, type: "Ödev", note: 76 },
      { oran: 40, type: "Final", note: 95 },
      { oran: 100, type: "Başarı Notu", note: "AA" },
    ],
  },
  {
    code: "ISL101",
    title: "İŞLETİM SİSTEMLERİ",
    class: "1. Sınıf",
    term: "Bahar Dönemi",
    grades: [
      { oran: 25, type: "Ara Sınav", note: 77 },
      { oran: 25, type: "Uygulama", note: 85 },
      { oran: 50, type: "Final", note: 89 },
      { oran: 100, type: "Başarı Notu", note: "BB" },
    ],
  },
  {
    code: "WEB101",
    title: "WEB PROGRAMLAMA",
    class: "1. Sınıf",
    term: "Güz Dönemi",
    grades: [
      { oran: 24, type: "Ara Sınav", note: 74 },
      { oran: 36, type: "Ödev", note: 75 },
      { oran: 40, type: "Final", note: 100 },
      { oran: 100, type: "Başarı Notu", note: "AA" },
    ],
  },
  {
    code: "MOB101",
    title: "MOBİL PROGRAMLAMA",
    class: "1. Sınıf",
    term: "Güz Dönemi",
    grades: [
      { oran: 30, type: "Ara Sınav", note: 80 },
      { oran: 30, type: "Ödev", note: 70 },
      { oran: 40, type: "Final", note: 90 },
      { oran: 100, type: "Başarı Notu", note: "BA" },
    ],
  },
  {
    code: "VT101",
    title: "VERİTABANI",
    class: "1. Sınıf",
    term: "Güz Dönemi",
    grades: [
      { oran: 25, type: "Ara Sınav", note: 78 },
      { oran: 25, type: "Ödev", note: 88 },
      { oran: 50, type: "Final", note: 85 },
      { oran: 100, type: "Başarı Notu", note: "BA" },
    ],
  },
];

function CoursesGradeCard() {
  return (
    <>
      <h2 className="poppins-semibold text-lg mb-5">1. Sınıf Dersleri</h2>
      <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-7">
        {gradesData.map((course, index) => (
          <Card key={index}>
            <div className="card-body">
              <div className="px-2">
                <div className="flex gap-5">
                  <div className="card bg-[#E7E7EF] w-19 h-15 flex items-center justify-center ">
                    <p className="flex items-center justify-center text-[#EB5C09]">
                      {course.code}
                    </p>
                  </div>
                  <div className="flex flex-col justify-center">
                    <h2 className="poppins-semibold">{course.title}</h2>
                    <div className="flex poppins-extralight">
                      <span>{course.class} </span>
                      <span className="mx-3"> / </span>
                      <span> {course.term}</span>
                    </div>
                  </div>
                </div>
              </div>
              <div className="overflow-x-auto">
                <table className="table">
                  <thead>
                    <tr>
                      <th>Oran</th>
                      <th>Çalışma Tipi</th>
                      <th>Not</th>
                    </tr>
                  </thead>
                  <tbody>
                    {course.grades.map((item, i) => (
                      <tr key={i}>
                        <td>{item.oran}</td>
                        <td>{item.type}</td>
                        <td>{item.note}</td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </div>
          </Card>
        ))}
      </div>
    </>
  );
}

export default CoursesGradeCard;
