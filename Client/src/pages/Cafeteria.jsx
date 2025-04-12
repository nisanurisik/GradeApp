import CafeteriaCard from "../components/CafeteriaCard";
import StudentCafeteriaCard from "../components/StudentCafeteriaCard";

function Cafeteria() {
  return (
    <div className="flex gap-7">
      <div className="w-80 flex-none">
        <StudentCafeteriaCard />
      </div>
      <div className="w-full">
        <CafeteriaCard />
      </div>
    </div>
  );
}

export default Cafeteria;
