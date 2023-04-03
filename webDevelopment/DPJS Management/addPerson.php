<?php
    // receive data from POST array
    $firstName = filter_input(INPUT_POST, 'firstName');
    $lastName = filter_input(INPUT_POST, 'lastName');
    $email = filter_input(INPUT_POST, 'email', FILTER_VALIDATE_EMAIL);
    $phone = filter_input(INPUT_POST, 'phone');
    
    // set error message to an empty string
    $errorMessage = "";
    
    // validate the data
    if ($firstName === FALSE) {
        $errorMessage = "First name must contain a value.";
    } // end if
    
    if ($lastName === FALSE) {
        $errorMessage = "Last name must contain a value.";
    } // end if
    
    //if an error message exist, return to index.php
    if ($errorMessage != "") {
        include("addPersonForm.php");
        exit();
    } // end if
    
    if (!empty($firstName) && !empty($lastName) && !empty($email) && !empty($phone)) {
        require_once('database.php');

        // add the person to the database  
        $insertQuery = 'INSERT INTO person (first_name, last_name, email, phone)
            VALUES (:first_name, :last_name, :email, :phone)';
        $statement = $db->prepare($insertQuery);
        $statement->bindValue(':first_name', $firstName);
        $statement->bindValue(':last_name', $lastName);
        $statement->bindValue(':email', $email);
        $statement->bindValue(':phone', $phone);
        $statement->execute();
        $statement->closeCursor();
    } else if (!empty($firstName) && !empty($lastName) && !empty($email) && empty($phone)) {
        require_once('database.php');

        // add the person to the database
        $insertQuery = 'INSERT INTO person (first_name, last_name, email)
            VALUES (:first_name, :last_name, :email)';
        $statement = $db->prepare($insertQuery);
        $statement->bindValue(':first_name', $firstName);
        $statement->bindValue(':last_name', $lastName);
        $statement->bindValue(':email', $email);
        $statement->execute();
        $statement->closeCursor();
    } else if (!empty($firstName) && !empty($lastName) && empty($email) && !empty($phone)) {
        require_once('database.php');

        // add the person to the database
        $insertQuery = 'INSERT INTO person (first_name, last_name, phone)
            VALUES (:first_name, :last_name, :phone)';
        $statement = $db->prepare($insertQuery);
        $statement->bindValue(':first_name', $firstName);
        $statement->bindValue(':last_name', $lastName);
        $statement->bindValue(':phone', $phone);
        $statement->execute();
        $statement->closeCursor();
    } else if (!empty($firstName) && !empty($lastName) && empty($email) && empty($phone)) {
        require_once('database.php');

        // add the person to the database
        $insertQuery = 'INSERT INTO person (first_name, last_name)
            VALUES (:first_name, :last_name)';
        $statement = $db->prepare($insertQuery);
        $statement->bindValue(':first_name', $firstName);
        $statement->bindValue(':last_name', $lastName);
        $statement->execute();
        $statement->closeCursor();
    } // end if
    
    $addedMessage = "$firstName $lastName has been added.";
    
    include("viewPerson.php");
?>