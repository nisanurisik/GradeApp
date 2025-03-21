import {
  FaHome,
  FaCalendarAlt,
  FaBookOpen,
  FaClock,
  FaFileAlt,
  FaEdit,
  FaUserTie,
  FaBook,
  FaUtensils,
} from "react-icons/fa";
import { Link } from "react-router-dom";

function Sidebar() {
  return (
    <div className="bg-white w-72">
      <div className="drawer sm:drawer-open">
        <input id="my-drawer-2" type="checkbox" className="drawer-toggle" />
        <div className="drawer-content flex flex-col items-center justify-center">
          <label
            htmlFor="my-drawer-2"
            className="btn btn-primary drawer-button sm:hidden"
          >
            Open Sidebar
          </label>
        </div>
        <div className="drawer-side">
          <div className="bg-[#181825] w-full px-7 py-5 text-white">
            GradeApp University
          </div>
          <label
            htmlFor="my-drawer-2"
            aria-label="close sidebar"
            className="drawer-overlay"
          ></label>
          <ul className="menu text-base-content w-64 mt-3 p-4 space-y-2">
            <li className="w-[100%]">
              <Link to="/" className="flex items-center gap-5">
                <FaHome size={20} /> Anasayfa
              </Link>
            </li>
            <li>
              <Link to="courses" className="flex items-center gap-5">
                <FaBookOpen size={20} /> Seçilen Dersler
              </Link>
            </li>
            <li>
              <Link to="/schedule" className="flex items-center gap-5">
                <FaCalendarAlt size={20} /> Ders Programı
              </Link>
            </li>
            <li>
              <Link to="/exams" className="flex items-center gap-5">
                <FaClock size={20} /> Sınav Takvimi
              </Link>
            </li>
            <li>
              <Link to="/transcript" className="flex items-center gap-5">
                <FaFileAlt size={20} /> Transkript
              </Link>
            </li>
            <li>
              <Link to="/enrollment" className="flex items-center gap-5">
                <FaEdit size={20} /> Derse Yazılma
              </Link>
            </li>
            <li>
              <Link to="/advising" className="flex items-center gap-5">
                <FaUserTie size={20} /> Danışmanlık
              </Link>
            </li>
            <li>
              <Link to="/library" className="flex items-center gap-5">
                <FaBook size={20} /> Kütüphane
              </Link>
            </li>
            <li>
              <Link to="/cafeteria" className="flex items-center gap-5">
                <FaUtensils size={20} /> Yemekhane
              </Link>
            </li>
          </ul>
        </div>
      </div>
    </div>
  );
}

export default Sidebar;
