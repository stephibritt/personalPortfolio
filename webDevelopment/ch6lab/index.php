<?php
    require_once('model/person_db.php');

    $action = filter_input(INPUT_POST, 'action');
    if ($action == NULL) {
        $action = filter_input(INPUT_GET, 'action');
        if ($action == NULL) {
            $action = 'viewPerson';
        } // end if
    } // end if

    if ($action == 'viewPerson') {
        $people = getPerson();
        
        $addedMessage = filter_input(INPUT_GET, 'addedMessage');
        $updatedMessage = filter_input(INPUT_GET, 'updatedMessage');
        $deletedMessage = filter_input(INPUT_GET, 'deletedMessage');
        include('./viewPerson.php');
    } else if ($action == 'deletePerson') {
        $person_id = filter_input(INPUT_POST, 'person_id', FILTER_VALIDATE_INT);
        $firstName = filter_input(INPUT_POST, 'firstName');
        $lastName = filter_input(INPUT_POST, 'lastName');
        if ($person_id == NULL || $person_id == FALSE) {
            $errorMessage = "There was an error deleting the selected file.";
            include('./viewPerson.php');
        } else { 
            deletePerson($person_id);
            
            $deletedMessage = "$firstName $lastName was deleted.";
            header("Location: .?deletedMessage=$deletedMessage");
        } // end if
    } else if ($action == 'showAddForm') {
        include('./addPerson.php');
    } else if ($action == 'showUpdateForm') {
        $person_id = filter_input(INPUT_POST, 'person_id', FILTER_VALIDATE_INT);
        $firstName = filter_input(INPUT_POST, 'firstName');
        $lastName = filter_input(INPUT_POST, 'lastName');
        $email = filter_input(INPUT_POST, 'email', FILTER_VALIDATE_EMAIL);
        $phone = filter_input(INPUT_POST, 'phone');
        include('./updatePerson.php');
    } else if ($action == 'addPerson') {
        $firstName = htmlspecialchars(filter_input(INPUT_POST, 'firstName'));
        $lastName = htmlspecialchars(filter_input(INPUT_POST, 'lastName'));
        $email = filter_input(INPUT_POST, 'email', FILTER_VALIDATE_EMAIL);
        $phone = filter_input(INPUT_POST, 'phone');
        if ($firstName == NULL || $firstName == FALSE || $lastName == NULL || $lastName == FALSE) {
            $errorMessage = "A file cannot be added without a valid first and last name.";
            include('./viewPerson.php');
        } else { 
            addPerson($firstName, $lastName, $email, $phone);
            
            $addedMessage = "$firstName $lastName was added.";
            header("Location: .?addedMessage=$addedMessage");
        } // end if
    } else if ($action == 'updatePerson') {
        $person_id = filter_input(INPUT_POST, 'person_id', FILTER_VALIDATE_INT);
        $firstName = htmlspecialchars(filter_input(INPUT_POST, 'firstName'));
        $lastName = htmlspecialchars(filter_input(INPUT_POST, 'lastName'));
        $email = filter_input(INPUT_POST, 'email', FILTER_VALIDATE_EMAIL);
        $phone = filter_input(INPUT_POST, 'phone');
        if ($firstName == NULL || $firstName == FALSE || $lastName == NULL || $lastName == FALSE) {
            $errorMessage = "A file cannot be updated without a valid first and last name.";
            include('./viewPerson.php');
        } else { 
            updatePerson($person_id, $firstName, $lastName, $email, $phone);
            
            $updatedMessage = "$firstName $lastName was updated.";
            header("Location: .?updatedMessage=$updatedMessage");
        } // end if
    } else if ($action == 'search') {
        $firstName = htmlspecialchars(filter_input(INPUT_POST, 'firstName'));
        $lastName = htmlspecialchars(filter_input(INPUT_POST, 'lastName'));
        $email = filter_input(INPUT_POST, 'email', FILTER_VALIDATE_EMAIL);
        if (($firstName != NULL || $firstName != FALSE || $lastName != NULL || $lastName != FALSE) && ($email == NULL || $email == FALSE)) {
            $email = "NOT_AVAILABLE";
            
            $people = searchPerson($firstName, $lastName, $email);
            
            include('./viewPerson.php');
        } else {
            $people = searchPerson($firstName, $lastName, $email);
            
            include('./viewPerson.php');
        } // end if
    } else if ($action == 'showPersonCard') {
        $p_person_id = filter_input(INPUT_POST, 'person_id', FILTER_VALIDATE_INT);
        
        $person = viewIndividual($p_person_id);
        
        include('./personCard.php');
        
//        if (($firstName != NULL || $firstName != FALSE || $lastName != NULL || $lastName != FALSE) && ($email == NULL || $email == FALSE)) {
//            $email = "NOT_AVAILABLE";
//            
//            $people = searchPerson($firstName, $lastName, $email);
//            
//            include('./viewPerson.php');
//        } else {
//            $people = searchPerson($firstName, $lastName, $email);
//            
//            include('./viewPerson.php');
//        } // end if
    } // end if
?>