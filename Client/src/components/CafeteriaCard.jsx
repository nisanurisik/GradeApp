const weeklyMenu = [
  {
    day: "Pazartesi",
    date: "15 Nisan",
    lunch: ["Mercimek Çorbası", "Tavuk Sote", "Pilav", "Ayran"],
  },
  {
    day: "Salı",
    date: "16 Nisan",
    lunch: ["Tarhana Çorbası", "Karnıyarık", "Bulgur Pilavı", "Yoğurt"],
  },
  {
    day: "Çarşamba",
    date: "17 Nisan",
    lunch: ["Domates Çorbası", "Köfte", "Makarna", "Meyve"],
  },
  {
    day: "Perşembe",
    date: "18 Nisan",
    lunch: ["Ezogelin Çorbası", "Etli Türlü", "Pirinç Pilavı", "Komposto"],
  },
  {
    day: "Cuma",
    date: "19 Nisan",
    lunch: ["Şehriye Çorbası", "Balık Izgara", "Salata", "Tatlı"],
  },
];

function CafeteriaCard() {
  return (
    <>
      <h2 className="text-2xl poppins-semibold mb-6 text-purple-600">
        🍽️ Haftalık Yemek Menüsü
      </h2>
      <div className="space-y-4">
        {weeklyMenu.map((menu, index) => (
          <div
            key={index}
            className="bg-gradient-to-br from-base-200 to-base-100 border border-base-300 rounded-xl p-5 shadow-md hover:shadow-lg transition-shadow duration-200"
          >
            <div className="flex justify-between items-center mb-3">
              <h3 className="text-lg font-semibold text-neutral-700">
                {menu.day} - {menu.date}
              </h3>
              <span className="badge badge-info badge-outline text-xs px-3 py-1">
                Öğle Yemeği
              </span>
            </div>
            <ul className="text-sm text-gray-700 list-disc list-inside space-y-1">
              {menu.lunch.map((item, i) => (
                <li key={i} className="pl-1">
                  {item}
                </li>
              ))}
            </ul>
          </div>
        ))}
      </div>
    </>
  );
}

export default CafeteriaCard;
