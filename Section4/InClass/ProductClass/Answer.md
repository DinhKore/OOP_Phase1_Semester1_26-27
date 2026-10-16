1. 
- name: Phải là private kèm với setter/property có kiểm tra tính hợp lệ (ví dụ: chuỗi không được để rỗng).  
- price: Phải là private kèm với setter/property có kiểm tra tính hợp lệ (ví dụ: không được là số âm).  
- stockQuantity: Phải là private kèm với setter/property có kiểm tra tính hợp lệ (ví dụ: không được nhỏ hơn 0).  
- internalCostPrice: Phải là private để giấu kín dữ liệu nội bộ của lớp.

2. 
- Đó là field: internalCostPrice
-> bởi vì là thường chỉ được thiết lập một lần khi nhập dữ liệu qua hàm khởi tạo (constructor).  Việc đóng hoàn toàn quyền thay đổi (không có setter) giúp bảo vệ tính toàn vẹn của đối tượng, tuân thủ nguyên tắc đóng gói (encapsulation) để ngăn các đoạn code bên ngoài làm sai lệch dữ liệu tài chính.

3. 
// Cho phép đọc và ghi (có validation bên trong thân hàm)
public String getName();
public void setName(String name);

public double getPrice();
public void setPrice(double price);

public int getStockQuantity();
public void setStockQuantity(int quantity);

// Chỉ cho phép đọc (Read-only), tuyệt đối KHÔNG viết hàm setInternalCostPrice()
public double getInternalCostPrice();