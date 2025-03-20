import Footer from "../components/Footer";
import Navbar from "../components/Navbar";
import Sidebar from "../components/Sidebar";

function Layout({ children }) {
  return (
    <>
      <div className="flex">
        <Sidebar />

        <div className="w-full">
          <Navbar />
          <div className="p-7">{children}</div>
        </div>
      </div>
      <Footer />
    </>
  );
}

export default Layout;
