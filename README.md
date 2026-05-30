# Champion Desktop - Inventory Management System

Aplikasi desktop berbasis **C# WinForms** untuk manajemen inventaris barang, dibuat untuk kompetisi **LKS (Lomba Kompetensi Siswa)**.

## Fitur

| Fitur | Deskripsi |
|-------|-----------|
| **Login** | Autentikasi user dengan role-based access (Admin / User) |
| **CRUD Barang** | Tambah, edit, hapus data barang |
| **Barang Masuk** | Pencatatan stok barang masuk |
| **Barang Keluar** | Pencatatan stok barang keluar |
| **Search & Filter** | Pencarian dan filter data barang |
| **Chart** | Visualisasi data inventaris |
| **SQL JOIN** | Query relasi antar tabel |
| **Aggregate Query** | Perhitungan SUM untuk laporan |
| **Excel Import** | Import data dari file Excel |

## Tech Stack

- **Language:** C# (.NET)
- **UI Framework:** Windows Forms (WinForms)
- **Database:** SQL Server (LocalDB) / MariaDB
- **IDE:** Visual Studio

## Database

Database `inventorydb` dengan tabel utama:

- `barang` — Data master barang (kode, nama, kategori, stok, harga)
- `barang_masuk` — Pencatatan barang masuk (tanggal, barang, jumlah)
- `barang_keluar` — Pencatatan barang keluar (tanggal, barang, jumlah)
- `kategori` — Kategori barang
- `users` — User & role

Import `database.sql` ke database untuk setup awal.

## Struktur Project

```
champion-dekstop/
├── .github/workflows/
│   └── desktop-autojudge.yml   # Auto-judge CI (100 pts)
├── database.sql                # Schema & seed data
├── helper.cs                   # DB connection helper
├── session.cs                  # User session management
└── README.md
```

## Auto Judge

Project ini menggunakan GitHub Actions untuk auto-grading. Setiap push akan otomatis di-cek:

| Kriteria | Poin |
|----------|------|
| Solution file (.sln) | +10 |
| Build sukses | +20 |
| WinForms usage | +5 |
| Login form | +10 |
| Role logic | +5 |
| Barang CRUD | +10 |
| Barang Masuk | +10 |
| Barang Keluar | +10 |
| SQL JOIN | +10 |
| Aggregate query (SUM) | +5 |
| Chart component | +10 |
| Search feature | +5 |
| Filter feature | +5 |
| Excel Import | +5 |
| **Total** | **100** |

## Getting Started

1. Clone repository
2. Buka solution (.sln) di Visual Studio
3. Import `database.sql` ke SQL Server / MariaDB
4. Update connection string di `helper.cs`
5. Build & Run

## License

Project untuk kompetisi LKS.
