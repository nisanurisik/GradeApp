function CourseSchedul() {
  return (
    <>
      <h2 className="text-center text-xl md:text-2xl font-semibold mb-6">
        1. Sınıf Bilgisayar Mühendisliği Ders Programı
      </h2>

      <div className="overflow-x-auto rounded-box border border-base-content/10 bg-base-100">
        <table className="table min-w-[800px] text-xs md:text-sm">
          <thead>
            <tr>
              <th>Saat</th>
              <th>Pazartesi</th>
              <th>Salı</th>
              <th>Çarşamba</th>
              <th>Perşembe</th>
              <th>Cuma</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <th>08:15 - 09:00</th>
              <td>Matematik-II</td>
              <td></td>
              <td></td>
              <td></td>
              <td></td>
            </tr>
            <tr>
              <th>09:15 - 10:00</th>
              <td>Matematik-II</td>
              <td>Fizik-II Lab. B</td>
              <td>Olasılık ve İstatistiğe Giriş</td>
              <td>Fizik-II</td>
              <td>Programlamaya Giriş-II</td>
            </tr>
            <tr>
              <th>10:15 - 11:00</th>
              <td></td>
              <td>Fizik-II Lab. A</td>
              <td>Uygul. ve İstatistiğe Giriş</td>
              <td>Fizik-II</td>
              <td>Programlamaya Giriş-II</td>
            </tr>
            <tr>
              <th>11:15 - 12:00</th>
              <td></td>
              <td>Fizik-II Lab. A</td>
              <td>Olasılık ve İstatistiğe Giriş</td>
              <td>Programlamaya Giriş-II</td>
              <td>Program. Giriş-II (Lab. A)</td>
            </tr>
            <tr>
              <th>12:00 - 13:00</th>
              <td
                colSpan={5}
                className="text-center font-medium text-base-content/70"
              >
                Öğlen Arası
              </td>
            </tr>
            <tr>
              <th>13:15 - 14:00</th>
              <td>Elektrik Devreleri ve Elektronik</td>
              <td>İngilizce-II</td>
              <td></td>
              <td>Matematik-II (Uyg.)</td>
              <td>Program. Giriş-II (Lab. B)</td>
            </tr>
            <tr>
              <th>14:15 - 15:00</th>
              <td>Elektrik Devreleri ve Elektronik</td>
              <td>İngilizce-II</td>
              <td>Donanım Lab.</td>
              <td>Matematik-II (Uyg.)</td>
              <td>Çizge Kuramı</td>
            </tr>
            <tr>
              <th>15:15 - 16:00</th>
              <td>Elektrik Devreleri ve Elektronik</td>
              <td>İngilizce-II</td>
              <td>Donanım Lab.</td>
              <td></td>
              <td>Çizge Kuramı</td>
            </tr>
            <tr>
              <th>16:15 - 17:00</th>
              <td></td>
              <td></td>
              <td>Donanım Lab.</td>
              <td></td>
              <td>Girişimcilik ve Yenilikçilik</td>
            </tr>
            <tr>
              <th>17:00 - 17:45</th>
              <td></td>
              <td></td>
              <td>Donanım Lab.</td>
              <td></td>
              <td>Girişimcilik ve Yenilikçilik</td>
            </tr>
          </tbody>
        </table>
      </div>
    </>
  );
}

export default CourseSchedul;
