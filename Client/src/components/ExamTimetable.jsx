function ExamTimetable() {
  return (
    <>
      <h2 className="text-center text-xl md:text-2xl font-semibold mb-6">
        1. Sınıf Bilgisayar Mühendisliği Sınav Takvimi
      </h2>

      <div className="overflow-x-auto rounded-box border border-base-content/10 bg-base-100">
        <table className="table min-w-[700px] text-xs md:text-sm">
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
            <tr>
              <td>Matematik-II</td>
              <td>15.04.2025 (Salı)</td>
              <td>10:00 - 12:00</td>
              <td>Vize</td>
              <td>Amfi 1</td>
            </tr>
            <tr>
              <td>Fizik-II</td>
              <td>17.04.2025 (Perşembe)</td>
              <td>13:30 - 15:00</td>
              <td>Vize</td>
              <td>Fizik Lab.</td>
            </tr>
            <tr>
              <td>Elektrik Devreleri ve Elektronik</td>
              <td>18.04.2025 (Cuma)</td>
              <td>09:00 - 11:00</td>
              <td>Vize</td>
              <td>Lab 202</td>
            </tr>
            <tr>
              <td>Olasılık ve İstatistiğe Giriş</td>
              <td>30.05.2025 (Cuma)</td>
              <td>11:00 - 13:00</td>
              <td>Vize</td>
              <td>Amfi 2</td>
            </tr>
            <tr>
              <td>Programlamaya Giriş-II</td>
              <td>03.06.2025 (Salı)</td>
              <td>14:00 - 16:00</td>
              <td>Vize</td>
              <td>Lab 205</td>
            </tr>
            <tr>
              <td>Çizge Kuramı</td>
              <td>05.06.2025 (Perşembe)</td>
              <td>15:00 - 17:00</td>
              <td>Vize</td>
              <td>208</td>
            </tr>
          </tbody>
        </table>
      </div>
    </>
  );
}

export default ExamTimetable;
