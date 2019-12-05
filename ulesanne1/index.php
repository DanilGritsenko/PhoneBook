<?php
$phonebook = simplexml_load_file("phonebook.xml");
$counter = 0;
$phone = $phonebook -> phone;
// name - название раздела xml
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

?>

<!DOCTYPE html>
<html>
  <head>
    <title>XML Reading</title>
    <meta charset="utf-8"/>
        <link rel="stylesheet" type="text/css" href="css/skeleton.css" />
    </head>
    <body>
      <h1>XML Reading from phonebook</h1>
	  <h5>
	  <?php
		  echo "First entry:".($phone[0] -> name)." ".($phone[0] -> surname);
	  ?>
	  </h3>
      <h3>Table</h3>
	  
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
            <!-- Действие этой формы будет происходить в этом файле - form action="?"-->
            <form action="?" method="post"> 
               Search: <input type="text" name="search" placeholder="Name" />
                Find by ID<input type="radio" name="radiofind" value="name" checked/>
                Find by Name<input type="radio" name="radiofind" value="cpu" />
                Find by Surname<input type="radio" name="radiofind" value="gpu" />
				Find by Number<input type="radio" name="radiofind" value="num" />
                <input type="submit" value="Find" />
                
            </form>
            <table class="u-full-width">
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Surname</th>
                    <th>Number</th>
                    <th>Email</th>
                </tr>
                <?php
                if (!empty($_POST["search"])){
                    $answer = $_POST['radiofind'];
                    if ($answer == "name"){
						try{
                        $result = searchByID($_POST["search"]);
						}
						catch(Exception $e){
						echo "Syntax Error";}
									
                    }
                    else if($answer == "cpu"){
						try{
                        $result = searchByName($_POST["search"]);
						}
						catch(Exception $e){
						echo "Syntax Error";}
                    }
                    else if($answer == "gpu"){
						try{
                        $result = searchBySurname($_POST["search"]);
						}
						catch(Exception $e){
						echo "Syntax Error";}
                    }
					else if($answer == "num"){
						try{
                        $result = searchByNum($_POST["search"]);
						}
						catch(Exception $e){
						echo "Syntax Error";}
                    }
                    foreach($result as $phone){
						$counter++;
                        echo "<tr>";
                        echo "<td>".($phone -> id)."</td>";
						echo "<td>".($phone -> name)."</td>";
						echo "<td>".($phone -> surname)."</td>";
						echo "<td>".($phone -> number)."</td>";
						echo "<td>".($phone -> email)."</td>";
                        echo "</tr>";
                    }
					echo "Found ".($counter)." entries";
					}
                ?>
				
            </table>
    </body>
</html>