const exams = [
  {
    course: "Matematik-II",
    date: "15.04.2025 (Salı)",
    clock: "10:00 - 12:00",
    type: "Vize",
    class: "Amfi 1",
  },
  {
    course: "Fizik-II",
    date: "17.04.2025 (Perşembe)",
    clock: "13:30 - 15:00",
    type: "Vize",
    class: "Fizik Lab.",
  },
  {
    course: "Elektrik Devreleri ve Elektronik",
    date: "18.04.2025 (Cuma)",
    clock: "09:00 - 11:00",
    type: "Vize",
    class: "Lab 202",
  },
  {
    course: "Olasılık ve İstatistiğe Giriş",
    date: "30.05.2025 (Cuma)",
    clock: "11:00 - 13:00",
    type: "Vize",
    class: "Amfi 2",
  },
  {
    course: "Programlamaya Giriş-II",
    date: "03.06.2025 (Salı)",
    clock: "14:00 - 16:00",
    type: "Vize",
    class: "Lab 205",
  },
  {
    course: "Çizge Kuramı",
    date: "05.06.2025 (Perşembe)",
    clock: "15:00 - 17:00",
    type: "Vize",
    class: "208",
  },
];

function ExamTimetable() {
  return (
    <>
      <h2 className="text-center text-xl md:text-2xl font-semibold mb-6">
        1. Sınıf Bilgisayar Mühendisliği Sınav Takvimi
      </h2>

      <div className="overflow-x-auto rounded-box border border-base-content/10 bg-base-100">
        <table className="table  text-xs md:text-sm">
          <thead>
            <tr>
              <th>Ders</th>
              <th>Tarih</th>
              <th>Saat</th>
              <th>Sınav Türü</th>
              <th>Sınıf</th>
            </tr>
          </thead>
          <tbody>
            {exams.map((exam, index) => (
              <tr key={index}>
                <td>{exam.course}</td>
                <td>{exam.date}</td>
                <td>{exam.clock}</td>
                <td>{exam.type}</td>
                <td>{exam.class}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </>
  );
}

export default ExamTimetable;
