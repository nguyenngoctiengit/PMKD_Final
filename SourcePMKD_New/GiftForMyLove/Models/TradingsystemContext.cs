using System;
using Data.Models.Trading_system;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EntityFrameworkCore.UseRowNumberForPaging;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class TradingsystemContext : DbContext
    {
        public TradingsystemContext()
        {
        }

        public TradingsystemContext(DbContextOptions<TradingsystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Annex> Annices { get; set; }
        public virtual DbSet<Archive> Archives { get; set; }
        public virtual DbSet<ArchivesAssignTask> ArchivesAssignTasks { get; set; }
        public virtual DbSet<ArchivesFbfileAttach> ArchivesFbfileAttaches { get; set; }
        public virtual DbSet<ArchivesFeedBack> ArchivesFeedBacks { get; set; }
        public virtual DbSet<ArchivesFileAttach> ArchivesFileAttaches { get; set; }
        public virtual DbSet<Assembly> Assemblies { get; set; }
        public virtual DbSet<AutomaticValue> AutomaticValues { get; set; }
        public virtual DbSet<AutomaticValuesBranch> AutomaticValuesBranches { get; set; }
        public virtual DbSet<AutomaticValuesBranchChange> AutomaticValuesBranchChanges { get; set; }
        public virtual DbSet<BackupSchedule> BackupSchedules { get; set; }
        public virtual DbSet<BagType> BagTypes { get; set; }
        public virtual DbSet<BangTinh> BangTinhs { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Can> Cans { get; set; }
        public virtual DbSet<Carrier> Carriers { get; set; }
        public virtual DbSet<ChangeDetail> ChangeDetails { get; set; }
        public virtual DbSet<ChangeStock> ChangeStocks { get; set; }
        public virtual DbSet<ChiDao> ChiDaos { get; set; }
        public virtual DbSet<ChiPhiUocTinh> ChiPhiUocTinhs { get; set; }
        public virtual DbSet<CoA> CoAs { get; set; }
        public virtual DbSet<CoB> CoBs { get; set; }
        public virtual DbSet<CoD> CoDs { get; set; }
        public virtual DbSet<CoE> CoEs { get; set; }
        public virtual DbSet<CoX> CoXes { get; set; }
        public virtual DbSet<ComputerLog> ComputerLogs { get; set; }
        public virtual DbSet<ComputerRigister> ComputerRigisters { get; set; }
        public virtual DbSet<ConfigReport> ConfigReports { get; set; }
        public virtual DbSet<ContSea> ContSeas { get; set; }
        public virtual DbSet<ContentExportWord> ContentExportWords { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CtFixgium> CtFixgia { get; set; }
        public virtual DbSet<CtHdmb> CtHdmbs { get; set; }
        public virtual DbSet<CustomerNorm> CustomerNorms { get; set; }
        public virtual DbSet<DaiLy> DaiLies { get; set; }
        public virtual DbSet<DangKy4C> DangKy4Cs { get; set; }
        public virtual DbSet<DanhGium> DanhGia { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DieuKhoanCl> DieuKhoanCls { get; set; }
        public virtual DbSet<DieuKhoanCl1> DieuKhoanCls1 { get; set; }
        public virtual DbSet<DieuKhoanCl11> DieuKhoanCl1s { get; set; }
        public virtual DbSet<DieuKhoanCl12> DieuKhoanCl1s1 { get; set; }
        public virtual DbSet<DkctHdmb> DkctHdmbs { get; set; }
        public virtual DbSet<Dkfixgium> Dkfixgia { get; set; }
        public virtual DbSet<Dkhdmb> Dkhdmbs { get; set; }
        public virtual DbSet<Dmkh> Dmkhs { get; set; }
        public virtual DbSet<Dmtte> Dmttes { get; set; }
        public virtual DbSet<DoanhThu> DoanhThus { get; set; }
        public virtual DbSet<DocArchive> DocArchives { get; set; }
        public virtual DbSet<DocFeedBack> DocFeedBacks { get; set; }
        public virtual DbSet<DocFileAttach> DocFileAttaches { get; set; }
        public virtual DbSet<DocPlace> DocPlaces { get; set; }
        public virtual DbSet<DocProcess> DocProcesses { get; set; }
        public virtual DbSet<DocProcessWaste> DocProcessWastes { get; set; }
        public virtual DbSet<DocStyle> DocStyles { get; set; }
        public virtual DbSet<DocType> DocTypes { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DonviTv> DonviTvs { get; set; }
        public virtual DbSet<DonviTv1> DonviTvs1 { get; set; }
        public virtual DbSet<DsPhongn> DsPhongns { get; set; }
        public virtual DbSet<Edit> Edits { get; set; }
        public virtual DbSet<EditReason> EditReasons { get; set; }
        public virtual DbSet<EdocDatum> EdocData { get; set; }
        public virtual DbSet<EdocDetail> EdocDetails { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FeedBackFileAttach> FeedBackFileAttaches { get; set; }
        public virtual DbSet<FileDatum> FileData { get; set; }
        public virtual DbSet<FileStored> FileStoreds { get; set; }
        public virtual DbSet<FileTaiLieu> FileTaiLieus { get; set; }
        public virtual DbSet<Fixgium> Fixgia { get; set; }
        public virtual DbSet<GiaoNhan> GiaoNhans { get; set; }
        public virtual DbSet<GroupBranch> GroupBranches { get; set; }
        public virtual DbSet<GroupRight> GroupRights { get; set; }
        public virtual DbSet<HangHoaCanGiaiQuyet> HangHoaCanGiaiQuyets { get; set; }
        public virtual DbSet<Hanghoa> Hanghoas { get; set; }
        public virtual DbSet<Hdmb> Hdmbs { get; set; }
        public virtual DbSet<Hdmb1> Hdmb1s { get; set; }
        public virtual DbSet<HdmbAnnex> HdmbAnnices { get; set; }
        public virtual DbSet<HdmbGiaohang> HdmbGiaohangs { get; set; }
        public virtual DbSet<Hh> Hhs { get; set; }
        public virtual DbSet<Hopdong1> Hopdong1s { get; set; }
        public virtual DbSet<Huyen> Huyens { get; set; }
        public virtual DbSet<IconChat> IconChats { get; set; }
        public virtual DbSet<ImportBhxh2022> ImportBhxh2022s { get; set; }
        public virtual DbSet<ImportBhxh2022B> ImportBhxh2022Bs { get; set; }
        public virtual DbSet<ImportBhxhNew> ImportBhxhNews { get; set; }
        public virtual DbSet<ImportSaiMaNvBhxh2022> ImportSaiMaNvBhxh2022s { get; set; }
        public virtual DbSet<InputContract> InputContracts { get; set; }
        public virtual DbSet<InputDetail> InputDetails { get; set; }
        public virtual DbSet<InputDetailSx> InputDetailSxes { get; set; }
        public virtual DbSet<InputStock> InputStocks { get; set; }
        public virtual DbSet<InputStockSx> InputStockSxes { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<InxHoaTan> InxHoaTans { get; set; }
        public virtual DbSet<InxVanPhong> InxVanPhongs { get; set; }
        public virtual DbSet<Ioform> Ioforms { get; set; }
        public virtual DbSet<Kc> Kcs { get; set; }
        public virtual DbSet<Kcsky> Kcskies { get; set; }
        public virtual DbSet<Kdtv> Kdtvs { get; set; }
        public virtual DbSet<KeHoachNam> KeHoachNams { get; set; }
        public virtual DbSet<Kh> Khs { get; set; }
        public virtual DbSet<KhTam2> KhTam2s { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Khachngoai> Khachngoais { get; set; }
        public virtual DbSet<KhieuNai> KhieuNais { get; set; }
        public virtual DbSet<KhkdTiep> KhkdTieps { get; set; }
        public virtual DbSet<Khohang> Khohangs { get; set; }
        public virtual DbSet<Khuvuc> Khuvucs { get; set; }
        public virtual DbSet<KimNgach> KimNgaches { get; set; }
        public virtual DbSet<KimNgach2019> KimNgach2019s { get; set; }
        public virtual DbSet<KimNgach20192020> KimNgach20192020s { get; set; }
        public virtual DbSet<KimNgach2020> KimNgach2020s { get; set; }
        public virtual DbSet<KimNgachDoanhThu> KimNgachDoanhThus { get; set; }
        public virtual DbSet<KtTtContract> KtTtContracts { get; set; }
        public virtual DbSet<KyKetHdPakd> KyKetHdPakds { get; set; }
        public virtual DbSet<Learning> Learnings { get; set; }
        public virtual DbSet<LenhXk> LenhXks { get; set; }
        public virtual DbSet<LichCongTac> LichCongTacs { get; set; }
        public virtual DbSet<ListCo> ListCos { get; set; }
        public virtual DbSet<LogCan> LogCans { get; set; }
        public virtual DbSet<LogMessage> LogMessages { get; set; }
        public virtual DbSet<LoiNhuan> LoiNhuans { get; set; }
        public virtual DbSet<LuongBh2022> LuongBh2022s { get; set; }
        public virtual DbSet<LuongCdcv> LuongCdcvs { get; set; }
        public virtual DbSet<MapkdKt> MapkdKts { get; set; }
        public virtual DbSet<MappingCodeChamCongEmployee> MappingCodeChamCongEmployees { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Menu1> Menus1 { get; set; }
        public virtual DbSet<MenuNav> MenuNavs { get; set; }
        public virtual DbSet<MenuTam> MenuTams { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageOffline> MessageOfflines { get; set; }
        public virtual DbSet<MessageToUser> MessageToUsers { get; set; }
        public virtual DbSet<Money> Money { get; set; }
        public virtual DbSet<NhapKho> NhapKhos { get; set; }
        public virtual DbSet<NhomHangHoa> NhomHangHoas { get; set; }
        public virtual DbSet<NhomTruong> NhomTruongs { get; set; }
        public virtual DbSet<Nhomhang> Nhomhangs { get; set; }
        public virtual DbSet<NkDmhangHoa> NkDmhangHoas { get; set; }
        public virtual DbSet<NkDmkhachHang> NkDmkhachHangs { get; set; }
        public virtual DbSet<NkDmtk> NkDmtks { get; set; }
        public virtual DbSet<NkInput> NkInputs { get; set; }
        public virtual DbSet<NkInputdetail> NkInputdetails { get; set; }
        public virtual DbSet<NkOutput> NkOutputs { get; set; }
        public virtual DbSet<NkOutputDetail> NkOutputDetails { get; set; }
        public virtual DbSet<NkTonkhoDk> NkTonkhoDks { get; set; }
        public virtual DbSet<Noigiaohang> Noigiaohangs { get; set; }
        public virtual DbSet<Notice> Notices { get; set; }
        public virtual DbSet<Notify> Notifies { get; set; }
        public virtual DbSet<NsBacdt> NsBacdts { get; set; }
        public virtual DbSet<NsBangChamcong> NsBangChamcongs { get; set; }
        public virtual DbSet<NsBangluong> NsBangluongs { get; set; }
        public virtual DbSet<NsCaLv> NsCaLvs { get; set; }
        public virtual DbSet<NsCdkn> NsCdkns { get; set; }
        public virtual DbSet<NsChuyenluong> NsChuyenluongs { get; set; }
        public virtual DbSet<NsChuyennganh> NsChuyennganhs { get; set; }
        public virtual DbSet<NsChuyenpb> NsChuyenpbs { get; set; }
        public virtual DbSet<NsCongdoan> NsCongdoans { get; set; }
        public virtual DbSet<NsCongtac> NsCongtacs { get; set; }
        public virtual DbSet<NsDangKyPhep> NsDangKyPheps { get; set; }
        public virtual DbSet<NsDangvien> NsDangviens { get; set; }
        public virtual DbSet<NsDanhGiaCbnv> NsDanhGiaCbnvs { get; set; }
        public virtual DbSet<NsDlChamcong> NsDlChamcongs { get; set; }
        public virtual DbSet<NsDmChamcong> NsDmChamcongs { get; set; }
        public virtual DbSet<NsDmNgaycong> NsDmNgaycongs { get; set; }
        public virtual DbSet<NsDmThuong> NsDmThuongs { get; set; }
        public virtual DbSet<NsDmbp> NsDmbps { get; set; }
        public virtual DbSet<NsDmcbnv> NsDmcbnvs { get; set; }
        public virtual DbSet<NsDmchucvu> NsDmchucvus { get; set; }
        public virtual DbSet<NsDmdantoc> NsDmdantocs { get; set; }
        public virtual DbSet<NsDmdvc> NsDmdvcs { get; set; }
        public virtual DbSet<NsDmgiamtru> NsDmgiamtrus { get; set; }
        public virtual DbSet<NsDmloaihd> NsDmloaihds { get; set; }
        public virtual DbSet<NsDmphepNam> NsDmphepNams { get; set; }
        public virtual DbSet<NsDmtd> NsDmtds { get; set; }
        public virtual DbSet<NsDmthuetn> NsDmthuetns { get; set; }
        public virtual DbSet<NsDmtknh> NsDmtknhs { get; set; }
        public virtual DbSet<NsDmtn> NsDmtns { get; set; }
        public virtual DbSet<NsDmtongiao> NsDmtongiaos { get; set; }
        public virtual DbSet<NsDoanvien> NsDoanviens { get; set; }
        public virtual DbSet<NsDotTd> NsDotTds { get; set; }
        public virtual DbSet<NsDsTuyendung> NsDsTuyendungs { get; set; }
        public virtual DbSet<NsDsVpcty1> NsDsVpcty1s { get; set; }
        public virtual DbSet<NsDulieu> NsDulieus { get; set; }
        public virtual DbSet<NsHdld> NsHdlds { get; set; }
        public virtual DbSet<NsHospital> NsHospitals { get; set; }
        public virtual DbSet<NsKetquaPv> NsKetquaPvs { get; set; }
        public virtual DbSet<NsLdtd> NsLdtds { get; set; }
        public virtual DbSet<NsLoaiCv> NsLoaiCvs { get; set; }
        public virtual DbSet<NsLoaiPhep> NsLoaiPheps { get; set; }
        public virtual DbSet<NsNgach205> NsNgach205s { get; set; }
        public virtual DbSet<NsNgachluong> NsNgachluongs { get; set; }
        public virtual DbSet<NsNghiphep> NsNghipheps { get; set; }
        public virtual DbSet<NsPhepNam> NsPhepNams { get; set; }
        public virtual DbSet<NsQhgd> NsQhgds { get; set; }
        public virtual DbSet<NsQtct> NsQtcts { get; set; }
        public virtual DbSet<NsQtdt> NsQtdts { get; set; }
        public virtual DbSet<NsQtktkl> NsQtktkls { get; set; }
        public virtual DbSet<NsTamung> NsTamungs { get; set; }
        public virtual DbSet<NsTblFilename> NsTblFilenames { get; set; }
        public virtual DbSet<NsTsluong> NsTsluongs { get; set; }
        public virtual DbSet<NsTstn> NsTstns { get; set; }
        public virtual DbSet<NsTstn0> NsTstn0s { get; set; }
        public virtual DbSet<NsTtBaohiem> NsTtBaohiems { get; set; }
        public virtual DbSet<NsTtBhyt> NsTtBhyts { get; set; }
        public virtual DbSet<NsVanbang> NsVanbangs { get; set; }
        public virtual DbSet<NsVitriTd> NsVitriTds { get; set; }
        public virtual DbSet<NsYcTuyendung> NsYcTuyendungs { get; set; }
        public virtual DbSet<OutputDetail> OutputDetails { get; set; }
        public virtual DbSet<OutputStock> OutputStocks { get; set; }
        public virtual DbSet<PairedPlan> PairedPlans { get; set; }
        public virtual DbSet<Parameter> Parameters { get; set; }
        public virtual DbSet<PaymentCondition> PaymentConditions { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PermissionsMenu> PermissionsMenus { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<PlaceExchange> PlaceExchanges { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<PortfolioPayment> PortfolioPayments { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Presentation> Presentations { get; set; }
        public virtual DbSet<ProcessWaste> ProcessWastes { get; set; }
        public virtual DbSet<ProcessWasteDetail> ProcessWasteDetails { get; set; }
        public virtual DbSet<Quocgium> Quocgia { get; set; }
        public virtual DbSet<Reminder> Reminders { get; set; }
        public virtual DbSet<ReportHdmb> ReportHdmbs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<Saveinvoice> Saveinvoices { get; set; }
        public virtual DbSet<SaveinvoiceDetail> SaveinvoiceDetails { get; set; }
        public virtual DbSet<ServiceCenterInfo> ServiceCenterInfos { get; set; }
        public virtual DbSet<ShipLine> ShipLines { get; set; }
        public virtual DbSet<Signer> Signers { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<SuKien> SuKiens { get; set; }
        public virtual DbSet<SuKienUser> SuKienUsers { get; set; }
        public virtual DbSet<SysUpdate> SysUpdates { get; set; }
        public virtual DbSet<T00lockedMonth> T00lockedMonths { get; set; }
        public virtual DbSet<T00nam> T00nams { get; set; }
        public virtual DbSet<T00updateFile> T00updateFiles { get; set; }
        public virtual DbSet<T01dgCongviec> T01dgCongviecs { get; set; }
        public virtual DbSet<T01ketquaTh> T01ketquaThs { get; set; }
        public virtual DbSet<T01ldDanhgiaHqcv> T01ldDanhgiaHqcvs { get; set; }
        public virtual DbSet<T01loaiphep> T01loaipheps { get; set; }
        public virtual DbSet<T02thanhlyHd> T02thanhlyHds { get; set; }
        public virtual DbSet<T05bangluong> T05bangluongs { get; set; }
        public virtual DbSet<T05caLamviec> T05caLamviecs { get; set; }
        public virtual DbSet<T05chamCongNgay> T05chamCongNgays { get; set; }
        public virtual DbSet<T05chamcongPhep> T05chamcongPheps { get; set; }
        public virtual DbSet<T05checkinout> T05checkinouts { get; set; }
        public virtual DbSet<T05dangkyCa> T05dangkyCas { get; set; }
        public virtual DbSet<T05danhgiaXeploai> T05danhgiaXeploais { get; set; }
        public virtual DbSet<T05dmtn> T05dmtns { get; set; }
        public virtual DbSet<T05gioLam> T05gioLams { get; set; }
        public virtual DbSet<T05khenThuongKyLuat> T05khenThuongKyLuats { get; set; }
        public virtual DbSet<T05kyhieuCong> T05kyhieuCongs { get; set; }
        public virtual DbSet<T05lamThem> T05lamThems { get; set; }
        public virtual DbSet<T05luongTamung> T05luongTamungs { get; set; }
        public virtual DbSet<T05luongThuong> T05luongThuongs { get; set; }
        public virtual DbSet<T05luongt> T05luongts { get; set; }
        public virtual DbSet<T05machine> T05machines { get; set; }
        public virtual DbSet<T05mucThuong> T05mucThuongs { get; set; }
        public virtual DbSet<T05ngaylvNam> T05ngaylvNams { get; set; }
        public virtual DbSet<T05nghilenam> T05nghilenams { get; set; }
        public virtual DbSet<T05phepnam> T05phepnams { get; set; }
        public virtual DbSet<T05thuetn> T05thuetns { get; set; }
        public virtual DbSet<T05tienNopBaoHiem> T05tienNopBaoHiems { get; set; }
        public virtual DbSet<T05tstn> T05tstns { get; set; }
        public virtual DbSet<T05tstn0> T05tstn0s { get; set; }
        public virtual DbSet<TBaoCao> TBaoCaos { get; set; }
        public virtual DbSet<TConsignee> TConsignees { get; set; }
        public virtual DbSet<TConsignee1> TConsignee1s { get; set; }
        public virtual DbSet<TDanhmucBp> TDanhmucBps { get; set; }
        public virtual DbSet<TDanhmucNv> TDanhmucNvs { get; set; }
        public virtual DbSet<THangGao> THangGaos { get; set; }
        public virtual DbSet<THdldHoaTan> THdldHoaTans { get; set; }
        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<TaiLieu> TaiLieus { get; set; }
        public virtual DbSet<TamC> TamCs { get; set; }
        public virtual DbSet<TblBuyer> TblBuyers { get; set; }
        public virtual DbSet<TblKhachhang> TblKhachhangs { get; set; }
        public virtual DbSet<TblNsDmcbnvTam> TblNsDmcbnvTams { get; set; }
        public virtual DbSet<TestImage> TestImages { get; set; }
        public virtual DbSet<Thanhtoan> Thanhtoans { get; set; }
        public virtual DbSet<Thitruong> Thitruongs { get; set; }
        public virtual DbSet<ThucHienHdPakd> ThucHienHdPakds { get; set; }
        public virtual DbSet<TieuChuanCl> TieuChuanCls { get; set; }
        public virtual DbSet<TmpManager> TmpManagers { get; set; }
        public virtual DbSet<TonDau> TonDaus { get; set; }
        public virtual DbSet<Tonghop> Tonghops { get; set; }
        public virtual DbSet<Trandatum> Trandata { get; set; }
        public virtual DbSet<TreHanMuaBan> TreHanMuaBans { get; set; }
        public virtual DbSet<TruongCa> TruongCas { get; set; }
        public virtual DbSet<TyGiaGiaoBan> TyGiaGiaoBans { get; set; }
        public virtual DbSet<TyGium> TyGia { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<UserBranch> UserBranches { get; set; }
        public virtual DbSet<UserMessage> UserMessages { get; set; }
        public virtual DbSet<UserRight> UserRights { get; set; }
        public virtual DbSet<ViewNhapHang> ViewNhapHangs { get; set; }
        public virtual DbSet<ViewXuatHang> ViewXuatHangs { get; set; }
        public virtual DbSet<VwContractConnect> VwContractConnects { get; set; }
        public virtual DbSet<VwInvoiceConnect> VwInvoiceConnects { get; set; }
        public virtual DbSet<VwTonghopHdmb> VwTonghopHdmbs { get; set; }
        public virtual DbSet<Xa> Xas { get; set; }
        public virtual DbSet<Xeptai> Xeptais { get; set; }
        public virtual DbSet<XuatKho> XuatKhos { get; set; }
        public virtual DbSet<Sp_GetHangHoa_CtHDmb> Sp_GetHangHoa_CtHDmbs { get; set; }
        public virtual DbSet<Sp_HDMB_Annex> Sp_HDMB_Annices { get; set; }
        public virtual DbSet<Sp_Hdmb_HistoryHDMB> Sp_Hdmb_HistoryHDMBs { get; set; }
        public virtual DbSet<Sp_GiaoNhan_HistoryHDMB> Sp_GiaoNhan_HistoryHDMBs { get; set; }
        public virtual DbSet<Sp_GetChungtu_HDBan_HistoryHDMB> Sp_GetChungtu_HDBan_HistoryHDMBs { get; set; }
        public virtual DbSet<Sp_GetInfoPlans_PrintReport> Sp_GetInfoPlans_PrintReports { get; set; }
        public virtual DbSet<Sp_Hdmb_FinishHDMB> Sp_Hdmb_FinishHDMBs { get; set; }
        public virtual DbSet<Sp_CtHDMB_FinishHDMB> Sp_CtHDMB_FinishHDMBs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var ConnectionStrings = "Server=14.161.30.211,2313;Database=tradingsystem;User Id=kd;Password=Intimex;";
                optionsBuilder.UseSqlServer("Server=14.161.30.211,2313;Database=tradingsystem;User Id=kd;Password=Intimex;");
                optionsBuilder.UseSqlServer(ConnectionStrings, builder => builder.UseRowNumberForPaging());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Annex>(entity =>
            {
                entity.ToTable("Annex");

                entity.Property(e => e.MaNhom)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NoiDung)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Archive>(entity =>
            {
                entity.HasKey(e => e.ArchivesId);

                entity.Property(e => e.ArchivesCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ArchivesName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ArchivesType).HasComment("0: Cong viec, 1: Ho so");

                entity.Property(e => e.Contents).IsRequired();

                entity.Property(e => e.DateClose).HasColumnType("datetime");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaCN");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ArchivesAssignTask>(entity =>
            {
                entity.ToTable("ArchivesAssignTask");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateAssign).HasColumnType("datetime");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateFinish).HasColumnType("datetime");

                entity.Property(e => e.DateFinishAssign).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserAccept)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserAssign)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Archives)
                    .WithMany(p => p.ArchivesAssignTasks)
                    .HasForeignKey(d => d.ArchivesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArchivesAssignTask_Archives");
            });

            modelBuilder.Entity<ArchivesFbfileAttach>(entity =>
            {
                entity.ToTable("ArchivesFBFileAttach");

                entity.Property(e => e.ArchivesFbid).HasColumnName("ArchivesFBId");

                entity.Property(e => e.FileAttach)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileSource)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ArchivesFeedBack>(entity =>
            {
                entity.ToTable("ArchivesFeedBack");

                entity.Property(e => e.Contents).IsRequired();

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ArchivesFileAttach>(entity =>
            {
                entity.ToTable("ArchivesFileAttach");

                entity.Property(e => e.FileAttach)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileSource)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Assembly>(entity =>
            {
                entity.HasKey(e => e.AssemblyName);

                entity.ToTable("Assembly");

                entity.Property(e => e.AssemblyName).HasMaxLength(255);

                entity.Property(e => e.AssemblyPath)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AssemblyVersion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdatePath).HasMaxLength(250);
            });

            modelBuilder.Entity<AutomaticValue>(entity =>
            {
                entity.HasKey(e => e.ObjectName)
                    .HasName("PK_DefaultValues");

                entity.Property(e => e.ObjectName).HasMaxLength(50);

                entity.Property(e => e.DefaultValueForSelection)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("dvt");

                entity.Property(e => e.LastValueOfColumnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LengthOfDefaultValueForId).HasDefaultValueSql("((10))");

                entity.Property(e => e.Minquantity)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("minquantity");

                entity.Property(e => e.Minvalue)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("minvalue");

                entity.Property(e => e.PrefixOfDefaultValueForId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<AutomaticValuesBranch>(entity =>
            {
                entity.HasKey(e => new { e.ObjectName, e.Macn });

                entity.ToTable("AutomaticValuesBranch");

                entity.Property(e => e.ObjectName).HasMaxLength(50);

                entity.Property(e => e.Macn)
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(10)
                    .HasColumnName("dvt")
                    .IsFixedLength(true);

                entity.Property(e => e.LastValueOfColumnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LengthOfDefaultValueForId).HasDefaultValueSql("((10))");

                entity.Property(e => e.MinQuantity)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("minQuantity");

                entity.Property(e => e.MinValue)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("minValue");

                entity.Property(e => e.NextValueOfColumnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Payment)
                    .HasMaxLength(50)
                    .HasColumnName("payment");

                entity.Property(e => e.PrefixOfDefaultValueForId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Printer).HasMaxLength(255);

                entity.Property(e => e.SerialOfVatBill)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.Vat).HasColumnName("vat");
            });

            modelBuilder.Entity<AutomaticValuesBranchChange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutomaticValuesBranch_Change");

                entity.Property(e => e.IsUpdate).HasColumnName("Is_Update");

                entity.Property(e => e.LastValueOfColumnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NextValueOfColumnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrefixOfDefaultValueForId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BackupSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BackupSchedule");

                entity.Property(e => e.BackupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BackupPath)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BackupType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DataBaseName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndAt)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RestorePath)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartAt)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TimeBetweenBackup).HasDefaultValueSql("((10))");
            });

            modelBuilder.Entity<BagType>(entity =>
            {
                entity.ToTable("BagType");

                entity.Property(e => e.BagTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<BangTinh>(entity =>
            {
                entity.HasKey(e => new { e.Idunit, e.Idbt, e.Iddong });

                entity.ToTable("BangTinh");

                entity.Property(e => e.Idunit)
                    .HasMaxLength(50)
                    .HasColumnName("IDUnit");

                entity.Property(e => e.Idbt)
                    .HasMaxLength(50)
                    .HasColumnName("IDBT");

                entity.Property(e => e.Iddong).HasColumnName("IDDong");

                entity.Property(e => e.ChatLuongHd)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("ChatLuongHD");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Dvtsb)
                    .HasMaxLength(50)
                    .HasColumnName("DVTSB");

                entity.Property(e => e.Dvtsl)
                    .HasMaxLength(50)
                    .HasColumnName("DVTSL");

                entity.Property(e => e.GiaTt)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("GiaTT");

                entity.Property(e => e.IsGl).HasColumnName("IsGL");

                entity.Property(e => e.LuongTru).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.LuongTruDc)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("LuongTruDC");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(50)
                    .HasColumnName("MaKH");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(50)
                    .HasColumnName("MaMH");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("date")
                    .HasColumnName("NgayHD");

                entity.Property(e => e.NgayP).HasColumnType("date");

                entity.Property(e => e.NgaySua).HasColumnType("date");

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.NguoiSua).HasMaxLength(50);

                entity.Property(e => e.NguoiTao).HasMaxLength(50);

                entity.Property(e => e.Nvnhap)
                    .HasMaxLength(500)
                    .HasColumnName("NVNhap");

                entity.Property(e => e.Ptru)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("PTru");

                entity.Property(e => e.QuiCach).HasMaxLength(255);

                entity.Property(e => e.Slthuc)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("SLThuc");

                entity.Property(e => e.Sltru)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("SLTru");

                entity.Property(e => e.SoBao).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SoHd)
                    .HasMaxLength(50)
                    .HasColumnName("SoHD");

                entity.Property(e => e.SoLuong).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SoPhieu).HasMaxLength(50);

                entity.Property(e => e.SoPkcs)
                    .HasMaxLength(50)
                    .HasColumnName("SoPKCS");

                entity.Property(e => e.SoPn)
                    .HasMaxLength(50)
                    .HasColumnName("SoPN");

                entity.Property(e => e.SoXe).HasMaxLength(20);

                entity.Property(e => e.Tckcs)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("TCKCS");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(255)
                    .HasColumnName("TenKH");

                entity.Property(e => e.TenKhoN).HasMaxLength(255);

                entity.Property(e => e.TenMh)
                    .HasMaxLength(255)
                    .HasColumnName("TenMH");

                entity.Property(e => e.TienHang).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TongCong).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vuot).HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bank");

                entity.Property(e => e.Contens)
                    .IsRequired()
                    .HasColumnName("contens");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimestampColumn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .HasName("PK_bill_1");

                entity.ToTable("bill");

                entity.Property(e => e.InvoiceId).HasMaxLength(15);

                entity.Property(e => e.Bags)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("bags");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bill_no");

                entity.Property(e => e.BodyBill1)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("body_bill1");

                entity.Property(e => e.BodyBill2)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("body_bill2");

                entity.Property(e => e.Bulk)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("_bulk")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Consignee)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("consignee");

                entity.Property(e => e.Customs)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("customs");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("date");

                entity.Property(e => e.Delivery)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("delivery");

                entity.Property(e => e.Goods)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("goods");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("gw");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Issue)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MainUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Marks)
                    .IsRequired()
                    .HasColumnName("marks");

                entity.Property(e => e.Notify)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("notify");

                entity.Property(e => e.Nw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("nw");

                entity.Property(e => e.PortDisch)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_disch");

                entity.Property(e => e.PortLoad1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_load1");

                entity.Property(e => e.PortLoad2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_load2");

                entity.Property(e => e.PreCarri)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pre_carri");

                entity.Property(e => e.Shiper)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("shiper");

                entity.Property(e => e.SubUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TMarks)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("t_marks");

                entity.Property(e => e.Tally)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tally")
                    .IsFixedLength(true);

                entity.Property(e => e.TimestampColumn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");

                entity.Property(e => e.Vessel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vessel");

                entity.Property(e => e.Voy1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy1");

                entity.Property(e => e.Voy2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy2");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.AddressE)
                    .HasMaxLength(255)
                    .HasColumnName("Address_E");

                entity.Property(e => e.AddressV)
                    .HasMaxLength(255)
                    .HasColumnName("Address_V");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.Icocode)
                    .HasMaxLength(50)
                    .HasColumnName("ICOCode");

                entity.Property(e => e.Mst)
                    .HasMaxLength(50)
                    .HasColumnName("MST");

                entity.Property(e => e.NameBg)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Name_BG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NameE)
                    .HasMaxLength(255)
                    .HasColumnName("Name_E");

                entity.Property(e => e.NameV)
                    .HasMaxLength(255)
                    .HasColumnName("Name_V");

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Stt).HasDefaultValueSql("((1))");

                entity.Property(e => e.TimeStamp).HasMaxLength(255);

                entity.Property(e => e.TitleDocument)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ToaKinhTe).HasMaxLength(255);

                entity.Property(e => e.UnitType).HasColumnName("unit_type");

                entity.Property(e => e.WebSite).HasMaxLength(255);
            });

            modelBuilder.Entity<Buyer>(entity =>
            {
                entity.HasKey(e => new { e.Cbuyer, e.ItemCode })
                    .HasName("PK_buyer_1");

                entity.ToTable("buyer");

                entity.Property(e => e.Cbuyer)
                    .HasMaxLength(255)
                    .HasColumnName("cbuyer");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Buyer1)
                    .HasColumnName("buyer")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Chatluong)
                    .HasColumnName("chatluong")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("ten")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimestampColumn)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");
            });

            modelBuilder.Entity<Can>(entity =>
            {
                entity.HasKey(e => new { e.SystemId, e.Macn });

                entity.ToTable("can");

                entity.Property(e => e.SystemId)
                    .HasMaxLength(50)
                    .HasColumnName("systemID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Macn)
                    .HasMaxLength(50)
                    .HasColumnName("macn")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContNo)
                    .HasMaxLength(30)
                    .HasColumnName("cont_no")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.ContNo1)
                    .HasMaxLength(30)
                    .HasColumnName("cont_no1")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.CustAdd)
                    .HasMaxLength(250)
                    .HasColumnName("cust_add")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_code")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.CustName)
                    .HasMaxLength(50)
                    .HasColumnName("cust_name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustPresent)
                    .HasMaxLength(150)
                    .HasColumnName("cust_present")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasColumnName("date_in");

                entity.Property(e => e.DateOut)
                    .HasColumnType("datetime")
                    .HasColumnName("date_out");

                entity.Property(e => e.Dongia)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("dongia")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dongia1)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("dongia1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("dvt")
                    .HasDefaultValueSql("(N'kg')");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HinhThucCan).HasComment("0: can nhap hang - 1: can xuat hang");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("date")
                    .HasColumnName("ngayHD");

                entity.Property(e => e.Payment)
                    .HasMaxLength(50)
                    .HasColumnName("payment")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(50)
                    .HasColumnName("prod_code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(255)
                    .HasColumnName("prod_name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SealNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("seal_no")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SealNo1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("seal_no1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Serial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.SystemRefHd)
                    .HasMaxLength(50)
                    .HasColumnName("SystemRefHD");

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(255)
                    .HasColumnName("taikhoan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Taxcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Tienthue)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tienthue")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeIn)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("time_in")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.TimeOut)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("time_out")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.TlCont)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tl_cont")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TlCont1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tl_cont1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TlDau1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TL_Dau1");

                entity.Property(e => e.TlDau2)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TL_Dau2");

                entity.Property(e => e.TlIn)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TL_in")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TlNet)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tl_net")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TlOut)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tl_out")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tlbao)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("TLBao");

                entity.Property(e => e.Tongtrigia)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tongtrigia")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Trigia)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("trigia")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Trigia1)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("trigia1");

                entity.Property(e => e.Trigiatruocthue)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("trigiatruocthue");

                entity.Property(e => e.TruckNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("truck_no")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Tthai).HasColumnName("tthai");

                entity.Property(e => e.TypeCont).HasColumnName("type_cont");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("vat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VatNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Carrier>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("carrier");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .HasColumnName("code");

                entity.Property(e => e.Ma)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ma");
            });

            modelBuilder.Entity<ChangeDetail>(entity =>
            {
                entity.ToTable("ChangeDetail");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ChangeStock)
                    .WithMany(p => p.ChangeDetails)
                    .HasForeignKey(d => d.ChangeStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangeDetail_ChangeStock");
            });

            modelBuilder.Entity<ChangeStock>(entity =>
            {
                entity.ToTable("ChangeStock");

                entity.Property(e => e.ChangeStockNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EntDate).HasColumnType("date");

                entity.Property(e => e.LenhXuat)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StockCodeSource)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StockCodeTarget)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StockNameSource)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StockNameTarget)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ChiDao>(entity =>
            {
                entity.ToTable("ChiDao");

                entity.Property(e => e.CongViec)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CvhoanThanh)
                    .IsRequired()
                    .HasColumnName("CVHoanThanh");

                entity.Property(e => e.CvthucHien)
                    .IsRequired()
                    .HasColumnName("CVThucHien");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.HanHt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("HanHT");

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaDV");

                entity.Property(e => e.NgayGiao)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VuongMac).IsRequired();
            });

            modelBuilder.Entity<ChiPhiUocTinh>(entity =>
            {
                entity.ToTable("ChiPhiUocTinh");

                entity.Property(e => e.ChiPhi).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaNhom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CoA>(entity =>
            {
                entity.ToTable("co_a");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bags)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bags");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bill_no");

                entity.Property(e => e.Bulk)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("_bulk")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Consignee)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("consignee");

                entity.Property(e => e.Customs)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("customs");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("date");

                entity.Property(e => e.DateIv)
                    .HasColumnType("datetime")
                    .HasColumnName("date_iv");

                entity.Property(e => e.Delivery)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("delivery");

                entity.Property(e => e.Dvt1)
                    .HasMaxLength(15)
                    .HasColumnName("DVT1");

                entity.Property(e => e.Dvt2)
                    .HasMaxLength(15)
                    .HasColumnName("DVT2");

                entity.Property(e => e.Goods)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("goods");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("gw");

                entity.Property(e => e.Hscode)
                    .HasMaxLength(50)
                    .HasColumnName("hscode");

                entity.Property(e => e.ImpCountr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("imp_countr")
                    .IsFixedLength(true);

                entity.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.Issued)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('HOCHIMINH CITY')");

                entity.Property(e => e.Marks)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("marks");

                entity.Property(e => e.Medit).HasColumnName("medit");

                entity.Property(e => e.Ngayco)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ngayco");

                entity.Property(e => e.Nw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("nw");

                entity.Property(e => e.PortLoad1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_load1");

                entity.Property(e => e.PreCarri)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pre_carri");

                entity.Property(e => e.Shiper)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("shiper");

                entity.Property(e => e.TMarks)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("t_marks");

                entity.Property(e => e.ThirdCountry).HasColumnType("text");

                entity.Property(e => e.TimestampColumn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");

                entity.Property(e => e.Trigia)
                    .HasColumnType("numeric(19, 2)")
                    .HasColumnName("trigia");

                entity.Property(e => e.Vessel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vessel");

                entity.Property(e => e.Vn)
                    .HasMaxLength(50)
                    .HasColumnName("vn");

                entity.Property(e => e.Voy1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy1");

                entity.Property(e => e.Voy2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy2");
            });

            modelBuilder.Entity<CoB>(entity =>
            {
                entity.ToTable("co_b");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bags)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bags");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bill_no");

                entity.Property(e => e.Bulk)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("_bulk")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Consignee)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("consignee");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.Customs)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("customs");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("date");

                entity.Property(e => e.DateIv)
                    .HasColumnType("datetime")
                    .HasColumnName("date_iv");

                entity.Property(e => e.DateVn)
                    .HasColumnType("datetime")
                    .HasColumnName("date_vn");

                entity.Property(e => e.Delivery)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("delivery");

                entity.Property(e => e.Dvt1)
                    .HasMaxLength(15)
                    .HasColumnName("DVT1");

                entity.Property(e => e.Dvt2)
                    .HasMaxLength(15)
                    .HasColumnName("DVT2");

                entity.Property(e => e.Goods)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("goods");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("gw");

                entity.Property(e => e.Hscode)
                    .HasMaxLength(50)
                    .HasColumnName("hscode");

                entity.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.Issued)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('HOCHIMINH CITY')");

                entity.Property(e => e.Marks)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("marks");

                entity.Property(e => e.Medit).HasColumnName("medit");

                entity.Property(e => e.Nw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("nw");

                entity.Property(e => e.PortLoad1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_load1");

                entity.Property(e => e.PreCarri)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pre_carri");

                entity.Property(e => e.Shiper)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("shiper");

                entity.Property(e => e.TMarks)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("t_marks");

                entity.Property(e => e.ThirdCountry).HasColumnType("text");

                entity.Property(e => e.TimestampColumn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");

                entity.Property(e => e.Trigia)
                    .HasColumnType("numeric(19, 2)")
                    .HasColumnName("trigia");

                entity.Property(e => e.VcciDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vcci_date");

                entity.Property(e => e.Vessel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vessel");

                entity.Property(e => e.Vn)
                    .HasMaxLength(50)
                    .HasColumnName("vn");

                entity.Property(e => e.Voy1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy1");

                entity.Property(e => e.Voy2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy2");
            });

            modelBuilder.Entity<CoD>(entity =>
            {
                entity.ToTable("co_d");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bags)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bags");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bill_no");

                entity.Property(e => e.Bulk)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("_bulk")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Consignee)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("consignee");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("date");

                entity.Property(e => e.DateIv)
                    .HasColumnType("datetime")
                    .HasColumnName("date_iv");

                entity.Property(e => e.Delivery)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("delivery");

                entity.Property(e => e.Dvt1)
                    .HasMaxLength(15)
                    .HasColumnName("DVT1");

                entity.Property(e => e.Dvt2)
                    .HasMaxLength(15)
                    .HasColumnName("DVT2");

                entity.Property(e => e.Goods)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("goods");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("gw");

                entity.Property(e => e.Hscode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("hscode");

                entity.Property(e => e.ImpCountr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("imp_countr");

                entity.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.Issued)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('HOCHIMINH CITY')");

                entity.Property(e => e.Marks)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("marks");

                entity.Property(e => e.Medit).HasColumnName("medit");

                entity.Property(e => e.Nw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("nw");

                entity.Property(e => e.PortDisch)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_disch");

                entity.Property(e => e.PortLoad1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_load1");

                entity.Property(e => e.PreCarri)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pre_carri");

                entity.Property(e => e.Shiper)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("shiper");

                entity.Property(e => e.TMarks)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("t_marks");

                entity.Property(e => e.ThirdCountry).HasColumnType("text");

                entity.Property(e => e.TimestampColumn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");

                entity.Property(e => e.Trigia)
                    .HasColumnType("numeric(19, 2)")
                    .HasColumnName("trigia");

                entity.Property(e => e.VcciDate)
                    .HasMaxLength(50)
                    .HasColumnName("vcci_date");

                entity.Property(e => e.Vessel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vessel");

                entity.Property(e => e.Vn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vn");

                entity.Property(e => e.Voy1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy1");

                entity.Property(e => e.Voy2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy2");
            });

            modelBuilder.Entity<CoE>(entity =>
            {
                entity.ToTable("co_e");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bags)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bags");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bill_no");

                entity.Property(e => e.Bulk)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("_bulk")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Consignee)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("consignee");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("date");

                entity.Property(e => e.DateIv)
                    .HasColumnType("datetime")
                    .HasColumnName("date_iv");

                entity.Property(e => e.Delivery)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("delivery");

                entity.Property(e => e.Dvt1)
                    .HasMaxLength(15)
                    .HasColumnName("DVT1");

                entity.Property(e => e.Dvt2)
                    .HasMaxLength(15)
                    .HasColumnName("DVT2");

                entity.Property(e => e.Goods)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("goods");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("gw");

                entity.Property(e => e.Hscode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("hscode");

                entity.Property(e => e.ImpCountr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("imp_countr");

                entity.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.Issued)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('HOCHIMINH CITY')");

                entity.Property(e => e.Marks)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("marks");

                entity.Property(e => e.Medit).HasColumnName("medit");

                entity.Property(e => e.Nw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("nw");

                entity.Property(e => e.PortDisch)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_disch");

                entity.Property(e => e.PortLoad1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_load1");

                entity.Property(e => e.PreCarri)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pre_carri");

                entity.Property(e => e.Shiper)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("shiper");

                entity.Property(e => e.TMarks)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("t_marks");

                entity.Property(e => e.ThirdCountry).HasColumnType("text");

                entity.Property(e => e.TimestampColumn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");

                entity.Property(e => e.Trigia)
                    .HasColumnType("numeric(19, 2)")
                    .HasColumnName("trigia");

                entity.Property(e => e.Vessel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vessel");

                entity.Property(e => e.Vn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vn");

                entity.Property(e => e.Voy1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy1");

                entity.Property(e => e.Voy2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy2");
            });

            modelBuilder.Entity<CoX>(entity =>
            {
                entity.ToTable("co_x");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bags)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bags");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bill_no")
                    .IsFixedLength(true);

                entity.Property(e => e.Bulk)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("_bulk")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeIm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("code_im");

                entity.Property(e => e.CodeNoti)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("code_noti");

                entity.Property(e => e.CodeTau)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("code_tau");

                entity.Property(e => e.CodeTsm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("code_tsm");

                entity.Property(e => e.Customs)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("customs");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("date");

                entity.Property(e => e.DateVn)
                    .HasColumnType("datetime")
                    .HasColumnName("date_vn");

                entity.Property(e => e.Delivery)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("delivery");

                entity.Property(e => e.Dvt1)
                    .HasMaxLength(15)
                    .HasColumnName("DVT1");

                entity.Property(e => e.Dvt2)
                    .HasMaxLength(15)
                    .HasColumnName("DVT2");

                entity.Property(e => e.Goods)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("goods");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("gw");

                entity.Property(e => e.Hscode)
                    .HasMaxLength(50)
                    .HasColumnName("hscode");

                entity.Property(e => e.IcoNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ico_num");

                entity.Property(e => e.ImpCountr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("imp_countr");

                entity.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Issued)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('HOCHIMINH CITY')");

                entity.Property(e => e.Marks)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("marks");

                entity.Property(e => e.Medit).HasColumnName("medit");

                entity.Property(e => e.Notify)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("notify");

                entity.Property(e => e.Nw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("nw");

                entity.Property(e => e.PortDish)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_dish");

                entity.Property(e => e.PortLoad1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_load1");

                entity.Property(e => e.PortLoad2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_load2");

                entity.Property(e => e.PreCarri)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pre_carri");

                entity.Property(e => e.Shiper)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("shiper");

                entity.Property(e => e.TMarks)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("t_marks");

                entity.Property(e => e.ThirdCountry).HasColumnType("text");

                entity.Property(e => e.TimestampColumn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");

                entity.Property(e => e.Trigia)
                    .HasColumnType("numeric(19, 2)")
                    .HasColumnName("trigia");

                entity.Property(e => e.TsmCoun)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tsm_coun");

                entity.Property(e => e.VcciDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vcci_date");

                entity.Property(e => e.Vessel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vessel");

                entity.Property(e => e.Vn)
                    .HasMaxLength(50)
                    .HasColumnName("vn");

                entity.Property(e => e.Voy1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy1");

                entity.Property(e => e.Voy2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy2");
            });

            modelBuilder.Entity<ComputerLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComputerLog");

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("computerName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("loginTime");

                entity.Property(e => e.LogoutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("logoutTime");

                entity.Property(e => e.MacAdd)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("macAdd")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ComputerRigister>(entity =>
            {
                entity.HasKey(e => e.MacAdd);

                entity.ToTable("ComputerRigister");

                entity.Property(e => e.MacAdd).HasMaxLength(255);

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConfigReport>(entity =>
            {
                entity.ToTable("ConfigReport");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DocName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ContSea>(entity =>
            {
                entity.ToTable("cont_sea");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bags)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("bags");

                entity.Property(e => e.Bulk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bulk_");

                entity.Property(e => e.ContNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("cont_no");

                entity.Property(e => e.Customs)
                    .IsRequired()
                    .HasColumnName("customs");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("gw");

                entity.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nw)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("nw");

                entity.Property(e => e.PackedBy).HasMaxLength(50);

                entity.Property(e => e.SealNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("seal_no");

                entity.Property(e => e.Tear)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("tear");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ContentExportWord>(entity =>
            {
                entity.ToTable("ContentExportWord");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Alignment)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Left; 2: center; 3: right; 4: Justify");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FontSize).HasDefaultValueSql("((13))");

                entity.Property(e => e.Indexs)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Default - 2: Điều 2 - 3: Điều 3 - 4: Điều 4 - 5: Điều 5 - 6: Footer");

                entity.Property(e => e.ListVariable)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReportType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Phụ kiện - 2: Hợp đồng - 3: Invoice");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Country");

                entity.Property(e => e.CodeQg)
                    .HasMaxLength(50)
                    .HasColumnName("Code_QG");

                entity.Property(e => e.MaQg)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_QG");

                entity.Property(e => e.TenQg)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_QG");
            });

            modelBuilder.Entity<CtFixgium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ct_fixgia");

                entity.Property(e => e.Diff)
                    .HasColumnType("numeric(15, 2)")
                    .HasColumnName("diff");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(10)
                    .HasColumnName("dvt")
                    .IsFixedLength(true);

                entity.Property(e => e.Giacuoi)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giacuoi");

                entity.Property(e => e.Giafix)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giafix");

                entity.Property(e => e.Gianam)
                    .HasMaxLength(10)
                    .HasColumnName("gianam")
                    .IsFixedLength(true);

                entity.Property(e => e.Giathang)
                    .HasMaxLength(10)
                    .HasColumnName("giathang")
                    .IsFixedLength(true);

                entity.Property(e => e.Giatt)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giatt");

                entity.Property(e => e.Idrow)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Idrowdetail)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.IsFix)
                    .HasColumnName("isFix")
                    .HasComment("0- Chua fix, 1-Da fix");

                entity.Property(e => e.IsrateEx)
                    .IsRequired()
                    .HasColumnName("Israte_ex")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Macn)
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.Mahang)
                    .HasMaxLength(50)
                    .HasColumnName("mahang");

                entity.Property(e => e.Ngayfix)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayfix");

                entity.Property(e => e.Sig)
                    .HasMaxLength(10)
                    .HasColumnName("sig")
                    .IsFixedLength(true);

                entity.Property(e => e.Solot).HasColumnName("solot");

                entity.Property(e => e.Soluong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasComment("0-Huy, 1-Su dung");

                entity.Property(e => e.Systemref)
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.Tigia)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("tigia")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Trongluong)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("trongluong");

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("vat");
            });

            modelBuilder.Entity<CtHdmb>(entity =>
            {
                entity.HasKey(e => e.IdRow);

                entity.ToTable("ct_hdmb");

                entity.Property(e => e.IdRow)
                    .HasMaxLength(50)
                    .HasColumnName("idRow");

                entity.Property(e => e.ChiPhi).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Diff)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("diff");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dvt");

                entity.Property(e => e.DvtTheoHd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dvtTheoHD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FNgayfix)
                    .HasColumnType("datetime")
                    .HasColumnName("f_ngayfix");

                entity.Property(e => e.GiaOld)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("gia_old")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaTheoHd)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giaTheoHD");

                entity.Property(e => e.Giact)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giact");

                entity.Property(e => e.Giacuoi)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giacuoi");

                entity.Property(e => e.Gianam)
                    .HasMaxLength(50)
                    .HasColumnName("gianam");

                entity.Property(e => e.Giathang)
                    .HasMaxLength(50)
                    .HasColumnName("giathang");

                entity.Property(e => e.Giathitruong)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("giathitruong");

                entity.Property(e => e.Giatt)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giatt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsrateEx)
                    .IsRequired()
                    .HasColumnName("Israte_ex")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LoaiBao)
                    .HasMaxLength(50)
                    .HasColumnName("loai_bao");

                entity.Property(e => e.LoaiBaoOld)
                    .HasMaxLength(50)
                    .HasColumnName("loai_bao_old")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mahang");

                entity.Property(e => e.MathangOld)
                    .HasMaxLength(50)
                    .HasColumnName("mathang_old")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mucthuong)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("mucthuong");

                entity.Property(e => e.Ngayfix)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayfix");

                entity.Property(e => e.Ref)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ref")
                    .IsFixedLength(true);

                entity.Property(e => e.Sig)
                    .HasMaxLength(50)
                    .HasColumnName("sig");

                entity.Property(e => e.Solot)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("solot");

                entity.Property(e => e.Soluong).HasColumnName("soluong");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasComment("0-Hủy, 1-Sử dụng");

                entity.Property(e => e.Stoploss)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("stoploss");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.Trongluong)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("trongluong");

                entity.Property(e => e.Vat)
                    .HasColumnName("vat")
                    .HasDefaultValueSql("((5))");
            });

            modelBuilder.Entity<CustomerNorm>(entity =>
            {
                entity.HasKey(e => new { e.Makhach, e.Nhomhang, e.Macn });

                entity.ToTable("CustomerNorm");

                entity.Property(e => e.Makhach)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhomhang)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Macn)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChucvuNguoigd)
                    .HasMaxLength(100)
                    .HasColumnName("Chucvu_nguoigd");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.GdBan).HasColumnName("GD_Ban");

                entity.Property(e => e.GdMua).HasColumnName("GD_Mua");

                entity.Property(e => e.Ghichu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NguoiGd)
                    .HasMaxLength(100)
                    .HasColumnName("Nguoi_GD");

                entity.Property(e => e.UserCreate).HasMaxLength(50);

                entity.Property(e => e.UserModify).HasMaxLength(50);

                entity.Property(e => e.ValueDmgh)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Value_DMGH");

                entity.Property(e => e.ValueNorm)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Value_norm");
            });

            modelBuilder.Entity<DaiLy>(entity =>
            {
                entity.ToTable("DaiLy");

                entity.Property(e => e.DaiLyFullName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DaiLyName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DienThoai)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.GiayPhep)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Loai).HasComment("0: DaiLy; 1: NhomTruong");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mst)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("MST");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DangKy4C>(entity =>
            {
                entity.HasKey(e => e.MaSo);

                entity.ToTable("DangKy4C");

                entity.Property(e => e.MaSo).HasMaxLength(50);

                entity.Property(e => e.Cmnd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CMND");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DienThoai)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DienTich).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Ghichu)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.NgayDangKy).HasColumnType("date");

                entity.Property(e => e.NgayNhap).HasColumnType("date");

                entity.Property(e => e.SanLuong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TenChuHo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DanhGium>(entity =>
            {
                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaDV");

                entity.Property(e => e.NoiDung).IsRequired();

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LdDepartment)
                    .HasMaxLength(50)
                    .HasColumnName("LD_Department");

                entity.Property(e => e.SttNs).HasColumnName("STT_NS");
            });

            modelBuilder.Entity<DieuKhoanCl>(entity =>
            {
                entity.HasKey(e => new { e.Idunit, e.Iddk, e.RquiCach });

                entity.ToTable("DieuKhoanCL");

                entity.Property(e => e.Idunit)
                    .HasMaxLength(50)
                    .HasColumnName("IDUnit");

                entity.Property(e => e.Iddk)
                    .HasMaxLength(50)
                    .HasColumnName("IDDK");

                entity.Property(e => e.RquiCach).HasColumnName("RQuiCach");

                entity.Property(e => e.ChatLuongHd)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("ChatLuongHD");

                entity.Property(e => e.ColKcs)
                    .HasMaxLength(50)
                    .HasColumnName("colKCS");

                entity.Property(e => e.DenNgay).HasColumnType("date");

                entity.Property(e => e.Dkchuan).HasColumnName("DKChuan");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.MaHd)
                    .HasMaxLength(50)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(50)
                    .HasColumnName("MaKH");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(50)
                    .HasColumnName("MaMH");

                entity.Property(e => e.NgayNsd)
                    .HasColumnType("date")
                    .HasColumnName("NgayNSD");

                entity.Property(e => e.NgaySua).HasColumnType("date");

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.NguoiSua).HasMaxLength(50);

                entity.Property(e => e.NguoiTao).HasMaxLength(50);

                entity.Property(e => e.NhomHang).HasMaxLength(50);

                entity.Property(e => e.QuiCach).HasMaxLength(255);

                entity.Property(e => e.TenKh)
                    .HasMaxLength(255)
                    .HasColumnName("TenKH");

                entity.Property(e => e.TenMh)
                    .HasMaxLength(255)
                    .HasColumnName("TenMH");

                entity.Property(e => e.ToiDa).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TuNgay).HasColumnType("date");
            });

            modelBuilder.Entity<DieuKhoanCl1>(entity =>
            {
                entity.ToTable("DieuKhoanCL_");

                entity.Property(e => e.ChatLuongHd)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("ChatLuongHD");

                entity.Property(e => e.ColKcs)
                    .HasMaxLength(50)
                    .HasColumnName("colKCS");

                entity.Property(e => e.DenNgay).HasColumnType("date");

                entity.Property(e => e.Dkchuan).HasColumnName("DKChuan");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.Iddk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IDDK");

                entity.Property(e => e.Idunit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IDUnit");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(50)
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(50)
                    .HasColumnName("MaKH");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(50)
                    .HasColumnName("MaMH");

                entity.Property(e => e.NgayNsd)
                    .HasColumnType("date")
                    .HasColumnName("NgayNSD");

                entity.Property(e => e.NgaySua).HasColumnType("date");

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.NguoiSua).HasMaxLength(50);

                entity.Property(e => e.NguoiTao).HasMaxLength(50);

                entity.Property(e => e.NhomHang).HasMaxLength(50);

                entity.Property(e => e.QuiCach).HasMaxLength(255);

                entity.Property(e => e.RquiCach).HasColumnName("RQuiCach");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(255)
                    .HasColumnName("TenKH");

                entity.Property(e => e.TenMh)
                    .HasMaxLength(255)
                    .HasColumnName("TenMH");

                entity.Property(e => e.ToiDa).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TuNgay).HasColumnType("date");
            });

            modelBuilder.Entity<DieuKhoanCl11>(entity =>
            {
                entity.HasKey(e => new { e.Idunit, e.Iddk, e.RquiCach, e.Iddong })
                    .HasName("PK_DieuKhoanCL1_1");

                entity.ToTable("DieuKhoanCL1");

                entity.Property(e => e.Idunit)
                    .HasMaxLength(50)
                    .HasColumnName("IDUnit");

                entity.Property(e => e.Iddk)
                    .HasMaxLength(50)
                    .HasColumnName("IDDK");

                entity.Property(e => e.RquiCach).HasColumnName("RQuiCach");

                entity.Property(e => e.Iddong).HasColumnName("IDDong");

                entity.Property(e => e.DenGt)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("DenGT");

                entity.Property(e => e.TrenKett).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TruVuot).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TuGt)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("TuGT");
            });

            modelBuilder.Entity<DieuKhoanCl12>(entity =>
            {
                entity.ToTable("DieuKhoanCL1_");

                entity.Property(e => e.DenGt)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("DenGT");

                entity.Property(e => e.Iddk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IDDK");

                entity.Property(e => e.Iddong).HasColumnName("IDDong");

                entity.Property(e => e.Idunit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IDUnit");

                entity.Property(e => e.RquiCach).HasColumnName("RQuiCach");

                entity.Property(e => e.TrenKett).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TruVuot).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.TuGt)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("TuGT");
            });

            modelBuilder.Entity<DkctHdmb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dkct_hdmb");

                entity.Property(e => e.Diff)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("diff");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dvt");

                entity.Property(e => e.DvtTheoHd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dvtTheoHD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FNgayfix)
                    .HasColumnType("datetime")
                    .HasColumnName("f_ngayfix");

                entity.Property(e => e.GiaTheoHd)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giaTheoHD");

                entity.Property(e => e.Giact)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giact");

                entity.Property(e => e.Giacuoi)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giacuoi");

                entity.Property(e => e.Gianam)
                    .HasMaxLength(50)
                    .HasColumnName("gianam");

                entity.Property(e => e.Giathang)
                    .HasMaxLength(50)
                    .HasColumnName("giathang");

                entity.Property(e => e.Giatt)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giatt");

                entity.Property(e => e.IdRow)
                    .HasMaxLength(10)
                    .HasColumnName("idRow")
                    .IsFixedLength(true);

                entity.Property(e => e.Mahang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mahang");

                entity.Property(e => e.Ngayfix)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayfix");

                entity.Property(e => e.Ref)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ref")
                    .IsFixedLength(true);

                entity.Property(e => e.Sig)
                    .HasMaxLength(50)
                    .HasColumnName("sig");

                entity.Property(e => e.Solot)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("solot");

                entity.Property(e => e.Soluong).HasColumnName("soluong");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Stoploss)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("stoploss");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.Trongluong)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("trongluong");

                entity.Property(e => e.Trongluongdagiao)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("trongluongdagiao");

                entity.Property(e => e.Vat)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("vat")
                    .HasDefaultValueSql("((5))");
            });

            modelBuilder.Entity<Dkfixgium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClientKy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("client_ky")
                    .IsFixedLength(true);

                entity.Property(e => e.Diff)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("diff");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("dvt");

                entity.Property(e => e.FNgayfix)
                    .HasColumnType("datetime")
                    .HasColumnName("f_ngayfix");

                entity.Property(e => e.Ghichu).HasColumnName("ghichu");

                entity.Property(e => e.Giact)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giact");

                entity.Property(e => e.Giacuoi)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giacuoi");

                entity.Property(e => e.Giafix)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("giafix");

                entity.Property(e => e.Gianam)
                    .HasMaxLength(50)
                    .HasColumnName("gianam");

                entity.Property(e => e.Giathang)
                    .HasMaxLength(50)
                    .HasColumnName("giathang");

                entity.Property(e => e.Giatt)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("giatt");

                entity.Property(e => e.IdRow)
                    .HasMaxLength(10)
                    .HasColumnName("idRow")
                    .IsFixedLength(true);

                entity.Property(e => e.IntKy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("int_ky")
                    .IsFixedLength(true);

                entity.Property(e => e.Isfix).HasColumnName("isfix");

                entity.Property(e => e.IsrateEx)
                    .IsRequired()
                    .HasColumnName("Israte_ex")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaKhach)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_khach");

                entity.Property(e => e.Macn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("macn")
                    .IsFixedLength(true);

                entity.Property(e => e.Mahang)
                    .HasMaxLength(50)
                    .HasColumnName("mahang");

                entity.Property(e => e.MuaBan)
                    .HasMaxLength(10)
                    .HasColumnName("mua_ban")
                    .IsFixedLength(true);

                entity.Property(e => e.Ngayfix)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayfix");

                entity.Property(e => e.Ngaygiao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaygiao");

                entity.Property(e => e.Ngayky)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayky");

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .HasColumnName("ref");

                entity.Property(e => e.Sig)
                    .HasMaxLength(50)
                    .HasColumnName("sig");

                entity.Property(e => e.Slgiao)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("slgiao");

                entity.Property(e => e.Sohd)
                    .HasMaxLength(50)
                    .HasColumnName("sohd");

                entity.Property(e => e.Solot).HasColumnName("solot");

                entity.Property(e => e.Solotfix).HasColumnName("solotfix");

                entity.Property(e => e.Soluong)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("soluong");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Stoploss).HasColumnName("stoploss");

                entity.Property(e => e.Systemref)
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.Tiente)
                    .HasMaxLength(10)
                    .HasColumnName("tiente")
                    .IsFixedLength(true);

                entity.Property(e => e.Trongluong)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("trongluong");

                entity.Property(e => e.Vat).HasColumnName("vat");
            });

            modelBuilder.Entity<Dkhdmb>(entity =>
            {
                entity.HasKey(e => e.Systemref);

                entity.ToTable("dkhdmb");

                entity.Property(e => e.Systemref)
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.ClientKy)
                    .HasMaxLength(50)
                    .HasColumnName("client_ky");

                entity.Property(e => e.Docstatus).HasComment("trạng thái");

                entity.Property(e => e.Ghichu).HasColumnName("ghichu");

                entity.Property(e => e.IntKy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("int_ky")
                    .IsFixedLength(true);

                entity.Property(e => e.IsFix).HasColumnName("isFix");

                entity.Property(e => e.Macn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("macn")
                    .IsFixedLength(true);

                entity.Property(e => e.Makhach)
                    .HasMaxLength(50)
                    .HasColumnName("makhach");

                entity.Property(e => e.MuaBan)
                    .HasMaxLength(50)
                    .HasColumnName("mua_ban")
                    .HasComment("MUA: hợp đồng mua;  BAN: hợp đồng bán");

                entity.Property(e => e.NgayTraPhaitra)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayTra_Phaitra");

                entity.Property(e => e.Ngaygiao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaygiao");

                entity.Property(e => e.Ngayhl)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayhl");

                entity.Property(e => e.Ngayky)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayky");

                entity.Property(e => e.Ngaylam)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaylam");

                entity.Property(e => e.Ngaytl)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaytl");

                entity.Property(e => e.Nguoilam)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nguoilam")
                    .IsFixedLength(true);

                entity.Property(e => e.Nguoitl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nguoitl")
                    .IsFixedLength(true);

                entity.Property(e => e.Pakd).HasColumnName("PAKD");

                entity.Property(e => e.Ref)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ref")
                    .IsFixedLength(true);

                entity.Property(e => e.SoPakd)
                    .HasMaxLength(10)
                    .HasColumnName("soPAKD")
                    .IsFixedLength(true);

                entity.Property(e => e.Sohd)
                    .HasMaxLength(50)
                    .HasColumnName("sohd");

                entity.Property(e => e.Thanhtoan)
                    .HasMaxLength(10)
                    .HasColumnName("thanhtoan")
                    .IsFixedLength(true);

                entity.Property(e => e.Tiente)
                    .HasMaxLength(10)
                    .HasColumnName("tiente")
                    .IsFixedLength(true);

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("trangthai")
                    .IsFixedLength(true)
                    .HasComment("1: mới, 2: hủy, 0: thanh lý");

                entity.Property(e => e.TrangthaiGhep)
                    .IsRequired()
                    .HasColumnName("trangthaiGhep")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0: không cho ghép - 1: còn có thể cho ghép");
            });

            modelBuilder.Entity<Dmkh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMKH");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_chi");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("Dien_Thoai");

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .HasColumnName("FAX");

                entity.Property(e => e.GiaoDichBan)
                    .HasMaxLength(255)
                    .HasColumnName("Giao_Dich_Ban");

                entity.Property(e => e.GiaoDichMua)
                    .HasMaxLength(255)
                    .HasColumnName("Giao_dich_mua");

                entity.Property(e => e.GiayPhep)
                    .HasMaxLength(255)
                    .HasColumnName("Giay_Phep");

                entity.Property(e => e.Idkhach)
                    .HasMaxLength(255)
                    .HasColumnName("IDKHACH");

                entity.Property(e => e.LoaiKhach)
                    .HasMaxLength(255)
                    .HasColumnName("Loai_Khach");

                entity.Property(e => e.MaKhach)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Khach");

                entity.Property(e => e.MaKhuvuc)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Ma_khuvuc")
                    .IsFixedLength(true);

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_So_Thue");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Cap");

                entity.Property(e => e.TenFull)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_Full");

                entity.Property(e => e.TenKhach)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_khach");

                entity.Property(e => e.TenQg)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_QG");
            });

            modelBuilder.Entity<Dmtte>(entity =>
            {
                entity.ToTable("DMTTE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaTte)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaTTE")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayAd)
                    .HasColumnType("date")
                    .HasColumnName("NgayAD");

                entity.Property(e => e.Tyle).HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Tyle1).HasColumnType("numeric(15, 3)");

                entity.Property(e => e.Tyle2).HasColumnType("numeric(15, 3)");
            });

            modelBuilder.Entity<DoanhThu>(entity =>
            {
                entity.ToTable("DoanhThu");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.HangHoa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LoaiHinh)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaDV");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhomHang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TienTe)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('VND')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type).HasComment("0: BC tuần, 1: BC tháng");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DocFeedBack>(entity =>
            {
                entity.ToTable("DocFeedBack");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateLimit).HasColumnType("date");

                entity.Property(e => e.Idea).IsRequired();

                entity.Property(e => e.UserReceive)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserSend)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DocFileAttach>(entity =>
            {
                entity.ToTable("DocFileAttach");

                entity.Property(e => e.FileAttach)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileSource)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DocPlace>(entity =>
            {
                entity.ToTable("DocPlace");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DocPlaceCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocPlaceName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DocProcess>(entity =>
            {
                entity.ToTable("DocProcess");

                entity.Property(e => e.Command).IsRequired();

                entity.Property(e => e.DateLimit).HasColumnType("date");

                entity.Property(e => e.DateProcess)
                    .HasColumnType("datetime")
                    .HasComment("Ngày chuyển CV");

                entity.Property(e => e.DateReceive).HasColumnType("date");

                entity.Property(e => e.NoteProcessReady)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObjectProcess)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Đối tượng nhận công văn");

                entity.Property(e => e.StatusProcess).HasComment("1: CV chưa xem; 2: CV đã xem");

                entity.Property(e => e.UserSend)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DocProcessWaste>(entity =>
            {
                entity.ToTable("DocProcessWaste");

                entity.Property(e => e.DocId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessWasteNumber)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DocStyle>(entity =>
            {
                entity.ToTable("DocStyle");

                entity.Property(e => e.DocStyleId).ValueGeneratedNever();

                entity.Property(e => e.StyleCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StyleName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DocType>(entity =>
            {
                entity.ToTable("DocType");

                entity.Property(e => e.TypeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.DocId);

                entity.ToTable("Document");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateCome)
                    .HasColumnType("datetime")
                    .HasComment("Ngày CV đến");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DocDate)
                    .HasColumnType("date")
                    .HasComment("Ngày của CV");

                entity.Property(e => e.DocLever).HasComment("0: CV bình thường; 1: CV khẩn");

                entity.Property(e => e.DocPlaceId).HasComment("Nơi gửi CV đến");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NumberCome)
                    .HasMaxLength(50)
                    .HasComment("Số CV đến");

                entity.Property(e => e.NumberSign)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Số hiệu CV");

                entity.Property(e => e.Singer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DonviTv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Donvi_TV");

                entity.Property(e => e.BacQc)
                    .HasMaxLength(255)
                    .HasColumnName("Bac_QC");

                entity.Property(e => e.ChucDanh)
                    .HasMaxLength(255)
                    .HasColumnName("Chuc_danh");

                entity.Property(e => e.ChuyenNganh).HasMaxLength(255);

                entity.Property(e => e.CongviecChinh).HasColumnName("Congviec_Chinh");

                entity.Property(e => e.DiachiTamtru)
                    .HasMaxLength(255)
                    .HasColumnName("Diachi_Tamtru");

                entity.Property(e => e.DiachiThuongtru)
                    .HasMaxLength(255)
                    .HasColumnName("Diachi_Thuongtru");

                entity.Property(e => e.Donvi).HasMaxLength(255);

                entity.Property(e => e.DtDd)
                    .HasMaxLength(255)
                    .HasColumnName("DT_DD");

                entity.Property(e => e.F12).HasMaxLength(255);

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.GhiChu1)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu1");

                entity.Property(e => e.Gioitinh).HasMaxLength(255);

                entity.Property(e => e.HeDd)
                    .HasMaxLength(255)
                    .HasColumnName("He_DD");

                entity.Property(e => e.Hovaten).HasMaxLength(255);

                entity.Property(e => e.Hsl205).HasColumnName("HSL_205");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");

                entity.Property(e => e.Ld)
                    .HasMaxLength(255)
                    .HasColumnName("LD");

                entity.Property(e => e.LoaiHd)
                    .HasMaxLength(255)
                    .HasColumnName("Loai_Hd");

                entity.Property(e => e.LuongKhoan)
                    .HasMaxLength(255)
                    .HasColumnName("Luong_Khoan");

                entity.Property(e => e.LuongQc).HasColumnName("Luong_QC");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaCbnv)
                    .HasMaxLength(255)
                    .HasColumnName("MA_CBNV");

                entity.Property(e => e.MaChucvu)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Chucvu");

                entity.Property(e => e.Ngach205)
                    .HasMaxLength(255)
                    .HasColumnName("Ngach_205");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayBd1)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_Bd1");

                entity.Property(e => e.NgayBd2)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_Bd2");

                entity.Property(e => e.NgayCap)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_cap");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Kt");

                entity.Property(e => e.NgayKt1)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_Kt1");

                entity.Property(e => e.NgayKt2)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_Kt2");

                entity.Property(e => e.NgayVao)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_vao");

                entity.Property(e => e.Ngaysinh).HasColumnType("datetime");

                entity.Property(e => e.Nguyenquan).HasMaxLength(255);

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap");

                entity.Property(e => e.Noisinh).HasMaxLength(255);

                entity.Property(e => e.PcTn).HasColumnName("PC_TN");

                entity.Property(e => e.SoBhxh).HasColumnName("So_BHXH");

                entity.Property(e => e.SoBhyt).HasColumnName("So_BHYT");

                entity.Property(e => e.SoCmnd).HasColumnName("So_CMND");

                entity.Property(e => e.TdCm)
                    .HasMaxLength(255)
                    .HasColumnName("TD_CM");

                entity.Property(e => e.TdNn)
                    .HasMaxLength(255)
                    .HasColumnName("TD_NN");

                entity.Property(e => e.TdTh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_TH");

                entity.Property(e => e.TdVh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_VH");

                entity.Property(e => e.TenBp)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_Bp");

                entity.Property(e => e.TruongDt)
                    .HasMaxLength(255)
                    .HasColumnName("Truong_DT");
            });

            modelBuilder.Entity<DonviTv1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Donvi_TV$");

                entity.Property(e => e.BacQc)
                    .HasMaxLength(255)
                    .HasColumnName("Bac_QC");

                entity.Property(e => e.BenhVien).HasMaxLength(255);

                entity.Property(e => e.ChucDanh)
                    .HasMaxLength(255)
                    .HasColumnName("Chuc_danh");

                entity.Property(e => e.CongviecChinh).HasColumnName("Congviec_Chinh");

                entity.Property(e => e.DiachiTamtru)
                    .HasMaxLength(255)
                    .HasColumnName("Diachi_Tamtru");

                entity.Property(e => e.DiachiThuongtru)
                    .HasMaxLength(255)
                    .HasColumnName("Diachi_Thuongtru");

                entity.Property(e => e.Donvi).HasMaxLength(255);

                entity.Property(e => e.DtDd)
                    .HasMaxLength(255)
                    .HasColumnName("DT_DD");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.GhiChu1)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu1");

                entity.Property(e => e.Gioitinh).HasMaxLength(255);

                entity.Property(e => e.HeDd)
                    .HasMaxLength(255)
                    .HasColumnName("He_DD");

                entity.Property(e => e.Hovaten).HasMaxLength(255);

                entity.Property(e => e.Hsl205).HasColumnName("HSL_205");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");

                entity.Property(e => e.Ld)
                    .HasMaxLength(255)
                    .HasColumnName("LD");

                entity.Property(e => e.LoaiHd)
                    .HasMaxLength(255)
                    .HasColumnName("Loai_Hd");

                entity.Property(e => e.LuongKhoan)
                    .HasMaxLength(255)
                    .HasColumnName("Luong_Khoan");

                entity.Property(e => e.LuongQc).HasColumnName("Luong_QC");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaCbnv)
                    .HasMaxLength(255)
                    .HasColumnName("MA_CBNV");

                entity.Property(e => e.MaChucvu)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Chucvu");

                entity.Property(e => e.Ngach205)
                    .HasMaxLength(255)
                    .HasColumnName("Ngach_205");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayBd1)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd1");

                entity.Property(e => e.NgayBd2)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd2");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_cap");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Kt");

                entity.Property(e => e.NgayKt1)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Kt1");

                entity.Property(e => e.NgayKt2)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Kt2");

                entity.Property(e => e.NgayVao)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_vao");

                entity.Property(e => e.Ngaysinh).HasColumnType("datetime");

                entity.Property(e => e.Nguyenquan).HasMaxLength(255);

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap");

                entity.Property(e => e.Noisinh).HasMaxLength(255);

                entity.Property(e => e.PcTn).HasColumnName("PC_TN");

                entity.Property(e => e.SoBhxh)
                    .HasMaxLength(255)
                    .HasColumnName("So_BHXH");

                entity.Property(e => e.SoBhyt)
                    .HasMaxLength(255)
                    .HasColumnName("So_BHYT");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(255)
                    .HasColumnName("So_CMND");

                entity.Property(e => e.TdCm)
                    .HasMaxLength(255)
                    .HasColumnName("TD_CM");

                entity.Property(e => e.TdNn)
                    .HasMaxLength(255)
                    .HasColumnName("TD_NN");

                entity.Property(e => e.TdTh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_TH");

                entity.Property(e => e.TdVh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_VH");

                entity.Property(e => e.TenBp)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_Bp");

                entity.Property(e => e.Tinh).HasMaxLength(255);

                entity.Property(e => e.TruongDt)
                    .HasMaxLength(255)
                    .HasColumnName("Truong_DT");
            });

            modelBuilder.Entity<DsPhongn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DS_PHONGNS");

                entity.Property(e => e.ChuyenMon)
                    .HasMaxLength(255)
                    .HasColumnName("Chuyen_Mon");

                entity.Property(e => e.CvChinh)
                    .HasMaxLength(255)
                    .HasColumnName("CV_Chinh");

                entity.Property(e => e.DanToc)
                    .HasMaxLength(255)
                    .HasColumnName("Dan_Toc");

                entity.Property(e => e.DiaChiHt)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_Chi_HT");

                entity.Property(e => e.DiaChiTt)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_Chi_TT");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");

                entity.Property(e => e.HandPhone)
                    .HasMaxLength(255)
                    .HasColumnName("Hand_Phone");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");

                entity.Property(e => e.KhongDvt).HasColumnName("Khong_DVT");

                entity.Property(e => e.LanhDao).HasColumnName("Lanh_Dao");

                entity.Property(e => e.LyDoNghi)
                    .HasMaxLength(255)
                    .HasColumnName("Ly_Do_Nghi");

                entity.Property(e => e.MaAnh)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Anh");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_BP");

                entity.Property(e => e.MaCa)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Ca");

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_ChucVu");

                entity.Property(e => e.MaDv)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Dv");

                entity.Property(e => e.MaMayCc)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_May_CC");

                entity.Property(e => e.MaNsNew)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Ns_New");

                entity.Property(e => e.MaNsOld)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_NS_Old");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_So_Thue");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayCapCmnd)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_Cap_CMND");

                entity.Property(e => e.NgayCapHc)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_Cap_HC");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_KT");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Sinh");

                entity.Property(e => e.NguoiPt).HasColumnName("Nguoi_PT");

                entity.Property(e => e.NguyenQuan)
                    .HasMaxLength(255)
                    .HasColumnName("Nguyen_Quan");

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap");

                entity.Property(e => e.NoiCapHc)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap_HC");

                entity.Property(e => e.NoiSinh)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Sinh");

                entity.Property(e => e.Qt)
                    .HasMaxLength(255)
                    .HasColumnName("QT");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(255)
                    .HasColumnName("So_CMND");

                entity.Property(e => e.SoHc)
                    .HasMaxLength(255)
                    .HasColumnName("So_HC");

                entity.Property(e => e.SoQdNghi)
                    .HasMaxLength(255)
                    .HasColumnName("So_QD_Nghi");

                entity.Property(e => e.SoTkNh)
                    .HasMaxLength(255)
                    .HasColumnName("So_Tk_NH");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TdHv)
                    .HasMaxLength(255)
                    .HasColumnName("TD_HV");

                entity.Property(e => e.TdNn)
                    .HasMaxLength(255)
                    .HasColumnName("TD_NN");

                entity.Property(e => e.TdTh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_TH");

                entity.Property(e => e.TdVh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_VH");

                entity.Property(e => e.TenNh)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_NH");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_NV");

                entity.Property(e => e.TinhTrangHn)
                    .HasMaxLength(255)
                    .HasColumnName("Tinh_Trang_HN");

                entity.Property(e => e.TonGiao)
                    .HasMaxLength(255)
                    .HasColumnName("Ton_Giao");

                entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            });

            modelBuilder.Entity<Edit>(entity =>
            {
                entity.ToTable("Edit");

                entity.Property(e => e.AttDoc).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ObjectId)
                    .HasMaxLength(255)
                    .HasColumnName("objectId");

                entity.Property(e => e.ObjectName).HasMaxLength(255);

                entity.Property(e => e.Press).HasMaxLength(255);

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("reason");
            });

            modelBuilder.Entity<EditReason>(entity =>
            {
                entity.ToTable("Edit_reason");

                entity.Property(e => e.FrmObject)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("frmObject");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("reason");
            });

            modelBuilder.Entity<EdocDatum>(entity =>
            {
                entity.HasKey(e => e.IdEd);

                entity.ToTable("EDoc_data");

                entity.Property(e => e.IdEd)
                    .HasMaxLength(20)
                    .HasColumnName("idEd")
                    .IsFixedLength(true);

                entity.Property(e => e.CheckingBy)
                    .HasMaxLength(10)
                    .HasColumnName("checkingBy")
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocStyle).HasComment("1: Hợp đồng; 2: PAKD; 3: Khách hàng; 4:Công Văn; 5: Nhập xuất HĐ; 6: Fix Giá; 7: Hóa đơn; 8: Bộ chứng từ thanh toán XK");

                entity.Property(e => e.Idreason)
                    .HasMaxLength(10)
                    .HasColumnName("idreason")
                    .IsFixedLength(true);

                entity.Property(e => e.Macn)
                    .HasMaxLength(10)
                    .HasColumnName("macn")
                    .IsFixedLength(true);

                entity.Property(e => e.MessgeIn).HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mucsua)
                    .HasMaxLength(70)
                    .HasColumnName("mucsua");

                entity.Property(e => e.Ngaysua)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaysua");

                entity.Property(e => e.OldValue)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoPa)
                    .HasMaxLength(30)
                    .HasColumnName("soPA")
                    .IsFixedLength(true);

                entity.Property(e => e.Sohd)
                    .HasMaxLength(30)
                    .HasColumnName("sohd")
                    .IsFixedLength(true);

                entity.Property(e => e.Systemref)
                    .HasMaxLength(20)
                    .HasColumnName("systemref")
                    .IsFixedLength(true);

                entity.Property(e => e.TypeDoc)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<EdocDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Edoc_Detail");

                entity.Property(e => e.DocLocation).HasMaxLength(250);

                entity.Property(e => e.DocName).HasMaxLength(50);

                entity.Property(e => e.DocStored).HasColumnType("image");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdEd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("idEd")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee");

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateWorking).HasColumnType("date");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FeedBackFileAttach>(entity =>
            {
                entity.ToTable("FeedBackFileAttach");

                entity.Property(e => e.FileAttach)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileSource)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<FileDatum>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.IdIndex)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("id_Index");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<FileStored>(entity =>
            {
                entity.HasKey(e => e.IdIndex);

                entity.ToTable("FileStored");

                entity.Property(e => e.IdIndex)
                    .HasMaxLength(25)
                    .HasColumnName("ID_INDEX")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateStored)
                    .HasColumnType("datetime")
                    .HasColumnName("dateStored");

                entity.Property(e => e.Department).HasDefaultValueSql("('')");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Realname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TypeOfDoc).HasComment("0- normal document; 1- meeting document, ");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserStored)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("userStored")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WeekOfYear).HasDefaultValueSql("((1))");

                entity.Property(e => e.Year).HasDefaultValueSql("((2013))");
            });

            modelBuilder.Entity<FileTaiLieu>(entity =>
            {
                entity.ToTable("FileTaiLieu");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Ext)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileStore)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasComment("0: File binh thuong; 1: File da xoa");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TaiLieu)
                    .WithMany(p => p.FileTaiLieus)
                    .HasForeignKey(d => d.TaiLieuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FileTaiLieu_TaiLieu");
            });

            modelBuilder.Entity<Fixgium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fixgia");

                entity.Property(e => e.ClientKy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("client_ky")
                    .IsFixedLength(true);

                entity.Property(e => e.Idrow)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntKy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("int_ky")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKhach)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_khach");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("macn")
                    .IsFixedLength(true);

                entity.Property(e => e.MuaBan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("mua_ban")
                    .IsFixedLength(true);

                entity.Property(e => e.Ngaynhap)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaynhap");

                entity.Property(e => e.Nhanvien)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nhanvien")
                    .IsFixedLength(true);

                entity.Property(e => e.Ref)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ref")
                    .IsFixedLength(true);

                entity.Property(e => e.Sohd)
                    .HasMaxLength(50)
                    .HasColumnName("sohd");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.TenKhach)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Khach");

                entity.Property(e => e.Tiente)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<GiaoNhan>(entity =>
            {
                entity.ToTable("GiaoNhan");

                entity.Property(e => e.ChongAm)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.GiamDinh)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("GW");

                entity.Property(e => e.KhuTrung)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.KiemDich)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Marka)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NgayGiao).HasColumnType("date");

                entity.Property(e => e.NumPacked).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nw)
                    .HasColumnType("decimal(18, 5)")
                    .HasColumnName("NW");

                entity.Property(e => e.NơiGiao)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PackedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoCont)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SoHd)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SoSeal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tear).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TenThuoc)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GroupBranch>(entity =>
            {
                entity.ToTable("GroupBranch");

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MatHang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nhom)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GroupRight>(entity =>
            {
                entity.ToTable("GroupRight");

                entity.Property(e => e.DesCription1).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MenuId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HangHoaCanGiaiQuyet>(entity =>
            {
                entity.ToTable("HangHoaCanGiaiQuyet");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NoiDung).IsRequired();

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Hanghoa>(entity =>
            {
                entity.HasKey(e => e.Mahang)
                    .HasName("PK_hanghoa_1");

                entity.ToTable("hanghoa");

                entity.Property(e => e.Mahang)
                    .HasMaxLength(50)
                    .HasColumnName("mahang");

                entity.Property(e => e.Baobi)
                    .HasColumnType("ntext")
                    .HasColumnName("baobi");

                entity.Property(e => e.DoAm)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Do_Am");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("dvt");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(255)
                    .HasColumnName("fullname");

                entity.Property(e => e.HatDen)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Hat_Den");

                entity.Property(e => e.HatVo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Hat_Vo");

                entity.Property(e => e.Idhanghoa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IDhanghoa")
                    .IsFixedLength(true);

                entity.Property(e => e.Kiemdinh)
                    .HasColumnType("ntext")
                    .HasColumnName("kiemdinh");

                entity.Property(e => e.MaNhom).HasMaxLength(50);

                entity.Property(e => e.OrderNhom).HasColumnName("Order_Nhom");

                entity.Property(e => e.Quicach)
                    .HasColumnType("ntext")
                    .HasColumnName("quicach");

                entity.Property(e => e.Sudung).HasColumnName("sudung");

                entity.Property(e => e.TapChat)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Tap_Chat");

                entity.Property(e => e.Tenhang)
                    .HasMaxLength(255)
                    .HasColumnName("tenhang");

                entity.Property(e => e.Tenhangvat)
                    .HasMaxLength(255)
                    .HasColumnName("tenhangvat");

                entity.Property(e => e.Vat).HasColumnName("vat");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<Hdmb>(entity =>
            {
                entity.HasKey(e => e.Systemref);

                entity.ToTable("hdmb");

                entity.Property(e => e.Systemref)
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.ClientKy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("client_ky")
                    .IsFixedLength(true);

                entity.Property(e => e.DiaDiemGiaoHang)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Docstatus).HasComment("trạng thái");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(250)
                    .HasColumnName("ghichu");

                entity.Property(e => e.HdcmuonId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("HDCMuonId")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IntKy)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("int_ky")
                    .IsFixedLength(true);

                entity.Property(e => e.IsFix)
                    .HasColumnName("isFix")
                    .HasComment("Gia trừ lùi = true; Giá outright = false");

                entity.Property(e => e.Macn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("macn")
                    .IsFixedLength(true);

                entity.Property(e => e.Makhach)
                    .HasMaxLength(50)
                    .HasColumnName("makhach");

                entity.Property(e => e.MuaBan)
                    .HasMaxLength(50)
                    .HasColumnName("mua_ban")
                    .HasComment("MUA: hợp đồng mua;  BAN: hợp đồng bán");

                entity.Property(e => e.NgayTraPhaitra)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayTra_Phaitra");

                entity.Property(e => e.Ngaygiao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaygiao");

                entity.Property(e => e.Ngayhl)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayhl");

                entity.Property(e => e.Ngayky)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayky");

                entity.Property(e => e.Ngaylam)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaylam");

                entity.Property(e => e.Ngaytl)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaytl");

                entity.Property(e => e.Nguoilam)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nguoilam")
                    .IsFixedLength(true);

                entity.Property(e => e.Nguoitl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nguoitl")
                    .IsFixedLength(true);

                entity.Property(e => e.Pakd).HasColumnName("PAKD");

                entity.Property(e => e.Ref)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ref")
                    .IsFixedLength(true);

                entity.Property(e => e.SoHdcmuon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SoHDCMuon")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoPakd)
                    .HasMaxLength(10)
                    .HasColumnName("soPAKD")
                    .IsFixedLength(true);

                entity.Property(e => e.Sohd)
                    .HasMaxLength(50)
                    .HasColumnName("sohd");

                entity.Property(e => e.Tenfull)
                    .HasMaxLength(255)
                    .HasColumnName("tenfull");

                entity.Property(e => e.Thanhtoan)
                    .HasMaxLength(50)
                    .HasColumnName("thanhtoan")
                    .IsFixedLength(true);

                entity.Property(e => e.ThanhtoanId).HasColumnName("thanhtoanId");

                entity.Property(e => e.TienUngHd)
                    .HasColumnType("money")
                    .HasColumnName("TienUngHD");

                entity.Property(e => e.TienUngTt)
                    .HasColumnType("money")
                    .HasColumnName("TienUngTT");

                entity.Property(e => e.Tiente)
                    .HasMaxLength(10)
                    .HasColumnName("tiente")
                    .IsFixedLength(true);

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasComment("1: mới, 2: hủy, 0: thanh lý");

                entity.Property(e => e.TrangthaiGhep)
                    .IsRequired()
                    .HasColumnName("trangthaiGhep")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0: không cho ghép - 1: còn có thể cho ghép");

                entity.Property(e => e.TypeKd)
                    .HasColumnName("TypeKD")
                    .HasComment("0: Trực tiếp, 1: Ủy thác");

                entity.Property(e => e.VanChuyen)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Hdmb1>(entity =>
            {
                entity.ToTable("hdmb1");

                entity.Property(e => e.Diff)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("diff");

                entity.Property(e => e.Giact)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("giact");

                entity.Property(e => e.Gianam)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("gianam");

                entity.Property(e => e.Giathang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("giathang");

                entity.Property(e => e.Isfix).HasColumnName("isfix");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mahang");

                entity.Property(e => e.Manhom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("manhom");

                entity.Property(e => e.MuaBan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mua_ban");

                entity.Property(e => e.Ngayky)
                    .HasColumnType("date")
                    .HasColumnName("ngayky");

                entity.Property(e => e.Sig)
                    .HasMaxLength(50)
                    .HasColumnName("sig");

                entity.Property(e => e.Tiente)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tiente");

                entity.Property(e => e.Trongluong)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("trongluong");
            });

            modelBuilder.Entity<HdmbAnnex>(entity =>
            {
                entity.ToTable("hdmb_annex");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.NoiDung).IsRequired();

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HdmbGiaohang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hdmb_giaohang");

                entity.Property(e => e.DiaDiemGiaoHang).IsRequired();
            });

            modelBuilder.Entity<Hh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hh");

                entity.Property(e => e.ProdCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("prod_code")
                    .IsFixedLength(true);

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("prod_name");
            });

            modelBuilder.Entity<Hopdong1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hopdong1");

                entity.Property(e => e.Chitiet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("chitiet");

                entity.Property(e => e.Isedit).HasColumnName("isedit");

                entity.Property(e => e.Loaihd).HasColumnName("loaihd");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("macn")
                    .IsFixedLength(true);

                entity.Property(e => e.Makhach)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("makhach")
                    .IsFixedLength(true);

                entity.Property(e => e.Muc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("muc")
                    .IsFixedLength(true);

                entity.Property(e => e.Nhomhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nhomhang")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Huyen>(entity =>
            {
                entity.ToTable("Huyen");

                entity.Property(e => e.KhuVucName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.KhuVuc)
                    .WithMany(p => p.Huyens)
                    .HasForeignKey(d => d.KhuVucId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Huyen_Khuvuc");
            });

            modelBuilder.Entity<IconChat>(entity =>
            {
                entity.ToTable("IconChat");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Images).HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ImportBhxh2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Import_BHXH_2022");

                entity.Property(e => e.HoVaTen)
                    .HasMaxLength(255)
                    .HasColumnName("Ho_Va_Ten");

                entity.Property(e => e.MaCbNv)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_NV");

                entity.Property(e => e.SoBhxh)
                    .HasMaxLength(255)
                    .HasColumnName("So_BHXH");

                entity.Property(e => e.SoBhyt)
                    .HasMaxLength(255)
                    .HasColumnName("So_BHYT");

                entity.Property(e => e.Stt).HasColumnName("STT");
            });

            modelBuilder.Entity<ImportBhxh2022B>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Import_BHXH_2022_BS");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_NV");

                entity.Property(e => e.MaPm)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Pm");

                entity.Property(e => e.SoBhNew)
                    .HasMaxLength(50)
                    .HasColumnName("So_BH_New");

                entity.Property(e => e.SoBhxh).HasColumnName("So_BHXH");

                entity.Property(e => e.SoYt)
                    .HasMaxLength(255)
                    .HasColumnName("So_YT");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_NV");
            });

            modelBuilder.Entity<ImportBhxhNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Import_BHXH_New");

                entity.Property(e => e.HoVaTen)
                    .HasMaxLength(255)
                    .HasColumnName("Ho_Va_Ten");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_NV");

                entity.Property(e => e.SoBhxh)
                    .HasMaxLength(255)
                    .HasColumnName("So_BHXH");

                entity.Property(e => e.SoBhyt)
                    .HasMaxLength(255)
                    .HasColumnName("So_BHYT");

                entity.Property(e => e.Stt).HasColumnName("STT");
            });

            modelBuilder.Entity<ImportSaiMaNvBhxh2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Import_SaiMa_NV_BHXH_2022");

                entity.Property(e => e.HoVaTen)
                    .HasMaxLength(255)
                    .HasColumnName("Ho_Va_Ten");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_NV");

                entity.Property(e => e.SoBhxh)
                    .HasMaxLength(255)
                    .HasColumnName("So_BHXH");

                entity.Property(e => e.SoBhyt)
                    .HasMaxLength(255)
                    .HasColumnName("So_BHYT");

                entity.Property(e => e.Stt).HasColumnName("STT");
            });

            modelBuilder.Entity<InputContract>(entity =>
            {
                entity.ToTable("InputContract");

                entity.Property(e => e.ContractDetailId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EntDate).HasColumnType("date");

                entity.Property(e => e.EntNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InputNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ContractDetail)
                    .WithMany(p => p.InputContracts)
                    .HasForeignKey(d => d.ContractDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InputContract_hdmb");

                entity.HasOne(d => d.InputDetail)
                    .WithMany(p => p.InputContracts)
                    .HasForeignKey(d => d.InputDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InputContract_InputDetail_SX");
            });

            modelBuilder.Entity<InputDetail>(entity =>
            {
                entity.ToTable("InputDetail");

                entity.Property(e => e.InputDetailId).HasMaxLength(255);

                entity.Property(e => e.Gw).HasColumnName("GW");

                entity.Property(e => e.InputStockId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Kcsid).HasColumnName("KCSId");

                entity.Property(e => e.LoaiBao)
                    .HasColumnName("loai_bao")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OriginailItemCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InputDetailSx>(entity =>
            {
                entity.HasKey(e => e.InputDetailId);

                entity.ToTable("InputDetail_SX");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gw).HasColumnName("GW");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Kcsid).HasColumnName("KCSId");

                entity.Property(e => e.Kcsnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("KCSNumber");

                entity.Property(e => e.LoaiBao).HasColumnName("loai_bao");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TlBao).HasColumnName("TL_Bao");

                entity.Property(e => e.TruckNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.InputStock)
                    .WithMany(p => p.InputDetailSxes)
                    .HasForeignKey(d => d.InputStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InputDetail_SX_InputStock_SX");
            });

            modelBuilder.Entity<InputStock>(entity =>
            {
                entity.ToTable("InputStock");

                entity.Property(e => e.InputStockId).HasMaxLength(255);

                entity.Property(e => e.CanId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Collate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CollateId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ContractIdSource)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateConfirm).HasColumnType("datetime");

                entity.Property(e => e.DvGiao)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("dv_giao")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntDate).HasColumnType("date");

                entity.Property(e => e.InputNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.InputTypeName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: Nhập; 1: Xuất");

                entity.Property(e => e.LenhNhap)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("lenh_nhap")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("macn")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Stock)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StockCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserConfirm).HasMaxLength(50);

                entity.Property(e => e.XeVc)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("xe_vc")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<InputStockSx>(entity =>
            {
                entity.HasKey(e => e.InputStockId)
                    .HasName("PK_InputStockId");

                entity.ToTable("InputStock_SX");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateConfirm).HasColumnType("datetime");

                entity.Property(e => e.DvGiao)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("dv_giao");

                entity.Property(e => e.EntDate).HasColumnType("date");

                entity.Property(e => e.InputNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.InputTypeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsProduce).HasDefaultValueSql("((1))");

                entity.Property(e => e.LenhNhap)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("lenh_nhap");

                entity.Property(e => e.MaKh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Kh")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Stock)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StockCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ten_Kh")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserConfirm).HasMaxLength(50);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("Inventory");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.DenVo)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("den_vo");

                entity.Property(e => e.DoAm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("do_am");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dvt");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ma_hang");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.NgayKhoaSo).HasColumnType("date");

                entity.Property(e => e.Sang12)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("sang_12");

                entity.Property(e => e.Sang13)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("sang_13");

                entity.Property(e => e.Sang16)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("sang_16");

                entity.Property(e => e.Sang18)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("sang_18");

                entity.Property(e => e.SoBao)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("so_bao");

                entity.Property(e => e.SoPhieu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("so_phieu");

                entity.Property(e => e.Stock)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TapChat)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("tap_chat");

                entity.Property(e => e.TenHang)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ten_hang");

                entity.Property(e => e.TrongLuong)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("trong_luong");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice");

                entity.Property(e => e.Id)
                    .HasMaxLength(15)
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amount");

                entity.Property(e => e.Balance)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("balance");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasColumnName("bank");

                entity.Property(e => e.BankCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bankCode")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .HasColumnName("bill_no");

                entity.Property(e => e.Buyer)
                    .IsRequired()
                    .HasColumnName("buyer");

                entity.Property(e => e.Cbuyer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("cbuyer")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeImportCountry)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodeTranshipmentCountry)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateBill)
                    .HasColumnType("date")
                    .HasColumnName("date_bill");

                entity.Property(e => e.DateHd)
                    .HasColumnType("datetime")
                    .HasColumnName("date_hd");

                entity.Property(e => e.DateIv)
                    .HasColumnType("datetime")
                    .HasColumnName("date_iv");

                entity.Property(e => e.DateLc)
                    .HasMaxLength(50)
                    .HasColumnName("date_lc");

                entity.Property(e => e.Delivery)
                    .HasMaxLength(50)
                    .HasColumnName("delivery");

                entity.Property(e => e.Giaohang)
                    .HasMaxLength(250)
                    .HasColumnName("giaohang");

                entity.Property(e => e.Goods).HasColumnName("goods");

                entity.Property(e => e.ImportCountry)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Invoice1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("invoice");

                entity.Property(e => e.IsXuatThiTruong).HasColumnName("IsXuat_ThiTruong");

                entity.Property(e => e.Issue)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KyBaoCao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LcNo)
                    .HasMaxLength(50)
                    .HasColumnName("lc_no");

                entity.Property(e => e.LoaiIv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("loaiIV");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MainUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Marks)
                    .HasMaxLength(50)
                    .HasColumnName("marks");

                entity.Property(e => e.Medit).HasColumnName("medit");

                entity.Property(e => e.NgayChuyenKt)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Chuyen_Kt");

                entity.Property(e => e.NgayLam).HasColumnType("date");

                entity.Property(e => e.NgayThanhKhoan).HasColumnType("date");

                entity.Property(e => e.NgayTrinhCt)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Trinh_Ct");

                entity.Property(e => e.Ngoaite)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ngoaite");

                entity.Property(e => e.Nhapkho).HasColumnName("nhapkho");

                entity.Property(e => e.NhapkhoNd).HasColumnName("nhapkho_Nd");

                entity.Property(e => e.Packing)
                    .HasMaxLength(255)
                    .HasColumnName("packing");

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("payment");

                entity.Property(e => e.PortLoad1)
                    .HasMaxLength(50)
                    .HasColumnName("port_load1");

                entity.Property(e => e.PreCarri)
                    .HasMaxLength(50)
                    .HasColumnName("pre_carri");

                entity.Property(e => e.ProIvId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Pro_IV_Id")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Shd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("shd");

                entity.Property(e => e.Shiper).HasColumnName("shiper");

                entity.Property(e => e.SubUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.TMarks).HasColumnName("t_marks");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("ten");

                entity.Property(e => e.Tienung)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("tienung");

                entity.Property(e => e.TimestampColumn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");

                entity.Property(e => e.TranshipmentCountry)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserXuat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Vessel)
                    .HasMaxLength(50)
                    .HasColumnName("vessel");

                entity.Property(e => e.Voy1)
                    .HasMaxLength(50)
                    .HasColumnName("voy1");

                entity.Property(e => e.Voy2)
                    .HasMaxLength(50)
                    .HasColumnName("voy2");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.ToTable("invoice_Detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmountByLetter)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("amountByLetter")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AmountVnd)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amountVND");

                entity.Property(e => e.Bag)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("bag");

                entity.Property(e => e.CachTinhGia)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateVat)
                    .HasColumnType("date")
                    .HasColumnName("DateVAT");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("gw");

                entity.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mahang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mahang");

                entity.Property(e => e.MucStoploss).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Nw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("nw");

                entity.Property(e => e.PackedBy)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quanlity)
                    .IsRequired()
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SerialVat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SerialVAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sohd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SohdVat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("sohdVAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SystemRef)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenhang)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("tenhang");

                entity.Property(e => e.TinhStoploss)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<InxHoaTan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INX_HoaTan");

                entity.Property(e => e.ChuyenMon)
                    .HasMaxLength(255)
                    .HasColumnName("Chuyen_Mon");

                entity.Property(e => e.CvChinh)
                    .HasMaxLength(255)
                    .HasColumnName("CV_Chinh");

                entity.Property(e => e.DanToc)
                    .HasMaxLength(255)
                    .HasColumnName("Dan_Toc");

                entity.Property(e => e.DiaChiHt)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_Chi_HT");

                entity.Property(e => e.DiaChiTt)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_Chi_TT");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");

                entity.Property(e => e.HandPhone)
                    .HasMaxLength(255)
                    .HasColumnName("Hand_Phone");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");

                entity.Property(e => e.KhongDvt).HasColumnName("Khong_DVT");

                entity.Property(e => e.LanhDao).HasColumnName("Lanh_Dao");

                entity.Property(e => e.LyDoNghi)
                    .HasMaxLength(255)
                    .HasColumnName("Ly_Do_Nghi");

                entity.Property(e => e.MaAnh)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Anh");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_BP");

                entity.Property(e => e.MaCa)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Ca");

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_ChucVu");

                entity.Property(e => e.MaDv)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Dv");

                entity.Property(e => e.MaMayCc)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_May_CC");

                entity.Property(e => e.MaNsNew)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Ns_New");

                entity.Property(e => e.MaNsOld)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_NS_Old");

                entity.Property(e => e.MaNv1)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_NV_1");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_So_Thue");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayCapCmnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Cap_CMND");

                entity.Property(e => e.NgayCapHc)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_Cap_HC");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_KT");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Sinh");

                entity.Property(e => e.NguoiPt).HasColumnName("Nguoi_PT");

                entity.Property(e => e.NguyenQuan)
                    .HasMaxLength(255)
                    .HasColumnName("Nguyen_Quan");

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap");

                entity.Property(e => e.NoiCapHc)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap_HC");

                entity.Property(e => e.NoiSinh)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Sinh");

                entity.Property(e => e.Qt)
                    .HasMaxLength(255)
                    .HasColumnName("QT");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(255)
                    .HasColumnName("So_CMND");

                entity.Property(e => e.SoHc)
                    .HasMaxLength(255)
                    .HasColumnName("So_HC");

                entity.Property(e => e.SoQdNghi)
                    .HasMaxLength(255)
                    .HasColumnName("So_QD_Nghi");

                entity.Property(e => e.SoTkNh)
                    .HasMaxLength(255)
                    .HasColumnName("So_Tk_NH");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TdHv)
                    .HasMaxLength(255)
                    .HasColumnName("TD_HV");

                entity.Property(e => e.TdNn)
                    .HasMaxLength(255)
                    .HasColumnName("TD_NN");

                entity.Property(e => e.TdTh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_TH");

                entity.Property(e => e.TdVh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_VH");

                entity.Property(e => e.TenNh)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_NH");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_NV");

                entity.Property(e => e.TinhTrangHn)
                    .HasMaxLength(255)
                    .HasColumnName("Tinh_Trang_HN");

                entity.Property(e => e.TonGiao)
                    .HasMaxLength(255)
                    .HasColumnName("Ton_Giao");

                entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            });

            modelBuilder.Entity<InxVanPhong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("INX_VanPhong");

                entity.Property(e => e.ChuyenMon)
                    .HasMaxLength(255)
                    .HasColumnName("Chuyen_Mon");

                entity.Property(e => e.CvChinh)
                    .HasMaxLength(255)
                    .HasColumnName("CV_Chinh");

                entity.Property(e => e.DanToc)
                    .HasMaxLength(255)
                    .HasColumnName("Dan_Toc");

                entity.Property(e => e.DiaChiHt)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_Chi_HT");

                entity.Property(e => e.DiaChiTt)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_Chi_TT");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");

                entity.Property(e => e.HandPhone)
                    .HasMaxLength(255)
                    .HasColumnName("Hand_Phone");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");

                entity.Property(e => e.KhongDvt).HasColumnName("Khong_DVT");

                entity.Property(e => e.LanhDao).HasColumnName("Lanh_Dao");

                entity.Property(e => e.LyDoNghi)
                    .HasMaxLength(255)
                    .HasColumnName("Ly_Do_Nghi");

                entity.Property(e => e.MaAnh)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Anh");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_BP");

                entity.Property(e => e.MaCa)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Ca");

                entity.Property(e => e.MaChucVu)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_ChucVu");

                entity.Property(e => e.MaDv)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Dv");

                entity.Property(e => e.MaMayCc)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_May_CC");

                entity.Property(e => e.MaNsNew)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Ns_New");

                entity.Property(e => e.MaNsOld)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_NS_Old");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_So_Thue");

                entity.Property(e => e.MaVt)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_VT");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayCapCmnd)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_Cap_CMND");

                entity.Property(e => e.NgayCapHc)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_Cap_HC");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_KT");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Sinh");

                entity.Property(e => e.NguoiPt).HasColumnName("Nguoi_PT");

                entity.Property(e => e.NguyenQuan)
                    .HasMaxLength(255)
                    .HasColumnName("Nguyen_Quan");

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap");

                entity.Property(e => e.NoiCapHc)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap_HC");

                entity.Property(e => e.NoiSinh)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Sinh");

                entity.Property(e => e.Qt)
                    .HasMaxLength(255)
                    .HasColumnName("QT");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(255)
                    .HasColumnName("So_CMND");

                entity.Property(e => e.SoHc)
                    .HasMaxLength(255)
                    .HasColumnName("So_HC");

                entity.Property(e => e.SoQdNghi)
                    .HasMaxLength(255)
                    .HasColumnName("So_QD_Nghi");

                entity.Property(e => e.SoTkNh)
                    .HasMaxLength(255)
                    .HasColumnName("So_Tk_NH");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TdHv)
                    .HasMaxLength(255)
                    .HasColumnName("TD_HV");

                entity.Property(e => e.TdNn)
                    .HasMaxLength(255)
                    .HasColumnName("TD_NN");

                entity.Property(e => e.TdTh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_TH");

                entity.Property(e => e.TdVh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_VH");

                entity.Property(e => e.TenNh)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_NH");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_NV");

                entity.Property(e => e.TinhTrangHn)
                    .HasMaxLength(255)
                    .HasColumnName("Tinh_Trang_HN");

                entity.Property(e => e.TonGiao)
                    .HasMaxLength(255)
                    .HasColumnName("Ton_Giao");

                entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");
            });

            modelBuilder.Entity<Ioform>(entity =>
            {
                entity.ToTable("IOForm");

                entity.Property(e => e.Form)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IoformId).HasColumnName("IOFormId");

                entity.Property(e => e.IoformName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("IOFormName");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Kc>(entity =>
            {
                entity.ToTable("KCS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CanId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DenVo)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("den_vo")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Đen vỡ;Bạc bụng");

                entity.Property(e => e.DoAm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("do_am")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Độ ẩm");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(10)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ghichu)
                    .HasColumnType("ntext")
                    .HasColumnName("ghichu")
                    .HasDefaultValueSql("('')")
                    .HasComment("Ghi chú");

                entity.Property(e => e.HatChay)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("hat_chay")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Hạt cháy-");

                entity.Property(e => e.HatKhac)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("hat_khac")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Hạt khác loài -");

                entity.Property(e => e.HatMoc)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("hat_moc")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Hạt mốc;Xanh non");

                entity.Property(e => e.HatNau)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("hat_nau")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Hạt nâu;Tỉ lệ hạt(rạng gẫy)");

                entity.Property(e => e.KhachHang)
                    .HasMaxLength(50)
                    .HasColumnName("khach_hang")
                    .HasDefaultValueSql("('')")
                    .HasComment("Khách hàng");

                entity.Property(e => e.LoaiBao)
                    .HasColumnName("loai_bao")
                    .HasDefaultValueSql("('')")
                    .HasComment("Loại bao");

                entity.Property(e => e.LoaiKcs)
                    .HasColumnName("loaiKCS")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: nhập NVL để sx; 1: Nhập TP từ sx; 2: Xuất NVL de SX; 3: Xuat TP");

                entity.Property(e => e.Macn)
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.Mahang)
                    .HasMaxLength(20)
                    .HasColumnName("mahang")
                    .HasDefaultValueSql("('')")
                    .HasComment("Hàng hóa");

                entity.Property(e => e.Manhom)
                    .HasMaxLength(20)
                    .HasColumnName("manhom")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayNhap)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_nhap")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayPhieu)
                    .HasColumnType("date")
                    .HasColumnName("ngay_phieu")
                    .HasComment("Ngày nhập");

                entity.Property(e => e.NguoiGiao)
                    .HasMaxLength(150)
                    .HasColumnName("nguoi_giao")
                    .HasDefaultValueSql("('')")
                    .HasComment("Người giao");

                entity.Property(e => e.NguoiKiem)
                    .HasMaxLength(150)
                    .HasColumnName("nguoi_kiem")
                    .HasDefaultValueSql("('')")
                    .HasComment("Người kiểm hàng");

                entity.Property(e => e.NguoiLayMau)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NguoiSua)
                    .HasMaxLength(150)
                    .HasColumnName("nguoi_sua")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NguoiTao)
                    .HasMaxLength(150)
                    .HasColumnName("nguoi_tao")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sang12)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sang_12")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Hạt trên sàng 12 -");

                entity.Property(e => e.Sang13)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sang_13")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Hạt trên sàng 13 -");

                entity.Property(e => e.Sang16)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sang_16")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Hạt trên sàng 16 -");

                entity.Property(e => e.Sang18)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sang_18")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Hạt trên sàng 18 -");

                entity.Property(e => e.SlChuaghep)
                    .HasColumnName("sl_chuaghep")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoLuong)
                    .HasColumnName("so_luong")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Số bao");

                entity.Property(e => e.SoPhieu)
                    .HasMaxLength(20)
                    .HasColumnName("so_phieu")
                    .HasDefaultValueSql("('')")
                    .HasComment("");

                entity.Property(e => e.TapChat)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tap_chat")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Tạp chất");

                entity.Property(e => e.TenHang)
                    .HasMaxLength(250)
                    .HasColumnName("ten_hang")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenKhach)
                    .HasMaxLength(250)
                    .HasColumnName("ten_khach")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TlChuaghep)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Tl_chuaghep")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangXop)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("trang_xop")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Hạt trắng xốp-");

                entity.Property(e => e.TrongLuong)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("trong_luong")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Trọng lượng GW");

                entity.Property(e => e.TrongLuongNw)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("TrongLuong_NW")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Trọng lượng NW");

                entity.Property(e => e.TrongluongXe)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("trongluong_xe")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.XeVc)
                    .HasMaxLength(20)
                    .HasColumnName("xe_vc")
                    .HasDefaultValueSql("('')")
                    .HasComment("Xe vận chuyển");
            });

            modelBuilder.Entity<Kcsky>(entity =>
            {
                entity.ToTable("KCSKy");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.NguoiKy)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Kdtv>(entity =>
            {
                entity.ToTable("kdtv");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bags)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("bags");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bill_no");

                entity.Property(e => e.Bulk)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("_bulk")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Consignee)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("consignee");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("date");

                entity.Property(e => e.Declaration)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("declaration")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Delivery)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("delivery");

                entity.Property(e => e.Goods)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("goods");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("gw");

                entity.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.MainUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Marks)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("marks");

                entity.Property(e => e.Medit).HasColumnName("medit");

                entity.Property(e => e.Ngaykt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ngaykt");

                entity.Property(e => e.Nongdo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nongdo");

                entity.Property(e => e.Nw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("nw");

                entity.Property(e => e.PlaceOfIssue)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PortLoad1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_load1");

                entity.Property(e => e.PreCarri)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pre_carri");

                entity.Property(e => e.Shiper)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("shiper");

                entity.Property(e => e.SoNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("So_No")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubUnit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TMarks)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("t_marks");

                entity.Property(e => e.Tbao)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("tbao");

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasMaxLength(125)
                    .HasColumnName("ten_kh");

                entity.Property(e => e.Tenthuoc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenthuoc");

                entity.Property(e => e.Tg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tg");

                entity.Property(e => e.TimestampColumn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");

                entity.Property(e => e.Vessel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("vessel");

                entity.Property(e => e.Voy1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy1");

                entity.Property(e => e.Voy2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("voy2");

                entity.Property(e => e.Xl)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("xl");
            });

            modelBuilder.Entity<KeHoachNam>(entity =>
            {
                entity.ToTable("KeHoachNam");

                entity.Property(e => e.Madv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nhom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoKh).HasColumnName("SoKH");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Kh>(entity =>
            {
                entity.HasKey(e => e.CustCode);

                entity.ToTable("kh");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("cust_code")
                    .IsFixedLength(true);

                entity.Property(e => e.CustName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("cust_name");

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("diachi");

                entity.Property(e => e.Dienthoai)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dienthoai")
                    .IsFixedLength(true);

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(50)
                    .HasColumnName("taikhoan");

                entity.Property(e => e.Taxcode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("taxcode")
                    .IsFixedLength(true);

                entity.Property(e => e.Tenkhach)
                    .HasMaxLength(100)
                    .HasColumnName("tenkhach");
            });

            modelBuilder.Entity<KhTam2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KH_TAM2");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("dia_chi");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("dien_thoai");

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .HasColumnName("fax");

                entity.Property(e => e.GiayPhep)
                    .HasMaxLength(255)
                    .HasColumnName("giay_phep");

                entity.Property(e => e.MaKhuvuc)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_khuvuc");

                entity.Property(e => e.MaNhom).HasMaxLength(50);

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(255)
                    .HasColumnName("ma_so_thue");

                entity.Property(e => e.Makhach)
                    .HasMaxLength(50)
                    .HasColumnName("makhach");

                entity.Property(e => e.MuaBan)
                    .HasMaxLength(50)
                    .HasColumnName("mua_ban");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("date")
                    .HasColumnName("ngay_cap");

                entity.Property(e => e.Slhd).HasColumnName("SLHD");

                entity.Property(e => e.TenFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ten_full");

                entity.Property(e => e.TenKhuvuc)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Ten_khuvuc");

                entity.Property(e => e.Trongluong).HasColumnType("decimal(38, 3)");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhach)
                    .HasName("PK_khachHang_1");

                entity.ToTable("khachHang");

                entity.Property(e => e.MaKhach)
                    .HasMaxLength(50)
                    .HasColumnName("ma_khach");

                entity.Property(e => e.Bocxep)
                    .HasMaxLength(250)
                    .HasColumnName("bocxep");

                entity.Property(e => e.CheckTh).HasColumnName("Check_TH");

                entity.Property(e => e.ChucVu1)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu1");

                entity.Property(e => e.ChucVu2)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu2");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateActive)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Active");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("dia_chi");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("dien_thoai");

                entity.Property(e => e.Dientich).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .HasColumnName("fax");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(50)
                    .HasColumnName("ghi_chu");

                entity.Property(e => e.GiaoDich)
                    .HasColumnName("giao_dich")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0- Chờ duyệt, 1- Đang giao dịch, 2- Ngừng giao dịch");

                entity.Property(e => e.GiaoDichBan).HasColumnName("giao_dich_ban");

                entity.Property(e => e.GiaoDichMua).HasColumnName("giao_dich_mua");

                entity.Property(e => e.GiayPhep)
                    .HasMaxLength(255)
                    .HasColumnName("giay_phep");

                entity.Property(e => e.Idkhach)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IDKhach")
                    .IsFixedLength(true);

                entity.Property(e => e.LoaiKhach)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("loai_khach")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0- khách hàng mua bán lâu dài, 1- khách hàng mua bán theo từng phương án");

                entity.Property(e => e.MaCn)
                    .HasMaxLength(10)
                    .HasColumnName("ma_cn")
                    .IsFixedLength(true);

                entity.Property(e => e.MaHd)
                    .HasMaxLength(50)
                    .HasColumnName("ma_hd");

                entity.Property(e => e.MaKhuvuc)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_khuvuc");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(255)
                    .HasColumnName("ma_so_thue");

                entity.Property(e => e.MatHang)
                    .HasMaxLength(50)
                    .HasColumnName("mat_hang");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.NganHang)
                    .HasMaxLength(255)
                    .HasColumnName("Ngan_hang");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("date")
                    .HasColumnName("ngay_cap");

                entity.Property(e => e.NguoiKy1)
                    .HasMaxLength(50)
                    .HasColumnName("Nguoi_ky1");

                entity.Property(e => e.NguoiKy2)
                    .HasMaxLength(50)
                    .HasColumnName("Nguoi_ky2");

                entity.Property(e => e.Sanluong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(250)
                    .HasColumnName("tai_khoan");

                entity.Property(e => e.TenFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ten_full")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenKhach)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ten_khach");

                entity.Property(e => e.TenQg)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Qg");

                entity.Property(e => e.ThanhToanBan).HasColumnName("thanh_toan_ban");

                entity.Property(e => e.ThanhToanMua).HasColumnName("thanh_toan_mua");

                entity.Property(e => e.ToaKinhTe).HasMaxLength(250);

                entity.Property(e => e.UyQuyen1)
                    .HasMaxLength(50)
                    .HasColumnName("Uy_Quyen1");

                entity.Property(e => e.UyQuyen2)
                    .HasMaxLength(50)
                    .HasColumnName("Uy_Quyen2");

                entity.Property(e => e.Vanchuyen)
                    .HasMaxLength(250)
                    .HasColumnName("vanchuyen");

                entity.Property(e => e.Visible)
                    .IsRequired()
                    .HasColumnName("visible")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Khachngoai>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Khachngoai");

                entity.Property(e => e.MaKhach)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_khach");
            });

            modelBuilder.Entity<KhieuNai>(entity =>
            {
                entity.ToTable("KhieuNai");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Gtdk)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GTDK");

                entity.Property(e => e.Gtgq)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GTGQ");

                entity.Property(e => e.Gtps)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GTPS");

                entity.Property(e => e.Gtth)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GTTH");

                entity.Property(e => e.KhachHang)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaDV");

                entity.Property(e => e.Sldk)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SLDK");

                entity.Property(e => e.Slgq)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SLGQ");

                entity.Property(e => e.Slps)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SLPS");

                entity.Property(e => e.Slth)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SLTH");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KhkdTiep>(entity =>
            {
                entity.ToTable("KHKD_Tiep");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DVT");

                entity.Property(e => e.HangHoa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LoaiHinh)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaDV");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NhomHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type).HasComment("0: BC tuần, 1: BC tháng");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Khohang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("khohang");

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("diachi");

                entity.Property(e => e.Makho)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("makho")
                    .IsFixedLength(true);

                entity.Property(e => e.Tenkho)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("tenkho");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<Khuvuc>(entity =>
            {
                entity.ToTable("Khuvuc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaKhuvuc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_khuvuc");

                entity.Property(e => e.TenKhuvuc)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Ten_khuvuc");
            });

            modelBuilder.Entity<KimNgach>(entity =>
            {
                entity.ToTable("KimNgach");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.HangHoa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.HinhThuc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LoaiHinh)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaDV");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgoaiTe)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nhom)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhomHang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type).HasComment("0: BC tuần, 1: BC tháng");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KimNgach2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KimNgach_2019");

                entity.Property(e => e.GiaTri).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ImportCountry)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ngoaite)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ngoaite");
            });

            modelBuilder.Entity<KimNgach20192020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KimNgach_2019_2020");

                entity.Property(e => e.ImportCountry)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ngoaite)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ngoaite");

                entity.Property(e => e.TriGia).HasColumnType("money");
            });

            modelBuilder.Entity<KimNgach2020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KimNgach_2020");

                entity.Property(e => e.GiaTri).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.ImportCountry)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ngoaite)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ngoaite");
            });

            modelBuilder.Entity<KimNgachDoanhThu>(entity =>
            {
                entity.ToTable("KimNgach_DoanhThu");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DoanhThu)
                    .HasColumnType("money")
                    .HasColumnName("Doanh_Thu");

                entity.Property(e => e.DuyetNam).HasColumnName("Duyet_nam");

                entity.Property(e => e.DuyetQui).HasColumnName("Duyet_Qui");

                entity.Property(e => e.DuyetThang).HasColumnName("Duyet_Thang");

                entity.Property(e => e.DuyetTuan).HasColumnName("Duyet_Tuan");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.KimNgach)
                    .HasColumnType("money")
                    .HasColumnName("Kim_Ngach");

                entity.Property(e => e.LoaiHinh)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loai_Hinh")
                    .HasDefaultValueSql("('X')")
                    .IsFixedLength(true)
                    .HasComment("X - Xuất khẩu, N - Nhập khẩu");

                entity.Property(e => e.MaDvCs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_DvCs")
                    .HasDefaultValueSql("(N'INX')");

                entity.Property(e => e.Nam).HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.NamLv)
                    .HasColumnName("Nam_LV")
                    .HasDefaultValueSql("(datepart(year,getdate()))");

                entity.Property(e => e.NgayCt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ct")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NhomHang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nhom_Hang")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("So_Hd")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("money")
                    .HasColumnName("So_Luong");

                entity.Property(e => e.Thang).HasDefaultValueSql("(datepart(month,getdate()))");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TyGia)
                    .HasColumnType("money")
                    .HasColumnName("Ty_Gia");
            });

            modelBuilder.Entity<KtTtContract>(entity =>
            {
                entity.HasKey(e => e.IdTt);

                entity.ToTable("KT_TT_CONTRACT");

                entity.Property(e => e.IdTt).HasColumnName("Id_TT");

                entity.Property(e => e.Invoice)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MaHdKt)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Hd_Kt");

                entity.Property(e => e.MaTte)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_TTe")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayCt)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Ct");

                entity.Property(e => e.NoiDung)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Noi_Dung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoCt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("So_Ct");

                entity.Property(e => e.Stt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STT");

                entity.Property(e => e.Stt0)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("STT0");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TienTt)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Tien_TT");

                entity.Property(e => e.TienTtNt)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Tien_TT_NT");

                entity.Property(e => e.TkCo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Tk_Co");

                entity.Property(e => e.TkNo)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Tk_No");

                entity.Property(e => e.TyGia)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Ty_Gia");
            });

            modelBuilder.Entity<KyKetHdPakd>(entity =>
            {
                entity.ToTable("KyKet_Hd_Pakd");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaDV");

                entity.Property(e => e.Nhom)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NhomHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Learning>(entity =>
            {
                entity.HasKey(e => e.ActId);

                entity.ToTable("Learning");

                entity.Property(e => e.ActId)
                    .ValueGeneratedNever()
                    .HasColumnName("ACT_ID");

                entity.Property(e => e.ActModule)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ACT_module")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ACTION")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObjectId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')")
                    .HasComment("Nếu ACTION là EXEC thi để tên Form, nếu ACTION la REMINDER thì để tên store truy vấn kiểm tra.");

                entity.Property(e => e.Sms)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("SMS")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<LenhXk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LenhXK");

                entity.Property(e => e.CatMang).HasColumnType("datetime");

                entity.Property(e => e.ChongAm)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DvNhan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dvNhan");

                entity.Property(e => e.GiamDinh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Giay)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HangTau)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.KhuTrung)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KiemDem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LienHe)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.NgayGiao).HasColumnType("date");

                entity.Property(e => e.NgayLam).HasColumnType("date");

                entity.Property(e => e.NguoiMua)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NguonHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NhanMac)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoiGiao)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoBao).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SoLenh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.TrongLuong).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<LichCongTac>(entity =>
            {
                entity.ToTable("LichCongTac");

                entity.Property(e => e.T1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T10)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T11)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T12)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T13)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T14)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T15)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T16)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T17)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T18)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T19)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T20)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T21)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T22)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T23)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T24)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T25)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T26)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T27)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T28)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T29)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T30)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T31)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T32)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T33)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T34)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T35)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T36)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T37)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T38)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T39)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T4)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T40)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T41)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T42)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T43)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T44)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T45)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T46)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T47)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T48)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T49)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T5)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T50)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T51)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T52)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T53)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T54)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T55)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T56)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T57)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T58)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T6)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T7)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T8)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.T9)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ListCo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("list_co");

                entity.Property(e => e.Ms)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ms");

                entity.Property(e => e.Tenco)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tenco");
            });

            modelBuilder.Entity<LogCan>(entity =>
            {
                entity.ToTable("LogCan");

                entity.Property(e => e.GioCan)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.NgayCan).HasColumnType("date");

                entity.Property(e => e.PhieuCan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TrongLuong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TruckNo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LogMessage>(entity =>
            {
                entity.ToTable("LogMessage");

                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateSend).HasColumnType("date");

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("((0))")
                    .HasComment("");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoiNhuan>(entity =>
            {
                entity.ToTable("LoiNhuan");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.HieuQuaPa).HasColumnName("HieuQuaPA");

                entity.Property(e => e.HieuQuaTt).HasColumnName("HieuQuaTT");

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaDV");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type).HasComment("0: BC tuần, 1: BC tháng");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LuongBh2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LuongBH_2022");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(255)
                    .HasColumnName("Chuc_Vu");

                entity.Property(e => e.HoTen)
                    .HasMaxLength(255)
                    .HasColumnName("Ho_Ten");

                entity.Property(e => e.MaPm)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_PM");

                entity.Property(e => e.MucLuong).HasColumnName("Muc_Luong");

                entity.Property(e => e.NgachLuong)
                    .HasMaxLength(255)
                    .HasColumnName("Ngach_Luong");

                entity.Property(e => e.NgayAp)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ap");

                entity.Property(e => e.TgGiuBac)
                    .HasColumnType("datetime")
                    .HasColumnName("TG_Giu_Bac");
            });

            modelBuilder.Entity<LuongCdcv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Luong_CDCV$");

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.MaDv)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Dv");

                entity.Property(e => e.MucLuong).HasColumnName("Muc_luong");

                entity.Property(e => e.Ngach).HasMaxLength(255);

                entity.Property(e => e.NgayDc)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_DC");
            });

            modelBuilder.Entity<MapkdKt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MAPKD_KT");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MakhachKd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Makhach_KD");

                entity.Property(e => e.MakhachKt)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("Makhach_KT");
            });

            modelBuilder.Entity<MappingCodeChamCongEmployee>(entity =>
            {
                entity.ToTable("MappingCode_ChamCong_Employee");

                entity.Property(e => e.ChamCongId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("Material");

                entity.Property(e => e.MaterialCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaterialGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaterialName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Event).HasMaxLength(255);

                entity.Property(e => e.Icon).HasMaxLength(255);

                entity.Property(e => e.IconButton)
                    .HasMaxLength(255)
                    .HasColumnName("iconButton");

                entity.Property(e => e.IdParent).HasColumnName("ID_Parent");

                entity.Property(e => e.MenuName).HasMaxLength(255);

                entity.Property(e => e.MenuNameE)
                    .HasMaxLength(50)
                    .HasColumnName("MenuName_E");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.Object).HasMaxLength(255);

                entity.Property(e => e.Show).HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.TypeMenu).HasComment("1 du lieu ; 2 bao cao");
            });

            modelBuilder.Entity<Menu1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Menu_s");

                entity.Property(e => e.DescriptBrother)
                    .HasMaxLength(250)
                    .HasColumnName("Descript_Brother");

                entity.Property(e => e.Event).HasMaxLength(255);

                entity.Property(e => e.Icon).HasMaxLength(255);

                entity.Property(e => e.IconLager).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdBrother).HasColumnName("ID_Brother");

                entity.Property(e => e.IdParent).HasColumnName("ID_Parent");

                entity.Property(e => e.IsSystem).HasColumnName("isSystem");

                entity.Property(e => e.MenuName).HasMaxLength(255);

                entity.Property(e => e.MenuNameE)
                    .HasMaxLength(255)
                    .HasColumnName("MenuName_E");

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.NavExpand).HasColumnName("Nav_Expand");

                entity.Property(e => e.Object).HasMaxLength(255);

                entity.Property(e => e.Show).HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<MenuNav>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Menu_nav");

                entity.Property(e => e.DescriptBrother)
                    .HasMaxLength(255)
                    .HasColumnName("Descript_Brother");

                entity.Property(e => e.Event).HasMaxLength(255);

                entity.Property(e => e.Icon).HasMaxLength(255);

                entity.Property(e => e.IconLager).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdBrother).HasColumnName("ID_Brother");

                entity.Property(e => e.IdParent).HasColumnName("ID_Parent");

                entity.Property(e => e.IsSystem)
                    .HasMaxLength(255)
                    .HasColumnName("isSystem");

                entity.Property(e => e.MenuName).HasMaxLength(255);

                entity.Property(e => e.MenuNameE)
                    .HasMaxLength(255)
                    .HasColumnName("MenuName_E");

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.NavExpand).HasColumnName("Nav_Expand");

                entity.Property(e => e.Object).HasMaxLength(255);

                entity.Property(e => e.Show).HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<MenuTam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Menu_tam");

                entity.Property(e => e.Event).HasMaxLength(255);

                entity.Property(e => e.Icon).HasMaxLength(255);

                entity.Property(e => e.IconButton)
                    .HasMaxLength(255)
                    .HasColumnName("iconButton");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdParent).HasColumnName("ID_Parent");

                entity.Property(e => e.MenuName).HasMaxLength(255);

                entity.Property(e => e.MenuNameE)
                    .HasMaxLength(50)
                    .HasColumnName("MenuName_E");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.Object).HasMaxLength(255);

                entity.Property(e => e.Show).HasMaxLength(255);

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Message");

                entity.Property(e => e.IdEd)
                    .HasMaxLength(10)
                    .HasColumnName("idEd")
                    .IsFixedLength(true);

                entity.Property(e => e.Message1)
                    .HasColumnType("ntext")
                    .HasColumnName("Message");

                entity.Property(e => e.Msdate).HasColumnType("datetime");

                entity.Property(e => e.Systemref)
                    .HasMaxLength(20)
                    .HasColumnName("systemref")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MessageOffline>(entity =>
            {
                entity.ToTable("MessageOffline");

                entity.Property(e => e.Contents).IsRequired();

                entity.Property(e => e.EntDate).HasColumnType("datetime");

                entity.Property(e => e.UserReceive)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserSend)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MessageToUser>(entity =>
            {
                entity.ToTable("MessageToUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contens).HasMaxLength(255);

                entity.Property(e => e.MessageDate).HasColumnType("datetime");

                entity.Property(e => e.MessageType)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("messageType");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Money>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Ma)
                    .HasMaxLength(10)
                    .HasColumnName("ma")
                    .IsFixedLength(true);

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<NhapKho>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NhapKho");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DienGiai)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("dvt")
                    .IsFixedLength(true);

                entity.Property(e => e.Hinhthuc)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("hinhthuc");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaKho)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("macn")
                    .IsFixedLength(true);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.PhieuNhapXuat)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RefmuaBan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("refmua_ban")
                    .IsFixedLength(true);

                entity.Property(e => e.Soluong)
                    .HasColumnType("numeric(19, 3)")
                    .HasColumnName("soluong");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("systemref")
                    .IsFixedLength(true);

                entity.Property(e => e.Trongluong)
                    .HasColumnType("numeric(19, 3)")
                    .HasColumnName("trongluong");
            });

            modelBuilder.Entity<NhomHangHoa>(entity =>
            {
                entity.ToTable("NhomHangHoa");

                entity.Property(e => e.NhomHangHoaId).HasColumnName("NhomHangHoa_Id");

                entity.Property(e => e.TenFull)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenNhom)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Order_Nhom)
                    .HasColumnName("Order_Nhom");
            });

            modelBuilder.Entity<NhomTruong>(entity =>
            {
                entity.ToTable("NhomTruong");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DienThoai)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.GiayPhep)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NhomTruongName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Nhomhang>(entity =>
            {
                entity.ToTable("NHOMHANG");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NhomHang1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nhom_Hang")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenNhom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Nhom")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<NkDmhangHoa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NK_DMHangHoa");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateEdit).HasColumnType("datetime");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DVT");

                entity.Property(e => e.Giaban).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Giamua).HasColumnType("numeric(18, 3)");

                entity.Property(e => e.Loaihang)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.Mahang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Quicach)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tenhang)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserCreate).HasMaxLength(50);

                entity.Property(e => e.UserEdit).HasMaxLength(50);
            });

            modelBuilder.Entity<NkDmkhachHang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NK_DMKhachHang");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateEdit).HasColumnType("datetime");

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Dienthoai)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Loaikhach)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('2')")
                    .IsFixedLength(true);

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.Makhach)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Masothue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SoTkNh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SoTK_NH");

                entity.Property(e => e.TenNh)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ten_NH");

                entity.Property(e => e.Tenkhach)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TrangThai)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Trang_Thai")
                    .HasDefaultValueSql("('1')")
                    .IsFixedLength(true)
                    .HasComment("0- Ngừng giao dịch, 1- Hoạt động");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserEdit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'()')");
            });

            modelBuilder.Entity<NkDmtk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NK_DMTK");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Create")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DateEdit)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Edit")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DienGiai)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Dien_Giai");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MACN")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.Property(e => e.TkNhap)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TK_Nhap");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("User_Create")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserEdit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("User_Edit")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<NkInput>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NK_Input");

                entity.Property(e => e.ContractDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1900)-(1))-(1))");

                entity.Property(e => e.ContractNo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DateEdit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DienGiai)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Dien_Giai")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoaiCt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loai_CT")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKho)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Kho")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayHdVat)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayHD_VAT")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.NgayNhap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Nhap")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.NgayTk)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_TK")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.Ngoaite)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('VND')")
                    .IsFixedLength(true);

                entity.Property(e => e.NguoiNhap)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Nguoi_Nhap")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SerialVat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Serial_VAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoCt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("So_CT")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.SoHdVat)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SoHD_VAT")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Supplier)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SupplierCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Supplier_code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SystemId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SystemID")
                    .IsFixedLength(true);

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TkNhap)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TK_Nhap")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.TongThueNk)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Tong_ThueNK");

                entity.Property(e => e.TongThueTtdb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Tong_ThueTTDB");

                entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TyGia)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("Ty_Gia")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserEdit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<NkInputdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NK_Inputdetail");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Don_Gia");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("(N'()')");

                entity.Property(e => e.GiaBan1)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Gia_Ban1");

                entity.Property(e => e.GiaBan2)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Gia_Ban2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Hang")
                    .HasDefaultValueSql("(N'()')");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("So_Luong");

                entity.Property(e => e.SystemId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SystemID")
                    .IsFixedLength(true);

                entity.Property(e => e.TenHang)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ten_Hang")
                    .HasDefaultValueSql("(N'()')");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Thanh_Tien");

                entity.Property(e => e.ThueNk)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Thue_NK");

                entity.Property(e => e.ThueTtdb)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Thue_TTDB");

                entity.Property(e => e.TongTien)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Tong_Tien");
            });

            modelBuilder.Entity<NkOutput>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NK_Output");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DateEdit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Diengiai).IsRequired();

                entity.Property(e => e.HtTt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("HT_TT");

                entity.Property(e => e.LoaiHd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LoaiHD");

                entity.Property(e => e.MaTte)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaTTE");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Makhach)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Masothue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayHD");

                entity.Property(e => e.SoHd)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SoHD");

                entity.Property(e => e.Soseri)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StBangchu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ST_Bangchu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SystemId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SystemID")
                    .IsFixedLength(true);

                entity.Property(e => e.Tenkhach)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Tienhang).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tienthue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TongSl)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("TongSL");

                entity.Property(e => e.Tongtien).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Trangthai)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("0- Huy, 1- Cho in, 2- Da in");

                entity.Property(e => e.Tygia).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'()')");

                entity.Property(e => e.UserEdit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<NkOutputDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NK_Output_Detail");

                entity.Property(e => e.CheckGia).HasColumnName("Check_gia");

                entity.Property(e => e.Dongia).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DVT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mahang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Makho)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Soluong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SystemId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SystemID")
                    .IsFixedLength(true);

                entity.Property(e => e.Tenhang)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tokhai)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NkTonkhoDk>(entity =>
            {
                entity.HasKey(e => e.Identify);

                entity.ToTable("NK_Tonkho_DK");

                entity.Property(e => e.DonGia)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("Don_gia");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DVT");

                entity.Property(e => e.GiaBan1)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("Gia_ban1");

                entity.Property(e => e.GiaBan2)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("Gia_ban2");

                entity.Property(e => e.GiaTriTk)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("GiaTri_TK");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Hang");

                entity.Property(e => e.MaKho)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Kho");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("macn")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayTk)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_TK");

                entity.Property(e => e.SoluongTk)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("Soluong_TK");

                entity.Property(e => e.TenHang)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ten_Hang");

                entity.Property(e => e.TkNhap)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TK_Nhap");
            });

            modelBuilder.Entity<Noigiaohang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("noigiaohang");

                entity.Property(e => e.Isedit)
                    .HasMaxLength(10)
                    .HasColumnName("isedit")
                    .IsFixedLength(true);

                entity.Property(e => e.Ma)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ma")
                    .IsFixedLength(true);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("macn")
                    .IsFixedLength(true);

                entity.Property(e => e.Noigiao)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("noigiao");
            });

            modelBuilder.Entity<Notice>(entity =>
            {
                entity.ToTable("Notice");

                entity.Property(e => e.EntDate).HasColumnType("datetime");

                entity.Property(e => e.FileStore)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImageStore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NoticeContent)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Notify>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("notify");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Tenfull)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tenfull");

                entity.Property(e => e.Tengoi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tengoi");

                entity.Property(e => e.TimestampColumn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");
            });

            modelBuilder.Entity<NsBacdt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_BACDT");

                entity.Property(e => e.BacDt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Bac_DT");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<NsBangChamcong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_BANG_CHAMCONG");

                entity.Property(e => e.Ident00).ValueGeneratedOnAdd();

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MaNgay)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Ngay");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<NsBangluong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_BANGLUONG");

                entity.Property(e => e.Hs205)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("HS_205");

                entity.Property(e => e.Ident00).ValueGeneratedOnAdd();

                entity.Property(e => e.LuongCb)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Luong_CB");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MaThuong)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Thuong")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0- Lương hàng tháng, Mã thưởng");

                entity.Property(e => e.MaTn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Tn");

                entity.Property(e => e.NgachLuong)
                    .HasMaxLength(50)
                    .HasColumnName("Ngach_Luong");

                entity.Property(e => e.NgayCt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ct");

                entity.Property(e => e.PcTn)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PC_TN");

                entity.Property(e => e.Tien).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TinhLuong)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Tinh_Luong")
                    .HasDefaultValueSql("('C')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<NsCaLv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_CA_LV");

                entity.Property(e => e.CaLv).HasColumnName("Ca_LV");

                entity.Property(e => e.GiaRa).HasColumnName("Gia_Ra");

                entity.Property(e => e.GioVao).HasColumnName("Gio_Vao");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<NsCdkn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_CDKN");

                entity.Property(e => e.CdBks)
                    .HasMaxLength(50)
                    .HasColumnName("CD_BKS");

                entity.Property(e => e.CdHdqt)
                    .HasMaxLength(50)
                    .HasColumnName("CD_HDQT");

                entity.Property(e => e.GhiChu).HasColumnName("Ghi_Chu");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Cbnv");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Kt");

                entity.Property(e => e.NoiDungCd).HasColumnName("Noi_dung_CD");

                entity.Property(e => e.SoQdkn)
                    .HasMaxLength(50)
                    .HasColumnName("So_QDKN");

                entity.Property(e => e.TgBks).HasColumnName("TG_BKS");

                entity.Property(e => e.TgHdqt).HasColumnName("TG_HDQT");
            });

            modelBuilder.Entity<NsChuyenluong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_CHUYENLUONG");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.HlNgay1)
                    .HasColumnType("datetime")
                    .HasColumnName("HL_Ngay1");

                entity.Property(e => e.HlNgay2)
                    .HasColumnType("datetime")
                    .HasColumnName("HL_Ngay2");

                entity.Property(e => e.Hs205)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("HS_205");

                entity.Property(e => e.HtLuong)
                    .HasColumnName("HT_Luong")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsGiuLai).HasColumnName("Is_Giu_Lai");

                entity.Property(e => e.LoaiLuong).HasColumnName("Loai_Luong");

                entity.Property(e => e.LuongQc)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Luong_QC");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CBNV");

                entity.Property(e => e.Ngach205)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ngach_205");

                entity.Property(e => e.NgachQc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ngach_QC");

                entity.Property(e => e.NgayChuyen)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Chuyen");

                entity.Property(e => e.PcQc)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PC_QC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PcQc1)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PC_QC1");

                entity.Property(e => e.TyleGiuLai)
                    .HasColumnType("money")
                    .HasColumnName("Tyle_Giu_Lai");
            });

            modelBuilder.Entity<NsChuyennganh>(entity =>
            {
                entity.ToTable("NS_CHUYENNGANH");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChuyenNganh)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Chuyen_Nganh");
            });

            modelBuilder.Entity<NsChuyenpb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_CHUYENPB");

                entity.Property(e => e.CvNew)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CV_New");

                entity.Property(e => e.CvOld)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CV_Old");

                entity.Property(e => e.DenNgay)
                    .HasColumnType("date")
                    .HasColumnName("Den_ngay");

                entity.Property(e => e.DonviNew)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Donvi_New");

                entity.Property(e => e.DonviOld)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Donvi_Old");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CBNV");

                entity.Property(e => e.NgayChuyen)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Chuyen");

                entity.Property(e => e.PbNew)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PB_New");

                entity.Property(e => e.PbOld)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PB_Old");

                entity.Property(e => e.SoQd)
                    .HasMaxLength(50)
                    .HasColumnName("So_QD");

                entity.Property(e => e.TenCvNew)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_CV_New");

                entity.Property(e => e.TenCvOld)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_CV_Old");

                entity.Property(e => e.TenDvNew)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Dv_New");

                entity.Property(e => e.TenDvOld)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Dv_Old");

                entity.Property(e => e.TenPbNew)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_PB_New");

                entity.Property(e => e.TenPbOld)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_PB_Old");

                entity.Property(e => e.TuNgay)
                    .HasColumnType("date")
                    .HasColumnName("Tu_Ngay");
            });

            modelBuilder.Entity<NsCongdoan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_CONGDOAN");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Cbnv");

                entity.Property(e => e.MaThe)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_The");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Cap");

                entity.Property(e => e.NgayVao)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Vao");

                entity.Property(e => e.NoiVao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Vao");

                entity.Property(e => e.TrucThuoc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Truc_Thuoc");
            });

            modelBuilder.Entity<NsCongtac>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_CONGTAC");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CBNV");

                entity.Property(e => e.NgayDi)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Di");

                entity.Property(e => e.NgayVe)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ve");

                entity.Property(e => e.NhiemVu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Nhiem_Vu");

                entity.Property(e => e.NoiCt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Noi_CT");
            });

            modelBuilder.Entity<NsDangKyPhep>(entity =>
            {
                entity.ToTable("NS_DangKyPhep");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ToDate).HasColumnType("date");
            });

            modelBuilder.Entity<NsDangvien>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DANGVIEN");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Cbnv");

                entity.Property(e => e.MaThe)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_The");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Cap");

                entity.Property(e => e.NgayDb)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_DB");

                entity.Property(e => e.NgayVao)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Vao");

                entity.Property(e => e.NoiSh)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Noi_SH");

                entity.Property(e => e.NoiVao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Vao");
            });

            modelBuilder.Entity<NsDanhGiaCbnv>(entity =>
            {
                entity.HasKey(e => e.Stt);

                entity.ToTable("NS_DanhGia_CBNV");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu");

                entity.Property(e => e.ClcvCt1).HasColumnName("CLCV_CT1");

                entity.Property(e => e.ClcvCt2).HasColumnName("CLCV_CT2");

                entity.Property(e => e.ClcvCt3).HasColumnName("CLCV_CT3");

                entity.Property(e => e.KlcvCt1).HasColumnName("KLCV_CT1");

                entity.Property(e => e.KlcvCt2).HasColumnName("KLCV_CT2");

                entity.Property(e => e.KlcvCt3).HasColumnName("KLCV_CT3");

                entity.Property(e => e.MaCbNv)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.Macn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NqcvCt1).HasColumnName("NQCV_CT1");

                entity.Property(e => e.NqcvCt2).HasColumnName("NQCV_CT2");

                entity.Property(e => e.NqcvCt3).HasColumnName("NQCV_CT3");

                entity.Property(e => e.TdcvCt1).HasColumnName("TDCV_CT1");

                entity.Property(e => e.TdcvCt2).HasColumnName("TDCV_CT2");

                entity.Property(e => e.TdcvCt3).HasColumnName("TDCV_CT3");

                entity.Property(e => e.TenCbNv)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_CbNv");

                entity.Property(e => e.TglvCt1).HasColumnName("TGLV_CT1");

                entity.Property(e => e.TglvCt2).HasColumnName("TGLV_CT2");

                entity.Property(e => e.TglvCt3).HasColumnName("TGLV_CT3");
            });

            modelBuilder.Entity<NsDlChamcong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DL_Chamcong");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Cbnv");

                entity.Property(e => e.MaCc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_CC");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayTgRa)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_TG_Ra");

                entity.Property(e => e.NgayTgVao)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_TG_Vao");
            });

            modelBuilder.Entity<NsDmChamcong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DM_CHAMCONG");

                entity.Property(e => e.CongThuc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Cong_Thuc");

                entity.Property(e => e.Display)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.MaNgay)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Ngay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ngay).HasColumnType("date");

                entity.Property(e => e.SttColumn).HasColumnName("Stt_Column");

                entity.Property(e => e.TenNgay)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Ngay");

                entity.Property(e => e.TypeFormat)
                    .HasMaxLength(10)
                    .HasColumnName("Type_Format")
                    .IsFixedLength(true);

                entity.Property(e => e.WColumn).HasColumnName("W_Column");
            });

            modelBuilder.Entity<NsDmNgaycong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DM_NGAYCONG");

                entity.Property(e => e.IsKey).HasComment("Khoa bang luong");

                entity.Property(e => e.IsKeyCc)
                    .HasColumnName("IsKey_CC")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Khoa bang cham cong");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.SoNgay)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("So_Ngay");
            });

            modelBuilder.Entity<NsDmThuong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DM_THUONG");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MaThuong)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Thuong");

                entity.Property(e => e.NgayThuong)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Thuong");

                entity.Property(e => e.NoiDung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Dung");
            });

            modelBuilder.Entity<NsDmbp>(entity =>
            {
                entity.ToTable("NS_DMBP");

                entity.Property(e => e.CreateLog)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("Create_Log");

                entity.Property(e => e.LastModifyLog)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("LastModify_Log");

                entity.Property(e => e.MaBp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaBpCha)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Bp_Cha");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Data");

                entity.Property(e => e.NgayBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Begin");

                entity.Property(e => e.NgayEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_End");

                entity.Property(e => e.NhCuoi).HasColumnName("Nh_Cuoi");

                entity.Property(e => e.SttBp)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Stt_Bp");

                entity.Property(e => e.TenBp)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Bp");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<NsDmcbnv>(entity =>
            {
                entity.HasKey(e => e.MaCbNv);

                entity.ToTable("NS_DMCBNV");

                entity.Property(e => e.MaCbNv)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.AnHien)
                    .HasColumnName("An_Hien")
                    .HasComment("1-Không hiện bảng lương, 0-Hiện bảng lương");

                entity.Property(e => e.AnHienTu).HasColumnName("An_Hien_TU");

                entity.Property(e => e.BiDanh)
                    .HasMaxLength(50)
                    .HasColumnName("Bi_Danh");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu");

                entity.Property(e => e.CmNv)
                    .HasMaxLength(255)
                    .HasColumnName("CM_NV");

                entity.Property(e => e.CongViec)
                    .HasMaxLength(1000)
                    .HasColumnName("Cong_Viec");

                entity.Property(e => e.DanToc)
                    .HasMaxLength(50)
                    .HasColumnName("Dan_Toc");

                entity.Property(e => e.DcHn)
                    .HasMaxLength(255)
                    .HasColumnName("DC_HN");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_Chi");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");

                entity.Property(e => e.HandPhone)
                    .HasMaxLength(255)
                    .HasColumnName("Hand_Phone");

                entity.Property(e => e.Hinh).HasMaxLength(50);

                entity.Property(e => e.IdNs)
                    .HasMaxLength(10)
                    .HasColumnName("ID_NS")
                    .IsFixedLength(true);

                entity.Property(e => e.KhongCc).HasColumnName("Khong_CC");

                entity.Property(e => e.LanhDao)
                    .HasColumnName("Lanh_dao")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LdNghiviec)
                    .HasMaxLength(255)
                    .HasColumnName("LD_Nghiviec");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaCaLv)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Ca_LV")
                    .HasDefaultValueSql("('HC')");

                entity.Property(e => e.MaData)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("(N'*')");

                entity.Property(e => e.MaMayCc)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_May_CC");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_So_Thue");

                entity.Property(e => e.Macn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Member_ID");

                entity.Property(e => e.NganHang)
                    .HasMaxLength(100)
                    .HasColumnName("Ngan_Hang");

                entity.Property(e => e.NgayBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Begin");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Cap");

                entity.Property(e => e.NgayEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_End");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Sinh");

                entity.Property(e => e.NgaycapHc)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngaycap_HC");

                entity.Property(e => e.NguyenQuan)
                    .HasMaxLength(255)
                    .HasColumnName("Nguyen_Quan");

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap");

                entity.Property(e => e.NoiSinh)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Sinh");

                entity.Property(e => e.NoicapHc)
                    .HasMaxLength(50)
                    .HasColumnName("Noicap_HC");

                entity.Property(e => e.QuocTich)
                    .HasMaxLength(50)
                    .HasColumnName("Quoc_Tich");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("So_CMND");

                entity.Property(e => e.SoHc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("So_HC");

                entity.Property(e => e.SoPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("So_Phone");

                entity.Property(e => e.SoQdNv)
                    .HasMaxLength(50)
                    .HasColumnName("SoQD_NV");

                entity.Property(e => e.SoTk)
                    .HasMaxLength(50)
                    .HasColumnName("So_Tk");

                entity.Property(e => e.Stt)
                    .HasColumnName("STT")
                    .HasDefaultValueSql("((500))");

                entity.Property(e => e.TdHv)
                    .HasMaxLength(20)
                    .HasColumnName("TD_HV");

                entity.Property(e => e.TdNn)
                    .HasMaxLength(20)
                    .HasColumnName("TD_NN");

                entity.Property(e => e.TdTh)
                    .HasMaxLength(20)
                    .HasColumnName("TD_TH");

                entity.Property(e => e.TdVh)
                    .HasMaxLength(20)
                    .HasColumnName("TD_VH");

                entity.Property(e => e.TenCbNv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_CbNv");

                entity.Property(e => e.TenTat)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Tat");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TinhTrangHn)
                    .HasMaxLength(30)
                    .HasColumnName("Tinh_Trang_HN");

                entity.Property(e => e.TonGiao)
                    .HasMaxLength(50)
                    .HasColumnName("Ton_Giao");

                entity.Property(e => e.TrangThai)
                    .HasColumnName("Trang_Thai")
                    .HasComment("0 - Nghi viec, 1- Lam viec");

                entity.Property(e => e.UserCreate)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("User_Create");

                entity.Property(e => e.UserEdit)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("User_Edit");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<NsDmchucvu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DMCHUCVU");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.MaChucvu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ma_chucvu");

                entity.Property(e => e.TenChucvu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ten_Chucvu");
            });

            modelBuilder.Entity<NsDmdantoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DMDANTOC");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.MaDantoc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ma_dantoc");

                entity.Property(e => e.TenDantoc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ten_dantoc");
            });

            modelBuilder.Entity<NsDmdvc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DMDVCS");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Data");

                entity.Property(e => e.MaDvCs)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Ma_DvCs");

                entity.Property(e => e.MaTh)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Ma_TH")
                    .IsFixedLength(true);

                entity.Property(e => e.TenDvCs)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_DvCs");
            });

            modelBuilder.Entity<NsDmgiamtru>(entity =>
            {
                entity.ToTable("NS_DMGIAMTRU");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GtBanthan)
                    .HasColumnType("money")
                    .HasColumnName("GT_Banthan");

                entity.Property(e => e.GtPhuthuoc)
                    .HasColumnType("money")
                    .HasColumnName("GT_Phuthuoc");

                entity.Property(e => e.NgayAd)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_AD");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_KT");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<NsDmloaihd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DMLOAIHD");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.LoaiHd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Loai_HD");

                entity.Property(e => e.MaLoai)
                    .HasColumnName("Ma_Loai")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<NsDmphepNam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DMPHEP_NAM");

                entity.Property(e => e.CongThuc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Cong_Thuc");

                entity.Property(e => e.DataType)
                    .HasMaxLength(50)
                    .HasColumnName("Data_Type");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.LoaiPhep)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loai_Phep");

                entity.Property(e => e.MaCn)
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MaNPhep)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_N_Phep");

                entity.Property(e => e.SttColumn).HasColumnName("Stt_Column");

                entity.Property(e => e.TenNPhep)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_N_Phep");

                entity.Property(e => e.TypeFormat)
                    .HasMaxLength(10)
                    .HasColumnName("Type_Format")
                    .IsFixedLength(true);

                entity.Property(e => e.WColumn).HasColumnName("W_Column");
            });

            modelBuilder.Entity<NsDmtd>(entity =>
            {
                entity.HasKey(e => e.MaTd);

                entity.ToTable("NS_DMTD");

                entity.Property(e => e.MaTd)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_TD");

                entity.Property(e => e.DienGiai)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dien_Giai");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoaiTd)
                    .HasColumnName("Loai_TD")
                    .HasComment("0-Chưa ĐT, 1-CNKT, 2-TCCN, 3-CĐ, 4-ĐH, 5-Trên ĐH, 6-Ngoại ngữ, 7-Tin học");

                entity.Property(e => e.SttBc).HasColumnName("Stt_Bc");
            });

            modelBuilder.Entity<NsDmthuetn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DMTHUETN");

                entity.Property(e => e.BangThue)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Bang_Thue");

                entity.Property(e => e.Ident00).ValueGeneratedOnAdd();

                entity.Property(e => e.MucTn1)
                    .HasColumnType("money")
                    .HasColumnName("Muc_Tn1");

                entity.Property(e => e.MucTn2)
                    .HasColumnType("money")
                    .HasColumnName("Muc_Tn2");

                entity.Property(e => e.TyLe)
                    .HasColumnType("money")
                    .HasColumnName("Ty_Le");
            });

            modelBuilder.Entity<NsDmtknh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DMTKNH");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaKhach)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_khach");

                entity.Property(e => e.SoTkNh)
                    .HasMaxLength(50)
                    .HasColumnName("So_TK_NH");

                entity.Property(e => e.TenNh)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_NH");

                entity.Property(e => e.TinhTp)
                    .HasMaxLength(50)
                    .HasColumnName("Tinh_TP");
            });

            modelBuilder.Entity<NsDmtn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DMTN");

                entity.Property(e => e.CongThuc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Cong_Thuc");

                entity.Property(e => e.Display)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.LoaiTn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loai_Tn");

                entity.Property(e => e.MaCn)
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MaTn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Tn");

                entity.Property(e => e.SttColumn).HasColumnName("Stt_Column");

                entity.Property(e => e.TenTn)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Tn");

                entity.Property(e => e.TypeFormat)
                    .HasMaxLength(10)
                    .HasColumnName("Type_Format")
                    .IsFixedLength(true);

                entity.Property(e => e.WColumn).HasColumnName("W_Column");
            });

            modelBuilder.Entity<NsDmtongiao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DMTONGIAO");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.MaTongiao)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ma_tongiao");

                entity.Property(e => e.TenTongiao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ten_tongiao");
            });

            modelBuilder.Entity<NsDoanvien>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DOANVIEN");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Cbnv");

                entity.Property(e => e.MaThe)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_The");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Cap");

                entity.Property(e => e.NgayVao)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Vao");

                entity.Property(e => e.NoiSh)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Noi_SH");

                entity.Property(e => e.NoiVao)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Vao");
            });

            modelBuilder.Entity<NsDotTd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DOT_TD");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.KtTd).HasColumnName("KT_TD");

                entity.Property(e => e.MaDot)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Dot");

                entity.Property(e => e.NgayChotHs)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Chot_HS");

                entity.Property(e => e.NgayNhanHs)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Nhan_HS");

                entity.Property(e => e.NgayPv)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_PV");

                entity.Property(e => e.TenDotTd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Dot_TD");
            });

            modelBuilder.Entity<NsDsTuyendung>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DS_TUYENDUNG");

                entity.Property(e => e.CanNang)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("Can_Nang")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChieuCao)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("Chieu_Cao")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChuyenNganh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Chuyen_Nganh")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CongViec)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Cong_Viec")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DanToc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dan_Toc")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DateEdit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DiDong)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Di_Dong")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Dia_Chi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DienThoai)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dien_Thoai")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DotTd)
                    .HasMaxLength(20)
                    .HasColumnName("Dot_TD");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");

                entity.Property(e => e.Hinh)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("ID")
                    .IsFixedLength(true);

                entity.Property(e => e.KinhNghiem)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Kinh_Nghiem")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaUv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_UV");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MlMm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("ML_MM");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Cap")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayNop)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Nop")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Sinh")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(100)
                    .HasColumnName("Noi_Cap")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoiSinh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Noi_Sinh")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.QuocTich)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Quoc_Tich")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(50)
                    .HasColumnName("So_CMND")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TamTru)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Tam_Tru")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TdHv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TD_HV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TdNn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TD_NN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TdTh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TD_TH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenUv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ten_UV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TonGiao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ton_Giao")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TtHn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TT_HN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TtSk)
                    .HasMaxLength(100)
                    .HasColumnName("TT_SK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserCreate)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserEdit)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<NsDsVpcty1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_DS_VPCTY1");

                entity.Property(e => e.Benhvien).HasMaxLength(255);

                entity.Property(e => e.ChucDanh).HasMaxLength(255);

                entity.Property(e => e.ChuyenNganh)
                    .HasMaxLength(255)
                    .HasColumnName("Chuyen_Nganh");

                entity.Property(e => e.Congviec).HasMaxLength(255);

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_chi");

                entity.Property(e => e.Didong).HasMaxLength(255);

                entity.Property(e => e.Donvi).HasMaxLength(255);

                entity.Property(e => e.DtNha).HasColumnName("DT_Nha");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Gioitinh).HasMaxLength(255);

                entity.Property(e => e.HeDt)
                    .HasMaxLength(255)
                    .HasColumnName("He_DT");

                entity.Property(e => e.Hovaten).HasMaxLength(255);

                entity.Property(e => e.Hs205).HasColumnName("HS_205");

                entity.Property(e => e.IdNs)
                    .HasMaxLength(255)
                    .HasColumnName("ID_NS");

                entity.Property(e => e.Kiemnhiem).HasMaxLength(255);

                entity.Property(e => e.Lanhdao).HasMaxLength(255);

                entity.Property(e => e.MaBp)
                    .HasMaxLength(255)
                    .HasColumnName("MaBP");

                entity.Property(e => e.MaCbnv)
                    .HasMaxLength(255)
                    .HasColumnName("MaCBNV");

                entity.Property(e => e.MaTinh)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Tinh");

                entity.Property(e => e.MlKhoan)
                    .HasMaxLength(255)
                    .HasColumnName("ML_Khoan");

                entity.Property(e => e.MlQc).HasColumnName("ML_QC");

                entity.Property(e => e.MstTncn)
                    .HasMaxLength(255)
                    .HasColumnName("MST_TNCN");

                entity.Property(e => e.Ngach205)
                    .HasMaxLength(255)
                    .HasColumnName("Ngach_205");

                entity.Property(e => e.NgachQc)
                    .HasMaxLength(255)
                    .HasColumnName("Ngach_QC");

                entity.Property(e => e.Ngay1Hs205)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay1_HS205");

                entity.Property(e => e.Ngay1Qc)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay1_QC");

                entity.Property(e => e.Ngay1n1)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_1N1");

                entity.Property(e => e.Ngay1n2)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_1N2");

                entity.Property(e => e.Ngay2Hs205)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay2_HS205");

                entity.Property(e => e.Ngay2Qc)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay2_QC");

                entity.Property(e => e.Ngay3n1)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_3N1");

                entity.Property(e => e.Ngay3n2)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_3N2");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Cap");

                entity.Property(e => e.NgayKhoan1)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_Khoan1");

                entity.Property(e => e.NgayKhoan2)
                    .HasMaxLength(255)
                    .HasColumnName("Ngay_khoan2");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_KT");

                entity.Property(e => e.NgayLv)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayLV");

                entity.Property(e => e.NgayOxd1)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_OXD1");

                entity.Property(e => e.Ngaysinh).HasColumnType("datetime");

                entity.Property(e => e.Nguyenquan).HasMaxLength(255);

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap");

                entity.Property(e => e.Noisinh).HasMaxLength(255);

                entity.Property(e => e.PcQc).HasColumnName("PC_QC");

                entity.Property(e => e.SoBhxh)
                    .HasMaxLength(255)
                    .HasColumnName("So_BHXH");

                entity.Property(e => e.SoBhyt)
                    .HasMaxLength(255)
                    .HasColumnName("So_BHYT");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(255)
                    .HasColumnName("So_CMND");

                entity.Property(e => e.TamTru)
                    .HasMaxLength(255)
                    .HasColumnName("Tam_Tru");

                entity.Property(e => e.TdCm)
                    .HasMaxLength(255)
                    .HasColumnName("TD_CM");

                entity.Property(e => e.TdNn)
                    .HasMaxLength(255)
                    .HasColumnName("TD_NN");

                entity.Property(e => e.TdTh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_TH");

                entity.Property(e => e.TdVh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_VH");

                entity.Property(e => e.TruongDt)
                    .HasMaxLength(255)
                    .HasColumnName("Truong_DT");
            });

            modelBuilder.Entity<NsDulieu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_Dulieu$");

                entity.Property(e => e.Bv).HasColumnName("BV");

                entity.Property(e => e.ChiNhanh).HasMaxLength(255);

                entity.Property(e => e.Chucdanh).HasMaxLength(255);

                entity.Property(e => e.ChuyenNganh)
                    .HasMaxLength(255)
                    .HasColumnName("Chuyen_Nganh");

                entity.Property(e => e.CongviecChinh)
                    .HasMaxLength(255)
                    .HasColumnName("Congviec_Chinh");

                entity.Property(e => e.Dantoc).HasMaxLength(255);

                entity.Property(e => e.DcTamt)
                    .HasMaxLength(255)
                    .HasColumnName("DC_TAMT");

                entity.Property(e => e.DcTt)
                    .HasMaxLength(255)
                    .HasColumnName("DC_TT");

                entity.Property(e => e.DtNha).HasColumnName("DT_Nha");

                entity.Property(e => e.Dtll)
                    .HasMaxLength(255)
                    .HasColumnName("DTLL");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.GhiChu1)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu1");

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(255)
                    .HasColumnName("Gioi_Tinh");

                entity.Property(e => e.HeDt)
                    .HasMaxLength(255)
                    .HasColumnName("He_DT");

                entity.Property(e => e.LkNgay1)
                    .HasMaxLength(255)
                    .HasColumnName("LK_Ngay1");

                entity.Property(e => e.LkNgay2)
                    .HasMaxLength(255)
                    .HasColumnName("LK_Ngay2");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaCbnv)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_CBNV");

                entity.Property(e => e.Mst)
                    .HasMaxLength(255)
                    .HasColumnName("MST");

                entity.Property(e => e.MucLk)
                    .HasMaxLength(255)
                    .HasColumnName("Muc_LK");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Cap");

                entity.Property(e => e.NgayEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_End");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Sinh");

                entity.Property(e => e.NgayvaoCty)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngayvao_Cty");

                entity.Property(e => e.Nguyenquan).HasMaxLength(255);

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap");

                entity.Property(e => e.NoiSinh)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Sinh");

                entity.Property(e => e.OxdNgay1)
                    .HasColumnType("datetime")
                    .HasColumnName("OXD_Ngay1");

                entity.Property(e => e.OxdNgay2)
                    .HasMaxLength(255)
                    .HasColumnName("OXD_Ngay2");

                entity.Property(e => e.SoBhxh)
                    .HasMaxLength(255)
                    .HasColumnName("So_BHXH");

                entity.Property(e => e.SoBhyt).HasColumnName("So_BHYT");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(255)
                    .HasColumnName("So_CMND");

                entity.Property(e => e.Stt)
                    .HasMaxLength(255)
                    .HasColumnName("STT");

                entity.Property(e => e.TdHv)
                    .HasMaxLength(255)
                    .HasColumnName("TD_HV");

                entity.Property(e => e.TdNn)
                    .HasMaxLength(255)
                    .HasColumnName("TD_NN");

                entity.Property(e => e.TdTh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_TH");

                entity.Property(e => e.TdVh)
                    .HasMaxLength(255)
                    .HasColumnName("TD_VH");

                entity.Property(e => e.TenCbnv)
                    .HasMaxLength(255)
                    .HasColumnName("Ten_Cbnv");

                entity.Property(e => e.Tongiao).HasMaxLength(255);

                entity.Property(e => e.TruongDt)
                    .HasMaxLength(255)
                    .HasColumnName("Truong_DT");

                entity.Property(e => e.TvNgay1)
                    .HasColumnType("datetime")
                    .HasColumnName("TV_Ngay1");

                entity.Property(e => e.TvNgay2)
                    .HasColumnType("datetime")
                    .HasColumnName("TV_Ngay2");

                entity.Property(e => e.VvNgay1)
                    .HasColumnType("datetime")
                    .HasColumnName("VV_Ngay1");

                entity.Property(e => e.VvNgay2)
                    .HasColumnType("datetime")
                    .HasColumnName("VV_Ngay2");

                entity.Property(e => e._1nNgay1)
                    .HasColumnType("datetime")
                    .HasColumnName("1N_Ngay1");

                entity.Property(e => e._1nNgay2)
                    .HasColumnType("datetime")
                    .HasColumnName("1N_Ngay2");

                entity.Property(e => e._3nNgay1)
                    .HasColumnType("datetime")
                    .HasColumnName("3N_Ngay1");

                entity.Property(e => e._3nNgay2)
                    .HasColumnType("datetime")
                    .HasColumnName("3N_Ngay2");
            });

            modelBuilder.Entity<NsHdld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_HDLD");

                entity.Property(e => e.BacLuong)
                    .HasMaxLength(20)
                    .HasColumnName("Bac_Luong")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CheDoLamViec)
                    .HasMaxLength(250)
                    .HasColumnName("Che_Do_Lam_Viec");

                entity.Property(e => e.ChucDanh)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Danh");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.HsLuong)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("HS_Luong");

                entity.Property(e => e.HtTraluong)
                    .HasMaxLength(50)
                    .HasColumnName("HT_Traluong")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ident00).ValueGeneratedOnAdd();

                entity.Property(e => e.LoaiHd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Loai_Hd");

                entity.Property(e => e.LuongCb)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Luong_CB");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.NgachLuong)
                    .HasMaxLength(20)
                    .HasColumnName("Ngach_Luong");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayChamDut)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Cham_Dut")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Kt");

                entity.Property(e => e.NgayKy)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ky");

                entity.Property(e => e.NguoiKy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nguoi_Ky");

                entity.Property(e => e.NoiDungCv).HasColumnName("Noi_Dung_CV");

                entity.Property(e => e.NoiLv)
                    .HasMaxLength(250)
                    .HasColumnName("Noi_LV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PcQc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PC_QC");

                entity.Property(e => e.PcQc1)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("PC_QC1");

                entity.Property(e => e.SoHd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("So_Hd");
            });

            modelBuilder.Entity<NsHospital>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_HOSPITAL");

                entity.Property(e => e.DiaChiBv)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Dia_Chi_Bv");

                entity.Property(e => e.MaBv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Bv");

                entity.Property(e => e.MaKv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Kv");

                entity.Property(e => e.TenBv)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("Ten_Bv");
            });

            modelBuilder.Entity<NsKetquaPv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_KETQUA_PV");

                entity.Property(e => e.DChuyenmon)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("D_Chuyenmon");

                entity.Property(e => e.DKinhnghiem)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("D_Kinhnghiem");

                entity.Property(e => e.DKynang)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("D_Kynang");

                entity.Property(e => e.DNgoaihinh)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("D_Ngoaihinh");

                entity.Property(e => e.DNgoaingu)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("D_Ngoaingu");

                entity.Property(e => e.DPhongcach)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("D_Phongcach");

                entity.Property(e => e.DTinhoc)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("D_Tinhoc");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DateEdit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DiaDiemPv)
                    .HasMaxLength(100)
                    .HasColumnName("DiaDiem_PV");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.KqLan)
                    .HasColumnName("KQ_Lan")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaUv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_UV");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.TgPv)
                    .HasMaxLength(50)
                    .HasColumnName("TG_PV");

                entity.Property(e => e.ThanhvienPv)
                    .HasMaxLength(100)
                    .HasColumnName("Thanhvien_PV");

                entity.Property(e => e.UserCreate)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserEdit)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<NsLdtd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_LDTD");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LydoTd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Lydo_TD");
            });

            modelBuilder.Entity<NsLoaiCv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_LOAI_CV");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoaiCv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Loai_CV")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<NsLoaiPhep>(entity =>
            {
                entity.ToTable("NS_LoaiPhep");

                entity.Property(e => e.LoaiPhep)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<NsNgach205>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_NGACH205");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Hs205)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("HS_205");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoaiLuong).HasColumnName("Loai_Luong");

                entity.Property(e => e.LuongNew)
                    .HasColumnType("money")
                    .HasColumnName("Luong_New");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.Ngach205)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ngach_205");

                entity.Property(e => e.NgachNew)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ngach_New")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayAd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_AD");
            });

            modelBuilder.Entity<NsNgachluong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_NGACHLUONG");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoaiLuong).HasColumnName("Loai_Luong");

                entity.Property(e => e.LuongCb)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Luong_CB");

                entity.Property(e => e.LuongNew)
                    .HasColumnType("money")
                    .HasColumnName("Luong_New");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.NgachLuong)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ngach_Luong");

                entity.Property(e => e.NgachNew)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ngach_New")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayAd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_AD");
            });

            modelBuilder.Entity<NsNghiphep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_NGHIPHEP");

                entity.Property(e => e.CoPhep).HasColumnName("Co_Phep");

                entity.Property(e => e.CoTinhLuong).HasColumnName("Co_Tinh_Luong");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.LoaiPhep)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Loai_Phep");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Kt");

                entity.Property(e => e.NgayKy)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ky");

                entity.Property(e => e.NguoiDuyet)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nguoi_Duyet");

                entity.Property(e => e.NoiDung)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Noi_Dung");

                entity.Property(e => e.SoNgayNghi)
                    .HasColumnType("money")
                    .HasColumnName("So_Ngay_Nghi");
            });

            modelBuilder.Entity<NsPhepNam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_PHEP_NAM");

                entity.Property(e => e.Ident00).ValueGeneratedOnAdd();

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MaNPhep)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_N_PHEP");

                entity.Property(e => e.SoNgay)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("So_Ngay");
            });

            modelBuilder.Entity<NsQhgd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_QHGD");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(100)
                    .HasColumnName("Dia_Chi");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.GiamTru).HasColumnName("Giam_Tru");

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ho_Ten");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoaiQhgd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Loai_QHGD");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.NNghiep)
                    .IsRequired()
                    .HasMaxLength(28)
                    .HasColumnName("N_Nghiep");

                entity.Property(e => e.NamSinh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Nam_Sinh");
            });

            modelBuilder.Entity<NsQtct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_QTCT");

                entity.Property(e => e.BoPhan)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ChucDanh)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Chuc_Danh");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Dia_Chi");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Cbnv");

                entity.Property(e => e.MucLuong)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Muc_Luong");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Kt");

                entity.Property(e => e.TenCq)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_CQ");
            });

            modelBuilder.Entity<NsQtdt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_QTDT");

                entity.Property(e => e.DatLoai)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dat_Loai");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IdBachoc).HasColumnName("ID_BACHOC");

                entity.Property(e => e.IdCm).HasColumnName("ID_CM");

                entity.Property(e => e.KhoaHoc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Khoa_Hoc");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Kt");

                entity.Property(e => e.NoiDt).HasColumnName("Noi_DT");

                entity.Property(e => e.TruongHoc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Truong_Hoc");

                entity.Property(e => e.VanBang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Van_Bang");
            });

            modelBuilder.Entity<NsQtktkl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_QTKTKL");

                entity.Property(e => e.HinhThuc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Hinh_Thuc");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoaiKtkl)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Loai_KTKL")
                    .IsFixedLength(true);

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.NgayHl)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_HL");

                entity.Property(e => e.NgayQd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_QD");

                entity.Property(e => e.NguoiKy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nguoi_Ky");

                entity.Property(e => e.NoiDung)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Noi_Dung");

                entity.Property(e => e.SoQd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("So_QD");
            });

            modelBuilder.Entity<NsTamung>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_TAMUNG");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.LydoTu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Lydo_TU");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CBNV");

                entity.Property(e => e.NgayTu)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_TU");

                entity.Property(e => e.NguoiKyTu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nguoi_Ky_TU");

                entity.Property(e => e.SotienTu)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Sotien_TU");
            });

            modelBuilder.Entity<NsTblFilename>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_Tbl_Filename");

                entity.Property(e => e.FilenameCha)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Filename_Cha");

                entity.Property(e => e.FilenameCon)
                    .HasMaxLength(50)
                    .HasColumnName("Filename_Con");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsUpdate).HasColumnName("Is_update");

                entity.Property(e => e.TblnameCha)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Tblname_Cha");

                entity.Property(e => e.TblnameCon)
                    .HasMaxLength(50)
                    .HasColumnName("Tblname_Con");
            });

            modelBuilder.Entity<NsTsluong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_TSLUONG");

                entity.Property(e => e.HeSo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("He_So");

                entity.Property(e => e.Ident00).ValueGeneratedOnAdd();

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SoTien)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("So_Tien");

                entity.Property(e => e.ThangAd).HasColumnName("Thang_Ad");
            });

            modelBuilder.Entity<NsTstn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_TSTN");

                entity.Property(e => e.Ident00).ValueGeneratedOnAdd();

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MaTn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Tn");

                entity.Property(e => e.MucAp)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Muc_Ap");

                entity.Property(e => e.NgayAp)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ap");

                entity.Property(e => e.NoiDung)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Noi_Dung")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<NsTstn0>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_TSTN0");

                entity.Property(e => e.IsUuTien).HasColumnName("Is_UuTien");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.MaCn)
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MaTn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Tn");

                entity.Property(e => e.NgayTh)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_TH");

                entity.Property(e => e.Tien).HasColumnType("money");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NsTtBaohiem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_TT_BAOHIEM");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.KcbBv)
                    .HasMaxLength(50)
                    .HasColumnName("KCB_BV");

                entity.Property(e => e.KcbTinh)
                    .HasMaxLength(50)
                    .HasColumnName("KCB_Tinh");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Cbnv");

                entity.Property(e => e.NgayBhtn)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_BHTN");

                entity.Property(e => e.NgayDpcd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_DPCD");

                entity.Property(e => e.NgayKtBhxh)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKT_BHXH");

                entity.Property(e => e.NgayKtBhyt)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKT_BHYT");

                entity.Property(e => e.NgaycapBhxh)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngaycap_BHXH");

                entity.Property(e => e.NgaycapBhyt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngaycap_BHYT");

                entity.Property(e => e.NoicapBhxh)
                    .HasMaxLength(50)
                    .HasColumnName("Noicap_BHXH");

                entity.Property(e => e.SoBhxh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SO_BHXH");

                entity.Property(e => e.SoBhyt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SO_BHYT");

                entity.Property(e => e.TgBhtn).HasColumnName("TG_BHTN");

                entity.Property(e => e.TgBhxh)
                    .IsRequired()
                    .HasColumnName("TG_BHXH")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TgBhyt)
                    .IsRequired()
                    .HasColumnName("TG_BHYT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TgKpcd)
                    .IsRequired()
                    .HasColumnName("TG_KPCD")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<NsTtBhyt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_TT_BHYT");

                entity.Property(e => e.BacLuong)
                    .HasMaxLength(20)
                    .HasColumnName("Bac_Luong");

                entity.Property(e => e.DongBhCk).HasColumnName("Dong_BH_CK");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.KcbBv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("KCB_BV");

                entity.Property(e => e.KcbTinh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("KCB_Tinh");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Cbnv");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_KT");

                entity.Property(e => e.SoBhyt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SO_BHYT");

                entity.Property(e => e.TyleNopBh)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("Tyle_Nop_BH");
            });

            modelBuilder.Entity<NsVanbang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_VANBANG");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.VanBang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Van_Bang");
            });

            modelBuilder.Entity<NsVitriTd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_VITRI_TD");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DonviTd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Donvi_TD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaChucvu)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Chucvu");

                entity.Property(e => e.MaCn)
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.MaUv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_UV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MucLuong)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Muc_Luong");

                entity.Property(e => e.PbTd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PB_TD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoYc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("So_YC")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<NsYcTuyendung>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NS_YC_TUYENDUNG");

                entity.Property(e => e.BangCap)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Bang_Cap")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Chuc_Vu");

                entity.Property(e => e.ChuyenMon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Chuyen_Mon")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DangNv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Dang_NV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DateEdit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.GioiTinh)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Gioi_Tinh")
                    .HasDefaultValueSql("((1))")
                    .HasComment("");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LoaiCv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Loai_CV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LydoTuyen)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Lydo_Tuyen")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaBp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'INX')")
                    .IsFixedLength(true);

                entity.Property(e => e.NamKn).HasColumnName("Nam_KN");

                entity.Property(e => e.NgayTd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_TD")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.NgayYc)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_YC")
                    .HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.SoLuong)
                    .HasColumnName("So_Luong")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SoYc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("So_YC");

                entity.Property(e => e.TdNn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TD_NN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TdTh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TD_TH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TruongHoc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Truong_Hoc")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserEdit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.XepLoai)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Xep_loai")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.YcKhac)
                    .HasMaxLength(255)
                    .HasColumnName("YC_Khac");
            });

            modelBuilder.Entity<OutputDetail>(entity =>
            {
                entity.ToTable("OutputDetail");

                entity.Property(e => e.OutputDetailId).HasMaxLength(255);

                entity.Property(e => e.ChiPhi).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("GW");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemCodeOutputReal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ItemNameOutputReal)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kcsid).HasColumnName("KCSId");

                entity.Property(e => e.Kcsnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("KCSNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoaiBao)
                    .HasColumnName("loai_bao")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutputStockId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitOutputReal)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.OutputStock)
                    .WithMany(p => p.OutputDetails)
                    .HasForeignKey(d => d.OutputStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutputDetail_OutputStock");
            });

            modelBuilder.Entity<OutputStock>(entity =>
            {
                entity.ToTable("OutputStock");

                entity.Property(e => e.OutputStockId).HasMaxLength(255);

                entity.Property(e => e.CanId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Collate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CollateId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContractIdSource)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateConfirm).HasColumnType("datetime");

                entity.Property(e => e.DvNhan)
                    .HasMaxLength(250)
                    .HasColumnName("dv_nhan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EntDate).HasColumnType("date");

                entity.Property(e => e.IsOuputTp).HasColumnName("IsOuputTP");

                entity.Property(e => e.IsProduce).HasComment("0: Xuất gia công; 1: xuất sản xuất");

                entity.Property(e => e.LenhXuat)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("lenh_xuat")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaKh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Kh")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("macn")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OutputNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OutputTypeName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("0: Nhập; 1: Xuất");

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PlaceExchange)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SeriOutputTp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SeriOutputTP")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Stock)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StockCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ten_Kh")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserConfirm).HasMaxLength(50);

                entity.Property(e => e.XeVc)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("xe_vc")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PairedPlan>(entity =>
            {
                entity.HasKey(e => e.SystemId);

                entity.Property(e => e.SystemId)
                    .HasMaxLength(50)
                    .HasColumnName("systemID");

                entity.Property(e => e.ContracId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ContracID");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(10)
                    .HasColumnName("dvt");

                entity.Property(e => e.Macn)
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.PlansId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Trongluong).HasColumnName("trongluong");

                entity.HasOne(d => d.Plans)
                    .WithMany(p => p.PairedPlans)
                    .HasForeignKey(d => d.PlansId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PairedPlans_Plans");
            });

            modelBuilder.Entity<Parameter>(entity =>
            {
                entity.HasKey(e => e.CurrentYear)
                    .HasName("PK_Parameters_1");

                entity.Property(e => e.CurrentYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AS')")
                    .IsFixedLength(true);

                entity.Property(e => e.AutoCreateId).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentMonth)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DateFormat)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DoubleNumberFormat)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePathSaved).HasMaxLength(255);

                entity.Property(e => e.IntegerNumberFormat)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShowToolTipOnDataGrid).HasDefaultValueSql("((1))");

                entity.Property(e => e.WelcomeMessage).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentCondition>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Ma)
                    .HasMaxLength(10)
                    .HasColumnName("MA")
                    .IsFixedLength(true);

                entity.Property(e => e.Ten)
                    .HasColumnType("ntext")
                    .HasColumnName("TEN");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => new { e.FunctionId, e.UserId });

                entity.Property(e => e.FunctionId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Approval)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.Calculate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Delete)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.History)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.Insert)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Select)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.Update)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.Property(e => e.ViewAll)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PermissionsMenu>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.UserId });

                entity.ToTable("PermissionsMenu");

                entity.Property(e => e.MenuId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.KFileName)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("kFileName");

                entity.Property(e => e.Picture1)
                    .HasColumnType("image")
                    .HasColumnName("Picture");
            });

            modelBuilder.Entity<PlaceExchange>(entity =>
            {
                entity.ToTable("PlaceExchange");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.HasKey(e => e.SystemId)
                    .HasName("PK_PhuongAnKinhDoanh");

                entity.Property(e => e.SystemId).HasMaxLength(50);

                entity.Property(e => e.CangGiaoHang)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Chenhlechmuaban)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("chenhlechmuaban");

                entity.Property(e => e.ChiPhiSx).HasColumnName("ChiPhi_SX");

                entity.Property(e => e.CpThc).HasColumnName("CpTHC");

                entity.Property(e => e.CtTinhLaiVay)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CT_TinhLaiVay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DanhGiaBan).HasColumnType("ntext");

                entity.Property(e => e.DanhGiaMua).HasColumnType("ntext");

                entity.Property(e => e.DienGiaiNguonVon)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("DienGiai_NguonVon")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dieukiengiao)
                    .HasMaxLength(120)
                    .HasColumnName("dieukiengiao")
                    .IsFixedLength(true);

                entity.Property(e => e.DoiTacBan).HasColumnType("ntext");

                entity.Property(e => e.DoiTacMua).HasColumnType("ntext");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(10)
                    .HasColumnName("dvt")
                    .IsFixedLength(true);

                entity.Property(e => e.DvtBh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dvt_BH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtCt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dvt_CT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtGd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dvt_GD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtGn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dvt_GN")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtHh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dvt_HH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtKhac)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dvt_Khac")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtKt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dvt_KT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtLv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dvt_LV")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtThc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dvt_THC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DvtVcnd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dvt_Vcnd")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HangHoa).HasMaxLength(255);

                entity.Property(e => e.HdBan)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("HD_Ban")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HdMua)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("HD_Mua")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Isfix).HasColumnName("isfix");

                entity.Property(e => e.LaiSuat).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LoiNhuanSx).HasColumnName("LoiNhuan_SX");

                entity.Property(e => e.Macn)
                    .HasMaxLength(10)
                    .HasColumnName("macn")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayGiaoHdMua)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayGiao_HD_Mua");

                entity.Property(e => e.NgayKyHdBan)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKy_HD_Ban");

                entity.Property(e => e.NgayKyHdMua)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKy_HD_Mua");

                entity.Property(e => e.NgayPa)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayPA");

                entity.Property(e => e.Ngaygiao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaygiao");

                entity.Property(e => e.NguonVon)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NoiNhanHang)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoCont).HasColumnName("So_Cont");

                entity.Property(e => e.SoPa)
                    .HasMaxLength(50)
                    .HasColumnName("soPA");

                entity.Property(e => e.Songay).HasColumnName("songay");

                entity.Property(e => e.Songay1).HasColumnName("songay1");

                entity.Property(e => e.ThanhToanBan).HasMaxLength(255);

                entity.Property(e => e.ThanhToanMua).HasMaxLength(255);

                entity.Property(e => e.TienTeBaoHiem)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TienTe_BaoHiem")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TienTeCuocTau)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TienTe_CuocTau")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TienTeGn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TienTe_Gn")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TienTeHh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TienTe_Hh")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TienTeKhac)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TienTe_Khac")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TienTeKhuTrung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TienTe_KhuTrung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TienTeLaiVay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TienTe_LaiVay")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TienTeQly)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TienTe_Qly")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TienTeThc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TienTe_THC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TienTeVc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TienTe_Vc")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tienteban)
                    .HasMaxLength(50)
                    .HasColumnName("tienteban");

                entity.Property(e => e.Tientechenhlech)
                    .HasMaxLength(10)
                    .HasColumnName("tientechenhlech")
                    .IsFixedLength(true);

                entity.Property(e => e.Tientemua)
                    .HasMaxLength(50)
                    .HasColumnName("tientemua");

                entity.Property(e => e.Tongchiphi).HasColumnName("tongchiphi");

                entity.Property(e => e.Trangthai)
                    .HasColumnName("trangthai")
                    .HasComment("0: dang active; 1: đã hủy(xóa)");

                entity.Property(e => e.TrangthaiGhep)
                    .IsRequired()
                    .HasColumnName("trangthaiGhep")
                    .HasDefaultValueSql("((1))")
                    .HasComment("0: không cho ghép - 1: còn có thể cho ghép");

                entity.Property(e => e.TriGiaMua).HasColumnName("triGiaMua");

                entity.Property(e => e.Trongluong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TyGia).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<PortfolioPayment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.HinhThucGia).HasComment("0:Outright, 1: Tru lui");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LoaiHd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("loaiHD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("matt");

                entity.Property(e => e.Mucung).HasColumnName("mucung");

                entity.Property(e => e.TenTt)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("tenTT");

                entity.Property(e => e.ThanhToan).HasColumnName("Thanh_Toan");

                entity.Property(e => e.Ungtien).HasColumnName("ungtien");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("Position");

                entity.Property(e => e.PositionCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Presentation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Presentation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<ProcessWaste>(entity =>
            {
                entity.HasKey(e => e.EntNumber)
                    .HasName("PK_ProcessWaste_1");

                entity.ToTable("ProcessWaste");

                entity.Property(e => e.EntNumber).HasMaxLength(50);

                entity.Property(e => e.EntDate).HasColumnType("datetime");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ReportAttach)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StockCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StockName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProcessWasteDetail>(entity =>
            {
                entity.ToTable("ProcessWasteDetail");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProcessWasteEntNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ProcessWasteEntNumberNavigation)
                    .WithMany(p => p.ProcessWasteDetails)
                    .HasForeignKey(d => d.ProcessWasteEntNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessWasteDetail_ProcessWaste");
            });

            modelBuilder.Entity<Quocgium>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("quocgia");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ma)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ma")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Reminder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reminders");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("item");
            });

            modelBuilder.Entity<ReportHdmb>(entity =>
            {
                entity.ToTable("ReportHDMB");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.ToTable("SanPham");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DVT");

                entity.Property(e => e.LoaiHinh)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaDV");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NhomHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenHang)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type).HasComment("0: BC tuần, 1: BC tháng");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Saveinvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Saveinvoice");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amount");

                entity.Property(e => e.AmountVat)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("amount_VAT");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasColumnName("bank")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BillNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bill_no")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Buyer)
                    .IsRequired()
                    .HasColumnName("buyer")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cbuyer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("cbuyer")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChkDongia).HasColumnName("chk_dongia");

                entity.Property(e => e.CodeImportCountry)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cont)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateEdit).HasMaxLength(50);

                entity.Property(e => e.DateHd)
                    .HasColumnType("datetime")
                    .HasColumnName("date_hd")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateIv)
                    .HasColumnType("datetime")
                    .HasColumnName("date_iv");

                entity.Property(e => e.DateVat)
                    .HasColumnType("datetime")
                    .HasColumnName("DateVAT")
                    .HasDefaultValueSql("('01/01/1900')");

                entity.Property(e => e.Delivery)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("delivery")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DuyetNam).HasColumnName("Duyet_Nam");

                entity.Property(e => e.DuyetQui).HasColumnName("Duyet_Qui");

                entity.Property(e => e.DuyetThang).HasColumnName("Duyet_Thang");

                entity.Property(e => e.DuyetTuan).HasColumnName("Duyet_Tuan");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("Ghi_Chu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("id")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImportCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Invoice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("invoice")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Masothue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Medit).HasColumnName("medit");

                entity.Property(e => e.Nam).HasDefaultValueSql("((1))");

                entity.Property(e => e.NamLv)
                    .HasColumnName("Nam_LV")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ngoaite)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ngoaite")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("payment")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PortLoad1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("port_load1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PreCarri)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("pre_carri")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Qui).HasDefaultValueSql("((1))");

                entity.Property(e => e.SerialVat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SerialVAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Shd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("shd")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Shiper)
                    .IsRequired()
                    .HasColumnName("shiper")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoHdvat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SoHDVAT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoTk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("So_TK")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Soluong).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StBangchu)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("ST_Bangchu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SystemId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SystemID")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("systemref")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thang).HasDefaultValueSql("((1))");

                entity.Property(e => e.ThueSuat).HasColumnName("Thue_suat");

                entity.Property(e => e.TimestampColumn)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");

                entity.Property(e => e.TongTien).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TrangThai)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Trang_thai")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength(true)
                    .HasComment("0- Cho in, 1- In, 2-Huy");

                entity.Property(e => e.Tuan).HasDefaultValueSql("((1))");

                entity.Property(e => e.Tygia)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("tygia")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TypeInv)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Type_INV")
                    .HasDefaultValueSql("(N'XK')")
                    .IsFixedLength(true)
                    .HasComment("XK - Hoa don Xuat Khau, NK - Hoa don Nhap Khau");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserEdit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SaveinvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Saveinvoice_detail");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("amount");

                entity.Property(e => e.AmountVat)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("amount_VAT");

                entity.Property(e => e.Bag)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("bag");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DVT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Gw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("gw");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mahang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("mahang")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nw)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("nw");

                entity.Property(e => e.Sohd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SystemId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("SystemID")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.SystemRef)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tenhang)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("tenhang");

                entity.Property(e => e.TrangThai)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("trang_thai")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength(true);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<ServiceCenterInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ServiceCenterInfo");

                entity.Property(e => e.MPort).HasColumnName("mPort");

                entity.Property(e => e.MServer)
                    .HasMaxLength(50)
                    .HasColumnName("mServer");

                entity.Property(e => e.Mtype).HasColumnName("mtype");
            });

            modelBuilder.Entity<ShipLine>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("ship_line");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("logo")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Signer>(entity =>
            {
                entity.HasKey(e => new { e.Stt, e.MaKhach });

                entity.ToTable("signer");

                entity.Property(e => e.MaKhach)
                    .HasMaxLength(50)
                    .HasColumnName("ma_khach");

                entity.Property(e => e.Chucvu)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("chucvu");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Nguoiky)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("nguoiky");

                entity.Property(e => e.Uyquyen)
                    .IsRequired()
                    .HasColumnName("uyquyen")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("Stock");

                entity.Property(e => e.IsCheckKcs).HasColumnName("IsCheckKCS");

                entity.Property(e => e.IsStockService).HasDefaultValueSql("((1))");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StockCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StockName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<SuKien>(entity =>
            {
                entity.ToTable("SuKien");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Creater)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdSuKien)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("macn");

                entity.Property(e => e.Style)
                    .HasDefaultValueSql("((1))")
                    .HasComment("1: Hợp đồng mới - 2: Công văn mới - 3: Thông báo mới");

                entity.Property(e => e.SuKien1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("SuKien");

                entity.Property(e => e.ThoiGian).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<SuKienUser>(entity =>
            {
                entity.ToTable("SuKien_User");

                entity.Property(e => e.ActionId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EntDate).HasColumnType("datetime");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("macn");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SysUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SysUpdate");

                entity.Property(e => e.UpdateName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("updateName");

                entity.Property(e => e.UpdatePass)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("updatePass");
            });

            modelBuilder.Entity<T00lockedMonth>(entity =>
            {
                entity.HasKey(e => e.Ident);

                entity.ToTable("T00LOCKED_MONTH");

                entity.Property(e => e.Locked)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('')")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayLock)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Lock");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("User_Create")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<T00nam>(entity =>
            {
                entity.HasKey(e => e.Ident00);

                entity.ToTable("T00NAM");

                entity.Property(e => e.LockedSdHanTt).HasColumnName("Locked_SdHanTt");

                entity.Property(e => e.LockedSdk).HasColumnName("Locked_Sdk");

                entity.Property(e => e.LockedSdv).HasColumnName("Locked_Sdv");

                entity.Property(e => e.MaDvCs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Ma_DvCs");

                entity.Property(e => e.ThBdHt).HasColumnName("Th_Bd_Ht");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T00updateFile>(entity =>
            {
                entity.ToTable("T00UpdateFile");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SourceFile)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SourceFileFpt)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("SourceFile_FPT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TargetFile)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<T01dgCongviec>(entity =>
            {
                entity.HasKey(e => new { e.Ident, e.MaCbnv, e.Thang, e.Nam, e.MaKqth })
                    .HasName("PK_T01DG_CONGVIEC_1");

                entity.ToTable("T01DG_CONGVIEC");

                entity.Property(e => e.Ident).ValueGeneratedOnAdd();

                entity.Property(e => e.MaCbnv)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Cbnv");

                entity.Property(e => e.MaKqth)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_KQTH");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu");

                entity.Property(e => e.DiemChuan).HasColumnName("Diem_Chuan");

                entity.Property(e => e.DiemLdDg).HasColumnName("Diem_Ld_Dg");

                entity.Property(e => e.DiemNvDg).HasColumnName("Diem_Nv_Dg");

                entity.Property(e => e.LdTuNhan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("LD_Tu_Nhan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.TenCbnv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Cbnv");

                entity.Property(e => e.TenKqth)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("Ten_KQTH");

                entity.Property(e => e.TenTcDg)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("Ten_Tc_Dg");

                entity.Property(e => e.UserApprove)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("User_Approve")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<T01ketquaTh>(entity =>
            {
                entity.HasKey(e => e.Ident);

                entity.ToTable("T01KETQUA_TH");

                entity.Property(e => e.DiemChuan).HasColumnName("Diem_Chuan");

                entity.Property(e => e.MaKqth)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_KQTH");

                entity.Property(e => e.Stt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenKqth)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("Ten_KQTH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenTcDg)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("Ten_Tc_Dg");
            });

            modelBuilder.Entity<T01ldDanhgiaHqcv>(entity =>
            {
                entity.ToTable("T01LD_DANHGIA_HQCV");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.LdXacNhan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ld_XacNhan")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCbnv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Cbnv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NvDg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nv_Dg")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenCbnv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Cbnv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TgdDg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TGD_Dg")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<T01loaiphep>(entity =>
            {
                entity.HasKey(e => e.MaPhep);

                entity.ToTable("T01LOAIPHEP");

                entity.Property(e => e.MaPhep)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Phep");

                entity.Property(e => e.GioTangCa)
                    .HasColumnType("money")
                    .HasColumnName("Gio_Tang_Ca");

                entity.Property(e => e.KhCong)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("KH_Cong")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoaiLuong)
                    .HasColumnName("Loai_Luong")
                    .HasComment("Loại lương false- Không tính lương, true - Có tính lương");

                entity.Property(e => e.LoaiPhep)
                    .HasColumnName("Loai_Phep")
                    .HasComment("Loại phép false- Không trừ phép, true - Có trừ phép");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_Data")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayCong)
                    .HasColumnType("money")
                    .HasColumnName("Ngay_Cong");

                entity.Property(e => e.NgayLamDem)
                    .HasColumnType("money")
                    .HasColumnName("Ngay_Lam_Dem");

                entity.Property(e => e.NghiCoLg)
                    .HasColumnType("money")
                    .HasColumnName("Nghi_Co_Lg");

                entity.Property(e => e.NghiKgLg)
                    .HasColumnType("money")
                    .HasColumnName("Nghi_Kg_Lg");

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ten_Loai");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T02thanhlyHd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T02THANHLY_HD");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.GiaTri1)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri_1");

                entity.Property(e => e.GiaTri2)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri_2");

                entity.Property(e => e.GiaTriTh)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri_TH");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MaDt)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Dt");

                entity.Property(e => e.MaHd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Hd");

                entity.Property(e => e.NgayLap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Lap");

                entity.Property(e => e.TenDt)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Ten_Dt");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TongGiaTri)
                    .HasColumnType("money")
                    .HasColumnName("Tong_Gia_Tri");

                entity.Property(e => e.TongTienVat)
                    .HasColumnType("money")
                    .HasColumnName("Tong_Tien_VAT");

                entity.Property(e => e.TtDot1)
                    .HasColumnType("money")
                    .HasColumnName("TT_Dot_1");

                entity.Property(e => e.TtDot2)
                    .HasColumnType("money")
                    .HasColumnName("TT_Dot_2");

                entity.Property(e => e.TtDotCuoi)
                    .HasColumnType("money")
                    .HasColumnName("TT_Dot_Cuoi");
            });

            modelBuilder.Entity<T05bangluong>(entity =>
            {
                entity.HasKey(e => e.Ident00)
                    .HasName("PK__T05BANGL__352AA1BB4AD9AD2F");

                entity.ToTable("T05BANGLUONG");

                entity.Property(e => e.BacLuongBh)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Bac_Luong_BH")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BacLuongQc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Bac_Luong_QC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaDvCs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_DvCs")
                    .HasDefaultValueSql("('A01')");

                entity.Property(e => e.MaTn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Tn")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayCt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ct")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tien).HasColumnType("money");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.XepLoai)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("Xep_Loai")
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<T05caLamviec>(entity =>
            {
                entity.ToTable("T05CA_LAMVIEC");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Ghi_Chu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GioRa)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("Gio_Ra");

                entity.Property(e => e.GioRaMax)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Gio_Ra_Max")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GioRaMin)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Gio_Ra_Min")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GioTongLv)
                    .HasColumnType("money")
                    .HasColumnName("Gio_Tong_LV");

                entity.Property(e => e.GioVao)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("Gio_Vao");

                entity.Property(e => e.GioVaoMax)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Gio_Vao_Max")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GioVaoMin)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Gio_Vao_Min")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GiuaCa1)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("Giua_Ca_1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GiuaCa2)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("Giua_Ca_2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HeSoLv)
                    .HasColumnType("money")
                    .HasColumnName("He_So_Lv");

                entity.Property(e => e.HeSoTc)
                    .HasColumnType("money")
                    .HasColumnName("He_So_Tc")
                    .HasComment("Tăng ca ngày thường");

                entity.Property(e => e.HeSoTc1)
                    .HasColumnType("money")
                    .HasColumnName("He_So_Tc1")
                    .HasComment("Tăng ca ngày nghỉ trong tuần");

                entity.Property(e => e.HeSoTc2)
                    .HasColumnType("money")
                    .HasColumnName("He_So_Tc2")
                    .HasComment("Tăng ca ngày lễ, tết");

                entity.Property(e => e.IsCaDem).HasColumnName("Is_Ca_Dem");

                entity.Property(e => e.KyHieuCong)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("KyHieu_Cong")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCa)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Ca")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_Data");

                entity.Property(e => e.NgayAd)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Ad");

                entity.Property(e => e.SpRaSomCp)
                    .HasColumnType("money")
                    .HasColumnName("SP_RaSom_CP");

                entity.Property(e => e.SpVaoTreCp)
                    .HasColumnType("money")
                    .HasColumnName("SP_VaoTre_CP");

                entity.Property(e => e.TgLvMax)
                    .HasColumnType("money")
                    .HasColumnName("TG_LV_Max");

                entity.Property(e => e.TgLvMin)
                    .HasColumnType("money")
                    .HasColumnName("TG_LV_Min");

                entity.Property(e => e.TgTangCa)
                    .HasColumnType("money")
                    .HasColumnName("TG_Tang_Ca");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TongGioGiuaCa)
                    .HasColumnType("money")
                    .HasColumnName("Tong_Gio_Giua_Ca");

                entity.Property(e => e.UserCreate).HasMaxLength(50);

                entity.Property(e => e.UserModifyLast).HasMaxLength(50);
            });

            modelBuilder.Entity<T05chamCongNgay>(entity =>
            {
                entity.ToTable("T05ChamCong_Ngay");

                entity.Property(e => e.CaGioRa)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("Ca_Gio_Ra")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CaGioVao)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("Ca_Gio_Vao")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Chuc_Vu");

                entity.Property(e => e.Cong).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CongTc)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Cong_Tc");

                entity.Property(e => e.CongTc1)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Cong_Tc1");

                entity.Property(e => e.CongTc2)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Cong_Tc2");

                entity.Property(e => e.CongTc3)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Cong_Tc3");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.GioLv)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Gio_Lv");

                entity.Property(e => e.GioRa)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("Gio_Ra");

                entity.Property(e => e.GioTc)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Gio_Tc");

                entity.Property(e => e.GioVao)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasColumnName("Gio_Vao");

                entity.Property(e => e.IdChamCong)
                    .HasMaxLength(50)
                    .HasColumnName("Id_ChamCong");

                entity.Property(e => e.IsTreSom).HasColumnName("Is_Tre_Som");

                entity.Property(e => e.KyHieuTc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("KyHieu_Tc")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoaiCong)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Loai_Cong");

                entity.Property(e => e.MaBp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaCa)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Ca")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('A01')");

                entity.Property(e => e.MaKyHieu)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_KyHieu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaMayCc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_May_CC")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayCong)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Ngay_Cong");

                entity.Property(e => e.NgayCongLamDem)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Ngay_Cong_Lam_Dem");

                entity.Property(e => e.NgayGioRa)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Gio_Ra");

                entity.Property(e => e.NgayGioRaChuan)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Gio_Ra_Chuan");

                entity.Property(e => e.NgayGioVao)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Gio_Vao");

                entity.Property(e => e.NgayGioVaoChuan)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Gio_Vao_Chuan");

                entity.Property(e => e.NgayLamThem)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Ngay_Lam_Them");

                entity.Property(e => e.NgayLv)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Lv");

                entity.Property(e => e.NgayNghiLdCa)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Ngay_Nghi_LD_Ca");

                entity.Property(e => e.NghiCoLuong)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Nghi_Co_Luong");

                entity.Property(e => e.NghiKoLuong)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Nghi_Ko_Luong");

                entity.Property(e => e.Som).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TenCbNv)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ten_CbNv");

                entity.Property(e => e.Thu)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TongGio)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Tong_Gio");

                entity.Property(e => e.Tre).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<T05chamcongPhep>(entity =>
            {
                entity.ToTable("T05CHAMCONG_PHEP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreate).HasColumnType("date");

                entity.Property(e => e.DenNgay)
                    .HasColumnType("datetime")
                    .HasColumnName("Den_Ngay");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.LydoNghi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Lydo_Nghi");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.MaPhep)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Phep");

                entity.Property(e => e.SngayNghi)
                    .HasColumnType("money")
                    .HasColumnName("SNgay_Nghi");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TuNgay)
                    .HasColumnType("datetime")
                    .HasColumnName("Tu_Ngay");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<T05checkinout>(entity =>
            {
                entity.HasKey(e => new { e.UserEnrollNumber, e.TimeStr, e.MaData });

                entity.ToTable("T05CHECKINOUT");

                entity.Property(e => e.UserEnrollNumber).HasMaxLength(5);

                entity.Property(e => e.TimeStr).HasColumnType("datetime");

                entity.Property(e => e.MaData)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NewType).HasMaxLength(5);

                entity.Property(e => e.OriginType).HasMaxLength(10);

                entity.Property(e => e.Source).HasMaxLength(10);

                entity.Property(e => e.TimeDate).HasColumnType("date");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T05dangkyCa>(entity =>
            {
                entity.ToTable("T05DANGKY_CA");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Chuc_Vu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateLogUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CreateLog_User")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.MaBp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Bp")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCa)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Ca")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyLogUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ModifyLog_User")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayLv)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Lv");

                entity.Property(e => e.TenCbNv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Thu)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T05danhgiaXeploai>(entity =>
            {
                entity.ToTable("T05DANHGIA_XEPLOAI");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Chuc_Vu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Ghi_Chu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LdXepLoai)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("LD_Xep_Loai")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaBp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Bp")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NvXepLoai)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("NV_Xep_Loai")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TenCbNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ten_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T05dmtn>(entity =>
            {
                entity.ToTable("T05DMTN");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CongThuc)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Cong_Thuc");

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsDisplay1).HasColumnName("Is_Display1");

                entity.Property(e => e.IsDisplay2).HasColumnName("Is_Display2");

                entity.Property(e => e.IsDisplay3).HasColumnName("Is_Display3");

                entity.Property(e => e.IsInput).HasColumnName("Is_Input");

                entity.Property(e => e.LoaiTn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Loai_Tn");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("(N'INX')");

                entity.Property(e => e.MaKm)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Km");

                entity.Property(e => e.MaTn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Tn");

                entity.Property(e => e.SttCal).HasColumnName("Stt_Cal");

                entity.Property(e => e.TenTn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Tn");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TkCo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tk_Co");

                entity.Property(e => e.TkNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tk_No");
            });

            modelBuilder.Entity<T05gioLam>(entity =>
            {
                entity.ToTable("T05GioLam");

                entity.Property(e => e.GioLv)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("Gio_Lv");

                entity.Property(e => e.GioRa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Gio_Ra");

                entity.Property(e => e.GioVao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Gio_Vao");

                entity.Property(e => e.LoaiCong)
                    .HasColumnName("Loai_Cong")
                    .HasComment("0: Tính theo giờ vào và giờ ra; 1: Tính theo số giờ làm việc");

                entity.Property(e => e.MaBp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('A01')")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayAp)
                    .HasColumnType("date")
                    .HasColumnName("Ngay_Ap");

                entity.Property(e => e.TenCbNv)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Ten_CbNv");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T05khenThuongKyLuat>(entity =>
            {
                entity.ToTable("T05KhenThuong_KyLuat");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.NgayAd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ad");

                entity.Property(e => e.NgayNhap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Nhap");

                entity.Property(e => e.NguoiKy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Nguoi_Ky")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoiDung)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Dung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tien).HasColumnType("money");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T05kyhieuCong>(entity =>
            {
                entity.HasKey(e => e.MaKyHieu);

                entity.ToTable("T05KYHIEU_CONG");

                entity.Property(e => e.MaKyHieu)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_KyHieu");

                entity.Property(e => e.GioTangCa)
                    .HasColumnType("money")
                    .HasColumnName("Gio_Tang_Ca");

                entity.Property(e => e.KhCong)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("KH_Cong")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoaiKyHieu).HasColumnName("Loai_KyHieu");

                entity.Property(e => e.LoaiLuong).HasColumnName("Loai_Luong");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Data");

                entity.Property(e => e.NgayCong)
                    .HasColumnType("money")
                    .HasColumnName("Ngay_Cong");

                entity.Property(e => e.NgayLamDem)
                    .HasColumnType("money")
                    .HasColumnName("Ngay_Lam_Dem");

                entity.Property(e => e.NghiCoLg)
                    .HasColumnType("money")
                    .HasColumnName("Nghi_Co_Lg");

                entity.Property(e => e.NghiKgLg)
                    .HasColumnType("money")
                    .HasColumnName("Nghi_Kg_Lg");

                entity.Property(e => e.TenKyHieu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ten_KyHieu");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T05lamThem>(entity =>
            {
                entity.ToTable("T05LamThem");

                entity.Property(e => e.DenNgay)
                    .HasColumnType("date")
                    .HasColumnName("Den_Ngay");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.LyDo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ly_Do");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.SoGio)
                    .HasColumnType("money")
                    .HasColumnName("So_Gio");

                entity.Property(e => e.SoNgay)
                    .HasColumnType("money")
                    .HasColumnName("So_Ngay");

                entity.Property(e => e.SoTien)
                    .HasColumnType("money")
                    .HasColumnName("So_Tien");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TuNgay)
                    .HasColumnType("date")
                    .HasColumnName("Tu_Ngay");
            });

            modelBuilder.Entity<T05luongTamung>(entity =>
            {
                entity.ToTable("T05LUONG_TAMUNG");

                entity.Property(e => e.BacLuongHq)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Bac_Luong_HQ")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Chuc_Vu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Ghi_Chu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LuongHq)
                    .HasColumnType("money")
                    .HasColumnName("Luong_HQ");

                entity.Property(e => e.MaBp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Bp")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhuCap)
                    .HasColumnType("money")
                    .HasColumnName("Phu_Cap");

                entity.Property(e => e.TamUng)
                    .HasColumnType("money")
                    .HasColumnName("Tam_Ung");

                entity.Property(e => e.TenCbNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ten_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ThucLanh)
                    .HasColumnType("money")
                    .HasColumnName("Thuc_Lanh");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TongLuong)
                    .HasColumnType("money")
                    .HasColumnName("Tong_Luong");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<T05luongThuong>(entity =>
            {
                entity.ToTable("T05LUONG_THUONG");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Chuc_Vu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Ghi_Chu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LuongThuong)
                    .HasColumnType("money")
                    .HasColumnName("Luong_Thuong");

                entity.Property(e => e.MaBp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Bp")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayChotThuong)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Chot_Thuong")
                    .HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.NoiDung)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Noi_Dung")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoThangLv).HasColumnName("So_Thang_LV");

                entity.Property(e => e.TenCbNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ten_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<T05luongt>(entity =>
            {
                entity.HasKey(e => e.Identity00);

                entity.ToTable("T05LUONGTS");

                entity.Property(e => e.CongThuc)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Cong_Thuc");

                entity.Property(e => e.CreateLog)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("Create_Log");

                entity.Property(e => e.DienGiai)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("Dien_Giai");

                entity.Property(e => e.GiaTri01)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri01");

                entity.Property(e => e.GiaTri02)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri02");

                entity.Property(e => e.GiaTri03)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri03");

                entity.Property(e => e.GiaTri04)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri04");

                entity.Property(e => e.GiaTri05)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri05");

                entity.Property(e => e.GiaTri06)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri06");

                entity.Property(e => e.GiaTri07)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri07");

                entity.Property(e => e.GiaTri08)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri08");

                entity.Property(e => e.GiaTri09)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri09");

                entity.Property(e => e.GiaTri10)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri10");

                entity.Property(e => e.GiaTri11)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri11");

                entity.Property(e => e.GiaTri12)
                    .HasColumnType("money")
                    .HasColumnName("Gia_Tri12");

                entity.Property(e => e.Kieu)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastModifyLog)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("LastModify_Log");

                entity.Property(e => e.Loai)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("(N'INX')");

                entity.Property(e => e.Stt).HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ThamSo)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Tham_So");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T05machine>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("aaaaaMachines_PK")
                    .IsClustered(false);

                entity.ToTable("T05MACHINES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActiveKey).HasMaxLength(50);

                entity.Property(e => e.BaudRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.ColorCode).HasMaxLength(15);

                entity.Property(e => e.CommKey).HasDefaultValueSql("((0))");

                entity.Property(e => e.CommType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comport)
                    .HasColumnName("COMPort")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CycleReLoad).HasDefaultValueSql("((24))");

                entity.Property(e => e.Delay).HasDefaultValueSql("((30))");

                entity.Property(e => e.DomainName).HasMaxLength(50);

                entity.Property(e => e.Encrypt).HasDefaultValueSql("((0))");

                entity.Property(e => e.ErrorDelay).HasDefaultValueSql("((60))");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LastEventTime).HasColumnType("datetime");

                entity.Property(e => e.LastRecordDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaData)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('A01')");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.OpStamp).HasMaxLength(20);

                entity.Property(e => e.PhotoStamp).HasMaxLength(20);

                entity.Property(e => e.Port).HasDefaultValueSql("((0))");

                entity.Property(e => e.RealTime).HasDefaultValueSql("((1))");

                entity.Property(e => e.SerialNumber).HasMaxLength(30);

                entity.Property(e => e.Stamp).HasMaxLength(20);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TimeZone).HasDefaultValueSql("((7))");

                entity.Property(e => e.TransFlag).HasMaxLength(200);

                entity.Property(e => e.TransInterval).HasDefaultValueSql("((1))");

                entity.Property(e => e.TransTimes)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('00:00;14:05 ')");
            });

            modelBuilder.Entity<T05mucThuong>(entity =>
            {
                entity.ToTable("T05MUC_THUONG");

                entity.Property(e => e.ListChucDanh)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("List_Chuc_Danh")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LoaiHd)
                    .HasColumnName("Loai_HD")
                    .HasComment("1- Chính thức, 2- Thử việc, 3- Vụ việc");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Data");

                entity.Property(e => e.ThangTn1).HasColumnName("Thang_TN_1");

                entity.Property(e => e.ThangTn2).HasColumnName("Thang_TN_2");

                entity.Property(e => e.TienThuong)
                    .HasColumnType("money")
                    .HasColumnName("Tien_Thuong");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T05ngaylvNam>(entity =>
            {
                entity.ToTable("T05NGAYLV_NAM");

                entity.Property(e => e.SngayLv40).HasColumnName("SNgay_LV_40");

                entity.Property(e => e.SngayLv44)
                    .HasColumnType("money")
                    .HasColumnName("SNgay_LV_44");

                entity.Property(e => e.SngayLv48).HasColumnName("SNgay_LV_48");

                entity.Property(e => e.SoNgay).HasColumnName("So_Ngay");

                entity.Property(e => e.SoNgayCn).HasColumnName("So_Ngay_CN");

                entity.Property(e => e.SoNgayT7).HasColumnName("So_Ngay_T7");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T05nghilenam>(entity =>
            {
                entity.ToTable("T05NGHILENAM");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Ghi_Chu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HeSoLv)
                    .HasColumnType("money")
                    .HasColumnName("He_So_Lv")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Hệ số làm việc");

                entity.Property(e => e.HeSoTc)
                    .HasColumnType("money")
                    .HasColumnName("He_So_Tc")
                    .HasComment("Hệ số tăng ca");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaNgayNghi)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Ma_Ngay_Nghi")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserCreate)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserModifyLast).HasMaxLength(50);
            });

            modelBuilder.Entity<T05phepnam>(entity =>
            {
                entity.ToTable("T05PHEPNAM");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaBp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Bp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SngayDaNghiPhep)
                    .HasColumnType("money")
                    .HasColumnName("SNgay_Da_Nghi_Phep");

                entity.Property(e => e.SngayPhepChuan)
                    .HasColumnType("money")
                    .HasColumnName("SNgay_Phep_Chuan");

                entity.Property(e => e.SngayPhepConLai)
                    .HasColumnType("money")
                    .HasColumnName("SNgay_Phep_ConLai");

                entity.Property(e => e.SngayPhepNam)
                    .HasColumnType("money")
                    .HasColumnName("SNgay_Phep_Nam");

                entity.Property(e => e.SngayPhepThem)
                    .HasColumnType("money")
                    .HasColumnName("SNgay_Phep_Them");

                entity.Property(e => e.SngayPhepTon)
                    .HasColumnType("money")
                    .HasColumnName("SNgay_Phep_Ton");

                entity.Property(e => e.SoNamLv)
                    .HasColumnType("money")
                    .HasColumnName("So_Nam_LV");

                entity.Property(e => e.SphepTruT3)
                    .HasColumnType("money")
                    .HasColumnName("SPhep_Tru_T3");

                entity.Property(e => e.TenCbNv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T05thuetn>(entity =>
            {
                entity.HasKey(e => e.Ident00);

                entity.ToTable("T05THUETN");

                entity.Property(e => e.BangThue)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Bang_Thue");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.LoaiThue)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Loai_Thue")
                    .IsFixedLength(true);

                entity.Property(e => e.MucTn1)
                    .HasColumnType("money")
                    .HasColumnName("Muc_Tn1");

                entity.Property(e => e.MucTn2)
                    .HasColumnType("money")
                    .HasColumnName("Muc_Tn2");

                entity.Property(e => e.Ngay1).HasColumnType("datetime");

                entity.Property(e => e.Ngay2).HasColumnType("datetime");

                entity.Property(e => e.SttThue)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Stt_Thue");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TyLe)
                    .HasColumnType("money")
                    .HasColumnName("Ty_Le");
            });

            modelBuilder.Entity<T05tienNopBaoHiem>(entity =>
            {
                entity.ToTable("T05TienNop_BaoHiem");

                entity.Property(e => e.DnBhtn)
                    .HasColumnType("money")
                    .HasColumnName("DN_BHTN");

                entity.Property(e => e.DnBhxh)
                    .HasColumnType("money")
                    .HasColumnName("DN_BHXH");

                entity.Property(e => e.DnBhyt)
                    .HasColumnType("money")
                    .HasColumnName("DN_BHYT");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("Ghi_Chu")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HeSo)
                    .HasColumnType("money")
                    .HasColumnName("He_So");

                entity.Property(e => e.LuongBh)
                    .HasColumnType("money")
                    .HasColumnName("Luong_BH");

                entity.Property(e => e.MaBp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Bp")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Data")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NvBhtn)
                    .HasColumnType("money")
                    .HasColumnName("NV_BHTN");

                entity.Property(e => e.NvBhxh)
                    .HasColumnType("money")
                    .HasColumnName("NV_BHXH");

                entity.Property(e => e.NvBhyt)
                    .HasColumnType("money")
                    .HasColumnName("NV_BHYT");

                entity.Property(e => e.TenCbNv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_CbNv");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("User_Create")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<T05tstn>(entity =>
            {
                entity.HasKey(e => e.Ident00)
                    .HasName("PK__T05TSTN__352AA1BB3B97699F");

                entity.ToTable("T05TSTN");

                entity.Property(e => e.MaTn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Tn")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MucAp)
                    .HasColumnType("money")
                    .HasColumnName("Muc_Ap")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayAp)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ap")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<T05tstn0>(entity =>
            {
                entity.HasKey(e => e.Ident00)
                    .HasName("PK__T05TSTN0__352AA1BB4244672E");

                entity.ToTable("T05TSTN0");

                entity.Property(e => e.IsUuTien)
                    .IsRequired()
                    .HasColumnName("Is_UuTien")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_CbNv")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaTn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Tn")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MucAp)
                    .HasColumnType("money")
                    .HasColumnName("Muc_Ap")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NgayAp)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ap")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TBaoCao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_BaoCao");

                entity.Property(e => e.Bold)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(20)
                    .HasColumnName("Chuc_Vu");

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Dia_Chi");

                entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");

                entity.Property(e => e.LevelI)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Level_I")
                    .IsFixedLength(true);

                entity.Property(e => e.MaBp)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaCbnv)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Cbnv");

                entity.Property(e => e.MaCn)
                    .HasMaxLength(10)
                    .HasColumnName("MaCN")
                    .IsFixedLength(true);

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Sinh");

                entity.Property(e => e.NoiSinh)
                    .HasMaxLength(100)
                    .HasColumnName("Noi_Sinh");

                entity.Property(e => e.TenCbNv)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_CbNv");
            });

            modelBuilder.Entity<TConsignee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Consignee");

                entity.Property(e => e.Consignee)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("consignee");
            });

            modelBuilder.Entity<TConsignee1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_Consignee1");

                entity.Property(e => e.Consignee)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("consignee");
            });

            modelBuilder.Entity<TDanhmucBp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_DANHMUC_BP");

                entity.Property(e => e.CreateLog)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("Create_Log");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifyLog)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("LastModify_Log");

                entity.Property(e => e.MaBp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaBpCha)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Bp_Cha");

                entity.Property(e => e.MaData)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Ma_Data");

                entity.Property(e => e.NgayBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Begin");

                entity.Property(e => e.NgayEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_End");

                entity.Property(e => e.NhCuoi).HasColumnName("Nh_Cuoi");

                entity.Property(e => e.SttBp)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Stt_Bp");

                entity.Property(e => e.TenBp)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_Bp");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TDanhmucNv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_DANHMUC_NV");

                entity.Property(e => e.AnHien).HasColumnName("An_Hien");

                entity.Property(e => e.AnHienTu).HasColumnName("An_Hien_TU");

                entity.Property(e => e.BiDanh)
                    .HasMaxLength(50)
                    .HasColumnName("Bi_Danh");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu");

                entity.Property(e => e.CmNv)
                    .HasMaxLength(255)
                    .HasColumnName("CM_NV");

                entity.Property(e => e.CongViec)
                    .HasMaxLength(1000)
                    .HasColumnName("Cong_Viec");

                entity.Property(e => e.DanToc)
                    .HasMaxLength(50)
                    .HasColumnName("Dan_Toc");

                entity.Property(e => e.DcHn)
                    .HasMaxLength(255)
                    .HasColumnName("DC_HN");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_Chi");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");

                entity.Property(e => e.HandPhone)
                    .HasMaxLength(255)
                    .HasColumnName("Hand_Phone");

                entity.Property(e => e.Hinh).HasMaxLength(50);

                entity.Property(e => e.IdNs)
                    .HasMaxLength(10)
                    .HasColumnName("ID_NS")
                    .IsFixedLength(true);

                entity.Property(e => e.KhongCc).HasColumnName("Khong_CC");

                entity.Property(e => e.LanhDao).HasColumnName("Lanh_dao");

                entity.Property(e => e.LdNghiviec)
                    .HasMaxLength(255)
                    .HasColumnName("LD_Nghiviec");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaCaLv)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Ca_LV");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.MaData)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_Data");

                entity.Property(e => e.MaMayCc)
                    .HasMaxLength(10)
                    .HasColumnName("Ma_May_CC");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_So_Thue");

                entity.Property(e => e.Macn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Member_ID");

                entity.Property(e => e.NganHang)
                    .HasMaxLength(100)
                    .HasColumnName("Ngan_Hang");

                entity.Property(e => e.NgayBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Begin");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Cap");

                entity.Property(e => e.NgayEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_End");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Sinh");

                entity.Property(e => e.NgaycapHc)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngaycap_HC");

                entity.Property(e => e.NguyenQuan)
                    .HasMaxLength(255)
                    .HasColumnName("Nguyen_Quan");

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap");

                entity.Property(e => e.NoiSinh)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Sinh");

                entity.Property(e => e.NoicapHc)
                    .HasMaxLength(50)
                    .HasColumnName("Noicap_HC");

                entity.Property(e => e.QuocTich)
                    .HasMaxLength(50)
                    .HasColumnName("Quoc_Tich");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("So_CMND");

                entity.Property(e => e.SoHc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("So_HC");

                entity.Property(e => e.SoPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("So_Phone");

                entity.Property(e => e.SoQdNv)
                    .HasMaxLength(50)
                    .HasColumnName("SoQD_NV");

                entity.Property(e => e.SoTk)
                    .HasMaxLength(50)
                    .HasColumnName("So_Tk");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TdHv)
                    .HasMaxLength(20)
                    .HasColumnName("TD_HV");

                entity.Property(e => e.TdNn)
                    .HasMaxLength(20)
                    .HasColumnName("TD_NN");

                entity.Property(e => e.TdTh)
                    .HasMaxLength(20)
                    .HasColumnName("TD_TH");

                entity.Property(e => e.TdVh)
                    .HasMaxLength(20)
                    .HasColumnName("TD_VH");

                entity.Property(e => e.TenCbNv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_CbNv");

                entity.Property(e => e.TenTat)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Tat");

                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TinhTrangHn)
                    .HasMaxLength(30)
                    .HasColumnName("Tinh_Trang_HN");

                entity.Property(e => e.TonGiao)
                    .HasMaxLength(50)
                    .HasColumnName("Ton_Giao");

                entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");

                entity.Property(e => e.UserCreate)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("User_Create");

                entity.Property(e => e.UserEdit)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("User_Edit");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<THangGao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_HangGao");

                entity.Property(e => e.Baobi)
                    .HasColumnType("ntext")
                    .HasColumnName("baobi");

                entity.Property(e => e.DoAm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Do_Am");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("dvt");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(255)
                    .HasColumnName("fullname");

                entity.Property(e => e.HatDen)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Hat_Den");

                entity.Property(e => e.HatVo)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Hat_Vo");

                entity.Property(e => e.Idhanghoa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IDhanghoa")
                    .IsFixedLength(true);

                entity.Property(e => e.Kiemdinh)
                    .HasColumnType("ntext")
                    .HasColumnName("kiemdinh");

                entity.Property(e => e.MaNhom).HasMaxLength(50);

                entity.Property(e => e.Mahang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mahang");

                entity.Property(e => e.OrderNhom).HasColumnName("Order_Nhom");

                entity.Property(e => e.Quicach)
                    .HasColumnType("ntext")
                    .HasColumnName("quicach");

                entity.Property(e => e.Sudung).HasColumnName("sudung");

                entity.Property(e => e.TapChat)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("Tap_Chat");

                entity.Property(e => e.Tenhang)
                    .HasMaxLength(255)
                    .HasColumnName("tenhang");

                entity.Property(e => e.Tenhangvat)
                    .HasMaxLength(255)
                    .HasColumnName("tenhangvat");

                entity.Property(e => e.Vat).HasColumnName("vat");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<THdldHoaTan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_HDLD_HoaTan");

                entity.Property(e => e.BacLuong)
                    .HasMaxLength(20)
                    .HasColumnName("Bac_Luong");

                entity.Property(e => e.CheDoLamViec)
                    .HasMaxLength(50)
                    .HasColumnName("Che_Do_Lam_Viec");

                entity.Property(e => e.ChucDanh)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Danh");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.HsLuong)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("HS_Luong");

                entity.Property(e => e.HtTraluong)
                    .HasMaxLength(50)
                    .HasColumnName("HT_Traluong");

                entity.Property(e => e.LoaiHd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Loai_Hd");

                entity.Property(e => e.LuongCb)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Luong_CB");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.NgachLuong)
                    .HasMaxLength(20)
                    .HasColumnName("Ngach_Luong");

                entity.Property(e => e.NgayBd)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Ngay_Bd");

                entity.Property(e => e.NgayChamDut)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Ngay_Cham_Dut");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Ngay_Kt");

                entity.Property(e => e.NgayKy)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Ngay_Ky");

                entity.Property(e => e.NguoiKy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nguoi_Ky");

                entity.Property(e => e.NoiDungCv).HasColumnName("Noi_Dung_CV");

                entity.Property(e => e.NoiLv)
                    .HasMaxLength(50)
                    .HasColumnName("Noi_LV");

                entity.Property(e => e.PcQc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PC_QC");

                entity.Property(e => e.SoHd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("So_Hd");
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1");

                entity.Property(e => e._1).HasColumnName("1");

                entity.Property(e => e._10).HasColumnName("10");

                entity.Property(e => e._11)
                    .HasColumnType("money")
                    .HasColumnName("11");

                entity.Property(e => e._12)
                    .HasColumnType("money")
                    .HasColumnName("12");

                entity.Property(e => e._13).HasColumnName("13");

                entity.Property(e => e._14).HasColumnName("14");

                entity.Property(e => e._2)
                    .HasColumnType("money")
                    .HasColumnName("2");

                entity.Property(e => e._3).HasColumnName("3");

                entity.Property(e => e._4).HasColumnName("4");

                entity.Property(e => e._5).HasColumnName("5");

                entity.Property(e => e._6).HasColumnName("6");

                entity.Property(e => e._7).HasColumnName("7");

                entity.Property(e => e._8).HasColumnName("8");

                entity.Property(e => e._9)
                    .HasColumnType("money")
                    .HasColumnName("9");
            });

            modelBuilder.Entity<TaiLieu>(entity =>
            {
                entity.ToTable("TaiLieu");

                entity.Property(e => e.NodeName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TamC>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tam_C");

                entity.Property(e => e.ContNo)
                    .HasMaxLength(30)
                    .HasColumnName("cont_no")
                    .IsFixedLength(true);

                entity.Property(e => e.ContNo1)
                    .HasMaxLength(30)
                    .HasColumnName("cont_no1")
                    .IsFixedLength(true);

                entity.Property(e => e.CustAdd)
                    .HasMaxLength(250)
                    .HasColumnName("cust_add");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_code")
                    .IsFixedLength(true);

                entity.Property(e => e.CustName)
                    .HasMaxLength(50)
                    .HasColumnName("cust_name");

                entity.Property(e => e.CustPresent)
                    .HasMaxLength(150)
                    .HasColumnName("cust_present");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasColumnName("date_in");

                entity.Property(e => e.DateOut)
                    .HasColumnType("datetime")
                    .HasColumnName("date_out");

                entity.Property(e => e.Dongia)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("dongia");

                entity.Property(e => e.Dongia1)
                    .HasColumnType("numeric(18, 6)")
                    .HasColumnName("dongia1");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("dvt");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("date")
                    .HasColumnName("ngayHD");

                entity.Property(e => e.Payment)
                    .HasMaxLength(50)
                    .HasColumnName("payment");

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(50)
                    .HasColumnName("prod_code");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(255)
                    .HasColumnName("prod_name");

                entity.Property(e => e.SealNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("seal_no");

                entity.Property(e => e.SealNo1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("seal_no1");

                entity.Property(e => e.Serial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SystemId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("systemID");

                entity.Property(e => e.SystemRefHd)
                    .HasMaxLength(50)
                    .HasColumnName("SystemRefHD");

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(255)
                    .HasColumnName("taikhoan");

                entity.Property(e => e.Taxcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Tienthue)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tienthue");

                entity.Property(e => e.TimeIn)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("time_in")
                    .IsFixedLength(true);

                entity.Property(e => e.TimeOut)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("time_out")
                    .IsFixedLength(true);

                entity.Property(e => e.TlCont)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tl_cont");

                entity.Property(e => e.TlCont1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tl_cont1");

                entity.Property(e => e.TlIn)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TL_in");

                entity.Property(e => e.TlNet)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tl_net");

                entity.Property(e => e.TlOut)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tl_out");

                entity.Property(e => e.Tlbao)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("TLBao");

                entity.Property(e => e.Tongtrigia)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("tongtrigia");

                entity.Property(e => e.Trigia)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("trigia");

                entity.Property(e => e.Trigia1)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("trigia1");

                entity.Property(e => e.Trigiatruocthue)
                    .HasColumnType("numeric(18, 3)")
                    .HasColumnName("trigiatruocthue");

                entity.Property(e => e.TruckNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("truck_no")
                    .IsFixedLength(true);

                entity.Property(e => e.Tthai).HasColumnName("tthai");

                entity.Property(e => e.TypeCont).HasColumnName("type_cont");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("vat");

                entity.Property(e => e.VatNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblBuyer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Buyer");

                entity.Property(e => e.Buyer).HasColumnName("buyer");

                entity.Property(e => e.Cbuyer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("cbuyer");

                entity.Property(e => e.Chatluong).HasColumnName("chatluong");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Ten)
                    .HasMaxLength(255)
                    .HasColumnName("ten");

                entity.Property(e => e.TimestampColumn)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("timestamp_column");
            });

            modelBuilder.Entity<TblKhachhang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Khachhang");

                entity.Property(e => e.Bocxep)
                    .HasMaxLength(250)
                    .HasColumnName("bocxep");

                entity.Property(e => e.CheckTh).HasColumnName("Check_TH");

                entity.Property(e => e.ChucVu1)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu1");

                entity.Property(e => e.ChucVu2)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu2");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DateActive)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Active");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("dia_chi");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(255)
                    .HasColumnName("dien_thoai");

                entity.Property(e => e.Dientich).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .HasColumnName("fax");

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(50)
                    .HasColumnName("ghi_chu");

                entity.Property(e => e.GiaoDich).HasColumnName("giao_dich");

                entity.Property(e => e.GiaoDichBan).HasColumnName("giao_dich_ban");

                entity.Property(e => e.GiaoDichMua).HasColumnName("giao_dich_mua");

                entity.Property(e => e.GiayPhep)
                    .HasMaxLength(255)
                    .HasColumnName("giay_phep");

                entity.Property(e => e.Idkhach)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IDKhach")
                    .IsFixedLength(true);

                entity.Property(e => e.LoaiKhach)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("loai_khach");

                entity.Property(e => e.MaCn)
                    .HasMaxLength(10)
                    .HasColumnName("ma_cn")
                    .IsFixedLength(true);

                entity.Property(e => e.MaHd)
                    .HasMaxLength(50)
                    .HasColumnName("ma_hd");

                entity.Property(e => e.MaKhach)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ma_khach");

                entity.Property(e => e.MaKhuvuc)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_khuvuc");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(255)
                    .HasColumnName("ma_so_thue");

                entity.Property(e => e.MatHang)
                    .HasMaxLength(50)
                    .HasColumnName("mat_hang");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.NganHang)
                    .HasMaxLength(255)
                    .HasColumnName("Ngan_hang");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("date")
                    .HasColumnName("ngay_cap");

                entity.Property(e => e.NguoiKy1)
                    .HasMaxLength(50)
                    .HasColumnName("Nguoi_ky1");

                entity.Property(e => e.NguoiKy2)
                    .HasMaxLength(50)
                    .HasColumnName("Nguoi_ky2");

                entity.Property(e => e.Sanluong).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(250)
                    .HasColumnName("tai_khoan");

                entity.Property(e => e.TenFull)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ten_full");

                entity.Property(e => e.TenKhach)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ten_khach");

                entity.Property(e => e.TenQg)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Qg");

                entity.Property(e => e.ThanhToanBan).HasColumnName("thanh_toan_ban");

                entity.Property(e => e.ThanhToanMua).HasColumnName("thanh_toan_mua");

                entity.Property(e => e.ToaKinhTe).HasMaxLength(250);

                entity.Property(e => e.UyQuyen1)
                    .HasMaxLength(50)
                    .HasColumnName("Uy_Quyen1");

                entity.Property(e => e.UyQuyen2)
                    .HasMaxLength(50)
                    .HasColumnName("Uy_Quyen2");

                entity.Property(e => e.Vanchuyen)
                    .HasMaxLength(250)
                    .HasColumnName("vanchuyen");

                entity.Property(e => e.Visible).HasColumnName("visible");
            });

            modelBuilder.Entity<TblNsDmcbnvTam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_NS_DMCBNV_TAM");

                entity.Property(e => e.BiDanh)
                    .HasMaxLength(50)
                    .HasColumnName("Bi_Danh");

                entity.Property(e => e.ChucVu)
                    .HasMaxLength(50)
                    .HasColumnName("Chuc_Vu");

                entity.Property(e => e.CmNv)
                    .HasMaxLength(255)
                    .HasColumnName("CM_NV");

                entity.Property(e => e.CongViec).HasColumnName("Cong_Viec");

                entity.Property(e => e.DanToc)
                    .HasMaxLength(50)
                    .HasColumnName("Dan_Toc");

                entity.Property(e => e.DcHn)
                    .HasMaxLength(255)
                    .HasColumnName("DC_HN");

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("Dia_Chi");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");

                entity.Property(e => e.HandPhone)
                    .HasMaxLength(255)
                    .HasColumnName("Hand_Phone");

                entity.Property(e => e.Hinh).HasMaxLength(50);

                entity.Property(e => e.IdNs)
                    .HasMaxLength(10)
                    .HasColumnName("ID_NS")
                    .IsFixedLength(true);

                entity.Property(e => e.LanhDao).HasColumnName("Lanh_dao");

                entity.Property(e => e.LdNghiviec).HasColumnName("LD_Nghiviec");

                entity.Property(e => e.MaBp)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Bp");

                entity.Property(e => e.MaCbNv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_CbNv");

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(50)
                    .HasColumnName("Ma_So_Thue");

                entity.Property(e => e.Macn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Member_ID");

                entity.Property(e => e.NganHang)
                    .HasMaxLength(100)
                    .HasColumnName("Ngan_Hang");

                entity.Property(e => e.NgayBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Begin");

                entity.Property(e => e.NgayCap)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Cap");

                entity.Property(e => e.NgayEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_End");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Sinh");

                entity.Property(e => e.NgaycapHc)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngaycap_HC");

                entity.Property(e => e.NguyenQuan)
                    .HasMaxLength(255)
                    .HasColumnName("Nguyen_Quan");

                entity.Property(e => e.NoiCap)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Cap");

                entity.Property(e => e.NoiSinh)
                    .HasMaxLength(255)
                    .HasColumnName("Noi_Sinh");

                entity.Property(e => e.NoicapHc)
                    .HasMaxLength(50)
                    .HasColumnName("Noicap_HC");

                entity.Property(e => e.QuocTich)
                    .HasMaxLength(50)
                    .HasColumnName("Quoc_Tich");

                entity.Property(e => e.SoCmnd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("So_CMND");

                entity.Property(e => e.SoHc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("So_HC");

                entity.Property(e => e.SoPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("So_Phone");

                entity.Property(e => e.SoQdNv)
                    .HasMaxLength(50)
                    .HasColumnName("SoQD_NV");

                entity.Property(e => e.SoTk)
                    .HasMaxLength(50)
                    .HasColumnName("So_Tk");

                entity.Property(e => e.Stt).HasColumnName("STT");

                entity.Property(e => e.TdHv)
                    .HasMaxLength(20)
                    .HasColumnName("TD_HV");

                entity.Property(e => e.TdNn)
                    .HasMaxLength(20)
                    .HasColumnName("TD_NN");

                entity.Property(e => e.TdTh)
                    .HasMaxLength(20)
                    .HasColumnName("TD_TH");

                entity.Property(e => e.TdVh)
                    .HasMaxLength(20)
                    .HasColumnName("TD_VH");

                entity.Property(e => e.TenCbNv)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Ten_CbNv");

                entity.Property(e => e.TenTat)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Tat");

                entity.Property(e => e.TinhTrangHn)
                    .HasMaxLength(30)
                    .HasColumnName("Tinh_Trang_HN");

                entity.Property(e => e.TonGiao)
                    .HasMaxLength(50)
                    .HasColumnName("Ton_Giao");

                entity.Property(e => e.TrangThai).HasColumnName("Trang_Thai");

                entity.Property(e => e.UserCreate)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("User_Create");

                entity.Property(e => e.UserEdit)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("User_Edit");

                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<TestImage>(entity =>
            {
                entity.HasKey(e => e.TestId);

                entity.ToTable("TestImage");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("image");
            });

            modelBuilder.Entity<Thanhtoan>(entity =>
            {
                entity.ToTable("Thanhtoan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DienGiai)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Dien_Giai");

                entity.Property(e => e.MaCt)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("Ma_Ct");

                entity.Property(e => e.MaDt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Ma_Dt");

                entity.Property(e => e.MaDvcs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("MaDVCS");

                entity.Property(e => e.MaTte)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("Ma_Tte");

                entity.Property(e => e.NgayCt)
                    .HasColumnType("datetime")
                    .HasColumnName("Ngay_Ct");

                entity.Property(e => e.SoCt)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("So_Ct");

                entity.Property(e => e.Stt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("STT");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.TienTt)
                    .HasColumnType("money")
                    .HasColumnName("Tien_Tt");

                entity.Property(e => e.TienTtNt)
                    .HasColumnType("money")
                    .HasColumnName("Tien_Tt_Nt");

                entity.Property(e => e.Tk)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TyGia)
                    .HasColumnType("money")
                    .HasColumnName("Ty_Gia");
            });

            modelBuilder.Entity<Thitruong>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("thitruong");

                entity.Property(e => e.Ma)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ma");

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<ThucHienHdPakd>(entity =>
            {
                entity.ToTable("ThucHien_Hd_Pakd");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LaiPa).HasColumnName("Lai_PA");

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaDV");

                entity.Property(e => e.Nhom)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NhomHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UocLai).HasColumnName("Uoc_Lai");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TieuChuanCl>(entity =>
            {
                entity.ToTable("TieuChuanCL");

                entity.Property(e => e.ColKcs)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ColKCS");

                entity.Property(e => e.RquiCach).HasColumnName("RQuiCach");

                entity.Property(e => e.TênTc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("TênTC");
            });

            modelBuilder.Entity<TmpManager>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TmpManager");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("value")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VariableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("variableName")
                    .HasDefaultValueSql("('variablename')");
            });

            modelBuilder.Entity<TonDau>(entity =>
            {
                entity.ToTable("TonDau");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DonVi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("Ghi_Chu");

                entity.Property(e => e.GtNhap)
                    .HasColumnType("money")
                    .HasColumnName("GT_Nhap");

                entity.Property(e => e.GtTon)
                    .HasColumnType("money")
                    .HasColumnName("GT_Ton");

                entity.Property(e => e.GtTrungBay)
                    .HasColumnType("money")
                    .HasColumnName("GT_TrungBay");

                entity.Property(e => e.GtXuat)
                    .HasColumnType("money")
                    .HasColumnName("GT_Xuat");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Tonghop>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tonghop$");

                entity.Property(e => e.Ghichu).HasMaxLength(255);

                entity.Property(e => e.MaDv)
                    .HasMaxLength(255)
                    .HasColumnName("Ma_Dv");

                entity.Property(e => e.MucLuong).HasColumnName("Muc_Luong");

                entity.Property(e => e.Ngach205)
                    .HasMaxLength(255)
                    .HasColumnName("Ngach_205");
            });

            modelBuilder.Entity<Trandatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trandata");

                entity.Property(e => e.Buyer)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("buyer")
                    .IsFixedLength(true);

                entity.Property(e => e.Codenotify)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("codenotify")
                    .IsFixedLength(true);

                entity.Property(e => e.Codetau)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("codetau")
                    .IsFixedLength(true);

                entity.Property(e => e.Ico)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ico");

                entity.Property(e => e.ImCountry)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("im_country")
                    .IsFixedLength(true);

                entity.Property(e => e.LoaiIv)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("loai_iv")
                    .IsFixedLength(true);

                entity.Property(e => e.Nganhang)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nganhang")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayTau)
                    .HasColumnType("datetime")
                    .HasColumnName("ngay_tau");

                entity.Property(e => e.Person)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("person")
                    .IsFixedLength(true);

                entity.Property(e => e.Ref)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ref")
                    .IsFixedLength(true);

                entity.Property(e => e.So)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("so");

                entity.Property(e => e.TsCountry)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ts_country")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TreHanMuaBan>(entity =>
            {
                entity.ToTable("TreHanMuaBan");

                entity.Property(e => e.CanDoi).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DienGiaiBan)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DienGiaiCanDoi)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DienGiaiMua)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.HangHoa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaDv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MaDV");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NhomHang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TreHanBan).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TreHanMua).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Type).HasComment("0: BC tuần, 1: BC tháng");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TruongCa>(entity =>
            {
                entity.ToTable("TruongCa");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TruongCa1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("TruongCa");
            });

            modelBuilder.Entity<TyGiaGiaoBan>(entity =>
            {
                entity.ToTable("TyGiaGiaoBan");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TyGia).HasColumnType("money");
            });

            modelBuilder.Entity<TyGium>(entity =>
            {
                entity.Property(e => e.EntDate).HasColumnType("date");

                entity.Property(e => e.TyGia).HasColumnType("money");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("Unit");

                entity.Property(e => e.TiLe)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Unit1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Unit");

                entity.Property(e => e.UnitSub)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserBranch>(entity =>
            {
                entity.ToTable("UserBranch");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserMessage");

                entity.Property(e => e.ActId).HasColumnName("Act_Id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<UserRight>(entity =>
            {
                entity.HasKey(e => e.UserName1);

                entity.ToTable("UserRight");

                entity.Property(e => e.UserName1).HasMaxLength(50);

                entity.Property(e => e.Approve).HasDefaultValueSql("((0))");

                entity.Property(e => e.AutoMaticSms)
                    .HasColumnName("AutoMaticSMS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CloseDoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputerInfor)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteDoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.DownloadDoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.FullName1)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FullViewConTract).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsDepartmentLeader).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUnitLeader).HasDefaultValueSql("((0))");

                entity.Property(e => e.PassWord1).HasMaxLength(250);

                entity.Property(e => e.ReadOnlyAllForm).HasDefaultValueSql("((0))");

                entity.Property(e => e.RememberPw)
                    .HasColumnName("RememberPW")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowAll)
                    .HasMaxLength(10)
                    .HasColumnName("showAll")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ShowAllDoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowContractReminder).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowCustomerReminder).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowNhansu).HasComment("0-Nhân viên, 1-Lãnh đạo phòng, 2-Admin : thấy toàn bộ");

                entity.Property(e => e.Signer).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))")
                    .HasComment("0: chưa active - 1: đã active");

                entity.Property(e => e.StatusUpdate).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();

                entity.Property(e => e.ViewAllStock)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ViewMeetingDoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewPresentation).HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.WebPermission).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ViewNhapHang>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_NhapHang");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ViewXuatHang>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_XuatHang");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwContractConnect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Contract_Connect");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Don_Gia");

                entity.Property(e => e.GiaTri)
                    .HasColumnType("decimal(38, 9)")
                    .HasColumnName("Gia_Tri");

                entity.Property(e => e.MaHang)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Hang");

                entity.Property(e => e.Macn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("macn")
                    .IsFixedLength(true);

                entity.Property(e => e.Makhach)
                    .HasMaxLength(50)
                    .HasColumnName("makhach");

                entity.Property(e => e.MuaBan)
                    .HasMaxLength(50)
                    .HasColumnName("mua_ban");

                entity.Property(e => e.Ngaygiao)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaygiao");

                entity.Property(e => e.Ngayky)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayky");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(38, 3)")
                    .HasColumnName("So_Luong");

                entity.Property(e => e.Sohd)
                    .HasMaxLength(50)
                    .HasColumnName("sohd");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.TenKhach)
                    .HasMaxLength(254)
                    .HasColumnName("ten_khach");

                entity.Property(e => e.Tiente)
                    .HasMaxLength(10)
                    .HasColumnName("tiente")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwInvoiceConnect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Invoice_Connect");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("amount");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .HasColumnName("bill_no");

                entity.Property(e => e.Buyer)
                    .IsRequired()
                    .HasColumnName("buyer");

                entity.Property(e => e.Cbuyer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("cbuyer");

                entity.Property(e => e.DateBill)
                    .HasColumnType("date")
                    .HasColumnName("date_bill");

                entity.Property(e => e.DateHd)
                    .HasColumnType("datetime")
                    .HasColumnName("date_hd");

                entity.Property(e => e.DateIv)
                    .HasColumnType("datetime")
                    .HasColumnName("date_iv");

                entity.Property(e => e.Gia).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Goods).HasColumnName("goods");

                entity.Property(e => e.Invoice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("invoice");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.Makhach)
                    .HasMaxLength(50)
                    .HasColumnName("makhach");

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("payment");

                entity.Property(e => e.Shd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("shd");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("So_luong");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.Tokhai).IsRequired();
            });

            modelBuilder.Entity<VwTonghopHdmb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Tonghop_HDMB");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .HasColumnName("Bill_No");

                entity.Property(e => e.DateBill)
                    .HasColumnType("datetime")
                    .HasColumnName("date_Bill");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("Don_Gia");

                entity.Property(e => e.GiaTri)
                    .HasColumnType("decimal(38, 9)")
                    .HasColumnName("Gia_Tri");

                entity.Property(e => e.MaHang)
                    .HasMaxLength(20)
                    .HasColumnName("Ma_Hang");

                entity.Property(e => e.Macn)
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.Makhach)
                    .HasMaxLength(50)
                    .HasColumnName("makhach");

                entity.Property(e => e.Ngayky)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayky");

                entity.Property(e => e.SoLuong)
                    .HasColumnType("decimal(38, 3)")
                    .HasColumnName("So_Luong");

                entity.Property(e => e.Sohd)
                    .HasMaxLength(50)
                    .HasColumnName("sohd");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("systemref");

                entity.Property(e => e.TenKhach)
                    .HasMaxLength(254)
                    .HasColumnName("Ten_khach");
            });

            modelBuilder.Entity<Xa>(entity =>
            {
                entity.ToTable("Xa");

                entity.Property(e => e.HuyenName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Huyen)
                    .WithMany(p => p.Xas)
                    .HasForeignKey(d => d.HuyenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Xa_Huyen");
            });

            modelBuilder.Entity<Xeptai>(entity =>
            {
                entity.ToTable("xeptai");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aprove).HasColumnName("aprove");

                entity.Property(e => e.GhiChu)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("ghi_chu");

                entity.Property(e => e.HopDong)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("hop_dong");

                entity.Property(e => e.IsHoanThanh).HasColumnName("isHoanThanh");

                entity.Property(e => e.Iscan).HasColumnName("iscan");

                entity.Property(e => e.KhachHang)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("khach_hang");

                entity.Property(e => e.MaKhach)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ma_khach");

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("macn");

                entity.Property(e => e.Mahang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mahang");

                entity.Property(e => e.NgayVao)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaycan)
                    .HasColumnType("date")
                    .HasColumnName("ngaycan");

                entity.Property(e => e.PhieuNhapKho)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SoBao).HasColumnName("So_Bao");

                entity.Property(e => e.SoXe)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("so_xe");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))")
                    .HasComment("1- đang chờ lấy mẫu; 2 đã kiểm tra mẫu OK, 3 Kiểm tra mẫu không đạt; 4 trả về ");

                entity.Property(e => e.Tenhang)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("tenhang");

                entity.Property(e => e.TlBaobi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tl_baobi");

                entity.Property(e => e.UserApove)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<XuatKho>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XuatKho");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DienGiai)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("dvt")
                    .IsFixedLength(true);

                entity.Property(e => e.Hinhthuc)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("hinhthuc");

                entity.Property(e => e.MaHang)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MaKho)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Macn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("macn")
                    .IsFixedLength(true);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.PhieuNhapXuat)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.RefmuaBan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("refmua_ban")
                    .IsFixedLength(true);

                entity.Property(e => e.Soluong)
                    .HasColumnType("numeric(19, 3)")
                    .HasColumnName("soluong");

                entity.Property(e => e.Systemref)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("systemref")
                    .IsFixedLength(true);

                entity.Property(e => e.Trongluong)
                    .HasColumnType("numeric(19, 3)")
                    .HasColumnName("trongluong");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
