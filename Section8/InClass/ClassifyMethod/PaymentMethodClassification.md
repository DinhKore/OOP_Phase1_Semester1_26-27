# IN-CLASS EXERCISE: Classify Each Method (PaymentMethod Hierarchy)

Hệ thống phân cấp: `PaymentMethod` -> `CreditCard`, `CashPayment`, `BankTransfer`

---

### 1. `ProcessPayment(double amount)` -> **`abstract`**
* **Giải thích:** Bởi vì mỗi hình thức thanh toán có cách trừ tiền hoàn toàn khác nhau.
  * Thẻ tín dụng (`CreditCard`): Cần kết nối API cổng thanh toán, kiểm tra số dư và xác thực mã PIN/CVV.
  * Tiền mặt (`CashPayment`): Nhận tiền mặt từ khách và tính toán tiền thừa thối lại.
  * Chuyển khoản (`BankTransfer`): Quét mã VietQR hoặc kiểm tra sao kê/webhook giao dịch ngân hàng.
* Lớp cha không thể có code mặc định dùng chung được, nên bắt buộc phải để `abstract` để ép từng lớp con tự viết logic xử lý riêng của nó.

---

### 2. `PrintReceiptHeader()` -> **`concrete`**
* **Giải thích:** Đề bài đã chỉ rõ nội dung phần đầu hóa đơn này của bên nào cũng giống hệt nhau (*same header text for every payment method*).
* Dù khách hàng quẹt thẻ, trả tiền mặt hay chuyển khoản thì header phiếu thu vẫn in chung tên cửa hàng, địa chỉ, số hotline và định dạng trình bày.
* Vì vậy, ta viết sẵn thân hàm hoàn chỉnh ở lớp cha `PaymentMethod` để các lớp con kế thừa dùng lại, giúp tái sử dụng mã nguồn và tránh trùng lặp code thừa thãi.

---

### 3. `ValidateAmount(double amount)` -> **`concrete`**
* **Giải thích:** Quy tắc kiểm tra số tiền hợp lệ (`amount > 0`) là nguyên tắc dùng chung tuyệt đối cho toàn bộ các loại giao dịch.
* Không có bất kỳ hình thức thanh toán nào chấp nhận giá trị âm hoặc bằng 0.
* Do logic kiểm tra này cố định 100% trên tất cả các lớp con, nên triển khai trực tiếp dạng `concrete` ngay tại lớp cơ sở là tối ưu nhất.

---

### 4. `GetTransactionFee()` -> **`abstract`** *(hoặc `concrete` trả về 0.0)*
* **Giải thích:** Mỗi phương thức thanh toán có một chính sách và biểu phí riêng biệt:
  * `CreditCard`: Thường mất phí phần trăm trên giá trị giao dịch (ví dụ 1.5% - 2.5%).
  * `BankTransfer`: Thường có phí cố định theo lượt giao dịch hoặc được miễn phí tùy ngân hàng.
  * `CashPayment`: Luôn luôn không tốn phí giao dịch (bằng 0).
* Việc đặt là `abstract` sẽ ép buộc lập trình viên khi thêm bất kỳ phương thức thanh toán mới nào cũng bắt buộc phải công bố rõ cơ chế tính phí của nó, tránh việc quên tính phí.