const studentInfo = {
  name: "Elisa",
  surname: "AI",
  number: 19060856,
  faculty: "Mühendislik",
  department: "Bilgisayar Mühendisliği",
  year: "1. Sınıf",
  registrationDate: "2025-09-14",
  registrationReason: "YKS",
  curriculum: "2024 Mühendislik Müfredatı",
  studyStatus: "Normal Süresi İçinde",
  generalAverage: 3.15,
};

function StudentInfo() {
  return (
    <>
      <h2 className="text-center text-lg poppins-bold mb-4">Ders Kayıt</h2>
      <div className="bg-base-100 rounded-box shadow-md w-full p-6">
        <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
          {/* Sol Sütun */}
          <ul className="space-y-3">
            <li className="flex items-center">
              <span className="poppins-medium text-sm text-sm w-40">
                Ad Soyad:
              </span>
              <span className="poppins-light text-sm">
                {studentInfo.name} {studentInfo.surname}
              </span>
            </li>
            <li className="flex items-center">
              <span className="poppins-medium text-sm w-40">Öğrenci No:</span>
              <span className="poppins-light text-sm">
                {studentInfo.number}
              </span>
            </li>
            <li className="flex items-center">
              <span className="poppins-medium text-sm w-40">Fakülte:</span>
              <span className="poppins-light text-sm">
                {studentInfo.faculty}
              </span>
            </li>
            <li className="flex items-center">
              <span className="poppins-medium text-sm w-40">Bölüm:</span>
              <span className="poppins-light text-sm">
                {studentInfo.department}
              </span>
            </li>
            <li className="flex items-center">
              <span className="poppins-medium text-sm w-40">Sınıf:</span>
              <span className="poppins-light text-sm">{studentInfo.year}</span>
            </li>
          </ul>

          {/* Sağ Sütun */}
          <ul className="space-y-3">
            <li className="flex items-center">
              <span className="poppins-medium text-sm w-40">Kayıt Tarihi:</span>
              <span className="poppins-light text-sm">
                {studentInfo.registrationDate}
              </span>
            </li>
            <li className="flex items-center">
              <span className="poppins-medium text-sm w-40">Kayıt Türü:</span>
              <span className="poppins-light text-sm">
                {studentInfo.registrationReason}
              </span>
            </li>
            <li className="flex items-center">
              <span className="poppins-medium text-sm w-40">Müfredat:</span>
              <span className="poppins-light text-sm">
                {studentInfo.curriculum}
              </span>
            </li>
            <li className="flex items-center">
              <span className="poppins-medium text-sm w-40">
                Öğrenim Durumu:
              </span>
              <span className="poppins-light text-sm">
                {studentInfo.studyStatus}
              </span>
            </li>
            <li className="flex items-center">
              <span className="poppins-medium text-sm w-40">
                Genel Ortalama:
              </span>
              <span className="poppins-light text-sm">
                {studentInfo.generalAverage}
              </span>
            </li>
          </ul>
        </div>
      </div>
    </>
  );
}

export default StudentInfo;
