Книга Контактов
Документация по первой части задания (PHP + XML)
Задание
- Создать веб-страницу книги контактов, с помощью которой, пользователь сможет искать нужный контакт по определённому параметру.
 
Этапы
* Создать XML файл, содержащий 2-3 логических диапозона.
* XML файл должен содержать ID, имя, фамилию, номер телефона и адрес электронной почты.
* Отображение данных в таблице HTML, при помощи PHP.
* Придумать 3 функции.
* Поиск по различным параметрам.
* Добавление нового контакта.
* Редактирование уже существующего контакта.

XML Файл

```
<book>
	<phone>
		<id>1</id>
		<name>Danil</name>
		<surname>Gritsenko</surname>
		<number>56651975</number>
		<email>danil.gritsenko3@gmail.com</email>
	</phone>
	<phone>
		<id>2</id>
		<name>Kirill</name>
		<surname>Lavrov</surname>
		<number>42935865</number>
		<email>kirill546@mail.ru</email>
	</phone>
	<phone>
		<id>3</id>
		<name>Daniil</name>
		<surname>Vatsyk</surname>
		<number>58472548</number>
		<email>vatsyk@gmail.com</email>
	</phone>
	<phone>
		<id>4</id>
		<name>Vadim</name>
		<surname>Vassiltsenko</surname>
		<number>54715689</number>
		<email>redsniper@gmail.com</email>
	</phone>
	<phone>
		<id>5</id>
		<name>Kevin</name>
		<surname>Konstantinov</surname>
		<number>54756126</number>
		<email>kevin12@gmail.com</email>
	</phone>
</book>
```

Чтение XML файла
```
$phonebook = simplexml_load_file("phonebook.xml");
```
Вывод таблицы всех контактов
```
<table class="u-full-width">
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Surname</th>
                    <th>Phone</th>
                    <th>Email</th>
                </tr>
                <?php
        foreach($phonebook -> phone as $phone){
          echo "<tr>";
          echo "<td>".($phone -> id)."</td>";
          echo "<td>".($phone -> name)."</td>";
          echo "<td>".($phone -> surname)."</td>";
          echo "<td>".($phone -> number)."</td>";
          echo "<td>".($phone -> email)."</td>";
          echo "</tr>";
        }
                $counter = 0;
                ?>
            </table>
```
Функция поиска по имени
```
function searchByName($query) {
    global $phonebook;
    $result = array();
	try{
    foreach($phonebook -> phone as $phone)
        if (substr(strtolower($phone -> name), 0, strlen($query)) == strtolower($query)){
            array_push($result, $phone);
        }
	}
	catch(Exception $e){
		echo "Syntax Error";
	}
    return $result;
}
```
Функция поиска по фамилии
```
function searchBySurname($query) {
    global $phonebook;
    $result = array();
	try{
    foreach($phonebook -> phone as $phone)
        if (substr(strtolower($phone -> surname), 0, strlen($query)) == strtolower($query)){
            array_push($result, $phone);
        }
	}
	catch(Exception $e){
		echo "Syntax Error";
	}
    return $result;
}  
```
Функция поиска по номеру телефона
```
function searchByNum($query) {
    global $phonebook;
    $result = array();
	try{
    foreach($phonebook -> phone as $phone)
        if (substr(strtolower($phone -> number), 0, strlen($query)) == strtolower($query)){
            array_push($result, $phone);
        }
	}
	catch(Exception $e){
		echo "Syntax Error";
	}
    return $result;
}  
```
Функция поиска по ID
```
function searchByID($query) {
    global $phonebook;
    $result = array();
	try{
    foreach($phonebook -> phone as $phone)
        if (substr(strtolower($phone -> id), 0, strlen($query)) == strtolower($query)){
            array_push($result, $phone);
        }
	}
	catch(Exception $e){
		echo "Syntax Error";
	}
    return $result;
}
```
