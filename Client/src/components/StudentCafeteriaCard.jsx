import { FaUserGraduate } from "react-icons/fa";
import Card from "./Card";

function StudentCafeteriaCard() {
  return (
    <Card>
      <figure className="px-10 pt-10">
        <FaUserGraduate className="text-7xl text-gray-700 mb-2" />
      </figure>
      <div className="card-body items-center text-center">
        <h2 className="card-title text-xl">Elisa AI</h2>
        <span className="text-sm text-gray-500">G250321123</span>
        <div className="divider m-0 p-0"></div>
        <p className="text-md font-semibold">Kart Bakiye:</p>
        <span className="text-2xl font-bold text-green-600">125 ₺</span>
      </div>
    </Card>
  );
}

export default StudentCafeteriaCard;
