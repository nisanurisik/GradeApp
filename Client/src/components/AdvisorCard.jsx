import { FaUserTie } from "react-icons/fa";
import Card from "./Card";

function StudentCard() {
  return (
    <div className="w-76">
      <Card>
        <figure className="px-10 pt-10">
          <FaUserTie className="text-7xl text-gray-700 mb-2" />
        </figure>
        <div className="card-body items-center text-center">
          <h2 className="card-title text-xl">Nisa Nur IŞIK</h2>
          <span className="text-gray-600 text-sm">Danışman Öğretim Üyesi</span>
          <p className="text-gray-700 text-sm">Mühendislik Fakültesi</p>
          <span className="text-gray-700 font-semibold text-sm">
            Bilgisayar Mühendisliği Bölümü
          </span>
          <div className="divider p-0 m-0"></div>
          <div className="card-actions">
            <button className="btn btn-xs btn-primary">
              nisa.nur.isik@gradeapp.edu.tr
            </button>
          </div>
        </div>
      </Card>
    </div>
  );
}

export default StudentCard;
