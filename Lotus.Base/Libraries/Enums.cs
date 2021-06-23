using System.ComponentModel;
namespace Lotus.Libraries
{
    public enum AlertType
    {
        Done = 0,
        Error = 1,
        Info = 2
    }

    public enum ChucDanh
    {
        [Description("Văn Thư hành chính")]
        VTHC = 0,
        [Description("Văn thư nghiệp vụ")]
        VTNV = 1,
        [Description("Chuyên viên")]
        CHUYENVIEN = 2,
        [Description("Lãnh đạo Phòng")]
        LANHDAOPHONG = 3,
        [Description("Lãnh đạo Chi nhánh")]
        LANHDAOCHINHANH = 4,
        [Description("Admin")]
        Admin = 5,
    }

    public enum NoiQuanLy
    {
        [Description("Hội sở Chính")]
        TSC = 0,
        [Description("Chi nhánh TPHCM")]
        CNHCM = 1,
    }

    public enum Buoi
    {
        [Description("Buổi sáng")]
        MORNING = 0,
        [Description("Buổi chiều")]
        AFTERNOON = 1,
    }

    public enum Status
    {
        [Description(@"Chờ xử lý")]
        PENDING = 0,
        [Description(@"Chuyển Phòng nghiệp vụ")]
        TRANSFERED = 1,
        [Description(@"Đã xử lý")]
        APPROVED = 3,
        [Description(@"Sai, trả về")]
        DENY = 2,
    }

    public enum LoaiSo
    {
        [Description(@"Sổ công văn đến")]
        CONGVANDEN = 0,
        [Description(@"Sổ chứng từ Phòng Đăng ký")]
        CTNVPHONGDK = 1,
        [Description(@"Sổ lấy số chứng từ đến")]
        CTNV = 2,
        [Description(@"Sổ giao TVLK")]
        SOGIAOTVLK = 3,
        [Description(@"Sổ nhận chứng từ qua đường thư")]
        CTNV_MAIL = 4,
        [Description(@"Sổ văn bản đi")]
        VBDI = 5,
        [Description(@"Sổ chuyển giao văn bản nội bộ")]
        SOGIAOVBNOIBO = 6,
    }

    public enum Condition_Operator
    {
        [Description(@"LIKE")]
        LIKE = 0,
        [Description(@"NOT LIKE")]
        NOTLIKE = 1,
        [Description(@"=")]
        EQUAL = 2,
        [Description(@">")]
        LARGER = 3,
        [Description(@">=")]
        LARGEROREQUAL = 4,
        [Description(@"<")]
        SMALLER = 5,
        [Description(@"<=")]
        SMALLEROREQUAL = 6,
    }
    public enum FieldType
    {
        [Description(@"Chuỗi")]
        STRING = 0,
        [Description(@"Số")]
        NUMBER = 1,
        [Description(@"Ngày tháng")]
        DATE = 2,
        [Description(@"Mặc định")]
        DEFAULT = 3,
    }
}