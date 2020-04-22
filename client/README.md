** Virtual DOM **
công nghệ ảo hóa html bằng js

render: xuất ra màn hình

ASP .NET CORE 
ASP dính với c# , củng là 1 frameowrk của js

java spring
spring cũng giống ASP

backend => API ( c#, node , java,..)
        /\
        ||
    axios ( client )
        ||

        \/
fontend => ASP, React, Angular, Vue,...

### Tạo => export ; lấy ra => import

### React

- chạy project: npm start

- map phải có key trong component

- className chứ ko phải class

- thần chú: rafce

## props

- object của [bên ngoài component truyền vào]

- object, callback, number, string,...

### callback

- là func làm tham số cho một func khác

### slow competiter
(khi nào nên dùng ...)
- object và array nó sẽ lưu dạng index
vd: arr=[1,2,4]
arr => 1FDV

- obj1 so sánh obj2
chỉ so sánh giá trị của index



### useState

- lưu lại dữ liệu tạm thời trong 1 component

- [sẵn có (tùy ý dev)]

- mổi lần update state thì component bị render

### useEffect

- sau khi component render thì nó sẽ chạy vào useEffect

- 2 tham số:

+ callback

+ array dependency ( dependency là những đối tượng mà callback phụ thuộc vào (func) )

- công dụng: gọi hàm lấy dữ liệu CRUD từ API

### Redux
- là store lưu trữ gobal state, action

- componrnt sẽ dùng state trong redux thay vì dùng trong App component

- state trong component bị thay đổi => những component dùng state đó sẽ được update theo

B1: định nghĩa type ( CONSTANT )
B2: tạo action dựa trên type
(action nói chuyện với reducer thì sẽ dùng dispatch)
B3: tạo thêm switch case với reducer tương ứng

** lưu ý; chỉ có App component mới có Provider

### useSelector

- dùng để xuống redux lấy state trong reducer

### useDispatch

