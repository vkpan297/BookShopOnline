create database BookShop

use BookShop

CREATE TABLE LoaiSach(
IDLoai int primary key identity,
TenLoai nvarchar(50)

)
insert into LoaiSach values(N'Toán');
insert into LoaiSach values(N'Hoá');
insert into LoaiSach values(N'Văn');
insert into LoaiSach values(N'Sinh');
insert into LoaiSach values(N'Địa');
insert into LoaiSach values(N'Truyện Buồn');
insert into LoaiSach values(N'Truyện Hài Hước');
insert into LoaiSach values(N'Truyện Tiểu Thuyết');
insert into LoaiSach values(N'Truyện Trinh Thám');
insert into LoaiSach values(N'Truyện Ngôn tình');

drop table LoaiSach



create table Sach(
IDSach int primary key identity,
TenSach nvarchar(50),
SoLuong int,
Gia int,
MaLoai int,
SoTap int,
Anh nvarchar(900),
NgayNhap datetime,
TacGia nvarchar(50),
Mota nvarchar(900)
foreign key(MaLoai) references LoaiSach(IDLoai),
)
drop table Sach
insert into Sach values(N'Những Gì Đã Qua Đừng Nghĩ Lại Quá Nhiều',5,36.000,6,3,N'buon1.jpg',GetDate(),N'Minh Mẫn',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Mình Sẽ Đi Cuối Đất Cùng Trời',5,98.000,6,3,N'buon2.jpg',GetDate(),N'Nguyễn Phong Việt',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Có Một Cô Gái Thầm Yêu Anh',5,53.000,6,3,N'buon3.jpg',GetDate(),N'Pham Anh Thư',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Nếu Chỉ Còn Một Ngày Để Sống',5,45.000,6,3,N'buon4.jpg',GetDate(),N' Nicola Yoon',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Vẫn Ổn Thôi , Kể Cả Khi Bạn Không Có Ước Mơ',5,40.000,6,3,N'buon5.jpg',GetDate(),N' Park Seung Oh,',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Có Những Thứ Đẹp Hơn Cả Tình Yêu',5,39.000,6,3,N'buon6.jpg',GetDate(),N' Tử An',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');











insert into Sach values(N'Tịch Mịch',5,92.000,10,3,N'ngontinh1.jpg',GetDate(),N'Phỉ Ngã Tư Tồn',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Khách Bộ Hành Thời Gian',5,108.000,10,3,N'ngontinh2.jpg',GetDate(),N'Mộc Phù Sinh',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Gió Ngừng Thổi, Tình Còn Vương',5,75.000,10,3,N'ngontinh3.jpg',GetDate(),N'Diệp Lạc Vô Tâm',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Ngập Tràn Yêu Thương',5,100.000,10,3,N'ngontinh4.jpg',GetDate(),N'Cố Tây Tước',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Anh Có Thích Nước Mỹ Không',5,107.000,10,3,N'ngontinh5.jpg',GetDate(),N'Tân Di Ổ',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Anh Không Thích Thế Giới Này, Anh Chỉ Thích Em',5,85.000,10,3,N'ngontinh6.jpg',GetDate(),N'Kiều Nhất',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');







insert into Sach values(N'Hờn cả thế giới ',5,61.000,7,3,N'haihuoc1.jpg',GetDate(),N'Cynical Chick',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Đời Về Cơ Bản Là Buồn Cười',5,57.000,7,3,N'haihuoc2.jpg',GetDate(),N'Lê Bích',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Hài Hước Một Chút Thế Giới Sẽ Khác Đi',5,56.000,7,3,N'haihuoc3.jpg',GetDate(),N'The Book Worm',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Phụ Nữ Cười',5,36.000,7,3,N'haihuoc4.jpg',GetDate(),N'Ngọc Hà',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');










insert into Sach values(N'Khi Nhìn Thấy Lời Nói Dối Tôi Đã Yêu Em Thật Lòng',5,49.000,8,3,N'tieuthuyet1.jpg',GetDate(),N'Sakurai Mina',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Anh Từng Hứa Sẽ Không Quên',5,75.000,8,3,N'tieuthuyet2.jpg',GetDate(),N'Mizuho Hirayama',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Tình Yêu Không Phải Thứ Để Dành',5,48.000,8,3,N'tieuthuyet3.jpg',GetDate(),N'Nguyễn Phước Huy',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Các Thế Giới Song Song',5,115.000,8,3,N'tieuthuyet4.jpg',GetDate(),N' Nicola Yoon',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Tôi Quyết Định Sống Cho Chính Tôi ',5,43.000,8,3,N'tieuthuyet5.jpg',GetDate(),N'Kim Suhyun,',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Bạn Thân',5,46.000,8,3,N'tieuthuyet16.jpg',GetDate(),N'Michael Sieben',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');








insert into Sach values(N'Kỳ Án Ánh Trăng',5,90.000,9,3,N'trinhtham1.jpg',GetDate(),N' Quỷ Cổ Nữ',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Hắc Miêu Quán ',5,71.000,9,3,N'trinhtham2.jpg',GetDate(),N'Yukito Ayatsuji',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Mặt Nạ Trắng',5,48.000,9,3,N'trinhtham3.jpg',GetDate(),N'Kim Tam Long',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Cô gái có hình xăm rồng',5,115.000,9,3,N'trinhtham4.jpg',GetDate(),N' Nicola Yoon',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'TỘI LỖI KHÔNG CHỨNG CỨ',5,43.000,9,3,N'trinhtham5.jpg',GetDate(),N'Kim Suhyun,',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');
insert into Sach values(N'Những Cuộc Phiêu Lưu Của Huckleberry Finn',5,87.000,9,3,N'trinhtham6.jpg',GetDate(),N'MarkTwain',N'Cách đây 3 năm, “Những gì đã qua đừng nghĩ lại quá nhiều” trở thành cuốn sách bestseller trên khắp các bảng xếp hạng. Liên tục tái bản ngay sau đó, nhận được vô số những phản hồi tích cực từ độc giả, những ai chưa từng đọc thì vô cùng tiếc nuối. Lần trở lại này, “em nhỏ” được thay áo mới vô cùng xinh xắn!

Cuốn sách là sự kết hợp tuyệt vời giữa hai nhà văn trẻ nổi tiếng: Minh Mẫn và Du Phong hứa hẹn sẽ đem đến cho những tâm hồn đang tổn thương sự vui vẻ và nhẹ nhõm trước những nỗi đau quá khứ.

Những ai từng mất rất nhiều thời gian để quên đi một mối tình khắc cốt ghi tâm. Ai còn mang nặng nỗi đau quá khứ, những người còn chưa đành lòng quên đi một tình cảm đau khổ hay những người cứ mãi day dứt, băn khoăn về một việc đã qua');






insert into Sach values(N'Toán 1',5,90.000,1,3,N'toan1.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Toán 2',5,71.000,1,3,N'toan2.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Toán 3',5,48.000,1,3,N'toan3.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Toán 4',5,115.000,1,3,N'toan4.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Toán 5',5,43.000,1,3,N'toan5.jpg',GetDate(),N'Bộ GD và ĐT',N'');

insert into Sach values(N'Hoá 8',5,90.000,2,3,N'hoa8.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Hoá 9',5,71.000,2,3,N'hoa9.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Hoá 10',5,48.000,2,3,N'hoa10.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Hoá 11',5,115.000,2,3,N'hoa11.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Hoá 12',5,43.000,2,3,N'hoa12.jpg',GetDate(),N'Bộ GD và ĐT',N'');

insert into Sach values(N'Văn 1',5,90.000,3,3,N'van1.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Văn 2',5,71.000,3,3,N'van2.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Văn 3',5,48.000,3,3,N'van3.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Văn 4',5,115.000,3,3,N'van4.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Văn 5',5,43.000,3,3,N'van5.jpg',GetDate(),N'Bộ GD và ĐT',N'');

insert into Sach values(N'Sinh 8',5,90.000,4,3,N'sinh8.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Sinh 9',5,71.000,4,3,N'sinh9.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Sinh 10',5,48.000,4,3,N'sinh10.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Sinh 11',5,115.000,4,3,N'sinh11.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Sinh 12',5,43.000,4,3,N'sinh12.jpg',GetDate(),N'Bộ GD và ĐT',N'');

insert into Sach values(N'Địa 6',5,90.000,5,3,N'dia6.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Địa 7',5,71.000,5,3,N'dia7.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Địa 8',5,48.000,5,3,N'dia8.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Địa 9',5,115.000,5,3,N'dia9.jpg',GetDate(),N'Bộ GD và ĐT',N'');
insert into Sach values(N'Địa 10',5,43.000,5,3,N'dia10.jpg',GetDate(),N'Bộ GD và ĐT',N'');


create table Account(
ID int primary key identity,
UserName nvarchar(50),
Password nvarchar(50),
Name nvarchar(50),
Address  nvarchar(50),
Email nvarchar(50),
Phone nvarchar(50),
NgayTao datetime,
Status int
)
drop table Account
insert into Account values('admin','123','Kien','HaNoi','abc@gmail.com','123456789',GETDATE(),1);
insert into Account values('user','456','Cuong','HaNoi','abc123@gmail.com','123456789',GETDATE(),2);

create table HoaDon(
MaHoaDon int primary key identity,
MaKh int,
NgayNhap datetime,
Status int,
TenNguoiNhan nvarchar(50),
SdtNguoiNhan nvarchar(50),
DiaChiNguoiNhan nvarchar(50),
EmailNguoiNhan nvarchar(50) 

foreign key(MaKh) references Account(ID),
)
drop table HoaDon

create table ChiTietHoaDon(
MaChiTietHoaDon int primary key identity,
MaSach int,
MaHoaDon int,
SoLuongMua int,
Gia int


foreign key(MaSach) references Sach(IDSach),
foreign key(MaHoaDon) references HoaDon(MaHoaDon),
)

drop table ChiTietHoaDon


CREATE TABLE TinTuc (
  matt int primary key identity,
  tieude nvarchar(200),
  hinhanh nvarchar(100) ,
  noidung nvarchar(900) ,
  ngaydang datetime
) 

CREATE TABLE LienHe (
  malh int primary key identity,
  tennguoilh nvarchar(50),
  sdtnguoilh int ,
  emailnguoilh nvarchar(50)  ,
  diachinguoilh nvarchar(50)  ,
  noidung nvarchar(255)  ,
  ngaylh datetime 
)



CREATE TABLE KhachHang (
  makh int primary key identity,
  hokh nvarchar(20) ,
  tenkh nvarchar(20) ,
  sdt int ,
  diachi nvarchar(50),
  email nvarchar(30) ,
  gioitinh nvarchar(50),
  tendn nvarchar(20) ,
  matkhau nvarchar(20)
)

select S.IDSach,S.TenSach,S.SoLuong,S.Gia,LS.TenLoai,S.SoTap,S.Anh,S.NgayNhap,S.TacGia,S.MoTa from Sach as S join LoaiSach as LS  on S.MaLoai=LS.IDLoai



SELECT P.Ten,KH.Ten,BTP.NgayDat,BTP.CheckIn,BTP.CheckOut from BangThuePhong AS BTP join KhachHang AS KH ON KH.ID=BTP.IDKhachHang join  Phong AS P ON P.ID =BTP.IDPhong where BTP.IDPhong=1 and KH.Ten='a'