import StudentCard from "../components/StudentCard";
import StudentNews from "../components/StudentNews";

function Home() {
  return (
    <div className="flex gap-7">
      <div className="w-80 flex-none">
        <StudentCard />
      </div>
      <div className="w-full">
        <StudentNews />
      </div>
    </div>
  );
}

export default Home;
