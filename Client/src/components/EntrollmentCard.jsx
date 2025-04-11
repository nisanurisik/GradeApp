const courses = [
  {
    code: "371512002",
    title: "Atatürk İlkeleri ve İnkılap Tarihi II",
    ects: 2,
    credit: 2,
    classLevel: 1,
    lecturer: "Dr. Ahmet Yılmaz",
    type: "Zorunlu",
  },
  {
    code: "371512004",
    title: "Türk Dili II",
    ects: 2,
    credit: 2,
    classLevel: 1,
    lecturer: "Öğr. Gör. Zeynep Kara",
    type: "Zorunlu",
  },
  {
    code: "D052(2)",
    title: "Yabancı Dil Seçmeli Ders Grubu II",
    ects: 2,
    credit: 2,
    classLevel: 1,
    lecturer: "-",
    type: "Seçmeli",
  },
  {
    code: "NTP101",
    title: "NESNE TABANLI PROGRAMLAMA",
    ects: 6,
    credit: 4,
    classLevel: 1,
    lecturer: "Öğr. Gör. Burcu Demir",
    type: "Zorunlu",
  },
  {
    code: "ALP101",
    title: "ALGORİTMA VE PROGRAMLAMA",
    ects: 5,
    credit: 4,
    classLevel: 1,
    lecturer: "Dr. Mert Özkan",
    type: "Zorunlu",
  },
  {
    code: "ISL101",
    title: "İŞLETİM SİSTEMLERİ",
    ects: 5,
    credit: 3,
    classLevel: 1,
    lecturer: "Dr. Ayşe Karaca",
    type: "Zorunlu",
  },
  {
    code: "WEB101",
    title: "WEB PROGRAMLAMA",
    ects: 6,
    credit: 4,
    classLevel: 1,
    lecturer: "Öğr. Gör. Ali Can",
    type: "Zorunlu",
  },
  {
    code: "MOB101",
    title: "MOBİL PROGRAMLAMA",
    ects: 5,
    credit: 3,
    classLevel: 1,
    lecturer: "Dr. Betül Kaya",
    type: "Zorunlu",
  },
  {
    code: "VT101",
    title: "VERİTABANI",
    ects: 6,
    credit: 3,
    classLevel: 1,
    lecturer: "Dr. Emre Güler",
    type: "Zorunlu",
  },
  {
    code: "MOB101",
    title: "MOBİL PROGRAMLAMA",
    ects: 5,
    credit: 3,
    classLevel: 1,
    lecturer: "Dr. Betül Kaya",
    type: "Zorunlu",
  },
  {
    code: "VT101",
    title: "VERİTABANI",
    ects: 6,
    credit: 3,
    classLevel: 1,
    lecturer: "Dr. Emre Güler",
    type: "Zorunlu",
  },
];

function Entrollment() {
  return (
    <>
      <div className="flex my-5">
        <div className="flex items-center w-full gap-5">
          <h2 className="poppins-semibold text-md ">Danışman:</h2>
          <span className="poppins-light text-md"> Onur AYDINOĞLU</span>
        </div>
        <div className="w-full flex justify-end gap-6">
          <button className="btn btn-soft shadow-sm poppins-medium text-[13px]">
            Seçilen Dersleri Danışman Onayına Gönder
          </button>
        </div>
      </div>
      <div className="overflow-x-auto h-96">
        <table className="table table-pin-rows">
          {/* Başlık */}
          <thead className="text-black">
            <tr>
              <th></th>
              <th>Ders Kodu</th>
              <th>Ders Adı</th>
              <th>AKTS</th>
              <th>Kredi</th>
              <th>Sınıf</th>
              <th>Öğretim Görevlisi</th>
              <th>Türü</th>
            </tr>
          </thead>

          {/* İçerik */}
          <tbody>
            {courses.map((course, index) => (
              <tr key={index}>
                <th>
                  <label>
                    <input type="checkbox" className="checkbox" />
                  </label>
                </th>
                <td>{course.code}</td>
                <td>{course.title}</td>
                <td>{course.ects}</td>
                <td>{course.credit}</td>
                <td>{course.classLevel}</td>
                <td>{course.lecturer}</td>
                <td>
                  <span
                    className={`badge ${
                      course.type === "Zorunlu"
                        ? "badge-secondary"
                        : "badge-primary"
                    }`}
                  >
                    {course.type}
                  </span>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </>
  );
}

export default Entrollment;
