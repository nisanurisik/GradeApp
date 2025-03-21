import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Layout from "./layouts/Layout";
import Home from "./pages/Home";
import Courses from "./pages/Courses";
import Schedule from "./pages/Schedule";
import Exams from "./pages/Exams";
import Transcript from "./pages/Transcript";
import Enrollment from "./pages/Enrollment";
import Advising from "./pages/Advising";
import Library from "./pages/Library";
import Cafeteria from "./pages/Cafeteria";

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Layout />}>
          <Route index element={<Home />} />
          <Route path="courses" element={<Courses />} />
          <Route path="schedule" element={<Schedule />} />
          <Route path="exams" element={<Exams />} />
          <Route path="transcript" element={<Transcript />} />
          <Route path="enrollment" element={<Enrollment />} />
          <Route path="advising" element={<Advising />} />
          <Route path="library" element={<Library />} />
          <Route path="cafeteria" element={<Cafeteria />} />
        </Route>
      </Routes>
    </Router>
  );
}

export default App;
