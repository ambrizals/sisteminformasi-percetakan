SELECT pesanan.orderid,karyawan.karyawanname,pesanan.orderconsumer,pesanan.orderconsumertelp,pesanan.orderstatus,pesanan.ordertotal,pesanan.orderbayar FROM PESANAN
INNER JOIN log_pesanan ON (log_pesanan.orderID = pesanan.orderID) AND log_pesanan.logStatus = 'Membuat Pesanan'
INNER JOIN karyawan ON (log_pesanan.karyawanID = karyawan.karyawanID) WHERE pesanan.orderid = 'ORD-1'