# Quick Guide

Perhatikan catatan ini, kalau tidak bisa pake git lakukan langkah ini :

Clone Repository
- Lakukan step ini pertama kali
- Buka client git pake command line atau bash, di windows ada git-scm : https://git-scm.com/download/win
- ketik perintah "git clone git@gitlab.com:ambrizals/percetakan.git" terus enter
- pilih repository atau direktori dengan ketik perintah "cd percetakan"
- Folder terletak di C:\Users\(Nama User PC Kamu)\percetakan

Perbarui Repository
- Pastikan semua kode sudah benar dan sesuai dengan keinginan
- Ketik perintah "git add *" untuk nambah semua file ke repository
- Ketik perintah "git commit -m "Ketik catatannya disini" " untuk buat catatan update
- Ketik perintah "git push origin master" untuk upload data ini ke repository dan bench master

Download Repository
- Pastikan tidak melakukan editing sebelum melakukan ini
- Ketik perintah "git stash"
- Ketik perintah "git pull origin master" untuk download dan timpa data di lokal

# Catatan Penting

- Kekurangan : Form Laporan belum tersedia
- Kekurangan : Form absensi belum sepenuhnya berfungsi

# Persiapan

Sebelum melanjutkan project ini, pastikan tool ini terdapat pada perangkat :
- Microsoft Visual Studio 2010
- Net Framework 4.0 (Jika belum tersedia di perangkat)
- MySQL Connector Versi 6.9.9 (Jika references file tidak terbaca)
- MySQL Server / XAMPP
- MySQL Workbench / SQLYog / HeidiSQL / Adminer (Aplikasi lain : https://techtalk.gfi.com/top-10-free-database-tools-for-sys-admins/)
- Crystal Report VS2010

Karena aplikasi ini belum memiliki installer maka lakukan backup database melalui SQL Editor atau MySQL Command Line.
