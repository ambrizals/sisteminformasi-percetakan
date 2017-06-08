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

# Directory List

|-- percetakan
    |-- CONTRIBUTING.md
    |-- Database.sql
    |-- directoryList.md
    |-- Percetakan.sln
    |-- Percetakan.suo
    |-- privilage_user.MD
    |-- readme.MD
    |-- sqlyog.err
    |-- include
    |   |-- mysql
    |       |-- MySql.Data.dll
    |       |-- MySql.Data.Entity.dll
    |       |-- MySql.Data.Entity.EF5.xml
    |       |-- MySql.Data.Entity.EF6.dll
    |       |-- MySql.Data.Entity.EF6.xml
    |       |-- MySql.Data.InstallState
    |       |-- MySql.Data.xml
    |       |-- MySql.Fabric.Plugin.dll
    |       |-- MySql.Web.dll
    |       |-- MySql.Web.InstallState
    |       |-- MySql.Web.NET40
    |       |-- MySql.Web.xml
    |-- Percetakan
        |-- app.config
        |-- ClsKoneksi.vb
        |-- FormAbout.Designer.vb
        |-- FormAbout.resx
        |-- FormAbout.vb
        |-- FormAbsensi.Designer.vb
        |-- FormAbsensi.resx
        |-- FormAbsensi.vb
        |-- FormAbsenTambahcuti.Designer.vb
        |-- FormAbsenTambahcuti.resx
        |-- FormAbsenTambahcuti.vb
        |-- FormAddGudang.Designer.vb
        |-- FormAddGudang.resx
        |-- FormAddGudang.vb
        |-- FormAddstockGudang.Designer.vb
        |-- FormAddstockGudang.resx
        |-- FormAddstockGudang.vb
        |-- FormBayarPesanan.Designer.vb
        |-- FormBayarPesanan.resx
        |-- FormBayarPesanan.vb
        |-- FormCaribahanPesanan.Designer.vb
        |-- FormCaribahanPesanan.resx
        |-- FormCaribahanPesanan.vb
        |-- FormConfig.Designer.vb
        |-- FormConfig.resx
        |-- FormConfig.vb
        |-- FormEditbahanGudang.Designer.vb
        |-- FormEditbahanGudang.resx
        |-- FormEditbahanGudang.vb
        |-- FormEditItem_Gudang.Designer.vb
        |-- FormEditItem_Gudang.resx
        |-- FormEditItem_Gudang.vb
        |-- FormEditKaryawan.Designer.vb
        |-- FormEditKaryawan.resx
        |-- FormEditKaryawan.vb
        |-- FormGudang.Designer.vb
        |-- FormGudang.resx
        |-- FormGudang.vb
        |-- FormJobList.Designer.vb
        |-- FormJobList.resx
        |-- FormJobList.vb
        |-- FormKaryawan.Designer.vb
        |-- FormKaryawan.resx
        |-- FormKaryawan.vb
        |-- FormPesanan.Designer.vb
        |-- FormPesanan.resx
        |-- FormPesanan.vb
        |-- Global.vb
        |-- InfoAplikasi.Designer.vb
        |-- InfoAplikasi.settings
        |-- Login.Designer.vb
        |-- Login.resx
        |-- Login.vb
        |-- MenuUtama.Designer.vb
        |-- MenuUtama.resx
        |-- MenuUtama.vb
        |-- Percetakan.vbproj
        |-- Percetakan.vbproj.user
        |-- bin
        |   |-- Debug
        |   |   |-- konfig.ini
        |   |   |-- MySql.Data.dll
        |   |   |-- MySql.Data.xml
        |   |   |-- Percetakan.exe
        |   |   |-- Percetakan.exe.config
        |   |   |-- Percetakan.pdb
        |   |   |-- Percetakan.vshost.exe
        |   |   |-- Percetakan.vshost.exe.config
        |   |   |-- Percetakan.xml
        |   |-- Release
        |       |-- Percetakan.exe.config
        |       |-- Percetakan.vshost.exe
        |       |-- Percetakan.vshost.exe.config
        |       |-- Percetakan.vshost.exe.manifest
        |-- My Project
        |   |-- Application.Designer.vb
        |   |-- Application.myapp
        |   |-- AssemblyInfo.vb
        |   |-- Resources.Designer.vb
        |   |-- Resources.resx
        |   |-- Settings.Designer.vb
        |   |-- Settings.settings
        |-- obj
            |-- x86
                |-- Debug
                |   |-- DesignTimeResolveAssemblyReferences.cache
                |   |-- DesignTimeResolveAssemblyReferencesInput.cache
                |   |-- Percetakan.exe
                |   |-- Percetakan.FormAbout.resources
                |   |-- Percetakan.FormAbsensi.resources
                |   |-- Percetakan.FormAbsenTambahcuti.resources
                |   |-- Percetakan.FormAddGudang.resources
                |   |-- Percetakan.FormAddstockGudang.resources
                |   |-- Percetakan.FormBayarPesanan.resources
                |   |-- Percetakan.FormCaribahanPesanan.resources
                |   |-- Percetakan.FormConfig.resources
                |   |-- Percetakan.FormEditbahanGudang.resources
                |   |-- Percetakan.FormEditKaryawan.resources
                |   |-- Percetakan.FormGudang.resources
                |   |-- Percetakan.FormJobList.resources
                |   |-- Percetakan.FormKaryawan.resources
                |   |-- Percetakan.FormPesanan.resources
                |   |-- Percetakan.Login.resources
                |   |-- Percetakan.MenuUtama.resources
                |   |-- Percetakan.pdb
                |   |-- Percetakan.Resources.resources
                |   |-- Percetakan.vbproj.FileListAbsolute.txt
                |   |-- Percetakan.vbproj.GenerateResource.Cache
                |   |-- Percetakan.xml
                |   |-- TempPE
                |       |-- My Project.Resources.Designer.vb.dll
                |-- Release
                    |-- DesignTimeResolveAssemblyReferencesInput.cache
                    |-- Percetakan.vbproj.FileListAbsolute.txt
                    |-- TempPE
                        |-- My Project.Resources.Designer.vb.dll
