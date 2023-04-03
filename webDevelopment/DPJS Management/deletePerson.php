<?php
    require_once('database.php');

    // Get IDs
    $person_id = filter_input(INPUT_POST, 'person_id', FILTER_VALIDATE_INT);
    $firstName = filter_input(INPUT_POST, 'firstName');
    $lastName = filter_input(INPUT_POST, 'lastName');

    // Delete the person from the database
    if ($person_id !== FALSE) {
        $deleteQuery = 'DELETE FROM person
                  WHERE person_id = :person_id';
        $statement = $db->prepare($deleteQuery);
        $statement->bindValue(':person_id', $person_id);
        $success = $statement->execute();
        $statement->closeCursor();    
    }

    $deletedMessage = "$firstName $lastName has been deleted.";
    
    include('viewPerson.php');
?>