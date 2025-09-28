# Baitap1-Wed
# Đề bài:
DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.
# Bài Làm:
# Đề tài: Ứng dụng “UniqueArt” – Tạo và hiển thị nghệ thuật ASCII/HashArt trên Web
# Cách làm:
# 1.DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
# Tạo Project
# <img width="1920" height="1200" alt="Screenshot 2025-09-28 125116" src="https://github.com/user-attachments/assets/7e97d498-5d29-40fc-90cd-a438f827d2db" />
# kết quả 
# <img width="1920" height="1200" alt="Screenshot 2025-09-27 141237" src="https://github.com/user-attachments/assets/22bacc4a-6e22-4d02-96b4-99a5be471729" />
# <img width="1920" height="1200" alt="Screenshot 2025-09-27 141259" src="https://github.com/user-attachments/assets/b27adfc7-6f6c-4d22-b323-b7a9864c8e81" />
# <img width="1920" height="1200" alt="Screenshot 2025-09-27 141313" src="https://github.com/user-attachments/assets/b553e55c-c594-4ade-98b6-a64cae65e6b3" />
# <img width="1920" height="1200" alt="Screenshot 2025-09-27 141330" src="https://github.com/user-attachments/assets/5e98516c-44e3-4524-ad8f-47a3c3e8f6ad" />
# <img width="1920" height="1200" alt="Screenshot 2025-09-27 141344" src="https://github.com/user-attachments/assets/c1662da0-3354-4aff-b5f5-72aa19ce1c31" />
# 2.Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
# Tạo Project 
# <img width="960" height="600" alt="image" src="https://github.com/user-attachments/assets/3a4ecaef-f251-4b51-8c0d-fbee2e85bbc1" />
#  Kết quả
# <img width="1146" height="632" alt="Screenshot 2025-09-27 141608" src="https://github.com/user-attachments/assets/e38bb2a7-2caa-462b-b29a-a24f9a8d41ba" />
# 3.+ Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
# Tạo Project
# <img width="960" height="600" alt="image" src="https://github.com/user-attachments/assets/bae7b574-9314-42e9-88fe-b12d73224223" />
# Kết quả
# <img width="1920" height="1200" alt="Screenshot 2025-09-27 142651" src="https://github.com/user-attachments/assets/a57b526a-8add-467f-a267-f48835d125e7" />
# 4.Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework)
# Tạo Project
# <img width="960" height="600" alt="image" src="https://github.com/user-attachments/assets/e4bcb5aa-aaba-49af-b6e8-95bb11af55fa" />
# Cấu hình IIS
# <img width="1920" height="1200" alt="Screenshot 2025-09-27 150614" src="https://github.com/user-attachments/assets/a806e1c9-71e4-4cd7-9bf2-2de64ea4a218" />
# kết quả
# <img width="1920" height="1200" alt="Screenshot 2025-09-27 150614" src="https://github.com/user-attachments/assets/ff634c8f-5cae-4511-9779-d228b164b3fd" />


