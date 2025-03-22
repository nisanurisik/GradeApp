import { FaUserGraduate } from "react-icons/fa";
import Card from "./Card";

function StudentCard() {
  return (
    <Card>
      <figure className="px-10 pt-10">
        <FaUserGraduate className="text-7xl text-gray-700 mb-2" />
      </figure>
      <div className="card-body items-center text-center">
        <h2 className="card-title text-xl">Elisa AI</h2>
        <span className="text-gray-600 text-sm">G250321123</span>
        <p className="text-gray-700 text-sm">Mühendislik Fakültesi</p>
        <span className="text-gray-700 font-semibold text-sm">
          BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
        </span>
        <div className="divider p-0 m-0"></div>
        <div className="card-actions">
          <button className="btn btn-xs btn-primary">1. Sınıf</button>
        </div>
      </div>
    </Card>
  );
}

export default StudentCard;
