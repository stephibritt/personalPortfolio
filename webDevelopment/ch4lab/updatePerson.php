<?php
    require_once('database.php');
    
    $person_id = filter_input(INPUT_POST, 'person_id', FILTER_VALIDATE_INT);
    $firstName = filter_input(INPUT_POST, 'firstName');
    $lastName = filter_input(INPUT_POST, 'lastName');
    $email = filter_input(INPUT_POST, 'email', FILTER_VALIDATE_EMAIL);
    $phone = filter_input(INPUT_POST, 'phone');
    
    // set error message to an empty string
    $errorMessage = "";
    
    //if an error message exist, return to index.php
    if ($errorMessage != "") {
        include("updatePersonForm.php");
        exit();
    } // end if
    
    if (!empty($firstName) && !empty($lastName) && !empty($email) && !empty($phone)) {
        require_once('database.php');

        // update all fields of the person table  
        $updateQuery = 'UPDATE person
            SET first_name = :first_name, last_name = :last_name, email = :email, phone = :phone
            WHERE person_id = :person_id';
        $statement = $db->prepare($updateQuery);
        $statement->bindValue(':person_id', $person_id);
        $statement->bindValue(':first_name', $firstName);
        $statement->bindValue(':last_name', $lastName);
        $statement->bindValue(':email', $email);
        $statement->bindValue(':phone', $phone);
        $success = $statement->execute();
        $statement->closeCursor();
    } else if (!empty($firstName) && !empty($lastName) && !empty($email) && empty($phone)) {
        require_once('database.php');

        // update first name, last name, and email
        $updateQuery = 'UPDATE person
            SET first_name = :first_name, last_name = :last_name, email = :email
            WHERE person_id = :person_id';
        $statement = $db->prepare($updateQuery);
        $statement->bindValue(':person_id', $person_id);
        $statement->bindValue(':first_name', $firstName);
        $statement->bindValue(':last_name', $lastName);
        $statement->bindValue(':email', $email);
        $success = $statement->execute();
        $statement->closeCursor();
    } else if (!empty($firstName) && !empty($lastName) && empty($email) && !empty($phone)) {
        require_once('database.php');

        // update first name, last name, and phone
        $updateQuery = 'UPDATE person
            SET first_name = :first_name, last_name = :last_name, phone = :phone
            WHERE person_id = :person_id';
        $statement = $db->prepare($updateQuery);
        $statement->bindValue(':person_id', $person_id);
        $statement->bindValue(':first_name', $firstName);
        $statement->bindValue(':last_name', $lastName);
        $statement->bindValue(':phone', $phone);
        $success = $statement->execute();
        $statement->closeCursor();
    } else if (!empty($firstName) && !empty($lastName) && empty($email) && empty($phone)) {
        require_once('database.php');

        // update first name and last name
        $updateQuery = 'UPDATE person
            SET first_name = :first_name, last_name = :last_name
            WHERE person_id = :person_id';
        $statement = $db->prepare($updateQuery);
        $statement->bindValue(':person_id', $person_id);
        $statement->bindValue(':first_name', $firstName);
        $statement->bindValue(':last_name', $lastName);
        $success = $statement->execute();
        $statement->closeCursor();
    } // end if
    
    $updatedMessage = "$firstName $lastName has been updated.";
    
    include("viewPerson.php");
?>