<?php
    require_once('database.php');
    
    function get_ticket() {
        //query the db
        global $db;
        
        // select all person records
        $select_query = 'SELECT * FROM ticket';
        $statement = $db->prepare($select_query);
        $statement->execute();
        $tickets = $statement->fetchAll();
        $statement->closeCursor();
        
        // return the values
        return $tickets;
    } // end function

    function add_ticket($game_name, $esrb_rating, $genre, $platform) {
        //query the db
        global $db;

        // add the person to the database  
        $ticket_insert_query = 'INSERT INTO ticket (game_name, esrb_rating, genre, platform)
            VALUES (:game_name, :esrb_rating, :genre, :platform)';
        $statement = $db->prepare($ticket_insert_query);
        $statement->bindValue(':game_name', $game_name);
        $statement->bindValue(':esrb_rating', $esrb_rating);
        $statement->bindValue(':genre', $genre);
        $statement->bindValue(':platform', $platform);
        $statement->execute();
        $statement->closeCursor();
    } // end function

    function view_ticket_card($ticket_id) {
        //query the db
        global $db;
        
        // delete the person record from the database
        $viewQuery = 'SELECT * FROM ticket 
                      WHERE ticket_id = :ticket_id';
        $statement = $db->prepare($viewQuery);
        $statement->bindValue(':ticket_id', $ticket_id);
        $statement->execute();
        $ticket = $statement->fetchAll();
        $statement->closeCursor();
        
        // return the values
        return $ticket;
    }
?>