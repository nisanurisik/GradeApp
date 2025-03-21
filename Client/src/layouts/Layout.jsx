import Footer from "../components/Footer";
import Navbar from "../components/Navbar";
import Sidebar from "../components/Sidebar";
import { Outlet } from "react-router-dom";

function Layout() {
  return (
    <>
      <div className="flex">
        <Sidebar />

        <div className="w-full">
          <Navbar />
          <main className="flex-grow p-7">
            <Outlet />
          </main>
        </div>
      </div>
      <Footer />
    </>
  );
}

export default Layout;
