import React from "react";
import { MdCampaign } from "react-icons/md";
import Card from "./Card";

const announcements = [
  {
    date: "9 Eylül, 00:00",
    title: "Sistem Duyurusu",
    description:
      "2024-2025 akademik yılı için öğrenci bilgi sistemi bakım çalışmaları 9-10 Eylül tarihleri arasında gerçekleştirilecektir. Bu süre zarfında sisteme erişim sağlanamayacaktır.",
  },
  {
    date: "10 Eylül, 14:00",
    title: "Akademik Takvim Yayınlandı",
    description:
      "2024-2025 eğitim öğretim yılına ait akademik takvim üniversitemiz web sitesinde yayınlanmıştır. Öğrencilerimizin ders kayıtları ve sınav tarihlerini takip etmeleri önemle duyurulur.",
  },
  {
    date: "23 Eylül, 09:00",
    title: "Yemek Bursu Başvuruları Başladı",
    description:
      "2024-2025 öğretim yılı için yemek bursu başvuruları 23-30 Eylül tarihleri arasında alınacaktır. Başvurular öğrenci işleri otomasyonu üzerinden yapılacaktır.",
  },
];

const StudentNews = () => {
  return (
    <Card>
      <div className="card-body flex flex-col items-start">
        <h2 className="card-title flex items-center text-gray-600">
          Duyurular
        </h2>

        <div className="divider w-full"></div>

        <ul className="steps steps-vertical w-full">
          {announcements.map((item, index) => (
            <li key={index} className="step mb-4">
              <span className="step-icon">
                <MdCampaign className="text-2xl text-purple-600" />
              </span>
              <div className="space-y-1 w-full">
                <span className="flex text-gray-400 text-sm ms-4">
                  {item.date}
                </span>
                <div className="card flex items-start  bg-[#F0F0F0] shadow-sm p-4 space-y-1">
                  <h2 className=" text-purple-600 text-sm">{item.title}</h2>
                  <span className="text-start text-gray-900">
                    {item.description}
                  </span>
                </div>
              </div>
            </li>
          ))}
        </ul>
      </div>
    </Card>
  );
};

export default StudentNews;
