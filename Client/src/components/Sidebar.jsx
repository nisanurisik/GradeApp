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

function Sidebar() {
  return (
    <div className="drawer sm:drawer-open bg-white w-72">
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
            <a className="flex items-center gap-5">
              <FaHome size={20} /> Anasayfa
            </a>
          </li>
          <li>
            <a className="flex items-center gap-5">
              <FaBookOpen size={20} /> Seçilen Dersler
            </a>
          </li>
          <li>
            <a className="flex items-center gap-5">
              <FaCalendarAlt size={20} /> Ders Programı
            </a>
          </li>
          <li>
            <a className="flex items-center gap-5">
              <FaClock size={20} /> Sınav Takvimi
            </a>
          </li>
          <li>
            <a className="flex items-center gap-5">
              <FaFileAlt size={20} /> Transkript
            </a>
          </li>
          <li>
            <a className="flex items-center gap-5">
              <FaEdit size={20} /> Derse Yazılma
            </a>
          </li>
          <li>
            <a className="flex items-center gap-5">
              <FaUserTie size={20} /> Danışmanlık
            </a>
          </li>
          <li>
            <a className="flex items-center gap-5">
              <FaBook size={20} /> Kütüphane
            </a>
          </li>
          <li>
            <a className="flex items-center gap-5">
              <FaUtensils size={20} /> Yemekhane
            </a>
          </li>
        </ul>
      </div>
    </div>
  );
}

export default Sidebar;
