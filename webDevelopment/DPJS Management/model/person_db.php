<?php
    require_once('database.php');
    
    function getPerson() {
        //query the db
        global $db;
        
        // select all person records
        $selectQuery = 'SELECT * FROM person';
        $statement = $db->prepare($selectQuery);
        $statement->execute();
        $people = $statement->fetchAll();
        $statement->closeCursor();
        
        // return the values
        return $people;
    } // end function
    
    function addPerson($firstName, $lastName, $email, $phone) {
        //query the db
        global $db;

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
    } // end function
    
    function updatePerson($person_id, $firstName, $lastName, $email, $phone) {
        //query the db
        global $db;

        // update the person's record in the database 
        $updateQuery = 'UPDATE person
            SET first_name = :first_name, last_name = :last_name, email = :email, phone = :phone
            WHERE person_id = :person_id';
        $statement = $db->prepare($updateQuery);
        $statement->bindValue(':person_id', $person_id);
        $statement->bindValue(':first_name', $firstName);
        $statement->bindValue(':last_name', $lastName);
        $statement->bindValue(':email', $email);
        $statement->bindValue(':phone', $phone);
        $statement->execute();
        $statement->closeCursor();
    } // end function
    
    function deletePerson($person_id) {
        //query the db
        global $db;
        
        // delete the person record from the database
        $deleteQuery = 'DELETE FROM person
            WHERE person_id = :person_id';
        $statement = $db->prepare($deleteQuery);
        $statement->bindValue(':person_id', $person_id);
        $statement->execute();
        $statement->closeCursor();
    } // end function

    function searchPerson($firstName, $lastName, $email) {
        //query the db
        global $db;
        
        // select all person records
        $searchQuery = 'SELECT * FROM person
            WHERE first_name = :first_name
            OR last_name = :last_name
            OR email = :email';
        $statement = $db->prepare($searchQuery);
        $statement->bindValue(':first_name', $firstName);
        $statement->bindValue(':last_name', $lastName);
        $statement->bindValue(':email', $email);
        $statement->execute();
        $people = $statement->fetchAll();
        $statement->closeCursor();
        
        // return the values
        return $people;
    } // end function
    
    function viewIndividual($p_person_id) {
        //query the db
        global $db;
        
        // delete the person record from the database
        $viewQuery = 'SELECT p.first_name, p.last_name, d.major, d.concentration, j.job_title, j.salary, o.name
                      FROM person p
                        LEFT JOIN degree d ON (p.person_id = d.person_id)
                        LEFT JOIN job j ON (p.person_id = j.person_id)
                        LEFT JOIN organization o ON (j.organization_id = o.organization_id)
                      WHERE p.person_id = :p_person_id';
        $statement = $db->prepare($viewQuery);
        $statement->bindValue(':p_person_id', $p_person_id);
        $statement->execute();
        $person = $statement->fetchAll();
        $statement->closeCursor();
        
        // return the values
        return $person;
    } // end function
?>