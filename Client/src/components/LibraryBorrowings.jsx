import {
  FaBookOpen,
  FaCheckCircle,
  FaClock,
  FaExclamationCircle,
} from "react-icons/fa";
import { differenceInCalendarDays, format } from "date-fns";

const borrowings = [
  {
    title: "1984",
    author: "George Orwell",
    takenDate: "2025-04-01",
    dueDate: "2025-05-25",
    returned: false,
  },
  {
    title: "Suç ve Ceza",
    author: "Fyodor Dostoyevski",
    takenDate: "2024-02-01",
    dueDate: "2024-03-01",
    returned: true,
  },
  {
    title: "Sefiller",
    author: "Victor Hugo",
    takenDate: "2024-04-01",
    dueDate: "2024-04-20",
    returned: false,
  },
];

function getStatusBadge(borrowing) {
  const today = new Date();
  const due = new Date(borrowing.dueDate);

  if (borrowing.returned) {
    return (
      <span className="badge badge-success gap-1">
        <FaCheckCircle /> İade Edildi
      </span>
    );
  }

  const diff = differenceInCalendarDays(due, today);

  if (diff < 0) {
    return (
      <span className="badge badge-error gap-1">
        <FaExclamationCircle /> Süresi Geçmiş
      </span>
    );
  }

  return (
    <span className="badge badge-warning gap-1">
      <FaClock /> {diff} gün kaldı
    </span>
  );
}

function LibraryBorrowings() {
  return (
    <>
      <h2 className="text-2xl font-bold mb-6">
        📚 Kitap Alım Geçmişi - Elisa AI
      </h2>

      <div className="grid grid-cols-1 md:grid-cols-3 gap-6">
        {borrowings.map((book, index) => (
          <div key={index} className="card bg-base-100 shadow-md">
            <div className="card-body">
              <div className="flex items-center gap-4 mb-2">
                <FaBookOpen className="text-3xl text-primary" />
                <div>
                  <h2 className="card-title text-lg">{book.title}</h2>
                  <p className="text-sm opacity-70">{book.author}</p>
                </div>
              </div>

              <div className="text-sm">
                <p>
                  <strong>Alım Tarihi:</strong>{" "}
                  {format(new Date(book.takenDate), "dd.MM.yyyy")}
                </p>
                <p>
                  <strong>Son Teslim:</strong>{" "}
                  {format(new Date(book.dueDate), "dd.MM.yyyy")}
                </p>
              </div>

              <div className="flex justify-between items-center mt-4">
                {getStatusBadge(book)}
                <button className="btn btn-sm btn-outline btn-info">
                  Detay
                </button>
              </div>
            </div>
          </div>
        ))}
      </div>
    </>
  );
}

export default LibraryBorrowings;
